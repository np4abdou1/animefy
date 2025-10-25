import { NextRequest, NextResponse } from 'next/server';

export async function GET(request: NextRequest) {
  const { searchParams } = new URL(request.url);
  const slug = searchParams.get('slug');
  const name = searchParams.get('name');
  const type = searchParams.get('type') || 'SERIES';
  
  if (!slug) {
    return NextResponse.json({ error: 'Slug parameter is required' }, { status: 400 });
  }
  
  // Redirect to the proper anime page with query parameters
  const redirectUrl = `/anime/${slug}?name=${encodeURIComponent(name || '')}&type=${encodeURIComponent(type)}`;
  
  return NextResponse.redirect(redirectUrl);
}
