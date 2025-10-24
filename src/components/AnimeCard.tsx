'use client';

import { useState } from 'react';
import Link from 'next/link';
import { storeAnimeUrl, createAnimeSlug, type AnimeData } from '@/lib/anime-url';

interface AnimeCardProps {
  anime: AnimeData;
  className?: string;
}

export function AnimeCard({ anime, className = '' }: AnimeCardProps) {
  const [animeUrl, setAnimeUrl] = useState<string | null>(null);
  const [isStoring, setIsStoring] = useState(false);

  const handleClick = async (e: React.MouseEvent) => {
    // Prevent default navigation
    e.preventDefault();

    if (isStoring) return;

    setIsStoring(true);

    try {
      // Store anime data in KV with slug as key
      const response = await fetch('/api/anime/store-url', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(anime)
      });

      if (response.ok) {
        const result = await response.json();
        if (result.success && result.url) {
          // Navigate to the clean URL
          window.location.href = result.url;
          return;
        }
      }
      
      // Fallback: create slug and navigate
      const fallbackSlug = createAnimeSlug(anime.EN_Title || anime.AR_Title || anime.AnimeId);
      window.location.href = `/anime/${fallbackSlug}`;
    } catch (error) {
      console.error('Error storing anime URL:', error);
      // Fallback: use slug directly
      const fallbackSlug = createAnimeSlug(anime.EN_Title || anime.AR_Title || anime.AnimeId);
      window.location.href = `/anime/${fallbackSlug}`;
    } finally {
      setIsStoring(false);
    }
  };

  const thumbnailUrl = `https://animeify.net/animeify/files/thumbnails/${anime.Thumbnail}`;

  return (
    <Link
      href={animeUrl || '#'}
      onClick={handleClick}
      className={`group relative block overflow-hidden rounded-lg bg-gray-900 transition-transform hover:scale-105 ${className}`}
    >
      <div className="aspect-[2/3] relative">
        <img
          src={thumbnailUrl}
          alt={anime.EN_Title}
          className="w-full h-full object-cover"
          loading="lazy"
        />
        
        {/* Overlay */}
        <div className="absolute inset-0 bg-gradient-to-t from-black/80 via-black/20 to-transparent opacity-0 group-hover:opacity-100 transition-opacity" />
        
        {/* Info on hover */}
        <div className="absolute bottom-0 left-0 right-0 p-4 translate-y-full group-hover:translate-y-0 transition-transform">
          <p className="text-white text-sm font-semibold line-clamp-2">
            {anime.EN_Title}
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

      {/* Loading indicator */}
      {isStoring && (
        <div className="absolute inset-0 bg-black/50 flex items-center justify-center">
          <div className="w-8 h-8 border-4 border-blue-500 border-t-transparent rounded-full animate-spin" />
        </div>
      )}
    </Link>
  );
}
