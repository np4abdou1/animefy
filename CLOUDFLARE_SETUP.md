# 🚀 Cloudflare Pages Setup Guide

## ✅ Code is Ready!

All fixes have been pushed to GitHub. The website is ready to deploy on Cloudflare Pages.

---

## 📋 Deployment Steps

### 1. Connect GitHub Repository

1. Go to [Cloudflare Dashboard](https://dash.cloudflare.com)
2. Navigate to **Workers & Pages**
3. Click **Create application** → **Pages** → **Connect to Git**
4. Select your repository: **np4abdou1/animefy**
5. Click **Begin setup**

### 2. Configure Build Settings

Set these exact values:

```
Project name: animefy-v2
Production branch: main
Build command: npx @cloudflare/next-on-pages@1
Build output directory: .vercel/output/static
Root directory: (leave empty)
```

### 3. Add Environment Variables (Optional)

No environment variables needed for basic setup.

### 4. **CRITICAL: Add KV Binding**

After the first deployment:

1. Go to your project: **animefy-v2**
2. Click **Settings** → **Functions**
3. Scroll to **KV namespace bindings**
4. Click **Add binding**
5. Configure:
   - **Variable name**: `KV_BINDING`
   - **KV namespace**: Select namespace with ID `430df556554942d99d22041f101e1f67`
6. Click **Save**
7. **Redeploy** the site (Settings → Deployments → Retry deployment)

---

## 🔧 What Was Fixed

### 1. **Response Format**
- Changed from `Response.json()` to `new Response(JSON.stringify())`
- Cloudflare Pages Functions require standard Response constructor

### 2. **Error Handling**
- Added KV binding check
- Added anime data validation
- Detailed error messages for debugging

### 3. **Complete Data Flow**
```
User clicks anime card
    ↓
POST /api/anime/store-url (Cloudflare Function)
    ↓
Store in KV: slug → full anime data
    ↓
Navigate to /anime/slug
    ↓
GET /api/anime/[slug] (Cloudflare Function)
    ↓
1. Fetch from KV
2. Search API by exact name
3. Get details & episodes
4. Return complete data
    ↓
Display anime page with all info
```

---

## 🧪 Testing After Deployment

### Test Store URL Endpoint
```bash
curl -X POST https://main.animefy-v2.pages.dev/api/anime/store-url \
  -H "Content-Type: application/json" \
  -d '{
    "AnimeId": "x123",
    "EN_Title": "Naruto",
    "AR_Title": "ناروتو",
    "Thumbnail": "naruto.jpg",
    "Type": "SERIES",
    "Episodes": 220,
    "Status": "AIRED"
  }'
```

**Expected Response:**
```json
{
  "success": true,
  "slug": "naruto",
  "url": "/anime/naruto"
}
```

### Test Fetch Anime Endpoint
```bash
curl https://main.animefy-v2.pages.dev/api/anime/naruto
```

**Expected Response:**
```json
{
  "success": true,
  "data": {
    "AnimeId": "x123",
    "EN_Title": "Naruto",
    "AR_Title": "ناروتو",
    "Plot": "...",
    "Episodes": [...],
    "related_anime": [...],
    ...
  }
}
```

---

## ⚠️ Common Issues

### Issue: "KV binding not configured"
**Solution**: Add KV_BINDING in Settings → Functions (see step 4 above)

### Issue: "Anime not found in KV"
**Solution**: The anime hasn't been clicked yet. Click an anime card first to store it.

### Issue: Build fails
**Solution**: 
- Check build command is exactly: `npx @cloudflare/next-on-pages@1`
- Check build output is: `.vercel/output/static`
- Make sure all dependencies are in package.json

### Issue: Pages show "Internal Server Error"
**Solution**:
1. Check build logs in Cloudflare Dashboard
2. Verify KV binding is added
3. Redeploy after adding KV binding

---

## 📊 Expected Build Output

```
✓ Compiled successfully
✓ Linting and checking validity of types
✓ Collecting page data
✓ Generating static pages
✓ Collecting build traces
✓ Finalizing page optimization

Route (app)                              Size     First Load JS
┌ ƒ /                                   4.55 kB        116 kB
├ ƒ /anime/[slug]                        161 B         106 kB
├ ƒ /api/anime/[id]                      136 B         102 kB
...

○  (Static)   prerendered as static content
ƒ  (Dynamic)  server-rendered on demand
```

---

## 🎯 Final Checklist

- [ ] Repository connected to Cloudflare Pages
- [ ] Build settings configured correctly
- [ ] First deployment successful
- [ ] KV binding added (KV_BINDING)
- [ ] Site redeployed after KV binding
- [ ] Test endpoints working
- [ ] Anime cards clickable
- [ ] Anime pages loading with full data

---

## 🌐 Your Live URLs

After deployment:
- **Production**: https://main.animefy-v2.pages.dev
- **Project Dashboard**: https://dash.cloudflare.com → animefy-v2

---

## 📝 Notes

- KV data expires after 30 days (configurable in store-url.ts)
- Each anime click stores ~2-5KB in KV
- Cloudflare Pages Functions have no cold start
- Edge runtime ensures fast global performance

**Your website is ready to go live! 🎉**
