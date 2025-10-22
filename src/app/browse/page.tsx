'use client';

import { useState, useEffect, useRef, useCallback } from 'react';
import { useSearchParams } from 'next/navigation';
import Link from 'next/link';

const API_URL = process.env.NEXT_PUBLIC_API_URL || 'https://witanime-api-worker.abdellah2019gg.workers.dev';
const THUMBNAILS_BASE = "https://animeify.net/animeify/files/thumbnails/";

interface Anime {
  AnimeId: string;
  Synonyms: string;
  EN_Title: string;
  AR_Title: string;
  Thumbnail: string;
  Type: string;
  Episodes: string;
  Score: string;
  Status: string;
  Genres: string;
  Premiered: string;
}

export default function BrowsePage() {
  const searchParams = useSearchParams();
  const typeParam = searchParams.get('type');
  
  const [animeList, setAnimeList] = useState<Anime[]>([]);
  const [loading, setLoading] = useState(true);
  const [hasMore, setHasMore] = useState(true);
  const [from, setFrom] = useState(0);
  const [activeTab, setActiveTab] = useState<'SERIES' | 'MOVIE'>((typeParam?.toUpperCase() === 'MOVIE' ? 'MOVIE' : 'SERIES') as 'SERIES' | 'MOVIE');
  const [selectedGenre, setSelectedGenre] = useState<string>('');
  const observerTarget = useRef(null);

  // Update activeTab when URL changes
  useEffect(() => {
    if (typeParam) {
      const newTab = typeParam.toUpperCase() === 'MOVIE' ? 'MOVIE' : 'SERIES';
      setActiveTab(newTab as 'SERIES' | 'MOVIE');
    }
  }, [typeParam]);

  const genres = [
    'Action', 'Adventure', 'Comedy', 'Drama', 'Fantasy', 'Horror',
    'Mystery', 'Romance', 'Sci-Fi', 'Slice of Life', 'Sports',
    'Supernatural', 'Thriller', 'Psychological'
  ];

  // Fetch anime based on type and genre
  const fetchAnime = useCallback(async (type: string, genre: string, fromIndex: number, append: boolean = false) => {
    setLoading(true);
    try {
      const params = new URLSearchParams();
      params.append('type', type);
      if (genre) {
        params.append('genre', genre);
      }
      params.append('from', fromIndex.toString());

      const response = await fetch(`${API_URL}/api/browse?${params}`);
      const data = await response.json();

      if (data.status === 'success') {
        if (append) {
          setAnimeList(prev => [...prev, ...data.data]);
        } else {
          setAnimeList(data.data);
        }
        setHasMore(data.pagination.hasMore);
      }
    } catch (error) {
      console.error('Error fetching anime:', error);
    } finally {
      setLoading(false);
    }
  }, []);

  // Initial load
  useEffect(() => {
    setAnimeList([]);
    setFrom(0);
    setHasMore(true);
    fetchAnime(activeTab, selectedGenre, 0, false);
  }, [activeTab, selectedGenre, fetchAnime]);

  // Infinite scroll observer
  useEffect(() => {
    const observer = new IntersectionObserver(
      entries => {
        if (entries[0].isIntersecting && hasMore && !loading) {
          const nextFrom = from + 20;
          setFrom(nextFrom);
          fetchAnime(activeTab, selectedGenre, nextFrom, true);
        }
      },
      { threshold: 0.1 }
    );

    if (observerTarget.current) {
      observer.observe(observerTarget.current);
    }

    return () => {
      if (observerTarget.current) {
        observer.unobserve(observerTarget.current);
      }
    };
  }, [hasMore, loading, from, activeTab, selectedGenre, fetchAnime]);

  return (
    <div className="min-h-screen pt-[70px] pb-16" dir="rtl">
      {/* Genre Filters */}
      <div className="bg-gradient-to-b from-black via-black/95 to-black/90 border-b border-gray-800/30 py-8">
        <div className="px-4 md:px-12 lg:px-16">
          <h3 className="text-lg font-semibold text-white mb-4" style={{ fontFamily: 'var(--font-normal-text)' }}>التصنيفات</h3>
          <div className="flex items-center gap-3 overflow-x-auto scrollbar-hide pb-2">
            <button
              onClick={() => setSelectedGenre('')}
              className={`px-6 py-2.5 text-sm whitespace-nowrap transition-all rounded-lg flex-shrink-0 font-medium ${
                selectedGenre === ''
                  ? 'bg-white text-black shadow-lg scale-105'
                  : 'bg-white/5 text-gray-300 border border-gray-700/50 hover:border-gray-500 hover:bg-white/10'
              }`}
              style={{ fontFamily: 'var(--font-normal-text)' }}
            >
              الكل
            </button>
            {genres.map(genre => (
              <button
                key={genre}
                onClick={() => setSelectedGenre(genre)}
                className={`px-6 py-2.5 text-sm whitespace-nowrap transition-all rounded-lg flex-shrink-0 font-medium ${
                  selectedGenre === genre
                    ? 'bg-white text-black shadow-lg scale-105'
                    : 'bg-white/5 text-gray-300 border border-gray-700/50 hover:border-gray-500 hover:bg-white/10'
                }`}
                style={{ fontFamily: 'var(--font-normal-text)' }}
              >
                {genre}
              </button>
            ))}
          </div>
        </div>
      </div>

      {/* Anime Grid */}
      <div className="px-4 md:px-12 lg:px-16 mt-10 mb-12">
        {animeList.length === 0 && !loading ? (
          <div className="text-center py-20">
            <p className="text-2xl text-gray-400" style={{ fontFamily: 'var(--font-normal-text)' }}>لا توجد نتائج</p>
          </div>
        ) : (
          <div className="grid grid-cols-2 sm:grid-cols-3 md:grid-cols-4 lg:grid-cols-5 gap-3 md:gap-4 py-2">
            {animeList.map((anime) => (
              <Link
                key={anime.AnimeId}
                href={`/anime/${anime.AnimeId}`}
                className="group p-1"
              >
                <div className="relative aspect-[2/3] bg-black transition-all duration-300 ease-out group-hover:scale-105 group-hover:ring-2 group-hover:ring-white/80 rounded-md">
                  <div className="absolute inset-0 overflow-hidden rounded-md">
                    <img
                      src={`${THUMBNAILS_BASE}${anime.Thumbnail}`}
                      alt={anime.Synonyms || anime.EN_Title || anime.AR_Title}
                      className="w-full h-full object-cover"
                    />
                    
                    {/* Hover overlay with title at bottom */}
                    <div className="absolute inset-0 bg-gradient-to-t from-black/90 via-transparent to-transparent opacity-0 group-hover:opacity-100 transition-opacity duration-300">
                      {anime.Score && parseFloat(anime.Score) > 0 && (
                        <div className="absolute top-3 left-3 bg-yellow-500/95 text-black px-3 py-1.5 text-sm font-bold rounded" style={{ fontFamily: 'var(--font-normal-text)' }}>
                          ⭐ {parseFloat(anime.Score).toFixed(1)}
                        </div>
                      )}
                      <div className="absolute bottom-0 left-0 right-0 p-4">
                        <h3 className="text-base font-semibold text-white line-clamp-2" style={{ fontFamily: 'var(--font-normal-text)' }}>
                          {anime.Synonyms || anime.EN_Title || anime.AR_Title}
                        </h3>
                        {anime.Episodes && (
                          <p className="text-sm text-gray-300 mt-1" style={{ fontFamily: 'var(--font-normal-text)' }}>
                            {anime.Episodes} حلقة
                          </p>
                        )}
                      </div>
                    </div>
                  </div>
                </div>
              </Link>
            ))}
          </div>
        )}

        {/* Loading Spinner */}
        {loading && (
          <div className="flex justify-center items-center py-12">
            <div className="animate-spin rounded-full h-12 w-12 border-t-2 border-b-2 border-white/50"></div>
          </div>
        )}

        {/* Intersection Observer Target */}
        {hasMore && !loading && <div ref={observerTarget} className="h-10" />}

        {/* End Message */}
        {!hasMore && animeList.length > 0 && (
          <p className="text-center text-gray-400 mt-12 mb-8" style={{ fontFamily: 'var(--font-normal-text)' }}>
            لا توجد المزيد من النتائج
          </p>
        )}
      </div>
    </div>
  );
}
