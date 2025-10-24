"use client"

import Link from "next/link"
import { createAnimeUrl } from '@/utils/slugify'
import { TrendingUp, Crown } from "lucide-react"

interface TrendingItem {
  Id?: string
  SubjectId?: string
  Title?: string
  Episodes?: string
  Photo?: string
  Type?: string
  Anime?: {
    AnimeId?: string
    anime_id?: string
    Synonyms?: string
    EN_Title?: string
    AR_Title?: string
    Thumbnail?: string
  }
}

interface TrendingAnimeProps {
  trending: TrendingItem[]
}

const THUMBNAILS_BASE = "https://animeify.net/animeify/files/thumbnails/"
const TRENDING_PHOTOS_BASE = "https://animeify.net/animeify/files/trending/photos/"

export default function TrendingAnime({ trending }: TrendingAnimeProps) {
  if (!trending || trending.length === 0) return null

  // Filter out non-episode items (like ads/banners)
  const episodeTrending = trending.filter((item) => item.Type === "EPISODE")

  if (episodeTrending.length === 0) return null

  return (
    <section id="trending" className="py-12">
      <div className="mb-8">
        <div className="flex items-center gap-2">
          <h2
            className="text-4xl md:text-5xl font-semibold text-white"
            style={{ fontFamily: "var(--font-big-titles)" }}
          >
            الأكثر مشاهدة
          </h2>
          <TrendingUp className="w-6 h-6 text-white/20" />
        </div>
      </div>

      <div className="relative -mr-4 md:-mr-12 lg:-mr-16 xl:-mr-24 -ml-4 md:-ml-12 lg:-ml-16 xl:-ml-24">
        <div className="flex overflow-x-auto gap-3 py-8 pb-6 scrollbar-hide pr-4 md:pr-12 lg:pr-16 xl:pr-24 pl-4 md:pl-12 lg:pl-16 xl:pl-24">
          {episodeTrending.map((item, index) => {
            const animeId = item.SubjectId || item.Anime?.AnimeId || item.Anime?.anime_id || ""
            const title = item.Title || item.Anime?.AR_Title || item.Anime?.EN_Title || item.Anime?.Synonyms || ""

            // Trending items have Photo field (slider images), fallback to Anime.Thumbnail
            const photo = item.Photo || ""
            const animeThumbnail = item.Anime?.Thumbnail || ""
            const thumbnail = photo
              ? TRENDING_PHOTOS_BASE + photo
              : animeThumbnail
                ? THUMBNAILS_BASE + animeThumbnail
                : ""

            const episodes = item.Episodes || ""

            // Top 3 get minimal special styling
            const isTopThree = index < 3

            return (
              <Link
                key={`${item.Id || index}`}
                href={createAnimeUrl(animeId, title, 'SERIES')}
                className="group flex-shrink-0 w-[320px] sm:w-[360px] md:w-[400px] lg:w-[450px]"
              >
                <div className="relative aspect-[16/9] bg-black transition-all duration-300 ease-out group-hover:scale-105 group-hover:ring-2 group-hover:ring-white/80 rounded-md">
                  <div className="absolute inset-0 overflow-hidden rounded-md">
                    {thumbnail && (
                      <img src={thumbnail || "/placeholder.svg"} alt={title} className="w-full h-full object-cover" />
                    )}

                    {/* Hover overlay with title at bottom */}
                    <div className="absolute inset-0 bg-gradient-to-t from-black/90 via-transparent to-transparent opacity-0 group-hover:opacity-100 transition-opacity duration-300">
                      <div
                        className={`absolute top-3 left-3 backdrop-blur-sm px-3 py-1.5 text-sm rounded font-bold transition-all duration-300 ${
                          isTopThree ? "bg-white/95 text-black" : "bg-black/90 text-white"
                        }`}
                        style={{ fontFamily: "var(--font-normal-text)" }}
                      >
                        {index === 0 && <Crown className="w-4 h-4 inline ml-1 mb-0.5" />}#{index + 1}
                      </div>
                      <div className="absolute bottom-0 left-0 right-0 p-4">
                        <h3
                          className="text-lg font-semibold text-white line-clamp-2"
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
