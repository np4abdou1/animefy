export const runtime = 'edge';

const ANIMEIFY_API_BASE = 'https://animeify.net/animeify/apis_v4/';
const ANIMEIFY_TOKEN = '8cnY80AZSbUCmR26Vku1VUUY4';
const JIKAN_API_BASE = 'https://api.jikan.moe/v4';
const THUMB_BASE = 'https://animeify.net/animeify/files/thumbnails/';

async function postForm(url: string, data: Record<string, string>) {
  const body = new URLSearchParams(data);
  const res = await fetch(url, {
    method: 'POST',
    headers: {
      'Accept': 'application/json, text/plain, */*',
      'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8',
    },
    body,
  });
  if (!res.ok) throw new Error(`HTTP ${res.status}`);
  return await res.json();
}

function normalizeDetails(input: any) {
  let d = input;
  if (!d) return null;
  if (Array.isArray(d)) d = d[0] || null;
  if (d && typeof d === 'object' && 'data' in d && typeof (d as any).data === 'object') d = (d as any).data;
  if (d && typeof d === 'object' && 'AnimeDetails' in (d as any)) d = (d as any).AnimeDetails;
  if (d && typeof d === 'object' && 'Details' in (d as any)) d = (d as any).Details;
  // Normalize common field names
  if (d && typeof d === 'object') {
    const o: any = d;
    // Title variants
    if (!o.AR_Title && o.TitleAR) o.AR_Title = o.TitleAR;
    if (!o.EN_Title && o.TitleEN) o.EN_Title = o.TitleEN;
    if (!o.Title && (o.EN_Title || o.AR_Title)) o.Title = o.AR_Title || o.EN_Title;
    // Thumbnail variants
    const thumb = o.Thumbnail || o.Thumb || o.Image || o.Poster || o.Cover || o.ThumbName || o.ThumbnailName;
    if (!o.Thumbnail && thumb) o.Thumbnail = thumb;
    // Episodes / Status variants
    if (!o.Episodes && o.EpisodeCount) o.Episodes = o.EpisodeCount;
    if (!o.Status && o.AiringStatus) o.Status = o.AiringStatus;
    // Related list alias
    if (!o.RelatedAnime && (o.Related || o.related)) o.RelatedAnime = o.Related || o.related;
  }
  return d || null;
}

async function fetchDetailsForLang(animeId: string, lang: string) {
  // Prefer v2; fallback to v1 if needed for a specific language
  const common = { UserId: '0', Language: lang, AnimeId: animeId, AnimeRelationId: '', Token: ANIMEIFY_TOKEN } as Record<string, string>;
  try {
    const v2 = await postForm(ANIMEIFY_API_BASE + 'anime/load_anime_details_v2.php', common);
    return normalizeDetails(v2);
  } catch {
    try {
      const v1 = await postForm(ANIMEIFY_API_BASE + 'anime/load_anime_details.php', common);
      return normalizeDetails(v1);
    } catch {
      return null;
    }
  }
}

async function fetchEpisodes(animeId: string) {
  try {
    const data = await postForm(ANIMEIFY_API_BASE + 'episodes/load_episodes.php', { AnimeID: animeId, Token: ANIMEIFY_TOKEN });
    if (Array.isArray(data)) return data;
    if (data && typeof data === 'object') {
      return (data.episodes || data.data || data.list || []) as any[];
    }
    return [];
  } catch {
    return [];
  }
}

async function fetchRelated(relationId: string | undefined) {
  if (!relationId) return [];
  try {
    const data = await postForm(ANIMEIFY_API_BASE + 'anime/load_related_anime.php', {
      UserId: '0',
      RelationId: relationId,
      Language: 'AR',
      Token: ANIMEIFY_TOKEN,
    });
    if (Array.isArray(data)) return data;
    if (data && typeof data === 'object') {
      const list = (data.RelatedAnime || (data as any).data || (data as any).list || []) as any[];
      return Array.isArray(list) ? list : [];
    }
    return [];
  } catch {
    return [];
  }
}

