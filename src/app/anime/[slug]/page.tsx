import { notFound } from 'next/navigation';
import Link from 'next/link';
import { createAnimeSlug } from '@/lib/anime-url';

const THUMBNAILS_BASE = "https://animeify.net/animeify/files/thumbnails/";

interface AnimeDetailsProps {
  params: Promise<{
    slug: string;
  }>;
}

async function getAnimeDetails(slug: string) {
  try {
    // Fetch from Cloudflare Function (server-side, no API exposure)
    const res = await fetch(`${process.env.NEXT_PUBLIC_SITE_URL || 'http://localhost:3000'}/api/anime/${slug}`, {
      cache: 'no-store'
    });
    
    if (!res.ok) {
      console.error(`Failed to fetch anime: ${res.status}`);
      return null;
    }
    
    const json = await res.json();
    return json.success ? json.data : null;
  } catch (error) {
    console.error('Error fetching anime details:', error);
    return null;
  }
}

export default async function AnimeDetailsPage({ params }: AnimeDetailsProps) {
  const { slug } = await params;
  
  const anime = await getAnimeDetails(slug);

  if (!anime) {
    notFound();
  }

  // Calculate average rating from distribution
  const calculateRating = (stats: any) => {
    if (!stats) return 0;
    let totalVotes = 0;
    let totalScore = 0;
    for (let i = 1; i <= 10; i++) {
      const votes = stats[`rates_${i}`] || 0;
      totalVotes += votes;
      totalScore += votes * i;
    }
    return totalVotes > 0 ? (totalScore / totalVotes).toFixed(1) : '0';
  };

  const animeRating = anime.anime_statistics 
    ? calculateRating(anime.anime_statistics) 
    : calculateRating(anime);

  const malScore = anime.Score || 0;
  const studios = anime.Creators ? anime.Creators.split(', ') : [];
  const description = anime.plot || 'لا يوجد وصف متاح.';
  const episodeCount = anime.Episodes || 0;
  const viewCount = anime.views || 0;
  
  // Big title: Always use AR_Title first
  const displayTitle = anime.AR_Title || anime.EN_Title || anime.Synonyms || 'Unknown';
  
  // Small title: Show EN_Title or Synonyms as secondary
  const secondaryTitle = anime.EN_Title || anime.Synonyms || '';

  return (
    <div className="min-h-screen bg-black text-white pt-16">
      {/* Hero Section with Backdrop */}
      <div className="relative w-full h-[60vh] md:h-[70vh] overflow-hidden">
        {/* Backdrop Image */}
        <div className="absolute inset-0">
          <img
            src={`${THUMBNAILS_BASE}${anime.Thumbnail}`}
            alt={anime.EN_Title}
            className="w-full h-full object-cover blur-xl scale-110"
          />
          <div className="absolute inset-0 bg-gradient-to-t from-black via-black/80 to-black/40" />
        </div>

        {/* Content */}
        <div className="relative h-full px-4 md:px-12 lg:px-16 xl:px-24 flex items-end pb-12">
          <div className="flex flex-col md:flex-row gap-6 md:gap-8 w-full">
            {/* Poster */}
            <div className="flex-shrink-0">
              <img
                src={`${THUMBNAILS_BASE}${anime.Thumbnail}`}
                alt={displayTitle}
                className="w-48 md:w-56 lg:w-64 rounded-lg shadow-2xl"
              />
            </div>

            {/* Info */}
            <div className="flex-1 flex flex-col justify-end">
              <h1 className="text-4xl md:text-5xl lg:text-6xl font-bold mb-2 break-words" style={{ fontFamily: 'var(--font-big-titles)', wordBreak: 'break-word', overflowWrap: 'break-word' }}>
                {displayTitle}
              </h1>
              {secondaryTitle && (
                <p className="text-lg md:text-xl text-gray-300 mb-4 break-words" style={{ fontFamily: 'var(--font-normal-text)', wordBreak: 'break-word', overflowWrap: 'break-word' }}>
                  {secondaryTitle}
                </p>
              )}

              {/* Meta Info */}
              <div className="flex flex-wrap items-center gap-4 text-sm md:text-base mb-4">
                {malScore > 0 && (
                  <div className="flex items-center gap-2 bg-yellow-500/20 px-3 py-1 rounded">
                    <span className="text-yellow-500">⭐</span>
                    <span className="font-semibold">{parseFloat(malScore.toString()).toFixed(1)}</span>
                  </div>
                )}
                {animeRating !== '0' && (
                  <div className="flex items-center gap-2 bg-blue-500/20 px-3 py-1 rounded">
                    <span className="text-blue-400">★</span>
                    <span className="font-semibold">{animeRating}/10</span>
                  </div>
                )}
                <span className="px-3 py-1 bg-white/10 rounded">{anime.Type}</span>
                <span className="px-3 py-1 bg-white/10 rounded">{anime.Status}</span>
                {anime.Rating && <span className="px-3 py-1 bg-white/10 rounded">{anime.Rating}</span>}
              </div>

              {/* Genres */}
              {anime.Genres && (
                <div className="flex flex-wrap gap-2 mb-4">
                  {anime.Genres.split(', ').map((genre: string) => (
                    <span key={genre} className="px-3 py-1 bg-white/5 border border-white/20 rounded text-sm">
                      {genre}
                    </span>
                  ))}
                </div>
              )}
            </div>
          </div>
        </div>
      </div>

      {/* Main Content */}
      <div className="px-4 md:px-12 lg:px-16 xl:px-24 py-12">
        <div className="grid grid-cols-1 lg:grid-cols-3 gap-8">
          {/* Left Column - Main Info */}
          <div className="lg:col-span-2 space-y-8">
            {/* Description */}
            <section>
              <h2 className="text-2xl font-bold mb-4" style={{ fontFamily: 'var(--font-big-titles)' }} dir="rtl">
                القصة
              </h2>
              <p className="text-gray-300 leading-relaxed text-lg" style={{ fontFamily: 'var(--font-normal-text)' }} dir="rtl">
                {description}
              </p>
            </section>

            {/* Episodes List */}
            {Array.isArray(anime.Episodes) && anime.Episodes.length > 0 && (
              <section>
                <h2 className="text-2xl font-bold mb-4" style={{ fontFamily: 'var(--font-big-titles)' }} dir="rtl">
                  الحلقات ({anime.Episodes.length})
                </h2>
                <div className="grid grid-cols-2 sm:grid-cols-3 md:grid-cols-4 lg:grid-cols-5 gap-3">
                  {anime.Episodes.map((ep: any) => (
                    <Link
                      key={ep.Episode}
                      href={`/watch/${anime.anime_id || anime.AnimeId}/${ep.Episode}`}
                      className="bg-white/5 hover:bg-white/10 border border-white/10 hover:border-white/30 rounded-lg p-4 text-center transition-all"
                    >
                      <div className="text-sm text-gray-400 mb-1" dir="rtl">الحلقة</div>
                      <div className="text-lg font-semibold">{ep.Episode}</div>
                      {ep.Type !== 'Episode' && (
                        <div className="text-xs text-gray-500 mt-1">{ep.Type}</div>
                      )}
                    </Link>
                  ))}
                </div>
              </section>
            )}

            {/* Related Anime */}
            {anime.related_anime && anime.related_anime.length > 0 && (
              <section>
                <h2 className="text-2xl font-bold mb-4" style={{ fontFamily: 'var(--font-big-titles)' }} dir="rtl">
                  أنمي ذات صلة
                </h2>
                <div className="grid grid-cols-2 sm:grid-cols-3 md:grid-cols-4 gap-4">
                  {anime.related_anime.map((related: any) => {
                    const relatedTitle = related.AR_Title || related.EN_Title || related.Synonyms || '';
                    const relatedSlug = createAnimeSlug(relatedTitle);
                    return (
                    <Link
                      key={related.AnimeId}
                      href={`/anime/${relatedSlug}`}
                      className="group"
                    >
                      <div className="relative aspect-[2/3] bg-black rounded-lg overflow-hidden">
                        <img
                          src={`${THUMBNAILS_BASE}${related.Thumbnail}`}
                          alt={related.AR_Title || related.EN_Title || related.Synonyms}
                          className="w-full h-full object-cover group-hover:scale-105 transition-transform"
                        />
                        <div className="absolute inset-0 bg-gradient-to-t from-black/90 via-transparent to-transparent opacity-0 group-hover:opacity-100 transition-opacity">
                          <div className="absolute bottom-0 left-0 right-0 p-3">
                            <h3 className="text-sm font-semibold text-white line-clamp-2" dir="rtl">
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

          {/* Right Column - Stats & Info */}
          <div className="space-y-6">
            {/* Statistics */}
            <section className="bg-white/5 border border-white/10 rounded-lg p-6">
              <h3 className="text-xl font-bold mb-4" style={{ fontFamily: 'var(--font-big-titles)' }} dir="rtl">
                الإحصائيات
              </h3>
              <div className="space-y-3">
                {viewCount > 0 && (
                  <div className="flex justify-between" dir="rtl">
                    <span className="text-gray-400">المشاهدات</span>
                    <span className="font-semibold">{viewCount.toLocaleString()}</span>
                  </div>
                )}
                {anime.library_favourites && (
                  <div className="flex justify-between" dir="rtl">
                    <span className="text-gray-400">المفضلة</span>
                    <span className="font-semibold">{anime.library_favourites.toLocaleString()}</span>
                  </div>
                )}
                {anime.Rank && (
                  <div className="flex justify-between" dir="rtl">
                    <span className="text-gray-400">الترتيب</span>
                    <span className="font-semibold">#{anime.Rank}</span>
                  </div>
                )}
                {anime.Popularity && (
                  <div className="flex justify-between" dir="rtl">
                    <span className="text-gray-400">الشعبية</span>
                    <span className="font-semibold">#{anime.Popularity}</span>
                  </div>
                )}
              </div>
            </section>

            {/* Information */}
            <section className="bg-white/5 border border-white/10 rounded-lg p-6">
              <h3 className="text-xl font-bold mb-4" style={{ fontFamily: 'var(--font-big-titles)' }} dir="rtl">
                المعلومات
              </h3>
              <div className="space-y-3 text-sm">
                {anime.Type && (
                  <div dir="rtl">
                    <div className="text-gray-400 mb-1">النوع</div>
                    <div className="font-semibold">{anime.Type === 'SERIES' ? 'مسلسل' : anime.Type === 'MOVIE' ? 'فيلم' : anime.Type}</div>
                  </div>
                )}
                {episodeCount > 0 && (
                  <div dir="rtl">
                    <div className="text-gray-400 mb-1">الحلقات</div>
                    <div className="font-semibold">{episodeCount}</div>
                  </div>
                )}
                {anime.Status && (
                  <div dir="rtl">
                    <div className="text-gray-400 mb-1">الحالة</div>
                    <div className="font-semibold">
                      {anime.Status === 'AIRING' ? 'يعرض الآن' : 
                       anime.Status === 'AIRED' ? 'منتهي' : 
                       anime.Status === 'UPCOMING' ? 'قريباً' : anime.Status}
                    </div>
                  </div>
                )}
                {anime.Season && (
                  <div dir="rtl">
                    <div className="text-gray-400 mb-1">الموسم</div>
                    <div className="font-semibold">{anime.Season}</div>
                  </div>
                )}
                {anime.Duration && (
                  <div dir="rtl">
                    <div className="text-gray-400 mb-1">المدة</div>
                    <div className="font-semibold">{anime.Duration}</div>
                  </div>
                )}
                {studios.length > 0 && (
                  <div dir="rtl">
                    <div className="text-gray-400 mb-1">الاستوديو</div>
                    <div className="font-semibold">{studios.join(', ')}</div>
                  </div>
                )}
                {anime.Rating && (
                  <div dir="rtl">
                    <div className="text-gray-400 mb-1">التصنيف العمري</div>
                    <div className="font-semibold">{anime.Rating}</div>
                  </div>
                )}
              </div>
            </section>
          </div>
        </div>
      </div>
    </div>
  );
}
