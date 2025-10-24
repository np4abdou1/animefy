#!/usr/bin/env python3
"""
Animeify Browser v1.0
Interactive anime search and streaming link browser
Reverse-engineered from Animeify v3.0.9 Android app
"""

import sys
import requests
import re
import argparse
import json
from typing import List, Dict, Optional, Any
from colorama import init, Fore, Back, Style

init(autoreset=True)

if sys.platform == 'win32':
    sys.stdout.reconfigure(encoding='utf-8')


# ============================================================================
# API CONFIGURATION
# ============================================================================

ANIMEIFY_API_BASE = "https://animeify.net/animeify/apis_v4/"
ANIMEIFY_TOKEN = "8cnY80AZSbUCmR26Vku1VUUY4"
MYANIMELIST_API_BASE = "https://api.jikan.moe/v4/anime/"
THUMBNAILS_BASE_URL = "https://animeify.net/animeify/files/thumbnails/"
DEFAULT_HTTP_HEADERS = {
    "Accept": "application/json, text/plain, */*",
    "User-Agent": "AnimeifyBrowser/1.0 (+python-requests)",
    "X-Requested-With": "XMLHttpRequest",
}
DEBUG_LOGGING = False


# ============================================================================
# API REQUESTS
# ============================================================================

def search_anime_titles(search_query: str, content_type: str = "SERIES") -> List[Dict]:
    """Search anime using Animeify API with SEARCH filter type"""
    
    endpoint_url = ANIMEIFY_API_BASE + "anime/load_anime_list_v2.php"
    
    request_payload = {
        'UserId': '0',
        'Language': 'English',
        'FilterType': 'SEARCH',
        'FilterData': search_query,
        'Type': content_type,
        'From': '0',
        'Token': ANIMEIFY_TOKEN
    }
    
    try:
        api_response = requests.post(endpoint_url, data=request_payload, headers=DEFAULT_HTTP_HEADERS, timeout=10)
        api_response.raise_for_status()
        try:
            return api_response.json()
        except ValueError:
            # Non-JSON response; treat as no results
            return []
    except requests.exceptions.RequestException as error:
        if DEBUG_LOGGING:
            print(f"{Fore.RED}✗ Search failed: {error}{Style.RESET_ALL}")
        return []


def fetch_myanimelist_data(mal_anime_id: str) -> Optional[Dict]:
    """Get additional anime info from MyAnimeList via Jikan API"""
    
    if not mal_anime_id or mal_anime_id == "0":
        return None
    
    try:
        jikan_url = MYANIMELIST_API_BASE + mal_anime_id
        jikan_response = requests.get(jikan_url, timeout=10)
        jikan_response.raise_for_status()
        return jikan_response.json().get('data')
    except requests.exceptions.RequestException:
        return None


def load_anime_episodes(anime_identifier: str) -> List[Dict]:
    """Load all episodes for specified anime"""
    
    endpoint_url = ANIMEIFY_API_BASE + "episodes/load_episodes.php"
    
    request_payload = {
        'AnimeID': anime_identifier,
        'Token': ANIMEIFY_TOKEN
    }
    
    try:
        api_response = requests.post(endpoint_url, data=request_payload, headers=DEFAULT_HTTP_HEADERS, timeout=10)
        api_response.raise_for_status()
        try:
            return api_response.json()
        except ValueError:
            return []
    except requests.exceptions.RequestException as error:
        if DEBUG_LOGGING:
            print(f"{Fore.RED}✗ Episode loading failed: {error}{Style.RESET_ALL}")
        return []


def fetch_streaming_servers(anime_identifier: str, episode_number, content_type: str = "SERIES") -> Optional[Dict]:
    """Get streaming server links for specific episode"""
    
    endpoint_url = ANIMEIFY_API_BASE + "anime/load_servers.php"
    
    request_payload = {
        'UserId': '0',
        'AnimeId': anime_identifier,
        'Episode': str(episode_number),
        'AnimeType': content_type,
        'Token': ANIMEIFY_TOKEN
    }
    
    try:
        api_response = requests.post(endpoint_url, data=request_payload, headers=DEFAULT_HTTP_HEADERS, timeout=10)
        api_response.raise_for_status()
        try:
            return api_response.json()
        except ValueError:
            return None
    except requests.exceptions.RequestException as error:
        if DEBUG_LOGGING:
            print(f"{Fore.RED}✗ Server loading failed: {error}{Style.RESET_ALL}")
        return None


def fetch_anime_details(anime_identifier: str,
                        relation_id: str = "",
                        user_id: str = "0",
                        language: str = "English") -> Optional[Dict]:
    """Fetch detailed anime info and statistics from Animeify (load_anime_details.php)."""

    endpoint_url = ANIMEIFY_API_BASE + "anime/load_anime_details.php"
    request_payload = {
        'UserId': str(user_id),
        'Language': language,
        'AnimeId': anime_identifier,
        'AnimeRelationId': relation_id,
        'Token': ANIMEIFY_TOKEN
    }
    try:
        api_response = requests.post(endpoint_url, data=request_payload, headers=DEFAULT_HTTP_HEADERS, timeout=10)
        api_response.raise_for_status()
        try:
            return api_response.json()
        except ValueError:
            # Graceful fallback when server returns empty/non-JSON
            return None
    except requests.exceptions.RequestException as error:
        # Network-level error (quiet unless debugging enabled)
        if DEBUG_LOGGING:
            print(f"{Fore.RED}✗ Details loading failed: {error}{Style.RESET_ALL}")
        return None


def fetch_anime_details_v2(anime_identifier: str,
                           relation_id: str = "",
                           user_id: str = "0",
                           language: str = "English") -> Optional[Dict]:
    """Attempt to fetch details from a potential v2 endpoint; fallback handled by caller.

    Note: The presence of this endpoint can vary; failures are treated as absence.
    """

    endpoint_url = ANIMEIFY_API_BASE + "anime/load_anime_details_v2.php"
    request_payload = {
        'UserId': str(user_id),
        'Language': language,
        'AnimeId': anime_identifier,
        'AnimeRelationId': relation_id,
        'Token': ANIMEIFY_TOKEN
    }
    try:
        api_response = requests.post(endpoint_url, data=request_payload, headers=DEFAULT_HTTP_HEADERS, timeout=10)
        api_response.raise_for_status()
        try:
            return api_response.json()
        except ValueError:
            return None
    except requests.exceptions.RequestException:
        return None