async function fetchRelatedEnglish(relationId: string | undefined) {
  if (!relationId) return [];
  try {
    const data = await postForm(ANIMEIFY_API_BASE + 'anime/load_related_anime.php', {
      UserId: '0',
      RelationId: relationId,
      Language: 'English',
      Token: ANIMEIFY_TOKEN,
    });
    if (Array.isArray(data)) return data;
    if (data && typeof data === 'object') {
      const list = (data.RelatedAnime || (data as any).data || (data as any).list || []) as any[];
      return Array.isArray(list) ? list : [];
    }
    return [];
  } catch {
    return [];
  }
}

async function fetchGlance(animeId: string) {
  try {
    const data = await postForm(ANIMEIFY_API_BASE + 'anime/load_anime_details_glance.php', {
      UserId: '0',
      AnimeId: animeId,
      Token: ANIMEIFY_TOKEN,
    });
    return normalizeDetails(data);
  } catch {
    return null;
  }
}

async function searchByTitle(title: string) {
  try {
    const data = await postForm(ANIMEIFY_API_BASE + 'anime/load_anime_list_v2.php', {
      UserId: '0',
      Language: 'English',
      FilterType: 'SEARCH',
      FilterData: title,
      Type: 'SERIES',
      From: '0',
      Token: ANIMEIFY_TOKEN,
    });
    return Array.isArray(data) ? data : [];
  } catch {
    return [];
  }
}

function titleFromId(animeId: string) {
  // Remove leading 'x' and split CamelCase/numbers/underscores into spaced words
  let s = animeId.startsWith('x') ? animeId.slice(1) : animeId;
  s = s.replace(/[_-]+/g, ' ');
  s = s.replace(/([a-z])([A-Z])/g, '$1 $2');
  s = s.replace(/(\d+)/g, ' $1 ');
  s = s.replace(/\s{2,}/g, ' ').trim();
  return s;
}

async function enrichWithMalByTitle(title?: string) {
  if (!title) return null;
  try {
    const res = await fetch(`${JIKAN_API_BASE}/anime?q=${encodeURIComponent(title)}&limit=1`);
    if (!res.ok) return null;
    const json = await res.json();
    const item = Array.isArray(json?.data) && json.data.length > 0 ? json.data[0] : null;
    return item;
  } catch {
    return null;
  }
}

