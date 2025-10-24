# 🎯 Anime Details API - Complete Analysis

## ✅ SOLUTION FOUND

### The Working Endpoint

**Endpoint:** `https://animeify.net/animeify/apis_v4/anime/load_anime_details.php`

**Method:** POST

**Critical Discovery:** The `AnimeId` parameter expects a **SLUG (string identifier)**, NOT a numeric ID!

---

## 📋 Request Format

### Headers
```
Content-Type: application/x-www-form-urlencoded
Accept: application/json, text/plain, */*
User-Agent: AnimeifyBrowser/1.0 (+python-requests)
X-Requested-With: XMLHttpRequest
```

### POST Parameters
```
UserId=0
Language=EN
AnimeId=xNarutoShippuuden    ← THIS IS A SLUG, NOT A NUMBER!
AnimeRelationId=
Token=8cnY80AZSbUCmR26Vku1VUUY4
```

---

## 🔍 How the Android App Works

### 1. When User Clicks an Anime

From `HomeFragment.cs` (line 574-603), the app passes **ALL anime data** to the details screen:

```csharp
Intent intent = new Intent(Application.Context, typeof(AnimeDetails));
intent.PutExtra("AnimeId", anime.AnimeId);           // ← SLUG like "xNarutoShippuuden"
intent.PutExtra("ENTitle", anime.EN_Title);
intent.PutExtra("JPTitle", anime.JP_Title);
intent.PutExtra("ARTitle", anime.AR_Title);
intent.PutExtra("Synonyms", anime.Synonyms);
intent.PutExtra("Tags", anime.Tags);
intent.PutExtra("Genres", anime.Genres);
intent.PutExtra("Season", anime.Season);
intent.PutExtra("Duration", anime.Duration);
intent.PutExtra("Premiered", anime.Premiered);
intent.PutExtra("Aired", anime.Aired);
intent.PutExtra("Broadcast", anime.Broadcast);
intent.PutExtra("Thumbnail", Constants.Thumbnails(anime.Thumbnail));
intent.PutExtra("Trailer", anime.Trailer);
intent.PutExtra("YTTrailer", anime.YTTrailer);
intent.PutExtra("Creators", anime.Creators);
intent.PutExtra("Status", anime.Status);
intent.PutExtra("Episodes", anime.Episodes);
intent.PutExtra("Score", anime.Score);
intent.PutExtra("Rank", anime.Rank);
intent.PutExtra("Popularity", anime.Popularity);
intent.PutExtra("Rating", anime.Rating);
intent.PutExtra("RelationId", anime.RelationId);
intent.PutExtra("MalId", anime.MalId);
intent.PutExtra("Type", anime.Type);
```

### 2. The Details Screen Displays This Data Immediately

From `AnimeDetails.cs` (line 74-99), the screen shows the passed data:

```csharp
this.animeId = this.Intent.GetStringExtra("AnimeId");
this.enTitle = this.Intent.GetStringExtra("ENTitle");
this.jpTitle = this.Intent.GetStringExtra("JPTitle");
// ... etc
```

### 3. Then Loads Additional Details in Background

From `AnimeDetails.cs` (line 747-832), it calls the API:

```csharp
private void LoadAnimeDetails()
{
    WebClient webClient = new WebClient();
    System.Uri address = new System.Uri(Constants.ApiPhp("anime/load_anime_details.php"));
    webClient.UploadValuesAsync(address, new NameValueCollection
    {
        { "UserId", this.userId.ToString() },
        { "Language", this.Resources.GetString(2131951706) },
        { "AnimeId", this.animeId },                    // ← Uses the SLUG
        { "AnimeRelationId", this.relationId },
        { "Token", "8cnY80AZSbUCmR26Vku1VUUY4" }
    });
}
```

**What the API Returns:**
- `Plot` - Full anime description
- `AnimeStatistics` - Ratings, favorites, library stats, views
- `Library` - User's personal library status
- `RelatedAnime` - Array of related anime

---

## 🧪 Test Results

### ✅ Working Examples

**Test 1: Naruto Shippuden**
```bash
curl -X POST "https://animeify.net/animeify/apis_v4/anime/load_anime_details.php" \
  -H "Content-Type: application/x-www-form-urlencoded" \
  -d "UserId=0&Language=EN&AnimeId=xNarutoShippuuden&AnimeRelationId=&Token=8cnY80AZSbUCmR26Vku1VUUY4"
```

