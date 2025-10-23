using System;
using System.Threading;

namespace System.Text
{
	/// <summary>Provides a failure-handling mechanism, called a fallback, for an encoded input byte sequence that cannot be converted to an output character. </summary>
	// Token: 0x02000249 RID: 585
	[Serializable]
	public abstract class DecoderFallback
	{
		/// <summary>Gets an object that outputs a substitute string in place of an input byte sequence that cannot be decoded.</summary>
		/// <returns>A type derived from the <see cref="T:System.Text.DecoderFallback" /> class. The default value is a <see cref="T:System.Text.DecoderReplacementFallback" /> object that emits the QUESTION MARK character ("?", U+003F) in place of unknown byte sequences. </returns>
		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x0004FD0E File Offset: 0x0004DF0E
		public static DecoderFallback ReplacementFallback
		{
			get
			{
				DecoderFallback result;
				if ((result = DecoderFallback.s_replacementFallback) == null)
				{
					result = (Interlocked.CompareExchange<DecoderFallback>(ref DecoderFallback.s_replacementFallback, new DecoderReplacementFallback(), null) ?? DecoderFallback.s_replacementFallback);
				}
				return result;
			}
		}

		/// <summary>Gets an object that throws an exception when an input byte sequence cannot be decoded.</summary>
		/// <returns>A type derived from the <see cref="T:System.Text.DecoderFallback" /> class. The default value is a <see cref="T:System.Text.DecoderExceptionFallback" /> object.</returns>
		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x0004FD32 File Offset: 0x0004DF32
		public static DecoderFallback ExceptionFallback
		{
			get
			{
				DecoderFallback result;
				if ((result = DecoderFallback.s_exceptionFallback) == null)
				{
					result = (Interlocked.CompareExchange<DecoderFallback>(ref DecoderFallback.s_exceptionFallback, new DecoderExceptionFallback(), null) ?? DecoderFallback.s_exceptionFallback);
				}
				return result;
			}
		}

		/// <summary>When overridden in a derived class, initializes a new instance of the <see cref="T:System.Text.DecoderFallbackBuffer" /> class. </summary>
		/// <returns>An object that provides a fallback buffer for a decoder.</returns>
		// Token: 0x06001429 RID: 5161
		public abstract DecoderFallbackBuffer CreateFallbackBuffer();

		/// <summary>When overridden in a derived class, gets the maximum number of characters the current <see cref="T:System.Text.DecoderFallback" /> object can return.</summary>
		/// <returns>The maximum number of characters the current <see cref="T:System.Text.DecoderFallback" /> object can return.</returns>
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600142A RID: 5162
		public abstract int MaxCharCount { get; }

		// Token: 0x0400080F RID: 2063
		private static DecoderFallback s_replacementFallback;

		// Token: 0x04000810 RID: 2064
		private static DecoderFallback s_exceptionFallback;
	}
}
