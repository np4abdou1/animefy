'use client';

import Link from 'next/link';
import { createAnimeUrl } from '@/lib/slug';

interface AnimeCardProps {
  anime: any;
  className?: string;
}

export function AnimeCard({ anime, className = '' }: AnimeCardProps) {
  const thumbnailUrl = `https://animeify.net/animeify/files/thumbnails/${anime.Thumbnail}`;
  const animeUrl = createAnimeUrl(anime);

  return (
    <Link 
      href={animeUrl}
      className={`group relative block overflow-hidden rounded-lg bg-gray-900 transition-transform hover:scale-105 ${className}`}
    >
      <div className="aspect-[2/3] relative">
        <img
          src={thumbnailUrl}
          alt={anime.EN_Title || anime.AR_Title}
          className="w-full h-full object-cover"
          loading="lazy"
        />
        
        {/* Overlay */}
        <div className="absolute inset-0 bg-gradient-to-t from-black/80 via-black/20 to-transparent opacity-0 group-hover:opacity-100 transition-opacity" />
        
        {/* Info on hover */}
        <div className="absolute bottom-0 left-0 right-0 p-4 translate-y-full group-hover:translate-y-0 transition-transform">
          <p className="text-white text-sm font-semibold line-clamp-2">
            {anime.EN_Title || anime.AR_Title}
          </p>
          <div className="flex items-center gap-2 mt-2 text-xs text-gray-300">
            <span>{anime.Type}</span>
            <span>•</span>
            <span>{anime.Episodes} eps</span>
            {anime.Score && (
              <>
                <span>•</span>
                <span>⭐ {anime.Score}</span>
              </>
            )}
          </div>
        </div>
      </div>
    </Link>
  );
}