def fetch_related_characters_by_relation(relation_id: str, user_id: str = "0") -> List[Dict]:
    """Fetch related characters using RelationId (as per APK).

    Endpoint expects: UserId, RelationId, Token
    """
    endpoint_url = ANIMEIFY_API_BASE + "characters/related_characters.php"
    request_payload = {
        'UserId': str(user_id),
        'RelationId': relation_id,
        'Token': ANIMEIFY_TOKEN
    }
    try:
        api_response = requests.post(endpoint_url, data=request_payload, headers=DEFAULT_HTTP_HEADERS, timeout=10)
        api_response.raise_for_status()
        try:
            data = api_response.json()
        except ValueError:
            return []
        if isinstance(data, list):
            return data
        return data.get('Characters') or data.get('characters') or data.get('data') or []
    except requests.exceptions.RequestException:
        return []


def fetch_related_anime(relation_id: str, user_id: str = "0", language: Optional[str] = None) -> List[Dict]:
    """Fetch related anime using RelationId (matches APK behavior).

    Endpoint expects: UserId, RelationId, optional Language, Token
    """
    endpoint_url = ANIMEIFY_API_BASE + "anime/load_related_anime.php"
    request_payload = {
        'UserId': str(user_id),
        'RelationId': relation_id,
        'Token': ANIMEIFY_TOKEN
    }
    if language:
        request_payload['Language'] = language
    try:
        api_response = requests.post(endpoint_url, data=request_payload, headers=DEFAULT_HTTP_HEADERS, timeout=10)
        api_response.raise_for_status()
        try:
            data = api_response.json()
        except ValueError:
            return []
        if isinstance(data, list):
            return data
        return data.get('RelatedAnime') or data.get('data') or []
    except requests.exceptions.RequestException:
        return []


# ============================================================================
# WRAPPER CLIENT (PROGRAMMATIC API)
# ============================================================================

