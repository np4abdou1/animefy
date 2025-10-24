'use client';

import { useEffect, useMemo, useRef, useState } from 'react';
import { Pause, Play, Volume2, VolumeX, Maximize2, Settings2, ChevronDown } from 'lucide-react';
import { motion, AnimatePresence } from 'framer-motion';

type ServerEntry = {
  serverName: string;
  serverType: string;
  serverTypeKey?: string;
  quality?: string;
  url: string;
  directUrl?: string | null;
};

interface PlayerProps {
  animeId: string;
  episodes: Array<{ Episode?: number | string } | number | string>;
  defaultType?: 'SERIES' | 'MOVIE';
  defaultEpisode?: string;
}

function parseEpisodeValue(ep: any): string {
  if (typeof ep === 'number' || typeof ep === 'string') return String(ep);
  return String((ep as any)?.Episode ?? '1');
}

export default function VideoPlayer({ animeId, episodes, defaultType = 'SERIES', defaultEpisode }: PlayerProps) {
  const videoRef = useRef<HTMLVideoElement | null>(null);
  const [selectedEpisode, setSelectedEpisode] = useState<string>(defaultEpisode || '');
  const [servers, setServers] = useState<ServerEntry[]>([]);
  const [currentSrc, setCurrentSrc] = useState<string>('');
  const [useIframe, setUseIframe] = useState<boolean>(false);
  const [iframeSrc, setIframeSrc] = useState<string>('');
  const [showSettings, setShowSettings] = useState<boolean>(false);
  const [selectedServerKey, setSelectedServerKey] = useState<string>('MEDIAFIRE');
  const [selectedQuality, setSelectedQuality] = useState<string>('');
  const [isPlaying, setIsPlaying] = useState<boolean>(false);
  const [muted, setMuted] = useState<boolean>(false);

  const mediafireOptions = useMemo(() => {
    const list = servers.filter(s => (s.serverTypeKey || s.serverType).toUpperCase().includes('MEDIAFIRE') && s.directUrl);
    // sort by quality numeric desc
    const parseQ = (q?: string) => {
      const m = (q || '').match(/(\d{3,4})p/i); return m ? parseInt(m[1], 10) : 0;
    };
    return list.sort((a,b)=>parseQ(b.quality)-parseQ(a.quality));
  }, [servers]);

  async function loadServers(ep: string) {
    const params = new URLSearchParams({ episode: ep, type: defaultType });
    const res = await fetch(`/api/anime/${animeId}/servers?` + params.toString(), { cache: 'no-store' });
    const json = await res.json();
    setServers(json.servers || []);
    // pick best mediafire
    if (json.bestMediafire?.directUrl) {
      setUseIframe(false);
      setIframeSrc('');
      setSelectedServerKey('MEDIAFIRE');
      setSelectedQuality(json.bestMediafire.quality || '');
      setCurrentSrc(json.bestMediafire.directUrl);
      setTimeout(()=>videoRef.current?.play().catch(()=>{}), 100);
    } else {
      // fallback to first embed server
      const embed = (json.servers || []).find((s:any)=>!(s.serverTypeKey||'').toUpperCase().includes('MEDIAFIRE'));
      if (embed) {
        setUseIframe(true);
        setIframeSrc(embed.url);
      }
    }
  }

  // Auto-load if defaultEpisode provided
  useEffect(() => {
    if (defaultEpisode) {
      setSelectedEpisode(defaultEpisode);
      loadServers(defaultEpisode);
    }
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [defaultEpisode]);

  function handlePlayPause() {
    const v = videoRef.current; if (!v) return;
    if (v.paused) { v.play(); setIsPlaying(true); } else { v.pause(); setIsPlaying(false); }
  }

  function handleMute() {
    const v = videoRef.current; if (!v) return;
    v.muted = !v.muted; setMuted(v.muted);
  }

  function handleFullscreen() {
    const el = document.getElementById('player-container');
    if (!el) return;
    if (document.fullscreenElement) document.exitFullscreen();
    else el.requestFullscreen().catch(()=>{});
  }

  function onSelectServer(s: ServerEntry) {
    const key = (s.serverTypeKey || s.serverType).toUpperCase();
    if (key.includes('MEDIAFIRE') && s.directUrl) {
      setUseIframe(false);
      setIframeSrc('');
      setCurrentSrc(s.directUrl);
      setSelectedServerKey('MEDIAFIRE');
      setSelectedQuality(s.quality || '');
      setTimeout(()=>videoRef.current?.play().catch(()=>{}), 100);
    } else {
      setUseIframe(true);
      setIframeSrc(s.url);
      setSelectedServerKey(key);
    }
    setShowSettings(false);
  }

  function onSelectQuality(q: string) {
    const m = mediafireOptions.find(o => (o.quality||'') === q);
    if (m?.directUrl) {
      setUseIframe(false);
      setIframeSrc('');
      setCurrentSrc(m.directUrl);
      setSelectedQuality(q);
      setSelectedServerKey('MEDIAFIRE');
      setTimeout(()=>videoRef.current?.play().catch(()=>{}), 50);
    }
  }

  return (
    <div id="player-container" className="fixed inset-0 w-screen h-screen bg-black">
      {/* Episode chooser */}
      <div className="absolute top-4 left-1/2 -translate-x-1/2 z-20 flex items-center gap-2">
        <div className="relative">
          <select
            className="appearance-none pr-8 pl-3 py-2 rounded-lg bg-white/10 text-white border border-white/20 backdrop-blur-md"
            value={selectedEpisode}
            onChange={(e)=>{ const ep=e.target.value; setSelectedEpisode(ep); loadServers(ep); }}
          >
            <option value="" disabled>اختر حلقة</option>
            {episodes.map((ep, i)=>{
              const val = parseEpisodeValue(ep);
              return <option key={i} value={val}>{`الحلقة ${val}`}</option>
            })}
          </select>
          <ChevronDown className="absolute right-2 top-1/2 -translate-y-1/2 text-white w-4 h-4 pointer-events-none" />
        </div>
      </div>

      {/* Video or Iframe */}
      {!useIframe ? (
        <div className="w-full h-full relative">
          <video ref={videoRef} className="w-full h-full object-contain" src={currentSrc} controls={false} onPlay={()=>setIsPlaying(true)} onPause={()=>setIsPlaying(false)} />

          {/* Controls overlay */}
          <div className="absolute inset-0 bg-gradient-to-t from-black/40 via-transparent to-black/30 pointer-events-none" />
          <div className="absolute bottom-6 left-0 right-0 px-6 flex items-center justify-between z-20">
            <div className="flex items-center gap-2 pointer-events-auto">
              <button aria-label="play" onClick={handlePlayPause} className="p-2 rounded-full bg-white/10 hover:bg-white/20 text-white">
                {isPlaying ? <Pause className="w-5 h-5"/> : <Play className="w-5 h-5"/>}
              </button>
              <button aria-label="mute" onClick={handleMute} className="p-2 rounded-full bg-white/10 hover:bg-white/20 text-white">
                {muted ? <VolumeX className="w-5 h-5"/> : <Volume2 className="w-5 h-5"/>}
              </button>
            </div>
            <div className="flex items-center gap-2 pointer-events-auto">
              {/* Settings */}
              <div className="relative">
                <button aria-label="settings" onClick={()=>setShowSettings(v=>!v)} className="p-2 rounded-full bg-white/10 hover:bg-white/20 text-white"><Settings2 className="w-5 h-5"/></button>
                <AnimatePresence>
                  {showSettings && (
                    <motion.div initial={{ opacity:0, y:10 }} animate={{ opacity:1, y:0 }} exit={{ opacity:0, y:10 }} className="absolute bottom-12 right-0 bg-black/90 backdrop-blur-xl border border-white/10 rounded-xl p-3 w-64">
                      <div className="text-white font-bold mb-2" style={{ fontFamily: 'var(--font-big-titles)' }}>الإعدادات</div>
                      {/* Servers */}
                      <div className="mb-2">
                        <div className="text-xs text-gray-300 mb-1">السيرفر</div>
                        <div className="flex flex-wrap gap-2">
                          {servers.map((s,i)=>{
                            const key=(s.serverTypeKey||s.serverType).toUpperCase();
                            return (
                              <button key={i} onClick={()=>onSelectServer(s)} className={`px-2 py-1 rounded-lg text-xs ${key===selectedServerKey? 'bg-white text-black':'bg-white/10 text-white hover:bg-white/20'}`}>{s.serverName || key}</button>
                            )
                          })}
                        </div>
                      </div>
                      {/* Quality for mediafire only */}
                      {mediafireOptions.length>0 && (
                        <div>
                          <div className="text-xs text-gray-300 mb-1">الجودة (Mediafire)</div>
                          <div className="flex flex-wrap gap-2">
                            {mediafireOptions.map((o,i)=> (
                              <button key={i} onClick={()=>onSelectQuality(o.quality||'')} className={`px-2 py-1 rounded-lg text-xs ${selectedQuality===o.quality? 'bg-white text-black':'bg-white/10 text-white hover:bg-white/20'}`}>{o.quality || '—'}</button>
                            ))}
                          </div>
                        </div>
                      )}
                    </motion.div>
                  )}
                </AnimatePresence>
              </div>
              <button aria-label="fullscreen" onClick={handleFullscreen} className="p-2 rounded-full bg-white/10 hover:bg-white/20 text-white"><Maximize2 className="w-5 h-5"/></button>
            </div>
          </div>
        </div>
      ) : (
        <iframe src={iframeSrc} className="w-full h-full" allowFullScreen referrerPolicy="no-referrer" />
      )}

      {/* Hint overlay */}
      {!selectedEpisode && (
        <div className="absolute inset-0 flex items-center justify-center">
          <div className="px-6 py-4 rounded-xl bg-white/10 border border-white/20 text-white" style={{ fontFamily: 'var(--font-normal-text)' }}>
            اختر حلقة لبدء المشاهدة
          </div>
        </div>
      )}
    </div>
  );
}