**Response:**
```json
{
  "Plot": "It has been two and a half years since Naruto Uzumaki left...",
  "AnimeStatistics": {
    "UserRate": 0,
    "rates_1": "7625",
    "rates_2": "3305",
    "rates_3": "1776",
    "rates_4": "1441",
    "rates_5": "1649",
    "rates_6": "1776",
    "rates_7": "2177",
    "rates_8": "3105",
    "rates_9": "5276",
    "rates_10": "24371",
    "library_favourites": "92306",
    "library_watch_done": "24196",
    "library_watch_later": "7188",
    "library_watch_currently": "13709",
    "views": "4445018"
  },
  "Library": {
    "Favourite": 0,
    "Library": null
  },
  "RelatedAnime": []
}
```

**Test 2: One Piece**
```bash
curl -X POST "https://animeify.net/animeify/apis_v4/anime/load_anime_details.php" \
  -H "Content-Type: application/x-www-form-urlencoded" \
  -d "UserId=0&Language=EN&AnimeId=xOnePiece&AnimeRelationId=&Token=8cnY80AZSbUCmR26Vku1VUUY4"
```

**Response:** ✅ Success - Full data returned

---

## 🔑 Key Findings

### 1. AnimeId Format
- **Type:** String (slug)
- **Pattern:** Starts with `x` followed by title in PascalCase
- **Examples:**
  - `xNarutoShippuuden`
  - `xOnePiece`
  - `xAttackOnTitan`
  - `xDemonSlayer`

### 2. Data Model

**AnimeModel** has two IDs:
- `Id` (int) - Numeric database ID
- `AnimeId` (string) - Slug identifier used for API calls

### 3. The App's Strategy

The Android app uses a **two-phase loading strategy**:

**Phase 1:** Display immediately from passed data
- Title, poster, genres, type, episodes, etc.
- User sees content instantly

**Phase 2:** Load additional details via API
- Plot/description
- Statistics (ratings, favorites, views)
- User's library status
- Related anime

This provides a fast user experience while loading heavy data in the background.

---

## 💡 Solution for Next.js App

### Option 1: Store Full Anime Data (Recommended)

When user clicks an anime card, pass the complete anime object to the details page:

```typescript
// In your anime list/grid component
<Link 
  href={{
    pathname: `/anime/${anime.AnimeId}`,
    query: { data: JSON.stringify(anime) }
  }}
>
```

Then on the details page, display the data immediately and load additional details:

```typescript
// app/anime/[slug]/page.tsx
export default async function AnimeDetailsPage({ params, searchParams }) {
  // Phase 1: Display passed data immediately
  const animeData = searchParams.data ? JSON.parse(searchParams.data) : null;
  
  // Phase 2: Load additional details
  const details = await fetch('https://animeify.net/animeify/apis_v4/anime/load_anime_details.php', {
    method: 'POST',
    headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
    body: new URLSearchParams({
      UserId: '0',
      Language: 'EN',
      AnimeId: params.slug,
      AnimeRelationId: animeData?.RelationId || '',
      Token: '8cnY80AZSbUCmR26Vku1VUUY4'
    })
  }).then(r => r.json());
  
  return <AnimeDetails anime={animeData} details={details} />;
}
```

### Option 2: Use Search Endpoint as Fallback

If you only have the slug, use the search endpoint:

```typescript
const response = await fetch('https://animeify.net/animeify/apis_v4/anime/load_anime_list_v2.php', {
  method: 'POST',
  body: new URLSearchParams({
    UserId: '0',
    Language: 'EN',
    FilterType: 'SEARCH',
    FilterData: titleFromSlug, // Extract title from slug
    Token: '8cnY80AZSbUCmR26Vku1VUUY4'
  })
});
```

---

## 📊 API Comparison

| Endpoint | Purpose | Input | Returns Full Anime Data? |
|----------|---------|-------|-------------------------|
| `load_anime_details.php` | Get plot, stats, related | Slug (AnimeId) | ❌ No - Only plot, stats, related |
| `load_anime_list_v2.php` (SEARCH) | Search anime | Title string | ✅ Yes - Complete anime object |

**Conclusion:** The "details" endpoint doesn't return full details! It only returns supplementary data. The app already has the main anime data before calling this endpoint.

---

## 🎬 Next Steps

1. **Update your Next.js routing** to pass full anime data when navigating to details page
2. **Use the slug format** (`xNarutoShippuuden`) for the AnimeId parameter
3. **Implement two-phase loading** like the Android app for better UX
4. **Consider caching** the anime list data to avoid repeated searches

---

## 📝 Notes

- The endpoint has some PHP notices/warnings but still returns valid JSON
- Some anime slugs may not have data (returns null values)
- The `Token` is hardcoded in the app: `8cnY80AZSbUCmR26Vku1VUUY4`
- The API base URL: `https://animeify.net/animeify/apis_v4/`
