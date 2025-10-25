import type { NextConfig } from "next";

const nextConfig: NextConfig = {
  // Cloudflare Pages compatibility
  skipTrailingSlashRedirect: true,
  trailingSlash: false,
  
  // Image configuration
  images: {
    unoptimized: true, // Required for Cloudflare Pages
    remotePatterns: [
      {
        protocol: 'https',
        hostname: 'animeify.net',
        port: '',
        pathname: '/**',
      },
    ],
  },
  
  // Better handling of dynamic routes
  experimental: {
    missingSuspenseWithCSRBailout: false,
  },
  
  // Generate static pages for dynamic routes
  generateBuildId: async () => {
    return 'animefy-build-' + Date.now()
  },
};

export default nextConfig;
