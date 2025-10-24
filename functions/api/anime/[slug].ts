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
    // Step 1: Try to get anime data from KV
    let basicAnime: AnimeBasicData | null = null;
    let animeId = '';
    let animeName = '';
    let animeType = 'SERIES';

    if (KV_BINDING) {
      try {
        const storedData = await KV_BINDING.get(slug);
        if (storedData) {
          const parsed = JSON.parse(storedData);
          basicAnime = parsed;
          animeId = parsed.AnimeId;
          animeName = parsed.EN_Title || parsed.AR_Title || '';
          animeType = (parsed.Type || 'SERIES').toUpperCase();
        }
      } catch (kvError) {
        console.warn('KV fetch failed, will search by slug:', kvError);
      }
    }

    // Step 2: If no data from KV, convert slug back to search term
    if (!basicAnime) {
      // Convert slug to search term: "naruto-shippuden" -> "naruto shippuden"
      animeName = slug.replace(/-/g, ' ');
      animeType = 'SERIES';
    }

    // Step 3: Search for the anime using its name to get complete data
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

    let fullAnimeData: AnimeBasicData | null = null;
    if (searchResponse.ok) {
      const searchResults = await searchResponse.json();
      if (Array.isArray(searchResults) && searchResults.length > 0) {
        if (animeId) {
          // Find exact match by AnimeId if we have it from KV
          const exactMatch = searchResults.find((item: any) => item.AnimeId === animeId);
          fullAnimeData = exactMatch || searchResults[0];
        } else {
          // Use first result if searching by slug
          fullAnimeData = searchResults[0];
        }
      }
    }

    // If search failed and we have basic data from KV, use that
    if (!fullAnimeData && basicAnime) {
      fullAnimeData = basicAnime;
    }

    // If still no data, return 404
    if (!fullAnimeData) {
      return new Response(
        JSON.stringify({ 
          error: 'Anime not found', 
          slug,
          searchTerm: animeName,
          message: 'Could not find anime in API. Please try searching from the browse page.'
        }),
        { 
          status: 404,
          headers: {
            'Access-Control-Allow-Origin': '*',
            'Content-Type': 'application/json'
          }
        }
      );
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
