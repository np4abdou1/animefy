// WitAnime API Worker - Proxies and aggregates Animeify API data
// Based on reverse-engineered Animeify v3.0.9 Android app

const ANIMEIFY_API_BASE = "https://animeify.net/animeify/apis_v4/";
const ANIMEIFY_TOKEN = "8cnY80AZSbUCmR26Vku1VUUY4";
const THUMBNAILS_BASE_URL = "https://animeify.net/animeify/files/thumbnails/";

// Helper to make requests to Animeify API
async function animeifyRequest(endpoint, params) {
  const url = ANIMEIFY_API_BASE + endpoint;
  
  // Build form data as URL-encoded string
  const formBody = Object.keys(params)
    .map(key => encodeURIComponent(key) + '=' + encodeURIComponent(params[key]))
    .join('&');
  
  const response = await fetch(url, {
    method: 'POST',
    headers: {
      'Content-Type': 'application/x-www-form-urlencoded',
    },
    body: formBody
  });
  
  if (!response.ok) {
    throw new Error(`API request failed: ${response.status}`);
  }
  
  return await response.json();
}

// Get current day of week in format API expects
function getCurrentDayOfWeek() {
  const days = ['SUNDAY', 'MONDAY', 'TUESDAY', 'WEDNESDAY', 'THURSDAY', 'FRIDAY', 'SATURDAY'];
  return days[new Date().getDay()];
}

// Get current season
function getCurrentSeason() {
  const month = new Date().getMonth() + 1;
  const year = new Date().getFullYear();
  
  if (month >= 1 && month <= 3) return `WINTER ${year}`;
  if (month >= 4 && month <= 6) return `SPRING ${year}`;
  if (month >= 7 && month <= 9) return `SUMMER ${year}`;
  return `FALL ${year}`;
}

