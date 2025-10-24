// Function to store anime URL mapping in KV
// Called when user clicks an anime from discover/home page

interface Env {
  ANIME_URLS: any;
}

function createSlug(title: string): string {
  return title
    .toLowerCase()
    .trim()
    // Replace special characters and spaces with hyphens
    .replace(/[^\w\s-]/g, '')
    .replace(/[\s_]+/g, '-')
    .replace(/^-+|-+$/g, '');
}

export const onRequestPost = async (context: any) => {
  const { ANIME_URLS } = context.env;

  try {
    const animeData = await context.request.json();

    // Create clean slug from title
    const slug = createSlug(animeData.EN_Title || animeData.JP_Title || animeData.AnimeId);

    // Store the full anime data in KV with slug as key
    await ANIME_URLS.put(slug, JSON.stringify(animeData), {
      expirationTtl: 60 * 60 * 24 * 30 // 30 days
    });

    return Response.json(
      { 
        success: true, 
        slug,
        url: `/anime/${slug}`
      },
      {
        headers: {
          'Access-Control-Allow-Origin': '*',
          'Content-Type': 'application/json'
        }
      }
    );

  } catch (error) {
    console.error('Error storing URL:', error);
    return Response.json(
      { error: 'Failed to store URL' },
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

export const onRequestOptions = async () => {
  return new Response(null, {
    headers: {
      'Access-Control-Allow-Origin': '*',
      'Access-Control-Allow-Methods': 'POST, OPTIONS',
      'Access-Control-Allow-Headers': 'Content-Type',
    }
  });
};
