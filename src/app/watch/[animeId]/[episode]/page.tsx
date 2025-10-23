import { Metadata } from 'next';
import { notFound } from 'next/navigation';
import Link from 'next/link';
import Image from 'next/image';
import { ChevronRight, ChevronLeft, List, Info } from 'lucide-react';
import VideoPlayer from '@/components/VideoPlayer';

export const runtime = 'edge';

const THUMBNAILS_BASE = 'https://animeify.net/animeify/files/thumbnails/';

interface WatchPageData {
  anime: any;
  episodes: any[];
  servers: any;
}

async function getWatchData(animeId: string, episode: string): Promise<WatchPageData | null> {
  try {
    // Use absolute URL for the API route
    const baseUrl = process.env.NEXT_PUBLIC_BASE_URL || 'https://animefy.pages.dev';
    
    // Fetch anime details and streaming servers in parallel
    const [animeRes, serversRes] = await Promise.all([
      fetch(`${baseUrl}/api/anime/${animeId}`, {
        next: { revalidate: 600 }
      }),
      fetch(`${baseUrl}/api/anime/${animeId}/watch/${episode}`, {
        next: { revalidate: 300 }
      })
    ]);

    if (!animeRes.ok || !serversRes.ok) {
      return null;
    }

    const [animeData, serversData] = await Promise.all([
      animeRes.json(),
      serversRes.json()
    ]);

    return {
      anime: animeData.data?.anime || null,
      episodes: animeData.data?.episodes || [],
      servers: serversData.data || null
    };
  } catch (error) {
    console.error('Error fetching watch data:', error);
    return null;
  }
}

export async function generateMetadata({ 
  params 
}: { 
  params: { animeId: string; episode: string } 
}): Promise<Metadata> {
  const data = await getWatchData(params.animeId, params.episode);
  
  if (!data || !data.anime) {
    return {
      title: 'مشاهدة - WitAnime',
    };
  }

  const title = data.anime.AR_Title || data.anime.EN_Title || 'أنمي';
  
  return {
    title: `${title} - الحلقة ${params.episode} - WitAnime`,
    description: `مشاهدة ${title} الحلقة ${params.episode}`,
  };
}