class AnimeifyClient:
    """High-level API client and CLI-friendly wrapper for Animeify + MAL (Jikan)"""

    def __init__(self,
                 animeify_base: str = ANIMEIFY_API_BASE,
                 thumbnails_base: str = THUMBNAILS_BASE_URL,
                 token: str = ANIMEIFY_TOKEN,
                 mal_base: str = MYANIMELIST_API_BASE) -> None:
        self.animeify_base = animeify_base
        self.thumbnails_base = thumbnails_base
        self.token = token
        self.mal_base = mal_base

    # -------- Core API calls --------
    def search(self, query: str, content_type: str = "SERIES") -> List[Dict[str, Any]]:
        return search_anime_titles(query, content_type)

    def mal(self, mal_anime_id: str) -> Optional[Dict[str, Any]]:
        return fetch_myanimelist_data(mal_anime_id)

    def episodes(self, anime_id: str) -> List[Dict[str, Any]]:
        return load_anime_episodes(anime_id)

    def servers(self, anime_id: str, episode: Any, content_type: str = "SERIES") -> Optional[Dict[str, Any]]:
        return fetch_streaming_servers(anime_id, episode, content_type)

    def details(self, anime_id: str, relation_id: str = "", user_id: str = "0", language: str = "English") -> Optional[Dict[str, Any]]:
        # Prefer v2 if available; fallback to original endpoint
        v2 = fetch_anime_details_v2(anime_id, relation_id, user_id, language)
        return v2 if v2 is not None else fetch_anime_details(anime_id, relation_id, user_id, language)

    def characters(self, relation_id: str, user_id: str = "0") -> List[Dict[str, Any]]:
        return fetch_related_characters_by_relation(relation_id, user_id)

    def related_anime(self, relation_id: str, user_id: str = "0", language: Optional[str] = None) -> List[Dict[str, Any]]:
        return fetch_related_anime(relation_id, user_id=user_id, language=language)

    # -------- Helpers / Builders --------
    def thumbnail_url(self, thumbnail_name: str) -> Optional[str]:
        if not thumbnail_name:
            return None
        return self.thumbnails_base + thumbnail_name

    def streaming_url(self, server_link: str, server_type_key: str) -> str:
        return build_streaming_url(server_link, server_type_key)

    def mediafire_direct(self, mediafire_url: str) -> Optional[str]:
        return extract_direct_mediafire_url(mediafire_url)

    # -------- Enrichment / Shaping --------
    def shape_search_result(self, raw: Dict[str, Any], enrich_with_mal: bool = True) -> Dict[str, Any]:
        """Normalize a single search result and optionally enrich with MAL details."""
        shaped: Dict[str, Any] = {
            "id": raw.get("AnimeId"),
            "titles": {
                "en": raw.get("EN_Title", "Unknown"),
                "jp": raw.get("JP_Title") or None,
                "ar": raw.get("AR_Title") or None,
                "synonyms": raw.get("Synonyms") or None,
            },
            "type": raw.get("Type"),  # SERIES or MOVIE
            "episodes": raw.get("Episodes"),
            "status": raw.get("Status"),  # Finished/Airing (as provided by Animeify)
            "genres": raw.get("Genres"),
            "season": raw.get("Season"),
            "premiered": raw.get("Premiered"),
            "aired": raw.get("Aired"),
            "broadcast": raw.get("Broadcast"),
            "duration": raw.get("Duration"),
            "thumbnail_url": self.thumbnail_url(raw.get("Thumbnail")),
            "trailer": raw.get("Trailer"),
            "yt_trailer": raw.get("YTTrailer"),
            "creators": raw.get("Creators"),
            "score": raw.get("Score"),
            "rank": raw.get("Rank"),
            "popularity": raw.get("Popularity"),
            "rating": raw.get("Rating"),  # age/content rating
            "views": raw.get("views"),
            "relation_id": raw.get("RelationId"),
            "library_counts": {
                "favourites": raw.get("library_favourites"),
                "watch_done": raw.get("library_watch_done"),
                "watch_later": raw.get("library_watch_later"),
                "watch_currently": raw.get("library_watch_currently"),
            },
            "ratings_distribution": {
                str(i): raw.get(f"rates_{i}") for i in range(1, 11)
            },
            "mal": {
                "id": raw.get("MalId") if raw.get("MalId") not in (None, "0") else None,
            },
        }

        if enrich_with_mal and shaped["mal"]["id"]:
            data = self.mal(shaped["mal"]["id"]) or {}
            shaped["mal"].update({
                "score": data.get("score"),
                "scored_by": data.get("scored_by"),
                "rank": data.get("rank"),
                "popularity": data.get("popularity"),
                "members": data.get("members"),
                "favorites": data.get("favorites"),
                "status": data.get("status"),  # e.g., Finished Airing / Currently Airing
                "type": data.get("type"),      # e.g., TV/Movie/OVA
            })

        return shaped

    def anime_details(self, raw: Dict[str, Any]) -> Dict[str, Any]:
        """Produce a detailed anime info object (Animeify details + MAL enrichment)."""
        shaped = self.shape_search_result(raw, enrich_with_mal=False)

        # Pull official Animeify details/statistics
        details = self.details(shaped.get("id")) or {}
        if details:
            # Plot/Library/AnimeStatistics/RelatedAnime
            shaped["description"] = details.get("Plot")
            stats = details.get("AnimeStatistics") or {}
            if stats:
                shaped["anime_statistics"] = {
                    "user_rate": stats.get("UserRate"),
                    "ratings_distribution": {str(i): stats.get(f"rates_{i}") for i in range(1, 11)},
                    "library_counts": {
                        "favourites": stats.get("library_favourites"),
                        "watch_done": stats.get("library_watch_done"),
                        "watch_later": stats.get("library_watch_later"),
                        "watch_currently": stats.get("library_watch_currently"),
                    },
                    "views": stats.get("views"),
                }
            shaped["related_anime"] = [self.shape_search_result(a, enrich_with_mal=False) for a in (details.get("RelatedAnime") or [])]

        # If RelatedAnime missing, try dedicated endpoint using RelationId
        if not shaped.get("related_anime"):
            relation_id = raw.get("RelationId") or (details.get("RelationId") if isinstance(details, dict) else None)
            if relation_id:
                # Prefer English labels; try Arabic fallback then generic
                rel = self.related_anime(relation_id, language="English") or self.related_anime(relation_id, language="AR") or self.related_anime(relation_id)
                if rel:
                    shaped["related_anime"] = [self.shape_search_result(a, enrich_with_mal=False) for a in rel]

        # MAL enrichment
        mal_id = (raw.get("MalId") if raw.get("MalId") not in (None, "0") else shaped.get("mal", {}).get("id"))
        if mal_id:
            mal_data = self.mal(mal_id) or {}
            images = ((mal_data.get("images") or {}).get("jpg") or {})
            shaped.update({
                "mal": {**shaped.get("mal", {}), **{
                    "id": mal_id,
                    "score": mal_data.get("score"),
                    "scored_by": mal_data.get("scored_by"),
                    "rank": mal_data.get("rank"),
                    "popularity": mal_data.get("popularity"),
                    "members": mal_data.get("members"),
                    "favorites": mal_data.get("favorites"),
                    "status": mal_data.get("status"),
                    "type": mal_data.get("type"),
                }}
            })
            shaped.update({
                "description": shaped.get("description") or mal_data.get("synopsis"),
                "aired": shaped.get("aired") or (mal_data.get("aired") or {}).get("string"),
                "duration": shaped.get("duration") or mal_data.get("duration"),
                "studios": [s.get("name") for s in (mal_data.get("studios") or [])],
                "trailer_url": ((mal_data.get("trailer") or {}).get("url"))
            })
            shaped.setdefault("images", {})
            shaped["images"].update({
                "mal_small": images.get("small_image_url"),
                "mal_large": images.get("large_image_url"),
                "mal_default": images.get("image_url"),
            })

        return shaped

    def list_episodes(self, episodes_raw: List[Dict[str, Any]]) -> List[Dict[str, Any]]:
        items: List[Dict[str, Any]] = []
        for ep in episodes_raw:
            num_raw = ep.get("Episode")
            try:
                num = float(num_raw)
            except (TypeError, ValueError):
                num = num_raw
            items.append({
                "episode": num,
                "label": f"Episode {num_raw}",
                "kind": ep.get("Type", "Episode"),
            })
        return items

    SERVER_LABELS = {
        # Standard
        "OKLink": ("OK.ru", "720p"),
        "MALink": ("Mega.nz", "720p"),
        "GDLink": ("Google Drive", "720p"),
        "LBLink": ("LibreBoot", "720p"),
        "SVLink": ("StreamVid", "720p"),
        "FRLink": ("MediaFire", "720p"),
        "SFLink": ("StreamSB", "720p"),
        "FDLink": ("FileHost", "720p"),
        # Low
        "LBLowQ": ("LibreBoot LowQ", "480p"),
        "SVLowQ": ("StreamVid LowQ", "480p"),
        "FRLowQ": ("MediaFire LowQ", "480p"),
        # Full HD
        "LBFhdQ": ("LibreBoot FHD", "1080p"),
        "GDFhdQ": ("Google Drive FHD", "1080p"),
        "FRFhdQ": ("MediaFire FHD", "1080p"),
    }

    def list_servers(self, servers_payload: Dict[str, Any]) -> Dict[str, Any]:
        """Normalize server response into an easy-to-consume structure with direct links when possible."""
        if not servers_payload:
            return {"episode": None, "servers": []}

        cur = servers_payload.get("CurrentEpisode", {})
        episode_val = cur.get("Episode")
        try:
            episode_num = float(episode_val)
        except (TypeError, ValueError):
            episode_num = episode_val

        # Episode-level statistics if present
        ep_stats = cur.get("EpisodeStatistics") or {}
        episode_statistics = None
        if ep_stats:
            episode_statistics = {
                "user_rate": ep_stats.get("UserRate"),
                "ratings_distribution": {str(i): ep_stats.get(f"rates_{i}") for i in range(1, 11)},
                "views": ep_stats.get("views"),
            }

        items: List[Dict[str, Any]] = []
        for key, (name, quality) in self.SERVER_LABELS.items():
            value = cur.get(key)
            if not value:
                continue

            embed = self.streaming_url(value, key)
            direct: Optional[str] = None
            # Attempt direct URL extraction for providers we can handle
            if key.startswith("FR") and embed.startswith("https://www.mediafire.com"):
                direct = self.mediafire_direct(embed)
            # Google Drive pattern we build is already a direct link
            if key.startswith("GD") and embed:
                direct = embed

            items.append({
                "server_key": key,
                "name": name,
                "quality": quality,
                "embed_url": embed,
                "direct_url": direct,
            })

        # Navigation
        next_ep = servers_payload.get("NextEpisode")
        prev_ep = servers_payload.get("PreviousEpisode")
        def _num(v):
            if not v:
                return None
            try:
                return float(v.get("Episode"))
            except Exception:
                return v.get("Episode")

        result = {
            "episode": episode_num,
            "servers": items,
            "next_episode": _num(next_ep),
            "previous_episode": _num(prev_ep),
        }
        if episode_statistics is not None:
            result["episode_statistics"] = episode_statistics
        return result


