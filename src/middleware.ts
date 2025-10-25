import { NextRequest, NextResponse } from 'next/server';

export function middleware(request: NextRequest) {
  const { pathname } = request.nextUrl;
  
  console.log('Middleware - Processing pathname:', pathname);
  
  // Handle anime dynamic routes
  if (pathname.startsWith('/anime/')) {
    // Extract the slug from the pathname
    const segments = pathname.split('/');
    const slug = segments[2]; // /anime/[slug]
    
    console.log('Middleware - Anime route, slug:', slug);
    
    // If we have a valid slug, let the request continue
    if (slug && slug !== '') {
      // Add headers to help with edge runtime issues
      const response = NextResponse.next();
      response.headers.set('x-pathname', pathname);
      response.headers.set('x-slug', slug);
      return response;
    }
  }
  
  // Handle watch dynamic routes
  if (pathname.startsWith('/anime/') && pathname.includes('/watch/')) {
    // Extract the slug and episode from the pathname
    const segments = pathname.split('/');
    const slug = segments[2]; // /anime/[slug]
    const episode = segments[4]; // /anime/[slug]/watch/[episode]
    
    console.log('Middleware - Watch route, slug:', slug, 'episode:', episode);
    
    // If we have valid slug and episode, let the request continue
    if (slug && slug !== '' && episode && episode !== '') {
      // Add headers to help with edge runtime issues
      const response = NextResponse.next();
      response.headers.set('x-pathname', pathname);
      response.headers.set('x-slug', slug);
      response.headers.set('x-episode', episode);
      return response;
    }
  }
  
  // For all other routes, continue normally
  return NextResponse.next();
}

export const config = {
  matcher: [
    '/anime/:path*',
    '/watch/:path*',
  ],
};
