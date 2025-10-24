# Animefy Deployment Guide

## ✅ Completed Steps

1. **Fixed KV Binding Configuration**
   - Updated `wrangler.toml` to use `KV_BINDING` with ID: `430df556554942d99d22041f101e1f67`
   - Updated all functions to use the correct binding name

2. **Installed Dependencies**
   - Added `@cloudflare/next-on-pages`, `@cloudflare/workers-types`, `wrangler`, and `vercel`
   - Downgraded Next.js to 15.5.2 for compatibility

3. **Built and Deployed**
   - Successfully deployed to: **https://fcfba150.animefy-v2.pages.dev**
   - Deployment alias: **https://main.animefy-v2.pages.dev**

## ⚠️ Current Issue

The API endpoints are returning the fallback HTML instead of functioning properly. This is because:

1. **Next.js API routes** (`src/app/api/*`) are not being served - they require the full Next.js runtime
2. **Cloudflare Pages Functions** (`functions/api/*`) are deployed but need KV binding configuration

## 🔧 Required Action: Configure KV Binding

The KV namespace binding needs to be added to the Cloudflare Pages project via the dashboard:

### Steps:

1. Go to [Cloudflare Dashboard](https://dash.cloudflare.com)
2. Navigate to **Workers & Pages** → **animefy-v2**
3. Go to **Settings** → **Functions**
4. Scroll to **KV namespace bindings**
5. Click **Add binding**
6. Configure:
   - **Variable name**: `KV_BINDING`
   - **KV namespace**: Select the namespace with ID `430df556554942d99d22041f101e1f67` (ANIME_URL)
7. Click **Save**

### Alternative: Use Wrangler (if supported in future)

```bash
# This command may not work for Pages projects yet
npx wrangler pages project create animefy-v2 --production-branch=main
```

## 📁 Project Structure

```
animefy/
├── functions/              # Cloudflare Pages Functions (Edge)
│   ├── api/
│   │   └── anime/
│   │       ├── [slug].ts   # Get anime by slug from KV
│   │       └── store-url.ts # Store anime URL in KV
│   └── types.d.ts
├── src/app/               # Next.js App (requires full runtime)
│   ├── api/               # Next.js API routes
│   └── ...
├── public/                # Static assets
├── out/                   # Deployment directory
└── wrangler.toml          # Cloudflare configuration
```

## 🚀 Deployment Commands

### Deploy to Cloudflare Pages
```bash
# Build and deploy
npm run build
npm run pages:deploy

# Or deploy directly
npx wrangler pages deploy out --project-name=animefy-v2 --commit-dirty=true
```

### Check Deployment Status
```bash
npx wrangler pages deployment list --project-name=animefy-v2
```

## 🔍 Testing After KV Binding

Once the KV binding is configured, test these endpoints:

1. **Store anime URL**:
   ```bash
   curl -X POST https://main.animefy-v2.pages.dev/api/anime/store-url \
     -H "Content-Type: application/json" \
     -d '{"AnimeId":"x123","EN_Title":"Test Anime","Thumbnail":"https://example.com/img.jpg","Type":"SERIES","Episodes":12,"Status":"Airing"}'
   ```

2. **Get anime by slug**:
   ```bash
   curl https://main.animefy-v2.pages.dev/api/anime/test-anime
   ```

## 📝 Notes

- **Next.js API routes** in `src/app/api/*` won't work on Cloudflare Pages without additional configuration
- **Cloudflare Pages Functions** in `functions/*` will work once KV binding is configured
- The current deployment serves static assets and a fallback HTML page
- For full Next.js SSR support, consider using Cloudflare Workers or a different hosting platform

## 🎯 Next Steps

1. Add KV binding via Cloudflare Dashboard (see above)
2. Test the Functions API endpoints
3. Consider migrating Next.js API routes to Cloudflare Pages Functions for full compatibility
4. Update the frontend to use the Functions API endpoints

## 📊 Deployment Info

- **Project Name**: animefy-v2
- **Latest Deployment**: https://fcfba150.animefy-v2.pages.dev
- **Production URL**: https://main.animefy-v2.pages.dev
- **KV Namespace ID**: 430df556554942d99d22041f101e1f67
- **KV Binding Name**: KV_BINDING
