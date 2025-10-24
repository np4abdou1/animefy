using System;
using System.Threading;

namespace System.Text
{
	/// <summary>Provides a failure-handling mechanism, called a fallback, for an input character that cannot be converted to an encoded output byte sequence. </summary>
	// Token: 0x02000254 RID: 596
	[Serializable]
	public abstract class EncoderFallback
	{
		/// <summary>Gets an object that outputs a substitute string in place of an input character that cannot be encoded.</summary>
		/// <returns>A type derived from the <see cref="T:System.Text.EncoderFallback" /> class. The default value is a <see cref="T:System.Text.EncoderReplacementFallback" /> object that replaces unknown input characters with the QUESTION MARK character ("?", U+003F).</returns>
		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x00050D40 File Offset: 0x0004EF40
		public static EncoderFallback ReplacementFallback
		{
			get
			{
				if (EncoderFallback.s_replacementFallback == null)
				{
					Interlocked.CompareExchange<EncoderFallback>(ref EncoderFallback.s_replacementFallback, new EncoderReplacementFallback(), null);
				}
				return EncoderFallback.s_replacementFallback;
			}
		}

		/// <summary>Gets an object that throws an exception when an input character cannot be encoded.</summary>
		/// <returns>A type derived from the <see cref="T:System.Text.EncoderFallback" /> class. The default value is a <see cref="T:System.Text.EncoderExceptionFallback" /> object.</returns>
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x00050D5F File Offset: 0x0004EF5F
		public static EncoderFallback ExceptionFallback
		{
			get
			{
				if (EncoderFallback.s_exceptionFallback == null)
				{
					Interlocked.CompareExchange<EncoderFallback>(ref EncoderFallback.s_exceptionFallback, new EncoderExceptionFallback(), null);
				}
				return EncoderFallback.s_exceptionFallback;
			}
		}

		/// <summary>When overridden in a derived class, initializes a new instance of the <see cref="T:System.Text.EncoderFallbackBuffer" /> class. </summary>
		/// <returns>An object that provides a fallback buffer for an encoder.</returns>
		// Token: 0x0600147C RID: 5244
		public abstract EncoderFallbackBuffer CreateFallbackBuffer();

		/// <summary>When overridden in a derived class, gets the maximum number of characters the current <see cref="T:System.Text.EncoderFallback" /> object can return.</summary>
		/// <returns>The maximum number of characters the current <see cref="T:System.Text.EncoderFallback" /> object can return.</returns>
		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600147D RID: 5245
		public abstract int MaxCharCount { get; }

		// Token: 0x04000828 RID: 2088
		private static EncoderFallback s_replacementFallback;

		// Token: 0x04000829 RID: 2089
		private static EncoderFallback s_exceptionFallback;
	}
}
