"use client"

import Link from "next/link"

interface EpisodeData {
  eId?: string
  AnimeID?: string
  Episode?: string | number
}

interface Episode {
  eId?: string
  AnimeID?: string
  Episode?: EpisodeData | string | number
  Anime?: {
    anime_id?: string
    Synonyms?: string
    EN_Title?: string
    AR_Title?: string
    Thumbnail?: string
  }
}

interface LatestEpisodesProps {
  episodes: Episode[]
}

const THUMBNAILS_BASE = "https://animeify.net/animeify/files/thumbnails/"

export default function LatestEpisodes({ episodes }: LatestEpisodesProps) {
  if (!episodes || episodes.length === 0) return null

  return (
    <section id="latest" className="relative py-12">
      <div className="mb-4">
        <h2
          className="text-4xl md:text-5xl font-semibold text-white"
          style={{ fontFamily: "var(--font-big-titles)" }}
        >
          اخر التحديثات
        </h2>
      </div>

      <div className="relative">
        <div className="flex overflow-x-auto gap-3 py-8 pb-6 scrollbar-hide">
          {episodes.map((episode, index) => {
            const animeId = episode.AnimeID || episode.Anime?.anime_id || ""

            // Handle Episode field - could be string, number, or object
            let episodeNum = ""
            if (typeof episode.Episode === "object" && episode.Episode !== null) {
              episodeNum = (episode.Episode as EpisodeData).Episode?.toString() || ""
            } else if (episode.Episode) {
              episodeNum = episode.Episode.toString()
            }

            const title = episode.Anime?.Synonyms || episode.Anime?.EN_Title || episode.Anime?.AR_Title || ""
            const thumbnail = episode.Anime?.Thumbnail || ""

            return (
              <Link
                key={`${episode.eId || index}`}
                href={`/anime/${animeId}/episode/${episodeNum}`}
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
                        className="absolute top-3 left-3 bg-black/90 backdrop-blur-sm text-white px-3 py-1.5 text-sm rounded font-medium"
                        style={{ fontFamily: "var(--font-normal-text)" }}
                      >
                        الحلقة {episodeNum}
                      </div>
                      <div className="absolute bottom-0 left-0 right-0 p-4">
                        <h3
                          className="text-base font-semibold text-white line-clamp-2 text-center"
                          style={{ fontFamily: "var(--font-normal-text)" }}
                          dir="ltr"
                        >
                          {title}
                        </h3>
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
