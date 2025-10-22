import { Metadata } from 'next';
import DiscoverContent from '@/components/DiscoverContent';

export const metadata: Metadata = {
  title: 'استكشف | WitAnime',
  description: 'استكشف جميع الأنمي - مسلسلات وأفلام',
};

export default function DiscoverPage() {
  return (
    <main className="min-h-screen bg-black pt-20">
      <DiscoverContent />
    </main>
  );
}
