import Link from 'next/link'

export default function NotFound() {
  return (
    <div className="min-h-screen bg-gradient-to-br from-gray-900 via-purple-900 to-violet-900 text-white flex items-center justify-center">
      <div className="text-center">
        <h1 className="text-6xl font-bold mb-4">404</h1>
        <h2 className="text-2xl font-semibold mb-4">Anime Not Found</h2>
        <p className="text-gray-300 mb-8 max-w-md">
          The anime you're looking for doesn't exist or has been moved. 
          Let's get you back to watching some great anime!
        </p>
        <div className="space-x-4">
          <Link 
            href="/" 
            className="inline-block bg-purple-600 hover:bg-purple-700 px-6 py-3 rounded-lg transition-colors"
          >
            Go Home
          </Link>
          <Link 
            href="/browse" 
            className="inline-block bg-gray-600 hover:bg-gray-700 px-6 py-3 rounded-lg transition-colors"
          >
            Browse Anime
          </Link>
        </div>
      </div>
    </div>
  )
}
