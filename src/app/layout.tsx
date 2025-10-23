import type React from "react"
import type { Metadata } from "next"
import "./globals.css"
import Header from "@/components/Header"

// Remove Google Fonts import to avoid build failures in restricted environments
// Custom fonts are loaded via CSS from /public/fonts/
// const geistSans = Geist({
//   variable: "--font-geist-sans",
//   subsets: ["latin"],
// })
// 
// const geistMono = Geist_Mono({
//   variable: "--font-geist-mono",
//   subsets: ["latin"],
// })

export const metadata: Metadata = {
  title: "WitAnime - Anime Streaming",
  description: "Watch your favorite anime for free with beautiful streaming experience",
}

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode
}>) {
  return (
    <html lang="ar" dir="rtl">
      <body
        className="antialiased bg-black text-white min-h-screen flex flex-col"
      >
        <Header />
        {children}
      </body>
    </html>
  )
}
