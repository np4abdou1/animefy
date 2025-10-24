export const runtime = 'edge';

const ANIMEIFY_API_BASE = 'https://animeify.net/animeify/apis_v4/';
const ANIMEIFY_TOKEN = '8cnY80AZSbUCmR26Vku1VUUY4';

async function postForm(url: string, data: Record<string, string>) {
  const body = new URLSearchParams(data);
  const res = await fetch(url, {
    method: 'POST',
    headers: {
      'Accept': 'application/json, text/plain, */*',
      'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8',
    },
    body,
  });
  if (!res.ok) throw new Error(`HTTP ${res.status}`);
  return await res.json();
}

function buildStreamingUrl(link: string, typeKey: string) {
  const key = (typeKey || '').toUpperCase();
  // Normalize some embed providers
  if (key.includes('OK') || key.includes('OKRU')) return `https://ok.ru/videoembed/${link}`;
  if (key.includes('STREAMTAPE')) return `https://streamtape.com/e/${link}`;
  if (key.includes('FILEMOON')) return `https://filemoon.sx/e/${link}`;
  if (key.includes('SENDVID')) return `https://sendvid.com/embed/${link}`;
  if (key.includes('VANFEM') || key.includes('VIDHIDE')) return `https://vanfem.com/e/${link}`;
  if (key.includes('SB') || key.includes('STREAMSB')) return `https://streamsb.net/e/${link}`;
  if (key.includes('MEGA')) return `https://mega.nz/embed/${link}`;
  if (key.includes('GDRIVE') || key.includes('GOOGLE')) return `https://drive.google.com/file/d/${link}/preview`;
  // Mediafire usually is full url already
  return link;
}

async function extractDirectMediafireUrl(url: string) {
  try {
    const res = await fetch(url, { headers: { 'Accept': 'text/html' } });
    const html = await res.text();
    // Look for a direct download link appearing in the page
    const m = html.match(/https?:\/\/download\.mediafire\.com\/[\w\-/.%?&=]+/i);
    if (m && m[0]) return m[0];
  } catch {}
  return null;
}

export async function GET(request: Request, ctx: { params: Promise<{ id: string }> }) {
  try {
    const url = new URL(request.url);
    const { id: animeId } = await ctx.params;
    const episode = url.searchParams.get('episode') || '1';
    const type = (url.searchParams.get('type') || 'SERIES').toUpperCase();

    const payload: Record<string, string> = {
      UserId: '0',
      AnimeId: animeId,
      Episode: episode,
      AnimeType: type,
      Token: ANIMEIFY_TOKEN,
    };
    const data = await postForm(ANIMEIFY_API_BASE + 'anime/load_servers.php', payload);

    const list: any[] = [];
    const current = data?.CurrentEpisode || data?.current || {};
    const servers = Array.isArray(current?.Servers) ? current.Servers : (Array.isArray(data?.Servers) ? data.Servers : []);

    for (const s of servers) {
      const serverName = s?.ServerName || s?.Name || '';
      const serverType = s?.ServerType || s?.Type || '';
      const serverTypeKey = s?.ServerTypeKey || s?.TypeKey || serverType;
      const quality = s?.Quality || s?.Resolution || '';
      const rawLink = s?.Link || s?.Url || '';
      const urlBuilt = buildStreamingUrl(rawLink, serverTypeKey || serverType);

      let directUrl: string | null = null;
      const typeKeyU = (serverTypeKey || '').toUpperCase();
      if (typeKeyU.includes('MEDIAFIRE')) {
        // Try to extract a direct downloadable link
        directUrl = await extractDirectMediafireUrl(urlBuilt);
      }

      list.push({
        serverName,
        serverType,
        serverTypeKey,
        quality,
        url: urlBuilt,
        directUrl,
      });
    }

    // Group mediafire qualities
    const mediafire = list.filter(s => (s.serverTypeKey || '').toUpperCase().includes('MEDIAFIRE'));
    // Derive best quality by numeric compare
    const parseQ = (q?: string) => {
      const m = (q || '').match(/(\d{3,4})p/i);
      return m ? parseInt(m[1], 10) : 0;
    };
    let best: any | null = null;
    for (const m of mediafire) {
      if (m.directUrl) {
        if (!best || parseQ(m.quality) > parseQ(best.quality)) best = m;
      }
    }

    return new Response(JSON.stringify({ status: 'success', servers: list, mediafire, bestMediafire: best }), {
      status: 200,
      headers: { 'content-type': 'application/json; charset=utf-8' },
    });
  } catch (err: any) {
    return new Response(JSON.stringify({ status: 'error', message: err?.message || 'fetch_failed' }), {
      status: 500,
      headers: { 'content-type': 'application/json; charset=utf-8' },
    });
  }
}