export default async function WatchPage({ 
  params 
}: { 
  params: { animeId: string; episode: string } 
}) {
  const data = await getWatchData(params.animeId, params.episode);

  if (!data || !data.anime) {
    notFound();
  }

  const { anime, episodes, servers } = data;
  const currentEpisodeNum = parseFloat(params.episode);
  
  // Find current episode index
  const currentEpisodeIndex = episodes.findIndex(
    (ep: any) => parseFloat(ep.Episode) === currentEpisodeNum
  );

  // Get next and previous episodes
  const previousEpisode = currentEpisodeIndex > 0 ? episodes[currentEpisodeIndex - 1] : null;
  const nextEpisode = currentEpisodeIndex < episodes.length - 1 ? episodes[currentEpisodeIndex + 1] : null;

  return (
    <main className="min-h-screen bg-black text-white pt-[70px]">
      <div className="px-4 md:px-12 lg:px-16 xl:px-24 py-8">
        {/* Breadcrumb */}
        <div className="mb-6">
          <div className="flex items-center gap-2 text-sm text-gray-400" style={{ fontFamily: 'var(--font-normal-text)' }}>
            <Link href="/" className="hover:text-white transition-colors">
              الرئيسية
            </Link>
            <ChevronLeft className="w-4 h-4" />
            <Link href={`/anime/${params.animeId}`} className="hover:text-white transition-colors">
              {anime.AR_Title || anime.EN_Title}
            </Link>
            <ChevronLeft className="w-4 h-4" />
            <span className="text-white">الحلقة {params.episode}</span>
          </div>
        </div>

        {/* Page Title */}
        <div className="mb-6">
          <h1 
            className="text-3xl md:text-4xl font-bold mb-2"
            style={{ fontFamily: 'var(--font-big-titles)' }}
          >
            {anime.AR_Title || anime.EN_Title}
          </h1>
          <p 
            className="text-xl text-gray-400"
            style={{ fontFamily: 'var(--font-normal-text)' }}
          >
            الحلقة {params.episode}
          </p>
        </div>

        <div className="grid grid-cols-1 lg:grid-cols-3 gap-6">
          {/* Main Video Player */}
          <div className="lg:col-span-2 space-y-6">
            <VideoPlayer 
              servers={servers} 
              animeTitle={anime.AR_Title || anime.EN_Title}
              episode={params.episode}
            />

            {/* Episode Navigation */}
            <div className="flex gap-3">
              {previousEpisode ? (
                <Link
                  href={`/watch/${params.animeId}/${previousEpisode.Episode}`}
                  className="flex-1 flex items-center justify-center gap-2 bg-white/10 hover:bg-white/20 border border-white/20 hover:border-white/40 px-6 py-3 rounded-lg transition-all font-semibold"
                  style={{ fontFamily: 'var(--font-normal-text)' }}
                >
                  <ChevronRight className="w-5 h-5" />
                  الحلقة السابقة
                </Link>
              ) : (
                <div className="flex-1 bg-white/5 border border-white/10 px-6 py-3 rounded-lg text-center text-gray-500 font-semibold" style={{ fontFamily: 'var(--font-normal-text)' }}>
                  الحلقة السابقة
                </div>
              )}

              {nextEpisode ? (
                <Link
                  href={`/watch/${params.animeId}/${nextEpisode.Episode}`}
                  className="flex-1 flex items-center justify-center gap-2 bg-white text-black hover:bg-gray-200 px-6 py-3 rounded-lg transition-all font-semibold"
                  style={{ fontFamily: 'var(--font-normal-text)' }}
                >
                  الحلقة التالية
                  <ChevronLeft className="w-5 h-5" />
                </Link>
              ) : (
                <div className="flex-1 bg-white/5 border border-white/10 px-6 py-3 rounded-lg text-center text-gray-500 font-semibold" style={{ fontFamily: 'var(--font-normal-text)' }}>
                  الحلقة التالية
                </div>
              )}
            </div>

            {/* Anime Info Card */}
            <Link
              href={`/anime/${params.animeId}`}
              className="flex gap-4 bg-white/5 hover:bg-white/10 border border-white/10 hover:border-white/30 rounded-lg p-4 transition-all group"
            >
              {anime.Thumbnail && (
                <div className="relative w-24 h-32 flex-shrink-0 rounded-lg overflow-hidden">
                  <Image
                    src={`${THUMBNAILS_BASE}${anime.Thumbnail}`}
                    alt={anime.AR_Title || anime.EN_Title}
                    fill
                    className="object-cover"
                  />
                </div>
              )}
              <div className="flex-1">
                <div className="flex items-start justify-between gap-2 mb-2">
                  <h3 
                    className="text-xl font-bold group-hover:text-white transition-colors"
                    style={{ fontFamily: 'var(--font-big-titles)' }}
                  >
                    {anime.AR_Title || anime.EN_Title}
                  </h3>
                  <Info className="w-5 h-5 text-gray-400 group-hover:text-white transition-colors" />
                </div>
                {anime.EN_Title && anime.AR_Title && (
                  <p className="text-sm text-gray-400 mb-2" style={{ fontFamily: 'var(--font-anime-titles)' }}>
                    {anime.EN_Title}
                  </p>
                )}
                {anime.Synonyms && (
                  <p 
                    className="text-sm text-gray-400 line-clamp-2"
                    style={{ fontFamily: 'var(--font-normal-text)' }}
                  >
                    {anime.Synonyms}
                  </p>
                )}
              </div>
            </Link>
          </div>

          {/* Episodes List Sidebar */}
          <div className="lg:col-span-1">
            <div className="bg-white/5 border border-white/10 rounded-lg overflow-hidden sticky top-[90px]">
              <div className="bg-white/10 px-4 py-3 border-b border-white/10">
                <h2 
                  className="font-bold text-lg flex items-center gap-2"
                  style={{ fontFamily: 'var(--font-big-titles)' }}
                >
                  <List className="w-5 h-5" />
                  قائمة الحلقات ({episodes.length})
                </h2>
              </div>
              
              <div className="max-h-[600px] overflow-y-auto">
                <div className="p-2 space-y-1">
                  {episodes.map((ep: any) => {
                    const isActive = parseFloat(ep.Episode) === currentEpisodeNum;
                    return (
                      <Link
                        key={ep.eId || ep.Episode}
                        href={`/watch/${params.animeId}/${ep.Episode}`}
                        className={`block px-4 py-3 rounded-lg transition-all ${
                          isActive
                            ? 'bg-white text-black font-bold'
                            : 'bg-white/5 hover:bg-white/10 border border-white/10 hover:border-white/30'
                        }`}
                      >
                        <div className="flex items-center justify-between">
                          <span style={{ fontFamily: 'var(--font-normal-text)' }}>
                            الحلقة {ep.Episode}
                          </span>
                          {ep.Type && ep.Type !== 'EPISODE' && (
                            <span className={`text-xs px-2 py-0.5 rounded ${
                              isActive ? 'bg-black/20' : 'bg-white/10'
                            }`}>
                              {ep.Type}
                            </span>
                          )}
                        </div>
                        {ep.MarkedAs && ep.MarkedAs !== 'NORMAL' && (
                          <span className={`text-xs ${isActive ? 'text-black/60' : 'text-gray-400'}`}>
                            {ep.MarkedAs === 'FILLER' && 'حلقة حشو'}
                            {ep.MarkedAs === 'LAST' && 'الحلقة الأخيرة'}
                          </span>
                        )}
                      </Link>
                    );
                  })}
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </main>
  );
}
