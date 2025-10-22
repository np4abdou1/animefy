import Link from 'next/link';
import { MessageCircle, Instagram, Youtube, Twitter, Facebook } from 'lucide-react';

export default function Footer() {
  return (
    <footer className="bg-[#0a0a0a] border-t border-gray-800 mt-auto">
      <div className="container mx-auto px-4 lg:px-8 py-8">
        {/* Social Media Icons */}
        <div className="flex items-center justify-center gap-6 mb-6">
          <Link 
            href="#" 
            className="text-gray-400 hover:text-white transition-colors duration-200"
            aria-label="Facebook"
          >
            <Facebook className="w-5 h-5" />
          </Link>
          <Link 
            href="#" 
            className="text-gray-400 hover:text-white transition-colors duration-200"
            aria-label="Twitter"
          >
            <Twitter className="w-5 h-5" />
          </Link>
          <Link 
            href="#" 
            className="text-gray-400 hover:text-white transition-colors duration-200"
            aria-label="YouTube"
          >
            <Youtube className="w-5 h-5" />
          </Link>
          <Link 
            href="#" 
            className="text-gray-400 hover:text-white transition-colors duration-200"
            aria-label="Discord"
          >
            <MessageCircle className="w-5 h-5" />
          </Link>
          <Link 
            href="#" 
            className="text-gray-400 hover:text-white transition-colors duration-200"
            aria-label="Instagram"
          >
            <Instagram className="w-5 h-5" />
          </Link>
          <Link 
            href="#" 
            className="text-gray-400 hover:text-white transition-colors duration-200"
            aria-label="Telegram"
          >
            <svg className="w-5 h-5" fill="currentColor" viewBox="0 0 24 24">
              <path d="M12 2C6.48 2 2 6.48 2 12s4.48 10 10 10 10-4.48 10-10S17.52 2 12 2zm4.64 6.8c-.15 1.58-.8 5.42-1.13 7.19-.14.75-.42 1-.68 1.03-.58.05-1.02-.38-1.58-.75-.88-.58-1.38-.94-2.23-1.5-.99-.65-.35-1.01.22-1.59.15-.15 2.71-2.48 2.76-2.69a.2.2 0 00-.05-.18c-.06-.05-.14-.03-.21-.02-.09.02-1.49.95-4.22 2.79-.4.27-.76.41-1.08.4-.36-.01-1.04-.2-1.55-.37-.63-.2-1.12-.31-1.08-.66.02-.18.27-.36.74-.55 2.92-1.27 4.86-2.11 5.83-2.51 2.78-1.16 3.35-1.36 3.73-1.36.08 0 .27.02.39.12.1.08.13.19.14.27-.01.06.01.24 0 .38z"/>
            </svg>
          </Link>
        </div>

        {/* Footer Links */}
        <div className="flex items-center justify-center gap-4 mb-6 text-sm" style={{ fontFamily: 'var(--font-normal-text)' }}>
          <Link 
            href="/witanime" 
            className="text-gray-400 hover:text-white transition-colors duration-200"
          >
            WITANIME
          </Link>
          <span className="text-gray-700">|</span>
          <Link 
            href="/contact" 
            className="text-gray-400 hover:text-white transition-colors duration-200"
          >
            Contact Us
          </Link>
          <span className="text-gray-700">|</span>
          <Link 
            href="/dmca" 
            className="text-gray-400 hover:text-white transition-colors duration-200"
          >
            DMCA
          </Link>
        </div>

        {/* Copyright Text */}
        <div className="text-center text-gray-500 text-sm" style={{ fontFamily: 'var(--font-normal-text)' }}>
          <p>جميع الحقوق محفوظة لموقع ويت انمي | WitAnime</p>
        </div>
      </div>
    </footer>
  );
}
