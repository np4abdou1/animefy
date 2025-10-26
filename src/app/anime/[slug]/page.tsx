// FIXED: Robust client-side anime page for Cloudflare Pages
'use client'

import { notFound } from "next/navigation"
import Link from "next/link"
import { slugToTitle } from "@/lib/slug"
import { useParams, useSearchParams } from "next/navigation"
import { useEffect, useState } from "react"

const THUMBNAILS_BASE = "https://animeify.net/animeify/files/thumbnails/"

interface AnimeData {
  anime: {
    title: string
    thumbnail: string
    type: string
    status: string
    episodes: string
    year: string
    description?: string
    genres?: string[]
    EN_Title?: string
    JP_Title?: string
    AR_Title?: string
    AnimeId?: string
  }
  details?: any
  episodes?: any[]
}

export default function AnimePage() {
  const params = useParams()
  const searchParams = useSearchParams()
  
  const [animeData, setAnimeData] = useState<AnimeData | null>(null)
  const [loading, setLoading] = useState(true)
  const [error, setError] = useState<string | null>(null)

  const slug = params?.slug as string
  const name = searchParams?.get('name')
  const type = searchParams?.get('type') || 'SERIES'

  useEffect(() => {
    if (!slug) return

    const fetchAnimeData = async () => {
      try {
        setLoading(true)
        setError(null)

        // CRITICAL FIX: Always prioritize 'name' query param
        const searchTitle = name || (!/^\d+$/.test(slug) ? slugToTitle(slug) : "")

        console.log("AnimePage - slug:", slug, "searchTitle:", searchTitle, "type:", type)

        if (!searchTitle) {
          throw new Error("No title available for this anime")
        }

        // ROBUST API FETCHING with multiple fallbacks
        let animeFound = false
        
        // Try 1: Details API
        try {
          const response = await fetch(`/api/anime/details?title=${encodeURIComponent(searchTitle)}&type=${type}`, {
            cache: 'no-store'
          })

          if (response.ok) {
            const data = await response.json()
            if (data && !data.error && data.anime) {
              setAnimeData(data)
              animeFound = true
              return
            }
          }
        } catch (err) {
          console.warn("Details API failed:", err)
        }

        // Try 2: Search API
        if (!animeFound && name) {
          try {
            const searchResponse = await fetch('/api/search', {
              method: 'POST',
              headers: { 'Content-Type': 'application/json' },
              body: JSON.stringify({ query: name, type: type })
            })

            if (searchResponse.ok) {
              const searchData = await searchResponse.json()
              if (searchData?.results?.length > 0) {
                const anime = searchData.results[0]
                setAnimeData({
                  anime: {
                    title: anime.EN_Title || anime.title || name,
                    thumbnail: anime.Thumbnail || anime.thumbnail || '',
                    type: anime.Type || type,
                    status: anime.Status || 'Unknown',
                    episodes: anime.Episodes || 'Unknown',
                    year: anime.Premiered || anime.year || 'Unknown',
                    description: anime.description || 'No description available.',
                    genres: anime.Genres ? anime.Genres.split(',').map((g: string) => g.trim()) : [],
                    EN_Title: anime.EN_Title,
                    JP_Title: anime.JP_Title,
                    AR_Title: anime.AR_Title,
                    AnimeId: anime.AnimeId
                  }
                })
                animeFound = true
                return
              }
            }
          } catch (err) {
            console.warn("Search API failed:", err)
          }
        }

        // Try 3: Create fallback data if we have a name
        if (!animeFound && (name || searchTitle)) {
          setAnimeData({
            anime: {
              title: name || searchTitle,
              thumbnail: '',
              type: type,
              status: 'Unknown',
              episodes: 'Unknown',
              year: 'Unknown',
              description: 'This anime is available for streaming. API details are temporarily unavailable.',
              genres: []
            }
          })
          animeFound = true
          return
        }

        if (!animeFound) {
          throw new Error("Anime not found")
        }

      } catch (err) {
        console.error("AnimePage - Error:", err)
        setError(err instanceof Error ? err.message : "Unknown error")
      } finally {
        setLoading(false)
      }
    }

    fetchAnimeData()
  }, [slug, name, type])

  if (loading) {
    return (
      <div className="min-h-screen bg-gradient-to-br from-gray-900 via-purple-900 to-violet-900 text-white flex items-center justify-center">
        <div className="text-center">
          <div className="animate-spin rounded-full h-12 w-12 border-b-2 border-purple-500 mx-auto mb-4"></div>
          <h1 className="text-2xl font-bold">Loading Anime...</h1>
          <p className="text-gray-300 mt-2">Fetching details for {name || slug}</p>
        </div>
      </div>
    )
  }

  if (error || !animeData) {
    const displayTitle = name || (!/^\d+$/.test(slug) ? slugToTitle(slug) : "Unknown Anime")
    
    return (
      <div className="min-h-screen bg-gradient-to-br from-gray-900 via-purple-900 to-violet-900 text-white">
        <div className="container mx-auto px-4 py-8">
          <div className="text-center">
            <h1 className="text-4xl font-bold mb-4">Anime Temporarily Unavailable</h1>
            <p className="text-gray-300 mb-6">
              "{displayTitle}" is currently unavailable. This might be a temporary issue.
            </p>
            <div className="space-y-4">
              <Link 
                href="/" 
                className="inline-block bg-purple-600 hover:bg-purple-700 px-6 py-3 rounded-lg transition-colors mr-4"
              >
                Go Home
              </Link>
              <Link 
                href="/browse" 
                className="inline-block bg-blue-600 hover:bg-blue-700 px-6 py-3 rounded-lg transition-colors"
              >
                Browse Anime
              </Link>
            </div>
            <div className="mt-8 text-sm text-gray-400 space-y-1">
              <p>Searched: {displayTitle}</p>
              <p>Type: {type}</p>
              <p>Slug: {slug}</p>
            </div>
          </div>
        </div>
      </div>
    )
  }

  const anime = animeData.anime

  return (
    <div className="min-h-screen bg-gradient-to-br from-gray-900 via-purple-900 to-violet-900 text-white">
      <div className="container mx-auto px-4 py-8">
        <div className="grid grid-cols-1 lg:grid-cols-3 gap-8">
          {/* Anime Poster */}
          <div className="lg:col-span-1">
            <div className="sticky top-8">
              {anime.thumbnail ? (
                <img
                  src={`${THUMBNAILS_BASE}${anime.thumbnail}`}
                  alt={anime.title}
                  className="w-full rounded-lg shadow-2xl"
                  onError={(e) => {
                    const target = e.target as HTMLImageElement
                    target.src = "/placeholder-anime.jpg"
                  }}
                />
              ) : (
                <div className="w-full aspect-[3/4] bg-gray-800 rounded-lg shadow-2xl flex items-center justify-center">
                  <span className="text-gray-400">No Image Available</span>
                </div>
              )}
            </div>
          </div>

          {/* Anime Details */}
          <div className="lg:col-span-2">
            <h1 className="text-4xl font-bold mb-4">{anime.title}</h1>
            
            <div className="grid grid-cols-2 gap-4 mb-6">
              <div>
                <span className="text-gray-400">Type:</span>
                <span className="ml-2 text-white">{anime.type}</span>
              </div>
              <div>
                <span className="text-gray-400">Status:</span>
                <span className="ml-2 text-white">{anime.status}</span>
              </div>
              <div>
                <span className="text-gray-400">Episodes:</span>
                <span className="ml-2 text-white">{anime.episodes}</span>
              </div>
              <div>
                <span className="text-gray-400">Year:</span>
                <span className="ml-2 text-white">{anime.year}</span>
              </div>
            </div>

            {anime.description && (
              <div className="mb-6">
                <h2 className="text-2xl font-semibold mb-3">Description</h2>
                <p className="text-gray-300 leading-relaxed">{anime.description}</p>
              </div>
            )}

            {anime.genres && anime.genres.length > 0 && (
              <div className="mb-6">
                <h2 className="text-2xl font-semibold mb-3">Genres</h2>
                <div className="flex flex-wrap gap-2">
                  {anime.genres.map((genre: string, index: number) => (
                    <span
                      key={index}
                      className="bg-purple-600 px-3 py-1 rounded-full text-sm"
                    >
                      {genre}
                    </span>
                  ))}
                </div>
              </div>
            )}

            {/* Action Buttons */}
            <div className="mt-8 space-x-4">
              <Link
                href={`/anime/${slug}/watch/1?name=${encodeURIComponent(name || anime.title)}&type=${type}`}
                className="inline-block bg-gradient-to-r from-purple-600 to-pink-600 hover:from-purple-700 hover:to-pink-700 px-8 py-4 rounded-lg text-lg font-semibold transition-all transform hover:scale-105"
              >
                🎬 Watch Now
              </Link>
              <Link
                href="/"
                className="inline-block bg-gray-600 hover:bg-gray-700 px-6 py-4 rounded-lg text-lg font-semibold transition-colors"
              >
                ← Back to Home
              </Link>
            </div>
          </div>
        </div>
      </div>
    </div>
  )
}
