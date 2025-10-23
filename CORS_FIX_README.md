# CORS Fix Implementation

## Problem

When the Next.js app is deployed on Cloudflare Pages (https://animefy.pages.dev), it makes client-side fetch requests directly to https://animeify.net/animeify/apis_v4/. The animeify.net API does not include proper CORS headers that allow requests from animefy.pages.dev, resulting in the following error:

```
Access to fetch at 'https://animeify.net/animeify/apis_v4/anime/load_anime_list_v2.php' 
from origin 'https://animefy.pages.dev' has been blocked by CORS policy: 
No 'Access-Control-Allow-Origin' header is present on the requested resource.
```

## Solution

The app now uses a **Next.js API Route proxy** to handle API requests. This eliminates CORS issues because:

1. **Client-side**: The browser makes requests to `/api/animeify` (same origin, no CORS)
2. **Server-side**: The Next.js API route at `/api/animeify` forwards requests to animeify.net
3. **Response**: The API route adds proper CORS headers and returns data to the client

### Architecture

```
Browser → /api/animeify → https://animeify.net/animeify/apis_v4/
         (same origin)    (server-to-server, no CORS)
```

## Implementation Details

### Files Modified

1. **`src/app/api/animeify/route.ts`** (new)
   - Next.js API route handler that proxies requests
   - Accepts POST requests with `{ endpoint, params }`
   - Forwards to animeify.net with proper headers
   - Returns JSON with CORS headers

2. **`src/lib/animeify-api.ts`** (modified)
   - Detects if running on client or server
   - Client-side: Uses `/api/animeify` proxy
   - Server-side: Direct calls to animeify.net (for SSG/ISR)

### How It Works

#### Client-Side Request Flow

```javascript
// Browser calls browseAnime()
browseAnime({ type: 'SERIES', genre: 'Action' })

// ↓ Routes through proxy

fetch('/api/animeify', {
  method: 'POST',
  body: JSON.stringify({
    endpoint: 'anime/load_anime_list_v2.php',
    params: {
      UserId: '0',
      Language: 'English',
      FilterType: 'GENRE',
      FilterData: 'Action',
      Type: 'SERIES',
      From: '0',
      Token: '8cnY80AZSbUCmR26Vku1VUUY4'
    }
  })
})

// ↓ Server proxies to animeify.net

// ↓ Returns with CORS headers

// ✓ No CORS error!
```

## Alternative: Cloudflare Worker

If you prefer using the Cloudflare Worker instead (see `/worker` directory):

1. Deploy the worker:
   ```bash
   cd worker
   npx wrangler deploy
   ```

2. Update `.env.local`:
   ```
   NEXT_PUBLIC_WORKER_URL=https://witanime-api-worker.YOUR-SUBDOMAIN.workers.dev
   ```

3. Modify `src/lib/animeify-api.ts` to use worker URL if set

## Testing

### Development
```bash
npm run dev
# Visit http://localhost:3000/browse
# Check browser console - no CORS errors
```

### Production
When deployed to Cloudflare Pages, the proxy will work because:
- Client requests stay within the same domain
- Server-side Next.js can make requests to external APIs
- CORS headers are properly set on responses

## Benefits

✅ No CORS errors  
✅ Works on any deployment platform (Vercel, Cloudflare Pages, etc.)  
✅ No changes needed to existing API calls  
✅ Graceful fallback for server-side rendering  
✅ Maintains caching with `revalidate` settings  

## Notes

- The proxy route is only used for client-side requests
- Server-side rendering (SSG/ISR) still calls animeify.net directly
- Build-time errors about DNS are expected if animeify.net is unreachable during build
- Runtime client-side requests will work correctly when deployed
