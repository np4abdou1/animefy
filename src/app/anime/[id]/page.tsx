import { Metadata } from 'next';
import { notFound } from 'next/navigation';
import Image from 'next/image';
import Link from 'next/link';
import { Star, Calendar, Clock, Play, Users, TrendingUp } from 'lucide-react';

export const runtime = 'edge';

const THUMBNAILS_BASE = 'https://animeify.net/animeify/files/thumbnails/';
const CHARACTERS_BASE = 'https://animeify.net/animeify/files/characters/photos/chars/';

interface AnimeDetailsData {
  anime: any;
  episodes: any[];
  characters: any[];
  related: any[];
}

async function getAnimeDetails(id: string): Promise<AnimeDetailsData | null> {
  try {
    // Use absolute URL for the API route
    const baseUrl = process.env.NEXT_PUBLIC_BASE_URL || 'https://animefy.pages.dev';
    const res = await fetch(`${baseUrl}/api/anime/${id}`, {
      next: { revalidate: 600 } // Revalidate every 10 minutes
    });
    
    if (!res.ok) {
      return null;
    }
    
    const json = await res.json();
    return json.data || null;
  } catch (error) {
    console.error('Error fetching anime details:', error);
    return null;
  }
}

export async function generateMetadata({ params }: { params: { id: string } }): Promise<Metadata> {
  const data = await getAnimeDetails(params.id);
  
  if (!data || !data.anime) {
    return {
      title: 'أنمي غير موجود - WitAnime',
    };
  }

  const title = data.anime.AR_Title || data.anime.EN_Title || 'أنمي';
  
  return {
    title: `${title} - WitAnime`,
    description: data.anime.Synonyms || title,
  };
}