export default {
  async fetch(request, env, ctx) {
    const url = new URL(request.url);
    
    // CORS headers
    const corsHeaders = {
      'Access-Control-Allow-Origin': '*',
      'Access-Control-Allow-Methods': 'GET, POST, OPTIONS',
      'Access-Control-Allow-Headers': 'Content-Type',
      'Content-Type': 'application/json',
    };

    // Handle CORS preflight
    if (request.method === 'OPTIONS') {
      return new Response(null, { headers: corsHeaders });
    }

    try {
      // Root endpoint
      if (url.pathname === '/') {
        return new Response(
          JSON.stringify({
            status: 'success',
            message: 'WitAnime API Worker',
            version: '1.0.0',
            endpoints: {
              health: '/health',
              homeContent: '/api/home_content',
              latestEpisodes: '/api/latest_episodes',
              search: '/api/search',
              browse: '/api/browse',
              animeDetails: '/api/anime/:id',
              animeEpisodes: '/api/anime/:id/episodes',
              streamingServers: '/api/anime/:id/watch/:episode',
              genres: '/api/genres',
              studios: '/api/studios',
            }
          }),
          { headers: corsHeaders }
        );
      }

      // Health check
      if (url.pathname === '/health') {
        return new Response(
          JSON.stringify({
            status: 'healthy',
            timestamp: new Date().toISOString()
          }),
          { headers: corsHeaders }
        );
      }

      // Main home content endpoint - aggregates all home screen data
      if (url.pathname === '/api/home_content') {
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
          return new Response(
            JSON.stringify({
              status: 'success',
              data: {
                // اخر التحديثات - Latest Episodes
                latestEpisodes: homeData.LatestEpisodes || [],
                
                // يعرض اليوم - Airing Today (current day)
                airingToday: homeData.Broadcast || [],
                
                // العرض الأول - Premiered this season
                premieredAnime: homeData.Premiere || [],
                
                // الأخبار - Latest News
                latestNews: homeData.LatestNews || [],
                
                // Trending/Popular slider
                trending: trendingData || [],
                
                // Updates chart (for badges/notifications)
                updatesChart: homeData.UpdatesChart || null,
                
                // Metadata
                currentDay: getCurrentDayOfWeek(),
                currentSeason: getCurrentSeason(),
                timestamp: new Date().toISOString()
              }
            }),
            { headers: corsHeaders }
          );
        } catch (error) {
          return new Response(
            JSON.stringify({
              status: 'error',
              message: 'Failed to fetch home content',
              error: error.message
            }),
            { 
              status: 500,
              headers: corsHeaders 
            }
          );
        }
      }

      // Latest episodes endpoint (standalone)
      if (url.pathname === '/api/latest_episodes') {
        try {
          const from = url.searchParams.get('from') || '0';
          
          const data = await animeifyRequest('episodes/load_latest_episodes.php', {
            UserId: '0',
            Language: 'English',
            From: from,
            Token: ANIMEIFY_TOKEN
          });

          return new Response(
            JSON.stringify({
              status: 'success',
              data: data
            }),
            { headers: corsHeaders }
          );
        } catch (error) {
          return new Response(
            JSON.stringify({
              status: 'error',
              message: 'Failed to fetch latest episodes',
              error: error.message
            }),
            { 
              status: 500,
              headers: corsHeaders 
            }
          );
        }
      }

      // Search endpoint
      if (url.pathname === '/api/search') {
        try {
          const query = url.searchParams.get('q') || '';
          const type = url.searchParams.get('type') || 'SERIES';
          const from = url.searchParams.get('from') || '0';
          
          if (!query) {
            return new Response(
              JSON.stringify({
                status: 'error',
                message: 'Search query is required'
              }),
              { 
                status: 400,
                headers: corsHeaders 
              }
            );
          }

          const data = await animeifyRequest('anime/load_anime_list_v2.php', {
            UserId: '0',
            Language: 'English',
            FilterType: 'SEARCH',
            FilterData: query,
            Type: type,
            From: from,
            Token: ANIMEIFY_TOKEN
          });

          return new Response(
            JSON.stringify({
              status: 'success',
              data: data,
              pagination: {
                from: from,
                hasMore: data && data.length >= 20
              }
            }),
            { headers: corsHeaders }
          );
        } catch (error) {
          return new Response(
            JSON.stringify({
              status: 'error',
              message: 'Search failed',
              error: error.message
            }),
            { 
              status: 500,
              headers: corsHeaders 
            }
          );
        }
      }

      // Browse/Explore endpoint - list all anime with filters
      if (url.pathname === '/api/browse') {
        try {
          const type = url.searchParams.get('type') || ''; // SERIES, MOVIE, OVA, SPECIAL
          const genre = url.searchParams.get('genre') || '';
          const studio = url.searchParams.get('studio') || '';
          const status = url.searchParams.get('status') || ''; // AIRING, AIRED, UPCOMING
          const season = url.searchParams.get('season') || '';
          const sortBy = url.searchParams.get('sortBy') || ''; // LATEST, POPULAR, RATING, NAME
          const from = url.searchParams.get('from') || '0';
          
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
              filterData = 'HIGHEST_RATE';  // Fixed: Use HIGHEST_RATE not SCORE
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
            From: from,
            Token: ANIMEIFY_TOKEN
          });

          return new Response(
            JSON.stringify({
              status: 'success',
              data: data,
              filters: {
                type,
                genre,
                studio,
                status,
                season,
                sortBy
              },
              pagination: {
                from: from,
                hasMore: data && data.length >= 20
              }
            }),
            { headers: corsHeaders }
          );
        } catch (error) {
          return new Response(
            JSON.stringify({
              status: 'error',
              message: 'Browse failed',
              error: error.message
            }),
            { 
              status: 500,
              headers: corsHeaders 
            }
          );
        }
      }

      // Get anime details by ID (complete with episodes, characters, and related)
      if (url.pathname.match(/^\/api\/anime\/[^\/]+$/)) {
        try {
          const animeId = url.pathname.split('/').pop();
          
          // Fetch all data in parallel to minimize requests
          const [animeDetails, episodes, characters, relatedAnime] = await Promise.all([
            animeifyRequest('anime/load_anime_details.php', {
              UserId: '0',
              AnimeId: animeId,
              Token: ANIMEIFY_TOKEN
            }),
            animeifyRequest('episodes/load_episodes.php', {
              AnimeID: animeId,
              Token: ANIMEIFY_TOKEN
            }).catch(() => []),
            animeifyRequest('characters/characters_list.php', {
              AnimeId: animeId,
              Token: ANIMEIFY_TOKEN
            }).catch(() => []),
            animeifyRequest('anime/load_related_anime.php', {
              AnimeId: animeId,
              Token: ANIMEIFY_TOKEN
            }).catch(() => [])
          ]);

          return new Response(
            JSON.stringify({
              status: 'success',
              data: {
                anime: animeDetails,
                episodes: episodes || [],
                characters: characters || [],
                related: relatedAnime || []
              }
            }),
            { headers: corsHeaders }
          );
        } catch (error) {
          return new Response(
            JSON.stringify({
              status: 'error',
              message: 'Failed to fetch anime details',
              error: error.message
            }),
            { 
              status: 500,
              headers: corsHeaders 
            }
          );
        }
      }

      // Get streaming servers for a specific episode
      if (url.pathname.match(/^\/api\/anime\/[^\/]+\/watch\/[^\/]+$/)) {
        try {
          const pathParts = url.pathname.split('/');
          const animeId = pathParts[3];
          const episode = pathParts[5];
          const animeType = url.searchParams.get('type') || 'SERIES';
          
          const data = await animeifyRequest('anime/load_servers.php', {
            UserId: '0',
            AnimeId: animeId,
            Episode: episode,
            AnimeType: animeType,
            Token: ANIMEIFY_TOKEN
          });

          return new Response(
            JSON.stringify({
              status: 'success',
              data: data
            }),
            { headers: corsHeaders }
          );
        } catch (error) {
          return new Response(
            JSON.stringify({
              status: 'error',
              message: 'Failed to fetch streaming servers',
              error: error.message
            }),
            { 
              status: 500,
              headers: corsHeaders 
            }
          );
        }
      }

      // Get anime episodes by ID
      if (url.pathname.match(/^\/api\/anime\/[^\/]+\/episodes$/)) {
        try {
          const pathParts = url.pathname.split('/');
          const animeId = pathParts[pathParts.length - 2];
          
          const data = await animeifyRequest('episodes/load_episodes.php', {
            AnimeID: animeId,
            Token: ANIMEIFY_TOKEN
          });

          return new Response(
            JSON.stringify({
              status: 'success',
              data: data
            }),
            { headers: corsHeaders }
          );
        } catch (error) {
          return new Response(
            JSON.stringify({
              status: 'error',
              message: 'Failed to fetch episodes',
              error: error.message
            }),
            { 
              status: 500,
              headers: corsHeaders 
            }
          );
        }
      }

      // Get available genres
      if (url.pathname === '/api/genres') {
        return new Response(
          JSON.stringify({
            status: 'success',
            data: [
              'Action', 'Adventure', 'Comedy', 'Drama', 'Fantasy', 'Horror',
              'Mystery', 'Psychological', 'Romance', 'Sci-Fi', 'Slice of Life',
              'Sports', 'Supernatural', 'Thriller', 'Mecha', 'Historical',
              'School', 'Military', 'Shounen', 'Shoujo', 'Seinen', 'Josei'
            ]
          }),
          { headers: corsHeaders }
        );
      }

      // Get available studios (common ones)
      if (url.pathname === '/api/studios') {
        return new Response(
          JSON.stringify({
            status: 'success',
            data: [
              'Studio Ghibli', 'Toei Animation', 'Madhouse', 'Bones', 'A-1 Pictures',
              'Production I.G', 'Wit Studio', 'Ufotable', 'Kyoto Animation', 'Shaft',
              'J.C.Staff', 'Sunrise', 'Studio Pierrot', 'Trigger', 'MAPPA',
              'Cloverworks', 'David Production', 'White Fox', 'P.A. Works', 'Brain\'s Base'
            ]
          }),
          { headers: corsHeaders }
        );
      }

      // Schedule endpoint - Get airing anime by day and seasons
      if (url.pathname === '/api/schedule') {
        try {
          const days = ['SUNDAY', 'MONDAY', 'TUESDAY', 'WEDNESDAY', 'THURSDAY', 'FRIDAY', 'SATURDAY'];
          const schedule = {};
          
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

          return new Response(
            JSON.stringify({
              status: 'success',
              data: {
                schedule,
                seasons: sortedSeasons
              }
            }),
            { headers: corsHeaders }
          );
        } catch (error) {
          return new Response(
            JSON.stringify({
              status: 'error',
              message: 'Failed to fetch schedule',
              error: error.message
            }),
            { 
              status: 500,
              headers: corsHeaders 
            }
          );
        }
      }

      // 404 for unknown routes
      return new Response(
        JSON.stringify({
          status: 'error',
          message: 'Endpoint not found'
        }),
        { 
          status: 404,
          headers: corsHeaders 
        }
      );

    } catch (error) {
      return new Response(
        JSON.stringify({
          status: 'error',
          message: 'Internal server error',
          error: error.message
        }),
        { 
          status: 500,
          headers: corsHeaders 
        }
      );
    }
  },
};
