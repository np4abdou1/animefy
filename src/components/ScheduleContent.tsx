'use client';

import { useState } from 'react';
import Link from 'next/link';

interface Anime {
  Id?: string;
  AnimeId?: string;
  anime_id?: string;
  Synonyms?: string;
  EN_Title?: string;
  AR_Title?: string;
  Thumbnail?: string;
  Episodes?: string;
  Type?: string;
  Status?: string;
  EpisodeNumber?: string;
  EpisodeDate?: string;
}

interface ScheduleContentProps {
  schedule: { [day: string]: Anime[] };
  seasons: { season: string; animes: Anime[] }[];
}

const THUMBNAILS_BASE = "https://animeify.net/animeify/files/thumbnails/";

const ARABIC_DAYS: { [key: string]: string } = {
  'SUNDAY': 'الأحد',
  'MONDAY': 'الإثنين',
  'TUESDAY': 'الثلاثاء',
  'WEDNESDAY': 'الأربعاء',
  'THURSDAY': 'الخميس',
  'FRIDAY': 'الجمعة',
  'SATURDAY': 'السبت'
};

const DAYS_ORDER = ['SUNDAY', 'MONDAY', 'TUESDAY', 'WEDNESDAY', 'THURSDAY', 'FRIDAY', 'SATURDAY'];

export default function ScheduleContent({ schedule, seasons }: ScheduleContentProps) {
  const [activeTab, setActiveTab] = useState<'days' | 'seasons'>('days');
  const [selectedDay, setSelectedDay] = useState(() => {
    const days = ['SUNDAY', 'MONDAY', 'TUESDAY', 'WEDNESDAY', 'THURSDAY', 'FRIDAY', 'SATURDAY'];
    return days[new Date().getDay()];
  });
  const [selectedSeason, setSelectedSeason] = useState<string>(seasons[0]?.season || '');

  const currentAnimes = activeTab === 'days' 
    ? schedule[selectedDay] || []
    : seasons.find(s => s.season === selectedSeason)?.animes || [];

  return (
    <div className="max-w-[1920px] mx-auto pb-20">
      {/* Compact Header */}
      <div className="mb-6 flex flex-col sm:flex-row items-start sm:items-center justify-between gap-4">
        <h1 
          className="text-3xl md:text-4xl font-bold text-white"
          style={{ fontFamily: 'var(--font-big-titles)' }}
        >
          مواعيد الأنمي
        </h1>
        
        {/* View Mode Toggle - Compact */}
        <div className="flex gap-2">
          <button
            onClick={() => setActiveTab('days')}
            className={`px-4 py-2 rounded-lg font-semibold transition-all duration-200 text-sm ${
              activeTab === 'days'
                ? 'bg-white text-black'
                : 'bg-white/10 text-white hover:bg-white/20'
            }`}
            style={{ fontFamily: 'var(--font-normal-text)' }}
          >
            الأسبوع
          </button>
          <button
            onClick={() => setActiveTab('seasons')}
            className={`px-4 py-2 rounded-lg font-semibold transition-all duration-200 text-sm ${
              activeTab === 'seasons'
                ? 'bg-white text-black'
                : 'bg-white/10 text-white hover:bg-white/20'
            }`}
            style={{ fontFamily: 'var(--font-normal-text)' }}
          >
            المواسم
          </button>
        </div>
      </div>

      {/* Day/Season Selector - Horizontal Pills */}
      <div className="mb-6 flex gap-2 overflow-x-auto scrollbar-hide pb-2">
        {activeTab === 'days' ? (
          DAYS_ORDER.map((day) => (
            <button
              key={day}
              onClick={() => setSelectedDay(day)}
              className={`px-4 py-1.5 rounded-full font-semibold whitespace-nowrap transition-all duration-200 text-sm ${
                selectedDay === day
                  ? 'bg-white text-black'
                  : 'bg-white/10 text-white hover:bg-white/20'
              }`}
              style={{ fontFamily: 'var(--font-normal-text)' }}
            >
              {ARABIC_DAYS[day]}
            </button>
          ))
        ) : (
          seasons.map(({ season }) => (
            <button
              key={season}
              onClick={() => setSelectedSeason(season)}
              className={`px-4 py-1.5 rounded-full font-semibold whitespace-nowrap transition-all duration-200 text-sm ${
                selectedSeason === season
                  ? 'bg-white text-black'
                  : 'bg-white/10 text-white hover:bg-white/20'
              }`}
              style={{ fontFamily: 'var(--font-normal-text)' }}
            >
              {season}
            </button>
          ))
        )}
      </div>

      {/* Episode Cards - Wide Cards for Both Views */}
      {currentAnimes.length > 0 ? (
        <div className="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 xl:grid-cols-4 gap-4">
          {currentAnimes.map((anime, index) => {
            const animeId = anime.AnimeId || anime.anime_id || anime.Id || '';
            const title = anime.Synonyms || anime.EN_Title || anime.AR_Title || '';
            const thumbnail = anime.Thumbnail || '';
            const episodeNum = anime.EpisodeNumber || '';
            const type = anime.Type || '';
            const status = anime.Status || '';
            
            // Determine badge text
            let badgeText = '';
            if (activeTab === 'days' && episodeNum) {
              badgeText = `حلقة ${episodeNum}`;
            } else if (type === 'MOVIE') {
              badgeText = 'فيلم';
            } else if (type === 'SERIES') {
              if (status === 'AIRING') {
                badgeText = 'يعرض الآن';
              } else if (status === 'AIRED') {
                badgeText = 'منتهي';
              }
            }
            
            return (
              <Link
                key={`${animeId}-${index}`}
                href={`/anime/${animeId}`}
                className="group"
              >
                <div className="relative aspect-[16/9] bg-white/5 rounded-lg overflow-hidden transition-all duration-300 ease-out group-hover:scale-[1.02] group-hover:ring-2 group-hover:ring-white">
                  {thumbnail && (
                    <img
                      src={THUMBNAILS_BASE + thumbnail}
                      alt={title}
                      className="w-full h-full object-cover"
                      loading="lazy"
                    />
                  )}
                  
                  {/* Gradient Overlay - Hidden by default, visible on hover */}
                  <div className="absolute inset-0 bg-gradient-to-t from-black/90 via-black/40 to-transparent opacity-0 group-hover:opacity-100 transition-opacity duration-300">
                    <div className="absolute bottom-0 left-0 right-0 p-4">
                      <h3 
                        className="text-white text-base md:text-lg font-semibold line-clamp-2"
                        style={{ fontFamily: 'var(--font-normal-text)' }}
                      >
                        {title}
                      </h3>
                    </div>
                  </div>

                  {/* Badge */}
                  {badgeText && (
                    <div className="absolute top-3 right-3 bg-black/80 backdrop-blur-sm px-3 py-1.5 rounded text-sm text-white font-semibold">
                      {badgeText}
                    </div>
                  )}
                </div>
              </Link>
            );
          })}
        </div>
      ) : (
        <div className="text-center py-20">
          <p className="text-gray-400 text-xl" style={{ fontFamily: 'var(--font-normal-text)' }}>
            لا توجد حلقات مجدولة
          </p>
        </div>
      )}
    </div>
  );
}
