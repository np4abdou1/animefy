export const runtime = 'edge';

const ANIMEIFY_API_BASE = "https://animeify.net/animeify/apis_v4/";
const ANIMEIFY_TOKEN = "8cnY80AZSbUCmR26Vku1VUUY4";

export async function GET() {
  try {
    const days = ["SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY"];
    const schedule: any = {};

    // Fetch anime for each day
    for (const day of days) {
      const apiUrl = `${ANIMEIFY_API_BASE}anime/load_anime_list_v2.php`;
      const body = new URLSearchParams({
        UserId: '0',
        Language: 'AR',
        FilterType: 'AIRING_DAY',
        FilterData: day,
        Type: 'SERIES',
        From: '0',
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

      if (res.ok) {
        try {
          const data = await res.json();
          schedule[day] = Array.isArray(data) ? data : [];
        } catch (e) {
          schedule[day] = [];
        }
      } else {
        schedule[day] = [];
      }
    }

    const responseData = {
      status: 'success',
      data: schedule
    };

    return new Response(
      JSON.stringify(responseData),
      { 
        status: 200, 
        headers: { 
          'content-type': 'application/json; charset=utf-8',
          'Cache-Control': 'public, s-maxage=600, stale-while-revalidate=1200'
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
