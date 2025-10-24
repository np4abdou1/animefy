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
 * Search anime by title
 * Returns complete anime metadata
 */
export async function searchAnime(title: string, type: string = 'SERIES'): Promise<AnimeBasic[]> {
  try {
    const response = await fetch(`${API_BASE}anime/load_anime_list_v2.php`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/x-www-form-urlencoded',
      },
      body: new URLSearchParams({
        UserId: '0',
        Language: 'EN',
        FilterType: 'SEARCH',
        FilterData: title,
        Type: type,
        From: '0',
        Token: TOKEN,
      }),
      cache: 'no-store', // Always fetch fresh data
    });

    if (!response.ok) {
      throw new Error(`API error: ${response.status}`);
    }

    const data = await response.json();
    return Array.isArray(data.value) ? data.value : [];
  } catch (error) {
    console.error('Search anime error:', error);
    return [];
  }
}

/**
 * Get anime details (plot, statistics, related anime)
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
        Language: 'EN',
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

    if (!response.ok) {
      throw new Error(`API error: ${response.status}`);
    }

    const data = await response.json();
    return Array.isArray(data.value) ? data.value : [];
  } catch (error) {
    console.error('Get anime episodes error:', error);
    return [];
  }
}

/**
 * Get complete anime data (parallel API calls for speed)
 * This is the main function to use for anime detail pages
 */
export async function getCompleteAnimeData(searchTitle: string) {
  try {
    // Step 1: Search for anime by title
    const searchResults = await searchAnime(searchTitle);
    
    if (!searchResults || searchResults.length === 0) {
      return null;
    }

    // Get the first (best) match
    const anime = searchResults[0];

    // Step 2 & 3: Fetch details and episodes in parallel for speed
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
    console.error('Get complete anime data error:', error);
    return null;
  }
}
