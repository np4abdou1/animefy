'use client';

import { useEffect, useRef, useState } from 'react';

interface ScrollSectionProps {
  children: React.ReactNode;
  id: string;
  isActive: boolean;
}

export default function ScrollSection({ children, id, isActive }: ScrollSectionProps) {
  return (
    <section
      id={id}
      className={`scroll-section min-h-screen snap-start snap-always transition-all duration-700 ease-out ${
        isActive ? 'opacity-100 scale-100' : 'opacity-40 scale-95'
      }`}
      style={{
        paddingTop: '90px', // Space for header
        filter: isActive ? 'none' : 'brightness(0.6) blur(2px)',
      }}
    >
      <div className="h-full">
        {children}
      </div>
    </section>
  );
}
