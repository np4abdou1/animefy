import { NextRequest, NextResponse } from 'next/server';

export async function POST(request: NextRequest) {
  try {
    const { fileId } = await request.json();
    
    const mediafireUrl = `https://www.mediafire.com/file/${fileId}`;
    
    const response = await fetch(mediafireUrl, {
      headers: {
        'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.97 Safari/537.36 Edg/83.0.478.45',
      },
    });

    if (!response.ok) {
      throw new Error(`MediaFire error: ${response.status}`);
    }

    const html = await response.text();
    
    // Extract direct download link using the same logic as the DLL
    const startIndex = html.indexOf('https://download');
    if (startIndex === -1) {
      throw new Error('Download link not found');
    }
    
    const endIndex = html.indexOf('"', startIndex);
    const directLink = html.substring(startIndex, endIndex);
    
    return NextResponse.json({ directLink });
  } catch (error) {
    console.error('MediaFire extraction error:', error);
    return NextResponse.json({ error: 'Failed to extract MediaFire link' }, { status: 500 });
  }
}
