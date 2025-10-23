# WitAnime Features Documentation

## New Pages

### Anime Detail Page
**Route:** `/anime/[id]`

Displays comprehensive information about an anime including:
- Title (Arabic & English)
- Score, status, episode count
- Synopsis/story
- Complete episodes list (clickable)
- Characters with photos
- Related anime
- Detailed information sidebar

**Example:** `/anime/12345`

### Watch/Streaming Page
**Route:** `/watch/[animeId]/[episode]`

Video streaming page with advanced player features:
- Multi-quality support (1080p, 720p, 480p)
- Multiple server options
- MediaFire direct streaming (priority)
- Embed player fallback (Mega, OK.ru, etc.)
- Episode navigation (previous/next)
- Episodes sidebar for quick access

**Example:** `/watch/12345/1` (Anime ID: 12345, Episode: 1)

## Video Player Features

### Quality Switching
The video player automatically detects available qualities and allows users to switch between:
- 1080p (Full HD)
- 720p (HD) - Default
- 480p (SD)

### Server Switching
Multiple streaming servers per quality level:
- **MediaFire** - Direct download/stream links (Priority)
- **Server 1** - Alternative direct servers
- **Mega** - Embed player
- **OK.ru** - Embed player
- **Google Drive** - Direct API access

### Smart Server Selection
1. First tries MediaFire direct links
2. Falls back to other direct servers
3. Uses embed players as last resort
4. Automatically selects best available server

## API Endpoints (Worker)

### Enhanced Endpoints

#### Get Anime Details (Complete)
```
GET /api/anime/:id
```

Returns anime details, episodes, characters, and related anime in a single request.

**Response:**
```json
{
  "status": "success",
  "data": {
    "anime": { ... },
    "episodes": [ ... ],
    "characters": [ ... ],
    "related": [ ... ]
  }
}
```

#### Get Streaming Servers
```
GET /api/anime/:id/watch/:episode
```

Returns all available streaming servers for a specific episode.

**Response:**
```json
{
  "status": "success",
  "data": {
    "CurrentEpisode": {
      "Episode": 1.0,
      "Type": "EPISODE",
      "FRLink": "mediafire_id",
      "MALink": "mega_id",
      "OKLink": "okru_id",
      "FRFhdQ": "mediafire_1080p_id",
      "FRLowQ": "mediafire_480p_id",
      ...
    },
    "NextEpisode": { ... },
    "PreviousEpisode": null
  }
}
```

## Design System

### Typography
All pages use custom fonts from `/public/fonts/`:
- **BigTitlesStylish** - Main headings (anime titles)
- **NormalText** - Body text and UI elements
- **AnimeTitlesEnglish** - English subtitles
- **HeaderFont** - Navigation and headers

### Color Scheme
- **Background:** Black (#000) with subtle gradients
- **Text:** White with gray variations (#fff, #ccc, #999)
- **Accents:** White/10% for subtle backgrounds
- **Borders:** White/10-30% opacity
- **Score Badge:** Yellow (#eab308)
- **Active State:** White background with black text

### Components

#### Badges
```tsx
<span className="bg-white/10 px-3 py-1.5 rounded-full border border-white/20">
  Status
</span>
```

#### Buttons
```tsx
<button className="bg-white text-black px-8 py-3 rounded-full font-bold hover:scale-105">
  Action
</button>
```

#### Cards
```tsx
<div className="bg-white/5 border border-white/10 rounded-lg hover:bg-white/10">
  Content
</div>
```

## Arabic Language Support

All UI text is in Arabic:
- "ابدأ المشاهدة" - Start Watching
- "الحلقات" - Episodes
- "الشخصيات" - Characters
- "معلومات" - Information
- "القصة" - Story
- "الجودة" - Quality
- "الخوادم" - Servers
- "الحلقة السابقة" - Previous Episode
- "الحلقة التالية" - Next Episode

## Responsive Design

All pages are fully responsive:
- **Mobile:** Single column, stacked layout
- **Tablet:** 2-column grid for some sections
- **Desktop:** Full multi-column layouts with sidebars

### Breakpoints
- `sm:` 640px
- `md:` 768px
- `lg:` 1024px
- `xl:` 1280px

## Performance Optimizations

1. **Server-Side Rendering:** All pages use SSR with revalidation
2. **Parallel API Calls:** Worker fetches all data simultaneously
3. **Image Optimization:** Next.js automatic image optimization
4. **Caching:** 
   - Anime details: 10 minutes (600s)
   - Streaming servers: 5 minutes (300s)
   - Home content: 5 minutes (300s)

## Usage Examples

### Linking to Anime Detail
```tsx
<Link href={`/anime/${animeId}`}>
  {animeTitle}
</Link>
```

### Linking to Watch Episode
```tsx
<Link href={`/watch/${animeId}/${episodeNumber}`}>
  Watch Episode {episodeNumber}
</Link>
```

### Episode Navigation
```tsx
// Next episode
<Link href={`/watch/${animeId}/${currentEpisode + 1}`}>
  Next Episode
</Link>

// Previous episode
<Link href={`/watch/${animeId}/${currentEpisode - 1}`}>
  Previous Episode
</Link>
```

## Worker Deployment

The enhanced worker is ready for deployment to Cloudflare Workers.

**Deploy Command:**
```bash
cd worker
wrangler deploy
```

**Configuration:**
- Worker name: `witanime-api-worker`
- Routes configured in `wrangler.toml`
- Environment variables: None required (uses hardcoded API token)

## Browser Compatibility

Tested and works on:
- Chrome/Edge (latest)
- Firefox (latest)
- Safari (latest)
- Mobile browsers (iOS Safari, Chrome Mobile)

## Accessibility

- Semantic HTML structure
- ARIA labels where appropriate
- Keyboard navigation support
- RTL (Right-to-Left) layout for Arabic
- High contrast ratios for readability
