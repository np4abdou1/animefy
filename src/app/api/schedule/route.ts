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
    const days = ['SUNDAY', 'MONDAY', 'TUESDAY', 'WEDNESDAY', 'THURSDAY', 'FRIDAY', 'SATURDAY'];
    const schedule: Record<string, any[]> = {};
    
    // Fetch airing anime for each day
    const dayPromises = days.map(async (day) => {
      const data = await animeifyRequest('home/load_home.php', {
        UserId: '0',
        Language: 'English',
        Broadcast: day,
        Premiered: getCurrentSeason(),
        Token: ANIMEIFY_TOKEN
      });
      return { day, animes: data.Broadcast || [] };
    });
    
    const dayResults = await Promise.all(dayPromises);
    dayResults.forEach(({ day, animes }) => {
      schedule[day] = animes;
    });

    // Fetch seasons (current and recent)
    const currentYear = new Date().getFullYear();
    const seasons = ['WINTER', 'SPRING', 'SUMMER', 'FALL'];
    const seasonPromises = [];
    
    // Get current and past 2 seasons
    for (let yearOffset = 0; yearOffset < 2; yearOffset++) {
      for (const season of seasons) {
        const seasonYear = currentYear - yearOffset;
        const seasonName = `${season} ${seasonYear}`;
        
        seasonPromises.push(
          animeifyRequest('anime/load_anime_list_v2.php', {
            UserId: '0',
            Language: 'English',
            FilterType: 'PREMIERED',
            FilterData: seasonName,
            Type: '',
            From: '0',
            Token: ANIMEIFY_TOKEN
          }).then(animes => ({ season: seasonName, animes: animes || [] }))
        );
      }
    }
    
    const seasonResults = await Promise.all(seasonPromises);
    // Sort seasons by recency
    const sortedSeasons = seasonResults.sort((a, b) => {
      const yearA = parseInt(a.season.split(' ')[1]);
      const yearB = parseInt(b.season.split(' ')[1]);
      if (yearA !== yearB) return yearB - yearA;
      return seasons.indexOf(b.season.split(' ')[0]) - seasons.indexOf(a.season.split(' ')[0]);
    });

    return NextResponse.json({
      status: 'success',
      data: {
        schedule,
        seasons: sortedSeasons
      }
    }, { headers: corsHeaders });
  } catch (error) {
    return NextResponse.json({
      status: 'error',
      message: 'Failed to fetch schedule',
      error: error instanceof Error ? error.message : 'Unknown error'
    }, { 
      status: 500,
      headers: corsHeaders 
    });
  }
}
