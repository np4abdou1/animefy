// Animeify API Client - Direct API calls to Animeify.net
// Based on API documentation from API_DOCUMENTATION.md

const ANIMEIFY_API_BASE = process.env.NEXT_PUBLIC_API_BASE_URL || "https://animeify.net/animeify/apis_v4/";
const ANIMEIFY_TOKEN = process.env.NEXT_PUBLIC_API_TOKEN || "8cnY80AZSbUCmR26Vku1VUUY4";

// Helper to make POST requests to Animeify API
async function animeifyRequest(endpoint: string, params: Record<string, string>) {
  const url = ANIMEIFY_API_BASE + endpoint;
  
  // Build form data as URL-encoded string
  const formBody = Object.keys(params)
    .map(key => encodeURIComponent(key) + '=' + encodeURIComponent(params[key]))
    .join('&');
  
  try {
    const response = await fetch(url, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/x-www-form-urlencoded',
      },
      body: formBody,
      // Add Next.js caching configuration
      next: { revalidate: 300 }, // Cache for 5 minutes
    });
    
    if (!response.ok) {
      throw new Error(`API request failed: ${response.status} ${response.statusText}`);
    }
    
    return await response.json();
  } catch (error) {
    console.error(`Failed to fetch from ${url}:`, error);
    throw error;
  }
}

// Get current day of week in format API expects
function getCurrentDayOfWeek(): string {
  const days = ['SUNDAY', 'MONDAY', 'TUESDAY', 'WEDNESDAY', 'THURSDAY', 'FRIDAY', 'SATURDAY'];
  return days[new Date().getDay()];
}

// Get current season
function getCurrentSeason(): string {
  const month = new Date().getMonth() + 1;
  const year = new Date().getFullYear();
  
  if (month >= 1 && month <= 3) return `WINTER ${year}`;
  if (month >= 4 && month <= 6) return `SPRING ${year}`;
  if (month >= 7 && month <= 9) return `SUMMER ${year}`;
  return `FALL ${year}`;
}

// Home content endpoint - aggregates all home screen data
export async function getHomeContent() {
  try {
    // Fetch main home data (includes latest episodes, airing today, premiered anime, news)
    const homeData = await animeifyRequest('home/load_home.php', {
      UserId: '0',
      Language: 'English',
      Broadcast: getCurrentDayOfWeek(),
      Premiered: getCurrentSeason(),
      Token: ANIMEIFY_TOKEN
    });

    // Fetch trending/popular anime slider
    const trendingData = await animeifyRequest('home/load_trending.php', {
      UserId: '0',
      Language: 'English',
      Token: ANIMEIFY_TOKEN
    });

    // Return aggregated data
    return {
      latestEpisodes: homeData.LatestEpisodes || [],
      airingToday: homeData.Broadcast || [],
      premieredAnime: homeData.Premiere || [],
      latestNews: homeData.LatestNews || [],
      trending: trendingData || [],
      updatesChart: homeData.UpdatesChart || null,
      currentDay: getCurrentDayOfWeek(),
      currentSeason: getCurrentSeason(),
    };
  } catch (error) {
    console.error('Failed to fetch home content:', error);
    return {
      latestEpisodes: [],
      airingToday: [],
      premieredAnime: [],
      latestNews: [],
      trending: [],
      updatesChart: null,
      currentDay: getCurrentDayOfWeek(),
      currentSeason: getCurrentSeason(),
    };
  }
}

// Latest episodes endpoint
export async function getLatestEpisodes(from: number = 0) {
  try {
    const data = await animeifyRequest('episodes/load_latest_episodes.php', {
      UserId: '0',
      Language: 'English',
      From: from.toString(),
      Token: ANIMEIFY_TOKEN
    });

    return data || [];
  } catch (error) {
    console.error('Failed to fetch latest episodes:', error);
    return [];
  }
}

// Search anime
export async function searchAnime(query: string, type: string = '', from: number = 0) {
  try {
    if (!query.trim()) {
      return [];
    }

    const data = await animeifyRequest('anime/load_anime_list_v2.php', {
      UserId: '0',
      Language: 'English',
      FilterType: 'SEARCH',
      FilterData: query,
      Type: type,
      From: from.toString(),
      Token: ANIMEIFY_TOKEN
    });

    return data || [];
  } catch (error) {
    console.error('Search failed:', error);
    return [];
  }
}

