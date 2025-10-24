/**
 * Utility functions for creating and handling anime URLs
 * Format: /anime/animeId?name=FULL_NAME&type=TYPE
 * Simple and reliable - passes exact data without corruption
 * Name comes first in query params for better readability
 */

export function createAnimeUrl(animeId: string, title: string, type: string = 'SERIES'): string {
  const params = new URLSearchParams({
    name: title,
    type: type.toUpperCase()
  });
  return `/anime/${animeId}?${params.toString()}`;
}

export function parseAnimeUrl(slug: string): { animeId: string; type: string; title: string } | null {
  // Just return the animeId - the page will get type and name from searchParams
  return {
    animeId: slug,
    type: 'SERIES',
    title: ''
  };
}
