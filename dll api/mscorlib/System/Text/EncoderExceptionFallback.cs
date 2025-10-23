using System;

namespace System.Text
{
	/// <summary>Provides a failure-handling mechanism, called a fallback, for an input character that cannot be converted to an output byte sequence. The fallback throws an exception if an input character cannot be converted to an output byte sequence. This class cannot be inherited.</summary>
	// Token: 0x02000251 RID: 593
	[Serializable]
	public sealed class EncoderExceptionFallback : EncoderFallback
	{
		/// <summary>Returns an encoder fallback buffer that throws an exception if it cannot convert a character sequence to a byte sequence.</summary>
		/// <returns>An encoder fallback buffer that throws an exception when it cannot encode a character sequence.</returns>
		// Token: 0x0600146C RID: 5228 RVA: 0x00050BC3 File Offset: 0x0004EDC3
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			return new EncoderExceptionFallbackBuffer();
		}

		/// <summary>Gets the maximum number of characters this instance can return.</summary>
		/// <returns>The return value is always zero.</returns>
		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public override int MaxCharCount
		{
			get
			{
				return 0;
			}
		}

		/// <summary>Indicates whether the current <see cref="T:System.Text.EncoderExceptionFallback" /> object and a specified object are equal.</summary>
		/// <param name="value">An object that derives from the <see cref="T:System.Text.EncoderExceptionFallback" /> class.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is not <see langword="null" /> (<see langword="Nothing" /> in Visual Basic .NET) and is a <see cref="T:System.Text.EncoderExceptionFallback" /> object; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600146E RID: 5230 RVA: 0x00050BCA File Offset: 0x0004EDCA
		public override bool Equals(object value)
		{
			return value is EncoderExceptionFallback;
		}

		/// <summary>Retrieves the hash code for this instance.</summary>
		/// <returns>The return value is always the same arbitrary value, and has no special significance. </returns>
		// Token: 0x0600146F RID: 5231 RVA: 0x00050BD7 File Offset: 0x0004EDD7
		public override int GetHashCode()
		{
			return 654;
		}
	}
}
