'use client';

import { useState, useEffect, useRef, useCallback } from 'react';
import Link from 'next/link';
import { Filter, ChevronDown } from 'lucide-react';

interface Anime {
  Id?: string;
  AnimeId?: string;
  anime_id?: string;
  Synonyms?: string;
  EN_Title?: string;
  AR_Title?: string;
  Thumbnail?: string;
  Episodes?: string;
  Type?: string;
  Status?: string;
  Score?: string;
  Premiered?: string;
  Creators?: string;
  Genres?: string;
}

const THUMBNAILS_BASE = "https://animeify.net/animeify/files/thumbnails/";

const GENRES = [
  'Action', 'Adventure', 'Comedy', 'Drama', 'Fantasy', 'Horror',
  'Mystery', 'Psychological', 'Romance', 'Sci-Fi', 'Slice of Life',
  'Sports', 'Supernatural', 'Thriller', 'Mecha', 'Historical',
  'School', 'Military', 'Shounen', 'Shoujo', 'Seinen', 'Josei'
];

const STUDIOS = [
  'Studio Ghibli', 'Toei Animation', 'Madhouse', 'Bones', 'A-1 Pictures',
  'Production I.G', 'Wit Studio', 'Ufotable', 'Kyoto Animation', 'Shaft',
  'J.C.Staff', 'Sunrise', 'Studio Pierrot', 'Trigger', 'MAPPA',
  'Cloverworks', 'David Production', 'White Fox', 'P.A. Works', "Brain's Base"
];

const SEASONS = ['Winter', 'Spring', 'Summer', 'Fall'];
const YEARS = Array.from({ length: 30 }, (_, i) => new Date().getFullYear() - i);

const SORT_OPTIONS = [
  { value: 'POPULAR', label: 'الأكثر شعبية' },
  { value: 'RATING', label: 'الأعلى تقييماً' },
  { value: 'LATEST', label: 'الأحدث' },
  { value: 'NAME', label: 'الاسم' },
  { value: 'EPISODES', label: 'عدد الحلقات' },
];

