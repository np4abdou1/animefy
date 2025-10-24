export const runtime = 'edge';

function buildUpstreamUrl(reqUrl: string) {
  const url = new URL(reqUrl);
  const upstream = new URL('https://witanime-api-worker.abdellah2019gg.workers.dev/api/browse');
  // Forward expected query params transparently
  upstream.search = url.search;
  return upstream.toString();
}

export async function GET(request: Request) {
  const upstream = buildUpstreamUrl(request.url);
  try {
    const res = await fetch(upstream, { headers: { Accept: 'application/json' }, cache: 'no-store' });
    if (!res.ok) {
      return new Response(JSON.stringify({ status: 'error', message: `Upstream ${res.status}` }), {
        status: 502,
        headers: { 'content-type': 'application/json; charset=utf-8' },
      });
    }
    const data = await res.text();
    return new Response(data, { status: 200, headers: { 'content-type': 'application/json; charset=utf-8' } });
  } catch (err: any) {
    return new Response(JSON.stringify({ status: 'error', message: err?.message || 'fetch_failed' }), {
      status: 500,
      headers: { 'content-type': 'application/json; charset=utf-8' },
    });
  }
}
