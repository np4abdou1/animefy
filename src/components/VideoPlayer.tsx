"use client"

import { useEffect, useMemo, useRef, useState } from "react"
import {
  Pause,
  Play,
  Volume2,
  VolumeX,
  Maximize2,
  Settings2,
  SlidersHorizontal,
  ChevronDown,
  Loader2,
} from "lucide-react"
import { motion, AnimatePresence } from "framer-motion"

export type ServerEntry = {
  serverName: string
  serverType: string
  serverTypeKey?: string
  quality?: string
  url: string
  directUrl?: string | null
}

export interface ServerBootstrap {
  servers: ServerEntry[]
  mediafire?: ServerEntry[]
  bestMediafire?: ServerEntry | null
}

interface PlayerProps {
  animeId: string
  episodes: Array<{ Episode?: number | string } | number | string>
  defaultType?: "SERIES" | "MOVIE"
  defaultEpisode?: string
  initialServers?: ServerBootstrap | null
  title?: string
}

type EpisodeInput = { Episode?: number | string } | number | string

const MEDIAFIRE_KEY = "MEDIAFIRE"

function parseEpisodeValue(ep: EpisodeInput | undefined): string {
  if (ep == null) return ""
  if (typeof ep === "number" || typeof ep === "string") return String(ep)
  if (typeof (ep as any).Episode !== "undefined") return String((ep as any).Episode)
  if (typeof (ep as any).EPNumber !== "undefined") return String((ep as any).EPNumber)
  if (typeof (ep as any).Number !== "undefined") return String((ep as any).Number)
  return ""
}

function parseQualityValue(quality?: string) {
  const match = (quality || "").match(/(\d{3,4})p/i)
  return match ? parseInt(match[1], 10) : 0
}

function normalizeServerPayload(data: any): ServerBootstrap {
  return {
    servers: Array.isArray(data?.servers) ? data.servers : [],
    mediafire: Array.isArray(data?.mediafire) ? data.mediafire : [],
    bestMediafire: data?.bestMediafire ?? null,
  }
}

