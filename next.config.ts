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
  // Cloudflare Pages compatibility
  skipTrailingSlashRedirect: true,
  // Ensure dynamic routes work properly
  experimental: {
    // This helps with dynamic route handling
  },
};

export default nextConfig;
