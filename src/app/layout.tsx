import type React from "react"
import type { Metadata } from "next"
import localFont from "next/font/local"
import "./globals.css"
import Header from "@/components/Header"

const bigTitles = localFont({
  src: "../../public/fonts/big-titles-stylish.otf",
  variable: "--font-big-titles",
})

const normalText = localFont({
  src: "../../public/fonts/normal_text.ttf",
  variable: "--font-normal-text",
})

const headerFont = localFont({
  src: "../../public/fonts/header.ttf",
  variable: "--font-header",
})

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
        className={`${bigTitles.variable} ${normalText.variable} ${headerFont.variable} antialiased bg-black text-white min-h-screen flex flex-col`}
        style={{ fontFamily: 'var(--font-normal-text)' }}
      >
        <Header />
        {children}
      </body>
    </html>
  )
}