export default function VideoPlayer({
  animeId,
  episodes,
  defaultType = "SERIES",
  defaultEpisode,
  initialServers,
  title,
}: PlayerProps) {
  const videoRef = useRef<HTMLVideoElement | null>(null)
  const lastLoadedEpisodeRef = useRef<string | null>(null)
  const appliedInitialRef = useRef<boolean>(false)

  const initialEpisodeValue = useMemo(() => {
    if (defaultEpisode) return defaultEpisode
    if (Array.isArray(episodes) && episodes.length > 0) {
      return parseEpisodeValue(episodes[0]) || ""
    }
    return ""
  }, [defaultEpisode, episodes])

  const [selectedEpisode, setSelectedEpisode] = useState<string>(initialEpisodeValue)
  const [servers, setServers] = useState<ServerEntry[]>(initialServers?.servers ?? [])
  const [currentSrc, setCurrentSrc] = useState<string>("")
  const [useIframe, setUseIframe] = useState<boolean>(false)
  const [iframeSrc, setIframeSrc] = useState<string>("")
  const [selectedServerKey, setSelectedServerKey] = useState<string>("")
  const [selectedServerName, setSelectedServerName] = useState<string>("")
  const [selectedQuality, setSelectedQuality] = useState<string>("")
  const [isPlaying, setIsPlaying] = useState<boolean>(false)
  const [muted, setMuted] = useState<boolean>(false)
  const [showServersMenu, setShowServersMenu] = useState<boolean>(false)
  const [showQualityMenu, setShowQualityMenu] = useState<boolean>(false)
  const [loadingServers, setLoadingServers] = useState<boolean>(false)

  useEffect(() => {
    setSelectedEpisode(initialEpisodeValue)
  }, [initialEpisodeValue])

  const mediafireOptions = useMemo(() => {
    const list = servers.filter((server) => {
      const key = (server.serverTypeKey || server.serverType || "").toUpperCase()
      return key.includes(MEDIAFIRE_KEY) && !!server.directUrl
    })
    return [...list].sort((a, b) => parseQualityValue(b.quality) - parseQualityValue(a.quality))
  }, [servers])

  function applyServerData(rawPayload: ServerBootstrap | null | undefined, episodeValue: string, preferredQuality?: string) {
    if (!rawPayload) return
    const payload = normalizeServerPayload(rawPayload)
    const list = payload.servers ?? []
    setServers(list)

    const keyFrom = (entry: ServerEntry) => (entry.serverTypeKey || entry.serverType || "").toUpperCase()
    const directCandidates = list.filter((s) => keyFrom(s).includes(MEDIAFIRE_KEY) && !!s.directUrl)
    directCandidates.sort((a, b) => parseQualityValue(b.quality) - parseQualityValue(a.quality))

    let chosenDirect: ServerEntry | undefined
    if (preferredQuality) {
      chosenDirect = directCandidates.find((s) => (s.quality || "") === preferredQuality)
    }
    if (!chosenDirect) {
      chosenDirect = directCandidates[0]
    }

    if (chosenDirect && chosenDirect.directUrl) {
      setUseIframe(false)
      setIframeSrc("")
      setCurrentSrc(chosenDirect.directUrl)
      setSelectedServerKey(MEDIAFIRE_KEY)
      setSelectedServerName(chosenDirect.serverName || "Mediafire")
      setSelectedQuality(chosenDirect.quality || "")
      setTimeout(() => {
        try {
          videoRef.current?.play()?.catch(() => {})
          setIsPlaying(true)
        } catch {}
      }, 120)
    } else {
      const embed = list.find((s) => {
        const key = keyFrom(s)
        return !key.includes(MEDIAFIRE_KEY) && !!s.url
      })
      if (embed) {
        setUseIframe(true)
        setIframeSrc(embed.url)
        setCurrentSrc("")
        setSelectedServerKey(keyFrom(embed))
        setSelectedServerName(embed.serverName || embed.serverType || "Embed")
        setSelectedQuality(embed.quality || "")
        try {
          videoRef.current?.pause?.()
        } catch {}
        setIsPlaying(false)
      } else {
        setUseIframe(false)
        setIframeSrc("")
        setCurrentSrc("")
        setSelectedServerKey("")
        setSelectedServerName("")
        setSelectedQuality("")
        try {
          videoRef.current?.pause?.()
        } catch {}
        setIsPlaying(false)
      }
    }

    lastLoadedEpisodeRef.current = episodeValue
    setShowServersMenu(false)
    setShowQualityMenu(false)
  }

  useEffect(() => {
    if (!appliedInitialRef.current && initialServers && initialEpisodeValue) {
      applyServerData(initialServers, initialEpisodeValue, initialServers.bestMediafire?.quality || undefined)
      appliedInitialRef.current = true
    }
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [initialServers, initialEpisodeValue])

  async function loadServers(episodeValue: string) {
    try {
      setLoadingServers(true)
      const params = new URLSearchParams({ episode: episodeValue, type: defaultType })
      const res = await fetch(`/api/anime/${animeId}/servers?${params.toString()}`, { cache: "no-store" })
      if (!res.ok) throw new Error(`servers_failed_${res.status}`)
      const json = await res.json()
      applyServerData(json, episodeValue)
    } catch (error) {
      console.error("[watch] Failed to load servers", error)
    } finally {
      setLoadingServers(false)
    }
  }

  useEffect(() => {
    if (!selectedEpisode) return
    if (lastLoadedEpisodeRef.current === selectedEpisode) return
    loadServers(selectedEpisode)
  }, [selectedEpisode])

  function handlePlayPause() {
    const v = videoRef.current
    if (!v) return
    if (v.paused) {
      v.play().then(() => setIsPlaying(true)).catch(() => {})
    } else {
      v.pause()
      setIsPlaying(false)
    }
  }

  function handleMute() {
    const v = videoRef.current
    if (!v) return
    v.muted = !v.muted
    setMuted(v.muted)
  }

  function handleFullscreen() {
    const el = document.getElementById("player-container")
    if (!el) return
    if (document.fullscreenElement) document.exitFullscreen().catch(() => {})
    else el.requestFullscreen().catch(() => {})
  }

  function onSelectServer(server: ServerEntry) {
    const key = (server.serverTypeKey || server.serverType || "").toUpperCase()
    if (key.includes(MEDIAFIRE_KEY) && server.directUrl) {
      setUseIframe(false)
      setIframeSrc("")
      setCurrentSrc(server.directUrl)
      setSelectedServerKey(MEDIAFIRE_KEY)
      setSelectedServerName(server.serverName || "Mediafire")
      setSelectedQuality(server.quality || "")
      setTimeout(() => {
        try {
          videoRef.current?.play()?.catch(() => {})
          setIsPlaying(true)
        } catch {}
      }, 80)
    } else if (server.url) {
      setUseIframe(true)
      setIframeSrc(server.url)
      setCurrentSrc("")
      setSelectedServerKey(key)
      setSelectedServerName(server.serverName || server.serverType || "Embed")
      setSelectedQuality(server.quality || "")
      try {
        videoRef.current?.pause?.()
      } catch {}
      setIsPlaying(false)
    }
    setShowServersMenu(false)
  }

  function onSelectQuality(entry: ServerEntry) {
    if (!entry?.directUrl) return
    setUseIframe(false)
    setIframeSrc("")
    setCurrentSrc(entry.directUrl)
    setSelectedQuality(entry.quality || "")
    setSelectedServerKey(MEDIAFIRE_KEY)
    setSelectedServerName(entry.serverName || "Mediafire")
    setShowQualityMenu(false)
    setTimeout(() => {
      try {
        videoRef.current?.play()?.catch(() => {})
        setIsPlaying(true)
      } catch {}
    }, 60)
  }

  const hasEpisodeSelected = Boolean(selectedEpisode)
  const hasMediafire = mediafireOptions.length > 0

  return (
    <div
      id="player-container"
      className="relative bg-black/70 border border-white/10 rounded-3xl overflow-hidden shadow-2xl"
    >
      <div className="relative aspect-video bg-black">
        {!useIframe ? (
          <video
            ref={videoRef}
            className="w-full h-full object-contain"
            src={currentSrc}
            controls={false}
            onPlay={() => setIsPlaying(true)}
            onPause={() => setIsPlaying(false)}
            title={title || "Anime player"}
          />
        ) : (
          <iframe
            src={iframeSrc}
            className="w-full h-full"
            allowFullScreen
            referrerPolicy="no-referrer"
            title={title || "Embedded player"}
          />
        )}

        {!hasEpisodeSelected && (
          <div className="absolute inset-0 flex items-center justify-center">
            <div
              className="px-6 py-4 rounded-xl bg-black/80 border border-white/10 text-white"
              style={{ fontFamily: "var(--font-normal-text)" }}
            >
              اختر حلقة لبدء المشاهدة
            </div>
          </div>
        )}

        {loadingServers && (
          <div className="absolute inset-0 flex items-center justify-center bg-black/60">
            <Loader2 className="w-8 h-8 text-white animate-spin" />
          </div>
        )}

        {!useIframe && (
          <div className="pointer-events-none absolute inset-0 bg-gradient-to-t from-black/45 via-transparent to-black/40" />
        )}
      </div>

      <div className="flex flex-col gap-3 md:flex-row md:items-center md:justify-between bg-black/60 border-t border-white/10 px-4 py-4">
        <div className="flex flex-wrap items-center gap-3">
          <div className="flex items-center gap-2">
            <label className="text-sm text-gray-300" style={{ fontFamily: "var(--font-normal-text)" }}>
              الحلقة
            </label>
            <div className="relative">
              <select
                className="appearance-none pr-8 pl-3 py-2 rounded-lg bg-white/10 text-white border border-white/20 backdrop-blur-md text-sm"
                value={selectedEpisode}
                onChange={(event) => {
                  const value = event.target.value
                  setSelectedEpisode(value)
                }}
                disabled={episodes.length === 0}
                style={{ fontFamily: "var(--font-normal-text)" }}
              >
                {!selectedEpisode && <option value="">اختر حلقة</option>}
                {episodes.map((episode, index) => {
                  const value = parseEpisodeValue(episode)
                  if (!value) return null
                  return (
                    <option key={`${value}-${index}`} value={value}>
                      الحلقة {value}
                    </option>
                  )
                })}
              </select>
              <ChevronDown className="absolute right-2 top-1/2 -translate-y-1/2 text-white w-4 h-4 pointer-events-none" />
            </div>
          </div>

          <div className="flex items-center gap-2">
            <div className="relative">
              <button
                type="button"
                onClick={() => setShowServersMenu((value) => !value)}
                className="p-2 rounded-full bg-white/10 text-white hover:bg-white/20 transition"
                aria-label="تغيير السيرفر"
              >
                <Settings2 className="w-5 h-5" />
              </button>
              <AnimatePresence>
                {showServersMenu && (
                  <motion.div
                    initial={{ opacity: 0, y: 10 }}
                    animate={{ opacity: 1, y: 0 }}
                    exit={{ opacity: 0, y: 10 }}
                    className="absolute top-12 right-0 z-30 w-64 rounded-xl border border-white/10 bg-black/95 backdrop-blur-xl p-3 shadow-2xl"
                  >
                    <header
                      className="mb-2 text-sm font-semibold text-white"
                      style={{ fontFamily: "var(--font-big-titles)" }}
                    >
                      اختر السيرفر
                    </header>
                    <div className="flex flex-wrap gap-2">
                      {servers.length === 0 && (
                        <span className="text-xs text-gray-400" style={{ fontFamily: "var(--font-normal-text)" }}>
                          لا تتوفر سيرفرات بعد
                        </span>
                      )}
                      {servers.map((server, index) => {
                        const key = (server.serverTypeKey || server.serverType || "").toUpperCase()
                        const isActive = key === selectedServerKey
                        return (
                          <button
                            key={`${server.serverName}-${index}`}
                            onClick={() => onSelectServer(server)}
                            className={`px-3 py-1.5 rounded-lg text-xs transition ${
                              isActive ? "bg-white text-black" : "bg-white/10 text-white hover:bg-white/20"
                            }`}
                            style={{ fontFamily: "var(--font-normal-text)" }}
                          >
                            {server.serverName || key || "Server"}
                          </button>
                        )
                      })}
                    </div>
                  </motion.div>
                )}
              </AnimatePresence>
            </div>

            {hasMediafire && (
              <div className="relative">
                <button
                  type="button"
                  onClick={() => setShowQualityMenu((value) => !value)}
                  className="p-2 rounded-full bg-white/10 text-white hover:bg-white/20 transition"
                  aria-label="تغيير الجودة"
                >
                  <SlidersHorizontal className="w-5 h-5" />
                </button>
                <AnimatePresence>
                  {showQualityMenu && (
                    <motion.div
                      initial={{ opacity: 0, y: 10 }}
                      animate={{ opacity: 1, y: 0 }}
                      exit={{ opacity: 0, y: 10 }}
                      className="absolute top-12 right-0 z-30 w-56 rounded-xl border border-white/10 bg-black/95 backdrop-blur-xl p-3 shadow-2xl"
                    >
                      <header
                        className="mb-2 text-sm font-semibold text-white"
                        style={{ fontFamily: "var(--font-big-titles)" }}
                      >
                        جودة Mediafire
                      </header>
                      <div className="flex flex-wrap gap-2">
                        {mediafireOptions.map((option, index) => {
                          const isActive = selectedQuality === option.quality
                          return (
                            <button
                              key={`${option.quality}-${index}`}
                              onClick={() => onSelectQuality(option)}
                              className={`px-3 py-1.5 rounded-lg text-xs transition ${
                                isActive ? "bg-white text-black" : "bg-white/10 text-white hover:bg-white/20"
                              }`}
                              style={{ fontFamily: "var(--font-normal-text)" }}
                            >
                              {option.quality || "—"}
                            </button>
                          )
                        })}
                      </div>
                    </motion.div>
                  )}
                </AnimatePresence>
              </div>
            )}
          </div>
        </div>

        <div className="flex items-center gap-2">
          {!useIframe && (
            <>
              <button
                aria-label={isPlaying ? "إيقاف" : "تشغيل"}
                onClick={handlePlayPause}
                className="p-2 rounded-full bg-white/10 text-white hover:bg-white/20 transition"
              >
                {isPlaying ? <Pause className="w-5 h-5" /> : <Play className="w-5 h-5" />}
              </button>
              <button
                aria-label={muted ? "إلغاء كتم الصوت" : "كتم الصوت"}
                onClick={handleMute}
                className="p-2 rounded-full bg-white/10 text-white hover:bg-white/20 transition"
              >
                {muted ? <VolumeX className="w-5 h-5" /> : <Volume2 className="w-5 h-5" />}
              </button>
            </>
          )}
          <button
            aria-label="ملء الشاشة"
            onClick={handleFullscreen}
            className="p-2 rounded-full bg-white/10 text-white hover:bg-white/20 transition"
          >
            <Maximize2 className="w-5 h-5" />
          </button>
        </div>
      </div>

      <div className="flex flex-wrap items-center gap-2 border-t border-white/10 bg-black/50 px-4 py-3 text-xs text-gray-300" style={{ fontFamily: "var(--font-normal-text)" }}>
        <span>السيرفر:</span>
        <span className="text-white font-semibold">{selectedServerName || "—"}</span>
        {selectedQuality && (
          <>
            <span className="text-gray-500">•</span>
            <span>الجودة {selectedQuality}</span>
          </>
        )}
        {useIframe && (
          <>
            <span className="text-gray-500">•</span>
            <span>مشغل خارجي</span>
          </>
        )}
      </div>
    </div>
  )
}
