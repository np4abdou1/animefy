// Proxy endpoint for Animeify API to avoid CORS issues
// This server-side route proxies requests to animeify.net and adds CORS headers

import { NextRequest, NextResponse } from 'next/server';

const ANIMEIFY_API_BASE = process.env.NEXT_PUBLIC_API_BASE_URL || "https://animeify.net/animeify/apis_v4/";
const ANIMEIFY_TOKEN = process.env.NEXT_PUBLIC_API_TOKEN || "8cnY80AZSbUCmR26Vku1VUUY4";

// CORS headers
const corsHeaders = {
  'Access-Control-Allow-Origin': '*',
  'Access-Control-Allow-Methods': 'GET, POST, OPTIONS',
  'Access-Control-Allow-Headers': 'Content-Type',
};

export async function OPTIONS() {
  return NextResponse.json({}, { headers: corsHeaders });
}

export async function POST(request: NextRequest) {
  try {
    const body = await request.json();
    const { endpoint, params } = body;

    if (!endpoint) {
      return NextResponse.json(
        { error: 'Endpoint is required' },
        { status: 400, headers: corsHeaders }
      );
    }

    const url = ANIMEIFY_API_BASE + endpoint;

    // Build form data as URL-encoded string
    const formBody = Object.keys(params)
      .map(key => encodeURIComponent(key) + '=' + encodeURIComponent(params[key]))
      .join('&');

    // Make request to Animeify API
    const response = await fetch(url, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/x-www-form-urlencoded',
      },
      body: formBody,
    });

    if (!response.ok) {
      throw new Error(`API request failed: ${response.status} ${response.statusText}`);
    }

    const data = await response.json();

    return NextResponse.json(data, { headers: corsHeaders });
  } catch (error) {
    console.error('Proxy error:', error);
    return NextResponse.json(
      { error: error instanceof Error ? error.message : 'Internal server error' },
      { status: 500, headers: corsHeaders }
    );
  }
}
