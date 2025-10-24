# Animeify Browser v1.0 — API Reference

This document describes the HTTP endpoints used by `animeify_browser_v1.0.py`, the expected parameters, sample responses, and the streaming server URL patterns inferred from the Android APK/DLLs.

- API base: `https://animeify.net/animeify/apis_v4/`
- Thumbnails base: `https://animeify.net/animeify/files/thumbnails/`
- Token: `8cnY80AZSbUCmR26Vku1VUUY4`
- Common headers:
  - `Accept: application/json, text/plain, */*`
  - `User-Agent: AnimeifyBrowser/1.0 (+python-requests)`
  - `X-Requested-With: XMLHttpRequest`

Notes
- All endpoints are POST.
- Language values typically `English` for EN content and `AR` for Arabic content.
- Some endpoints require `RelationId` (not `AnimeId`).

---

## 1) Search — anime/load_anime_list_v2.php

- Method: POST
- Path: `anime/load_anime_list_v2.php`
- Params: `UserId`, `Language`, `FilterType`, `FilterData`, `Type`, `From`, `Token`
- Purpose: Search anime catalog, return list of AnimeModel records.

Request example
```http
POST /animeify/apis_v4/anime/load_anime_list_v2.php
UserId=0&Language=English&FilterType=SEARCH&FilterData=naruto&Type=SERIES&From=0&Token=8cnY80AZSbUCmR26Vku1VUUY4
```

Response example (truncated fields)
```json
[
  {
    "AnimeId": "xNarutoShippuuden",
    "EN_Title": "Naruto Shippuden",
    "JP_Title": "ナルト 疾風伝",
    "AR_Title": "ناروتو شيبودن",
    "Synonyms": "Naruto: Shippuuden",
    "Type": "SERIES",
    "Episodes": 500,
    "Status": "AIRED",
    "Genres": "Action, Adventure, Shounen",
    "Season": "Winter 2007",
    "Duration": "23 min/ep",
    "Thumbnail": "NarutoShippuuden.jpg",
    "Rating": "PG-13",
    "MalId": "1735",
    "RelationId": "R_xNarutoGroup",
    "views": 123456,
    "library_favourites": 1200,
    "library_watch_done": 900,
    "library_watch_later": 300,
    "library_watch_currently": 450,
    "rates_1": 10, "rates_2": 5, "rates_3": 6, "rates_4": 12,
    "rates_5": 20, "rates_6": 30, "rates_7": 80, "rates_8": 150,
    "rates_9": 220, "rates_10": 500
  }
]
```

---

## 2) Episodes — episodes/load_episodes.php

- Method: POST
- Path: `episodes/load_episodes.php`
- Params: `AnimeID`, `Token`
- Purpose: List all available episodes for an anime.

Request example
```http
POST /animeify/apis_v4/episodes/load_episodes.php
AnimeID=xNarutoShippuuden&Token=8cnY80AZSbUCmR26Vku1VUUY4
```

Response example
```json
[
  { "Episode": 1,   "Type": "Episode" },
  { "Episode": 2,   "Type": "Episode" },
  { "Episode": 12.5, "Type": "Special" }
]
```

---

## 3) Streaming servers — anime/load_servers.php

- Method: POST
- Path: `anime/load_servers.php`
- Params: `UserId`, `AnimeId`, `Episode`, `AnimeType`, `Token`
- Purpose: Get all streaming links for a specific episode.

Request example
```http
POST /animeify/apis_v4/anime/load_servers.php
UserId=0&AnimeId=xNarutoShippuuden&Episode=1&AnimeType=SERIES&Token=8cnY80AZSbUCmR26Vku1VUUY4
```

Response example
```json
{
  "CurrentEpisode": {
    "Episode": 1,
    "Type": "Episode",
    "LBLink": "filelions-id",
    "SVLink": "sendvid-id",
    "OKLink": "okru-id",
    "MALink": "mega-id",
    "GDLink": "gdrive-id",
    "FRLink": "mediafire-id",
    "SFLink": "streamsb-id",
    "FDLink": "vanfem-id",
    "LBLowQ": "filelions-low-id",
    "SVLowQ": "sendvid-low-id",
    "FRLowQ": "mediafire-low-id",
    "LBFhdQ": "filelions-fhd-id",
    "GDFhdQ": "gdrive-fhd-id",
    "FRFhdQ": "mediafire-fhd-id",
    "EpisodeStatistics": {
      "UserRate": 9,
      "views": 1234,
      "rates_1": 0, "rates_2": 1, "rates_3": 2, /* ... */ "rates_10": 50
    }
  },
  "NextEpisode": { "Episode": 2 },
  "PreviousEpisode": null
}
```

