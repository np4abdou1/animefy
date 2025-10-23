using System;
using System.Globalization;
using System.Text;

namespace System.Xml
{
	// Token: 0x02000020 RID: 32
	internal class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x06000105 RID: 261 RVA: 0x00008382 File Offset: 0x00006582
		internal CharEntityEncoderFallbackBuffer(CharEntityEncoderFallback parent)
		{
			this.parent = parent;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000083A4 File Offset: 0x000065A4
		public override bool Fallback(char charUnknown, int index)
		{
			if (this.charEntityIndex >= 0)
			{
				new EncoderExceptionFallback().CreateFallbackBuffer().Fallback(charUnknown, index);
			}
			if (this.parent.CanReplaceAt(index))
			{
				this.charEntity = string.Format(CultureInfo.InvariantCulture, "&#x{0:X};", new object[]
				{
					(int)charUnknown
				});
				this.charEntityIndex = 0;
				return true;
			}
			new EncoderExceptionFallback().CreateFallbackBuffer().Fallback(charUnknown, index);
			return false;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000841C File Offset: 0x0000661C
		public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			if (!char.IsSurrogatePair(charUnknownHigh, charUnknownLow))
			{
				throw XmlConvert.CreateInvalidSurrogatePairException(charUnknownHigh, charUnknownLow);
			}
			if (this.charEntityIndex >= 0)
			{
				new EncoderExceptionFallback().CreateFallbackBuffer().Fallback(charUnknownHigh, charUnknownLow, index);
			}
			if (this.parent.CanReplaceAt(index))
			{
				this.charEntity = string.Format(CultureInfo.InvariantCulture, "&#x{0:X};", new object[]
				{
					this.SurrogateCharToUtf32(charUnknownHigh, charUnknownLow)
				});
				this.charEntityIndex = 0;
				return true;
			}
			new EncoderExceptionFallback().CreateFallbackBuffer().Fallback(charUnknownHigh, charUnknownLow, index);
			return false;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000084AC File Offset: 0x000066AC
		public override char GetNextChar()
		{
			if (this.charEntityIndex == this.charEntity.Length)
			{
				this.charEntityIndex = -1;
			}
			if (this.charEntityIndex == -1)
			{
				return '\0';
			}
			string text = this.charEntity;
			int num = this.charEntityIndex;
			this.charEntityIndex = num + 1;
			return text[num];
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000084FA File Offset: 0x000066FA
		public override bool MovePrevious()
		{
			if (this.charEntityIndex == -1)
			{
				return false;
			}
			if (this.charEntityIndex > 0)
			{
				this.charEntityIndex--;
				return true;
			}
			return false;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00008521 File Offset: 0x00006721
		public override int Remaining
		{
			get
			{
				if (this.charEntityIndex == -1)
				{
					return 0;
				}
				return this.charEntity.Length - this.charEntityIndex;
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00008540 File Offset: 0x00006740
		public override void Reset()
		{
			this.charEntityIndex = -1;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00008549 File Offset: 0x00006749
		private int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate)
		{
			return XmlCharType.CombineSurrogateChar((int)lowSurrogate, (int)highSurrogate);
		}

		// Token: 0x040000F9 RID: 249
		private CharEntityEncoderFallback parent;

		// Token: 0x040000FA RID: 250
		private string charEntity = string.Empty;

		// Token: 0x040000FB RID: 251
		private int charEntityIndex = -1;
	}
}
