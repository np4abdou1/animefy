#!/usr/bin/env node
"use strict";
/**
 * Animeify Browser v1.0 — JavaScript (Node.js) port
 * Purpose: Standalone CLI to test Animeify APIs from Node without touching the Next.js app.
 * Requires: Node 18+ (global fetch). If using Node <18, install `node-fetch` and run with `node`.
 */

// -----------------------------
// Environment & Utilities
// -----------------------------
const DEBUG_LOGGING = false;

// Prefer global fetch (Node 18+). Lazy-load node-fetch if missing.
const fetchFn = globalThis.fetch
  ? globalThis.fetch.bind(globalThis)
  : async (...args) => {
      const { default: fetch } = await import("node-fetch");
      return fetch(...args);
    };

const sleep = (ms) => new Promise((res) => setTimeout(res, ms));

function toJSONSafe(text) {
  try {
    return JSON.parse(text);
  } catch {
    return null;
  }
}

// POST x-www-form-urlencoded
async function postForm(url, data, headers = {}) {
  const body = new URLSearchParams(data);
  const res = await fetchFn(url, {
    method: "POST",
    headers: {
      "Accept": "application/json, text/plain, */*",
      "Content-Type": "application/x-www-form-urlencoded; charset=UTF-8",
      "User-Agent": "AnimeifyBrowser/1.0 (+node-fetch)",
      "X-Requested-With": "XMLHttpRequest",
      ...headers,
    },
    body,
  });
  if (!res.ok) {
    if (DEBUG_LOGGING) console.error(`HTTP ${res.status} for ${url}`);
    throw new Error(`HTTP ${res.status}`);
  }
  const text = await res.text();
  const json = toJSONSafe(text);
  if (json === null) {
    if (DEBUG_LOGGING) console.error("Failed to parse JSON:", text.slice(0, 300));
    throw new Error("Invalid JSON");
  }
  return json;
}

// GET JSON helper
async function getJSON(url, headers = {}) {
  const res = await fetchFn(url, {
    method: "GET",
    headers: {
      "Accept": "application/json, text/plain, */*",
      "User-Agent": "AnimeifyBrowser/1.0 (+node-fetch)",
      ...headers,
    },
  });
  if (!res.ok) throw new Error(`HTTP ${res.status}`);
  return await res.json();
}

// GET text helper (HTML scrape etc.)
async function getText(url, headers = {}) {
  const res = await fetchFn(url, {
    method: "GET",
    headers: {
      "Accept": "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
      "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) AnimeifyBrowser/1.0 Chrome/110 Safari/537.36",
      ...headers,
    },
  });
  if (!res.ok) throw new Error(`HTTP ${res.status}`);
  return await res.text();
}

// -----------------------------
// API Configuration
// -----------------------------
const ANIMEIFY_API_BASE = "https://animeify.net/animeify/apis_v4/";
const ANIMEIFY_TOKEN = "8cnY80AZSbUCmR26Vku1VUUY4";
const MYANIMELIST_API_BASE = "https://api.jikan.moe/v4/anime/";
const THUMBNAILS_BASE_URL = "https://animeify.net/animeify/files/thumbnails/";

// -----------------------------
// API Requests
// -----------------------------
async function search_anime_titles(search_query, content_type = "SERIES") {
  const url = ANIMEIFY_API_BASE + "anime/load_anime_list_v2.php";
  const payload = {
    UserId: "0",
    Language: "English",
    FilterType: "SEARCH",
    FilterData: search_query,
    Type: content_type,
    From: "0",
    Token: ANIMEIFY_TOKEN,
  };
  try {
    const data = await postForm(url, payload);
    if (Array.isArray(data)) return data;
    return [];
  } catch (err) {
    if (DEBUG_LOGGING) console.error("search_anime_titles error:", err.message);
    return [];
  }
}

async function fetch_myanimelist_data(mal_anime_id) {
  if (!mal_anime_id || mal_anime_id === "0") return null;
  const url = MYANIMELIST_API_BASE + String(mal_anime_id);
  try {
    const json = await getJSON(url);
    return json && json.data ? json.data : null;
  } catch {
    return null;
  }
}

