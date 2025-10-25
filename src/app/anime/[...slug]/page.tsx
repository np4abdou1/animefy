// Simplified catch-all route for Cloudflare Pages
'use client'

import { notFound, redirect } from "next/navigation"
import { useParams, useSearchParams } from "next/navigation"
import { useEffect } from "react"

export default function AnimeCatchAllPage() {
  const params = useParams()
  const searchParams = useSearchParams()
  
  const slugArray = params?.slug as string[]
  const name = searchParams?.get('name')
  const type = searchParams?.get('type')

  useEffect(() => {
    if (!slugArray || slugArray.length === 0) {
      notFound()
      return
    }

    // Handle different catch-all patterns
    if (slugArray.length === 1) {
      // Single slug - redirect to main anime route
      const slug = slugArray[0]
      const queryParams = new URLSearchParams()
      if (name) queryParams.set('name', name)
      if (type) queryParams.set('type', type)
      
      const queryString = queryParams.toString()
      const redirectUrl = `/anime/${slug}${queryString ? `?${queryString}` : ''}`
      
      window.location.href = redirectUrl
      return
    }

    if (slugArray.length === 3 && slugArray[1] === 'watch') {
      // Watch route pattern: /anime/[slug]/watch/[episode]
      const slug = slugArray[0]
      const episode = slugArray[2]
      
      const queryParams = new URLSearchParams()
      if (name) queryParams.set('name', name)
      if (type) queryParams.set('type', type)
      
      const queryString = queryParams.toString()
      const redirectUrl = `/anime/${slug}/watch/${episode}${queryString ? `?${queryString}` : ''}`
      
      window.location.href = redirectUrl
      return
    }

    // For any other pattern, show not found
    console.log("AnimeCatchAllPage - Unhandled slug pattern:", slugArray)
    notFound()
  }, [slugArray, name, type])

  // Show loading while redirecting
  return (
    <div className="min-h-screen bg-gradient-to-br from-gray-900 via-purple-900 to-violet-900 text-white flex items-center justify-center">
      <div className="text-center">
        <div className="animate-spin rounded-full h-12 w-12 border-b-2 border-purple-500 mx-auto mb-4"></div>
        <h1 className="text-2xl font-bold">Redirecting...</h1>
      </div>
    </div>
  )
}
