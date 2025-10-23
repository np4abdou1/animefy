import type { NextConfig } from "next";

const nextConfig: NextConfig = {
  images: {
    remotePatterns: [
      {
        protocol: 'https',
        hostname: 'animeify.net',
        port: '',
        pathname: '/**',
      },
    ],
  },
  // Ensure fonts and static assets are properly handled
  assetPrefix: process.env.NEXT_PUBLIC_ASSET_PREFIX || undefined,
  // Enable static exports for better Cloudflare Pages compatibility
  output: process.env.OUTPUT_MODE === 'export' ? 'export' : undefined,
};

export default nextConfig;
