This is a [Next.js](https://nextjs.org) project bootstrapped with [`create-next-app`](https://nextjs.org/docs/app/api-reference/cli/create-next-app).

## Configuration

### API Setup

The application requires access to the Animeify API. You can configure the API endpoint using environment variables:

1. Copy `.env.local.example` to `.env.local`:
   ```bash
   cp .env.local.example .env.local
   ```

2. (Optional) Update the API endpoint in `.env.local`:
   ```bash
   NEXT_PUBLIC_API_BASE_URL=https://animeify.net/animeify/apis_v4/
   NEXT_PUBLIC_API_TOKEN=8cnY80AZSbUCmR26Vku1VUUY4
   ```

If the default API endpoint is not accessible, you can:
- Deploy the included Cloudflare Worker (see `/worker` directory) and point to it
- Use an alternative API proxy
- The app will gracefully handle API failures and display empty states

## Getting Started

First, install dependencies:

```bash
npm install
```

Then, run the development server:

```bash
npm run dev
# or
yarn dev
# or
pnpm dev
# or
bun dev
```

Open [http://localhost:3000](http://localhost:3000) with your browser to see the result.

You can start editing the page by modifying `app/page.tsx`. The page auto-updates as you edit the file.

## Custom Fonts

This project uses custom fonts located in `/public/fonts/` instead of Google Fonts:
- `header.ttf` - HeaderFont
- `normal_text.ttf` - NormalText  
- `big-titles-stylish.otf` - BigTitlesStylish
- `anime_titles_english.otf` - AnimeTitlesEnglish

Fonts are defined as CSS variables in `globals.css` and can be used as:
```css
font-family: var(--font-header);
font-family: var(--font-normal-text);
font-family: var(--font-big-titles);
font-family: var(--font-anime-titles);
```

## Learn More

To learn more about Next.js, take a look at the following resources:

- [Next.js Documentation](https://nextjs.org/docs) - learn about Next.js features and API.
- [Learn Next.js](https://nextjs.org/learn) - an interactive Next.js tutorial.

You can check out [the Next.js GitHub repository](https://github.com/vercel/next.js) - your feedback and contributions are welcome!

## Deploy on Vercel

The easiest way to deploy your Next.js app is to use the [Vercel Platform](https://vercel.com/new?utm_medium=default-template&filter=next.js&utm_source=create-next-app&utm_campaign=create-next-app-readme) from the creators of Next.js.

Check out our [Next.js deployment documentation](https://nextjs.org/docs/app/building-your-application/deploying) for more details.
