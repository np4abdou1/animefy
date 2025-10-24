export const runtime = 'edge';

// Animeify API constants
const ANIMEIFY_API_BASE = 'https://animeify.net/animeify/apis_v4/';
const ANIMEIFY_TOKEN = '8cnY80AZSbUCmR26Vku1VUUY4';

async function postForm(url: string, data: Record<string, string>) {
  const body = new URLSearchParams(data);
  const res = await fetch(url, {
    method: 'POST',
    headers: {
      'Accept': 'application/json, text/plain, */*',
      'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8'
    },
    body,
  });
  if (!res.ok) throw new Error(`HTTP ${res.status}`);
  return await res.json();
}

export async function GET(request: Request) {
  try {
    const url = new URL(request.url);
    const q = url.searchParams.get('q') || '';
    const type = (url.searchParams.get('type') || 'SERIES').toUpperCase();
    const from = url.searchParams.get('from') || '0';

    // Call Animeify search
    const payload: Record<string, string> = {
      UserId: '0',
      Language: 'English',
      FilterType: 'SEARCH',
      FilterData: q,
      Type: type,
      From: from,
      Token: ANIMEIFY_TOKEN,
    };
    const data = await postForm(ANIMEIFY_API_BASE + 'anime/load_anime_list_v2.php', payload);
    const list = Array.isArray(data) ? data : [];

    // Match the shape your UI expects from the old worker
    const pageSize = 20;
    const hasMore = list.length >= pageSize;
    return new Response(JSON.stringify({
      status: 'success',
      data: list,
      pagination: { hasMore },
    }), { status: 200, headers: { 'content-type': 'application/json; charset=utf-8' } });
  } catch (err: any) {
    return new Response(JSON.stringify({ status: 'error', message: err?.message || 'fetch_failed' }), {
      status: 500,
      headers: { 'content-type': 'application/json; charset=utf-8' },
    });
  }
}
