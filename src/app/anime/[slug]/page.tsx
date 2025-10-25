// Client-side compatible version for Cloudflare Pages
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
  }
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

        // Check if slug is an AnimeId (numeric) or a title slug
        const isAnimeId = /^\d+$/.test(slug)
        
        // CRITICAL: Always use 'name' query param if available (most reliable)
        // Only fall back to slug conversion if name is missing
        const searchTitle = name || (isAnimeId ? "" : slugToTitle(slug))

        console.log("AnimePage - slug:", slug, "searchTitle:", searchTitle, "type:", type)

        if (!searchTitle && isAnimeId) {
          throw new Error("No title available for numeric ID")
        }

        // Try to fetch anime details
        const response = await fetch(`/api/anime/details?title=${encodeURIComponent(searchTitle)}&type=${type}`)

        if (!response.ok) {
          throw new Error(`Failed to fetch anime details: ${response.status}`)
        }

        const data = await response.json()

        if (!data || data.error) {
          throw new Error(data?.error || "No anime data found")
        }

        setAnimeData(data)
      } catch (err) {
        console.error("AnimePage - Error fetching anime data:", err)
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
    const searchTitle = name || (!/^\d+$/.test(slug) ? slugToTitle(slug) : "")
    
    return (
      <div className="min-h-screen bg-gradient-to-br from-gray-900 via-purple-900 to-violet-900 text-white">
        <div className="container mx-auto px-4 py-8">
          <div className="text-center">
            <h1 className="text-4xl font-bold mb-4">Anime Not Found</h1>
            <p className="text-gray-300 mb-6">
              We couldn't find the anime "{searchTitle}". This might be a temporary issue.
            </p>
            <div className="space-y-4">
              <Link 
                href="/" 
                className="inline-block bg-purple-600 hover:bg-purple-700 px-6 py-3 rounded-lg transition-colors"
              >
                Go Home
              </Link>
              <div className="text-sm text-gray-400">
                <p>Searched for: {searchTitle}</p>
                <p>Type: {type}</p>
                <p>Slug: {slug}</p>
                {error && <p>Error: {error}</p>}
              </div>
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
              <img
                src={`${THUMBNAILS_BASE}${anime.thumbnail}`}
                alt={anime.title}
                className="w-full rounded-lg shadow-2xl"
                onError={(e) => {
                  const target = e.target as HTMLImageElement
                  target.src = "/placeholder-anime.jpg"
                }}
              />
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

            {/* Watch Button */}
            <div className="mt-8">
              <Link
                href={`/anime/${slug}/watch/1?name=${encodeURIComponent(name || anime.title)}&type=${type}`}
                className="inline-block bg-gradient-to-r from-purple-600 to-pink-600 hover:from-purple-700 hover:to-pink-700 px-8 py-4 rounded-lg text-lg font-semibold transition-all transform hover:scale-105"
              >
                Watch Now
              </Link>
            </div>
          </div>
        </div>
      </div>
    </div>
  )
}
