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
    const query = searchParams.get('q') || '';
    const type = searchParams.get('type') || 'SERIES';
    const from = searchParams.get('from') || '0';
    
    if (!query) {
      return NextResponse.json({
        status: 'error',
        message: 'Search query is required'
      }, { 
        status: 400,
        headers: corsHeaders 
      });
    }

    const data = await animeifyRequest('anime/load_anime_list_v2.php', {
      UserId: '0',
      Language: 'English',
      FilterType: 'SEARCH',
      FilterData: query,
      Type: type,
      From: from,
      Token: ANIMEIFY_TOKEN
    });

    return NextResponse.json({
      status: 'success',
      data: data,
      pagination: {
        from: from,
        hasMore: data && data.length >= 20
      }
    }, { headers: corsHeaders });
  } catch (error) {
    return NextResponse.json({
      status: 'error',
      message: 'Search failed',
      error: error instanceof Error ? error.message : 'Unknown error'
    }, { 
      status: 500,
      headers: corsHeaders 
    });
  }
}
