export const runtime = 'edge'
export const dynamic = 'force-dynamic'

import { notFound } from 'next/navigation';
import Link from 'next/link';
import { getCompleteAnimeDataByTitle } from '@/lib/animeify-api';
import { slugToTitle, createAnimeUrl } from '@/lib/slug';

interface AnimePageProps {
  params: Promise<{
    slug: string;
  }>;
  searchParams: Promise<{
    name?: string;
    type?: string;
  }>;
}

const THUMBNAILS_BASE = 'https://animeify.net/animeify/files/thumbnails/';

export default async function AnimePage({ params, searchParams }: AnimePageProps) {
  const { slug } = await params;
  const { name, type } = await searchParams;
  
  // CRITICAL: Always use 'name' query param if available (most reliable)
  // Only fall back to slug conversion if name is missing
  const searchTitle = name || slugToTitle(slug);
  const animeType = type || 'SERIES';
  
  console.log('AnimePage - slug:', slug, 'name:', name, 'searchTitle:', searchTitle, 'type:', animeType);
  
  try {
    // Fetch complete anime data with title and type
    const data = await getCompleteAnimeDataByTitle(searchTitle, animeType);
    
    console.log('AnimePage - data found:', !!data, 'anime:', !!data?.anime);
    
    if (!data || !data.anime) {
      console.error('AnimePage - 404: No data found for', searchTitle, animeType);
      notFound();
    }

    const { anime, details, episodes } = data;

  // Calculate average rating
  const calculateRating = () => {
    if (!details?.AnimeStatistics) return '0';
    
    let totalVotes = 0;
    let totalScore = 0;
    
    for (let i = 1; i <= 10; i++) {
      const key = `rates_${i}` as keyof typeof details.AnimeStatistics;
      const votes = parseInt(details.AnimeStatistics[key] as string) || 0;
      totalVotes += votes;
      totalScore += votes * i;
    }
    
    return totalVotes > 0 ? (totalScore / totalVotes).toFixed(1) : '0';
  };

  const userRating = calculateRating();
  const malScore = anime.Score ? parseFloat(anime.Score).toFixed(1) : '0';
  
  // Display Arabic title if available, otherwise English
  const displayTitle = anime.AR_Title || anime.EN_Title || anime.Synonyms || 'Unknown';
  
  // Only show secondary title if it's different from display title
  const secondaryTitle = anime.AR_Title && anime.EN_Title && anime.AR_Title !== anime.EN_Title 
    ? anime.EN_Title 
    : '';
  
  const description = details?.Plot || 'لا يوجد وصف متاح.';
  const viewCount = details?.AnimeStatistics?.views ? parseInt(details.AnimeStatistics.views) : 0;
  const genres = anime.Genres ? anime.Genres.split(', ') : [];

  return (
    <div className="min-h-screen bg-black text-white">
      {/* Hero Section */}
      <div className="relative w-full pt-32 pb-12">
        {/* Backdrop */}
        <div className="absolute inset-0">
          <img
            src={`${THUMBNAILS_BASE}${anime.Thumbnail}`}
            alt={displayTitle}
            className="w-full h-full object-cover opacity-20"
          />
          <div className="absolute inset-0 bg-gradient-to-b from-black via-black/90 to-black" />
        </div>

        {/* Hero Content */}
        <div className="relative container mx-auto px-4 md:px-8 lg:px-16">
          <div className="flex flex-col lg:flex-row gap-8">
            {/* Poster */}
            <div className="flex-shrink-0">
              <img
                src={`${THUMBNAILS_BASE}${anime.Thumbnail}`}
                alt={displayTitle}
                className="w-48 lg:w-64 rounded-lg shadow-2xl"
              />
            </div>

            {/* Info Section */}
            <div className="flex-1 space-y-4">
              {/* Title */}
              <div>
                <h1 className="text-3xl md:text-4xl font-bold mb-1" style={{ fontFamily: 'var(--font-big-titles)' }} dir="rtl">
                  {displayTitle}
                </h1>
                {secondaryTitle && (
                  <p className="text-lg text-gray-400" style={{ fontFamily: 'var(--font-normal-text)' }}>
                    {secondaryTitle}
                  </p>
                )}
              </div>

              {/* Ratings & Meta */}
              <div className="flex flex-wrap items-center gap-3 text-sm">
                {malScore !== '0' && (
                  <div className="flex items-center gap-1.5">
                    <span className="text-yellow-400">⭐</span>
                    <span className="font-semibold">{malScore}</span>
                  </div>
                )}
                
                <span className="text-gray-400">•</span>
                <span>{anime.Type}</span>
                
                {anime.Episodes && (
                  <>
                    <span className="text-gray-400">•</span>
                    <span>{anime.Episodes} حلقة</span>
                  </>
                )}
                
                {anime.Status && (
                  <>
                    <span className="text-gray-400">•</span>
                    <span>{anime.Status === 'AIRED' ? 'منتهي' : anime.Status === 'AIRING' ? 'يعرض الآن' : anime.Status}</span>
                  </>
                )}
              </div>

              {/* Genres */}
              {genres.length > 0 && (
                <div className="flex flex-wrap gap-2">
                  {genres.map((genre: string) => (
                    <span
                      key={genre}
                      className="px-3 py-1 bg-white/10 rounded text-xs"
                    >
                      {genre}
                    </span>
                  ))}
                </div>
              )}

              {/* Plot */}
              <div>
                <h2 className="text-lg font-semibold mb-2" dir="rtl">القصة</h2>
                <p className="text-gray-300 text-sm leading-relaxed" dir="rtl">
                  {description}
                </p>
              </div>

              {/* Information */}
              <div className="grid grid-cols-2 md:grid-cols-3 gap-4 text-sm">
                {anime.Premiered && (
                  <div>
                    <div className="text-gray-400 text-xs mb-1">العرض الأول</div>
                    <div className="font-medium">{anime.Premiered}</div>
                  </div>
                )}
                {anime.Duration && (
                  <div>
                    <div className="text-gray-400 text-xs mb-1">المدة</div>
                    <div className="font-medium">{anime.Duration} دقيقة</div>
                  </div>
                )}
                {anime.Creators && (
                  <div>
                    <div className="text-gray-400 text-xs mb-1">الاستوديو</div>
                    <div className="font-medium">{anime.Creators}</div>
                  </div>
                )}
              </div>
            </div>
          </div>
        </div>
      </div>

      {/* Main Content - Episodes and Related Anime */}
      <div className="container mx-auto px-4 md:px-8 lg:px-16 pb-12 space-y-8">
        {/* Episodes */}
        {episodes && episodes.length > 0 && (
          <section className="space-y-4">
            <h2 className="text-2xl font-semibold" style={{ fontFamily: 'var(--font-big-titles)' }} dir="rtl">
              الحلقات ({episodes.length})
            </h2>
            <div className="max-h-[400px] overflow-y-auto pr-2 scrollbar-thin scrollbar-thumb-white/20 scrollbar-track-transparent">
              <div className="grid grid-cols-4 sm:grid-cols-6 md:grid-cols-8 lg:grid-cols-10 xl:grid-cols-12 gap-2">
                {episodes.map((ep: any) => (
                  <Link
                    key={ep.eId}
                    href={`/anime/${slug}/watch/${ep.Episode}?name=${encodeURIComponent(searchTitle)}&type=${animeType}`}
                    className="relative bg-white/5 hover:bg-white/10 border border-white/10 hover:border-white/30 rounded-lg p-3 text-center transition-all cursor-pointer block"
                  >
                    <div className="text-base font-semibold">{ep.Episode}</div>
                    {ep.MarkedAs === 'LAST' && (
                      <div className="absolute -top-1 -right-1 bg-red-500 text-white text-xs px-1.5 py-0.5 rounded-full">
                        ✓
                      </div>
                    )}
                  </Link>
                ))}
              </div>
            </div>
          </section>
        )}

        {/* Related Anime */}
        {details?.RelatedAnime && details.RelatedAnime.length > 0 && (
          <section className="space-y-4">
            <h2 className="text-2xl font-semibold" style={{ fontFamily: 'var(--font-big-titles)' }} dir="rtl">
              أنمي ذات صلة
            </h2>
            <div className="grid grid-cols-2 sm:grid-cols-3 md:grid-cols-4 lg:grid-cols-5 xl:grid-cols-6 gap-4">
              {details.RelatedAnime.map((related: any) => {
                const relatedUrl = createAnimeUrl(related);
                return (
                  <Link
                    key={related.AnimeId}
                    href={relatedUrl}
                    className="group relative"
                  >
                    <div className="relative aspect-[2/3] bg-gray-900 rounded-lg overflow-hidden border-2 border-white/10 group-hover:border-white/30 transition-all">
                      <img
                        src={`${THUMBNAILS_BASE}${related.Thumbnail}`}
                        alt={related.EN_Title || related.AR_Title}
                        className="w-full h-full object-cover group-hover:scale-105 transition-transform duration-300"
                      />
                      <div className="absolute inset-0 bg-gradient-to-t from-black/80 via-transparent to-transparent opacity-0 group-hover:opacity-100 transition-opacity">
                        <div className="absolute bottom-0 left-0 right-0 p-3">
                          <h3 className="text-sm font-bold text-white line-clamp-2" dir="rtl">
                            {related.AR_Title || related.EN_Title || related.Synonyms}
                          </h3>
                        </div>
                      </div>
                    </div>
                  </Link>
                );
              })}
            </div>
          </section>
        )}
      </div>
    </div>
  );
  } catch (error) {
    console.error('AnimePage - Error loading anime data:', error);
    notFound();
  }
}
