// Function to store anime URL mapping in KV
// Called when user clicks an anime from discover/home page

interface Env {
  KV_BINDING: any;
}

function createSlug(title: string): string {
  return title
    .toLowerCase()
    .trim()
    // Remove special characters except spaces, hyphens, and alphanumeric
    .replace(/[^\w\s-]/g, '')
    // Replace multiple spaces or underscores with single hyphen
    .replace(/[\s_]+/g, '-')
    // Replace multiple consecutive hyphens with single hyphen
    .replace(/-+/g, '-')
    // Remove leading/trailing hyphens
    .replace(/^-+|-+$/g, '');
}

export const onRequestPost = async (context: any) => {
  const { KV_BINDING } = context.env;

  try {
    // Check if KV_BINDING exists
    if (!KV_BINDING) {
      return new Response(
        JSON.stringify({ 
          error: 'KV binding not configured',
          message: 'Please add KV_BINDING in Cloudflare Pages settings'
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

    const animeData = await context.request.json();

    // Validate anime data
    if (!animeData || !animeData.AnimeId) {
      return new Response(
        JSON.stringify({ 
          error: 'Invalid anime data',
          message: 'AnimeId is required'
        }),
        {
          status: 400,
          headers: {
            'Access-Control-Allow-Origin': '*',
            'Content-Type': 'application/json'
          }
        }
      );
    }

    // Create clean slug from title
    const slug = createSlug(animeData.EN_Title || animeData.AR_Title || animeData.JP_Title || animeData.AnimeId);

    // Store the full anime data in KV with slug as key
    await KV_BINDING.put(slug, JSON.stringify(animeData), {
      expirationTtl: 60 * 60 * 24 * 30 // 30 days
    });

    return new Response(
      JSON.stringify({ 
        success: true, 
        slug,
        url: `/anime/${slug}`
      }),
      {
        status: 200,
        headers: {
          'Access-Control-Allow-Origin': '*',
          'Content-Type': 'application/json'
        }
      }
    );

  } catch (error) {
    console.error('Error storing URL:', error);
    return new Response(
      JSON.stringify({ 
        error: 'Failed to store URL',
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

export const onRequestOptions = async () => {
  return new Response(null, {
    headers: {
      'Access-Control-Allow-Origin': '*',
      'Access-Control-Allow-Methods': 'POST, OPTIONS',
      'Access-Control-Allow-Headers': 'Content-Type',
    }
  });
};