# ============================================================================
# URL CONSTRUCTION
# ============================================================================

def build_streaming_url(server_link: str, server_type_key: str) -> str:
    """Convert server IDs to full embed URLs based on server type"""
    
    if not server_link:
        return ''
    
    if server_link.startswith('http://') or server_link.startswith('https://'):
        return server_link
    
    url_patterns = {
        'OK': 'https://ok.ru/videoembed/',
        'MA': 'https://mega.nz/embed/',
        'FR': 'https://www.mediafire.com/file/',
        'GD': 'https://www.googleapis.com/drive/v3/files/{0}?key=AIzaSyBzyqZekacyx5t_MGh_A-8-iz2tEeIzqwE&alt=media'
    }
    
    for server_prefix, base_url in url_patterns.items():
        if server_prefix in server_type_key:
            if '{0}' in base_url:
                return base_url.format(server_link)
            else:
                return base_url + server_link
    
    return server_link


def extract_direct_mediafire_url(mediafire_url: str) -> Optional[str]:
    """Extract direct download link from MediaFire page (FrDownload method)"""
    try:
        headers = {
            'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.97 Safari/537.36'
        }
        response = requests.get(mediafire_url, headers=headers, timeout=10)
        response.raise_for_status()
        
        html_content = response.text
        match = re.search(r'(https://download[^"]+)', html_content)
        
        if match:
            return match.group(1)
        return None
    except Exception:
        return None


# ============================================================================
# DISPLAY FUNCTIONS
# ============================================================================

def print_anime_search_results(anime_results: List[Dict]) -> None:
    """Display formatted search results - fast display without MAL data"""
    
    if not anime_results:
        print(f"\n{Fore.RED}✗ No anime found{Style.RESET_ALL}")
        return
    
    print(f"\n{Fore.CYAN}{'=' * 100}{Style.RESET_ALL}")
    print(f"{Fore.YELLOW}📺 Found {len(anime_results)} anime{Style.RESET_ALL}")
    print(f"{Fore.CYAN}{'=' * 100}{Style.RESET_ALL}")
    
    for result_index, anime_data in enumerate(anime_results, 1):
        english_title = anime_data.get('EN_Title', 'Unknown')
        japanese_title = anime_data.get('JP_Title', '')
        anime_id = anime_data.get('AnimeId', 'N/A')
        anime_type = anime_data.get('Type', 'N/A')
        total_episodes = anime_data.get('Episodes', 'N/A')
        release_status = anime_data.get('Status', 'N/A')
        genre_list = anime_data.get('Genres', 'N/A')
        thumbnail = anime_data.get('Thumbnail', '')
        
        print(f"\n{Fore.GREEN}[{result_index}] {Fore.WHITE}{Style.BRIGHT}{english_title}{Style.RESET_ALL}")
        
        if japanese_title:
            print(f"    {Fore.MAGENTA}🇯🇵 {japanese_title}{Style.RESET_ALL}")
        
        print(f"    {Fore.CYAN}Type: {anime_type} | Episodes: {total_episodes} | Status: {release_status}{Style.RESET_ALL}")
        print(f"    {Fore.BLUE}Genres: {genre_list}{Style.RESET_ALL}")
        
        if thumbnail:
            thumbnail_url = THUMBNAILS_BASE_URL + thumbnail
            print(f"    {Fore.LIGHTBLACK_EX}🖼️  {thumbnail_url}{Style.RESET_ALL}")
        
        print(f"    {Fore.BLACK}{Style.BRIGHT}ID: {anime_id}{Style.RESET_ALL}")
        print(f"{Fore.CYAN}{'-' * 100}{Style.RESET_ALL}")