---

## 4) Anime details (v2 preferred) — anime/load_anime_details_v2.php

- Method: POST
- Path: `anime/load_anime_details_v2.php`
- Params: `UserId`, `Language`, `AnimeId`, `AnimeRelationId`, `Token`
- Purpose: Detailed info (plot/description, statistics, related anime). If absent server-side, use v1.

Request example
```http
POST /animeify/apis_v4/anime/load_anime_details_v2.php
UserId=0&Language=English&AnimeId=xNarutoShippuuden&AnimeRelationId=&Token=8cnY80AZSbUCmR26Vku1VUUY4
```

Response example
```json
{
  "RelationId": "R_xNarutoGroup",
  "Plot": "Following the successful end of the Fourth Shinobi World War...",
  "AnimeStatistics": {
    "UserRate": 8,
    "views": 98765,
    "library_favourites": 1200,
    "library_watch_done": 900,
    "library_watch_later": 300,
    "library_watch_currently": 450,
    "rates_1": 2, /* ... */ "rates_10": 200
  },
  "RelatedAnime": [ { "AnimeId": "xBorutoNarutoNextGenerations", "EN_Title": "Boruto: Naruto Next Generations", "Type": "SERIES", "Episodes": 293, "Thumbnail": "BorutoNarutoNextGenerations2.jpg" } ]
}
```

---

## 5) Anime details (v1 fallback) — anime/load_anime_details.php

- Method: POST
- Path: `anime/load_anime_details.php`
- Params: `UserId`, `Language`, `AnimeId`, `AnimeRelationId`, `Token`
- Purpose: Same fields as above when v2 isn’t available.

Request/Response: same shape as v2 example above.

---

## 6) Related anime — anime/load_related_anime.php

- Method: POST
- Path: `anime/load_related_anime.php`
- Params: `UserId`, `RelationId`, `Language`, `Token`
- Purpose: Fetch related anime for a relation group (APK behavior). Use `RelationId` from details or search item.

Request example
```http
POST /animeify/apis_v4/anime/load_related_anime.php
UserId=0&RelationId=R_xNarutoGroup&Language=English&Token=8cnY80AZSbUCmR26Vku1VUUY4
```

Response example
```json
[
  { "AnimeId": "xNaruto", "EN_Title": "Naruto", "Type": "SERIES", "Episodes": 220, "Thumbnail": "Naruto.jpg" },
  { "AnimeId": "xBorutoNarutoNextGenerations", "EN_Title": "Boruto: Naruto Next Generations", "Type": "SERIES", "Episodes": 293, "Thumbnail": "BorutoNarutoNextGenerations2.jpg" }
]
```

---

## 7) Related characters — characters/related_characters.php

- Method: POST
- Path: `characters/related_characters.php`
- Params: `UserId`, `RelationId`, `Token`
- Purpose: Characters list for a relation group (not `AnimeId`).

Request example
```http
POST /animeify/apis_v4/characters/related_characters.php
UserId=0&RelationId=R_xNarutoGroup&Token=8cnY80AZSbUCmR26Vku1VUUY4
```

Response example
```json
[
  { "Name": "Uzumaki Naruto", "Role": "Main", "Image": "https://.../characters/photos/chars/uzumaki_naruto.jpg" },
  { "Name": "Uchiha Sasuke",  "Role": "Main", "Image": "https://.../characters/photos/chars/uchiha_sasuke.jpg" }
]
```

---

## 8) Details glance (not required, discovered) — anime/load_anime_details_glance.php

- Method: POST
- Path: `anime/load_anime_details_glance.php`
- Params: `UserId`, `AnimeId`, `Token`
- Purpose: Lightweight details used by a glance dialog in the APK.

---

# Streaming servers and URL patterns

The API returns provider-specific IDs. The app builds playable URLs using fixed patterns. Below are provider names and URL constructions gathered from the Python script and the APK’s SDKs.

