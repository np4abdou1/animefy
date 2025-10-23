'use client';

import { useState, useEffect } from 'react';
import Image from 'next/image';
import Link from 'next/link';
import { ChevronLeft, ChevronRight, Play, Info } from 'lucide-react';
import { heroAnimes, type HeroAnime } from '@/config/heroAnimes';

export default function HeroSection() {
  const [currentIndex, setCurrentIndex] = useState(0);

  // Auto-cycle through animes
  useEffect(() => {
    if (heroAnimes.length <= 1) return;

    const interval = setInterval(() => {
      setCurrentIndex((prev) => (prev + 1) % heroAnimes.length);
    }, 10000); // Change anime every 10 seconds

    return () => clearInterval(interval);
  }, [heroAnimes.length]);

  const goToNext = () => {
    setCurrentIndex((prev) => (prev + 1) % heroAnimes.length);
  };

  const goToPrevious = () => {
    setCurrentIndex((prev) => (prev - 1 + heroAnimes.length) % heroAnimes.length);
  };

  const goToSlide = (index: number) => {
    setCurrentIndex(index);
  };

  if (heroAnimes.length === 0) {
    return null;
  }

  const currentAnime = heroAnimes[currentIndex];

  return (
    <section className="relative h-full w-full group rounded-2xl">
      {/* Vibrant Glowing Effect Behind Hero Card */}
      {heroAnimes.map((anime, index) => {
        const cleanColor = (color: string) => color.length === 9 ? color.substring(0, 7) : color;
        const glowColor = cleanColor(anime.accentColor);
        const secondaryGlow = cleanColor(anime.secondaryColor || anime.accentColor);
        
        return (
          <div
            key={`glow-${anime.id}`}
            className={`absolute -inset-[100px] transition-opacity duration-1000 ease-in-out pointer-events-none ${
              index === currentIndex ? 'opacity-100' : 'opacity-0'
            }`}
            style={{ zIndex: -1 }}
          >
            {/* Core glow with reduced brightness */}
            <div 
              className="absolute inset-[100px] rounded-2xl"
              style={{
                background: 'rgba(255, 255, 255, 0.05)',
                boxShadow: `
                  0 0 40px 20px rgba(255, 255, 255, 0.15),
                  0 0 80px 50px ${glowColor}99,
                  0 0 120px 80px ${secondaryGlow}66,
                  0 0 160px 100px ${glowColor}40
                `,
              }}
            />
          </div>
        );
      })}
      
      {/* Background Images */}
      {heroAnimes.map((anime, index) => (
        <div
          key={anime.id}
          className={`absolute inset-0 rounded-2xl transition-opacity duration-1000 ease-in-out ${
            index === currentIndex ? 'opacity-100' : 'opacity-0'
          }`}
        >
          {/* Background Image */}
          <div className="absolute inset-0 rounded-2xl overflow-hidden">
            <Image
              src={anime.thumbnail}
              alt={anime.titleArabic}
              fill
              className="object-cover"
              priority={index === 0}
              quality={95}
            />
          </div>
          
          {/* Gradient Overlays - Subtle */}
          <div className="absolute inset-0 bg-gradient-to-r from-black/50 via-transparent to-transparent rounded-2xl" />
          <div className="absolute inset-0 bg-gradient-to-t from-black/60 via-transparent to-transparent rounded-2xl" />
        </div>
      ))}

      {/* Content Container */}
      <div className="relative h-full px-4 md:px-6 lg:px-8">
        <div className="flex flex-col justify-center h-full max-w-2xl text-right">
          {/* Anime Title */}
          <h1 
            className="text-4xl md:text-5xl lg:text-6xl font-bold mb-4 text-white animate-fade-in"
            style={{ 
              fontFamily: 'var(--font-big-titles)',
              textShadow: '0 2px 8px rgba(0, 0, 0, 0.5), 0 4px 16px rgba(0, 0, 0, 0.3)'
            }}
          >
            {currentAnime.titleArabic}
          </h1>
          
          {/* Description */}
          <p 
            className="text-base md:text-lg text-gray-200 mb-6 animate-fade-in-delay leading-relaxed line-clamp-3"
            style={{ 
              fontFamily: 'var(--font-normal-text)',
              textShadow: '0 1px 4px rgba(0, 0, 0, 0.6), 0 2px 8px rgba(0, 0, 0, 0.4)'
            }}
          >
            {currentAnime.description}
          </p>

          {/* CTA Buttons */}
          <div className="flex gap-3 animate-fade-in-delay-2">
            <Link 
              href={currentAnime.redirectPage}
              className="flex items-center gap-2 bg-white text-black px-6 py-2.5 rounded-md font-semibold hover:bg-white/90 transition-all duration-200 shadow-lg"
              style={{ fontFamily: 'var(--font-normal-text)' }}
            >
              <Play className="w-5 h-5 fill-current" />
              تشغيل
            </Link>
            <Link 
              href={currentAnime.redirectPage}
              className="flex items-center gap-2 bg-white/20 backdrop-blur-md text-white px-6 py-2.5 rounded-md font-semibold hover:bg-white/30 transition-all duration-200 shadow-lg"
              style={{ fontFamily: 'var(--font-normal-text)' }}
            >
              <Info className="w-5 h-5" />
              معلومات إضافية
            </Link>
          </div>
        </div>
      </div>

      {/* Navigation Arrows */}
      {heroAnimes.length > 1 && (
        <button
          onClick={goToNext}
          className="absolute left-4 top-1/2 -translate-y-1/2 text-white p-3 rounded-full hover:bg-white/10 transition-all duration-300 opacity-0 group-hover:opacity-100 z-10"
          style={{
            filter: 'drop-shadow(0 2px 4px rgba(0, 0, 0, 0.3)) drop-shadow(0 4px 8px rgba(0, 0, 0, 0.2))'
          }}
          aria-label="الأنمي التالي"
        >
          <ChevronLeft className="w-6 h-6" />
        </button>
      )}

      {/* Dots Indicator */}
      {heroAnimes.length > 1 && (
        <div className="absolute bottom-10 right-4 md:right-12 lg:right-16 flex gap-2 z-10">
          {heroAnimes.map((anime, index) => (
            <button
              key={anime.id}
              onClick={() => goToSlide(index)}
              className={`transition-all duration-300 ${
                index === currentIndex
                  ? 'w-8 h-1.5 bg-white rounded-full'
                  : 'w-1.5 h-1.5 bg-white/50 hover:bg-white/75 rounded-full'
              }`}
              aria-label={`انتقل إلى ${anime.titleArabic}`}
            />
          ))}
        </div>
      )}

      {/* Smooth Fade to Content Effect - Reduced shadow */}
      <div className="absolute bottom-0 left-0 right-0 h-20 bg-gradient-to-t from-black/20 via-black/5 to-transparent pointer-events-none rounded-2xl" />
    </section>
  );
}
