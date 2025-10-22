'use client';

import { useEffect } from 'react';

export default function ScrollSectionObserver() {
  useEffect(() => {
    const sections = document.querySelectorAll('.scroll-section');
    
    const observerOptions = {
      root: null,
      rootMargin: '-45% 0px -45% 0px', // Center detection zone
      threshold: 0,
    };

    const observer = new IntersectionObserver((entries) => {
      entries.forEach((entry) => {
        if (entry.isIntersecting) {
          // Remove active from all sections
          sections.forEach(s => s.classList.remove('active'));
          // Add active to current section
          entry.target.classList.add('active');
        }
      });
    }, observerOptions);

    sections.forEach((section) => observer.observe(section));

    // Set first section as active initially
    if (sections.length > 0) {
      sections[0].classList.add('active');
    }

    // Handle keyboard arrow navigation
    const handleKeyDown = (e: KeyboardEvent) => {
      if (e.key === 'ArrowDown' || e.key === 'ArrowUp') {
        e.preventDefault();
        
        const activeSection = document.querySelector('.scroll-section.active');
        if (!activeSection) return;

        const allSections = Array.from(sections);
        const currentIndex = allSections.indexOf(activeSection);
        
        let targetSection: Element | null = null;
        
        if (e.key === 'ArrowDown' && currentIndex < allSections.length - 1) {
          targetSection = allSections[currentIndex + 1];
        } else if (e.key === 'ArrowUp' && currentIndex > 0) {
          targetSection = allSections[currentIndex - 1];
        }
        
        if (targetSection) {
          targetSection.scrollIntoView({ behavior: 'smooth', block: 'start' });
        }
      }
    };

    window.addEventListener('keydown', handleKeyDown);

    return () => {
      sections.forEach((section) => observer.unobserve(section));
      window.removeEventListener('keydown', handleKeyDown);
    };
  }, []);

  return null;
}
