"use client"

import type React from "react"

import { useState, useEffect, Suspense } from "react"
import Image from "next/image"
import Link from "next/link"
import { useRouter, usePathname, useSearchParams } from "next/navigation"
import { Search } from "lucide-react"

function HeaderContent() {
  const [searchQuery, setSearchQuery] = useState("")
  const [searchOpen, setSearchOpen] = useState(false)
  const [hasScroll, setHasScroll] = useState(false)
  const router = useRouter()
  const pathname = usePathname()
  const searchParams = useSearchParams()
  const typeParam = searchParams.get("type")

  useEffect(() => {
    const handleScroll = () => {
      setHasScroll(window.scrollY > 10)
    }
    window.addEventListener("scroll", handleScroll)
    return () => window.removeEventListener("scroll", handleScroll)
  }, [])

  const handleSearch = (e: React.FormEvent) => {
    e.preventDefault()
    if (searchQuery.trim()) {
      router.push(`/search?q=${encodeURIComponent(searchQuery.trim())}`)
      setSearchQuery("")
      setSearchOpen(false)
    }
  }

  // Check if current path matches
  const isActive = (path: string) => {
    if (path === "/") return pathname === "/"
    return pathname.startsWith(path)
  }

  return (
    <header
      className={`fixed top-0 left-0 right-0 z-[100] h-[70px] transition-all duration-300 ${
        hasScroll ? "bg-black/80 backdrop-blur-md" : "bg-transparent"
      }`}
    >
      <div className="relative px-4 md:px-12 lg:px-16 xl:px-24 h-full">
        <div className="flex items-center justify-between h-full">
          {/* Logo */}
          <Link href="/" className="flex items-center">
            <Image
              src="/logo-wide.png"
              alt="WitAnime Logo"
              width={110}
              height={30}
              className="h-[30px] w-auto"
              priority
            />
          </Link>

          {/* Navigation - Centered */}
          <nav
            className="hidden md:flex items-center gap-2 text-sm absolute left-1/2 -translate-x-1/2"
            style={{ fontFamily: "var(--font-normal-text)" }}
          >
            <Link
              href="/"
              className={`relative px-4 py-2 font-semibold rounded-full transition-all duration-200 ${
                pathname === "/" && !hasScroll ? "bg-white text-black shadow-lg" : "text-gray-300 hover:text-white"
              }`}
            >
              الرئيسية
            </Link>
            <Link
              href="/discover"
              className={`relative px-4 py-2 font-semibold rounded-full transition-all duration-200 ${
                pathname === "/discover" && !hasScroll ? "bg-white text-black shadow-lg" : "text-gray-300 hover:text-white"
              }`}
            >
              استكشف
            </Link>
            <Link
              href="/schedule"
              className={`relative px-4 py-2 font-semibold rounded-full transition-all duration-200 ${
                pathname === "/schedule" && !hasScroll ? "bg-white text-black shadow-lg" : "text-gray-300 hover:text-white"
              }`}
            >
              مواعيد
            </Link>
          </nav>

          {/* Right Side - Search */}
          <div className="flex items-center">
            {searchOpen ? (
              <form onSubmit={handleSearch} className="flex items-center relative">
                <input
                  type="text"
                  value={searchQuery}
                  onChange={(e) => setSearchQuery(e.target.value)}
                  placeholder="العناوين، الأشخاص، الأنواع"
                  autoFocus
                  className="bg-black/90 border border-white/30 text-white px-4 py-1.5 pr-10 text-sm outline-none w-64 transition-all"
                  style={{ fontFamily: "var(--font-normal-text)" }}
                  onBlur={() => {
                    if (!searchQuery.trim()) {
                      setTimeout(() => setSearchOpen(false), 200)
                    }
                  }}
                />
                <Search className="w-4 h-4 text-white absolute right-3 pointer-events-none" />
              </form>
            ) : (
              <button
                onClick={() => setSearchOpen(true)}
                className="p-2 text-white hover:text-gray-400 transition-colors duration-200"
                aria-label="Search"
              >
                <Search className="w-5 h-5" />
              </button>
            )}
          </div>
        </div>
      </div>
    </header>
  )
}

export default function Header() {
  return (
    <Suspense fallback={
      <header className="fixed top-0 left-0 right-0 z-[100] h-[70px] bg-transparent">
        <div className="relative px-4 md:px-12 lg:px-16 xl:px-24 h-full">
          <div className="flex items-center justify-between h-full">
            <Link href="/" className="flex items-center">
              <Image
                src="/logo-wide.png"
                alt="WitAnime Logo"
                width={110}
                height={30}
                className="h-[30px] w-auto"
                priority
              />
            </Link>
          </div>
        </div>
      </header>
    }>
      <HeaderContent />
    </Suspense>
  )
}
