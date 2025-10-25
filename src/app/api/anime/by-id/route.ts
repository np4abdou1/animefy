export const runtime = 'edge';

import { NextRequest, NextResponse } from 'next/server';

const API_BASE = 'https://animeify.net/animeify/apis_v4/';
const TOKEN = '8cnY80AZSbUCmR26Vku1VUUY4';

/**
 * Get anime details by AnimeId
 */
async function getAnimeDetails(animeId: string, relationId?: string): Promise<any | null> {
  try {
    const response = await fetch(`${API_BASE}anime/load_anime_details.php`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/x-www-form-urlencoded',
        'User-Agent': 'Mozilla/5.0 (compatible; Animeify-Website/1.0)',
      },
      body: new URLSearchParams({
        UserId: '0',
        Language: 'AR',
        AnimeId: animeId,
        AnimeRelationId: relationId || '',
        Token: TOKEN,
      }),
      cache: 'no-store',
    });

    if (!response.ok) {
      throw new Error(`API error: ${response.status}`);
    }

    return await response.json();
  } catch (error) {
    console.error('Get anime details error:', error);
    return null;
  }
}

/**
 * Get anime episodes by AnimeId
 */
async function getAnimeEpisodes(animeId: string): Promise<any[]> {
  try {
    console.log('getAnimeEpisodes - AnimeID:', animeId);
    
    const response = await fetch(`${API_BASE}episodes/load_episodes.php`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/x-www-form-urlencoded',
        'User-Agent': 'Mozilla/5.0 (compatible; Animeify-Website/1.0)',
      },
      body: new URLSearchParams({
        AnimeID: animeId,
        Token: TOKEN,
      }),
      cache: 'no-store',
    });

    console.log('getAnimeEpisodes - Response status:', response.status);

    if (!response.ok) {
      throw new Error(`API error: ${response.status}`);
    }

    const data = await response.json();
    console.log('getAnimeEpisodes - Response data type:', typeof data);
    
    const results = Array.isArray(data) ? data : (Array.isArray(data.value) ? data.value : []);
    console.log('getAnimeEpisodes - Episodes count:', results.length);
    
    return results;
  } catch (error) {
    console.error('Get anime episodes error:', error);
    return [];
  }
}

/**
 * Get anime basic info by AnimeId
 */
async function getAnimeBasicInfo(animeId: string): Promise<any | null> {
  try {
    // First try to get basic anime info from the details endpoint
    const details = await getAnimeDetails(animeId);
    
    if (details && details.Anime) {
      return details.Anime;
    }
    
    // If that doesn't work, we might need to search for it
    // This is a fallback - in practice, the details endpoint should return the anime info
    return null;
  } catch (error) {
    console.error('Get anime basic info error:', error);
    return null;
  }
}

/**
 * Get complete anime data by AnimeId
 */
async function getCompleteAnimeDataById(animeId: string) {
  try {
    console.log('API - Getting anime data for ID:', animeId);
    
    // Get basic anime info, details, and episodes in parallel
    const [anime, details, episodes] = await Promise.allSettled([
      getAnimeBasicInfo(animeId),
      getAnimeDetails(animeId),
      getAnimeEpisodes(animeId),
    ]);

    const animeData = anime.status === 'fulfilled' ? anime.value : null;
    const detailsData = details.status === 'fulfilled' ? details.value : null;
    const episodesData = episodes.status === 'fulfilled' ? episodes.value : [];

    if (!animeData) {
      console.error('API - No anime data found for ID:', animeId);
      return null;
    }

    return { 
      anime: animeData, 
      details: detailsData,
      episodes: episodesData
    };
  } catch (error) {
    console.error('Get complete anime data by ID error:', error);
    return null;
  }
}

export async function GET(request: NextRequest) {
  try {
    const { searchParams } = new URL(request.url);
    const animeId = searchParams.get('id');
    
    if (!animeId) {
      return NextResponse.json({ error: 'AnimeId parameter is required' }, { status: 400 });
    }

    console.log('Anime by ID API - AnimeId:', animeId);
    
    // Add timeout and retry logic for edge runtime
    const controller = new AbortController();
    const timeoutId = setTimeout(() => controller.abort(), 30000); // 30 second timeout
    
    try {
      const data = await getCompleteAnimeDataById(animeId);
      clearTimeout(timeoutId);
      
      if (!data || !data.anime) {
        console.error('Anime by ID API - No data found for', animeId);
        return NextResponse.json({ error: 'Anime not found' }, { status: 404 });
      }

      console.log('Anime by ID API - Data found:', !!data, 'anime:', !!data?.anime);
      
      return NextResponse.json(data);
    } catch (error) {
      clearTimeout(timeoutId);
      throw error;
    }
  } catch (error) {
    console.error('Anime by ID API error:', error);
    
    // Handle specific edge runtime errors
    if (error instanceof Error) {
      if (error.name === 'AbortError') {
        return NextResponse.json({ error: 'Request timeout' }, { status: 408 });
      }
      if (error.message.includes('fetch')) {
        return NextResponse.json({ error: 'Network error' }, { status: 503 });
      }
    }
    
    return NextResponse.json({ error: 'Failed to fetch anime details' }, { status: 500 });
  }
}
