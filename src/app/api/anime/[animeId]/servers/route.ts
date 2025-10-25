import { NextRequest, NextResponse } from 'next/server';

const API_BASE = 'https://animeify.net/animeify/apis_v4/';
const TOKEN = '8cnY80AZSbUCmR26Vku1VUUY4';

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

export async function GET(
  request: NextRequest,
  { params }: { params: Promise<{ animeId: string }> }
) {
  try {
    const { animeId } = await params;
    const searchParams = request.nextUrl.searchParams;
    const episode = searchParams.get('episode');
    
    if (!episode) {
      return NextResponse.json({ error: 'Episode parameter required' }, { status: 400 });
    }

    const response = await fetch(`${API_BASE}anime/load_servers.php`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/x-www-form-urlencoded',
      },
      body: new URLSearchParams({
        UserId: '0',
        AnimeId: animeId,
        Episode: episode,
        AnimeType: 'SERIES',
        Token: TOKEN,
      }),
      cache: 'no-store',
    });

    if (!response.ok) {
      return NextResponse.json({ error: 'Failed to fetch servers' }, { status: response.status });
    }

    const data = await response.json();
    const currentEpisode = data.CurrentEpisode || {};
    
    // Extract MediaFire servers and get direct links
    const servers: any[] = [];
    const mediafireServers: any[] = [];
    
    // Process different quality MediaFire links in parallel
    const mediafirePromises: Promise<void>[] = [];
    
    if (currentEpisode.FRFhdQ) {
      mediafirePromises.push(
        extractMediaFireLink(currentEpisode.FRFhdQ).then((directLink) => {
          if (directLink) {
            mediafireServers.push({
              serverName: 'MediaFire',
              serverType: 'MEDIAFIRE',
              serverTypeKey: 'MEDIAFIRE',
              quality: '1080p',
              url: `https://www.mediafire.com/file/${currentEpisode.FRFhdQ}`,
              directUrl: directLink,
            });
          }
        })
      );
    }
    
    if (currentEpisode.FRLink) {
      mediafirePromises.push(
        extractMediaFireLink(currentEpisode.FRLink).then((directLink) => {
          if (directLink) {
            mediafireServers.push({
              serverName: 'MediaFire',
              serverType: 'MEDIAFIRE',
              serverTypeKey: 'MEDIAFIRE',
              quality: '720p',
              url: `https://www.mediafire.com/file/${currentEpisode.FRLink}`,
              directUrl: directLink,
            });
          }
        })
      );
    }
    
    if (currentEpisode.FRLowQ) {
      mediafirePromises.push(
        extractMediaFireLink(currentEpisode.FRLowQ).then((directLink) => {
          if (directLink) {
            mediafireServers.push({
              serverName: 'MediaFire',
              serverType: 'MEDIAFIRE',
              serverTypeKey: 'MEDIAFIRE',
              quality: '480p',
              url: `https://www.mediafire.com/file/${currentEpisode.FRLowQ}`,
              directUrl: directLink,
            });
          }
        })
      );
    }
    
    // Wait for all MediaFire extractions to complete
    await Promise.all(mediafirePromises);
    
    // Sort by quality (highest first)
    mediafireServers.sort((a, b) => {
      const qualityA = parseInt(a.quality) || 0;
      const qualityB = parseInt(b.quality) || 0;
      return qualityB - qualityA;
    });
    
    servers.push(...mediafireServers);
    
    // Add other servers as iframe embeds
    if (currentEpisode.SVLink) {
      servers.push({
        serverName: 'Streamvid',
        serverType: 'STREAMVID',
        serverTypeKey: 'STREAMVID',
        url: currentEpisode.SVLink,
      });
    }
    
    if (currentEpisode.SVLowQ) {
      servers.push({
        serverName: 'Streamvid SD',
        serverType: 'STREAMVID',
        serverTypeKey: 'STREAMVID_SD',
        quality: '480p',
        url: currentEpisode.SVLowQ,
      });
    }
    
    if (currentEpisode.OKLink) {
      servers.push({
        serverName: 'OK.ru',
        serverType: 'OK',
        serverTypeKey: 'OK',
        url: currentEpisode.OKLink,
      });
    }
    
    if (currentEpisode.LBLink) {
      servers.push({
        serverName: 'Lulubox',
        serverType: 'LULUBOX',
        serverTypeKey: 'LULUBOX',
        url: currentEpisode.LBLink,
      });
    }

    return NextResponse.json({
      servers,
      mediafire: mediafireServers,
      bestMediafire: mediafireServers[0] || null,
    });
  } catch (error) {
    console.error('Episode servers error:', error);
    return NextResponse.json({ error: 'Failed to fetch episode servers' }, { status: 500 });
  }
}
