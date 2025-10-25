import { NextRequest, NextResponse } from 'next/server';

const API_BASE = 'https://animeify.net/animeify/api/';
const TOKEN = '8cnY80AZSbUCmR26Vku1VUUY4';

export async function POST(request: NextRequest) {
  try {
    const { animeId, episode } = await request.json();

    const response = await fetch(`${API_BASE}episodes/load_episode_servers.php`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/x-www-form-urlencoded',
      },
      body: new URLSearchParams({
        AnimeID: animeId,
        Episode: episode.toString(),
        Token: TOKEN,
      }),
    });

    if (!response.ok) {
      throw new Error(`API error: ${response.status}`);
    }

    const data = await response.json();
    return NextResponse.json(data);
  } catch (error) {
    console.error('Episode servers error:', error);
    return NextResponse.json({ error: 'Failed to fetch episode servers' }, { status: 500 });
  }
}
