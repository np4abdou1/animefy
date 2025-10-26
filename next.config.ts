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
  
  // CRITICAL FIX: Use static export for Cloudflare Pages
  output: 'export',
  distDir: 'out',
  
  // REMOVED: Invalid experimental config that was causing build failure
  // experimental: { missingSuspenseWithCSRBailout: false }, // This was invalid
  
  // Generate static pages for dynamic routes
  generateBuildId: async () => {
    return 'animefy-build-' + Date.now()
  },
  
  // CRITICAL: Add generateStaticParams equivalent for static export
  async generateStaticParams() {
    return []
  },
  
  // Ensure proper routing for Cloudflare Pages
  async rewrites() {
    return [
      {
        source: '/anime/:slug*',
        destination: '/anime/:slug*',
      },
    ]
  },
};

export default nextConfig;
