# Cloudflare Pages Deployment Notes

## Font Files Configuration

This project uses custom fonts located in `/public/fonts/`. To ensure fonts load correctly on Cloudflare Pages:

### Changes Made

1. **Font File Naming**: Renamed `big titles stylish.otf` to `big-titles-stylish.otf` to avoid issues with spaces in URLs
   - Updated the corresponding `@font-face` declaration in `src/app/globals.css`

2. **Headers Configuration**: Added `public/_headers` file with:
   - CORS headers (`Access-Control-Allow-Origin: *`) to allow fonts to be loaded cross-origin
   - Cache headers (`Cache-Control: public, max-age=31536000, immutable`) for optimal performance
   - Proper Content-Type headers for different font formats (ttf, otf, woff, woff2)

3. **Next.js Configuration**: Updated `next.config.ts` to:
   - Support optional asset prefix via `NEXT_PUBLIC_ASSET_PREFIX` environment variable
   - Support static export mode via `OUTPUT_MODE=export` environment variable

### Font Files

The following custom fonts are available:
- `header.ttf` - HeaderFont
- `normal_text.ttf` - NormalText
- `big-titles-stylish.otf` - BigTitlesStylish
- `anime_titles_english.otf` - AnimeTitlesEnglish

### Usage in Code

Fonts are defined as CSS variables in `globals.css` and can be used as:
```css
font-family: var(--font-header);
font-family: var(--font-normal-text);
font-family: var(--font-big-titles);
font-family: var(--font-anime-titles);
```

Or directly:
```css
font-family: 'HeaderFont', sans-serif;
font-family: 'NormalText', sans-serif;
font-family: 'BigTitlesStylish', sans-serif;
font-family: 'AnimeTitlesEnglish', sans-serif;
```

### Cloudflare Pages Build Settings

Recommended build settings:
- Build command: `npm run build`
- Build output directory: `.next`
- Environment variables (if needed):
  - `NODE_VERSION`: 20
  - `OUTPUT_MODE`: (optional) set to `export` for static export

The `_headers` file will be automatically picked up by Cloudflare Pages and applied to the appropriate routes.
