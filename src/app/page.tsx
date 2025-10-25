import HeroSection from '@/components/HeroSection';
import LatestEpisodes from '@/components/LatestEpisodes';
import AiringToday from '@/components/AiringToday';
import TrendingAnime from '@/components/TrendingAnime';
import ScrollSectionObserver from '@/components/ScrollSectionObserver';
import Footer from '@/components/Footer';
import { headers } from 'next/headers';

export const runtime = 'edge';
export const revalidate = 300; // Revalidate every 5 minutes

async function getHomeContent() {
  try {
  const h = await headers();
    const proto = h.get('x-forwarded-proto') ?? 'https';
    const host = h.get('x-forwarded-host') ?? h.get('host');
    const base = `${proto}://${host}`;
    const res = await fetch(`${base}/api/home_content`);
    
    if (!res.ok) {
      throw new Error('Failed to fetch home content');
    }
    
    const json = await res.json();
    return json.data || {
      latestEpisodes: [],
      airingToday: [],
      trending: []
    };
  } catch (error) {
    console.error('Error fetching home content:', error);
    return {
      latestEpisodes: [],
      airingToday: [],
      trending: []
    };
  }
}

export default async function Home() {
  const homeData = await getHomeContent();

  return (
    <main className="snap-y snap-mandatory overflow-y-scroll h-screen relative scrollbar-hide" style={{
      scrollBehavior: 'smooth',
    }}>
      <ScrollSectionObserver />
      
      {/* Hero Section - with space to show next section */}
      <div id="hero" className="scroll-section snap-start active min-h-screen flex items-start pt-[calc(6rem-25px)] px-4 md:px-12 lg:px-16 xl:px-24 relative z-10">
        <div className="w-full h-[85vh]">
          <HeroSection />
        </div>
      </div>
      
      {/* Airing Today Section */}
      {homeData.airingToday && homeData.airingToday.length > 0 && (
        <section id="airing" className="scroll-section snap-start bg-[#0a0a0a] min-h-screen flex flex-col justify-start pt-24 relative overflow-visible">
          <div className="px-4 md:px-12 lg:px-16 xl:px-24">
            <AiringToday animes={homeData.airingToday} />
          </div>
        </section>
      )}
      
      {/* Latest Episodes Section */}
      {homeData.latestEpisodes && homeData.latestEpisodes.length > 0 && (
        <section id="latest" className="scroll-section snap-start bg-[#0a0a0a] min-h-screen flex flex-col justify-start pt-24 relative overflow-visible">
          <div className="px-4 md:px-12 lg:px-16 xl:px-24">
            <LatestEpisodes episodes={homeData.latestEpisodes} />
          </div>
        </section>
      )}
      
      {/* Trending Anime Section */}
      {homeData.trending && homeData.trending.length > 0 && (
        <section id="trending" className="scroll-section snap-start bg-[#0a0a0a] min-h-screen flex flex-col justify-start pt-24 relative overflow-visible">
          <div className="px-4 md:px-12 lg:px-16 xl:px-24">
            <TrendingAnime trending={homeData.trending} />
          </div>
        </section>
      )}

      {/* Footer Section */}
      <section className="snap-start bg-[#0a0a0a] min-h-fit relative overflow-hidden">
        <Footer />
      </section>
    </main>
  );
}
