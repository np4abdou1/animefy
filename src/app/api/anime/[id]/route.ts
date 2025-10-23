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

export async function GET(
  request: NextRequest,
  { params }: { params: Promise<{ id: string }> }
) {
  const corsHeaders = {
    'Access-Control-Allow-Origin': '*',
    'Access-Control-Allow-Methods': 'GET, POST, OPTIONS',
    'Access-Control-Allow-Headers': 'Content-Type',
    'Content-Type': 'application/json',
  };

  try {
    const { id: animeId } = await params;
    
    // Fetch all data in parallel to minimize requests
    const [animeDetails, episodes, characters, relatedAnime] = await Promise.all([
      animeifyRequest('anime/load_anime_details.php', {
        UserId: '0',
        AnimeId: animeId,
        Token: ANIMEIFY_TOKEN
      }),
      animeifyRequest('episodes/load_episodes.php', {
        AnimeID: animeId,
        Token: ANIMEIFY_TOKEN
      }).catch(() => []),
      animeifyRequest('characters/characters_list.php', {
        AnimeId: animeId,
        Token: ANIMEIFY_TOKEN
      }).catch(() => []),
      animeifyRequest('anime/load_related_anime.php', {
        AnimeId: animeId,
        Token: ANIMEIFY_TOKEN
      }).catch(() => [])
    ]);

    return NextResponse.json({
      status: 'success',
      data: {
        anime: animeDetails,
        episodes: episodes || [],
        characters: characters || [],
        related: relatedAnime || []
      }
    }, { headers: corsHeaders });
  } catch (error) {
    return NextResponse.json({
      status: 'error',
      message: 'Failed to fetch anime details',
      error: error instanceof Error ? error.message : 'Unknown error'
    }, { 
      status: 500,
      headers: corsHeaders 
    });
  }
}
