import { headers } from 'next/headers';
import VideoPlayer from '@/components/VideoPlayer';

export const runtime = 'edge';
export const revalidate = 60;

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

export default async function WatchPage({ params, searchParams }: { params: Promise<{ id: string }>, searchParams: Promise<{ episode?: string }> }) {
  const { id } = await params;
  const resolvedSearchParams = await searchParams;
  const { episodes, details } = await getAnimeData(id);
  const type = (details?.Type || 'SERIES') as 'SERIES' | 'MOVIE';

  return (
    <VideoPlayer animeId={id} episodes={episodes || []} defaultType={type} defaultEpisode={resolvedSearchParams?.episode} />
  );
}