def print_anime_details_with_mal(anime_data: Dict) -> None:
    """Display detailed anime info including Animeify details, characters, and MAL ratings."""

    english_title = anime_data.get('EN_Title', 'Unknown')
    japanese_title = anime_data.get('JP_Title', '')
    anime_id = anime_data.get('AnimeId', '0')
    mal_id = anime_data.get('MalId', '0')

    print(f"\n{Fore.CYAN}{'=' * 100}{Style.RESET_ALL}")
    print(f"{Fore.YELLOW}{Style.BRIGHT}📺 {english_title}{Style.RESET_ALL}")
    if japanese_title:
        print(f"{Fore.MAGENTA}🇯🇵 {japanese_title}{Style.RESET_ALL}")
    print(f"{Fore.CYAN}{'=' * 100}{Style.RESET_ALL}")

    # Basic metadata
    meta_type = anime_data.get('Type', 'N/A')
    meta_eps = anime_data.get('Episodes', 'N/A')
    meta_status = anime_data.get('Status', 'N/A')
    meta_rating = anime_data.get('Rating', 'N/A')
    thumb = anime_data.get('Thumbnail')
    if thumb:
        print(f"{Fore.LIGHTBLACK_EX}🖼️  {THUMBNAILS_BASE_URL + thumb}{Style.RESET_ALL}")
    print(f"{Fore.CYAN}Type: {meta_type} | Episodes: {meta_eps} | Status: {meta_status} | Age Rating: {meta_rating}{Style.RESET_ALL}")

    # Animeify details (prefer v2)
    details = fetch_anime_details_v2(anime_id) or fetch_anime_details(anime_id) or {}
    # Also try Arabic-language details for Arabic description (try 'AR' then 'Arabic')
    details_ar = (
        fetch_anime_details_v2(anime_id, language="AR") or
        fetch_anime_details(anime_id, language="AR") or
        fetch_anime_details_v2(anime_id, language="Arabic") or
        fetch_anime_details(anime_id, language="Arabic") or
        {}
    )
    # Determine RelationId as early as possible (some endpoints require it)
    relation_id = (
        anime_data.get('RelationId') or
        (details.get('RelationId') if isinstance(details, dict) else None) or
        (details_ar.get('RelationId') if isinstance(details_ar, dict) else None) or
        ''
    )
    plot = details.get('Plot') or ''
    if not plot and mal_id and mal_id != "0":
        mal_fallback = fetch_myanimelist_data(mal_id) or {}
        plot = mal_fallback.get('synopsis') or ''
    if plot:
        # Keep description concise in interactive view
        short_plot = plot if len(plot) <= 600 else plot[:600].rstrip() + '…'
        print(f"\n{Fore.WHITE}{Style.BRIGHT}📝 Description{Style.RESET_ALL}")
        print(short_plot)
    # Arabic description if available
    ar_plot = details_ar.get('Plot') or ''
    if ar_plot:
        short_ar = ar_plot if len(ar_plot) <= 600 else ar_plot[:600].rstrip() + '…'
        print(f"\n{Fore.WHITE}{Style.BRIGHT}📝 الوصف (Arabic){Style.RESET_ALL}")
        print(short_ar)

    stats = details.get('AnimeStatistics') or {}
    if stats:
        views = stats.get('views')
        user_rate = stats.get('UserRate')
        if views or user_rate:
            print(f"\n{Fore.WHITE}{Style.BRIGHT}📊 Stats{Style.RESET_ALL}")
            if views:
                print(f"Views: {views}")
            if user_rate:
                print(f"Your Rate: {user_rate}")

    # Related anime (from details, fallback to dedicated endpoint via RelationId)
    related = details.get('RelatedAnime') or details_ar.get('RelatedAnime') or []
    if not related and relation_id:
        # Try English first (matches UI), then Arabic as fallback
        related = fetch_related_anime(relation_id, language="English") or fetch_related_anime(relation_id, language="AR") or fetch_related_anime(relation_id)
    if related:
        print(f"\n{Fore.WHITE}{Style.BRIGHT}🔗 Related Anime{Style.RESET_ALL}")
        for rel in related[:8]:
            en = rel.get('EN_Title') or rel.get('Title') or 'Unknown'
            ar = rel.get('AR_Title') or ''
            rel_type = rel.get('Type') or ''
            eps = rel.get('Episodes') or ''
            thumb = rel.get('Thumbnail')
            line = f"- {en}"
            if ar:
                line += f" | {ar}"
            if rel_type or eps:
                line += f"  [{rel_type}{' · ' if rel_type and eps else ''}{eps} eps]"
            print(line)
            if thumb:
                print(f"  🖼️  {THUMBNAILS_BASE_URL + thumb}")

    # Characters via RelationId (APK behavior)
    chars = fetch_related_characters_by_relation(relation_id) if relation_id else []
    if chars:
        print(f"\n{Fore.WHITE}{Style.BRIGHT}👥 Characters{Style.RESET_ALL}")
        for ch in chars[:10]:
            name = ch.get('Name') or ch.get('CharacterName') or ch.get('EN_Name') or ch.get('AR_Name') or 'Unknown'
            role = ch.get('Role') or ch.get('CharacterRole') or ''
            img = ch.get('Image') or ch.get('ImageUrl') or ch.get('Picture') or ''
            line = f"- {name}"
            if role:
                line += f" ({role})"
            print(line)
            if img:
                print(f"  🖼️  {img}")

    # MAL ratings
    if mal_id and mal_id != "0":
        print(f"\n{Fore.YELLOW}⏳ Fetching MyAnimeList ratings...{Style.RESET_ALL}")
        mal_data = fetch_myanimelist_data(mal_id)
        if mal_data:
            mal_score = mal_data.get('score', 'N/A')
            total_votes = mal_data.get('scored_by', 0)
            global_rank = mal_data.get('rank', 'N/A')
            popularity_rank = mal_data.get('popularity', 'N/A')
            favorite_count = mal_data.get('favorites', 0)
            print(f"{Fore.YELLOW}⭐ MAL Score: {mal_score}/10 ({total_votes:,} votes){Style.RESET_ALL}")
            print(f"{Fore.YELLOW}🏆 Rank: #{global_rank} | Popularity: #{popularity_rank} | Favorites: {favorite_count:,}{Style.RESET_ALL}")
    print(f"{Fore.CYAN}{'=' * 100}{Style.RESET_ALL}")


def print_episode_list(episode_data: List[Dict], anime_title: str) -> None:
    """Display available episodes for selected anime"""
    
    if not episode_data:
        print(f"\n{Fore.RED}✗ No episodes available{Style.RESET_ALL}")
        return
    
    print(f"\n{Fore.CYAN}{'=' * 100}{Style.RESET_ALL}")
    print(f"{Fore.YELLOW}📺 {anime_title}{Style.RESET_ALL}")
    print(f"{Fore.GREEN}Total Episodes: {len(episode_data)}{Style.RESET_ALL}")
    print(f"{Fore.CYAN}{'=' * 100}{Style.RESET_ALL}\n")
    
    for episode_info in episode_data:
        episode_num = episode_info.get('Episode', 'N/A')
        episode_type = episode_info.get('Type', 'Episode')
        try:
            episode_index = int(float(episode_num))
        except (ValueError, TypeError):
            episode_index = episode_num
        print(f"  {Fore.WHITE}[{episode_index}] Episode {episode_num} {Fore.BLACK}({episode_type}){Style.RESET_ALL}")
    
    print(f"\n{Fore.CYAN}{'=' * 100}{Style.RESET_ALL}")


