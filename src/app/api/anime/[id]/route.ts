export const runtime = 'edge';

const ANIMEIFY_API_BASE = "https://animeify.net/animeify/apis_v4/";
const ANIMEIFY_TOKEN = "8cnY80AZSbUCmR26Vku1VUUY4";

interface AnimeDetailsParams {
  params: Promise<{
    id: string;
  }>;
}

export async function GET(request: Request, { params }: AnimeDetailsParams) {
  const { id: animeId } = await params;

  if (!animeId) {
    return new Response(
      JSON.stringify({ status: 'error', message: 'AnimeId is required' }),
      { status: 400, headers: { 'content-type': 'application/json; charset=utf-8' } }
    );
  }

  try {
    // Get parameters from query
    const url = new URL(request.url);
    const animeType = url.searchParams.get('type')?.toUpperCase() || 'SERIES';
    const animeName = url.searchParams.get('name') || ''; // Get the exact anime name from URL
    
    console.log(`[Anime API] Fetching anime: ${animeId} (${animeType})`);
    
    // Use the exact name passed from the card, or fall back to extracting from ID
    let searchTerm = animeName || animeId.replace(/^x/, '');
    
    console.log(`[Anime API] Search term: "${searchTerm}"`);
    
    let animeBasicInfo: any = null;
    
    // Search using load_anime_list_v2.php
    const searchUrl = `${ANIMEIFY_API_BASE}anime/load_anime_list_v2.php`;
    const searchBody = new URLSearchParams({
      UserId: '0',
      Language: 'AR',
      FilterType: 'SEARCH',
      FilterData: searchTerm,
      Type: animeType,
      From: '0',
      Token: ANIMEIFY_TOKEN
    });

    const searchRes = await fetch(searchUrl, {
      method: 'POST',
      headers: {
        'Accept': 'application/json, text/plain, */*',
        'Content-Type': 'application/x-www-form-urlencoded',
        'X-Requested-With': 'XMLHttpRequest',
      },
      body: searchBody.toString(),
    });

    if (searchRes.ok) {
      try {
        const searchData = await searchRes.json();
        console.log(`[Anime API] Search returned ${Array.isArray(searchData) ? searchData.length : 0} results`);
        
        if (Array.isArray(searchData) && searchData.length > 0) {
          // Find exact match by AnimeId
          animeBasicInfo = searchData.find((item: any) => item.AnimeId === animeId);
          
          if (!animeBasicInfo) {
            console.log(`[Anime API] No exact match, using first result`);
            console.log(`[Anime API] First result ID: ${searchData[0]?.AnimeId}, looking for: ${animeId}`);
            // If no exact match, check if first result is close enough
            if (searchData[0]?.AnimeId?.toLowerCase().includes(animeId.toLowerCase().replace(/^x/, '').substring(0, 5))) {
              animeBasicInfo = searchData[0];
            }
          }
        }
      } catch (e) {
        console.error(`[Anime API] Search error:`, e);
      }
    }
    
    if (!animeBasicInfo) {
      console.error(`[Anime API] Anime not found via search: ${animeId}`);
      return new Response(
        JSON.stringify({ 
          status: 'error', 
          message: 'Anime not found. Could not find anime in search results.',
          animeId,
          searchTerm,
          type: animeType,
          suggestion: 'Please access anime pages by clicking on anime cards from browse, discover, or search pages.'
        }),
        { status: 404, headers: { 'content-type': 'application/json; charset=utf-8' } }
      );
    }
    
    console.log(`[Anime API] Found anime: ${animeBasicInfo.EN_Title || animeBasicInfo.AR_Title}`);

    // Get detailed info (Plot, Statistics, RelatedAnime) using load_anime_details.php
    let detailsData = null;
    {
      const detailsUrl = `${ANIMEIFY_API_BASE}anime/load_anime_details.php`;
      const detailsBody = new URLSearchParams({
        UserId: '0',
        Language: 'AR',
        AnimeId: animeId,
        AnimeRelationId: animeBasicInfo?.RelationId || '',
        Token: ANIMEIFY_TOKEN
      });

      const detailsRes = await fetch(detailsUrl, {
        method: 'POST',
        headers: {
          'Accept': 'application/json, text/plain, */*',
          'Content-Type': 'application/x-www-form-urlencoded',
          'X-Requested-With': 'XMLHttpRequest',
        },
        body: detailsBody.toString(),
      });

      if (detailsRes.ok) {
        try {
          detailsData = await detailsRes.json();
        } catch (e) {
          // Details endpoint might return empty/invalid JSON
          detailsData = null;
        }
      }
    }

    // Get episodes list
    const episodesUrl = `${ANIMEIFY_API_BASE}episodes/load_episodes.php`;
    const episodesBody = new URLSearchParams({
      AnimeID: animeId,
      Token: ANIMEIFY_TOKEN
    });

    const episodesRes = await fetch(episodesUrl, {
      method: 'POST',
      headers: {
        'Accept': 'application/json, text/plain, */*',
        'Content-Type': 'application/x-www-form-urlencoded',
        'X-Requested-With': 'XMLHttpRequest',
      },
      body: episodesBody.toString(),
    });

    let episodesList = [];
    if (episodesRes.ok) {
      try {
        episodesList = await episodesRes.json();
      } catch (e) {
        episodesList = [];
      }
    }

    // Get MAL data if available (only for supplementary info like images and studios)
    let malData = null;
    if (animeBasicInfo.MalId && animeBasicInfo.MalId !== '0') {
      try {
        const malRes = await fetch(`https://api.jikan.moe/v4/anime/${animeBasicInfo.MalId}`);
        if (malRes.ok) {
          const malJson = await malRes.json();
          malData = malJson.data;
        }
      } catch (e) {
        // MAL API might fail, continue without it
        malData = null;
      }
    }

    // Check if we got any useful data
    if (!detailsData && episodesList.length === 0) {
      console.error(`[Anime API] No data found for anime: ${animeId}`);
      return new Response(
        JSON.stringify({ 
          status: 'error', 
          message: 'Anime data not found. The Animeify API does not support fetching anime by ID alone.',
          animeId,
          suggestion: 'Please access anime pages by clicking on anime cards from browse, discover, or search pages. Direct URL access is not supported due to API limitations.'
        }),
        { status: 404, headers: { 'content-type': 'application/json; charset=utf-8' } }
      );
    }

    // Combine all data - prioritize Arabic content
    const combinedData = {
      ...animeBasicInfo,
      // Use Arabic plot from Animeify, NOT MAL
      Plot: detailsData?.Plot || '',
      AnimeStatistics: detailsData?.AnimeStatistics || null,
      RelatedAnime: detailsData?.RelatedAnime || [],
      Library: detailsData?.Library || { Favourite: 0, Library: '' },
      Episodes: episodesList,
      MAL: malData ? {
        score: malData.score,
        scored_by: malData.scored_by,
        rank: malData.rank,
        popularity: malData.popularity,
        members: malData.members,
        favorites: malData.favorites,
        status: malData.status,
        studios: malData.studios?.map((s: any) => s.name) || [],
        aired: malData.aired?.string || '',
        duration: malData.duration || '',
        images: malData.images?.jpg || null,
      } : null,
    };

    console.log(`[Anime API] Returning data for: ${animeId} with ${episodesList.length} episodes`);

    return new Response(
      JSON.stringify({ status: 'success', data: combinedData }),
      { 
        status: 200, 
        headers: { 
          'content-type': 'application/json; charset=utf-8',
          'Cache-Control': 'public, s-maxage=300, stale-while-revalidate=600'
        } 
      }
    );

  } catch (err: any) {
    console.error('Anime details error:', err);
    return new Response(
      JSON.stringify({ status: 'error', message: err?.message || 'fetch_failed' }),
      { status: 500, headers: { 'content-type': 'application/json; charset=utf-8' } }
    );
  }
}
