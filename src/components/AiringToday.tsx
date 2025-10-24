"use client"

import Link from 'next/link'
import { createAnimeUrl } from '@/utils/slugify'
import { Clock } from "lucide-react"

interface Anime {
  Id?: string
  AnimeId?: string
  anime_id?: string
  Synonyms?: string
  EN_Title?: string
  AR_Title?: string
  Thumbnail?: string
  Episodes?: string
}

interface AiringTodayProps {
  animes: Anime[]
}

const THUMBNAILS_BASE = "https://animeify.net/animeify/files/thumbnails/"

// Arabic day names
const ARABIC_DAYS: { [key: string]: string } = {
  SUNDAY: "الأحد",
  MONDAY: "الإثنين",
  TUESDAY: "الثلاثاء",
  WEDNESDAY: "الأربعاء",
  THURSDAY: "الخميس",
  FRIDAY: "الجمعة",
  SATURDAY: "السبت",
}

// Get current day in API format
function getCurrentDay(): string {
  const days = ["SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY"]
  return days[new Date().getDay()]
}

export default function AiringToday({ animes }: AiringTodayProps) {
  if (!animes || animes.length === 0) return null

  const currentDay = getCurrentDay()
  const arabicDay = ARABIC_DAYS[currentDay]

  return (
    <section id="airing" className="relative py-12 -mt-20">
      <div className="mb-8">
        <h2 className="text-4xl md:text-5xl font-semibold text-white" style={{ fontFamily: "var(--font-big-titles)" }}>
          يعرض الأن ({arabicDay})
        </h2>
      </div>

      <div className="relative -mr-4 md:-mr-12 lg:-mr-16 xl:-mr-24 -ml-4 md:-ml-12 lg:-ml-16 xl:-ml-24">
        <div className="flex overflow-x-auto gap-3 py-8 pb-6 scrollbar-hide pr-4 md:pr-12 lg:pr-16 xl:pr-24 pl-4 md:pl-12 lg:pl-16 xl:pl-24">
          {animes.map((anime, index) => {
            const animeId = anime.AnimeId || anime.anime_id || ""
            const title = anime.AR_Title || anime.EN_Title || anime.Synonyms || ""
            const thumbnail = anime.Thumbnail || ""
            const episodes = anime.Episodes || ""

            return (
              <Link
                key={`${animeId}-${index}`}
                href={createAnimeUrl(animeId, title, 'SERIES')}
                className="group flex-shrink-0 w-[180px] sm:w-[200px] md:w-[220px] lg:w-[240px]"
              >
                <div className="relative aspect-[2/3] bg-black transition-all duration-300 ease-out group-hover:scale-105 group-hover:ring-2 group-hover:ring-white/80 rounded-md">
                  <div className="absolute inset-0 overflow-hidden rounded-md">
                    {thumbnail && (
                      <img
                        src={THUMBNAILS_BASE + thumbnail || "/placeholder.svg"}
                        alt={title}
                        className="w-full h-full object-cover"
                      />
                    )}

                    {/* Hover overlay with title at bottom */}
                    <div className="absolute inset-0 bg-gradient-to-t from-black/90 via-transparent to-transparent opacity-0 group-hover:opacity-100 transition-opacity duration-300">
                      <div
                        className="absolute top-3 right-3 flex items-center gap-1.5 bg-black/90 backdrop-blur-sm text-white px-3 py-1.5 text-sm rounded font-medium"
                        style={{ fontFamily: "var(--font-normal-text)" }}
                      >
                        <Clock className="w-4 h-4" />
                        <span>اليوم</span>
                      </div>
                      <div className="absolute bottom-0 left-0 right-0 p-4">
                        <h3
                          className="text-base font-semibold text-white line-clamp-2"
                          style={{ fontFamily: "var(--font-normal-text)" }}
                        >
                          {title}
                        </h3>
                        {episodes && (
                          <p className="text-sm text-gray-300 mt-1" style={{ fontFamily: "var(--font-normal-text)" }}>
                            الحلقة {episodes}
                          </p>
                        )}
                      </div>
                    </div>
                  </div>
                </div>
              </Link>
            )
          })}
        </div>
      </div>
    </section>
  )
}