def print_streaming_links(server_response: Dict, episode_number, anime_title: str) -> None:
    """Display all available streaming server links organized by quality with direct URLs"""
    
    if not server_response:
        print(f"\n{Fore.RED}✗ No streaming data available{Style.RESET_ALL}")
        return
    
    current_episode_data = server_response.get('CurrentEpisode', {})
    
    if not current_episode_data:
        print(f"\n{Fore.RED}✗ Episode data not found{Style.RESET_ALL}")
        return
    
    print(f"\n{Fore.CYAN}{'=' * 100}{Style.RESET_ALL}")
    print(f"{Fore.YELLOW}🎬 {anime_title} - Episode {episode_number}{Style.RESET_ALL}")
    print(f"{Fore.CYAN}{'=' * 100}{Style.RESET_ALL}")
    
    def print_server_with_direct(server_key: str, server_display_name: str, quality_label: str = "") -> None:
        """Print server link and attempt to extract direct download URL for MediaFire"""
        server_value = current_episode_data.get(server_key, '')
        if server_value:
            full_streaming_url = build_streaming_url(server_value, server_key)
            print(f"{server_display_name:30} {Fore.WHITE}→ {full_streaming_url}{Style.RESET_ALL}")
            
            if 'FR' in server_key and full_streaming_url.startswith('https://www.mediafire.com'):
                print(f"{'':30} {Fore.YELLOW}⏳ Extracting direct link...{Style.RESET_ALL}", end='\r')
                direct_url = extract_direct_mediafire_url(full_streaming_url)
                if direct_url:
                    print(f"{'':30} {Fore.GREEN}📥 Direct: {direct_url}{Style.RESET_ALL}")
                else:
                    print(f"{'':30} {Fore.RED}✗ Could not extract direct link{Style.RESET_ALL}")
    
    standard_quality_servers = [
        ('OKLink', f'{Fore.GREEN}🟢 OK.ru'),
        ('MALink', f'{Fore.BLUE}🔵 Mega.nz'),
        ('GDLink', f'{Fore.YELLOW}🟡 Google Drive'),
        ('LBLink', f'{Fore.MAGENTA}🟣 LibreBoot'),
        ('SVLink', f'{Fore.RED}🔴 StreamVid'),
        ('FRLink', f'{Fore.LIGHTRED_EX}🟠 MediaFire'),
        ('SFLink', f'{Fore.WHITE}⚪ StreamSB'),
        ('FDLink', f'{Fore.BLACK}{Style.BRIGHT}⚫ FileHost'),
    ]
    
    print(f"\n{Fore.CYAN}📺 STANDARD QUALITY (720p):{Style.RESET_ALL}")
    print(f"{Fore.CYAN}{'-' * 100}{Style.RESET_ALL}")
    
    for server_key, server_display_name in standard_quality_servers:
        print_server_with_direct(server_key, server_display_name, "720p")
    
    low_quality_servers = [
        ('LBLowQ', f'{Fore.MAGENTA}🟣 LibreBoot LowQ'),
        ('SVLowQ', f'{Fore.RED}🔴 StreamVid LowQ'),
        ('FRLowQ', f'{Fore.LIGHTRED_EX}🟠 MediaFire LowQ'),
    ]
    
    print(f"\n{Fore.CYAN}📱 LOW QUALITY (480p):{Style.RESET_ALL}")
    print(f"{Fore.CYAN}{'-' * 100}{Style.RESET_ALL}")
    
    for server_key, server_display_name in low_quality_servers:
        print_server_with_direct(server_key, server_display_name, "480p")
    
    hd_quality_servers = [
        ('LBFhdQ', f'{Fore.MAGENTA}🟣 LibreBoot FHD'),
        ('GDFhdQ', f'{Fore.YELLOW}🟡 Google Drive FHD'),
        ('FRFhdQ', f'{Fore.LIGHTRED_EX}🟠 MediaFire FHD'),
    ]
    
    print(f"\n{Fore.CYAN}🎞️  FULL HD (1080p):{Style.RESET_ALL}")
    print(f"{Fore.CYAN}{'-' * 100}{Style.RESET_ALL}")
    
    for server_key, server_display_name in hd_quality_servers:
        print_server_with_direct(server_key, server_display_name, "1080p")
    
    print(f"\n{Fore.CYAN}{'=' * 100}{Style.RESET_ALL}")
    
    next_episode_data = server_response.get('NextEpisode')
    previous_episode_data = server_response.get('PreviousEpisode')
    
    if next_episode_data:
        next_ep_num = next_episode_data.get('Episode', 'N/A')
        print(f"{Fore.GREEN}➡️  Next: Episode {next_ep_num}{Style.RESET_ALL}")
    
    if previous_episode_data:
        prev_ep_num = previous_episode_data.get('Episode', 'N/A')
        print(f"{Fore.YELLOW}⬅️  Previous: Episode {prev_ep_num}{Style.RESET_ALL}")
    
    print(f"{Fore.CYAN}{'=' * 100}{Style.RESET_ALL}")
    print(f"\n{Fore.GREEN}💡 Embed URLs ready to use in browser/player{Style.RESET_ALL}")
    print(f"{Fore.GREEN}📥 Direct URLs (MediaFire) are actual download/stream links{Style.RESET_ALL}")


# ============================================================================
# CLI LAYER
# ============================================================================

def _cli_search(client: AnimeifyClient, args: argparse.Namespace) -> None:
    results = client.search(args.query, args.type)
    if args.limit is not None:
        results = results[: max(0, args.limit)]
    shaped = [client.shape_search_result(r, enrich_with_mal=not args.no_mal) for r in results]
    print(json.dumps({"count": len(shaped), "results": shaped}, ensure_ascii=False, indent=2))


def _cli_anime(client: AnimeifyClient, args: argparse.Namespace) -> None:
    # Prefer official details endpoint using --id; fall back to search when needed
    raw: Optional[Dict[str, Any]] = None
    if args.id:
        # Try to get a minimal raw from a search round-trip to populate base fields
        probe = client.search(args.query or "", args.type) if args.query else client.search(args.id)
        for r in probe:
            if r.get("AnimeId") == args.id or (args.query and args.query.lower() in (r.get("EN_Title", "").lower())):
                raw = r
                break
        if raw is None and probe:
            raw = probe[0]
    elif args.query:
        probe = client.search(args.query, args.type)
        raw = probe[0] if probe else None

    if not raw:
        print(json.dumps({"error": "Anime not found. Provide --id or a matching --query."}, ensure_ascii=False))
        return

    detailed = client.anime_details(raw)
    # Add episodes list if requested
    if args.with_episodes:
        eps = client.episodes(detailed.get("id"))
        detailed["episodes_list"] = client.list_episodes(eps)
    print(json.dumps(detailed, ensure_ascii=False, indent=2))


