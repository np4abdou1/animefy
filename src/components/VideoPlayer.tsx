"use client"

import { useState, useEffect } from 'react';
import { Play, Loader2, Monitor, Wifi } from 'lucide-react';

interface StreamingServer {
  name: string;
  url: string;
  quality: string;
  type: 'direct' | 'embed';
}

interface VideoPlayerProps {
  servers: any;
  animeTitle: string;
  episode: string;
}

// Helper function to convert MediaFire link to direct download URL
async function getMediaFireDirectUrl(mediaFireId: string): Promise<string | null> {
  try {
    const mediaFireUrl = `https://www.mediafire.com/file/${mediaFireId}`;
    
    // For now, return the embed URL which MediaFire supports
    // In production, you might want to use a backend proxy to get the direct link
    return `https://www.mediafire.com/file/${mediaFireId}/file`;
  } catch (error) {
    console.error('Error getting MediaFire direct URL:', error);
    return null;
  }
}

// Helper to build streaming URLs from server data
function buildStreamingUrl(serverLink: string, serverType: string): string {
  if (!serverLink || serverLink === '') return '';
  
  // If already a full URL, return as is
  if (serverLink.startsWith('http')) {
    return serverLink;
  }
  
  // Build URL based on server type
  const patterns: { [key: string]: string } = {
    'OK': `https://ok.ru/videoembed/${serverLink}`,
    'MA': `https://mega.nz/embed/${serverLink}`,
    'GD': `https://www.googleapis.com/drive/v3/files/${serverLink}?key=AIzaSyBzyqZekacyx5t_MGh_A-8-iz2tEeIzqwE&alt=media`,
    'FR': `https://www.mediafire.com/file/${serverLink}`,
    'LB': serverLink,
    'SV': serverLink,
    'SF': serverLink,
    'FD': serverLink,
  };
  
  for (const [prefix, baseUrl] of Object.entries(patterns)) {
    if (serverType.includes(prefix)) {
      return baseUrl;
    }
  }
  
  return serverLink;
}

