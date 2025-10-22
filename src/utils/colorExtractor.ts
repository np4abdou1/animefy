/**
 * Extract dominant/accent color from an image
 */
export async function extractAccentColor(imageUrl: string): Promise<string> {
  return new Promise((resolve) => {
    const img = new Image();
    img.crossOrigin = 'Anonymous';
    
    img.onload = () => {
      try {
        const canvas = document.createElement('canvas');
        const ctx = canvas.getContext('2d');
        
        if (!ctx) {
          resolve('#8B5CF6'); // fallback purple
          return;
        }

        // Use smaller canvas for faster processing
        canvas.width = 100;
        canvas.height = 100;
        
        ctx.drawImage(img, 0, 0, 100, 100);
        const imageData = ctx.getImageData(0, 0, 100, 100);
        const pixels = imageData.data;
        
        // Color frequency map
        const colorMap: { [key: string]: number } = {};
        
        // Sample pixels and find vibrant colors
        for (let i = 0; i < pixels.length; i += 4) {
          const r = pixels[i];
          const g = pixels[i + 1];
          const b = pixels[i + 2];
          const a = pixels[i + 3];
          
          // Skip transparent or very dark/light pixels
          if (a < 125 || (r < 30 && g < 30 && b < 30) || (r > 225 && g > 225 && b > 225)) {
            continue;
          }
          
          // Check if color is vibrant enough (saturation check)
          const max = Math.max(r, g, b);
          const min = Math.min(r, g, b);
          const saturation = max === 0 ? 0 : (max - min) / max;
          
          // Only count vibrant colors
          if (saturation > 0.3) {
            // Round to reduce variations
            const rRounded = Math.round(r / 10) * 10;
            const gRounded = Math.round(g / 10) * 10;
            const bRounded = Math.round(b / 10) * 10;
            
            const key = `${rRounded},${gRounded},${bRounded}`;
            colorMap[key] = (colorMap[key] || 0) + 1;
          }
        }
        
        // Find most common vibrant color
        let maxCount = 0;
        let dominantColor = '139,92,246'; // fallback
        
        for (const [color, count] of Object.entries(colorMap)) {
          if (count > maxCount) {
            maxCount = count;
            dominantColor = color;
          }
        }
        
        const [r, g, b] = dominantColor.split(',').map(Number);
        
        // Boost saturation for more vibrant glow
        const hsl = rgbToHsl(r, g, b);
        hsl.s = Math.min(1, hsl.s * 1.5); // Increase saturation by 50%
        hsl.l = Math.max(0.4, Math.min(0.6, hsl.l)); // Ensure good brightness
        
        const rgb = hslToRgb(hsl.h, hsl.s, hsl.l);
        const hex = `#${rgb.r.toString(16).padStart(2, '0')}${rgb.g.toString(16).padStart(2, '0')}${rgb.b.toString(16).padStart(2, '0')}`;
        
        resolve(hex);
      } catch (error) {
        console.error('Error extracting color:', error);
        resolve('#8B5CF6'); // fallback purple
      }
    };
    
    img.onerror = () => {
      resolve('#8B5CF6'); // fallback purple
    };
    
    img.src = imageUrl;
  });
}

// RGB to HSL conversion
function rgbToHsl(r: number, g: number, b: number): { h: number; s: number; l: number } {
  r /= 255;
  g /= 255;
  b /= 255;
  
  const max = Math.max(r, g, b);
  const min = Math.min(r, g, b);
  let h = 0;
  let s = 0;
  const l = (max + min) / 2;
  
  if (max !== min) {
    const d = max - min;
    s = l > 0.5 ? d / (2 - max - min) : d / (max + min);
    
    switch (max) {
      case r:
        h = ((g - b) / d + (g < b ? 6 : 0)) / 6;
        break;
      case g:
        h = ((b - r) / d + 2) / 6;
        break;
      case b:
        h = ((r - g) / d + 4) / 6;
        break;
    }
  }
  
  return { h, s, l };
}

// HSL to RGB conversion
function hslToRgb(h: number, s: number, l: number): { r: number; g: number; b: number } {
  let r, g, b;
  
  if (s === 0) {
    r = g = b = l;
  } else {
    const hue2rgb = (p: number, q: number, t: number) => {
      if (t < 0) t += 1;
      if (t > 1) t -= 1;
      if (t < 1 / 6) return p + (q - p) * 6 * t;
      if (t < 1 / 2) return q;
      if (t < 2 / 3) return p + (q - p) * (2 / 3 - t) * 6;
      return p;
    };
    
    const q = l < 0.5 ? l * (1 + s) : l + s - l * s;
    const p = 2 * l - q;
    
    r = hue2rgb(p, q, h + 1 / 3);
    g = hue2rgb(p, q, h);
    b = hue2rgb(p, q, h - 1 / 3);
  }
  
  return {
    r: Math.round(r * 255),
    g: Math.round(g * 255),
    b: Math.round(b * 255),
  };
}
