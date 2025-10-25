"use client"

import { useEffect, useMemo, useRef, useState } from "react"
import {
  Pause,
  Play,
  Volume2,
  VolumeX,
  Maximize,
  Settings,
  SkipBack,
  SkipForward,
  Loader2,
  ArrowLeft,
} from "lucide-react"
import { motion, AnimatePresence } from "framer-motion"
import { useRouter } from "next/navigation"

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
  const [showControls, setShowControls] = useState<boolean>(true)
  const [progress, setProgress] = useState<number>(0)
  const [duration, setDuration] = useState<number>(0)
  const [volume, setVolume] = useState<number>(100)
  const [buffered, setBuffered] = useState<number>(0)
  const [showEpisodeMenu, setShowEpisodeMenu] = useState<boolean>(false)
  const [showNextEpisode, setShowNextEpisode] = useState<boolean>(false)
  const [centerIndicator, setCenterIndicator] = useState<"play" | "pause" | null>(null)
  const [keyFeedback, setKeyFeedback] = useState<
    | { type: "seek"; direction: "forward" | "backward"; amount: number }
    | { type: "volume"; level: number }
    | null
  >(null)
  const controlsTimeoutRef = useRef<NodeJS.Timeout | null>(null)
  const centerTimeoutRef = useRef<NodeJS.Timeout | null>(null)
  const router = useRouter()

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
      
      // Auto-fullscreen after a short delay
      setTimeout(() => {
        const el = document.getElementById("player-container")
        if (el && !document.fullscreenElement) {
          el.requestFullscreen().catch(() => {})
        }
      }, 500)
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
      v.play().then(() => {
        setIsPlaying(true)
        showCenterIndicator("play")
      }).catch(() => {})
    } else {
      v.pause()
      setIsPlaying(false)
      showCenterIndicator("pause", { persist: true })
    }
    showControlsTemporarily()
  }

  function showControlsTemporarily() {
    setShowControls(true)
    if (controlsTimeoutRef.current) {
      clearTimeout(controlsTimeoutRef.current)
    }
    controlsTimeoutRef.current = setTimeout(() => {
      if (isPlaying) {
        setShowControls(false)
      }
    }, 3000)
  }

  function handleMouseMove() {
    showControlsTemporarily()
  }

  function handleVideoClick() {
    handlePlayPause()
  }

  function handleSkip(seconds: number) {
    const v = videoRef.current
    if (!v) return
    v.currentTime = Math.max(0, Math.min(v.duration, v.currentTime + seconds))
    showControlsTemporarily()
  }

  function handleProgressChange(e: React.ChangeEvent<HTMLInputElement>) {
    const v = videoRef.current
    if (!v) return
    const newTime = (parseFloat(e.target.value) / 100) * v.duration
    v.currentTime = newTime
    setProgress(parseFloat(e.target.value))
  }

  function formatTime(seconds: number): string {
    if (isNaN(seconds)) return '0:00'
    const mins = Math.floor(seconds / 60)
    const secs = Math.floor(seconds % 60)
    return `${mins}:${secs.toString().padStart(2, '0')}`
  }

  function handleMute() {
    const v = videoRef.current
    if (!v) return
    v.muted = !v.muted
    setMuted(v.muted)
  }

  function handleVolumeChange(e: React.ChangeEvent<HTMLInputElement>) {
    const v = videoRef.current
    if (!v) return
    const newVolume = parseFloat(e.target.value)
    v.volume = newVolume / 100
    setVolume(newVolume)
    if (newVolume === 0) {
      setMuted(true)
      v.muted = true
    } else if (muted) {
      setMuted(false)
      v.muted = false
    }
  }

  function changeVolumeBy(delta: number) {
    const v = videoRef.current
    if (!v) return
    const newVolume = Math.max(0, Math.min(100, volume + delta))
    v.volume = newVolume / 100
    v.muted = newVolume === 0
    setVolume(newVolume)
    setMuted(v.muted)
    setKeyFeedback({ type: "volume", level: newVolume })
    showControlsTemporarily()
    setTimeout(() => setKeyFeedback(null), 600)
  }

  function showCenterIndicator(type: "play" | "pause", { persist = false }: { persist?: boolean } = {}) {
    if (centerTimeoutRef.current) {
      clearTimeout(centerTimeoutRef.current)
      centerTimeoutRef.current = null
    }
    setCenterIndicator(type)
    if (!persist) {
      centerTimeoutRef.current = setTimeout(() => {
        setCenterIndicator(null)
        centerTimeoutRef.current = null
      }, 500)
    }
  }

  function goToNextEpisode() {
    const currentIndex = episodes.findIndex(ep => parseEpisodeValue(ep) === selectedEpisode)
    if (currentIndex !== -1 && currentIndex < episodes.length - 1) {
      const nextEp = parseEpisodeValue(episodes[currentIndex + 1])
      if (nextEp) {
        setSelectedEpisode(nextEp)
        setShowNextEpisode(false)
      }
    }
  }

  function handleFullscreen() {
    const el = document.getElementById("player-container")
    if (!el) return
    if (document.fullscreenElement) document.exitFullscreen().catch(() => {})
    else el.requestFullscreen().catch(() => {})
    showControlsTemporarily()
  }

  useEffect(() => {
    const v = videoRef.current
    if (!v) return

    const updateProgress = () => {
      if (v.duration) {
        const currentProgress = (v.currentTime / v.duration) * 100
        setProgress(currentProgress)
        setDuration(v.duration)
        if (v.buffered?.length) {
          const bufferedEnd = v.buffered.end(v.buffered.length - 1)
          const bufferedPercent = Math.min((bufferedEnd / v.duration) * 100, 100)
          setBuffered(isFinite(bufferedPercent) ? bufferedPercent : 0)
        }

        // Show next episode button at 95% or 40 seconds left
        const timeLeft = v.duration - v.currentTime
        if ((currentProgress >= 95 || timeLeft <= 40) && !showNextEpisode) {
          const currentIndex = episodes.findIndex(ep => parseEpisodeValue(ep) === selectedEpisode)
          if (currentIndex !== -1 && currentIndex < episodes.length - 1) {
            setShowNextEpisode(true)
          }
        }
      }
    }

    v.addEventListener('timeupdate', updateProgress)
    v.addEventListener('loadedmetadata', updateProgress)

    return () => {
      v.removeEventListener('timeupdate', updateProgress)
      v.removeEventListener('loadedmetadata', updateProgress)
    }
  }, [currentSrc, selectedEpisode, episodes, showNextEpisode])

  useEffect(() => {
    const handleKeyPress = (e: KeyboardEvent) => {
      if (e.code === 'Space') {
        e.preventDefault()
        handlePlayPause()
      } else if (e.code === 'ArrowLeft') {
        e.preventDefault()
        handleSkip(-10)
        setKeyFeedback({ type: "seek", direction: "backward", amount: 10 })
        setTimeout(() => setKeyFeedback(null), 600)
      } else if (e.code === 'ArrowRight') {
        e.preventDefault()
        handleSkip(10)
        setKeyFeedback({ type: "seek", direction: "forward", amount: 10 })
        setTimeout(() => setKeyFeedback(null), 600)
      } else if (e.code === 'ArrowUp') {
        e.preventDefault()
        changeVolumeBy(5)
      } else if (e.code === 'ArrowDown') {
        e.preventDefault()
        changeVolumeBy(-5)
      } else if (e.code === 'KeyF') {
        e.preventDefault()
        handleFullscreen()
      } else if (e.code === 'KeyM') {
        e.preventDefault()
        handleMute()
      }
    }

    window.addEventListener('keydown', handleKeyPress)
    return () => {
      window.removeEventListener('keydown', handleKeyPress)
      if (controlsTimeoutRef.current) {
        clearTimeout(controlsTimeoutRef.current)
      }
      if (centerTimeoutRef.current) {
        clearTimeout(centerTimeoutRef.current)
      }
    }
  }, [isPlaying, volume])

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
  const currentTime = videoRef.current?.currentTime || 0

  return (
    <div
      id="player-container"
      className="relative bg-black w-full h-full overflow-hidden"
      onMouseMove={handleMouseMove}
      onMouseLeave={() => isPlaying && setShowControls(false)}
    >
      <div className="relative w-full h-full bg-black" dir="ltr">
        {!useIframe ? (
          currentSrc ? (
            <video
              ref={videoRef}
              className="w-full h-full object-contain cursor-pointer"
              src={currentSrc}
              controls={false}
              onPlay={() => setIsPlaying(true)}
              onPause={() => setIsPlaying(false)}
              onClick={handleVideoClick}
            />
          ) : (
            <div className="w-full h-full flex items-center justify-center bg-black">
              <Loader2 className="w-16 h-16 text-white/50 animate-spin" />
            </div>
          )
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
          <div className="absolute inset-0 flex items-center justify-center bg-black/90">
            <div className="text-center">
              <Loader2 className="w-16 h-16 text-white/50 animate-spin mx-auto mb-4" />
              <p className="text-white/70 text-sm" style={{ fontFamily: "var(--font-normal-text)" }}>
                اختر حلقة لبدء المشاهدة
              </p>
            </div>
          </div>
        )}

        {loadingServers && (
          <div className="absolute inset-0 flex items-center justify-center bg-black/80 z-40">
            <Loader2 className="w-16 h-16 text-white animate-spin" />
          </div>
        )}

        {/* Netflix-style Controls Overlay */}
        <AnimatePresence>
          {showControls && !useIframe && currentSrc && (
            <motion.div
              initial={{ opacity: 0 }}
              animate={{ opacity: 1 }}
              exit={{ opacity: 0 }}
              className="absolute inset-0 z-30 pointer-events-none"
            >
              {/* Top Gradient */}
              <div className="absolute top-0 left-0 right-0 h-32 bg-gradient-to-b from-black/80 to-transparent pointer-events-auto">
                <div className="p-4 flex items-start justify-between gap-4">
                  <button
                    onClick={() => router.back()}
                    className="p-2 hover:bg-white/10 rounded-full transition-colors flex-shrink-0"
                    aria-label="العودة"
                  >
                    <ArrowLeft className="w-5 h-5 text-white" />
                  </button>
                  <div className="flex-1 min-w-0">
                    <h2 className="text-base md:text-xl font-bold text-white mb-1 truncate" dir="ltr" style={{ fontFamily: 'var(--font-header)' }}>
                      {title || 'مشغل الفيديو'}
                    </h2>
                    {selectedQuality && (
                      <div className="text-xs md:text-sm text-white/70">
                        {selectedQuality}
                      </div>
                    )}
                  </div>
                </div>
              </div>

              {/* Center Play/Pause Button */}
              <AnimatePresence>
                {centerIndicator && (
                  <motion.div
                    key={centerIndicator}
                    initial={{ scale: 0.8, opacity: 0 }}
                    animate={{ scale: 1, opacity: 1 }}
                    exit={{ scale: 0.8, opacity: 0 }}
                    className="absolute inset-0 flex items-center justify-center pointer-events-none"
                  >
                    <div className="w-20 h-20 rounded-full bg-white/20 backdrop-blur-sm flex items-center justify-center">
                      {centerIndicator === "pause" ? (
                        <Pause className="w-10 h-10 text-white" />
                      ) : (
                        <Play className="w-10 h-10 text-white ml-1" fill="white" />
                      )}
                    </div>
                  </motion.div>
                )}
              </AnimatePresence>

              {/* Bottom Controls */}
              <div className="absolute bottom-0 left-0 right-0 bg-gradient-to-t from-black/90 via-black/60 to-transparent pointer-events-auto">
                {/* Progress Bar */}
                <div className="px-4 pb-2 group">
                  <input
                    type="range"
                    min="0"
                    max="100"
                    value={progress}
                    onChange={handleProgressChange}
                    className="w-full h-1 group-hover:h-1.5 rounded-lg appearance-none cursor-pointer transition-all [&::-webkit-slider-thumb]:appearance-none [&::-webkit-slider-thumb]:w-3 [&::-webkit-slider-thumb]:h-3 [&::-webkit-slider-thumb]:rounded-full [&::-webkit-slider-thumb]:bg-white [&::-webkit-slider-thumb]:opacity-0 group-hover:[&::-webkit-slider-thumb]:opacity-100 [&::-webkit-slider-thumb]:transition-all [&::-webkit-slider-thumb]:shadow-lg"
                    style={{
                      background: `linear-gradient(to right,
                        rgba(255,255,255,0.9) 0%,
                        rgba(255,255,255,0.9) ${progress}%,
                        rgba(200,200,200,0.7) ${progress}%,
                        rgba(200,200,200,0.7) ${buffered}%,
                        rgba(90,90,90,0.7) ${buffered}%,
                        rgba(90,90,90,0.7) 100%)`
                    }}
                  />
                </div>

                {/* Control Buttons */}
                <div className="px-4 pb-4 flex items-center justify-between gap-4" dir="ltr">
                  {/* Playback Controls */}
                  <div className="flex items-center gap-3">
                    <button
                      onClick={handlePlayPause}
                      className="p-2 hover:bg-white/10 rounded-full transition-colors"
                    >
                      {isPlaying ? <Pause className="w-6 h-6 text-white" /> : <Play className="w-6 h-6 text-white" />}
                    </button>

                    <span className="text-white text-sm hidden md:block">
                      {formatTime(currentTime)} / {formatTime(duration)}
                    </span>

                    {/* Volume Control */}
                    <div className="flex items-center gap-2 group/volume relative">
                      <button
                        onClick={handleMute}
                        className="p-2 hover:bg-white/10 rounded-full transition-colors"
                      >
                        {muted || volume === 0 ? <VolumeX className="w-5 h-5 text-white" /> : <Volume2 className="w-5 h-5 text-white" />}
                      </button>
                      <div className="absolute bottom-full left-1/2 -translate-x-1/2 mb-3 flex h-24 w-10 origin-bottom scale-y-0 opacity-0 transition-all duration-200 group-hover/volume:scale-y-100 group-hover/volume:opacity-100">
                        <div className="relative flex h-full w-full items-center justify-center">
                          <input
                            type="range"
                            min="0"
                            max="100"
                            value={volume}
                            onChange={handleVolumeChange}
                            className="h-1.5 w-24 -rotate-90 origin-center appearance-none cursor-pointer [&::-webkit-slider-thumb]:appearance-none [&::-webkit-slider-thumb]:w-3 [&::-webkit-slider-thumb]:h-3 [&::-webkit-slider-thumb]:rounded-full [&::-webkit-slider-thumb]:bg-white"
                            style={{
                              background: `linear-gradient(to right, white ${volume}%, rgba(255,255,255,0.3) ${volume}%)`
                            }}
                          />
                        </div>
                      </div>
                    </div>

                  </div>

                  {/* Episode & Quality Controls */}
                  <div className="flex items-center gap-2 md:gap-3" dir="rtl">
                    <div className="relative">
                      <button
                        onClick={() => {
                          setShowEpisodeMenu(!showEpisodeMenu)
                          setShowQualityMenu(false)
                        }}
                        className="px-3 py-2 bg-white/10 hover:bg-white/20 rounded-lg text-white text-sm font-medium"
                        style={{ fontFamily: 'var(--font-header)' }}
                        dir="rtl"
                      >
                        الحلقة {selectedEpisode}
                      </button>
                      <AnimatePresence>
                        {showEpisodeMenu && (
                          <motion.div
                            initial={{ opacity: 0, x: -10 }}
                            animate={{ opacity: 1, x: 0 }}
                            exit={{ opacity: 0, x: -10 }}
                            className="absolute bottom-12 right-0 w-64 max-h-96 overflow-y-auto rounded-lg bg-black/95 backdrop-blur-xl border border-white/20 shadow-2xl"
                            dir="rtl"
                          >
                            <div className="p-2">
                              <div className="text-xs text-white/50 px-2 py-2 mb-1 font-semibold" style={{ fontFamily: 'var(--font-header)' }}>الحلقات</div>
                              <div className="space-y-1">
                                {episodes.map((episode, index) => {
                                  const value = parseEpisodeValue(episode)
                                  if (!value) return null
                                  const isActive = value === selectedEpisode
                                  return (
                                    <button
                                      key={`${value}-${index}`}
                                      onClick={() => {
                                        setSelectedEpisode(value)
                                        setShowEpisodeMenu(false)
                                      }}
                                      className={`w-full text-right px-3 py-2.5 rounded text-sm transition-colors ${
                                        isActive ? 'bg-white/20 text-white font-bold' : 'text-white hover:bg-white/10'
                                      }`}
                                      style={{ fontFamily: 'var(--font-header)' }}
                                    >
                                      الحلقة {value}
                                    </button>
                                  )
                                })}
                              </div>
                            </div>
                          </motion.div>
                        )}
                      </AnimatePresence>
                    </div>

                    {hasMediafire && (
                      <div className="relative">
                        <button
                          onClick={() => {
                            setShowQualityMenu(!showQualityMenu)
                            setShowEpisodeMenu(false)
                          }}
                          className="p-2 hover:bg-white/10 rounded-full transition-colors"
                        >
                          <Settings className="w-5 h-5 text-white" />
                        </button>
                        <AnimatePresence>
                          {showQualityMenu && (
                            <motion.div
                              initial={{ opacity: 0, y: 10 }}
                              animate={{ opacity: 1, y: 0 }}
                              exit={{ opacity: 0, y: 10 }}
                              className="absolute bottom-12 right-0 w-40 rounded-lg bg-black/95 backdrop-blur-xl border border-white/20 p-2 shadow-2xl"
                              dir="rtl"
                            >
                              <div className="text-xs text-white/50 px-2 py-1 mb-1">الجودة</div>
                              {mediafireOptions.map((option, index) => {
                                const isActive = selectedQuality === option.quality
                                return (
                                  <button
                                    key={`${option.quality}-${index}`}
                                    onClick={() => onSelectQuality(option)}
                                    className={`w-full text-right px-3 py-2 rounded text-sm transition-colors ${
                                      isActive ? 'bg-white/20 text-white font-bold' : 'text-white hover:bg-white/10'
                                    }`}
                                  >
                                    {option.quality || '—'}
                                  </button>
                                )
                              })}
                            </motion.div>
                          )}
                        </AnimatePresence>
                      </div>
                    )}

                    <button
                      onClick={handleFullscreen}
                      className="p-2 hover:bg-white/10 rounded-full transition-colors"
                    >
                      <Maximize className="w-5 h-5 text-white" />
                    </button>
                  </div>
                </div>
              </div>
            </motion.div>
          )}
        </AnimatePresence>

        {/* Keyboard feedback */}
        <AnimatePresence>
          {keyFeedback && (
            <motion.div
              initial={{ opacity: 0, scale: 0.9 }}
              animate={{ opacity: 1, scale: 1 }}
              exit={{ opacity: 0, scale: 0.9 }}
              className="absolute bottom-36 left-1/2 -translate-x-1/2 z-40"
            >
              <div className="flex items-center gap-3 px-5 py-3 rounded-full bg-black/80 border border-white/10 shadow-2xl">
                {keyFeedback.type === "seek" ? (
                  <>
                    {keyFeedback.direction === "forward" ? (
                      <SkipForward className="w-6 h-6 text-white" />
                    ) : (
                      <SkipBack className="w-6 h-6 text-white" />
                    )}
                    <span className="text-white text-sm">{keyFeedback.amount} ثانية</span>
                  </>
                ) : (
                  <>
                    <Volume2 className="w-6 h-6 text-white" />
                    <span className="text-white text-sm">الصوت {Math.round(keyFeedback.level)}%</span>
                  </>
                )}
              </div>
            </motion.div>
          )}
        </AnimatePresence>

        {/* Next Episode Prompt */}
        <AnimatePresence>
          {showNextEpisode && (
            <motion.div
              initial={{ opacity: 0, y: 20 }}
              animate={{ opacity: 1, y: 0 }}
              exit={{ opacity: 0, y: 20 }}
              className="absolute bottom-24 right-8 z-40"
            >
              <div className="bg-black/90 backdrop-blur-xl border border-white/20 rounded-lg p-4 shadow-2xl">
                <p className="text-white text-sm mb-3" style={{ fontFamily: 'var(--font-normal-text)' }}>
                  الحلقة التالية
                </p>
                <div className="flex gap-2">
                  <button
                    onClick={goToNextEpisode}
                    className="px-4 py-2 bg-red-600 hover:bg-red-700 text-white rounded-lg transition-colors text-sm font-medium"
                    style={{ fontFamily: 'var(--font-header)' }}
                  >
                    تشغيل الآن
                  </button>
                  <button
                    onClick={() => setShowNextEpisode(false)}
                    className="px-4 py-2 bg-white/10 hover:bg-white/20 text-white rounded-lg transition-colors text-sm"
                  >
                    إلغاء
                  </button>
                </div>
              </div>
            </motion.div>
          )}
        </AnimatePresence>
      </div>

      {/* Mobile Episode Selector (Outside Video) */}
      <div className="md:hidden bg-black border-t border-white/10 px-4 py-3">
        <select
          className="w-full bg-white/5 text-white px-4 py-3 rounded-lg text-sm"
          value={selectedEpisode}
          onChange={(e) => setSelectedEpisode(e.target.value)}
          disabled={episodes.length === 0}
          style={{ fontFamily: 'var(--font-normal-text)' }}
        >
          {episodes.map((episode, index) => {
            const value = parseEpisodeValue(episode)
            if (!value) return null
            return (
              <option key={`${value}-${index}`} value={value} className="bg-black">
                الحلقة {value}
              </option>
            )
          })}
        </select>
      </div>
    </div>
  )
}
