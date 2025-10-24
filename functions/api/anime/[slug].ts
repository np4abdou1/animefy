// Cloudflare Pages Function for anime details
// Fetches anime data from KV and enriches with API calls

interface Env {
  KV_BINDING: any;
}

interface AnimeBasicData {
  AnimeId: string;
  EN_Title?: string;
  JP_Title?: string;
  AR_Title?: string;
  Thumbnail?: string;
  Type?: string;
  Episodes?: number;
  Status?: string;
  Genres?: string;
  Season?: string;
  Premiered?: string;
  Aired?: string;
  Duration?: string;
  Score?: number;
  Rank?: number;
  Rating?: string;
  RelationId?: string;
  MalId?: string;
  [key: string]: any; // Allow additional properties
}

const API_BASE = 'https://animeify.net/animeify/apis_v4/';
const TOKEN = '8cnY80AZSbUCmR26Vku1VUUY4';

export const onRequest = async (context: any) => {
  const { slug } = context.params as { slug: string };
  const { KV_BINDING } = context.env;

  try {
    // Step 1: Get basic anime data from KV
    const storedData = await KV_BINDING.get(slug);
    
    if (!storedData) {
      return new Response(
        JSON.stringify({ error: 'Anime not found in KV', slug }),
        { 
          status: 404,
          headers: {
            'Access-Control-Allow-Origin': '*',
            'Content-Type': 'application/json'
          }
        }
      );
    }

    // Step 2: Parse the stored anime data
    const basicAnime: AnimeBasicData = JSON.parse(storedData);
    const animeId = basicAnime.AnimeId;
    const animeName = basicAnime.EN_Title || basicAnime.AR_Title || '';
    const animeType = (basicAnime.Type || 'SERIES').toUpperCase();

    // Step 3: Search for the anime using its exact name to get complete data
    const searchResponse = await fetch(`${API_BASE}anime/load_anime_list_v2.php`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/x-www-form-urlencoded',
      },
      body: new URLSearchParams({
        UserId: '0',
        Language: 'AR',
        FilterType: 'SEARCH',
        FilterData: animeName,
        Type: animeType,
        From: '0',
        Token: TOKEN
      })
    });

    let fullAnimeData = basicAnime;
    if (searchResponse.ok) {
      const searchResults = await searchResponse.json();
      if (Array.isArray(searchResults) && searchResults.length > 0) {
        // Find exact match by AnimeId
        const exactMatch = searchResults.find((item: any) => item.AnimeId === animeId);
        if (exactMatch) {
          fullAnimeData = { ...basicAnime, ...exactMatch };
        } else {
          // Use first result if no exact match
          fullAnimeData = { ...basicAnime, ...searchResults[0] };
        }
      }
    }

    // Step 4: Fetch additional details (plot, related anime, statistics)
    const detailsResponse = await fetch(`${API_BASE}anime/load_anime_details.php`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/x-www-form-urlencoded',
      },
      body: new URLSearchParams({
        UserId: '0',
        Language: 'AR',
        AnimeId: fullAnimeData.AnimeId,
        AnimeRelationId: fullAnimeData.RelationId || '',
        Token: TOKEN
      })
    });

    let details: any = {};
    if (detailsResponse.ok) {
      try {
        details = await detailsResponse.json();
      } catch (e) {
        console.error('Failed to parse details:', e);
      }
    }

    // Step 5: Fetch episodes list
    const episodesResponse = await fetch(`${API_BASE}episodes/load_episodes.php`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/x-www-form-urlencoded',
      },
      body: new URLSearchParams({
        AnimeID: fullAnimeData.AnimeId,
        Token: TOKEN
      })
    });

    let episodes: any[] = [];
    if (episodesResponse.ok) {
      try {
        episodes = await episodesResponse.json();
        if (!Array.isArray(episodes)) episodes = [];
      } catch (e) {
        console.error('Failed to parse episodes:', e);
      }
    }

    // Step 6: Merge all data
    const completeData = {
      ...fullAnimeData,
      plot: details.Plot || '',
      Plot: details.Plot || '',
      related_anime: details.RelatedAnime || [],
      anime_statistics: details.AnimeStatistics || {},
      library: details.Library || {},
      Episodes: episodes,
      anime_id: fullAnimeData.AnimeId
    };

    return new Response(
      JSON.stringify({ success: true, data: completeData }),
      {
        status: 200,
        headers: {
          'Access-Control-Allow-Origin': '*',
          'Content-Type': 'application/json',
          'Cache-Control': 'public, s-maxage=600, stale-while-revalidate=1800'
        }
      }
    );

  } catch (error) {
    console.error('Error fetching anime:', error);
    return new Response(
      JSON.stringify({ 
        error: 'Failed to fetch anime data', 
        message: error instanceof Error ? error.message : 'Unknown error' 
      }),
      { 
        status: 500,
        headers: {
          'Access-Control-Allow-Origin': '*',
          'Content-Type': 'application/json'
        }
      }
    );
  }
};

// Handle CORS preflight
export const onRequestOptions = async () => {
  return new Response(null, {
    headers: {
      'Access-Control-Allow-Origin': '*',
      'Access-Control-Allow-Methods': 'GET, OPTIONS',
      'Access-Control-Allow-Headers': 'Content-Type',
    }
  });
};
