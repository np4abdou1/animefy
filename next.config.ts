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
};

export default nextConfig;
