/**
 * Server-side Animeify API client
 * All API calls are made server-side to protect API endpoints
 */

const API_BASE = 'https://animeify.net/animeify/apis_v4/';
const TOKEN = '8cnY80AZSbUCmR26Vku1VUUY4';

export interface AnimeBasic {
  Id: string;
  AnimeId: string;
  EN_Title: string;
  JP_Title?: string;
  AR_Title?: string;
  Synonyms?: string;
  Tags?: string;
  Genres: string;
  Season?: string;
  Premiered?: string;
  Aired?: string;
  Broadcast?: string;
  Duration?: string;
  Thumbnail: string;
  Trailer?: string;
  YTTrailer?: string;
  Creators?: string;
  Status: string;
  Episodes: string;
  Score?: string;
  Rank?: string;
  Popularity?: string;
  Rating?: string;
  RelationId?: string;
  MalId?: string;
  Type: string;
  anime_id: string;
  rates_1?: string;
  rates_2?: string;
  rates_3?: string;
  rates_4?: string;
  rates_5?: string;
  rates_6?: string;
  rates_7?: string;
  rates_8?: string;
  rates_9?: string;
  rates_10?: string;
  library_favourites?: string;
  library_watch_done?: string;
  library_watch_later?: string;
  library_watch_currently?: string;
  views?: string;
}

export interface AnimeDetails {
  Plot: string;
  AnimeStatistics: {
    UserRate: number;
    rates_1: string;
    rates_2: string;
    rates_3: string;
    rates_4: string;
    rates_5: string;
    rates_6: string;
    rates_7: string;
    rates_8: string;
    rates_9: string;
    rates_10: string;
    library_favourites: string;
    library_watch_done: string;
    library_watch_later: string;
    library_watch_currently: string;
    views: string;
  };
  Library: {
    Favourite: number;
    Library: string | null;
  };
  RelatedAnime: AnimeBasic[];
}

export interface Episode {
  eId: string;
  AnimeID: string;
  Episode: string;
  ExtraEpisodes?: string;
  Type?: string;
  MarkedAs?: string;
  Released?: string;
  ViewStatus?: string;
  // Streaming links
  LBLink?: string;
  SVLink?: string;
  OKLink?: string;
  MALink?: string;
  FHLink?: string;
  GDLink?: string;
  FRLink?: string;
  SFLink?: string;
  FDLink?: string;
}

/**
 * Search anime by title with multiple fallback strategies
 * Returns complete anime metadata
 */
export async function searchAnime(title: string, type: string = 'SERIES'): Promise<AnimeBasic[]> {
  try {
    // Strategy 1: Search with exact title and type
    let results = await performSearch(title, type);
    if (results.length > 0) return results;

    // Strategy 2: Search with exact title, all types
    results = await performSearch(title, 'ALL');
    if (results.length > 0) return results;

    // Strategy 3: Remove common suffixes and try again
    // "Africa No Salaryman Tv" -> "Africa No Salaryman"
    const cleanTitle = title
      .replace(/\s+(TV|Movie|OVA|Special|ONA)$/i, '')
      .trim();
    
    if (cleanTitle !== title) {
      results = await performSearch(cleanTitle, 'ALL');
      if (results.length > 0) return results;
    }

    // Strategy 4: Try with first 3 words only (for long titles)
    const words = title.split(' ');
    if (words.length > 3) {
      const shortTitle = words.slice(0, 3).join(' ');
      results = await performSearch(shortTitle, 'ALL');
      if (results.length > 0) return results;
    }

    // Strategy 5: Try with first 2 words (last resort)
    if (words.length > 2) {
      const veryShortTitle = words.slice(0, 2).join(' ');
      results = await performSearch(veryShortTitle, 'ALL');
      if (results.length > 0) return results;
    }

    return [];
  } catch (error) {
    console.error('Search anime error:', error);
    return [];
  }
}

/**
 * Helper function to perform a single search request
 */
