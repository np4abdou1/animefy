import { headers } from 'next/headers';
import Link from 'next/link';

export const runtime = 'edge';
export const revalidate = 300;

const THUMB = 'https://animeify.net/animeify/files/thumbnails/';

async function getBase() {
  const h = await headers();
  const proto = h.get('x-forwarded-proto') || 'https';
  const host = h.get('x-forwarded-host') || h.get('host');
  return `${proto}://${host}`;
}

async function getAnimeData(id: string) {
  const base = await getBase();
  const res = await fetch(`${base}/api/anime/${id}`, { next: { revalidate: 300 } });
  if (!res.ok) throw new Error('failed_to_load_anime');
  return res.json();
}

function Stat({ label, value }: { label: string; value?: string }) {
  if (!value) return null;
  return (
    <div className="px-3 py-2 rounded-lg bg-white/5 border border-white/10">
      <div className="text-xs text-gray-300" style={{ fontFamily: 'var(--font-normal-text)' }}>{label}</div>
      <div className="text-sm font-semibold text-white" style={{ fontFamily: 'var(--font-big-titles)' }}>{value}</div>
    </div>
  );
}

export default async function AnimePage({ params }: { params: Promise<{ id: string }> }) {
  const { id } = await params;
  const { details, episodes, related, mal, thumbnailUrl, stats: apiStats } = await getAnimeData(id);
  const d = details || {};
  const title = d.AR_Title || d.Title || d.EN_Title || mal?.title || id;
  const desc = d.Plot || d.AR_Description || d.EN_Description || d.Description || mal?.synopsis || '';
  const thumb = (thumbnailUrl) || (d.Thumbnail ? THUMB + d.Thumbnail : '') || (mal?.images?.jpg?.large_image_url || mal?.images?.jpg?.image_url || '');
  const stats = {
    type: d.Type === 'MOVIE' ? 'فيلم' : d.Type ? 'مسلسل' : undefined,
    episodes: (d.Episodes || d.TotalEpisodes) ? `${d.Episodes || d.TotalEpisodes} حلقة` : undefined,
    status: d.Status === 'AIRING' ? 'يعرض الآن' : d.Status === 'AIRED' ? 'منتهي' : undefined,
    score: (d.Score || d?.AnimeStatistics?.Rate || d?.AnimeStatistics?.Rating || apiStats?.score) ? `${d.Score || d?.AnimeStatistics?.Rate || d?.AnimeStatistics?.Rating || apiStats?.score}` : undefined,
    premiered: d.Premiered,
  };

  return (
    <div className="px-4 md:px-12 lg:px-16 xl:px-24 max-w-[1920px] mx-auto pb-20">
      {/* Header */}
      <div className="grid grid-cols-1 md:grid-cols-[280px,1fr] gap-6 mt-6 items-start">
        {/* Poster */}
        <div className="relative w-full aspect-[2/3] rounded-xl overflow-hidden bg-white/5 border border-white/10">
          {thumb && (
            // eslint-disable-next-line @next/next/no-img-element
            <img src={thumb} alt={title} className="w-full h-full object-cover" />
          )}
        </div>

        {/* Meta */}
        <div>
          <h1 className="text-3xl md:text-4xl font-extrabold text-white mb-3" style={{ fontFamily: 'var(--font-big-titles)' }}>{title}</h1>
          <div className="text-gray-200 leading-7 mb-4" style={{ fontFamily: 'var(--font-normal-text)' }}>{desc}</div>

          {/* Quick stats */}
          <div className="flex flex-wrap gap-2 mb-6">
            <Stat label="النوع" value={stats.type} />
            <Stat label="الحلقات" value={stats.episodes} />
            <Stat label="الحالة" value={stats.status} />
            <Stat label="التقييم" value={stats.score} />
            <Stat label="العرض" value={stats.premiered} />
          </div>

          {/* Watch button */}
          <Link href={`/watch/${id}`} className="inline-flex items-center gap-2 px-5 py-3 rounded-xl bg-white text-black font-bold hover:opacity-90 transition">
            مشاهدة الآن
          </Link>
        </div>
      </div>

      {/* Episodes list: compact */}
      {Array.isArray(episodes) && episodes.length > 0 && (
        <div className="mt-10">
          <h2 className="text-2xl font-bold text-white mb-3" style={{ fontFamily: 'var(--font-big-titles)' }}>الحلقات</h2>
          <div className="flex flex-wrap gap-2">
            {episodes.map((ep: any, idx: number) => {
              const epNum = ep?.Episode ?? ep?.EPNumber ?? ep?.Number ?? ep;
              return (
                <Link key={idx} href={`/watch/${id}?episode=${encodeURIComponent(epNum)}`} className="px-3 py-1.5 rounded-lg bg-white/10 text-white hover:bg-white/20 transition text-sm" style={{ fontFamily: 'var(--font-normal-text)' }}>
                  {`الحلقة ${epNum}`}
                </Link>
              );
            })}
          </div>
        </div>
      )}

      {/* Related anime */}
      {Array.isArray(related) && related.length > 0 && (
        <div className="mt-12">
          <h2 className="text-2xl font-bold text-white mb-4" style={{ fontFamily: 'var(--font-big-titles)' }}>أنميات مشابهة</h2>
          <div className="grid grid-cols-2 sm:grid-cols-3 md:grid-cols-4 lg:grid-cols-5 gap-4">
            {related.slice(0, 20).map((a: any, i: number) => {
              const rid = a.AnimeId || a.anime_id || '';
              const rtitle = a.AR_Title || a.Title || a.EN_Title || a.Synonyms || '';
              const rthumb = a.Thumbnail ? THUMB + a.Thumbnail : '';
              const type = a.Type || '';
              const status = a.Status || '';
              let badge = '';
              if (type === 'MOVIE') badge = 'فيلم';
              else if (status === 'AIRING') badge = 'يعرض الآن';
              else if (status === 'AIRED') badge = 'منتهي';
              return (
                <Link key={`${rid}-${i}`} href={`/anime/${rid}`} className="group">
                  <div className="relative aspect-[2/3] bg-white/5 transition-all duration-300 ease-out group-hover:scale-105 group-hover:ring-2 group-hover:ring-white rounded-lg overflow-hidden">
                    {rthumb && (
                      // eslint-disable-next-line @next/next/no-img-element
                      <img src={rthumb} alt={rtitle} className="w-full h-full object-cover" />
                    )}
                    <div className="absolute inset-0 bg-gradient-to-t from-black/90 via-transparent to-transparent opacity-0 group-hover:opacity-100 transition-opacity duration-300">
                      <div className="absolute bottom-0 left-0 right-0 p-3">
                        <h3 className="text-white text-sm font-semibold line-clamp-2" style={{ fontFamily: 'var(--font-normal-text)' }}>{rtitle}</h3>
                      </div>
                    </div>
                    {badge && <div className="absolute top-2 right-2 bg-black/80 backdrop-blur-sm px-2 py-1 rounded text-xs text-white font-semibold">{badge}</div>}
                  </div>
                </Link>
              );
            })}
          </div>
        </div>
      )}

      {/* MAL info */}
      {mal && (
        <div className="mt-12">
          <h2 className="text-2xl font-bold text-white mb-2" style={{ fontFamily: 'var(--font-big-titles)' }}>معلومات من MyAnimeList</h2>
          <div className="grid grid-cols-1 md:grid-cols-[220px,1fr] gap-4 bg-white/5 p-4 rounded-xl border border-white/10">
            {mal.images?.jpg?.image_url && (
              // eslint-disable-next-line @next/next/no-img-element
              <img src={mal.images.jpg.image_url} alt={mal.title} className="w-full h-[280px] object-cover rounded-lg" />
            )}
            <div>
              <div className="text-white font-bold text-xl mb-2" style={{ fontFamily: 'var(--font-big-titles)' }}>{mal.title}</div>
              <div className="text-gray-300" style={{ fontFamily: 'var(--font-normal-text)' }}>{mal.synopsis}</div>
            </div>
          </div>
        </div>
      )}
    </div>
  );
}