Provider map (server key → provider name)
- `OKLink` → OK.ru
- `MALink` → Mega.nz
- `GDLink` → Google Drive
- `LBLink` → LibreBoot
- `SVLink` → StreamVid (Sendvid)
- `FRLink` → MediaFire
- `SFLink` → StreamSB
- `FDLink` → FileHost
- Low-quality variants: `LBLowQ`, `SVLowQ`, `FRLowQ`
- Full-HD variants: `LBFhdQ`, `GDFhdQ`, `FRFhdQ`

URL patterns (embed/direct)
- OK.ru (OKLink)
  - `https://ok.ru/videoembed/{id}`
- Mega.nz (MALink)
  - `https://mega.nz/embed/{id}`
- MediaFire (FRLink, FRLowQ, FRFhdQ)
  - Embed page: `https://www.mediafire.com/file/{id}`
  - Direct extraction: scrape the page for `https://download...` link
- Google Drive (GDLink, GDFhdQ)
  - Direct media API: `https://www.googleapis.com/drive/v3/files/{id}?key=AIzaSyBzyqZekacyx5t_MGh_A-8-iz2tEeIzqwE&alt=media`
- StreamVid / Sendvid (SVLink, SVLowQ)
  - `https://sendvid.com/embed/{id}`
- LibreBoot (LBLink, LBLowQ, LBFhdQ)
  - Primary: `https://filelions.online/v/{id}`
  - Also whitelisted in app: `https://sbchill.com/e/{id}` (alternate embed accepted by the WebView)
- StreamSB (SFLink)
  - Inferred from app whitelist: `https://sbchill.com/e/{id}` (StreamSB mirrors often use `sbchill.com`)
- FileHost (FDLink)
  - Primary: `https://vanfem.com/v/{id}`
  - Also whitelisted in app: `https://embed.mystream.to/{id}`

Direct link handling and manipulations
- MediaFire: The app calls a helper (`CustomizedDownloader.FrDownload`) that fetches the MediaFire page and extracts the first `https://download...` URL. In Python, we replicate this by requesting the page and regexing the `https://download` link.
- Google Drive: The constructed URL is already a direct media endpoint (no scraping required). Requires the public file and the API key embedded in the client.
- Other providers (OK.ru, Mega.nz, Sendvid, FileLions, Vanfem, StreamSB): Used as embeds; no direct extraction implemented in the script.

---

# MyAnimeList (Jikan) enrichment

- GET `https://api.jikan.moe/v4/anime/{mal_id}`
- Used to supplement description, ratings, rank, popularity, and cover images when Animeify data is incomplete.

Response example (truncated)
```json
{
  "data": {
    "mal_id": 1735,
    "title": "Naruto: Shippuuden",
    "synopsis": "It has been two and a half years since Naruto Uzumaki left...",
    "score": 8.25,
    "scored_by": 1500000,
    "rank": 300,
    "popularity": 5,
    "images": { "jpg": { "image_url": "https://...jpg" } },
    "aired": { "string": "Feb 15, 2007 to Mar 23, 2017" },
    "duration": "23 min per ep",
    "studios": [ { "name": "Studio Pierrot" } ]
  }
}
```

---

# Field glossary (selected)

- AnimeModel (common in search/related):
  - `AnimeId`, `EN_Title`, `JP_Title`, `AR_Title`, `Synonyms`, `Type`, `Episodes`, `Status`, `Genres`, `Season`, `Duration`, `Thumbnail`, `Rating`, `MalId`, `RelationId`, `views`, library counts (`library_*`), ratings distribution (`rates_1..rates_10`).
- EpisodeModel (servers):
  - `Episode`, `Type`, provider keys (`LBLink`, `SVLink`, `OKLink`, `MALink`, `GDLink`, `FRLink`, `SFLink`, `FDLink`, plus LowQ/FhdQ variants), optional `EpisodeStatistics`.
- Details model:
  - `RelationId`, `Plot`, `AnimeStatistics` (same counters + `UserRate`, `views`), `RelatedAnime` array.

---

# Implementation notes

- Arabic description is fetched by calling details with `Language=AR` and reading `Plot`.
- Related anime should be read from details payload when present; if missing, call `anime/load_related_anime.php` with `RelationId` (English first, then Arabic fallback).
- Characters are retrieved via `characters/related_characters.php` with `RelationId` (not `AnimeId`).
- The CLI normalizes server listings and attempts MediaFire direct link extraction; other providers use embed links.
