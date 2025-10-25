export const runtime = "edge"

import { redirect } from "next/navigation"

/**
 * Anime index page - redirects to fallback or browse
 * This page handles the base /anime route
 */
export default function AnimePage() {
  // Server-side redirect - no client-side rendering needed
  redirect("/anime/fallback")
}
