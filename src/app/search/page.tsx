'use client';

import { useState, useEffect, useRef, useCallback, Suspense } from 'react';
import { useSearchParams } from 'next/navigation';
import Link from 'next/link';
import { Search as SearchIcon, X, SlidersHorizontal } from 'lucide-react';

const API_URL = process.env.NEXT_PUBLIC_API_URL || '';
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

function SearchPageContent() {
  const searchParams = useSearchParams();
  const [searchQuery, setSearchQuery] = useState('');
  const [animeList, setAnimeList] = useState<Anime[]>([]);
  const [loading, setLoading] = useState(false);
  const [hasMore, setHasMore] = useState(true);
  const [from, setFrom] = useState(0);
  const [showFilters, setShowFilters] = useState(false);
  const observerTarget = useRef(null);

  // Initialize search query from URL
  useEffect(() => {
    const query = searchParams.get('q');
    if (query) {
      setSearchQuery(query);
    }
  }, [searchParams]);

  // Filter states
  const [selectedTypes, setSelectedTypes] = useState<string[]>([]);
  const [selectedGenres, setSelectedGenres] = useState<string[]>([]);
  const [selectedStatus, setSelectedStatus] = useState<string[]>([]);

  const genres = [
    'Action', 'Adventure', 'Comedy', 'Drama', 'Fantasy', 'Horror',
    'Mystery', 'Romance', 'Sci-Fi', 'Slice of Life', 'Sports',
    'Supernatural', 'Thriller', 'Psychological', 'Ecchi', 'Shounen',
    'Shoujo', 'Seinen', 'Magic', 'Mecha', 'School', 'Music'
  ];

  const types = ['SERIES', 'MOVIE', 'OVA', 'SPECIAL', 'ONA'];
  const statuses = ['AIRING', 'AIRED', 'UPCOMING'];

  const typeLabels: Record<string, string> = {
    'SERIES': 'مسلسل',
    'MOVIE': 'فيلم',
    'OVA': 'OVA',
    'SPECIAL': 'خاص',
    'ONA': 'ONA'
  };

  const statusLabels: Record<string, string> = {
    'AIRING': 'يعرض الآن',
    'AIRED': 'منتهي',
    'UPCOMING': 'قريباً'
  };

  // Fetch anime
  const fetchAnime = useCallback(async (query: string, fromIndex: number, append: boolean = false) => {
    if (!query.trim()) {
      setAnimeList([]);
      return;
    }

    setLoading(true);
    try {
      const params = new URLSearchParams();
      params.append('q', query);
      params.append('from', fromIndex.toString());
      
      if (selectedTypes.length > 0) {
        params.append('type', selectedTypes[0]); // API supports single type
      }

      const response = await fetch(`${API_URL}/api/search?${params}`);
      const data = await response.json();

      if (data.status === 'success') {
        let results = data.data || [];

        // Client-side filtering for multiple selections
        if (selectedGenres.length > 0) {
          results = results.filter((anime: Anime) =>
            selectedGenres.some(genre => anime.Genres?.includes(genre))
          );
        }

        if (selectedStatus.length > 0) {
          results = results.filter((anime: Anime) =>
            selectedStatus.includes(anime.Status)
          );
        }

        if (selectedTypes.length > 1) {
          results = results.filter((anime: Anime) =>
            selectedTypes.includes(anime.Type)
          );
        }

        if (append) {
          setAnimeList(prev => [...prev, ...results]);
        } else {
          setAnimeList(results);
        }
        setHasMore(data.pagination?.hasMore && results.length >= 20);
      }
    } catch (error) {
      console.error('Error searching anime:', error);
    } finally {
      setLoading(false);
    }
  }, [selectedTypes, selectedGenres, selectedStatus]);

  // Search when query or filters change
  useEffect(() => {
    setFrom(0);
    setHasMore(true);
    fetchAnime(searchQuery, 0, false);
  }, [searchQuery, selectedTypes, selectedGenres, selectedStatus, fetchAnime]);

  // Infinite scroll
  useEffect(() => {
    const observer = new IntersectionObserver(
      entries => {
        if (entries[0].isIntersecting && hasMore && !loading && searchQuery.trim()) {
          const nextFrom = from + 20;
          setFrom(nextFrom);
          fetchAnime(searchQuery, nextFrom, true);
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
  }, [hasMore, loading, from, searchQuery, fetchAnime]);

  const toggleFilter = (category: 'type' | 'genre' | 'status', value: string) => {
    if (category === 'type') {
      setSelectedTypes(prev =>
        prev.includes(value) ? prev.filter(t => t !== value) : [...prev, value]
      );
    } else if (category === 'genre') {
      setSelectedGenres(prev =>
        prev.includes(value) ? prev.filter(g => g !== value) : [...prev, value]
      );
    } else if (category === 'status') {
      setSelectedStatus(prev =>
        prev.includes(value) ? prev.filter(s => s !== value) : [...prev, value]
      );
    }
  };

  const clearAllFilters = () => {
    setSelectedTypes([]);
    setSelectedGenres([]);
    setSelectedStatus([]);
  };

  const activeFiltersCount = selectedTypes.length + selectedGenres.length + selectedStatus.length;

  return (
    <div className="min-h-screen pt-[70px] pb-16" dir="rtl">
      {/* Search Bar */}
      <div className="bg-black border-b border-gray-800/50">
        <div className="px-4 md:px-12 lg:px-16 py-6">
          <div className="flex gap-4 items-center max-w-3xl">
            <div className="flex-1 relative">
              <SearchIcon className="absolute right-4 top-1/2 -translate-y-1/2 w-5 h-5 text-gray-400" />
              <input
                type="text"
                value={searchQuery}
                onChange={(e) => setSearchQuery(e.target.value)}
                placeholder="ابحث عن أنمي..."
                className="w-full bg-white/10 border border-white/20 pr-12 pl-4 py-3 text-white placeholder-gray-400 focus:outline-none focus:bg-white/15 focus:border-white/30 transition-all rounded"
                style={{ fontFamily: 'var(--font-normal-text)' }}
              />
              {searchQuery && (
                <button
                  onClick={() => setSearchQuery('')}
                  className="absolute left-4 top-1/2 -translate-y-1/2 text-gray-400 hover:text-white"
                >
                  <X className="w-5 h-5" />
                </button>
              )}
            </div>
            <button
              onClick={() => setShowFilters(!showFilters)}
              className={`flex items-center gap-2 px-5 py-3 transition-all rounded ${
                showFilters || activeFiltersCount > 0
                  ? 'bg-white text-black'
                  : 'bg-white/10 text-gray-300 hover:bg-white/20'
              }`}
              style={{ fontFamily: 'var(--font-normal-text)' }}
            >
              <SlidersHorizontal className="w-5 h-5" />
              <span className="hidden md:inline text-sm">فلاتر</span>
              {activeFiltersCount > 0 && (
                <span className="px-2 py-0.5 bg-black/20 text-xs font-bold rounded-full">
                  {activeFiltersCount}
                </span>
              )}
            </button>
          </div>
        </div>
      </div>

      {/* Filters Panel */}
      {showFilters && (
        <div className="bg-black/60 backdrop-blur-sm border-b border-white/10">
          <div className="px-4 md:px-12 lg:px-16 py-6">
            <div className="flex items-center justify-between mb-6">
              <h3 className="text-lg font-medium" style={{ fontFamily: 'var(--font-normal-text)' }}>الفلاتر</h3>
              {activeFiltersCount > 0 && (
                <button
                  onClick={clearAllFilters}
                  className="text-sm text-white/70 hover:text-white flex items-center gap-1 transition-colors"
                  style={{ fontFamily: 'var(--font-normal-text)' }}
                >
                  <X className="w-4 h-4" />
                  مسح الكل
                </button>
              )}
            </div>

            <div className="space-y-6">
              {/* Type Filters */}
              <div>
                <h4 className="text-sm text-gray-400 mb-3" style={{ fontFamily: 'var(--font-normal-text)' }}>النوع</h4>
                <div className="flex flex-wrap gap-2">
                  {types.map(type => (
                    <button
                      key={type}
                      onClick={() => toggleFilter('type', type)}
                      className={`px-4 py-2 text-sm transition-all rounded-full ${
                        selectedTypes.includes(type)
                          ? 'bg-white text-black font-medium'
                          : 'bg-white/10 text-gray-300 hover:bg-white/20'
                      }`}
                      style={{ fontFamily: 'var(--font-normal-text)' }}
                    >
                      {typeLabels[type]}
                    </button>
                  ))}
                </div>
              </div>

              {/* Status Filters */}
              <div>
                <h4 className="text-sm text-gray-400 mb-3" style={{ fontFamily: 'var(--font-normal-text)' }}>الحالة</h4>
                <div className="flex flex-wrap gap-2">
                  {statuses.map(status => (
                    <button
                      key={status}
                      onClick={() => toggleFilter('status', status)}
                      className={`px-4 py-2 text-sm transition-all rounded-full ${
                        selectedStatus.includes(status)
                          ? 'bg-white text-black font-medium'
                          : 'bg-white/10 text-gray-300 hover:bg-white/20'
                      }`}
                      style={{ fontFamily: 'var(--font-normal-text)' }}
                    >
                      {statusLabels[status]}
                    </button>
                  ))}
                </div>
              </div>

              {/* Genre Filters */}
              <div>
                <h4 className="text-sm text-gray-400 mb-3" style={{ fontFamily: 'var(--font-normal-text)' }}>التصنيفات</h4>
                <div className="flex flex-wrap gap-2">
                  {genres.map(genre => (
                    <button
                      key={genre}
                      onClick={() => toggleFilter('genre', genre)}
                      className={`px-4 py-2 text-sm transition-all rounded-full ${
                        selectedGenres.includes(genre)
                          ? 'bg-white text-black font-medium'
                          : 'bg-white/10 text-gray-300 hover:bg-white/20'
                      }`}
                      style={{ fontFamily: 'var(--font-normal-text)' }}
                    >
                      {genre}
                    </button>
                  ))}
                </div>
              </div>
            </div>
          </div>
        </div>
      )}

      {/* Results */}
      <div className="px-4 md:px-12 lg:px-16 mt-10 mb-12">
        {!searchQuery.trim() ? (
          <div className="text-center py-20">
            <SearchIcon className="w-16 h-16 text-gray-600 mx-auto mb-4" />
            <p className="text-xl text-gray-300" style={{ fontFamily: 'var(--font-normal-text)' }}>ابحث عن الأنمي المفضل لديك</p>
            <p className="text-sm text-gray-500 mt-2" style={{ fontFamily: 'var(--font-normal-text)' }}>استخدم الفلاتر لتحسين نتائج البحث</p>
          </div>
        ) : animeList.length === 0 && !loading ? (
          <div className="text-center py-20">
            <p className="text-2xl text-gray-300" style={{ fontFamily: 'var(--font-normal-text)' }}>لا توجد نتائج</p>
            <p className="text-sm text-gray-500 mt-2" style={{ fontFamily: 'var(--font-normal-text)' }}>جرب كلمات بحث أخرى أو فلاتر مختلفة</p>
          </div>
        ) : (
          <>
            <div className="mb-8">
              <p className="text-gray-400 text-sm" style={{ fontFamily: 'var(--font-normal-text)' }}>
                {animeList.length} نتيجة
              </p>
            </div>

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
          </>
        )}
      </div>
    </div>
  );
}

export default function SearchPage() {
  return (
    <Suspense fallback={
      <div className="min-h-screen pt-[70px] pb-16" dir="rtl">
        <div className="bg-black border-b border-gray-800/50">
          <div className="px-4 md:px-12 lg:px-16 py-6">
            <div className="flex gap-4 items-center max-w-3xl">
              <div className="flex-1 relative">
                <SearchIcon className="absolute right-4 top-1/2 -translate-y-1/2 w-5 h-5 text-gray-400" />
                <input
                  type="text"
                  placeholder="ابحث عن أنمي..."
                  className="w-full bg-white/10 border border-white/20 pr-12 pl-4 py-3 text-white placeholder-gray-400 focus:outline-none focus:bg-white/15 focus:border-white/30 transition-all rounded"
                  style={{ fontFamily: 'var(--font-normal-text)' }}
                />
              </div>
            </div>
          </div>
        </div>
        <div className="px-4 md:px-12 lg:px-16 mt-10 mb-12">
          <div className="text-center py-20">
            <SearchIcon className="w-16 h-16 text-gray-600 mx-auto mb-4" />
            <p className="text-xl text-gray-300" style={{ fontFamily: 'var(--font-normal-text)' }}>ابحث عن الأنمي المفضل لديك</p>
          </div>
        </div>
      </div>
    }>
      <SearchPageContent />
    </Suspense>
  );
}