async function load_anime_episodes(anime_identifier) {
  const url = ANIMEIFY_API_BASE + "episodes/load_episodes.php";
  const payload = { AnimeID: anime_identifier, Token: ANIMEIFY_TOKEN };
  try {
    const data = await postForm(url, payload);
    if (Array.isArray(data)) return data;
    return [];
  } catch (err) {
    if (DEBUG_LOGGING) console.error("load_anime_episodes error:", err.message);
    return [];
  }
}

async function fetch_streaming_servers(anime_identifier, episode_number, content_type = "SERIES") {
  const url = ANIMEIFY_API_BASE + "anime/load_servers.php";
  const payload = {
    UserId: "0",
    AnimeId: anime_identifier,
    Episode: String(episode_number),
    AnimeType: content_type,
    Token: ANIMEIFY_TOKEN,
  };
  try {
    const data = await postForm(url, payload);
    return data || null;
  } catch (err) {
    if (DEBUG_LOGGING) console.error("fetch_streaming_servers error:", err.message);
    return null;
  }
}

async function fetch_anime_details(anime_identifier, relation_id = "", user_id = "0", language = "English") {
  const url = ANIMEIFY_API_BASE + "anime/load_anime_details.php";
  const payload = {
    UserId: String(user_id),
    Language: language,
    AnimeId: anime_identifier,
    AnimeRelationId: relation_id,
    Token: ANIMEIFY_TOKEN,
  };
  try {
    const data = await postForm(url, payload);
    if (data && typeof data === "object") return data;
    return null;
  } catch {
    return null;
  }
}

async function fetch_anime_details_v2(anime_identifier, relation_id = "", user_id = "0", language = "English") {
  const url = ANIMEIFY_API_BASE + "anime/load_anime_details_v2.php";
  const payload = {
    UserId: String(user_id),
    Language: language,
    AnimeId: anime_identifier,
    AnimeRelationId: relation_id,
    Token: ANIMEIFY_TOKEN,
  };
  try {
    const data = await postForm(url, payload);
    if (data && typeof data === "object") return data;
    return null;
  } catch {
    return null;
  }
}

async function fetch_related_characters_by_relation(relation_id, user_id = "0") {
  const url = ANIMEIFY_API_BASE + "characters/related_characters.php";
  const payload = { UserId: String(user_id), RelationId: relation_id, Token: ANIMEIFY_TOKEN };
  try {
    const data = await postForm(url, payload);
    if (Array.isArray(data)) return data;
    if (data && typeof data === "object") return data.Characters || data.characters || data.data || [];
    return [];
  } catch {
    return [];
  }
}

async function fetch_related_anime(relation_id, user_id = "0", language) {
  const url = ANIMEIFY_API_BASE + "anime/load_related_anime.php";
  const payload = { UserId: String(user_id), RelationId: relation_id, Token: ANIMEIFY_TOKEN };
  if (language) payload.Language = language;
  try {
    const data = await postForm(url, payload);
    if (Array.isArray(data)) return data;
    if (data && typeof data === "object") return data.RelatedAnime || data.data || [];
    return [];
  } catch {
    return [];
  }
}

// -----------------------------
// URL Construction
// -----------------------------
function build_streaming_url(server_link, server_type_key) {
  if (!server_link) return "";
  if (server_link.startsWith("http://") || server_link.startsWith("https://")) return server_link;

  const key = server_type_key || "";
  if (key.includes("OK")) return `https://ok.ru/videoembed/${server_link}`;
  if (key.includes("MA")) return `https://mega.nz/embed/${server_link}`;
  if (key.includes("GD")) return `https://www.googleapis.com/drive/v3/files/${server_link}?key=AIzaSyBzyqZekacyx5t_MGh_A-8-iz2tEeIzqwE&alt=media`;
  if (key.includes("SV")) return `https://sendvid.com/embed/${server_link}`;
  if (key.includes("LB")) return `https://filelions.online/v/${server_link}`;
  if (key.includes("SF")) return `https://sbchill.com/e/${server_link}`;
  if (key.includes("FD")) return `https://vanfem.com/v/${server_link}`;
  if (key.includes("FR")) return `https://www.mediafire.com/file/${server_link}`;
  // Fallback: return as-is
  return server_link;
}

