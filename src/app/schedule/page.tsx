import { Metadata } from 'next';
import ScheduleContent from '@/components/ScheduleContent';
import { headers } from 'next/headers';

export const metadata: Metadata = {
  title: 'مواعيد العرض | WitAnime',
  description: 'جدول مواعيد عرض الأنمي حسب الأيام والمواسم',
};

export const runtime = 'edge';
export const revalidate = 3600; // Revalidate every hour

async function getScheduleData() {
  try {
    // Fetch schedule for all days (Edge requires absolute URL)
    const h = await headers();
    const proto = h.get('x-forwarded-proto') ?? 'https';
    const host = h.get('x-forwarded-host') ?? h.get('host');
    const base = `${proto}://${host}`;
    const res = await fetch(`${base}/api/schedule`);
    
    if (!res.ok) {
      throw new Error('Failed to fetch schedule');
    }
    
    const json = await res.json();
    return json.data || { schedule: {}, seasons: [] };
  } catch (error) {
    console.error('Error fetching schedule:', error);
    return { schedule: {}, seasons: [] };
  }
}

export default async function SchedulePage() {
  const scheduleData = await getScheduleData();

  return (
    <main className="min-h-screen bg-black pt-20 px-4 md:px-12 lg:px-16 xl:px-24">
      <ScheduleContent schedule={scheduleData.schedule} seasons={scheduleData.seasons} />
    </main>
  );
}
