export const runtime = 'edge';

const ANIMEIFY_API_BASE = "https://animeify.net/animeify/apis_v4/";
const ANIMEIFY_TOKEN = "8cnY80AZSbUCmR26Vku1VUUY4";

export async function GET(request: Request) {
  try {
    const url = new URL(request.url);
    const type = url.searchParams.get('type') || 'SERIES';
    const genre = url.searchParams.get('genre') || '';
    const from = url.searchParams.get('from') || '0';

    const apiUrl = `${ANIMEIFY_API_BASE}anime/load_anime_list_v2.php`;
    
    let filterType = 'ALL';
    let filterData = '';
    
    if (genre) {
      filterType = 'GENRE';
      filterData = genre;
    }

    const body = new URLSearchParams({
      UserId: '0',
      Language: 'AR',
      FilterType: filterType,
      FilterData: filterData,
      Type: type.toUpperCase(),
      From: from,
      Token: ANIMEIFY_TOKEN
    });

    const res = await fetch(apiUrl, {
      method: 'POST',
      headers: {
        'Accept': 'application/json, text/plain, */*',
        'Content-Type': 'application/x-www-form-urlencoded',
        'X-Requested-With': 'XMLHttpRequest',
      },
      body: body.toString(),
    });

    if (!res.ok) {
      return new Response(
        JSON.stringify({ status: 'error', message: `API ${res.status}` }),
        { status: 502, headers: { 'content-type': 'application/json; charset=utf-8' } }
      );
    }

    const data = await res.json();
    const animeList = Array.isArray(data) ? data : [];
    
    // Debug: Log first anime to see available fields
    if (animeList.length > 0) {
      console.log('[Browse API] Sample anime fields:', Object.keys(animeList[0]));
      console.log('[Browse API] Sample anime data:', animeList[0]);
    }
    
    // Pagination logic: assume 20 items per page
    const hasMore = animeList.length >= 20;

    const responseData = {
      status: 'success',
      data: animeList,
      pagination: {
        from: parseInt(from),
        count: animeList.length,
        hasMore: hasMore
      }
    };

    return new Response(
      JSON.stringify(responseData),
      { 
        status: 200, 
        headers: { 
          'content-type': 'application/json; charset=utf-8',
          'Cache-Control': 'public, s-maxage=300, stale-while-revalidate=600'
        } 
      }
    );
  } catch (err: any) {
    return new Response(
      JSON.stringify({ status: 'error', message: err?.message || 'fetch_failed' }),
      { status: 500, headers: { 'content-type': 'application/json; charset=utf-8' } }
    );
  }
}