export default function DiscoverContent() {
  const [animes, setAnimes] = useState<Anime[]>([]);
  const [loading, setLoading] = useState(false);
  const [hasMore, setHasMore] = useState(true);
  const [from, setFrom] = useState(0);
  const [showFilters, setShowFilters] = useState(false);
  const observerTarget = useRef(null);
  
  // Filter states
  const [selectedType, setSelectedType] = useState<string>('');
  const [selectedGenres, setSelectedGenres] = useState<string[]>([]);
  const [selectedStudio, setSelectedStudio] = useState<string>('');
  const [selectedSeason, setSelectedSeason] = useState<string>('');
  const [selectedYear, setSelectedYear] = useState<string>('');
  const [selectedSort, setSelectedSort] = useState<string>('POPULAR');
  const [selectedStatus, setSelectedStatus] = useState<string>('');

  // Dropdown states
  const [genreDropdown, setGenreDropdown] = useState(false);
  const [studioDropdown, setStudioDropdown] = useState(false);
  const [seasonDropdown, setSeasonDropdown] = useState(false);

  const fetchAnimes = useCallback(async (fromValue: number, append: boolean = false) => {
    if (loading) return;
    
    setLoading(true);
    try {
      const params = new URLSearchParams();
      if (selectedType) params.append('type', selectedType);
      if (selectedGenres.length > 0) params.append('genre', selectedGenres[0]);
      if (selectedStudio) params.append('studio', selectedStudio);
      if (selectedSeason && selectedYear) params.append('season', `${selectedSeason} ${selectedYear}`);
      if (selectedStatus) params.append('status', selectedStatus);
      if (selectedSort) params.append('sortBy', selectedSort);
      params.append('from', fromValue.toString());

  const res = await fetch(`/api/browse?${params}`);
      const json = await res.json();
      const newAnimes = json.data || [];
      
      if (append) {
        setAnimes(prev => [...prev, ...newAnimes]);
      } else {
        setAnimes(newAnimes);
      }
      
      setHasMore(newAnimes.length >= 18);
      setFrom(fromValue + 18);
    } catch (error) {
      console.error('Error fetching animes:', error);
    } finally {
      setLoading(false);
    }
  }, [selectedType, selectedGenres, selectedStudio, selectedSeason, selectedYear, selectedSort, selectedStatus, loading]);

  // Reset and fetch when filters change
  useEffect(() => {
    setFrom(0);
    setAnimes([]);
    setHasMore(true);
    fetchAnimes(0, false);
  }, [selectedType, selectedGenres, selectedStudio, selectedSeason, selectedYear, selectedSort, selectedStatus]);

  // Infinite scroll observer
  useEffect(() => {
    const observer = new IntersectionObserver(
      entries => {
        if (entries[0].isIntersecting && hasMore && !loading) {
          fetchAnimes(from, true);
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
  }, [from, hasMore, loading, fetchAnimes]);

  const clearFilters = () => {
    setSelectedType('');
    setSelectedGenres([]);
    setSelectedStudio('');
    setSelectedSeason('');
    setSelectedYear('');
    setSelectedSort('POPULAR');
    setSelectedStatus('');
  };

  const toggleGenre = (genre: string) => {
    setSelectedGenres(prev => 
      prev.includes(genre) ? prev.filter(g => g !== genre) : [genre]
    );
  };

  const activeFiltersCount = [
    selectedType, 
    selectedGenres.length > 0, 
    selectedStudio, 
    selectedSeason, 
    selectedYear, 
    selectedStatus
  ].filter(Boolean).length;

  return (
    <div className="px-4 md:px-12 lg:px-16 xl:px-24 max-w-[1920px] mx-auto pb-20">
      {/* Compact Header */}
      <div className="mb-6 flex items-center justify-between">
        <h1 
          className="text-3xl md:text-4xl font-bold text-white"
          style={{ fontFamily: 'var(--font-big-titles)' }}
        >
          استكشف الأنمي
        </h1>

        {/* Compact Filter Button */}
        <button
          onClick={() => setShowFilters(!showFilters)}
          className="flex items-center gap-2 px-4 py-2 rounded-lg font-semibold transition-all duration-200 bg-white/10 text-white hover:bg-white/20"
          style={{ fontFamily: 'var(--font-normal-text)' }}
        >
          <Filter className="w-4 h-4" />
          <span className="hidden sm:inline">فلتر</span>
          {activeFiltersCount > 0 && (
            <span className="bg-white text-black px-1.5 py-0.5 rounded-full text-xs font-bold">
              {activeFiltersCount}
            </span>
          )}
        </button>
      </div>

      {/* Minimal Compact Filter Panel */}
      {showFilters && (
        <div className="mb-6 bg-white/5 backdrop-blur-sm rounded-lg border border-white/10 p-4">
          <div className="flex items-center justify-between mb-3">
            <h2 
              className="text-lg font-semibold text-white"
              style={{ fontFamily: 'var(--font-big-titles)' }}
            >
              تصفية
            </h2>
            <button
              onClick={clearFilters}
              className="text-gray-400 hover:text-white transition-colors text-sm"
              style={{ fontFamily: 'var(--font-normal-text)' }}
            >
              مسح
            </button>
          </div>

          <div className="grid grid-cols-2 md:grid-cols-3 lg:grid-cols-6 gap-3">
            {/* Type */}
            <select
              value={selectedType}
              onChange={(e) => setSelectedType(e.target.value)}
              className="px-3 py-2 rounded-lg bg-white/10 text-white border border-white/20 outline-none text-sm"
              style={{ fontFamily: 'var(--font-normal-text)' }}
            >
              <option value="">النوع</option>
              <option value="SERIES">مسلسل</option>
              <option value="MOVIE">فيلم</option>
            </select>

            {/* Genre */}
            <div className="relative">
              <button
                onClick={() => setGenreDropdown(!genreDropdown)}
                className="w-full px-3 py-2 rounded-lg bg-white/10 text-white border border-white/20 transition-all flex items-center justify-between text-sm"
                style={{ fontFamily: 'var(--font-normal-text)' }}
              >
                <span className="truncate">{selectedGenres.length > 0 ? selectedGenres[0] : 'التصنيف'}</span>
                <ChevronDown className="w-4 h-4 flex-shrink-0" />
              </button>
              {genreDropdown && (
                <div className="absolute top-full left-0 right-0 mt-1 bg-black/95 backdrop-blur-xl rounded-lg border border-white/10 p-2 max-h-60 overflow-y-auto z-50 shadow-2xl">
                  {GENRES.map((genre) => (
                    <button
                      key={genre}
                      onClick={() => { toggleGenre(genre); setGenreDropdown(false); }}
                      className={`w-full px-3 py-2 rounded text-right transition-all text-sm ${
                        selectedGenres.includes(genre)
                          ? 'bg-white text-black'
                          : 'text-gray-300 hover:bg-white/10'
                      }`}
                      style={{ fontFamily: 'var(--font-normal-text)' }}
                    >
                      {genre}
                    </button>
                  ))}
                </div>
              )}
            </div>

            {/* Studio */}
            <div className="relative">
              <button
                onClick={() => setStudioDropdown(!studioDropdown)}
                className="w-full px-3 py-2 rounded-lg bg-white/10 text-white border border-white/20 transition-all flex items-center justify-between text-sm"
                style={{ fontFamily: 'var(--font-normal-text)' }}
              >
                <span className="truncate">{selectedStudio || 'الاستوديو'}</span>
                <ChevronDown className="w-4 h-4 flex-shrink-0" />
              </button>
              {studioDropdown && (
                <div className="absolute top-full left-0 right-0 mt-1 bg-black/95 backdrop-blur-xl rounded-lg border border-white/10 p-2 max-h-60 overflow-y-auto z-50 shadow-2xl">
                  <button
                    onClick={() => { setSelectedStudio(''); setStudioDropdown(false); }}
                    className="w-full px-3 py-2 rounded text-right text-gray-300 hover:bg-white/10 transition-all text-sm"
                    style={{ fontFamily: 'var(--font-normal-text)' }}
                  >
                    الكل
                  </button>
                  {STUDIOS.map((studio) => (
                    <button
                      key={studio}
                      onClick={() => { setSelectedStudio(studio); setStudioDropdown(false); }}
                      className={`w-full px-3 py-2 rounded text-right transition-all text-sm ${
                        selectedStudio === studio
                          ? 'bg-white text-black'
                          : 'text-gray-300 hover:bg-white/10'
                      }`}
                      style={{ fontFamily: 'var(--font-normal-text)' }}
                    >
                      {studio}
                    </button>
                  ))}
                </div>
              )}
            </div>

            {/* Season */}
            <div className="relative">
              <button
                onClick={() => setSeasonDropdown(!seasonDropdown)}
                className="w-full px-3 py-2 rounded-lg bg-white/10 text-white border border-white/20 transition-all flex items-center justify-between text-sm"
                style={{ fontFamily: 'var(--font-normal-text)' }}
              >
                <span className="truncate">{selectedSeason || 'الموسم'}</span>
                <ChevronDown className="w-4 h-4 flex-shrink-0" />
              </button>
              {seasonDropdown && (
                <div className="absolute top-full left-0 right-0 mt-1 bg-black/95 backdrop-blur-xl rounded-lg border border-white/10 p-2 z-50 shadow-2xl">
                  {SEASONS.map((season) => (
                    <button
                      key={season}
                      onClick={() => { setSelectedSeason(season); setSeasonDropdown(false); }}
                      className={`w-full px-3 py-2 rounded text-right transition-all text-sm ${
                        selectedSeason === season
                          ? 'bg-white text-black'
                          : 'text-gray-300 hover:bg-white/10'
                      }`}
                      style={{ fontFamily: 'var(--font-normal-text)' }}
                    >
                      {season}
                    </button>
                  ))}
                </div>
              )}
            </div>

            {/* Year */}
            <select
              value={selectedYear}
              onChange={(e) => setSelectedYear(e.target.value)}
              className="px-3 py-2 rounded-lg bg-white/10 text-white border border-white/20 outline-none text-sm"
              style={{ fontFamily: 'var(--font-normal-text)' }}
            >
              <option value="">السنة</option>
              {YEARS.map((year) => (
                <option key={year} value={year}>{year}</option>
              ))}
            </select>

            {/* Status */}
            <select
              value={selectedStatus}
              onChange={(e) => setSelectedStatus(e.target.value)}
              className="px-3 py-2 rounded-lg bg-white/10 text-white border border-white/20 outline-none text-sm"
              style={{ fontFamily: 'var(--font-normal-text)' }}
            >
              <option value="">الحالة</option>
              <option value="AIRING">يعرض الآن</option>
              <option value="AIRED">منتهي</option>
              <option value="UPCOMING">قريباً</option>
            </select>
          </div>

          {/* Sort - Horizontal Pills */}
          <div className="mt-3 flex gap-2 overflow-x-auto scrollbar-hide">
            {SORT_OPTIONS.map(({ value, label }) => (
              <button
                key={value}
                onClick={() => setSelectedSort(value)}
                className={`px-4 py-1.5 rounded-full font-semibold transition-all duration-200 flex-shrink-0 text-sm ${
                  selectedSort === value
                    ? 'bg-white text-black'
                    : 'bg-white/10 text-white hover:bg-white/20'
                }`}
                style={{ fontFamily: 'var(--font-normal-text)' }}
              >
                {label}
              </button>
            ))}
          </div>
        </div>
      )}

      {/* Results Grid */}
      {animes.length > 0 ? (
        <>
          <div className="grid grid-cols-2 sm:grid-cols-3 md:grid-cols-4 lg:grid-cols-5 gap-4">
            {animes.map((anime, index) => {
              const animeId = anime.AnimeId || anime.anime_id || '';
              const title = anime.Synonyms || anime.EN_Title || anime.AR_Title || '';
              const thumbnail = anime.Thumbnail || '';
              const type = anime.Type || '';
              const status = anime.Status || '';
              
              // Determine badge text
              let badgeText = '';
              if (type === 'MOVIE') {
                badgeText = 'فيلم';
              } else if (type === 'SERIES') {
                if (status === 'AIRING') {
                  badgeText = 'يعرض الآن';
                } else if (status === 'AIRED') {
                  badgeText = 'منتهي';
                }
              }
              
              return (
                <Link
                  key={`${animeId}-${index}`}
                  href={`/anime/${animeId}`}
                  className="group"
                >
                  <div className="relative aspect-[2/3] bg-white/5 transition-all duration-300 ease-out group-hover:scale-105 group-hover:ring-2 group-hover:ring-white rounded-lg overflow-hidden">
                    {thumbnail && (
                      <img
                        src={THUMBNAILS_BASE + thumbnail}
                        alt={title}
                        className="w-full h-full object-cover"
                        loading="lazy"
                      />
                    )}
                    
                    {/* Overlay */}
                    <div className="absolute inset-0 bg-gradient-to-t from-black/90 via-transparent to-transparent opacity-0 group-hover:opacity-100 transition-opacity duration-300">
                      <div className="absolute bottom-0 left-0 right-0 p-3">
                        <h3 
                          className="text-white text-sm font-semibold line-clamp-2"
                          style={{ fontFamily: 'var(--font-normal-text)' }}
                        >
                          {title}
                        </h3>
                      </div>
                    </div>

                    {/* Unified Badge */}
                    {badgeText && (
                      <div className="absolute top-2 right-2 bg-black/80 backdrop-blur-sm px-2 py-1 rounded text-xs text-white font-semibold">
                        {badgeText}
                      </div>
                    )}
                  </div>
                </Link>
              );
            })}
          </div>
          
          {/* Loading indicator for infinite scroll */}
          <div ref={observerTarget} className="mt-8 flex justify-center">
            {loading && (
              <div className="flex gap-2">
                <div className="w-2 h-2 bg-white rounded-full animate-bounce" style={{ animationDelay: '0ms' }} />
                <div className="w-2 h-2 bg-white rounded-full animate-bounce" style={{ animationDelay: '150ms' }} />
                <div className="w-2 h-2 bg-white rounded-full animate-bounce" style={{ animationDelay: '300ms' }} />
              </div>
            )}
          </div>
        </>
      ) : !loading ? (
        <div className="text-center py-20">
          <p className="text-gray-400 text-xl" style={{ fontFamily: 'var(--font-normal-text)' }}>
            لم يتم العثور على نتائج
          </p>
        </div>
      ) : (
        <div className="grid grid-cols-2 sm:grid-cols-3 md:grid-cols-4 lg:grid-cols-5 gap-4">
          {Array.from({ length: 18 }).map((_, i) => (
            <div key={i} className="aspect-[2/3] bg-white/5 rounded-lg animate-pulse" />
          ))}
        </div>
      )}
    </div>
  );
}
