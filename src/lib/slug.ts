/**
 * Robust slug generation that handles:
 * - Arabic text
 * - Special characters (=_!:":!"Ö'Ä!ÖÜP)
 * - Multiple spaces
 * - Unicode characters
 * - Edge cases
 */

/**
 * Convert any string to a clean URL-safe slug
 */
export function createSlug(text: string): string {
  if (!text) return '';
  
  return text
    .toString()
    .toLowerCase()
    .trim()
    // Remove Arabic and other non-Latin characters
    .replace(/[\u0600-\u06FF\u0750-\u077F\u08A0-\u08FF\uFB50-\uFDFF\uFE70-\uFEFF]/g, '')
    // Remove special characters and symbols
    .replace(/[^\w\s-]/g, '')
    // Replace multiple spaces or underscores with single hyphen
    .replace(/[\s_]+/g, '-')
    // Replace multiple hyphens with single hyphen
    .replace(/-+/g, '-')
    // Remove leading/trailing hyphens
    .replace(/^-+|-+$/g, '');
}

/**
 * Convert slug back to searchable title
 * "naruto-shippuden" -> "Naruto Shippuden"
 * Capitalizes each word for better search results
 */
export function slugToTitle(slug: string): string {
  if (!slug) return '';
  
  return slug
    .replace(/-/g, ' ')
    .trim()
    .split(' ')
    .map(word => word.charAt(0).toUpperCase() + word.slice(1))
    .join(' ');
}

/**
 * Create anime URL from anime data
 * Format: /anime/AnimeId?name=Title&type=SERIES
 * Uses AnimeId as slug for reliable routing
 */
export function createAnimeUrl(anime: {
  EN_Title?: string;
  AR_Title?: string;
  AnimeId?: string;
  anime_id?: string;
  Type?: string;
}): string {
  // Use AnimeId as the slug for reliable routing
  const animeId = anime.AnimeId || anime.anime_id || anime.Id || '';
  const title = anime.EN_Title || anime.AR_Title || '';
  const type = anime.Type || 'SERIES';
  
  if (!animeId) return '/';
  
  // Add name and type as query parameters for accurate search
  const encodedName = encodeURIComponent(title);
  
  return `/anime/${animeId}?name=${encodedName}&type=${type}`;
}

/**
 * Validate if a slug is safe and valid
 */
export function isValidSlug(slug: string): boolean {
  if (!slug) return false;
  
  // Only allow lowercase letters, numbers, and hyphens
  const slugPattern = /^[a-z0-9]+(?:-[a-z0-9]+)*$/;
  return slugPattern.test(slug);
}
