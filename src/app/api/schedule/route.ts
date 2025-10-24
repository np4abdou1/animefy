export const runtime = 'edge';

export async function GET() {
  const upstream = 'https://witanime-api-worker.abdellah2019gg.workers.dev/api/schedule';
  try {
    const res = await fetch(upstream, { headers: { Accept: 'application/json' } });
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
