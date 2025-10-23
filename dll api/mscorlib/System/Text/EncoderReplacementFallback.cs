using System;
using System.Runtime.Serialization;

namespace System.Text
{
	/// <summary>Provides a failure handling mechanism, called a fallback, for an input character that cannot be converted to an output byte sequence. The fallback uses a user-specified replacement string instead of the original input character. This class cannot be inherited.</summary>
	// Token: 0x02000257 RID: 599
	[Serializable]
	public sealed class EncoderReplacementFallback : EncoderFallback, ISerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Text.EncoderReplacementFallback" /> class.</summary>
		// Token: 0x06001497 RID: 5271 RVA: 0x0005133B File Offset: 0x0004F53B
		public EncoderReplacementFallback() : this("?")
		{
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00051348 File Offset: 0x0004F548
		internal EncoderReplacementFallback(SerializationInfo info, StreamingContext context)
		{
			try
			{
				this._strDefault = info.GetString("strDefault");
			}
			catch
			{
				this._strDefault = info.GetString("_strDefault");
			}
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x00051394 File Offset: 0x0004F594
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("strDefault", this._strDefault);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.EncoderReplacementFallback" /> class using a specified replacement string.</summary>
		/// <param name="replacement">A string that is converted in an encoding operation in place of an input character that cannot be encoded.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="replacement" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="replacement" /> contains an invalid surrogate pair. In other words, the surrogate does not consist of one high surrogate component followed by one low surrogate component.</exception>
		// Token: 0x0600149A RID: 5274 RVA: 0x000513A8 File Offset: 0x0004F5A8
		public EncoderReplacementFallback(string replacement)
		{
			if (replacement == null)
			{
				throw new ArgumentNullException("replacement");
			}
			bool flag = false;
			for (int i = 0; i < replacement.Length; i++)
			{
				if (char.IsSurrogate(replacement, i))
				{
					if (char.IsHighSurrogate(replacement, i))
					{
						if (flag)
						{
							break;
						}
						flag = true;
					}
					else
					{
						if (!flag)
						{
							flag = true;
							break;
						}
						flag = false;
					}
				}
				else if (flag)
				{
					break;
				}
			}
			if (flag)
			{
				throw new ArgumentException(SR.Format("String contains invalid Unicode code points.", "replacement"));
			}
			this._strDefault = replacement;
		}

		/// <summary>Gets the replacement string that is the value of the <see cref="T:System.Text.EncoderReplacementFallback" /> object.</summary>
		/// <returns>A substitute string that is used in place of an input character that cannot be encoded.</returns>
		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x00051422 File Offset: 0x0004F622
		public string DefaultString
		{
			get
			{
				return this._strDefault;
			}
		}

		/// <summary>Creates a <see cref="T:System.Text.EncoderFallbackBuffer" /> object that is initialized with the replacement string of this <see cref="T:System.Text.EncoderReplacementFallback" /> object.</summary>
		/// <returns>A <see cref="T:System.Text.EncoderFallbackBuffer" /> object equal to this <see cref="T:System.Text.EncoderReplacementFallback" /> object. </returns>
		// Token: 0x0600149C RID: 5276 RVA: 0x0005142A File Offset: 0x0004F62A
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			return new EncoderReplacementFallbackBuffer(this);
		}

		/// <summary>Gets the number of characters in the replacement string for the <see cref="T:System.Text.EncoderReplacementFallback" /> object.</summary>
		/// <returns>The number of characters in the string used in place of an input character that cannot be encoded.</returns>
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x00051432 File Offset: 0x0004F632
		public override int MaxCharCount
		{
			get
			{
				return this._strDefault.Length;
			}
		}

		/// <summary>Indicates whether the value of a specified object is equal to the <see cref="T:System.Text.EncoderReplacementFallback" /> object.</summary>
		/// <param name="value">A <see cref="T:System.Text.EncoderReplacementFallback" /> object.</param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="value" /> parameter specifies an <see cref="T:System.Text.EncoderReplacementFallback" /> object and the replacement string of that object is equal to the replacement string of this <see cref="T:System.Text.EncoderReplacementFallback" /> object; otherwise, <see langword="false" />. </returns>
		// Token: 0x0600149E RID: 5278 RVA: 0x00051440 File Offset: 0x0004F640
		public override bool Equals(object value)
		{
			EncoderReplacementFallback encoderReplacementFallback = value as EncoderReplacementFallback;
			return encoderReplacementFallback != null && this._strDefault == encoderReplacementFallback._strDefault;
		}

		/// <summary>Retrieves the hash code for the value of the <see cref="T:System.Text.EncoderReplacementFallback" /> object.</summary>
		/// <returns>The hash code of the value of the object.</returns>
		// Token: 0x0600149F RID: 5279 RVA: 0x0005146A File Offset: 0x0004F66A
		public override int GetHashCode()
		{
			return this._strDefault.GetHashCode();
		}

		// Token: 0x04000836 RID: 2102
		private string _strDefault;
	}
}