def _cli_episodes(client: AnimeifyClient, args: argparse.Namespace) -> None:
    eps = client.episodes(args.id)
    print(json.dumps({
        "anime_id": args.id,
        "episodes": client.list_episodes(eps)
    }, ensure_ascii=False, indent=2))


def _cli_servers(client: AnimeifyClient, args: argparse.Namespace) -> None:
    # Accept float-like episode values (e.g., 12.5)
    try:
        ep_val: Any = float(args.episode)
    except ValueError:
        ep_val = args.episode
    payload = client.servers(args.id, ep_val, args.type)
    listing = client.list_servers(payload or {})
    print(json.dumps({
        "anime_id": args.id,
        **listing
    }, ensure_ascii=False, indent=2))


def _cli_config(client: AnimeifyClient, _: argparse.Namespace) -> None:
    print(json.dumps({
        "animeify_api_base": client.animeify_base,
        "thumbnails_base": client.thumbnails_base,
        "token_present": bool(client.token),
        "mal_api_base": client.mal_base,
    }, ensure_ascii=False, indent=2))


def _cli_apimap(_: AnimeifyClient, __: argparse.Namespace) -> None:
    """Show discovered API endpoints and their expected parameters (from DLLs)."""
    endpoints = [
        {
            "path": "anime/load_anime_list_v2.php",
            "method": "POST",
            "params": ["UserId", "Language", "FilterType", "FilterData", "Type", "From", "Token"],
            "returns": "List<AnimeModel>"
        },
        {
            "path": "episodes/load_episodes.php",
            "method": "POST",
            "params": ["AnimeID", "Token"],
            "returns": "List<EpisodeModel> (with optional EpisodeStatistics)"
        },
        {
            "path": "anime/load_servers.php",
            "method": "POST",
            "params": ["UserId", "AnimeId", "Episode", "AnimeType", "Token"],
            "returns": "CurrentEpisode + Next/Previous with links and EpisodeStatistics"
        },
        {
            "path": "anime/load_anime_details_v2.php",
            "method": "POST",
            "params": ["UserId", "Language", "AnimeId", "AnimeRelationId", "Token"],
            "returns": "AnimeDetails v2 (description/plot, statistics including views, related anime)",
            "note": "If not present on server, fallback to v1"
        },
        {
            "path": "anime/load_anime_details.php",
            "method": "POST",
            "params": ["UserId", "Language", "AnimeId", "AnimeRelationId", "Token"],
            "returns": "AnimeDetailsModel { Plot, AnimeStatistics, RelatedAnime }"
        },
        {
            "path": "anime/load_anime_details_glance.php",
            "method": "POST",
            "params": ["UserId", "AnimeId", "Token"],
            "returns": "Lightweight details (glance)"
        },
        {
            "path": "anime/load_related_anime.php",
            "method": "POST",
            "params": ["UserId", "RelationId", "Language", "Token"],
            "returns": "List<AnimeModel> of related entries"
        },
        {
            "path": "anime/rating/rate_set.php",
            "method": "POST",
            "params": ["UserId", "AnimeId", "Rate", "Type", "Episode", "Token"],
            "returns": "EpisodesStatistics or AnimeStatistics"
        },
        {
            "path": "anime/rating/rate_delete.php",
            "method": "POST",
            "params": ["UserId", "AnimeId", "Type", "Episode", "Token"],
            "returns": "EpisodesStatistics or AnimeStatistics"
        },
        {
            "path": "users/user_statistics.php",
            "method": "POST",
            "params": ["UserId", "Token"],
            "returns": "UserStatistics"
        },
        {
            "path": "characters/related_characters.php",
            "method": "POST",
            "params": ["UserId", "RelationId", "Token"],
            "returns": "Related characters for a relation group"
        }
    ]
    print(json.dumps({"apis_v4": endpoints}, ensure_ascii=False, indent=2))


# ============================================================================
# USER INPUT
# ============================================================================

def get_user_selection(input_prompt: str, maximum_value: int, allow_zero_option: bool = False) -> Optional[int]:
    """Get and validate numeric user input"""
    
    try:
        user_input = input(f"{Fore.CYAN}{input_prompt}{Style.RESET_ALL}").strip()
        
        if user_input.lower() in ['q', 'quit', 'exit']:
            return None
        
        numeric_choice = int(user_input)
        minimum_value = 0 if allow_zero_option else 1
        
        if minimum_value <= numeric_choice <= maximum_value:
            return numeric_choice
        else:
            print(f"{Fore.RED}✗ Enter a number between {minimum_value} and {maximum_value}{Style.RESET_ALL}")
            return -1
            
    except ValueError:
        print(f"{Fore.RED}✗ Invalid input - numbers only{Style.RESET_ALL}")
        return -1


# ============================================================================
# MAIN INTERACTIVE BROWSER
# ============================================================================

