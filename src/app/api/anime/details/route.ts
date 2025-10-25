// export const runtime = 'edge';

import { NextRequest, NextResponse } from 'next/server';

const API_BASE = 'https://animeify.net/animeify/apis_v4/';
const TOKEN = '8cnY80AZSbUCmR26Vku1VUUY4';

/**
 * Search anime by title with multiple fallback strategies
 */
async function performSearch(title: string, type: string, retryCount = 0): Promise<any[]> {
  const maxRetries = 2;
  
  try {
    console.log('performSearch - Title:', title, 'Type:', type, 'Retry:', retryCount);
    
    const response = await fetch(`${API_BASE}anime/load_anime_list_v2.php`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/x-www-form-urlencoded',
        'User-Agent': 'Mozilla/5.0 (compatible; Animeify-Website/1.0)',
      },
      body: new URLSearchParams({
        UserId: '0',
        Language: 'AR',
        FilterType: 'SEARCH',
        FilterData: title,
        Type: type,
        From: '0',
        Token: TOKEN,
      }),
      cache: 'no-store',
    });

    console.log('performSearch - Response status:', response.status);

    if (!response.ok) {
      console.error('performSearch - Response not OK:', response.status, response.statusText);
      
      if (retryCount < maxRetries && (response.status >= 500 || response.status === 0)) {
        console.log('performSearch - Retrying due to server error...');
        await new Promise(resolve => setTimeout(resolve, 1000 * (retryCount + 1)));
        return performSearch(title, type, retryCount + 1);
      }
      
      return [];
    }

    const data = await response.json();
    console.log('performSearch - Response data:', JSON.stringify(data).substring(0, 200));
    
    const results = Array.isArray(data) ? data : (Array.isArray(data.value) ? data.value : []);
    console.log('performSearch - Results count:', results.length);
    
    return results;
  } catch (error) {
    console.error('performSearch - Error:', error);
    
    if (retryCount < maxRetries && (error instanceof Error && (error.name === 'AbortError' || error.message.includes('fetch')))) {
      console.log('performSearch - Retrying due to network error...');
      await new Promise(resolve => setTimeout(resolve, 1000 * (retryCount + 1)));
      return performSearch(title, type, retryCount + 1);
    }
    
    return [];
  }
}

/**
 * Get anime details (plot, statistics, related anime)
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
 * Get anime episodes
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
 * Get complete anime data by title and type
 */
async function getCompleteAnimeDataByTitle(searchTitle: string, type: string = 'SERIES') {
  try {
    console.log('API - Searching for:', searchTitle, 'Type:', type);
    
    // Create comprehensive search variations
    const searchVariations: string[] = [];
    
    // 1. Original title (exactly as provided)
    searchVariations.push(searchTitle);
    
    // 2. Clean spaces
    const cleanedTitle = searchTitle.replace(/\s+/g, ' ').trim();
    if (cleanedTitle !== searchTitle) {
      searchVariations.push(cleanedTitle);
    }
    
    // 3. Replace hyphens with spaces (for slugs like "5-toubun-no-hanayome" -> "5 toubun no hanayome")
    const hyphenToSpace = searchTitle.replace(/-/g, ' ').replace(/\s+/g, ' ').trim();
    if (hyphenToSpace !== searchTitle && !searchVariations.includes(hyphenToSpace)) {
      searchVariations.push(hyphenToSpace);
    }
    
    // 4. Capitalize each word (for better matching)
    const capitalized = searchTitle
      .replace(/-/g, ' ')
      .split(' ')
      .map(word => word.charAt(0).toUpperCase() + word.slice(1).toLowerCase())
      .join(' ');
    if (!searchVariations.includes(capitalized)) {
      searchVariations.push(capitalized);
    }
    
    // 5. Try first 3 words
    const words = cleanedTitle.split(' ');
    if (words.length > 3) {
      searchVariations.push(words.slice(0, 3).join(' '));
    }
    
    // 6. Try first 2 words
    if (words.length > 2) {
      searchVariations.push(words.slice(0, 2).join(' '));
    }
    
    // 7. Try first word only (last resort)
    if (words.length > 1) {
      searchVariations.push(words[0]);
    }

    console.log('API - Search variations:', searchVariations);

    // Try each variation with both specified type and ALL types
    for (let i = 0; i < searchVariations.length; i++) {
      const variation = searchVariations[i];
      
      // Try with specified type first
      console.log(`API - Trying variation ${i + 1}:`, variation, 'with type:', type);
      let searchResults = await performSearch(variation, type);
      console.log(`API - Results for "${variation}" + ${type}:`, searchResults?.length || 0);
      
      if (searchResults && searchResults.length > 0) {
        const anime = searchResults[0];
        console.log('API - Found anime:', anime.EN_Title, 'ID:', anime.AnimeId);
        
        // Edge Runtime compatible parallel requests
        const [details, episodes] = await Promise.allSettled([
          getAnimeDetails(anime.AnimeId, anime.RelationId),
          getAnimeEpisodes(anime.AnimeId),
        ]);

        return { 
          anime, 
          details: details.status === 'fulfilled' ? details.value : null,
          episodes: episodes.status === 'fulfilled' ? episodes.value : []
        };
      }

      // Try with ALL types
      console.log(`API - Trying variation ${i + 1}:`, variation, 'with type: ALL');
      searchResults = await performSearch(variation, 'ALL');
      console.log(`API - Results for "${variation}" + ALL:`, searchResults?.length || 0);
      
      if (searchResults && searchResults.length > 0) {
        const anime = searchResults[0];
        console.log('API - Found anime:', anime.EN_Title, 'ID:', anime.AnimeId);
        
        // Edge Runtime compatible parallel requests
        const [details, episodes] = await Promise.allSettled([
          getAnimeDetails(anime.AnimeId, anime.RelationId),
          getAnimeEpisodes(anime.AnimeId),
        ]);

        return { 
          anime, 
          details: details.status === 'fulfilled' ? details.value : null,
          episodes: episodes.status === 'fulfilled' ? episodes.value : []
        };
      }
    }

    console.error('API - No results found for any variation');
    return null;
  } catch (error) {
    console.error('Get complete anime data by title error:', error);
    return null;
  }
}

export async function GET(request: NextRequest) {
  try {
    const { searchParams } = new URL(request.url);
    const title = searchParams.get('title');
    const type = searchParams.get('type') || 'SERIES';
    
    if (!title) {
      return NextResponse.json({ error: 'Title parameter is required' }, { status: 400 });
    }

    console.log('Anime details API - Title:', title, 'Type:', type);
    
    const data = await getCompleteAnimeDataByTitle(title, type);
    
    if (!data || !data.anime) {
      console.error('Anime details API - No data found for', title, type);
      return NextResponse.json({ error: 'Anime not found' }, { status: 404 });
    }

    console.log('Anime details API - Data found:', !!data, 'anime:', !!data?.anime);
    
    return NextResponse.json(data);
  } catch (error) {
    console.error('Anime details API error:', error);
    
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
