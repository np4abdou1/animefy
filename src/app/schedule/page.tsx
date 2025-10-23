import { Metadata } from 'next';
import ScheduleContent from '@/components/ScheduleContent';

export const metadata: Metadata = {
  title: 'مواعيد العرض | WitAnime',
  description: 'جدول مواعيد عرض الأنمي حسب الأيام والمواسم',
};

async function getScheduleData() {
  try {
    // Fetch schedule for all days
    const res = await fetch('https://witanime-api-worker.abdellah2019gg.workers.dev/api/schedule', {
      next: { revalidate: 3600 } // Revalidate every hour
    });
    
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
