import { notFound } from 'next/navigation';
import Link from 'next/link';
import { getCompleteAnimeDataByTitle } from '@/lib/animeify-api';
import { slugToTitle, createAnimeUrl } from '@/lib/slug';

export const runtime = 'edge';

interface AnimePageProps {
  params: Promise<{
    slug: string;
  }>;
  searchParams: Promise<{
    type?: string;
  }>;
}

const THUMBNAILS_BASE = 'https://animeify.net/animeify/files/thumbnails/';

export default async function AnimePage({ params, searchParams }: AnimePageProps) {
  const { slug } = await params;
  const { type } = await searchParams;
  
  // Convert slug to title: "one-piece" -> "One Piece"
  const searchTitle = slugToTitle(slug);
  const animeType = type || 'SERIES';
  
  // Fetch complete anime data with title and type
  const data = await getCompleteAnimeDataByTitle(searchTitle, animeType);
  
  if (!data || !data.anime) {
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
  const displayTitle = anime.AR_Title || anime.EN_Title || anime.Synonyms || 'Unknown';
  const secondaryTitle = anime.EN_Title || anime.Synonyms || '';
  const description = details?.Plot || 'لا يوجد وصف متاح.';
  const viewCount = details?.AnimeStatistics?.views ? parseInt(details.AnimeStatistics.views) : 0;
  const genres = anime.Genres ? anime.Genres.split(', ') : [];

  return (
    <div className="min-h-screen bg-gradient-to-b from-black via-gray-900 to-black text-white">
      {/* Hero Section */}
      <div className="relative w-full h-[70vh] overflow-hidden">
        {/* Backdrop */}
        <div className="absolute inset-0">
          <img
            src={`${THUMBNAILS_BASE}${anime.Thumbnail}`}
            alt={displayTitle}
            className="w-full h-full object-cover blur-2xl scale-110 opacity-40"
          />
          <div className="absolute inset-0 bg-gradient-to-t from-black via-black/80 to-transparent" />
          <div className="absolute inset-0 bg-gradient-to-r from-black/90 via-transparent to-black/90" />
        </div>

        {/* Content */}
        <div className="relative h-full container mx-auto px-4 md:px-8 lg:px-16 flex items-end pb-12">
          <div className="flex flex-col md:flex-row gap-8 w-full">
            {/* Poster */}
            <div className="flex-shrink-0">
              <div className="relative group">
                <img
                  src={`${THUMBNAILS_BASE}${anime.Thumbnail}`}
                  alt={displayTitle}
                  className="w-56 md:w-64 lg:w-72 rounded-2xl shadow-2xl ring-4 ring-white/10 group-hover:ring-blue-500/50 transition-all duration-300"
                />
                <div className="absolute inset-0 bg-gradient-to-t from-black/60 to-transparent rounded-2xl opacity-0 group-hover:opacity-100 transition-opacity" />
              </div>
            </div>

            {/* Info */}
            <div className="flex-1 flex flex-col justify-end space-y-4">
              <h1 className="text-5xl md:text-6xl lg:text-7xl font-black leading-tight" style={{ fontFamily: 'var(--font-big-titles)' }}>
                {displayTitle}
              </h1>
              
              {secondaryTitle && (
                <p className="text-xl md:text-2xl text-gray-300" style={{ fontFamily: 'var(--font-normal-text)' }}>
                  {secondaryTitle}
                </p>
              )}

              {/* Meta Info */}
              <div className="flex flex-wrap items-center gap-3">
                {malScore !== '0' && (
                  <div className="flex items-center gap-2 bg-yellow-500/20 backdrop-blur-sm px-4 py-2 rounded-full border border-yellow-500/30">
                    <span className="text-yellow-400 text-xl">⭐</span>
                    <span className="font-bold text-lg">{malScore}</span>
                  </div>
                )}
                
                {userRating !== '0' && (
                  <div className="flex items-center gap-2 bg-blue-500/20 backdrop-blur-sm px-4 py-2 rounded-full border border-blue-500/30">
                    <span className="text-blue-400 text-xl">★</span>
                    <span className="font-bold text-lg">{userRating}/10</span>
                  </div>
                )}
                
                <span className="px-4 py-2 bg-white/10 backdrop-blur-sm rounded-full border border-white/20 font-semibold">
                  {anime.Type}
                </span>
                
                <span className="px-4 py-2 bg-white/10 backdrop-blur-sm rounded-full border border-white/20 font-semibold">
                  {anime.Status}
                </span>
                
                {anime.Rating && (
                  <span className="px-4 py-2 bg-white/10 backdrop-blur-sm rounded-full border border-white/20 font-semibold">
                    {anime.Rating}
                  </span>
                )}
              </div>

              {/* Genres */}
              {genres.length > 0 && (
                <div className="flex flex-wrap gap-2">
                  {genres.map((genre: string) => (
                    <span
                      key={genre}
                      className="px-3 py-1 bg-gradient-to-r from-purple-500/20 to-pink-500/20 backdrop-blur-sm rounded-lg border border-purple-500/30 text-sm font-medium hover:border-purple-500/60 transition-colors"
                    >
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
      <div className="container mx-auto px-4 md:px-8 lg:px-16 py-12">
        <div className="grid grid-cols-1 lg:grid-cols-3 gap-12">
          {/* Left Column - Main Info */}
          <div className="lg:col-span-2 space-y-12">
            {/* Description */}
            <section className="space-y-4">
              <h2 className="text-3xl font-bold bg-gradient-to-r from-blue-400 to-purple-400 bg-clip-text text-transparent" style={{ fontFamily: 'var(--font-big-titles)' }} dir="rtl">
                القصة
              </h2>
              <div className="bg-white/5 backdrop-blur-sm rounded-2xl p-6 border border-white/10">
                <p className="text-gray-300 leading-relaxed text-lg" style={{ fontFamily: 'var(--font-normal-text)' }} dir="rtl">
                  {description}
                </p>
              </div>
            </section>

            {/* Episodes */}
            {episodes && episodes.length > 0 && (
              <section className="space-y-4">
                <h2 className="text-3xl font-bold bg-gradient-to-r from-blue-400 to-purple-400 bg-clip-text text-transparent" style={{ fontFamily: 'var(--font-big-titles)' }} dir="rtl">
                  الحلقات ({episodes.length})
                </h2>
                <div className="grid grid-cols-3 sm:grid-cols-4 md:grid-cols-5 lg:grid-cols-6 gap-3">
                  {episodes.map((ep: any) => (
                    <div
                      key={ep.eId}
                      className="group relative bg-gradient-to-br from-white/10 to-white/5 backdrop-blur-sm hover:from-blue-500/20 hover:to-purple-500/20 border border-white/10 hover:border-blue-500/50 rounded-xl p-4 text-center transition-all duration-300 cursor-pointer"
                    >
                      <div className="text-sm text-gray-400 mb-1" dir="rtl">الحلقة</div>
                      <div className="text-2xl font-bold">{ep.Episode}</div>
                      {ep.MarkedAs === 'LAST' && (
                        <div className="absolute top-2 right-2 bg-red-500 text-white text-xs px-2 py-1 rounded-full">
                          FINAL
                        </div>
                      )}
                    </div>
                  ))}
                </div>
              </section>
            )}

            {/* Related Anime */}
            {details?.RelatedAnime && details.RelatedAnime.length > 0 && (
              <section className="space-y-4">
                <h2 className="text-3xl font-bold bg-gradient-to-r from-blue-400 to-purple-400 bg-clip-text text-transparent" style={{ fontFamily: 'var(--font-big-titles)' }} dir="rtl">
                  أنمي ذات صلة
                </h2>
                <div className="grid grid-cols-2 sm:grid-cols-3 md:grid-cols-4 gap-4">
                  {details.RelatedAnime.map((related: any) => {
                    const relatedUrl = createAnimeUrl(related);
                    return (
                      <Link
                        key={related.AnimeId}
                        href={relatedUrl}
                        className="group relative"
                      >
                        <div className="relative aspect-[2/3] bg-gray-800 rounded-xl overflow-hidden ring-2 ring-white/10 group-hover:ring-blue-500/50 transition-all">
                          <img
                            src={`${THUMBNAILS_BASE}${related.Thumbnail}`}
                            alt={related.EN_Title || related.AR_Title}
                            className="w-full h-full object-cover group-hover:scale-110 transition-transform duration-300"
                          />
                          <div className="absolute inset-0 bg-gradient-to-t from-black via-transparent to-transparent opacity-0 group-hover:opacity-100 transition-opacity">
                            <div className="absolute bottom-0 left-0 right-0 p-4">
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

          {/* Right Column - Stats & Info */}
          <div className="space-y-6">
            {/* Statistics */}
            {details?.AnimeStatistics && (
              <section className="bg-gradient-to-br from-white/10 to-white/5 backdrop-blur-sm border border-white/10 rounded-2xl p-6 space-y-4">
                <h3 className="text-2xl font-bold bg-gradient-to-r from-blue-400 to-purple-400 bg-clip-text text-transparent" style={{ fontFamily: 'var(--font-big-titles)' }} dir="rtl">
                  الإحصائيات
                </h3>
                <div className="space-y-3">
                  {viewCount > 0 && (
                    <div className="flex justify-between items-center" dir="rtl">
                      <span className="text-gray-400">المشاهدات</span>
                      <span className="font-bold text-lg">{viewCount.toLocaleString()}</span>
                    </div>
                  )}
                  {details.AnimeStatistics.library_favourites && (
                    <div className="flex justify-between items-center" dir="rtl">
                      <span className="text-gray-400">المفضلة</span>
                      <span className="font-bold text-lg">{parseInt(details.AnimeStatistics.library_favourites).toLocaleString()}</span>
                    </div>
                  )}
                  {anime.Rank && anime.Rank !== '0' && (
                    <div className="flex justify-between items-center" dir="rtl">
                      <span className="text-gray-400">الترتيب</span>
                      <span className="font-bold text-lg">#{anime.Rank}</span>
                    </div>
                  )}
                  {anime.Popularity && anime.Popularity !== '0' && (
                    <div className="flex justify-between items-center" dir="rtl">
                      <span className="text-gray-400">الشعبية</span>
                      <span className="font-bold text-lg">#{anime.Popularity}</span>
                    </div>
                  )}
                </div>
              </section>
            )}

            {/* Information */}
            <section className="bg-gradient-to-br from-white/10 to-white/5 backdrop-blur-sm border border-white/10 rounded-2xl p-6 space-y-4">
              <h3 className="text-2xl font-bold bg-gradient-to-r from-blue-400 to-purple-400 bg-clip-text text-transparent" style={{ fontFamily: 'var(--font-big-titles)' }} dir="rtl">
                المعلومات
              </h3>
              <div className="space-y-4 text-sm">
                {anime.Type && (
                  <div dir="rtl">
                    <div className="text-gray-400 mb-1">النوع</div>
                    <div className="font-semibold text-base">
                      {anime.Type === 'SERIES' ? 'مسلسل' : anime.Type === 'MOVIE' ? 'فيلم' : anime.Type}
                    </div>
                  </div>
                )}
                {anime.Episodes && (
                  <div dir="rtl">
                    <div className="text-gray-400 mb-1">الحلقات</div>
                    <div className="font-semibold text-base">{anime.Episodes}</div>
                  </div>
                )}
                {anime.Status && (
                  <div dir="rtl">
                    <div className="text-gray-400 mb-1">الحالة</div>
                    <div className="font-semibold text-base">
                      {anime.Status === 'AIRING' ? 'يعرض الآن' : 
                       anime.Status === 'AIRED' ? 'منتهي' : 
                       anime.Status === 'UPCOMING' ? 'قريباً' : anime.Status}
                    </div>
                  </div>
                )}
                {anime.Season && (
                  <div dir="rtl">
                    <div className="text-gray-400 mb-1">الموسم</div>
                    <div className="font-semibold text-base">{anime.Season}</div>
                  </div>
                )}
                {anime.Premiered && (
                  <div dir="rtl">
                    <div className="text-gray-400 mb-1">العرض الأول</div>
                    <div className="font-semibold text-base">{anime.Premiered}</div>
                  </div>
                )}
                {anime.Duration && (
                  <div dir="rtl">
                    <div className="text-gray-400 mb-1">المدة</div>
                    <div className="font-semibold text-base">{anime.Duration} دقيقة</div>
                  </div>
                )}
                {anime.Creators && (
                  <div dir="rtl">
                    <div className="text-gray-400 mb-1">الاستوديو</div>
                    <div className="font-semibold text-base">{anime.Creators}</div>
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