export async function GET(request: Request, ctx: { params: Promise<{ id: string }> }) {
  try {
    const { id: animeId } = await ctx.params;
    // Fetch Arabic first, then English; merge for completeness
    const [detailsAR, detailsEN] = await Promise.all([
      fetchDetailsForLang(animeId, 'AR'),
      fetchDetailsForLang(animeId, 'English'),
    ]);
    const details = { ...(detailsEN || {}), ...(detailsAR || {}) } as any;
    const episodes = await fetchEpisodes(animeId);
    let relationId = details?.RelationId || details?.RelationID || details?.relationId || details?.Relation || details?.RelationGroupId || details?.RelationGroupID;
    let related = Array.isArray(details?.RelatedAnime) ? details.RelatedAnime : [];
    if (!Array.isArray(related) || related.length === 0) related = await fetchRelated(relationId);
    if (!Array.isArray(related) || related.length === 0) related = await fetchRelatedEnglish(relationId);

    // MAL enrichment: try AR then EN title
    const mal = await enrichWithMalByTitle(details?.AR_Title || details?.Title || details?.EN_Title);

    // Provide a ready-to-use thumbnailUrl when possible
    let thumbnailName = details?.Thumbnail || details?.Thumb || details?.Image || details?.Poster || details?.Cover;
    let thumbnailUrl = thumbnailName ? THUMB_BASE + thumbnailName : undefined;

    // Fallback to glance if no thumbnail
    if (!thumbnailUrl) {
      const glance = await fetchGlance(animeId);
      const gThumb = glance?.Thumbnail || glance?.Thumb || glance?.Image || glance?.Poster;
      if (gThumb) {
        thumbnailName = gThumb;
        thumbnailUrl = THUMB_BASE + gThumb;
      }
    }

    // Fallback to search by title for thumbnail and some meta
    let listItem: any = null;
    if (!thumbnailUrl && (details?.EN_Title || details?.Title || details?.AR_Title)) {
      const results = await searchByTitle(details?.EN_Title || details?.Title || details?.AR_Title);
      if (Array.isArray(results) && results.length > 0) {
        listItem = results.find((r: any) => r?.AnimeId === animeId) || results[0];
        const lThumb = listItem?.Thumbnail;
        if (lThumb) {
          thumbnailName = lThumb;
          thumbnailUrl = THUMB_BASE + lThumb;
        }
      }
    }

    // If still missing, derive a human title from id and search again
    if (!thumbnailUrl && !listItem) {
      const q = titleFromId(animeId);
      const results2 = await searchByTitle(q);
      if (Array.isArray(results2) && results2.length > 0) {
        listItem = results2.find((r: any) => r?.AnimeId === animeId) || results2[0];
        const lThumb = listItem?.Thumbnail;
        if (lThumb) {
          thumbnailName = lThumb;
          thumbnailUrl = THUMB_BASE + lThumb;
        }
      }
    }

    // Merge title/meta from search item when details lack them
    if (listItem && typeof listItem === 'object') {
      const mergeIfEmpty = (key: string, value: any) => {
        if (value == null) return;
        if (details[key] == null || details[key] === '') details[key] = value;
      };
      mergeIfEmpty('AR_Title', listItem.AR_Title);
      mergeIfEmpty('EN_Title', listItem.EN_Title);
      mergeIfEmpty('Title', listItem.EN_Title || listItem.AR_Title || listItem.Synonyms);
      mergeIfEmpty('Type', listItem.Type);
      mergeIfEmpty('Episodes', listItem.Episodes);
      mergeIfEmpty('Status', listItem.Status);
      mergeIfEmpty('Score', listItem.Score);
      mergeIfEmpty('Rank', listItem.Rank);
      mergeIfEmpty('Popularity', listItem.Popularity);
      mergeIfEmpty('Rating', listItem.Rating);
      mergeIfEmpty('Premiered', listItem.Premiered);

      if (!relationId) relationId = listItem.RelationId;
      if ((!Array.isArray(related) || related.length === 0) && relationId) {
        related = await fetchRelated(relationId);
        if (!Array.isArray(related) || related.length === 0) related = await fetchRelatedEnglish(relationId);
      }
    }

    // Build stats object similar to Python shaping
    const animeStats = (details?.AnimeStatistics && typeof details.AnimeStatistics === 'object') ? details.AnimeStatistics : undefined;
    const stats = {
      score: details?.Score || listItem?.Score || undefined,
      rank: details?.Rank || listItem?.Rank || undefined,
      popularity: details?.Popularity || listItem?.Popularity || undefined,
      rating: details?.Rating || listItem?.Rating || undefined,
      views: animeStats?.views || listItem?.views || undefined,
      library: animeStats ? {
        favourites: animeStats.library_favourites,
        watch_done: animeStats.library_watch_done,
        watch_later: animeStats.library_watch_later,
        watch_currently: animeStats.library_watch_currently,
      } : undefined,
      distribution: animeStats ? Object.fromEntries(Array.from({length:10}, (_,i)=>[String(i+1), (animeStats as any)[`rates_${i+1}`]])) : undefined,
    };

    return new Response(JSON.stringify({ status: 'success', details, episodes, related, mal, thumbnailUrl, stats }), {
      status: 200,
      headers: { 'content-type': 'application/json; charset=utf-8' },
    });
  } catch (err: any) {
    return new Response(JSON.stringify({ status: 'error', message: err?.message || 'fetch_failed' }), {
      status: 500,
      headers: { 'content-type': 'application/json; charset=utf-8' },
    });
  }
}
