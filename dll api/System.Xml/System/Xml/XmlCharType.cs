using System;
using System.Threading;

namespace System.Xml
{
	// Token: 0x0200019C RID: 412
	internal struct XmlCharType
	{
		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x0005E03C File Offset: 0x0005C23C
		private static object StaticLock
		{
			get
			{
				if (XmlCharType.s_Lock == null)
				{
					object value = new object();
					Interlocked.CompareExchange<object>(ref XmlCharType.s_Lock, value, null);
				}
				return XmlCharType.s_Lock;
			}
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0005E068 File Offset: 0x0005C268
		private static void InitInstance()
		{
			object staticLock = XmlCharType.StaticLock;
			lock (staticLock)
			{
				if (XmlCharType.s_CharProperties == null)
				{
					byte[] chProps = new byte[65536];
					XmlCharType.SetProperties(chProps, "\t\n\r\r  ", 1);
					XmlCharType.SetProperties(chProps, "AZazÀÖØöøıĴľŁňŊžƀǃǍǰǴǵǺȗɐʨʻˁΆΆΈΊΌΌΎΡΣώϐϖϚϚϜϜϞϞϠϠϢϳЁЌЎяёќўҁҐӄӇӈӋӌӐӫӮӵӸӹԱՖՙՙաֆאתװײءغفيٱڷںھۀێېۓەەۥۦअहऽऽक़ॡঅঌএঐওনপরললশহড়ঢ়য়ৡৰৱਅਊਏਐਓਨਪਰਲਲ਼ਵਸ਼ਸਹਖ਼ੜਫ਼ਫ਼ੲੴઅઋઍઍએઑઓનપરલળવહઽઽૠૠଅଌଏଐଓନପରଲଳଶହଽଽଡ଼ଢ଼ୟୡஅஊஎஐஒகஙசஜஜஞடணதநபமவஷஹఅఌఎఐఒనపళవహౠౡಅಌಎಐಒನಪಳವಹೞೞೠೡഅഌഎഐഒനപഹൠൡกฮะะาำเๅກຂຄຄງຈຊຊຍຍດທນຟມຣລລວວສຫອຮະະາຳຽຽເໄཀཇཉཀྵႠჅაჶᄀᄀᄂᄃᄅᄇᄉᄉᄋᄌᄎᄒᄼᄼᄾᄾᅀᅀᅌᅌᅎᅎᅐᅐᅔᅕᅙᅙᅟᅡᅣᅣᅥᅥᅧᅧᅩᅩᅭᅮᅲᅳᅵᅵᆞᆞᆨᆨᆫᆫᆮᆯᆷᆸᆺᆺᆼᇂᇫᇫᇰᇰᇹᇹḀẛẠỹἀἕἘἝἠὅὈὍὐὗὙὙὛὛὝὝὟώᾀᾴᾶᾼιιῂῄῆῌῐΐῖΊῠῬῲῴῶῼΩΩKÅ℮℮ↀↂ〇〇〡〩ぁゔァヺㄅㄬ一龥가힣", 2);
					XmlCharType.SetProperties(chProps, "AZ__azÀÖØöøıĴľŁňŊžƀǃǍǰǴǵǺȗɐʨʻˁΆΆΈΊΌΌΎΡΣώϐϖϚϚϜϜϞϞϠϠϢϳЁЌЎяёќўҁҐӄӇӈӋӌӐӫӮӵӸӹԱՖՙՙաֆאתװײءغفيٱڷںھۀێېۓەەۥۦअहऽऽक़ॡঅঌএঐওনপরললশহড়ঢ়য়ৡৰৱਅਊਏਐਓਨਪਰਲਲ਼ਵਸ਼ਸਹਖ਼ੜਫ਼ਫ਼ੲੴઅઋઍઍએઑઓનપરલળવહઽઽૠૠଅଌଏଐଓନପରଲଳଶହଽଽଡ଼ଢ଼ୟୡஅஊஎஐஒகஙசஜஜஞடணதநபமவஷஹఅఌఎఐఒనపళవహౠౡಅಌಎಐಒನಪಳವಹೞೞೠೡഅഌഎഐഒനപഹൠൡกฮะะาำเๅກຂຄຄງຈຊຊຍຍດທນຟມຣລລວວສຫອຮະະາຳຽຽເໄཀཇཉཀྵႠჅაჶᄀᄀᄂᄃᄅᄇᄉᄉᄋᄌᄎᄒᄼᄼᄾᄾᅀᅀᅌᅌᅎᅎᅐᅐᅔᅕᅙᅙᅟᅡᅣᅣᅥᅥᅧᅧᅩᅩᅭᅮᅲᅳᅵᅵᆞᆞᆨᆨᆫᆫᆮᆯᆷᆸᆺᆺᆼᇂᇫᇫᇰᇰᇹᇹḀẛẠỹἀἕἘἝἠὅὈὍὐὗὙὙὛὛὝὝὟώᾀᾴᾶᾼιιῂῄῆῌῐΐῖΊῠῬῲῴῶῼΩΩKÅ℮℮ↀↂ〇〇〡〩ぁゔァヺㄅㄬ一龥가힣", 4);
					XmlCharType.SetProperties(chProps, "-.09AZ__az··ÀÖØöøıĴľŁňŊžƀǃǍǰǴǵǺȗɐʨʻˁːˑ̀͠͡ͅΆΊΌΌΎΡΣώϐϖϚϚϜϜϞϞϠϠϢϳЁЌЎяёќўҁ҃҆ҐӄӇӈӋӌӐӫӮӵӸӹԱՖՙՙաֆֹֻֽֿֿׁׂ֑֣֡ׄׄאתװײءغـْ٠٩ٰڷںھۀێېۓە۪ۭۨ۰۹ँःअह़्॑॔क़ॣ०९ঁঃঅঌএঐওনপরললশহ়়াৄেৈো্ৗৗড়ঢ়য়ৣ০ৱਂਂਅਊਏਐਓਨਪਰਲਲ਼ਵਸ਼ਸਹ਼਼ਾੂੇੈੋ੍ਖ਼ੜਫ਼ਫ਼੦ੴઁઃઅઋઍઍએઑઓનપરલળવહ઼ૅેૉો્ૠૠ૦૯ଁଃଅଌଏଐଓନପରଲଳଶହ଼ୃେୈୋ୍ୖୗଡ଼ଢ଼ୟୡ୦୯ஂஃஅஊஎஐஒகஙசஜஜஞடணதநபமவஷஹாூெைொ்ௗௗ௧௯ఁఃఅఌఎఐఒనపళవహాౄెైొ్ౕౖౠౡ౦౯ಂಃಅಌಎಐಒನಪಳವಹಾೄೆೈೊ್ೕೖೞೞೠೡ೦೯ംഃഅഌഎഐഒനപഹാൃെൈൊ്ൗൗൠൡ൦൯กฮะฺเ๎๐๙ກຂຄຄງຈຊຊຍຍດທນຟມຣລລວວສຫອຮະູົຽເໄໆໆ່ໍ໐໙༘༙༠༩༹༹༵༵༷༷༾ཇཉཀྵ྄ཱ྆ྋྐྕྗྗྙྭྱྷྐྵྐྵႠჅაჶᄀᄀᄂᄃᄅᄇᄉᄉᄋᄌᄎᄒᄼᄼᄾᄾᅀᅀᅌᅌᅎᅎᅐᅐᅔᅕᅙᅙᅟᅡᅣᅣᅥᅥᅧᅧᅩᅩᅭᅮᅲᅳᅵᅵᆞᆞᆨᆨᆫᆫᆮᆯᆷᆸᆺᆺᆼᇂᇫᇫᇰᇰᇹᇹḀẛẠỹἀἕἘἝἠὅὈὍὐὗὙὙὛὛὝὝὟώᾀᾴᾶᾼιιῂῄῆῌῐΐῖΊῠῬῲῴῶῼ⃐⃜⃡⃡ΩΩKÅ℮℮ↀↂ々々〇〇〡〯〱〵ぁゔ゙゚ゝゞァヺーヾㄅㄬ一龥가힣", 8);
					XmlCharType.SetProperties(chProps, "\t\n\r\r ퟿�", 16);
					XmlCharType.SetProperties(chProps, "-.09AZ__az··ÀÖØöøıĴľŁňŊžƀǃǍǰǴǵǺȗɐʨʻˁːˑ̀͠͡ͅΆΊΌΌΎΡΣώϐϖϚϚϜϜϞϞϠϠϢϳЁЌЎяёќўҁ҃҆ҐӄӇӈӋӌӐӫӮӵӸӹԱՖՙՙաֆֹֻֽֿֿׁׂ֑֣֡ׄׄאתװײءغـْ٠٩ٰڷںھۀێېۓە۪ۭۨ۰۹ँःअह़्॑॔क़ॣ०९ঁঃঅঌএঐওনপরললশহ়়াৄেৈো্ৗৗড়ঢ়য়ৣ০ৱਂਂਅਊਏਐਓਨਪਰਲਲ਼ਵਸ਼ਸਹ਼਼ਾੂੇੈੋ੍ਖ਼ੜਫ਼ਫ਼੦ੴઁઃઅઋઍઍએઑઓનપરલળવહ઼ૅેૉો્ૠૠ૦૯ଁଃଅଌଏଐଓନପରଲଳଶହ଼ୃେୈୋ୍ୖୗଡ଼ଢ଼ୟୡ୦୯ஂஃஅஊஎஐஒகஙசஜஜஞடணதநபமவஷஹாூெைொ்ௗௗ௧௯ఁఃఅఌఎఐఒనపళవహాౄెైొ్ౕౖౠౡ౦౯ಂಃಅಌಎಐಒನಪಳವಹಾೄೆೈೊ್ೕೖೞೞೠೡ೦೯ംഃഅഌഎഐഒനപഹാൃെൈൊ്ൗൗൠൡ൦൯กฮะฺเ๎๐๙ກຂຄຄງຈຊຊຍຍດທນຟມຣລລວວສຫອຮະູົຽເໄໆໆ່ໍ໐໙༘༙༠༩༹༹༵༵༷༷༾ཇཉཀྵ྄ཱ྆ྋྐྕྗྗྙྭྱྷྐྵྐྵႠჅაჶᄀᄀᄂᄃᄅᄇᄉᄉᄋᄌᄎᄒᄼᄼᄾᄾᅀᅀᅌᅌᅎᅎᅐᅐᅔᅕᅙᅙᅟᅡᅣᅣᅥᅥᅧᅧᅩᅩᅭᅮᅲᅳᅵᅵᆞᆞᆨᆨᆫᆫᆮᆯᆷᆸᆺᆺᆼᇂᇫᇫᇰᇰᇹᇹḀẛẠỹἀἕἘἝἠὅὈὍὐὗὙὙὛὛὝὝὟώᾀᾴᾶᾼιιῂῄῆῌῐΐῖΊῠῬῲῴῶῼ⃐⃜⃡⃡ΩΩKÅ℮℮ↀↂ々々〇〇〡〯〱〵ぁゔ゙゚ゝゞァヺーヾㄅㄬ一龥가힣", 32);
					XmlCharType.SetProperties(chProps, " %';=\\^퟿�", 64);
					XmlCharType.SetProperties(chProps, " !#%(;==?퟿�", 128);
					Thread.MemoryBarrier();
					XmlCharType.s_CharProperties = chProps;
				}
			}
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x0005E12C File Offset: 0x0005C32C
		private static void SetProperties(byte[] chProps, string ranges, byte value)
		{
			for (int i = 0; i < ranges.Length; i += 2)
			{
				int j = (int)ranges[i];
				int num = (int)ranges[i + 1];
				while (j <= num)
				{
					int num2 = j;
					chProps[num2] |= value;
					j++;
				}
			}
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0005E173 File Offset: 0x0005C373
		private XmlCharType(byte[] charProperties)
		{
			this.charProperties = charProperties;
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x0005E17C File Offset: 0x0005C37C
		public static XmlCharType Instance
		{
			get
			{
				if (XmlCharType.s_CharProperties == null)
				{
					XmlCharType.InitInstance();
				}
				return new XmlCharType(XmlCharType.s_CharProperties);
			}
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x0005E198 File Offset: 0x0005C398
		public bool IsWhiteSpace(char ch)
		{
			return (this.charProperties[(int)ch] & 1) > 0;
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x0005E1A7 File Offset: 0x0005C3A7
		public bool IsNCNameSingleChar(char ch)
		{
			return (this.charProperties[(int)ch] & 8) > 0;
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x0005E1B6 File Offset: 0x0005C3B6
		public bool IsStartNCNameSingleChar(char ch)
		{
			return (this.charProperties[(int)ch] & 4) > 0;
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x0005E1C5 File Offset: 0x0005C3C5
		public bool IsNameSingleChar(char ch)
		{
			return this.IsNCNameSingleChar(ch) || ch == ':';
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x0005E1D7 File Offset: 0x0005C3D7
		public bool IsCharData(char ch)
		{
			return (this.charProperties[(int)ch] & 16) > 0;
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0005E1E7 File Offset: 0x0005C3E7
		public bool IsPubidChar(char ch)
		{
			return ch < '\u0080' && ((int)"␀\0ﾻ꿿￿蟿￾߿"[(int)(ch >> 4)] & 1 << (int)(ch & '\u000f')) != 0;
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0005E20D File Offset: 0x0005C40D
		internal bool IsTextChar(char ch)
		{
			return (this.charProperties[(int)ch] & 64) > 0;
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x0005E21D File Offset: 0x0005C41D
		public bool IsLetter(char ch)
		{
			return (this.charProperties[(int)ch] & 2) > 0;
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0005E22C File Offset: 0x0005C42C
		public bool IsNCNameCharXml4e(char ch)
		{
			return (this.charProperties[(int)ch] & 32) > 0;
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0005E23C File Offset: 0x0005C43C
		public bool IsStartNCNameCharXml4e(char ch)
		{
			return this.IsLetter(ch) || ch == '_';
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0005E24E File Offset: 0x0005C44E
		public bool IsNameCharXml4e(char ch)
		{
			return this.IsNCNameCharXml4e(ch) || ch == ':';
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0005E260 File Offset: 0x0005C460
		public static bool IsDigit(char ch)
		{
			return XmlCharType.InRange((int)ch, 48, 57);
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x0005E26C File Offset: 0x0005C46C
		internal static bool IsHighSurrogate(int ch)
		{
			return XmlCharType.InRange(ch, 55296, 56319);
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x0005E27E File Offset: 0x0005C47E
		internal static bool IsLowSurrogate(int ch)
		{
			return XmlCharType.InRange(ch, 56320, 57343);
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x0005E290 File Offset: 0x0005C490
		internal static bool IsSurrogate(int ch)
		{
			return XmlCharType.InRange(ch, 55296, 57343);
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0005E2A2 File Offset: 0x0005C4A2
		internal static int CombineSurrogateChar(int lowChar, int highChar)
		{
			return lowChar - 56320 | (highChar - 55296 << 10) + 65536;
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x0005E2BC File Offset: 0x0005C4BC
		internal static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar)
		{
			int num = combinedChar - 65536;
			lowChar = (char)(56320 + num % 1024);
			highChar = (char)(55296 + num / 1024);
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0005E2F1 File Offset: 0x0005C4F1
		internal bool IsOnlyWhitespace(string str)
		{
			return this.IsOnlyWhitespaceWithPos(str) == -1;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x0005E300 File Offset: 0x0005C500
		internal int IsOnlyWhitespaceWithPos(string str)
		{
			if (str != null)
			{
				for (int i = 0; i < str.Length; i++)
				{
					if ((this.charProperties[(int)str[i]] & 1) == 0)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0005E338 File Offset: 0x0005C538
		internal int IsOnlyCharData(string str)
		{
			if (str != null)
			{
				for (int i = 0; i < str.Length; i++)
				{
					if ((this.charProperties[(int)str[i]] & 16) == 0)
					{
						if (i + 1 >= str.Length || !XmlCharType.IsHighSurrogate((int)str[i]) || !XmlCharType.IsLowSurrogate((int)str[i + 1]))
						{
							return i;
						}
						i++;
					}
				}
			}
			return -1;
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0005E39C File Offset: 0x0005C59C
		internal static bool IsOnlyDigits(string str, int startPos, int len)
		{
			for (int i = startPos; i < startPos + len; i++)
			{
				if (!XmlCharType.IsDigit(str[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0005E3C8 File Offset: 0x0005C5C8
		internal int IsPublicId(string str)
		{
			if (str != null)
			{
				for (int i = 0; i < str.Length; i++)
				{
					if (!this.IsPubidChar(str[i]))
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0005E3FB File Offset: 0x0005C5FB
		private static bool InRange(int value, int start, int end)
		{
			return value - start <= end - start;
		}

		// Token: 0x04000A96 RID: 2710
		private static object s_Lock;

		// Token: 0x04000A97 RID: 2711
		private static volatile byte[] s_CharProperties;

		// Token: 0x04000A98 RID: 2712
		internal byte[] charProperties;
	}
}
