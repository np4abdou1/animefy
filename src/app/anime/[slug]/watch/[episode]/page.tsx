export const runtime = 'edge';

import { notFound } from 'next/navigation';
import Link from 'next/link';
import { ArrowLeft } from 'lucide-react';
import { getCompleteAnimeDataByTitle, getAnimeEpisodes } from '@/lib/animeify-api';
import { slugToTitle } from '@/lib/slug';
import VideoPlayer from '@/components/VideoPlayer';

interface WatchPageProps {
  params: Promise<{
    slug: string;
    episode: string;
  }>;
  searchParams: Promise<{
    name?: string;
    type?: string;
  }>;
}

const THUMBNAILS_BASE = 'https://animeify.net/animeify/files/thumbnails/';

async function getEpisodeServers(animeId: string, episode: string) {
  try {
    const API_BASE = 'https://animeify.net/animeify/api/';
    const TOKEN = '8cnY80AZSbUCmR26Vku1VUUY4';

    const response = await fetch(`${API_BASE}episodes/load_episode_servers.php`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/x-www-form-urlencoded',
      },
      body: new URLSearchParams({
        AnimeID: animeId,
        Episode: episode,
        Token: TOKEN,
      }),
      cache: 'no-store',
    });

    if (!response.ok) {
      return null;
    }

    const data = await response.json();
    
    // Extract MediaFire servers and get direct links
    const servers: any[] = [];
    const mediafireServers: any[] = [];
    
    // Process different quality MediaFire links
    if (data.Fr_FHD_Q) {
      const directLink = await extractMediaFireLink(data.Fr_FHD_Q);
      if (directLink) {
        mediafireServers.push({
          serverName: 'MediaFire',
          serverType: 'MEDIAFIRE',
          serverTypeKey: 'MEDIAFIRE',
          quality: '1080p',
          url: `https://www.mediafire.com/file/${data.Fr_FHD_Q}`,
          directUrl: directLink,
        });
      }
    }
    
    if (data.Fr) {
      const directLink = await extractMediaFireLink(data.Fr);
      if (directLink) {
        mediafireServers.push({
          serverName: 'MediaFire',
          serverType: 'MEDIAFIRE',
          serverTypeKey: 'MEDIAFIRE',
          quality: '720p',
          url: `https://www.mediafire.com/file/${data.Fr}`,
          directUrl: directLink,
        });
      }
    }
    
    if (data.Fr_Low_Q) {
      const directLink = await extractMediaFireLink(data.Fr_Low_Q);
      if (directLink) {
        mediafireServers.push({
          serverName: 'MediaFire',
          serverType: 'MEDIAFIRE',
          serverTypeKey: 'MEDIAFIRE',
          quality: '480p',
          url: `https://www.mediafire.com/file/${data.Fr_Low_Q}`,
          directUrl: directLink,
        });
      }
    }
    
    servers.push(...mediafireServers);
    
    // Add other servers as iframe embeds
    if (data.Sv) {
      servers.push({
        serverName: 'Streamvid',
        serverType: 'STREAMVID',
        url: data.Sv,
      });
    }
    
    if (data.Ok) {
      servers.push({
        serverName: 'OK.ru',
        serverType: 'OK',
        url: data.Ok,
      });
    }

    return {
      servers,
      mediafire: mediafireServers,
      bestMediafire: mediafireServers[0] || null,
    };
  } catch (error) {
    console.error('Failed to fetch episode servers:', error);
    return null;
  }
}

async function extractMediaFireLink(fileId: string): Promise<string | null> {
  try {
    const mediafireUrl = `https://www.mediafire.com/file/${fileId}`;
    
    const response = await fetch(mediafireUrl, {
      headers: {
        'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.97 Safari/537.36',
      },
    });

    if (!response.ok) {
      return null;
    }

    const html = await response.text();
    
    const startIndex = html.indexOf('https://download');
    if (startIndex === -1) {
      return null;
    }
    
    const endIndex = html.indexOf('"', startIndex);
    const directLink = html.substring(startIndex, endIndex);
    
    return directLink;
  } catch (error) {
    console.error('Failed to extract MediaFire link:', error);
    return null;
  }
}

export default async function WatchPage({ params, searchParams }: WatchPageProps) {
  const { slug, episode } = await params;
  const { name, type } = await searchParams;
  
  const searchTitle = name || slugToTitle(slug);
  const animeType = type || 'SERIES';
  
  const data = await getCompleteAnimeDataByTitle(searchTitle, animeType);
  
  if (!data || !data.anime) {
    notFound();
  }

  const { anime, episodes } = data;
  const displayTitle = anime.AR_Title || anime.EN_Title || anime.Synonyms || 'Unknown';
  
  // Get episode servers
  const servers = await getEpisodeServers(anime.AnimeId, episode);

  return (
    <div className="fixed inset-0 bg-black text-white">
      <VideoPlayer
        animeId={anime.AnimeId}
        episodes={episodes || []}
        defaultEpisode={episode}
        initialServers={servers}
        title={`${displayTitle} - ${episode} الحلقة`}
      />
    </div>
  );
}
