import { NextRequest, NextResponse } from 'next/server';

export function middleware(request: NextRequest) {
  const { pathname, searchParams } = request.nextUrl;
  
  console.log('Middleware - Processing pathname:', pathname);
  
  // Handle anime dynamic routes
  if (pathname.startsWith('/anime/')) {
    const segments = pathname.split('/').filter(Boolean);
    
    if (segments.length >= 2) {
      const slug = segments[1];
      console.log('Middleware - Anime route, slug:', slug);
      
      // For static export, we need to ensure the route exists
      // Add headers to help with debugging
      const response = NextResponse.next();
      response.headers.set('x-pathname', pathname);
      response.headers.set('x-slug', slug);
      
      // Pass through search params as headers for better compatibility
      const name = searchParams.get('name');
      const type = searchParams.get('type');
      
      if (name) response.headers.set('x-anime-name', name);
      if (type) response.headers.set('x-anime-type', type);
      
      return response;
    }
  }
  
  return NextResponse.next();
}

export const config = {
  matcher: [
    // Match all anime routes
    '/anime/:path*',
    // Match API routes
    '/api/:path*',
  ],
};
