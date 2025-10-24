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
    // Step 1: Get encoded data from KV
    const encodedData = await KV_BINDING.get(slug);
    
    if (!encodedData) {
      return Response.json(
        { error: 'Anime not found', slug },
        { 
          status: 404,
          headers: {
            'Access-Control-Allow-Origin': '*',
            'Content-Type': 'application/json'
          }
        }
      );
    }

    // Step 2: Parse the anime data from KV
    const animeData: AnimeBasicData = JSON.parse(encodedData);

    // Step 3: Fetch additional details (plot, related anime) from API
    const detailsResponse = await fetch(`${API_BASE}anime/load_anime_details.php`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/x-www-form-urlencoded',
      },
      body: new URLSearchParams({
        UserId: '0',
        Language: 'EN',
        AnimeId: animeData.AnimeId,
        AnimeRelationId: animeData.RelationId || '',
        Token: TOKEN
      })
    });

    const details = await detailsResponse.json();

    // Step 4: Merge data
    const completeData = {
      ...animeData,
      plot: details.Plot || '',
      related_anime: details.RelatedAnime || [],
      anime_statistics: details.AnimeStatistics || {},
      library: details.Library || {}
    };

    return Response.json(
      { success: true, data: completeData },
      {
        headers: {
          'Access-Control-Allow-Origin': '*',
          'Content-Type': 'application/json',
          'Cache-Control': 'public, s-maxage=3600, stale-while-revalidate=86400'
        }
      }
    );

  } catch (error) {
    console.error('Error fetching anime:', error);
    return Response.json(
      { error: 'Failed to fetch anime data' },
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