def run_interactive_browser():
    """Main application loop for browsing anime and episodes"""
    
    print(f"{Fore.CYAN}{'=' * 100}{Style.RESET_ALL}")
    print(f"{Fore.YELLOW}{Style.BRIGHT}🎬 ANIMEIFY BROWSER v1.0{Style.RESET_ALL}")
    print(f"{Fore.CYAN}{'=' * 100}{Style.RESET_ALL}")
    print(f"{Fore.GREEN}Interactive anime search with dual API (Animeify + MyAnimeList){Style.RESET_ALL}")
    print(f"{Fore.CYAN}{'=' * 100}{Style.RESET_ALL}\n")
    
    while True:
        search_input = input(f"\n{Fore.YELLOW}🔍 Search anime (or 'q' to quit): {Style.RESET_ALL}").strip()
        
        if search_input.lower() in ['q', 'quit', 'exit']:
            print(f"\n{Fore.GREEN}👋 Goodbye!{Style.RESET_ALL}")
            break
        
        if not search_input:
            print(f"{Fore.RED}✗ Please enter a search term{Style.RESET_ALL}")
            continue
        
        print(f"\n{Fore.YELLOW}⏳ Searching for '{search_input}'...{Style.RESET_ALL}")
        
        search_results = search_anime_titles(search_input)
        
        if not search_results:
            print(f"{Fore.RED}✗ No results - try different keywords{Style.RESET_ALL}")
            continue
        
        print_anime_search_results(search_results)
        
        while True:
            anime_selection = get_user_selection(
                f"\n📋 Select anime [1-{len(search_results)}] or 0 for new search: ",
                len(search_results),
                allow_zero_option=True
            )
            
            if anime_selection is None:
                print(f"\n{Fore.GREEN}👋 Goodbye!{Style.RESET_ALL}")
                return
            
            if anime_selection == 0:
                break
            
            if anime_selection == -1:
                continue
            
            selected_anime = search_results[anime_selection - 1]
            selected_anime_id = selected_anime.get('AnimeId')
            selected_anime_title = selected_anime.get('EN_Title', 'Unknown')
            selected_anime_type = selected_anime.get('Type', 'SERIES')
            
            print_anime_details_with_mal(selected_anime)
            
            print(f"\n{Fore.YELLOW}⏳ Loading episodes for '{selected_anime_title}'...{Style.RESET_ALL}")
            
            available_episodes = load_anime_episodes(selected_anime_id)
            
            if not available_episodes:
                print(f"{Fore.RED}✗ No episodes found{Style.RESET_ALL}")
                continue
            
            print_episode_list(available_episodes, selected_anime_title)
            
            while True:
                episode_selection = get_user_selection(
                    f"\n📺 Select episode [1-{len(available_episodes)}] or 0 to go back: ",
                    len(available_episodes),
                    allow_zero_option=True
                )
                
                if episode_selection is None:
                    print(f"\n{Fore.GREEN}👋 Goodbye!{Style.RESET_ALL}")
                    return
                
                if episode_selection == 0:
                    break
                
                if episode_selection == -1:
                    continue
                
                selected_episode = available_episodes[episode_selection - 1]
                episode_num_raw = selected_episode.get('Episode', str(episode_selection))
                
                try:
                    selected_episode_number = float(episode_num_raw)
                except (ValueError, TypeError):
                    selected_episode_number = episode_selection
                
                print(f"\n{Fore.YELLOW}⏳ Loading streaming servers for Episode {episode_num_raw}...{Style.RESET_ALL}")
                
                streaming_data = fetch_streaming_servers(
                    selected_anime_id,
                    selected_episode_number,
                    selected_anime_type
                )
                
                if not streaming_data:
                    print(f"{Fore.RED}✗ No streaming servers available{Style.RESET_ALL}")
                    continue
                
                print_streaming_links(streaming_data, selected_episode_number, selected_anime_title)
                
                print(f"\n{Fore.CYAN}{'=' * 100}{Style.RESET_ALL}")
                continue_prompt = input(
                    f"{Fore.CYAN}Press Enter for another episode, 'b' for different anime, 'q' to quit: {Style.RESET_ALL}"
                ).strip().lower()
                
                if continue_prompt == 'q':
                    print(f"\n{Fore.GREEN}👋 Goodbye!{Style.RESET_ALL}")
                    return
                elif continue_prompt == 'b':
                    break
            
            if episode_selection == 0:
                break


# ============================================================================
# ENTRY POINT
# ============================================================================

def main_cli(argv: Optional[List[str]] = None) -> int:
    parser = argparse.ArgumentParser(description="Animeify CLI/API Wrapper")
    sub = parser.add_subparsers(dest="cmd")

    # search
    p_search = sub.add_parser("search", help="Search anime")
    p_search.add_argument("--query", "-q", required=True, help="Search query")
    p_search.add_argument("--type", choices=["SERIES", "MOVIE"], default="SERIES")
    p_search.add_argument("--limit", type=int, default=None, help="Limit number of results")
    p_search.add_argument("--no-mal", action="store_true", help="Skip MAL enrichment for speed")
    p_search.set_defaults(func=_cli_search)

    # anime (details)
    p_anime = sub.add_parser("anime", help="Get detailed anime info")
    p_anime.add_argument("--id", help="Animeify AnimeId")
    p_anime.add_argument("--query", "-q", help="Fallback search query to locate anime by id/title")
    p_anime.add_argument("--type", choices=["SERIES", "MOVIE"], default="SERIES")
    p_anime.add_argument("--with-episodes", action="store_true", help="Also fetch episodes list")
    p_anime.set_defaults(func=_cli_anime)

    # episodes
    p_eps = sub.add_parser("episodes", help="List episodes for an anime id")
    p_eps.add_argument("--id", required=True, help="Animeify AnimeId")
    p_eps.set_defaults(func=_cli_episodes)

    # servers
    p_srv = sub.add_parser("servers", help="List servers/links for an episode")
    p_srv.add_argument("--id", required=True, help="Animeify AnimeId")
    p_srv.add_argument("--episode", "-e", required=True, help="Episode number (e.g., 1 or 12.5)")
    p_srv.add_argument("--type", choices=["SERIES", "MOVIE"], default="SERIES")
    p_srv.set_defaults(func=_cli_servers)

    # config
    p_cfg = sub.add_parser("config", help="Show API configuration info")
    p_cfg.set_defaults(func=_cli_config)

    # apimap
    p_map = sub.add_parser("apimap", help="List discovered endpoints and parameters")
    p_map.set_defaults(func=_cli_apimap)

    # interactive
    sub.add_parser("interactive", help="Run interactive TUI browser")

    args = parser.parse_args(argv)

    client = AnimeifyClient()

    if args.cmd is None:
        # Default to interactive mode when no subcommand provided
        run_interactive_browser()
        return 0

    if args.cmd == "interactive":
        run_interactive_browser()
        return 0

    # Dispatch to subcommand handler
    handler = getattr(args, "func", None)
    if not handler:
        parser.print_help()
        return 2
    handler(client, args)
    return 0


if __name__ == "__main__":
    try:
        raise SystemExit(main_cli())
    except KeyboardInterrupt:
        print(f"\n\n{Fore.YELLOW}👋 Interrupted - Goodbye!{Style.RESET_ALL}")
    except Exception as unexpected_error:
        print(f"\n{Fore.RED}✗ Unexpected error: {unexpected_error}{Style.RESET_ALL}")
