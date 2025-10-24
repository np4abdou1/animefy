// Utility to generate and store anime URLs

export interface AnimeData {
  AnimeId: string;
  EN_Title: string;
  JP_Title?: string;
  AR_Title?: string;
  Thumbnail: string;
  Type: string;
  Episodes: number;
  Status: string;
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
  views?: number;
  library_favourites?: number;
  rates_1?: number;
  rates_2?: number;
  rates_3?: number;
  rates_4?: number;
  rates_5?: number;
  rates_6?: number;
  rates_7?: number;
  rates_8?: number;
  rates_9?: number;
  rates_10?: number;
}

/**
 * Creates a clean URL slug from anime title
 * Handles special characters, spaces, and edge cases
 */
export function createAnimeSlug(title: string): string {
  return title
    .toLowerCase()
    .trim()
    // Remove special characters except spaces and hyphens
    .replace(/[^\w\s-]/g, '')
    // Replace multiple spaces/underscores with single hyphen
    .replace(/[\s_]+/g, '-')
    // Remove leading/trailing hyphens
    .replace(/^-+|-+$/g, '')
    // Replace multiple consecutive hyphens with single hyphen
    .replace(/-+/g, '-');
}

/**
 * Stores anime data in KV and returns the clean URL
 * This is called when user clicks an anime card
 */
export async function storeAnimeUrl(animeData: AnimeData): Promise<string> {
  try {
    const response = await fetch('/api/anime/store-url', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(animeData)
    });

    const result = await response.json();
    
    if (result.success) {
      return result.url; // e.g., /anime/naruto-shippuden
    }
    
    throw new Error('Failed to store URL');
  } catch (error) {
    console.error('Error storing anime URL:', error);
    // Fallback to AnimeId if KV storage fails
    return `/anime/${animeData.AnimeId}`;
  }
}

/**
 * Fetches anime data from the clean URL slug
 */
export async function fetchAnimeBySlug(slug: string): Promise<any> {
  const response = await fetch(`/api/anime/${slug}`);
  
  if (!response.ok) {
    throw new Error('Anime not found');
  }
  
  const result = await response.json();
  return result.data;
}
