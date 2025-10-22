# WitAnime API Worker

Base Cloudflare Worker for the anime API.

## Deploy

```bash
cd worker
npx wrangler deploy
```

This will give you a URL like: `https://witanime-api-worker.YOUR-SUBDOMAIN.workers.dev`

## Endpoints

- `GET /` - API information
- `GET /health` - Health check

## Edit Later

Update `index.js` to add your anime API endpoints and logic.