async function performSearch(title: string, type: string): Promise<AnimeBasic[]> {
  try {
    console.log('performSearch - Title:', title, 'Type:', type);
    
    const response = await fetch(`${API_BASE}anime/load_anime_list_v2.php`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/x-www-form-urlencoded',
      },
      body: new URLSearchParams({
        UserId: '0',
        Language: 'AR', // Use Arabic to get AR_Title and Arabic data
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
      return [];
    }

    const data = await response.json();
    console.log('performSearch - Response data:', JSON.stringify(data).substring(0, 200));
    console.log('performSearch - Data type:', typeof data);
    console.log('performSearch - Is array?:', Array.isArray(data));
    console.log('performSearch - Has value property?:', 'value' in data);
    console.log('performSearch - Data keys:', Object.keys(data));
    
    // The API returns an array directly, not wrapped in {value: [...]}
    const results = Array.isArray(data) ? data : (Array.isArray(data.value) ? data.value : []);
    console.log('performSearch - Results count:', results.length);
    
    if (results.length > 0) {
      console.log('performSearch - First result:', results[0].EN_Title, results[0].AnimeId);
    }
    
    return results;
  } catch (error) {
    console.error('performSearch - Error:', error);
    return [];
  }
}

/**
 * Get anime details (plot, statistics, related anime)
 * Uses Arabic language to get Arabic descriptions
 */
export async function getAnimeDetails(animeId: string, relationId?: string): Promise<AnimeDetails | null> {
  try {
    const response = await fetch(`${API_BASE}anime/load_anime_details.php`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/x-www-form-urlencoded',
      },
      body: new URLSearchParams({
        UserId: '0',
        Language: 'AR', // Use Arabic to get Arabic plot/description
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
export async function getAnimeEpisodes(animeId: string): Promise<Episode[]> {
  try {
    console.log('getAnimeEpisodes - AnimeID:', animeId);
    
    const response = await fetch(`${API_BASE}episodes/load_episodes.php`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/x-www-form-urlencoded',
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
    console.log('getAnimeEpisodes - Is array?:', Array.isArray(data));
    console.log('getAnimeEpisodes - Has value property?:', 'value' in data);
    console.log('getAnimeEpisodes - Response sample:', JSON.stringify(data).substring(0, 200));
    
    // Check if data is array directly or wrapped in value
    const results = Array.isArray(data) ? data : (Array.isArray(data.value) ? data.value : []);
    console.log('getAnimeEpisodes - Episodes count:', results.length);
    
    if (results.length > 0) {
      console.log('getAnimeEpisodes - First episode:', results[0].Episode);
    }
    
    return results;
  } catch (error) {
    console.error('Get anime episodes error:', error);
    return [];
  }
}

/**
 * Get complete anime data by AnimeId (RECOMMENDED - most reliable)
 * Use this when you have the AnimeId from the anime card
 */
export async function getCompleteAnimeDataById(animeId: string) {
  try {
    // First, get the anime basic data with Arabic language
    const searchResults = await performSearch(animeId.replace(/^x/, ''), 'ALL');
    
    if (!searchResults || searchResults.length === 0) {
      return null;
    }

    const anime = searchResults[0];

    // Fetch details (with Arabic description) and episodes in parallel
    const [details, episodes] = await Promise.all([
      getAnimeDetails(anime.AnimeId, anime.RelationId),
      getAnimeEpisodes(anime.AnimeId),
    ]);

    return {
      anime,
      details,
      episodes,
    };
  } catch (error) {
    console.error('Get complete anime data by ID error:', error);
    return null;
  }
}

/**
 * Get complete anime data by title and type (OPTIMIZED - RECOMMENDED)
 * This is the fastest and most accurate method
 * 
 * Flow:
 * 1. Search by title + type → Get AnimeId
 * 2. Fetch details + episodes in parallel → Get everything
 */
export async function getCompleteAnimeDataByTitle(searchTitle: string, type: string = 'SERIES') {
  try {
    console.log('API - Searching for:', searchTitle, 'Type:', type);
    
    // Try multiple search variations to handle special characters
    const searchVariations = [
      searchTitle, // Original: "Death Note"
      searchTitle.replace(/\s+/g, ' ').trim(), // Clean spaces
      searchTitle.split(' ').slice(0, 3).join(' '), // First 3 words
      searchTitle.split(' ').slice(0, 2).join(' '), // First 2 words
      searchTitle.split(' ')[0], // First word only
    ];

    console.log('API - Search variations:', searchVariations);

    for (let i = 0; i < searchVariations.length; i++) {
      const variation = searchVariations[i];
      console.log(`API - Trying variation ${i + 1}:`, variation, 'with type:', type);
      
      // Try with specified type first
      let searchResults = await performSearch(variation, type);
      console.log(`API - Results for "${variation}" + ${type}:`, searchResults?.length || 0);
      
      if (searchResults && searchResults.length > 0) {
        const anime = searchResults[0];
        console.log('API - Found anime:', anime.EN_Title, 'ID:', anime.AnimeId);
        
        // Fetch details and episodes in PARALLEL (FAST!)
        const [details, episodes] = await Promise.all([
          getAnimeDetails(anime.AnimeId, anime.RelationId),
          getAnimeEpisodes(anime.AnimeId),
        ]);

        return { anime, details, episodes };
      }

      // Try with ALL types
      console.log(`API - Trying variation ${i + 1}:`, variation, 'with type: ALL');
      searchResults = await performSearch(variation, 'ALL');
      console.log(`API - Results for "${variation}" + ALL:`, searchResults?.length || 0);
      
      if (searchResults && searchResults.length > 0) {
        const anime = searchResults[0];
        console.log('API - Found anime:', anime.EN_Title, 'ID:', anime.AnimeId);
        
        // Fetch details and episodes in PARALLEL (FAST!)
        const [details, episodes] = await Promise.all([
          getAnimeDetails(anime.AnimeId, anime.RelationId),
          getAnimeEpisodes(anime.AnimeId),
        ]);

        return { anime, details, episodes };
      }
    }

    console.error('API - No results found for any variation');
    return null;
  } catch (error) {
    console.error('Get complete anime data by title error:', error);
    return null;
  }
}

/**
 * Get complete anime data by title search (fallback method)
 * @deprecated Use getCompleteAnimeDataByTitle instead
 */
export async function getCompleteAnimeData(searchTitle: string) {
  return getCompleteAnimeDataByTitle(searchTitle, 'SERIES');
}
