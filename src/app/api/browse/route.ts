import { NextRequest, NextResponse } from 'next/server';

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

export async function GET(request: NextRequest) {
  const corsHeaders = {
    'Access-Control-Allow-Origin': '*',
    'Access-Control-Allow-Methods': 'GET, POST, OPTIONS',
    'Access-Control-Allow-Headers': 'Content-Type',
    'Content-Type': 'application/json',
  };

  try {
    const { searchParams } = new URL(request.url);
    const type = searchParams.get('type') || ''; // SERIES, MOVIE, OVA, SPECIAL
    const genre = searchParams.get('genre') || '';
    const studio = searchParams.get('studio') || '';
    const status = searchParams.get('status') || ''; // AIRING, AIRED, UPCOMING
    const season = searchParams.get('season') || '';
    const sortBy = searchParams.get('sortBy') || ''; // LATEST, POPULAR, RATING, NAME
    const from = searchParams.get('from') || '0';
    
    // Determine filter type based on parameters (priority order)
    let filterType = '';
    let filterData = '';
    
    // Priority: genre > studio > season > status > sort
    if (genre) {
      filterType = 'GENRE';
      filterData = genre;
    } else if (studio) {
      filterType = 'STUDIOS';
      filterData = studio;
    } else if (season) {
      filterType = 'PREMIERED';
      filterData = season;
    } else if (status) {
      filterType = 'STATUS';
      filterData = status;
    } else if (sortBy) {
      // Sort filters
      if (sortBy === 'POPULAR') {
        // Don't send FilterType for popular - API returns by popularity by default
        filterType = '';
        filterData = '';
      } else if (sortBy === 'RATING') {
        filterType = 'SORT';
        filterData = 'HIGHEST_RATE';
      } else if (sortBy === 'NAME') {
        filterType = 'SORT';
        filterData = 'NAME';
      } else if (sortBy === 'LATEST') {
        filterType = 'SORT';
        filterData = 'PREMIERED_DEC';
      } else if (sortBy === 'EPISODES') {
        filterType = 'SORT';
        filterData = 'EPISODES_DEC';
      }
    }

    const data = await animeifyRequest('anime/load_anime_list_v2.php', {
      UserId: '0',
      Language: 'English',
      FilterType: filterType,
      FilterData: filterData,
      Type: type,
      From: from,
      Token: ANIMEIFY_TOKEN
    });

    return NextResponse.json({
      status: 'success',
      data: data,
      filters: {
        type,
        genre,
        studio,
        status,
        season,
        sortBy
      },
      pagination: {
        from: from,
        hasMore: data && data.length >= 20
      }
    }, { headers: corsHeaders });
  } catch (error) {
    return NextResponse.json({
      status: 'error',
      message: 'Browse failed',
      error: error instanceof Error ? error.message : 'Unknown error'
    }, { 
      status: 500,
      headers: corsHeaders 
    });
  }
}
