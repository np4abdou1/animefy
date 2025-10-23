# Animeify.net API Documentation

<div style="background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); padding: 2rem; border-radius: 10px; margin-bottom: 2rem;">
  <h1 style="color: white; margin: 0; font-size: 2.5rem;">🎬 Animeify API v4</h1>
  <p style="color: rgba(255,255,255,0.9); margin: 0.5rem 0 0 0; font-size: 1.2rem;">Complete Public API Reference</p>
</div>

## 📋 Table of Contents

- [Overview](#overview)
- [Base Configuration](#base-configuration)
- [Authentication](#authentication)
- [Public Endpoints](#public-endpoints)
  - [Home & Discovery](#home--discovery)
  - [Anime Search & Browse](#anime-search--browse)
  - [Anime Details](#anime-details)
  - [Episodes](#episodes)
  - [Streaming Servers](#streaming-servers)
  - [Schedule & Seasons](#schedule--seasons)
  - [News](#news)
  - [Characters](#characters)
- [Response Models](#response-models)
- [Filter Types](#filter-types)
- [Server Types](#server-types)
- [Error Handling](#error-handling)
- [Rate Limiting](#rate-limiting)

---

## Overview

The Animeify API provides access to a comprehensive anime database with streaming links, episode information, schedules, and more. This documentation covers **public endpoints only** - endpoints requiring user authentication (watch history, favorites, library) are excluded.

**API Version:** v4  
**Base URL:** `https://animeify.net/animeify/apis_v4/`  
**Protocol:** HTTP POST (form-urlencoded)  
**Response Format:** JSON

---

## Base Configuration

### API Constants

```javascript
const ANIMEIFY_API_BASE = "https://animeify.net/animeify/apis_v4/";
const ANIMEIFY_TOKEN = "8cnY80AZSbUCmR26Vku1VUUY4";
const THUMBNAILS_BASE_URL = "https://animeify.net/animeify/files/thumbnails/";
const TRAILERS_BASE_URL = "https://animeify.net/animeify/files/trailers/";
```

### Resource URLs

| Resource Type | Base URL |
|--------------|----------|
| Thumbnails | `https://animeify.net/animeify/files/thumbnails/` |
| Trailers | `https://animeify.net/animeify/files/trailers/` |
| News Covers | `https://animeify.net/animeify/files/news/cover_thumbnails/` |
| Character Photos | `https://animeify.net/animeify/files/characters/photos/chars/` |
| Voice Actor Photos | `https://animeify.net/animeify/files/characters/photos/voiceactors/` |
| Trending Photos | `https://animeify.net/animeify/files/trending/photos/` |

---

## Authentication

All API requests require a **Token** parameter:

```
Token: 8cnY80AZSbUCmR26Vku1VUUY4
```

For public endpoints, use `UserId: 0` to indicate an anonymous/guest user.

---

## Public Endpoints

### Home & Discovery

#### 1. Load Home Content

**Endpoint:** `home/load_home.php`

Loads the main home screen content including latest episodes, airing today, premiered anime, and news.

**Request Parameters:**
```
UserId: 0
Language: English
Broadcast: MONDAY | TUESDAY | WEDNESDAY | THURSDAY | FRIDAY | SATURDAY | SUNDAY
Premiered: WINTER 2024 | SPRING 2024 | SUMMER 2024 | FALL 2024
Token: 8cnY80AZSbUCmR26Vku1VUUY4
```

**Example Request (Python):**
```python
import requests

payload = {
    'UserId': '0',
    'Language': 'English',
    'Broadcast': 'MONDAY',
    'Premiered': 'FALL 2024',
    'Token': '8cnY80AZSbUCmR26Vku1VUUY4'
}

response = requests.post(
    'https://animeify.net/animeify/apis_v4/home/load_home.php',
    data=payload
)
data = response.json()
```

**Response Structure:**
```json
{
  "LatestEpisodes": [
    {
      "AnimeId": "12345",
      "EN_Title": "Attack on Titan",
      "JP_Title": "Shingeki no Kyojin",
      "Thumbnail": "aot_thumbnail.jpg",
      "Type": "SERIES",
      "Episodes": 87,
      "Status": "AIRING",
      "Genres": "Action, Drama, Fantasy",
      "Score": 9.1,
      "Rank": 1,
      "Popularity": 1,
      "LastEpisode": 87.0,
      "LastEpisodeType": "EPISODE"
    }
  ],
  "Broadcast": [
    {
      "AnimeId": "67890",
      "EN_Title": "My Hero Academia",
      "Broadcast": "SATURDAY",
      ...
    }
  ],
  "Premiere": [
    {
      "AnimeId": "11111",
      "EN_Title": "Chainsaw Man",
      "Premiered": "FALL 2024",
      ...
    }
  ],
  "LatestNews": [
    {
      "NewsId": "1",
      "Title": "New Season Announced",
      "Cover": "news_cover.jpg",
      "Date": "2024-10-20",
      ...
    }
  ],
  "UpdatesChart": {
    "TotalEpisodes": 150,
    "TotalAnime": 25
  }
}
```

---

#### 2. Load Trending Anime

**Endpoint:** `home/load_trending.php`

Loads trending/popular anime for the main slider.

**Request Parameters:**
```
UserId: 0
Language: English
Token: 8cnY80AZSbUCmR26Vku1VUUY4
```

**Response:** Array of anime objects with trending-specific photo URLs.

---

#### 3. Load Latest Episodes

**Endpoint:** `episodes/load_latest_episodes.php`

Loads the most recently updated episodes across all anime.

**Request Parameters:**
```
UserId: 0
Language: English
From: 0
Token: 8cnY80AZSbUCmR26Vku1VUUY4
```

**Parameters:**
- `From`: Pagination offset (increments of 20)

**Response:** Array of anime with their latest episode information.

---

### Anime Search & Browse

#### 4. Search Anime

**Endpoint:** `anime/load_anime_list_v2.php`

Search for anime by title or keywords.

**Request Parameters:**
```
UserId: 0
Language: English
FilterType: SEARCH
FilterData: naruto
Type: SERIES | MOVIE | OVA | SPECIAL | ONA | CARTOON | (empty for all)
From: 0
Token: 8cnY80AZSbUCmR26Vku1VUUY4
```

**Example Request (JavaScript):**
```javascript
const searchAnime = async (query) => {
  const formData = new URLSearchParams({
    'UserId': '0',
    'Language': 'English',
    'FilterType': 'SEARCH',
    'FilterData': query,
    'Type': 'SERIES',
    'From': '0',
    'Token': '8cnY80AZSbUCmR26Vku1VUUY4'
  });

  const response = await fetch(
    'https://animeify.net/animeify/apis_v4/anime/load_anime_list_v2.php',
    {
      method: 'POST',
      headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
      body: formData
    }
  );

  return await response.json();
};
```

**Response:** Array of matching anime objects.

---

#### 5. Browse Anime with Filters

**Endpoint:** `anime/load_anime_list_v2.php`

Browse anime using various filters (genre, studio, status, season, sort).

**Filter Types:**

| FilterType | FilterData Examples | Description |
|------------|-------------------|-------------|
| `GENRE` | `Action`, `Comedy`, `Drama`, `Fantasy` | Filter by genre |
| `STUDIOS` | `Studio Ghibli`, `Madhouse`, `Bones` | Filter by studio |
| `PREMIERED` | `WINTER 2024`, `SPRING 2023` | Filter by premiere season |
| `STATUS` | `AIRING`, `AIRED`, `UPCOMING` | Filter by airing status |
| `SORT` | `HIGHEST_RATE`, `NAME`, `PREMIERED_DEC`, `EPISODES_DEC` | Sort results |

**Example - Browse by Genre:**
```
FilterType: GENRE
FilterData: Action
Type: SERIES
From: 0
```

**Example - Sort by Rating:**
```
FilterType: SORT
FilterData: HIGHEST_RATE
Type: (empty)
From: 0
```

**Example - Filter by Season:**
```
FilterType: PREMIERED
FilterData: FALL 2024
Type: (empty)
From: 0
```

**Pagination:**
- Results return in batches of ~20 items
- Use `From` parameter to load more: 0, 20, 40, 60, etc.

---

### Anime Details

#### 6. Load Anime Details (Full)

**Endpoint:** `anime/load_anime_details.php`

Get complete details for a specific anime including synopsis, staff, relations, and statistics.

**Request Parameters:**
```
UserId: 0
AnimeId: 12345
Token: 8cnY80AZSbUCmR26Vku1VUUY4
```

**Response Structure:**
```json
{
  "AnimeId": "12345",
  "EN_Title": "Attack on Titan",
  "JP_Title": "Shingeki no Kyojin",
  "AR_Title": "هجوم العمالقة",
  "Synonyms": "AoT, SNK",
  "Tags": "titans, military, dark fantasy",
  "Genres": "Action, Drama, Fantasy",
  "Premiered": "SPRING 2013",
  "Aired": "Apr 7, 2013 to ...",
  "Broadcast": "SUNDAY",
  "Duration": 24,
  "Thumbnail": "aot.jpg",
  "Trailer": "aot_trailer.mp4",
  "YTTrailer": "youtube_video_id",
  "Creators": "Wit Studio, MAPPA",
  "Status": "AIRING",
  "Episodes": 87,
  "Score": 9.1,
  "Rank": 1,
  "Popularity": 1,
  "Rating": "PG-17",
  "MalId": "16498",
  "Type": "SERIES",
  "rates_1": 50,
  "rates_2": 100,
  "rates_3": 200,
  "rates_4": 500,
  "rates_5": 1000,
  "rates_6": 2000,
  "rates_7": 5000,
  "rates_8": 10000,
  "rates_9": 15000,
  "rates_10": 25000,
  "library_favourites": 50000,
  "library_watch_done": 30000,
  "library_watch_later": 20000,
  "library_watch_currently": 10000,
  "views": 1000000
}
```

---

#### 7. Load Anime Details (Glance)

**Endpoint:** `anime/load_anime_details_glance.php`

Get quick/summary details for a specific anime (lighter version).

**Request Parameters:**
```
UserId: 0
AnimeId: 12345
Token: 8cnY80AZSbUCmR26Vku1VUUY4
```

---

#### 8. Load Related Anime

**Endpoint:** `anime/load_related_anime.php`

Get related anime (sequels, prequels, spin-offs, etc.) for a specific anime.

**Request Parameters:**
```
AnimeId: 12345
Token: 8cnY80AZSbUCmR26Vku1VUUY4
```

**Response:** Array of related anime with relation types.

---

### Episodes

#### 9. Load Episodes

**Endpoint:** `episodes/load_episodes.php`

Get all episodes for a specific anime.

**Request Parameters:**
```
AnimeID: 12345
Token: 8cnY80AZSbUCmR26Vku1VUUY4
```

**Example Request (Python):**
```python
payload = {
    'AnimeID': '12345',
    'Token': '8cnY80AZSbUCmR26Vku1VUUY4'
}

response = requests.post(
    'https://animeify.net/animeify/apis_v4/episodes/load_episodes.php',
    data=payload
)
episodes = response.json()
```

**Response Structure:**
```json
[
  {
    "eId": 1,
    "AnimeID": "12345",
    "Episode": 1.0,
    "Type": "EPISODE",
    "MarkedAs": "NORMAL",
    "ExtraEpisodes": ""
  },
  {
    "eId": 2,
    "AnimeID": "12345",
    "Episode": 2.0,
    "Type": "EPISODE",
    "MarkedAs": "FILLER",
    "ExtraEpisodes": ""
  }
]
```

**Episode Types:**
- `EPISODE` - Regular episode
- `SPECIAL` - Special episode
- `OVA` - Original Video Animation
- `MOVIE` - Movie

**Marked As:**
- `NORMAL` - Regular episode
- `FILLER` - Filler episode
- `LAST` - Final episode
- `LAST_FILLER` - Final filler episode

---

### Streaming Servers

#### 10. Load Streaming Servers

**Endpoint:** `anime/load_servers.php`

Get all available streaming server links for a specific episode.

**Request Parameters:**
```
UserId: 0
AnimeId: 12345
Episode: 1
AnimeType: SERIES
Token: 8cnY80AZSbUCmR26Vku1VUUY4
```

**Example Request (Python):**
```python
payload = {
    'UserId': '0',
    'AnimeId': '12345',
    'Episode': '1',
    'AnimeType': 'SERIES',
    'Token': '8cnY80AZSbUCmR26Vku1VUUY4'
}

response = requests.post(
    'https://animeify.net/animeify/apis_v4/anime/load_servers.php',
    data=payload
)
servers = response.json()
```

**Response Structure:**
```json
{
  "CurrentEpisode": {
    "Episode": 1.0,
    "Type": "EPISODE",
    
    "OKLink": "video_id_here",
    "MALink": "mega_file_id",
    "GDLink": "google_drive_file_id",
    "FRLink": "mediafire_file_id",
    "LBLink": "libreboot_url",
    "SVLink": "streamvid_url",
    "SFLink": "streamsb_url",
    "FDLink": "filehost_url",
    
    "LBLowQ": "libreboot_480p_url",
    "SVLowQ": "streamvid_480p_url",
    "FRLowQ": "mediafire_480p_id",
    
    "LBFhdQ": "libreboot_1080p_url",
    "GDFhdQ": "google_drive_1080p_id",
    "FRFhdQ": "mediafire_1080p_id"
  },
  "NextEpisode": {
    "Episode": 2.0,
    "Type": "EPISODE"
  },
  "PreviousEpisode": null
}
```

**Server Link Construction:**

The API returns server IDs/codes that need to be converted to full URLs:

| Server | Field | URL Pattern |
|--------|-------|-------------|
| OK.ru | `OKLink` | `https://ok.ru/videoembed/{OKLink}` |
| Mega.nz | `MALink` | `https://mega.nz/embed/{MALink}` |
| MediaFire | `FRLink` | `https://www.mediafire.com/file/{FRLink}` |
| Google Drive | `GDLink` | `https://www.googleapis.com/drive/v3/files/{GDLink}?key=AIzaSyBzyqZekacyx5t_MGh_A-8-iz2tEeIzqwE&alt=media` |

**Example - Convert Server Links:**
```python
def build_streaming_url(server_link, server_type):
    if server_link.startswith('http'):
        return server_link
    
    patterns = {
        'OK': 'https://ok.ru/videoembed/',
        'MA': 'https://mega.nz/embed/',
        'FR': 'https://www.mediafire.com/file/',
        'GD': 'https://www.googleapis.com/drive/v3/files/{0}?key=AIzaSyBzyqZekacyx5t_MGh_A-8-iz2tEeIzqwE&alt=media'
    }
    
    for prefix, base_url in patterns.items():
        if prefix in server_type:
            return base_url.format(server_link) if '{0}' in base_url else base_url + server_link
    
    return server_link

# Usage
ok_url = build_streaming_url("123456789", "OKLink")
# Result: https://ok.ru/videoembed/123456789
```

**Quality Levels:**
- **Standard (720p):** `OKLink`, `MALink`, `GDLink`, `LBLink`, `SVLink`, `FRLink`, `SFLink`, `FDLink`
- **Low Quality (480p):** `LBLowQ`, `SVLowQ`, `FRLowQ`
- **Full HD (1080p):** `LBFhdQ`, `GDFhdQ`, `FRFhdQ`

---

### Schedule & Seasons

#### 11. Load Schedule

**Endpoint:** `explore/load_shcedule.php`

Get airing schedule for a specific day of the week.

**Request Parameters:**
```
UserId: 0
Day: MONDAY | TUESDAY | WEDNESDAY | THURSDAY | FRIDAY | SATURDAY | SUNDAY
Token: 8cnY80AZSbUCmR26Vku1VUUY4
```

**Response:** Array of anime airing on the specified day.

---

#### 12. Load Seasons

**Endpoint:** `explore/load_seasons.php`

Get anime by season and year.

**Request Parameters:**
```
UserId: 0
Season: WINTER 2024 | SPRING 2024 | SUMMER 2024 | FALL 2024
Token: 8cnY80AZSbUCmR26Vku1VUUY4
```

**Response:** Array of anime that premiered in the specified season.

---

### News

#### 13. Load News

**Endpoint:** `news/load_news.php`

Get anime news articles.

**Request Parameters:**
```
UserId: 0
From: 0
Token: 8cnY80AZSbUCmR26Vku1VUUY4
```

**Response Structure:**
```json
[
  {
    "NewsId": "1",
    "Title": "Attack on Titan Final Season Announced",
    "Cover": "news_cover.jpg",
    "Content": "Full news content here...",
    "Date": "2024-10-20",
    "Views": 10000,
    "CategoryType": "ANIME"
  }
]
```

**News Cover URL:** `https://animeify.net/animeify/files/news/cover_thumbnails/{Cover}`

---

### Characters

#### 14. Load Characters List

**Endpoint:** `characters/characters_list.php`

Get characters for a specific anime.

**Request Parameters:**
```
AnimeId: 12345
Token: 8cnY80AZSbUCmR26Vku1VUUY4
```

**Response:** Array of character objects with names, roles, and photos.

---

#### 15. Search Characters

**Endpoint:** `characters/characters_search.php`

Search for characters by name.

**Request Parameters:**
```
SearchQuery: naruto
From: 0
Token: 8cnY80AZSbUCmR26Vku1VUUY4
```

**Response:** Array of matching characters.

---

#### 16. Load Character Details

**Endpoint:** `characters/characters_details.php`

Get detailed information about a specific character.

**Request Parameters:**
```
CharacterId: 123
Token: 8cnY80AZSbUCmR26Vku1VUUY4
```

**Response:** Character details including bio, voice actors, anime appearances.

---

#### 17. Load Related Characters

**Endpoint:** `characters/related_characters.php`

Get characters related to a specific character.

**Request Parameters:**
```
CharacterId: 123
Token: 8cnY80AZSbUCmR26Vku1VUUY4
```

---

## Response Models

### AnimeModel

```typescript
interface AnimeModel {
  AnimeId: string;
  EN_Title: string;
  JP_Title: string;
  AR_Title: string;
  Synonyms: string;
  Tags: string;
  Genres: string;
  Season: number;
  Premiered: string;
  Aired: string;
  Broadcast: string;
  Duration: number;
  Thumbnail: string;
  Trailer: string;
  YTTrailer: string;
  Creators: string;
  Status: "AIRING" | "AIRED" | "UPCOMING" | "PAUSED" | "UNAVAILABLE";
  Episodes: number;
  Score: number;
  Rank: number;
  Popularity: number;
  Rating: "ALLAGES" | "PG-13" | "PG-17" | "CHILDREN";
  RelationId: string;
  MalId: string;
  Type: "SERIES" | "MOVIE" | "OVA" | "ONA" | "SPECIAL" | "CARTOON";
  rates_1: number;
  rates_2: number;
  rates_3: number;
  rates_4: number;
  rates_5: number;
  rates_6: number;
  rates_7: number;
  rates_8: number;
  rates_9: number;
  rates_10: number;
  library_favourites: number;
  library_watch_done: number;
  library_watch_later: number;
  library_watch_currently: number;
  views: number;
}
```

### EpisodeModel

```typescript
interface EpisodeModel {
  eId: number;
  AnimeID: string;
  Episode: number;
  ExtraEpisodes: string;
  Type: "EPISODE" | "SPECIAL" | "OVA" | "MOVIE";
  MarkedAs: "NORMAL" | "FILLER" | "LAST" | "LAST_FILLER";
  
  // Standard Quality (720p)
  OKLink: string;
  MALink: string;
  GDLink: string;
  LBLink: string;
  SVLink: string;
  FRLink: string;
  SFLink: string;
  FDLink: string;
  
  // Low Quality (480p)
  LBLowQ: string;
  SVLowQ: string;
  FRLowQ: string;
  
  // Full HD (1080p)
  LBFhdQ: string;
  GDFhdQ: string;
  FRFhdQ: string;
}
```

### NewsModel

```typescript
interface NewsModel {
  NewsId: string;
  Title: string;
  Cover: string;
  Content: string;
  Date: string;
  Views: number;
  CategoryType: "ANIME" | "NEWS" | "CHARACTER" | "OTHERS";
}
```

### CharacterModel

```typescript
interface CharacterModel {
  CharacterId: string;
  Name: string;
  JP_Name: string;
  Photo: string;
  Role: string;
  About: string;
  Favourites: number;
}
```

---

## Filter Types

### Content Types

```
SERIES    - TV Series
MOVIE     - Movies
OVA       - Original Video Animation
ONA       - Original Net Animation
SPECIAL   - Special Episodes
CARTOON   - Cartoons
```

### Anime Status

```
AIRING      - Currently airing
AIRED       - Finished airing
UPCOMING    - Not yet aired
PAUSED      - Temporarily paused
UNAVAILABLE - Not available
```

### Age Ratings

```
ALLAGES   - All Ages
PG-13     - Parental Guidance 13+
PG-17     - Parental Guidance 17+
CHILDREN  - Children only
```

### Genres

```
Action, Adventure, Comedy, Drama, Fantasy, Horror, Mystery, 
Psychological, Romance, Sci-Fi, Slice of Life, Sports, 
Supernatural, Thriller, Mecha, Historical, School, Military,
Shounen, Shoujo, Seinen, Josei
```

### Sort Options

```
HIGHEST_RATE    - Highest rated
HIGHEST_RANK    - Highest ranked
NAME            - Alphabetical by name
PREMIERED_DEC   - Latest premiered first
PREMIERED_ACS   - Oldest premiered first
EPISODES_DEC    - Most episodes first
EPISODES_ASC    - Least episodes first
```

### Seasons

Format: `{SEASON} {YEAR}`

Examples:
```
WINTER 2024
SPRING 2024
SUMMER 2024
FALL 2024
```

### Days of Week

```
SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
```

---

## Server Types

### Standard Quality Servers (720p)

| Server Code | Server Name | URL Pattern |
|-------------|-------------|-------------|
| `OK` | OK.ru | `https://ok.ru/videoembed/{id}` |
| `MA` | Mega.nz | `https://mega.nz/embed/{id}` |
| `GD` | Google Drive | `https://www.googleapis.com/drive/v3/files/{id}?key=...&alt=media` |
| `FR` | MediaFire | `https://www.mediafire.com/file/{id}` |
| `LB` | LibreBoot | Direct URL |
| `SV` | StreamVid | Direct URL |
| `SF` | StreamSB | Direct URL |
| `FD` | FileHost | Direct URL |

### Quality Suffixes

- **LowQ** - Low Quality (480p)
- **FhdQ** - Full HD (1080p)
- *No suffix* - Standard Quality (720p)

---

## Error Handling

### Common Error Responses

**Invalid Token:**
```json
{
  "error": "Invalid token",
  "status": "failed"
}
```

**No Results:**
```json
[]
```

**Missing Parameters:**
```json
{
  "error": "Missing required parameters",
  "status": "failed"
}
```

### HTTP Status Codes

- `200` - Success
- `400` - Bad Request (missing parameters)
- `401` - Unauthorized (invalid token)
- `404` - Not Found
- `500` - Internal Server Error

---

## Rate Limiting

**Current Limits:**
- No strict rate limiting enforced
- Recommended: Max 60 requests per minute
- Use caching when possible to reduce API calls

**Best Practices:**
1. Cache responses when data doesn't change frequently
2. Use pagination (`From` parameter) instead of loading all data
3. Combine related requests when possible
4. Implement exponential backoff for retries

---

## Code Examples

### Python - Complete Search & Play Flow

```python
import requests

API_BASE = "https://animeify.net/animeify/apis_v4/"
TOKEN = "8cnY80AZSbUCmR26Vku1VUUY4"

def search_anime(query):
    """Search for anime"""
    payload = {
        'UserId': '0',
        'Language': 'English',
        'FilterType': 'SEARCH',
        'FilterData': query,
        'Type': 'SERIES',
        'From': '0',
        'Token': TOKEN
    }
    
    response = requests.post(f"{API_BASE}anime/load_anime_list_v2.php", data=payload)
    return response.json()

def get_episodes(anime_id):
    """Get all episodes for an anime"""
    payload = {
        'AnimeID': anime_id,
        'Token': TOKEN
    }
    
    response = requests.post(f"{API_BASE}episodes/load_episodes.php", data=payload)
    return response.json()

def get_servers(anime_id, episode, anime_type="SERIES"):
    """Get streaming servers for an episode"""
    payload = {
        'UserId': '0',
        'AnimeId': anime_id,
        'Episode': str(episode),
        'AnimeType': anime_type,
        'Token': TOKEN
    }
    
    response = requests.post(f"{API_BASE}anime/load_servers.php", data=payload)
    return response.json()

def build_stream_url(server_id, server_type):
    """Convert server ID to full URL"""
    if server_id.startswith('http'):
        return server_id
    
    patterns = {
        'OK': f'https://ok.ru/videoembed/{server_id}',
        'MA': f'https://mega.nz/embed/{server_id}',
        'FR': f'https://www.mediafire.com/file/{server_id}',
        'GD': f'https://www.googleapis.com/drive/v3/files/{server_id}?key=AIzaSyBzyqZekacyx5t_MGh_A-8-iz2tEeIzqwE&alt=media'
    }
    
    for prefix, url in patterns.items():
        if prefix in server_type:
            return url
    
    return server_id

# Example usage
results = search_anime("naruto")
if results:
    anime = results[0]
    anime_id = anime['AnimeId']
    
    episodes = get_episodes(anime_id)
    if episodes:
        first_episode = episodes[0]['Episode']
        
        servers = get_servers(anime_id, first_episode)
        current_ep = servers.get('CurrentEpisode', {})
        
        if current_ep.get('OKLink'):
            stream_url = build_stream_url(current_ep['OKLink'], 'OKLink')
            print(f"Stream URL: {stream_url}")
```

### JavaScript - Browse with Filters

```javascript
const API_BASE = "https://animeify.net/animeify/apis_v4/";
const TOKEN = "8cnY80AZSbUCmR26Vku1VUUY4";

async function browseAnime(filters = {}) {
  const {
    genre = '',
    studio = '',
    season = '',
    status = '',
    sortBy = '',
    type = '',
    from = 0
  } = filters;
  
  // Determine filter type and data
  let filterType = '';
  let filterData = '';
  
  if (genre) {
    filterType = 'GENRE';
    filterData = genre;
  } else if (studio) {
    filterType = 'STUDIOS';
    filterData = studio;
  } else if (season) {
    filterType = 'PREMIERED';
    filterData = season;
  } else if (status) {
    filterType = 'STATUS';
    filterData = status;
  } else if (sortBy) {
    filterType = 'SORT';
    filterData = sortBy === 'RATING' ? 'HIGHEST_RATE' : sortBy;
  }
  
  const formData = new URLSearchParams({
    'UserId': '0',
    'Language': 'English',
    'FilterType': filterType,
    'FilterData': filterData,
    'Type': type,
    'From': from.toString(),
    'Token': TOKEN
  });
  
  const response = await fetch(
    `${API_BASE}anime/load_anime_list_v2.php`,
    {
      method: 'POST',
      headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
      body: formData
    }
  );
  
  return await response.json();
}

// Usage examples
const actionAnime = await browseAnime({ genre: 'Action', type: 'SERIES' });
const fall2024 = await browseAnime({ season: 'FALL 2024' });
const topRated = await browseAnime({ sortBy: 'HIGHEST_RATE' });
const airingNow = await browseAnime({ status: 'AIRING' });
```

### TypeScript - Home Content Aggregator

```typescript
const API_BASE = "https://animeify.net/animeify/apis_v4/";
const TOKEN = "8cnY80AZSbUCmR26Vku1VUUY4";

interface HomeContent {
  latestEpisodes: any[];
  airingToday: any[];
  premieredAnime: any[];
  latestNews: any[];
  trending: any[];
}

async function getHomeContent(): Promise<HomeContent> {
  const today = ['SUNDAY', 'MONDAY', 'TUESDAY', 'WEDNESDAY', 'THURSDAY', 'FRIDAY', 'SATURDAY'][new Date().getDay()];
  const currentSeason = getCurrentSeason();
  
  // Fetch home data
  const homeFormData = new URLSearchParams({
    'UserId': '0',
    'Language': 'English',
    'Broadcast': today,
    'Premiered': currentSeason,
    'Token': TOKEN
  });
  
  const homeResponse = await fetch(`${API_BASE}home/load_home.php`, {
    method: 'POST',
    headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
    body: homeFormData
  });
  
  const homeData = await homeResponse.json();
  
  // Fetch trending data
  const trendingFormData = new URLSearchParams({
    'UserId': '0',
    'Language': 'English',
    'Token': TOKEN
  });
  
  const trendingResponse = await fetch(`${API_BASE}home/load_trending.php`, {
    method: 'POST',
    headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
    body: trendingFormData
  });
  
  const trendingData = await trendingResponse.json();
  
  return {
    latestEpisodes: homeData.LatestEpisodes || [],
    airingToday: homeData.Broadcast || [],
    premieredAnime: homeData.Premiere || [],
    latestNews: homeData.LatestNews || [],
    trending: trendingData || []
  };
}

function getCurrentSeason(): string {
  const month = new Date().getMonth() + 1;
  const year = new Date().getFullYear();
  
  if (month >= 1 && month <= 3) return `WINTER ${year}`;
  if (month >= 4 && month <= 6) return `SPRING ${year}`;
  if (month >= 7 && month <= 9) return `SUMMER ${year}`;
  return `FALL ${year}`;
}
```

---

## Cloudflare Worker Proxy Example

The repository includes a Cloudflare Worker that acts as a REST API wrapper around the Animeify API. This provides cleaner endpoints and better caching.

**Worker Endpoints:**

```
GET  /                          - API info
GET  /health                    - Health check
GET  /api/home_content          - Aggregated home data
GET  /api/latest_episodes?from=0 - Latest episodes
GET  /api/search?q=naruto&type=SERIES - Search anime
GET  /api/browse?genre=Action   - Browse with filters
GET  /api/anime/:id             - Anime details
GET  /api/anime/:id/episodes    - Anime episodes
GET  /api/genres                - Available genres
GET  /api/studios               - Available studios
```

**Example Usage:**
```javascript
// Using the worker endpoint
const response = await fetch('https://witanime-api-worker.YOUR-SUBDOMAIN.workers.dev/api/search?q=naruto');
const data = await response.json();
```

---

## Additional Notes

### Language Support

The API supports multiple languages:
- `English` - English titles and content
- `Arabic` - Arabic titles and content
- `Japanese` - Japanese titles

Use the `Language` parameter in requests. Default is `English`.

### MyAnimeList Integration

Many anime have a `MalId` field that links to MyAnimeList. You can use this with the Jikan API:

```javascript
const malId = anime.MalId;
const jikanUrl = `https://api.jikan.moe/v4/anime/${malId}`;
const malData = await fetch(jikanUrl).then(r => r.json());
```

### Thumbnail URLs

Construct full thumbnail URLs:
```
https://animeify.net/animeify/files/thumbnails/{Thumbnail}
```

Example:
```
https://animeify.net/animeify/files/thumbnails/aot_thumbnail.jpg
```

### Mobile App

This API was originally used by the Animeify v3.0.9 Android app. The decompiled C# code in the `dll api/AQ/` folder shows the original implementation.

---

<div style="background: #f8f9fa; padding: 2rem; border-radius: 10px; margin-top: 3rem;">
  <h2 style="margin-top: 0;">📞 Support & Resources</h2>
  <ul>
    <li><strong>Browser CLI:</strong> <code>animeify_browser_v1.0.py</code> - Interactive Python CLI for testing the API</li>
    <li><strong>Worker Source:</strong> <code>worker/index.js</code> - Cloudflare Worker implementation</li>
    <li><strong>Decompiled Source:</strong> <code>dll api/AQ/</code> - Original Android app C# code</li>
  </ul>
</div>

---

<div style="text-align: center; padding: 2rem; color: #666;">
  <p><strong>Animeify API Documentation v1.0</strong></p>
  <p>Reverse-engineered from Animeify v3.0.9 Android App</p>
  <p>For educational and development purposes</p>
</div>
