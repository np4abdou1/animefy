import Link from 'next/link'
import { Suspense } from 'react'

// This page serves as a fallback for dynamic anime routes
export default function AnimeFallback() {
  return (
    <div className="min-h-screen bg-gradient-to-br from-gray-900 via-purple-900 to-violet-900 text-white">
      <div className="container mx-auto px-4 py-8">
        <div className="text-center">
          <h1 className="text-4xl font-bold mb-4">Loading Anime...</h1>
          <p className="text-gray-300 mb-6">
            We're fetching the anime details for you. This might take a moment.
          </p>
          
          <div className="animate-spin rounded-full h-12 w-12 border-b-2 border-purple-500 mx-auto mb-6"></div>
          
          <div className="space-y-4">
            <p className="text-sm text-gray-400">
              If this page doesn't load automatically, try refreshing or go back home.
            </p>
            <Link 
              href="/" 
              className="inline-block bg-purple-600 hover:bg-purple-700 px-6 py-3 rounded-lg transition-colors"
            >
              Go Home
            </Link>
          </div>
        </div>
      </div>
    </div>
  )
}