export default function VideoPlayer({ servers, animeTitle, episode }: VideoPlayerProps) {
  const [selectedServer, setSelectedServer] = useState<StreamingServer | null>(null);
  const [selectedQuality, setSelectedQuality] = useState<string>('720p');
  const [availableServers, setAvailableServers] = useState<StreamingServer[]>([]);
  const [loading, setLoading] = useState(true);
  const [loadingDirectUrl, setLoadingDirectUrl] = useState(false);

  useEffect(() => {
    // Parse servers from API response
    const parseServers = async () => {
      if (!servers || !servers.CurrentEpisode) {
        setLoading(false);
        return;
      }

      const currentEp = servers.CurrentEpisode;
      const serverList: StreamingServer[] = [];

      // Priority 1: MediaFire Direct URLs (720p)
      if (currentEp.FRLink) {
        serverList.push({
          name: 'MediaFire',
          url: buildStreamingUrl(currentEp.FRLink, 'FR'),
          quality: '720p',
          type: 'direct'
        });
      }

      // MediaFire 1080p
      if (currentEp.FRFhdQ) {
        serverList.push({
          name: 'MediaFire',
          url: buildStreamingUrl(currentEp.FRFhdQ, 'FR'),
          quality: '1080p',
          type: 'direct'
        });
      }

      // MediaFire 480p
      if (currentEp.FRLowQ) {
        serverList.push({
          name: 'MediaFire',
          url: buildStreamingUrl(currentEp.FRLowQ, 'FR'),
          quality: '480p',
          type: 'direct'
        });
      }

      // Priority 2: Other direct servers
      if (currentEp.LBLink) {
        serverList.push({
          name: 'Server 1',
          url: buildStreamingUrl(currentEp.LBLink, 'LB'),
          quality: '720p',
          type: 'direct'
        });
      }

      if (currentEp.LBFhdQ) {
        serverList.push({
          name: 'Server 1',
          url: buildStreamingUrl(currentEp.LBFhdQ, 'LB'),
          quality: '1080p',
          type: 'direct'
        });
      }

      if (currentEp.LBLowQ) {
        serverList.push({
          name: 'Server 1',
          url: buildStreamingUrl(currentEp.LBLowQ, 'LB'),
          quality: '480p',
          type: 'direct'
        });
      }

      // Priority 3: Embed servers
      if (currentEp.MALink) {
        serverList.push({
          name: 'Mega',
          url: buildStreamingUrl(currentEp.MALink, 'MA'),
          quality: '720p',
          type: 'embed'
        });
      }

      if (currentEp.OKLink) {
        serverList.push({
          name: 'OK.ru',
          url: buildStreamingUrl(currentEp.OKLink, 'OK'),
          quality: '720p',
          type: 'embed'
        });
      }

      if (currentEp.GDLink) {
        serverList.push({
          name: 'Google Drive',
          url: buildStreamingUrl(currentEp.GDLink, 'GD'),
          quality: '720p',
          type: 'embed'
        });
      }

      if (currentEp.GDFhdQ) {
        serverList.push({
          name: 'Google Drive',
          url: buildStreamingUrl(currentEp.GDFhdQ, 'GD'),
          quality: '1080p',
          type: 'embed'
        });
      }

      setAvailableServers(serverList);

      // Select first server by default
      if (serverList.length > 0) {
        setSelectedServer(serverList[0]);
        setSelectedQuality(serverList[0].quality);
      }

      setLoading(false);
    };

    parseServers();
  }, [servers]);

  const handleQualityChange = (quality: string) => {
    setSelectedQuality(quality);
    
    // Find a server with the selected quality
    const serverWithQuality = availableServers.find(s => s.quality === quality);
    if (serverWithQuality) {
      setSelectedServer(serverWithQuality);
    }
  };

  const handleServerChange = (server: StreamingServer) => {
    setSelectedServer(server);
    setSelectedQuality(server.quality);
  };

  const getAvailableQualities = () => {
    const qualities = new Set(availableServers.map(s => s.quality));
    return Array.from(qualities).sort((a, b) => {
      const order: { [key: string]: number } = { '480p': 1, '720p': 2, '1080p': 3 };
      return (order[b] || 0) - (order[a] || 0);
    });
  };

  const getServersForQuality = (quality: string) => {
    return availableServers.filter(s => s.quality === quality);
  };

  if (loading) {
    return (
      <div className="w-full aspect-video bg-black rounded-lg flex items-center justify-center">
        <div className="flex flex-col items-center gap-4">
          <Loader2 className="w-12 h-12 animate-spin text-white/50" />
          <p className="text-white/70" style={{ fontFamily: 'var(--font-normal-text)' }}>
            جاري تحميل المشغل...
          </p>
        </div>
      </div>
    );
  }

  if (!selectedServer) {
    return (
      <div className="w-full aspect-video bg-black rounded-lg flex items-center justify-center border border-white/10">
        <div className="text-center">
          <p className="text-white/70 text-lg mb-2" style={{ fontFamily: 'var(--font-normal-text)' }}>
            عذراً، لا توجد خوادم متاحة لهذه الحلقة
          </p>
          <p className="text-white/50 text-sm" style={{ fontFamily: 'var(--font-normal-text)' }}>
            يرجى المحاولة لاحقاً
          </p>
        </div>
      </div>
    );
  }

  return (
    <div className="space-y-4">
      {/* Video Player */}
      <div className="w-full aspect-video bg-black rounded-lg overflow-hidden border border-white/10">
        {selectedServer.type === 'direct' ? (
          // For direct URLs, show link to download/stream
          <div className="w-full h-full flex items-center justify-center bg-gradient-to-br from-gray-900 to-black">
            <div className="text-center p-8">
              <Monitor className="w-16 h-16 mx-auto mb-4 text-white/50" />
              <h3 className="text-xl font-bold mb-3" style={{ fontFamily: 'var(--font-normal-text)' }}>
                {animeTitle} - الحلقة {episode}
              </h3>
              <p className="text-white/70 mb-6" style={{ fontFamily: 'var(--font-normal-text)' }}>
                اضغط على الزر أدناه للمشاهدة بجودة {selectedServer.quality}
              </p>
              <a
                href={selectedServer.url}
                target="_blank"
                rel="noopener noreferrer"
                className="inline-flex items-center gap-2 bg-white text-black px-8 py-3 rounded-full font-bold hover:bg-gray-200 transition-all hover:scale-105"
                style={{ fontFamily: 'var(--font-normal-text)' }}
              >
                <Play className="w-5 h-5 fill-black" />
                مشاهدة على {selectedServer.name}
              </a>
            </div>
          </div>
        ) : (
          // For embed URLs, use iframe
          <iframe
            src={selectedServer.url}
            className="w-full h-full"
            allowFullScreen
            allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
            title={`${animeTitle} - Episode ${episode}`}
          />
        )}
      </div>

      {/* Controls */}
      <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
        {/* Quality Selector */}
        <div>
          <label className="block text-sm font-semibold mb-2 text-white/90" style={{ fontFamily: 'var(--font-normal-text)' }}>
            الجودة
          </label>
          <div className="flex flex-wrap gap-2">
            {getAvailableQualities().map((quality) => (
              <button
                key={quality}
                onClick={() => handleQualityChange(quality)}
                className={`px-4 py-2 rounded-lg font-semibold transition-all ${
                  selectedQuality === quality
                    ? 'bg-white text-black'
                    : 'bg-white/10 text-white hover:bg-white/20 border border-white/20'
                }`}
                style={{ fontFamily: 'var(--font-normal-text)' }}
              >
                {quality}
              </button>
            ))}
          </div>
        </div>

        {/* Server Selector */}
        <div>
          <label className="block text-sm font-semibold mb-2 text-white/90" style={{ fontFamily: 'var(--font-normal-text)' }}>
            <Wifi className="w-4 h-4 inline-block ml-1" />
            الخوادم
          </label>
          <div className="flex flex-wrap gap-2">
            {getServersForQuality(selectedQuality).map((server, index) => (
              <button
                key={`${server.name}-${server.quality}-${index}`}
                onClick={() => handleServerChange(server)}
                className={`px-4 py-2 rounded-lg font-semibold transition-all ${
                  selectedServer === server
                    ? 'bg-white text-black'
                    : 'bg-white/10 text-white hover:bg-white/20 border border-white/20'
                }`}
                style={{ fontFamily: 'var(--font-normal-text)' }}
              >
                {server.name}
              </button>
            ))}
          </div>
        </div>
      </div>

      {/* Server Info */}
      <div className="bg-white/5 border border-white/10 rounded-lg p-4">
        <p className="text-sm text-white/70" style={{ fontFamily: 'var(--font-normal-text)' }}>
          <strong>الخادم الحالي:</strong> {selectedServer.name} ({selectedServer.quality})
          {selectedServer.type === 'direct' && ' - رابط مباشر'}
          {selectedServer.type === 'embed' && ' - مشغل مدمج'}
        </p>
      </div>
    </div>
  );
}
