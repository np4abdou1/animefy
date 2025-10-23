import { Metadata } from 'next';
import ScheduleContent from '@/components/ScheduleContent';
import { getSchedule } from '@/lib/animeify-api';

export const metadata: Metadata = {
  title: 'مواعيد العرض | WitAnime',
  description: 'جدول مواعيد عرض الأنمي حسب الأيام والمواسم',
};

export default async function SchedulePage() {
  const scheduleData = await getSchedule();

  return (
    <main className="min-h-screen bg-black pt-20 px-4 md:px-12 lg:px-16 xl:px-24">
      <ScheduleContent schedule={scheduleData.schedule} seasons={scheduleData.seasons} />
    </main>
  );
}