async function extract_direct_mediafire_url(mediafire_url) {
  try {
    const html = await getText(mediafire_url);
    // Look for a https://download... link (first occurrence)
    const match = html.match(/https:\/\/download[^"'<>\s]+/i);
    if (match) return match[0];
    return null;
  } catch {
    return null;
  }
}

// -----------------------------
// High-level Client
// -----------------------------
class AnimeifyClient {
  constructor({
    animeify_base = ANIMEIFY_API_BASE,
    thumbnails_base = THUMBNAILS_BASE_URL,
    token = ANIMEIFY_TOKEN,
    mal_base = MYANIMELIST_API_BASE,
  } = {}) {
    this.animeify_base = animeify_base;
    this.thumbnails_base = thumbnails_base;
    this.token = token;
    this.mal_base = mal_base;
  }

  // Core API wrappers
  search(query, content_type = "SERIES") { return search_anime_titles(query, content_type); }
  mal(mal_id) { return fetch_myanimelist_data(mal_id); }
  episodes(anime_id) { return load_anime_episodes(anime_id); }
  servers(anime_id, episode, content_type = "SERIES") { return fetch_streaming_servers(anime_id, episode, content_type); }
  async details(anime_id, relation_id = "", user_id = "0", language = "English") {
    const v2 = await fetch_anime_details_v2(anime_id, relation_id, user_id, language);
    if (v2) return v2;
    return await fetch_anime_details(anime_id, relation_id, user_id, language);
  }
  characters(relation_id, user_id = "0") { return fetch_related_characters_by_relation(relation_id, user_id); }
  related_anime(relation_id, user_id = "0", language) { return fetch_related_anime(relation_id, user_id, language); }

  // Helpers
  thumbnail_url(thumbnail_name) {
    if (!thumbnail_name) return null;
    return this.thumbnails_base + thumbnail_name;
  }
  streaming_url(server_link, server_type_key) { return build_streaming_url(server_link, server_type_key); }
  mediafire_direct(mediafire_url) { return extract_direct_mediafire_url(mediafire_url); }

  // Shaping
  async shape_search_result(raw, enrich_with_mal = true) {
    const shaped = {
      id: raw?.AnimeId,
      titles: {
        en: raw?.EN_Title || "Unknown",
        jp: raw?.JP_Title || null,
        ar: raw?.AR_Title || null,
        synonyms: raw?.Synonyms || null,
      },
      type: raw?.Type,
      episodes: raw?.Episodes,
      status: raw?.Status,
      genres: raw?.Genres,
      season: raw?.Season,
      premiered: raw?.Premiered,
      aired: raw?.Aired,
      broadcast: raw?.Broadcast,
      duration: raw?.Duration,
      thumbnail_url: this.thumbnail_url(raw?.Thumbnail),
      trailer: raw?.Trailer,
      yt_trailer: raw?.YTTrailer,
      creators: raw?.Creators,
      score: raw?.Score,
      rank: raw?.Rank,
      popularity: raw?.Popularity,
      rating: raw?.Rating,
      views: raw?.views,
      relation_id: raw?.RelationId,
      library_counts: {
        favourites: raw?.library_favourites,
        watch_done: raw?.library_watch_done,
        watch_later: raw?.library_watch_later,
        watch_currently: raw?.library_watch_currently,
      },
      ratings_distribution: Object.fromEntries(Array.from({ length: 10 }, (_, i) => {
        const k = String(i + 1);
        return [k, raw?.[`rates_${k}`]];
      })),
      mal: {
        id: raw?.MalId && raw.MalId !== "0" ? raw.MalId : null,
      },
    };

    if (enrich_with_mal && shaped.mal.id) {
      const mal = await this.mal(shaped.mal.id).catch(() => null);
      if (mal) shaped.mal.data = mal;
    }
    return shaped;
  }

  async anime_details(raw) {
    const shaped = await this.shape_search_result(raw, false);
    const animeId = shaped.id;
    const details = (await this.details(animeId)) || {};

    const result = { ...shaped, details: details || {} };

    // Arabic plot
    const detailsAR = (await this.details(animeId, "", "0", "AR"))
      || (await this.details(animeId, "", "0", "Arabic")) || {};

    if (details?.Plot) result.details.plot_en = details.Plot;
    if (detailsAR?.Plot) result.details.plot_ar = detailsAR.Plot;

    const relationId = raw?.RelationId || details?.RelationId || detailsAR?.RelationId || "";
    if (!result.relation_id && relationId) result.relation_id = relationId;

    // Related anime
    let related = details?.RelatedAnime || detailsAR?.RelatedAnime || [];
    if ((!related || related.length === 0) && relationId) {
      related = await this.related_anime(relationId, "0", "English");
      if (!related || related.length === 0) related = await this.related_anime(relationId, "0", "AR");
    }
    result.related = related || [];

    // Characters
    if (relationId) {
      result.characters = await this.characters(relationId);
    }

    return result;
  }

  list_episodes(episodes_raw) {
    if (!Array.isArray(episodes_raw)) return [];
    const list = episodes_raw
      .map((e) => ({ episode: e?.Episode, type: e?.Type }))
      .filter((e) => e.episode !== undefined && e.episode !== null);
    list.sort((a, b) => Number(a.episode) - Number(b.episode));
    return list;
  }

  get SERVER_LABELS() {
    return {
      OKLink: ["OK.ru", "720p"],
      MALink: ["Mega.nz", "720p"],
      GDLink: ["Google Drive", "720p"],
      LBLink: ["LibreBoot", "720p"],
      SVLink: ["StreamVid", "720p"],
      FRLink: ["MediaFire", "720p"],
      SFLink: ["StreamSB", "720p"],
      FDLink: ["FileHost", "720p"],
      LBLowQ: ["LibreBoot LowQ", "480p"],
      SVLowQ: ["StreamVid LowQ", "480p"],
      FRLowQ: ["MediaFire LowQ", "480p"],
      LBFhdQ: ["LibreBoot FHD", "1080p"],
      GDFhdQ: ["Google Drive FHD", "1080p"],
      FRFhdQ: ["MediaFire FHD", "1080p"],
    };
  }

  async list_servers(servers_payload, { includeDirect = true } = {}) {
    const payload = servers_payload || {};
    const current = payload.CurrentEpisode || {};
    const keys = Object.keys(this.SERVER_LABELS);

    const streams = [];
    for (const k of keys) {
      const id = current[k];
      if (!id) continue;
      const [provider, quality] = this.SERVER_LABELS[k];
      const embed = this.streaming_url(id, k);
      let direct = null;
      if (includeDirect && k.startsWith("FR")) {
        try { direct = await this.mediafire_direct(embed); } catch {}
      }
      streams.push({ key: k, provider, quality, id, embed, direct });
    }

    return {
      episode: current?.Episode ?? null,
      type: current?.Type ?? null,
      streams,
      statistics: current?.EpisodeStatistics || null,
      nextEpisode: payload?.NextEpisode?.Episode ?? null,
      previousEpisode: payload?.PreviousEpisode?.Episode ?? null,
    };
  }
}

// -----------------------------
// CLI Layer
// -----------------------------
function printUsage() {
  console.log(`\nAnimeify Browser v1.0 — JS CLI\n\nCommands:\n  search --query <q> [--type SERIES|MOVIE] [--limit N] [--no-mal]\n  anime [--id <animeId> | --query <q>] [--with-episodes]\n  episodes --id <animeId>\n  servers --id <animeId> --episode <num> [--type SERIES|MOVIE] [--no-direct]\n  config\n  apimap\n\nExamples:\n  node animeify_browser_v1.0.js search --query naruto --limit 3\n  node animeify_browser_v1.0.js servers --id xNarutoShippuuden --episode 1\n`);
}

function parseArgs(argv) {
  const out = { _: [] };
  let i = 0;
  while (i < argv.length) {
    const a = argv[i];
    if (a.startsWith("--")) {
      const key = a.slice(2);
      const next = argv[i + 1];
      if (next === undefined || next.startsWith("--")) {
        out[key] = true;
        i += 1;
      } else {
        out[key] = next;
        i += 2;
      }
    } else {
      out._.push(a);
      i += 1;
    }
  }
  return out;
}

async function main(argv = process.argv.slice(2)) {
  if (argv.length === 0) {
    printUsage();
    return 0;
  }

  const args = parseArgs(argv);
  const cmd = args._[0];
  const client = new AnimeifyClient();

  try {
    switch (cmd) {
      case "search": {
        const q = args.query || args.q;
        const type = args.type === "MOVIE" ? "MOVIE" : "SERIES";
        const limit = args.limit ? Number(args.limit) : undefined;
        if (!q) throw new Error("--query is required");
        const results = await client.search(q, type);
        const trimmed = typeof limit === "number" ? results.slice(0, limit) : results;
        const shaped = [];
        for (const r of trimmed) {
          shaped.push(await client.shape_search_result(r, !args["no-mal"]));
        }
        console.log(JSON.stringify({ count: shaped.length, results: shaped }, null, 2));
        break;
      }
      case "anime": {
        const id = args.id;
        const q = args.query || args.q;
        let raw = null;
        if (id) {
          // If id present, best-effort: search by id to get a raw record to shape
          const found = await client.search(id, args.type || "SERIES");
          raw = found.find((x) => x?.AnimeId === id) || found[0] || null;
        } else if (q) {
          const found = await client.search(q, args.type || "SERIES");
          raw = found[0] || null;
        }
        if (!raw) throw new Error("Could not locate anime. Provide --id or --query.");
        const detailed = await client.anime_details(raw);
        if (args["with-episodes"]) {
          detailed.episodes = client.list_episodes(await client.episodes(detailed.id));
        }
        console.log(JSON.stringify(detailed, null, 2));
        break;
      }
      case "episodes": {
        const id = args.id;
        if (!id) throw new Error("--id is required");
        const eps = await client.episodes(id);
        console.log(JSON.stringify({ anime_id: id, episodes: client.list_episodes(eps) }, null, 2));
        break;
      }
      case "servers": {
        const id = args.id;
        const ep = args.episode || args.e;
        const type = args.type === "MOVIE" ? "MOVIE" : "SERIES";
        if (!id) throw new Error("--id is required");
        if (ep === undefined) throw new Error("--episode is required");
        let epVal = ep;
        if (!isNaN(Number(ep))) epVal = String(Number(ep));
        const payload = await client.servers(id, epVal, type);
        const listing = await client.list_servers(payload || {}, { includeDirect: !args["no-direct"] });
        console.log(JSON.stringify({ anime_id: id, ...listing }, null, 2));
        break;
      }
      case "config": {
        console.log(JSON.stringify({
          animeify_api_base: client.animeify_base,
          thumbnails_base: client.thumbnails_base,
          token_present: Boolean(client.token),
          mal_api_base: client.mal_base,
        }, null, 2));
        break;
      }
      case "apimap": {
        const endpoints = [
          { path: "anime/load_anime_list_v2.php", method: "POST", params: ["UserId","Language","FilterType","FilterData","Type","From","Token"], returns: "List<AnimeModel>" },
          { path: "episodes/load_episodes.php", method: "POST", params: ["AnimeID","Token"], returns: "List<EpisodeModel> (with optional EpisodeStatistics)" },
          { path: "anime/load_servers.php", method: "POST", params: ["UserId","AnimeId","Episode","AnimeType","Token"], returns: "CurrentEpisode + Next/Previous with links and EpisodeStatistics" },
          { path: "anime/load_anime_details_v2.php", method: "POST", params: ["UserId","Language","AnimeId","AnimeRelationId","Token"], returns: "AnimeDetails v2 (plot, statistics, related)" },
          { path: "anime/load_anime_details.php", method: "POST", params: ["UserId","Language","AnimeId","AnimeRelationId","Token"], returns: "AnimeDetails v1 (plot, statistics, related)" },
          { path: "anime/load_anime_details_glance.php", method: "POST", params: ["UserId","AnimeId","Token"], returns: "Lightweight details (glance)" },
          { path: "anime/load_related_anime.php", method: "POST", params: ["UserId","RelationId","Language","Token"], returns: "List<AnimeModel> of related entries" },
          { path: "characters/related_characters.php", method: "POST", params: ["UserId","RelationId","Token"], returns: "Related characters for a relation group" },
        ];
        console.log(JSON.stringify({ apis_v4: endpoints }, null, 2));
        break;
      }
      default:
        printUsage();
        return 1;
    }
  } catch (err) {
    console.error("Error:", err.message || String(err));
    return 2;
  }
  return 0;
}

if (require.main === module) {
  main().then((code) => process.exit(code));
}