// Browse anime with filters
export async function browseAnime(options: {
  type?: string;
  genre?: string;
  studio?: string;
  status?: string;
  season?: string;
  sortBy?: string;
  from?: number;
}) {
  try {
    const { type = '', genre = '', studio = '', status = '', season = '', sortBy = '', from = 0 } = options;
    
    // Determine filter type based on parameters (priority order)
    let filterType = '';
    let filterData = '';
    
    // Priority: genre > studio > season > status > sort
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
      // Sort filters
      if (sortBy === 'POPULAR') {
        // Don't send FilterType for popular - API returns by popularity by default
        filterType = '';
        filterData = '';
      } else if (sortBy === 'RATING') {
        filterType = 'SORT';
        filterData = 'HIGHEST_RATE';
      } else if (sortBy === 'NAME') {
        filterType = 'SORT';
        filterData = 'NAME';
      } else if (sortBy === 'LATEST') {
        filterType = 'SORT';
        filterData = 'PREMIERED_DEC';
      } else if (sortBy === 'EPISODES') {
        filterType = 'SORT';
        filterData = 'EPISODES_DEC';
      }
    }

    const data = await animeifyRequest('anime/load_anime_list_v2.php', {
      UserId: '0',
      Language: 'English',
      FilterType: filterType,
      FilterData: filterData,
      Type: type,
      From: from.toString(),
      Token: ANIMEIFY_TOKEN
    });

    return data || [];
  } catch (error) {
    console.error('Browse failed:', error);
    return [];
  }
}

// Get anime details
export async function getAnimeDetails(animeId: string) {
  try {
    const data = await animeifyRequest('anime/load_anime_details.php', {
      UserId: '0',
      AnimeId: animeId,
      Token: ANIMEIFY_TOKEN
    });

    return data;
  } catch (error) {
    console.error('Failed to fetch anime details:', error);
    return null;
  }
}

// Get anime episodes
export async function getAnimeEpisodes(animeId: string) {
  try {
    const data = await animeifyRequest('episodes/load_episodes.php', {
      AnimeID: animeId,
      Token: ANIMEIFY_TOKEN
    });

    return data || [];
  } catch (error) {
    console.error('Failed to fetch episodes:', error);
    return [];
  }
}

// Get schedule for all days and seasons
export async function getSchedule() {
  try {
    const days = ['SUNDAY', 'MONDAY', 'TUESDAY', 'WEDNESDAY', 'THURSDAY', 'FRIDAY', 'SATURDAY'];
    const schedule: Record<string, any[]> = {};
    
    // Fetch airing anime for each day
    const dayPromises = days.map(async (day) => {
      const data = await animeifyRequest('home/load_home.php', {
        UserId: '0',
        Language: 'English',
        Broadcast: day,
        Premiered: getCurrentSeason(),
        Token: ANIMEIFY_TOKEN
      });
      return { day, animes: data.Broadcast || [] };
    });
    
    const dayResults = await Promise.all(dayPromises);
    dayResults.forEach(({ day, animes }) => {
      schedule[day] = animes;
    });

    // Fetch seasons (current and recent)
    const currentYear = new Date().getFullYear();
    const seasons = ['WINTER', 'SPRING', 'SUMMER', 'FALL'];
    const seasonPromises = [];
    
    // Get current and past 2 seasons
    for (let yearOffset = 0; yearOffset < 2; yearOffset++) {
      for (const season of seasons) {
        const seasonYear = currentYear - yearOffset;
        const seasonName = `${season} ${seasonYear}`;
        
        seasonPromises.push(
          animeifyRequest('anime/load_anime_list_v2.php', {
            UserId: '0',
            Language: 'English',
            FilterType: 'PREMIERED',
            FilterData: seasonName,
            Type: '',
            From: '0',
            Token: ANIMEIFY_TOKEN
          }).then(animes => ({ season: seasonName, animes: animes || [] }))
        );
      }
    }
    
    const seasonResults = await Promise.all(seasonPromises);
    // Sort seasons by recency
    const sortedSeasons = seasonResults.sort((a, b) => {
      const yearA = parseInt(a.season.split(' ')[1]);
      const yearB = parseInt(b.season.split(' ')[1]);
      if (yearA !== yearB) return yearB - yearA;
      return seasons.indexOf(b.season.split(' ')[0]) - seasons.indexOf(a.season.split(' ')[0]);
    });

    return {
      schedule,
      seasons: sortedSeasons
    };
  } catch (error) {
    console.error('Failed to fetch schedule:', error);
    return {
      schedule: {},
      seasons: []
    };
  }
}
