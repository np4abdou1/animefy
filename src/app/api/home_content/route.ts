import { NextResponse } from 'next/server';

export const runtime = 'edge';

const ANIMEIFY_API_BASE = "https://animeify.net/animeify/apis_v4/";
const ANIMEIFY_TOKEN = "8cnY80AZSbUCmR26Vku1VUUY4";

// Helper to make requests to Animeify API
async function animeifyRequest(endpoint: string, params: Record<string, string>) {
  const url = ANIMEIFY_API_BASE + endpoint;
  
  // Build form data as URL-encoded string
  const formBody = Object.keys(params)
    .map(key => encodeURIComponent(key) + '=' + encodeURIComponent(params[key]))
    .join('&');
  
  const response = await fetch(url, {
    method: 'POST',
    headers: {
      'Content-Type': 'application/x-www-form-urlencoded',
    },
    body: formBody
  });
  
  if (!response.ok) {
    throw new Error(`API request failed: ${response.status}`);
  }
  
  return await response.json();
}

// Get current day of week in format API expects
function getCurrentDayOfWeek() {
  const days = ['SUNDAY', 'MONDAY', 'TUESDAY', 'WEDNESDAY', 'THURSDAY', 'FRIDAY', 'SATURDAY'];
  return days[new Date().getDay()];
}

// Get current season
function getCurrentSeason() {
  const month = new Date().getMonth() + 1;
  const year = new Date().getFullYear();
  
  if (month >= 1 && month <= 3) return `WINTER ${year}`;
  if (month >= 4 && month <= 6) return `SPRING ${year}`;
  if (month >= 7 && month <= 9) return `SUMMER ${year}`;
  return `FALL ${year}`;
}

export async function GET() {
  const corsHeaders = {
    'Access-Control-Allow-Origin': '*',
    'Access-Control-Allow-Methods': 'GET, POST, OPTIONS',
    'Access-Control-Allow-Headers': 'Content-Type',
    'Content-Type': 'application/json',
  };

  try {
    // Fetch main home data (includes latest episodes, airing today, premiered anime, news)
    const homeData = await animeifyRequest('home/load_home.php', {
      UserId: '0',
      Language: 'English',
      Broadcast: getCurrentDayOfWeek(),
      Premiered: getCurrentSeason(),
      Token: ANIMEIFY_TOKEN
    });

    // Fetch trending/popular anime slider
    const trendingData = await animeifyRequest('home/load_trending.php', {
      UserId: '0',
      Language: 'English',
      Token: ANIMEIFY_TOKEN
    });

    // Return aggregated data
    return NextResponse.json({
      status: 'success',
      data: {
        latestEpisodes: homeData.LatestEpisodes || [],
        airingToday: homeData.Broadcast || [],
        premieredAnime: homeData.Premiere || [],
        latestNews: homeData.LatestNews || [],
        trending: trendingData || [],
        updatesChart: homeData.UpdatesChart || null,
        currentDay: getCurrentDayOfWeek(),
        currentSeason: getCurrentSeason(),
        timestamp: new Date().toISOString()
      }
    }, { headers: corsHeaders });
  } catch (error) {
    return NextResponse.json({
      status: 'error',
      message: 'Failed to fetch home content',
      error: error instanceof Error ? error.message : 'Unknown error'
    }, { 
      status: 500,
      headers: corsHeaders 
    });
  }
}
