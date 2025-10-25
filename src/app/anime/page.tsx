"use client"

export const runtime = "edge"

import { useRouter } from "next/navigation"
import { useEffect } from "react"

/**
 * Anime index page - redirects to fallback or browse
 * This page handles the base /anime route
 */
export default function AnimePage() {
  const router = useRouter()

  useEffect(() => {
    // Redirect to the fallback page which shows anime list
    router.push("/anime/fallback")
  }, [router])

  return (
    <div className="flex items-center justify-center min-h-screen">
      <div className="text-center">
        <p className="text-lg text-gray-600">Loading anime content...</p>
      </div>
    </div>
  )
}
