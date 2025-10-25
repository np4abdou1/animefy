'use client';

import { useEffect } from 'react';

export default function WatchLayout({
  children,
}: {
  children: React.ReactNode;
}) {
  useEffect(() => {
    // Hide header on watch page
    const header = document.querySelector('header');
    if (header) {
      header.style.display = 'none';
    }
    
    return () => {
      // Show header when leaving watch page
      const header = document.querySelector('header');
      if (header) {
        header.style.display = '';
      }
    };
  }, []);

  return <>{children}</>;
}