export default async function AnimeDetailPage({ params }: { params: { id: string } }) {
  const data = await getAnimeDetails(params.id);

  if (!data || !data.anime) {
    notFound();
  }

  const anime = data.anime;
  const episodes = data.episodes || [];
  const characters = data.characters || [];
  const related = data.related || [];

  // Parse score and rating
  const score = anime.Score ? parseFloat(anime.Score) : 0;
  const rating = anime.Rating || 'غير محدد';
  const status = anime.Status || 'غير معروف';
  const genres = anime.Genres ? anime.Genres.split(',').map((g: string) => g.trim()) : [];
  
  // Get status label in Arabic
  const statusLabels: { [key: string]: string } = {
    'AIRING': 'يعرض الآن',
    'AIRED': 'انتهى',
    'UPCOMING': 'قريباً',
    'PAUSED': 'متوقف',
  };

  const statusLabel = statusLabels[status] || status;

  return (
    <main className="min-h-screen bg-black text-white pt-[70px]">
      {/* Hero Section with Background */}
      <div className="relative w-full h-[60vh] md:h-[70vh]">
        {/* Background Image */}
        <div className="absolute inset-0">
          {anime.Thumbnail && (
            <Image
              src={`${THUMBNAILS_BASE}${anime.Thumbnail}`}
              alt={anime.AR_Title || anime.EN_Title}
              fill
              className="object-cover"
              priority
            />
          )}
          {/* Gradient Overlay */}
          <div className="absolute inset-0 bg-gradient-to-t from-black via-black/80 to-transparent" />
          <div className="absolute inset-0 bg-gradient-to-r from-black/90 via-black/50 to-transparent" />
        </div>

        {/* Content */}
        <div className="relative h-full px-4 md:px-12 lg:px-16 xl:px-24 flex items-end pb-12">
          <div className="max-w-4xl">
            {/* Title */}
            <h1 
              className="text-4xl md:text-5xl lg:text-6xl font-bold mb-4 drop-shadow-2xl"
              style={{ fontFamily: 'var(--font-big-titles)' }}
            >
              {anime.AR_Title || anime.EN_Title}
            </h1>

            {/* Subtitle */}
            {anime.EN_Title && anime.AR_Title && (
              <p 
                className="text-lg md:text-xl text-gray-300 mb-4"
                style={{ fontFamily: 'var(--font-anime-titles)' }}
              >
                {anime.EN_Title}
              </p>
            )}

            {/* Meta Information */}
            <div className="flex flex-wrap items-center gap-4 mb-6 text-sm md:text-base" style={{ fontFamily: 'var(--font-normal-text)' }}>
              {/* Score */}
              {score > 0 && (
                <div className="flex items-center gap-1.5 bg-yellow-500/20 px-3 py-1.5 rounded-full border border-yellow-500/30">
                  <Star className="w-4 h-4 text-yellow-500 fill-yellow-500" />
                  <span className="font-semibold text-yellow-500">{score.toFixed(1)}</span>
                </div>
              )}

              {/* Status */}
              <div className="flex items-center gap-1.5 bg-white/10 px-3 py-1.5 rounded-full border border-white/20">
                <TrendingUp className="w-4 h-4" />
                <span>{statusLabel}</span>
              </div>

              {/* Episodes Count */}
              {anime.Episodes && (
                <div className="flex items-center gap-1.5 bg-white/10 px-3 py-1.5 rounded-full border border-white/20">
                  <Play className="w-4 h-4" />
                  <span>{anime.Episodes} حلقة</span>
                </div>
              )}

              {/* Type */}
              {anime.Type && (
                <div className="bg-white/10 px-3 py-1.5 rounded-full border border-white/20">
                  {anime.Type}
                </div>
              )}
            </div>

            {/* Action Button */}
            {episodes.length > 0 && (
              <Link
                href={`/watch/${params.id}/${episodes[0].Episode || 1}`}
                className="inline-flex items-center gap-2 bg-white text-black px-8 py-3 rounded-full font-bold text-lg hover:bg-gray-200 transition-all hover:scale-105 shadow-2xl"
                style={{ fontFamily: 'var(--font-normal-text)' }}
              >
                <Play className="w-5 h-5 fill-black" />
                ابدأ المشاهدة
              </Link>
            )}
          </div>
        </div>
      </div>

      {/* Details Section */}
      <div className="px-4 md:px-12 lg:px-16 xl:px-24 py-12">
        <div className="grid grid-cols-1 lg:grid-cols-3 gap-8">
          {/* Main Content */}
          <div className="lg:col-span-2 space-y-8">
            {/* Synopsis */}
            {anime.Synonyms && (
              <div>
                <h2 
                  className="text-2xl md:text-3xl font-bold mb-4"
                  style={{ fontFamily: 'var(--font-big-titles)' }}
                >
                  القصة
                </h2>
                <p 
                  className="text-gray-300 leading-relaxed text-base md:text-lg"
                  style={{ fontFamily: 'var(--font-normal-text)' }}
                >
                  {anime.Synonyms}
                </p>
              </div>
            )}

            {/* Episodes List */}
            {episodes.length > 0 && (
              <div>
                <h2 
                  className="text-2xl md:text-3xl font-bold mb-4"
                  style={{ fontFamily: 'var(--font-big-titles)' }}
                >
                  الحلقات ({episodes.length})
                </h2>
                <div className="grid grid-cols-2 sm:grid-cols-3 md:grid-cols-4 lg:grid-cols-5 gap-3">
                  {episodes.map((ep: any) => (
                    <Link
                      key={ep.eId || ep.Episode}
                      href={`/watch/${params.id}/${ep.Episode}`}
                      className="group relative bg-white/5 hover:bg-white/10 border border-white/10 hover:border-white/30 rounded-lg p-4 text-center transition-all hover:scale-105"
                    >
                      <div className="flex items-center justify-center gap-2">
                        <Play className="w-4 h-4 opacity-50 group-hover:opacity-100 transition-opacity" />
                        <span 
                          className="font-semibold text-lg"
                          style={{ fontFamily: 'var(--font-normal-text)' }}
                        >
                          {ep.Episode}
                        </span>
                      </div>
                      {ep.Type && ep.Type !== 'EPISODE' && (
                        <span className="text-xs text-gray-400 mt-1 block">{ep.Type}</span>
                      )}
                    </Link>
                  ))}
                </div>
              </div>
            )}

            {/* Characters */}
            {characters.length > 0 && (
              <div>
                <h2 
                  className="text-2xl md:text-3xl font-bold mb-4 flex items-center gap-2"
                  style={{ fontFamily: 'var(--font-big-titles)' }}
                >
                  <Users className="w-6 h-6" />
                  الشخصيات
                </h2>
                <div className="grid grid-cols-2 sm:grid-cols-3 md:grid-cols-4 gap-4">
                  {characters.slice(0, 12).map((char: any) => (
                    <div 
                      key={char.CharacterId || char.Name}
                      className="group bg-white/5 hover:bg-white/10 border border-white/10 hover:border-white/30 rounded-lg overflow-hidden transition-all hover:scale-105"
                    >
                      {char.Photo && (
                        <div className="relative w-full aspect-[3/4] bg-gray-800">
                          <Image
                            src={`${CHARACTERS_BASE}${char.Photo}`}
                            alt={char.Name || 'Character'}
                            fill
                            className="object-cover"
                          />
                        </div>
                      )}
                      <div className="p-3">
                        <p 
                          className="font-semibold text-sm line-clamp-2 text-center"
                          style={{ fontFamily: 'var(--font-normal-text)' }}
                        >
                          {char.Name || char.JP_Name}
                        </p>
                        {char.Role && (
                          <p className="text-xs text-gray-400 text-center mt-1">{char.Role}</p>
                        )}
                      </div>
                    </div>
                  ))}
                </div>
              </div>
            )}

            {/* Related Anime */}
            {related.length > 0 && (
              <div>
                <h2 
                  className="text-2xl md:text-3xl font-bold mb-4"
                  style={{ fontFamily: 'var(--font-big-titles)' }}
                >
                  أنميات مرتبطة
                </h2>
                <div className="grid grid-cols-2 sm:grid-cols-3 md:grid-cols-4 gap-4">
                  {related.slice(0, 8).map((rel: any) => (
                    <Link
                      key={rel.AnimeId || rel.Id}
                      href={`/anime/${rel.AnimeId || rel.Id}`}
                      className="group bg-white/5 hover:bg-white/10 border border-white/10 hover:border-white/30 rounded-lg overflow-hidden transition-all hover:scale-105"
                    >
                      {rel.Thumbnail && (
                        <div className="relative w-full aspect-[3/4] bg-gray-800">
                          <Image
                            src={`${THUMBNAILS_BASE}${rel.Thumbnail}`}
                            alt={rel.AR_Title || rel.EN_Title || 'Related anime'}
                            fill
                            className="object-cover"
                          />
                        </div>
                      )}
                      <div className="p-3">
                        <p 
                          className="font-semibold text-sm line-clamp-2"
                          style={{ fontFamily: 'var(--font-normal-text)' }}
                        >
                          {rel.AR_Title || rel.EN_Title}
                        </p>
                        {rel.Relation && (
                          <p className="text-xs text-gray-400 mt-1">{rel.Relation}</p>
                        )}
                      </div>
                    </Link>
                  ))}
                </div>
              </div>
            )}
          </div>

          {/* Sidebar */}
          <div className="space-y-6">
            <div className="bg-white/5 border border-white/10 rounded-lg p-6 space-y-4" style={{ fontFamily: 'var(--font-normal-text)' }}>
              <h3 className="text-xl font-bold mb-4">معلومات</h3>

              {/* Genres */}
              {genres.length > 0 && (
                <div>
                  <p className="text-gray-400 text-sm mb-2">الأنواع</p>
                  <div className="flex flex-wrap gap-2">
                    {genres.map((genre: string) => (
                      <span
                        key={genre}
                        className="bg-white/10 px-3 py-1 rounded-full text-sm border border-white/20"
                      >
                        {genre}
                      </span>
                    ))}
                  </div>
                </div>
              )}

              {/* Premiered */}
              {anime.Premiered && (
                <div>
                  <p className="text-gray-400 text-sm mb-1">الموسم</p>
                  <div className="flex items-center gap-2">
                    <Calendar className="w-4 h-4 text-gray-400" />
                    <p className="font-semibold">{anime.Premiered}</p>
                  </div>
                </div>
              )}

              {/* Broadcast */}
              {anime.Broadcast && (
                <div>
                  <p className="text-gray-400 text-sm mb-1">يوم العرض</p>
                  <p className="font-semibold">{anime.Broadcast}</p>
                </div>
              )}

              {/* Duration */}
              {anime.Duration && (
                <div>
                  <p className="text-gray-400 text-sm mb-1">المدة</p>
                  <div className="flex items-center gap-2">
                    <Clock className="w-4 h-4 text-gray-400" />
                    <p className="font-semibold">{anime.Duration} دقيقة</p>
                  </div>
                </div>
              )}

              {/* Studios */}
              {anime.Creators && (
                <div>
                  <p className="text-gray-400 text-sm mb-1">الاستوديو</p>
                  <p className="font-semibold">{anime.Creators}</p>
                </div>
              )}

              {/* Rating */}
              <div>
                <p className="text-gray-400 text-sm mb-1">التصنيف العمري</p>
                <p className="font-semibold">{rating}</p>
              </div>

              {/* Views */}
              {anime.views && (
                <div>
                  <p className="text-gray-400 text-sm mb-1">المشاهدات</p>
                  <p className="font-semibold">{parseInt(anime.views).toLocaleString('ar-EG')}</p>
                </div>
              )}

              {/* Popularity Rank */}
              {anime.Popularity && (
                <div>
                  <p className="text-gray-400 text-sm mb-1">ترتيب الشعبية</p>
                  <p className="font-semibold">#{anime.Popularity}</p>
                </div>
              )}

              {/* Score Rank */}
              {anime.Rank && (
                <div>
                  <p className="text-gray-400 text-sm mb-1">ترتيب التقييم</p>
                  <p className="font-semibold">#{anime.Rank}</p>
                </div>
              )}
            </div>
          </div>
        </div>
      </div>
    </main>
  );
}
