#!/usr/bin/env python3
"""
Animeify Browser v1.0
Interactive anime search and streaming link browser
Reverse-engineered from Animeify v3.0.9 Android app
"""

import sys
import requests
import re
from typing import List, Dict, Optional
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
        api_response = requests.post(endpoint_url, data=request_payload, timeout=10)
        api_response.raise_for_status()
        return api_response.json()
    except requests.exceptions.RequestException as error:
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
        api_response = requests.post(endpoint_url, data=request_payload, timeout=10)
        api_response.raise_for_status()
        return api_response.json()
    except requests.exceptions.RequestException as error:
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
        api_response = requests.post(endpoint_url, data=request_payload, timeout=10)
        api_response.raise_for_status()
        return api_response.json()
    except requests.exceptions.RequestException as error:
        print(f"{Fore.RED}✗ Server loading failed: {error}{Style.RESET_ALL}")
        return None


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
    """Display detailed anime info with MAL ratings when user selects it"""
    
    english_title = anime_data.get('EN_Title', 'Unknown')
    japanese_title = anime_data.get('JP_Title', '')
    mal_id = anime_data.get('MalId', '0')
    
    print(f"\n{Fore.CYAN}{'=' * 100}{Style.RESET_ALL}")
    print(f"{Fore.YELLOW}{Style.BRIGHT}📺 {english_title}{Style.RESET_ALL}")
    if japanese_title:
        print(f"{Fore.MAGENTA}🇯🇵 {japanese_title}{Style.RESET_ALL}")
    print(f"{Fore.CYAN}{'=' * 100}{Style.RESET_ALL}")
    
    if mal_id and mal_id != "0":
        print(f"{Fore.YELLOW}⏳ Fetching MyAnimeList ratings...{Style.RESET_ALL}")
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

if __name__ == "__main__":
    try:
        run_interactive_browser()
    except KeyboardInterrupt:
        print(f"\n\n{Fore.YELLOW}👋 Interrupted - Goodbye!{Style.RESET_ALL}")
    except Exception as unexpected_error:
        print(f"\n{Fore.RED}✗ Unexpected error: {unexpected_error}{Style.RESET_ALL}")
