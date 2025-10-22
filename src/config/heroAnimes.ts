export interface HeroAnime {
  id: number;
  titleArabic: string;
  titleEnglish: string;
  description: string;
  thumbnail: string;
  redirectPage: string;
  accentColor: string; // Primary color from the anime's theme
  secondaryColor?: string; // Optional secondary color for gradient effects
}

export const heroAnimes: HeroAnime[] = [
  {
    id: 1,
    titleArabic: "ون بنش مان",
    titleEnglish: "One Punch Man",
    description: "قصة رجل خارق يستطيع هزيمة أي عدو بلكمة واحدة فقط",
    thumbnail: "/hero_section/onepunchman.jpg",
    redirectPage: "/anime/one-punch-man",
    accentColor: "#927c00ff", // Gold/Yellow - Saitama's iconic color
    secondaryColor: "#802200ff" // Orange accent
  },
  {
    id: 2,
    titleArabic: "ماي هيرو أكاديميا",
    titleEnglish: "My Hero Academia",
    description: "في عالم يمتلك فيه الجميع قوى خارقة، يسعى فتى بلا قوة ليصبح أعظم بطل",
    thumbnail: "/hero_section/myhero.jpg",
    redirectPage: "/anime/my-hero-academia",
    accentColor: "#006f39ff", // Green - Deku's iconic color
    secondaryColor: "#003043ff" // Blue accent
  },
  {
    id: 3,
    titleArabic: "جاتشياكوتا",
    titleEnglish: "Gachiakuta",
    description: "فتى يعيش في عالم القمامة يسعى للبقاء على قيد الحياة والكشف عن حقيقة ماضيه",
    thumbnail: "/hero_section/Gachiakuta-Slider.jpg",
    redirectPage: "/anime/gachiakuta",
    accentColor: "#615e00ff", // Purple - Dark fantasy theme
    secondaryColor: "#5b5e00ff" // Bright purple accent
  }
];
