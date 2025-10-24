export const runtime = 'edge';

const ANIMEIFY_API_BASE = "https://animeify.net/animeify/apis_v4/";
const ANIMEIFY_TOKEN = "8cnY80AZSbUCmR26Vku1VUUY4";

export async function GET() {
  try {
    // Get current day for airing today
    const days = ["SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY"];
    const currentDay = days[new Date().getDay()];

    // Fetch airing today
    const airingUrl = `${ANIMEIFY_API_BASE}anime/load_anime_list_v2.php`;
    const airingBody = new URLSearchParams({
      UserId: '0',
      Language: 'AR',
      FilterType: 'AIRING_DAY',
      FilterData: currentDay,
      Type: 'SERIES',
      From: '0',
      Token: ANIMEIFY_TOKEN
    });

    const airingRes = await fetch(airingUrl, {
      method: 'POST',
      headers: {
        'Accept': 'application/json, text/plain, */*',
        'Content-Type': 'application/x-www-form-urlencoded',
        'X-Requested-With': 'XMLHttpRequest',
      },
      body: airingBody.toString(),
    });

    let airingToday = [];
    if (airingRes.ok) {
      try {
        airingToday = await airingRes.json();
      } catch (e) {
        airingToday = [];
      }
    }

    // Fetch latest episodes
    const latestUrl = `${ANIMEIFY_API_BASE}episodes/load_latest_episodes.php`;
    const latestBody = new URLSearchParams({
      UserId: '0',
      Language: 'AR',
      From: '0',
      Token: ANIMEIFY_TOKEN
    });

    const latestRes = await fetch(latestUrl, {
      method: 'POST',
      headers: {
        'Accept': 'application/json, text/plain, */*',
        'Content-Type': 'application/x-www-form-urlencoded',
        'X-Requested-With': 'XMLHttpRequest',
      },
      body: latestBody.toString(),
    });

    let latestEpisodes = [];
    if (latestRes.ok) {
      try {
        latestEpisodes = await latestRes.json();
      } catch (e) {
        latestEpisodes = [];
      }
    }

    // Fetch trending
    const trendingUrl = `${ANIMEIFY_API_BASE}trending/load_trending.php`;
    const trendingBody = new URLSearchParams({
      UserId: '0',
      Token: ANIMEIFY_TOKEN
    });

    const trendingRes = await fetch(trendingUrl, {
      method: 'POST',
      headers: {
        'Accept': 'application/json, text/plain, */*',
        'Content-Type': 'application/x-www-form-urlencoded',
        'X-Requested-With': 'XMLHttpRequest',
      },
      body: trendingBody.toString(),
    });

    let trending = [];
    if (trendingRes.ok) {
      try {
        trending = await trendingRes.json();
      } catch (e) {
        trending = [];
      }
    }

    const responseData = {
      status: 'success',
      data: {
        airingToday: Array.isArray(airingToday) ? airingToday : [],
        latestEpisodes: Array.isArray(latestEpisodes) ? latestEpisodes : [],
        trending: Array.isArray(trending) ? trending : []
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
