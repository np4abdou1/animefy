using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System.Text
{
	/// <summary>Represents a character encoding.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x0200026E RID: 622
	[ComVisible(true)]
	[Serializable]
	public abstract class Encoding : ICloneable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Text.Encoding" /> class.</summary>
		// Token: 0x060015AC RID: 5548 RVA: 0x0005923A File Offset: 0x0005743A
		protected Encoding() : this(0)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.Encoding" /> class that corresponds to the specified code page.</summary>
		/// <param name="codePage">The code page identifier of the preferred encoding.-or- 0, to use the default encoding. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="codePage" /> is less than zero. </exception>
		// Token: 0x060015AD RID: 5549 RVA: 0x00059243 File Offset: 0x00057443
		protected Encoding(int codePage)
		{
			if (codePage < 0)
			{
				throw new ArgumentOutOfRangeException("codePage");
			}
			this.m_codePage = codePage;
			this.SetDefaultFallbacks();
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x0005926E File Offset: 0x0005746E
		internal virtual void SetDefaultFallbacks()
		{
			this.encoderFallback = new InternalEncoderBestFitFallback(this);
			this.decoderFallback = new InternalDecoderBestFitFallback(this);
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x00059288 File Offset: 0x00057488
		internal void OnDeserializing()
		{
			this.encoderFallback = null;
			this.decoderFallback = null;
			this.m_isReadOnly = true;
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x0005929F File Offset: 0x0005749F
		internal void OnDeserialized()
		{
			if (this.encoderFallback == null || this.decoderFallback == null)
			{
				this.m_deserializedFromEverett = true;
				this.SetDefaultFallbacks();
			}
			this.dataItem = null;
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x000592C5 File Offset: 0x000574C5
		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
			this.OnDeserializing();
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x000592CD File Offset: 0x000574CD
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
			this.OnDeserialized();
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x000592D5 File Offset: 0x000574D5
		[OnSerializing]
		private void OnSerializing(StreamingContext ctx)
		{
			this.dataItem = null;
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x000592E0 File Offset: 0x000574E0
		internal void DeserializeEncoding(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this.m_codePage = (int)info.GetValue("m_codePage", typeof(int));
			this.dataItem = null;
			try
			{
				this.m_isReadOnly = (bool)info.GetValue("m_isReadOnly", typeof(bool));
				this.encoderFallback = (EncoderFallback)info.GetValue("encoderFallback", typeof(EncoderFallback));
				this.decoderFallback = (DecoderFallback)info.GetValue("decoderFallback", typeof(DecoderFallback));
			}
			catch (SerializationException)
			{
				this.m_deserializedFromEverett = true;
				this.m_isReadOnly = true;
				this.SetDefaultFallbacks();
			}
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x000593AC File Offset: 0x000575AC
		internal void SerializeEncoding(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("m_isReadOnly", this.m_isReadOnly);
			info.AddValue("encoderFallback", this.EncoderFallback);
			info.AddValue("decoderFallback", this.DecoderFallback);
			info.AddValue("m_codePage", this.m_codePage);
			info.AddValue("dataItem", null);
			info.AddValue("Encoding+m_codePage", this.m_codePage);
			info.AddValue("Encoding+dataItem", null);
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060015B6 RID: 5558 RVA: 0x00059434 File Offset: 0x00057634
		private static object InternalSyncObject
		{
			get
			{
				if (Encoding.s_InternalSyncObject == null)
				{
					object value = new object();
					Interlocked.CompareExchange<object>(ref Encoding.s_InternalSyncObject, value, null);
				}
				return Encoding.s_InternalSyncObject;
			}
		}

		/// <summary>Returns the encoding associated with the specified code page identifier.</summary>
		/// <param name="codepage">The code page identifier of the preferred encoding. Possible values are listed in the Code Page column of the table that appears in the <see cref="T:System.Text.Encoding" /> class topic.-or- 0 (zero), to use the default encoding. </param>
		/// <returns>The encoding that is associated with the specified code page.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="codepage" /> is less than zero or greater than 65535. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="codepage" /> is not supported by the underlying platform. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="codepage" /> is not supported by the underlying platform. </exception>
		// Token: 0x060015B7 RID: 5559 RVA: 0x00059460 File Offset: 0x00057660
		[SecuritySafeCritical]
		public static Encoding GetEncoding(int codepage)
		{
			Encoding encoding = EncodingProvider.GetEncodingFromProvider(codepage);
			if (encoding != null)
			{
				return encoding;
			}
			if (codepage < 0 || codepage > 65535)
			{
				throw new ArgumentOutOfRangeException("codepage", Environment.GetResourceString("Valid values are between {0} and {1}, inclusive.", new object[]
				{
					0,
					65535
				}));
			}
			if (Encoding.encodings != null)
			{
				Encoding.encodings.TryGetValue(codepage, out encoding);
			}
			if (encoding == null)
			{
				object internalSyncObject = Encoding.InternalSyncObject;
				lock (internalSyncObject)
				{
					if (Encoding.encodings == null)
					{
						Encoding.encodings = new Dictionary<int, Encoding>();
					}
					if (Encoding.encodings.TryGetValue(codepage, out encoding))
					{
						return encoding;
					}
					if (codepage <= 1201)
					{
						if (codepage <= 3)
						{
							if (codepage == 0)
							{
								encoding = Encoding.Default;
								goto IL_233;
							}
							if (codepage - 1 > 2)
							{
								goto IL_1B0;
							}
						}
						else if (codepage != 42)
						{
							if (codepage == 1200)
							{
								encoding = Encoding.Unicode;
								goto IL_233;
							}
							if (codepage != 1201)
							{
								goto IL_1B0;
							}
							encoding = Encoding.BigEndianUnicode;
							goto IL_233;
						}
						throw new ArgumentException(Environment.GetResourceString("{0} is not a supported code page.", new object[]
						{
							codepage
						}), "codepage");
					}
					if (codepage <= 20127)
					{
						if (codepage == 12000)
						{
							encoding = Encoding.UTF32;
							goto IL_233;
						}
						if (codepage == 12001)
						{
							encoding = new UTF32Encoding(true, true);
							goto IL_233;
						}
						if (codepage == 20127)
						{
							encoding = Encoding.ASCII;
							goto IL_233;
						}
					}
					else
					{
						if (codepage == 28591)
						{
							encoding = Encoding.Latin1;
							goto IL_233;
						}
						if (codepage == 65000)
						{
							encoding = Encoding.UTF7;
							goto IL_233;
						}
						if (codepage == 65001)
						{
							encoding = Encoding.UTF8;
							goto IL_233;
						}
					}
					IL_1B0:
					if (EncodingTable.GetCodePageDataItem(codepage) == null)
					{
						throw new NotSupportedException(Environment.GetResourceString("No data is available for encoding {0}. For information on defining a custom encoding, see the documentation for the Encoding.RegisterProvider method.", new object[]
						{
							codepage
						}));
					}
					if (codepage != 12000)
					{
						if (codepage != 12001)
						{
							encoding = (Encoding)EncodingHelper.InvokeI18N("GetEncoding", new object[]
							{
								codepage
							});
							if (encoding == null)
							{
								throw new NotSupportedException(string.Format("Encoding {0} data could not be found. Make sure you have correct international codeset assembly installed and enabled.", codepage));
							}
						}
						else
						{
							encoding = new UTF32Encoding(true, true);
						}
					}
					else
					{
						encoding = Encoding.UTF32;
					}
					IL_233:
					Encoding.encodings.Add(codepage, encoding);
				}
				return encoding;
			}
			return encoding;
		}

		/// <summary>Returns the encoding associated with the specified code page name.</summary>
		/// <param name="name">The code page name of the preferred encoding. Any value returned by the <see cref="P:System.Text.Encoding.WebName" /> property is valid. Possible values are listed in the Name column of the table that appears in the <see cref="T:System.Text.Encoding" /> class topic.</param>
		/// <returns>The encoding  associated with the specified code page.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="name" /> is not a valid code page name.-or- The code page indicated by <paramref name="name" /> is not supported by the underlying platform. </exception>
		// Token: 0x060015B8 RID: 5560 RVA: 0x000596DC File Offset: 0x000578DC
		public static Encoding GetEncoding(string name)
		{
			Encoding encodingFromProvider = EncodingProvider.GetEncodingFromProvider(name);
			if (encodingFromProvider != null)
			{
				return encodingFromProvider;
			}
			return Encoding.GetEncoding(EncodingTable.GetCodePageFromName(name));
		}

		/// <summary>When overridden in a derived class, returns a sequence of bytes that specifies the encoding used.</summary>
		/// <returns>A byte array containing a sequence of bytes that specifies the encoding used.-or- A byte array of length zero, if a preamble is not required.</returns>
		// Token: 0x060015B9 RID: 5561 RVA: 0x00059700 File Offset: 0x00057900
		public virtual byte[] GetPreamble()
		{
			return EmptyArray<byte>.Value;
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x00059707 File Offset: 0x00057907
		public virtual ReadOnlySpan<byte> Preamble
		{
			get
			{
				return this.GetPreamble();
			}
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00059714 File Offset: 0x00057914
		private void GetDataItem()
		{
			if (this.dataItem == null)
			{
				this.dataItem = EncodingTable.GetCodePageDataItem(this.m_codePage);
				if (this.dataItem == null)
				{
					throw new NotSupportedException(Environment.GetResourceString("No data is available for encoding {0}. For information on defining a custom encoding, see the documentation for the Encoding.RegisterProvider method.", new object[]
					{
						this.m_codePage
					}));
				}
			}
		}

		/// <summary>When overridden in a derived class, gets the human-readable description of the current encoding.</summary>
		/// <returns>The human-readable description of the current <see cref="T:System.Text.Encoding" />.</returns>
		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x00059766 File Offset: 0x00057966
		public virtual string EncodingName
		{
			get
			{
				return Environment.GetResourceStringEncodingName(this.m_codePage);
			}
		}

		/// <summary>When overridden in a derived class, gets the name registered with the Internet Assigned Numbers Authority (IANA) for the current encoding.</summary>
		/// <returns>The IANA name for the current <see cref="T:System.Text.Encoding" />.</returns>
		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x00059773 File Offset: 0x00057973
		public virtual string WebName
		{
			get
			{
				if (this.dataItem == null)
				{
					this.GetDataItem();
				}
				return this.dataItem.WebName;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Text.EncoderFallback" /> object for the current <see cref="T:System.Text.Encoding" /> object.</summary>
		/// <returns>The encoder fallback object for the current <see cref="T:System.Text.Encoding" /> object. </returns>
		/// <exception cref="T:System.ArgumentNullException">The value in a set operation is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">A value cannot be assigned in a set operation because the current <see cref="T:System.Text.Encoding" /> object is read-only.</exception>
		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060015BE RID: 5566 RVA: 0x0005978E File Offset: 0x0005798E
		// (set) Token: 0x060015BF RID: 5567 RVA: 0x00059796 File Offset: 0x00057996
		[ComVisible(false)]
		public EncoderFallback EncoderFallback
		{
			get
			{
				return this.encoderFallback;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(Environment.GetResourceString("Instance is read-only."));
				}
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.encoderFallback = value;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Text.DecoderFallback" /> object for the current <see cref="T:System.Text.Encoding" /> object.</summary>
		/// <returns>The decoder fallback object for the current <see cref="T:System.Text.Encoding" /> object. </returns>
		/// <exception cref="T:System.ArgumentNullException">The value in a set operation is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">A value cannot be assigned in a set operation because the current <see cref="T:System.Text.Encoding" /> object is read-only.</exception>
		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x000597C5 File Offset: 0x000579C5
		// (set) Token: 0x060015C1 RID: 5569 RVA: 0x000597CD File Offset: 0x000579CD
		[ComVisible(false)]
		public DecoderFallback DecoderFallback
		{
			get
			{
				return this.decoderFallback;
			}
			set
			{
				if (this.IsReadOnly)
				{
					throw new InvalidOperationException(Environment.GetResourceString("Instance is read-only."));
				}
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.decoderFallback = value;
			}
		}

		/// <summary>When overridden in a derived class, creates a shallow copy of the current <see cref="T:System.Text.Encoding" /> object.</summary>
		/// <returns>A copy of the current <see cref="T:System.Text.Encoding" /> object.</returns>
		// Token: 0x060015C2 RID: 5570 RVA: 0x000597FC File Offset: 0x000579FC
		[ComVisible(false)]
		public virtual object Clone()
		{
			Encoding encoding = (Encoding)base.MemberwiseClone();
			encoding.m_isReadOnly = false;
			return encoding;
		}

		/// <summary>When overridden in a derived class, gets a value indicating whether the current encoding is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the current <see cref="T:System.Text.Encoding" /> is read-only; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060015C3 RID: 5571 RVA: 0x00059810 File Offset: 0x00057A10
		[ComVisible(false)]
		public bool IsReadOnly
		{
			get
			{
				return this.m_isReadOnly;
			}
		}

		/// <summary>Gets an encoding for the ASCII (7-bit) character set.</summary>
		/// <returns>An  encoding for the ASCII (7-bit) character set.</returns>
		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x00059818 File Offset: 0x00057A18
		public static Encoding ASCII
		{
			get
			{
				if (Encoding.asciiEncoding == null)
				{
					Encoding.asciiEncoding = new ASCIIEncoding();
				}
				return Encoding.asciiEncoding;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060015C5 RID: 5573 RVA: 0x00059836 File Offset: 0x00057A36
		private static Encoding Latin1
		{
			get
			{
				if (Encoding.latin1Encoding == null)
				{
					Encoding.latin1Encoding = new Latin1Encoding();
				}
				return Encoding.latin1Encoding;
			}
		}

		/// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding the characters in the specified string.</summary>
		/// <param name="s">The string containing the set of characters to encode. </param>
		/// <returns>The number of bytes produced by encoding the specified characters.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060015C6 RID: 5574 RVA: 0x00059854 File Offset: 0x00057A54
		public virtual int GetByteCount(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			char[] array = s.ToCharArray();
			return this.GetByteCount(array, 0, array.Length);
		}

		/// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding a set of characters from the specified character array.</summary>
		/// <param name="chars">The character array containing the set of characters to encode. </param>
		/// <param name="index">The index of the first character to encode. </param>
		/// <param name="count">The number of characters to encode. </param>
		/// <returns>The number of bytes produced by encoding the specified characters.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="chars" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is less than zero.-or- 
		///         <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="chars" />. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060015C7 RID: 5575
		public abstract int GetByteCount(char[] chars, int index, int count);

		/// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding a set of characters starting at the specified character pointer.</summary>
		/// <param name="chars">A pointer to the first character to encode. </param>
		/// <param name="count">The number of characters to encode. </param>
		/// <returns>The number of bytes produced by encoding the specified characters.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="chars" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="count" /> is less than zero. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060015C8 RID: 5576 RVA: 0x00059884 File Offset: 0x00057A84
		[SecurityCritical]
		[CLSCompliant(false)]
		[ComVisible(false)]
		public unsafe virtual int GetByteCount(char* chars, int count)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("chars", Environment.GetResourceString("Array cannot be null."));
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("Non-negative number required."));
			}
			char[] array = new char[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = chars[i];
			}
			return this.GetByteCount(array, 0, count);
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x000598EA File Offset: 0x00057AEA
		[SecurityCritical]
		internal unsafe virtual int GetByteCount(char* chars, int count, EncoderNLS encoder)
		{
			return this.GetByteCount(chars, count);
		}

		/// <summary>When overridden in a derived class, encodes all the characters in the specified character array into a sequence of bytes.</summary>
		/// <param name="chars">The character array containing the characters to encode. </param>
		/// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="chars" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060015CA RID: 5578 RVA: 0x000598F4 File Offset: 0x00057AF4
		public virtual byte[] GetBytes(char[] chars)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("chars", Environment.GetResourceString("Array cannot be null."));
			}
			return this.GetBytes(chars, 0, chars.Length);
		}

		/// <summary>When overridden in a derived class, encodes a set of characters from the specified character array into a sequence of bytes.</summary>
		/// <param name="chars">The character array containing the set of characters to encode. </param>
		/// <param name="index">The index of the first character to encode. </param>
		/// <param name="count">The number of characters to encode. </param>
		/// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="chars" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is less than zero.-or- 
		///         <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="chars" />. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060015CB RID: 5579 RVA: 0x0005991C File Offset: 0x00057B1C
		public virtual byte[] GetBytes(char[] chars, int index, int count)
		{
			byte[] array = new byte[this.GetByteCount(chars, index, count)];
			this.GetBytes(chars, index, count, array, 0);
			return array;
		}

		/// <summary>When overridden in a derived class, encodes a set of characters from the specified character array into the specified byte array.</summary>
		/// <param name="chars">The character array containing the set of characters to encode. </param>
		/// <param name="charIndex">The index of the first character to encode. </param>
		/// <param name="charCount">The number of characters to encode. </param>
		/// <param name="bytes">The byte array to contain the resulting sequence of bytes. </param>
		/// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes. </param>
		/// <returns>The actual number of bytes written into <paramref name="bytes" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="chars" /> is <see langword="null" />.-or- 
		///         <paramref name="bytes" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.-or- 
		///         <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="chars" />.-or- 
		///         <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060015CC RID: 5580
		public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

		/// <summary>When overridden in a derived class, encodes all the characters in the specified string into a sequence of bytes.</summary>
		/// <param name="s">The string containing the characters to encode. </param>
		/// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060015CD RID: 5581 RVA: 0x00059948 File Offset: 0x00057B48
		public virtual byte[] GetBytes(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s", Environment.GetResourceString("String reference not set to an instance of a String."));
			}
			byte[] array = new byte[this.GetByteCount(s)];
			this.GetBytes(s, 0, s.Length, array, 0);
			return array;
		}

		/// <summary>When overridden in a derived class, encodes a set of characters from the specified string into the specified byte array.</summary>
		/// <param name="s">The string containing the set of characters to encode. </param>
		/// <param name="charIndex">The index of the first character to encode. </param>
		/// <param name="charCount">The number of characters to encode. </param>
		/// <param name="bytes">The byte array to contain the resulting sequence of bytes. </param>
		/// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes. </param>
		/// <returns>The actual number of bytes written into <paramref name="bytes" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />.-or- 
		///         <paramref name="bytes" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.-or- 
		///         <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="chars" />.-or- 
		///         <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060015CE RID: 5582 RVA: 0x0005998C File Offset: 0x00057B8C
		public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			return this.GetBytes(s.ToCharArray(), charIndex, charCount, bytes, byteIndex);
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x000599AE File Offset: 0x00057BAE
		[SecurityCritical]
		internal unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			return this.GetBytes(chars, charCount, bytes, byteCount);
		}

		/// <summary>When overridden in a derived class, encodes a set of characters starting at the specified character pointer into a sequence of bytes that are stored starting at the specified byte pointer.</summary>
		/// <param name="chars">A pointer to the first character to encode. </param>
		/// <param name="charCount">The number of characters to encode. </param>
		/// <param name="bytes">A pointer to the location at which to start writing the resulting sequence of bytes. </param>
		/// <param name="byteCount">The maximum number of bytes to write. </param>
		/// <returns>The actual number of bytes written at the location indicated by the <paramref name="bytes" /> parameter.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="chars" /> is <see langword="null" />.-or- 
		///         <paramref name="bytes" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="charCount" /> or <paramref name="byteCount" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="byteCount" /> is less than the resulting number of bytes. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060015D0 RID: 5584 RVA: 0x000599BC File Offset: 0x00057BBC
		[SecurityCritical]
		[CLSCompliant(false)]
		[ComVisible(false)]
		public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			if (bytes == null || chars == null)
			{
				throw new ArgumentNullException((bytes == null) ? "bytes" : "chars", Environment.GetResourceString("Array cannot be null."));
			}
			if (charCount < 0 || byteCount < 0)
			{
				throw new ArgumentOutOfRangeException((charCount < 0) ? "charCount" : "byteCount", Environment.GetResourceString("Non-negative number required."));
			}
			char[] array = new char[charCount];
			for (int i = 0; i < charCount; i++)
			{
				array[i] = chars[i];
			}
			byte[] array2 = new byte[byteCount];
			int bytes2 = this.GetBytes(array, 0, charCount, array2, 0);
			if (bytes2 < byteCount)
			{
				byteCount = bytes2;
			}
			for (int i = 0; i < byteCount; i++)
			{
				bytes[i] = array2[i];
			}
			return byteCount;
		}

		/// <summary>When overridden in a derived class, calculates the number of characters produced by decoding a sequence of bytes from the specified byte array.</summary>
		/// <param name="bytes">The byte array containing the sequence of bytes to decode. </param>
		/// <param name="index">The index of the first byte to decode. </param>
		/// <param name="count">The number of bytes to decode. </param>
		/// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="bytes" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is less than zero.-or- 
		///         <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060015D1 RID: 5585
		public abstract int GetCharCount(byte[] bytes, int index, int count);

		/// <summary>When overridden in a derived class, calculates the number of characters produced by decoding a sequence of bytes starting at the specified byte pointer.</summary>
		/// <param name="bytes">A pointer to the first byte to decode. </param>
		/// <param name="count">The number of bytes to decode. </param>
		/// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="bytes" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="count" /> is less than zero. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060015D2 RID: 5586 RVA: 0x00059A6C File Offset: 0x00057C6C
		[SecurityCritical]
		[CLSCompliant(false)]
		[ComVisible(false)]
		public unsafe virtual int GetCharCount(byte* bytes, int count)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", Environment.GetResourceString("Array cannot be null."));
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("Non-negative number required."));
			}
			byte[] array = new byte[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = bytes[i];
			}
			return this.GetCharCount(array, 0, count);
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00059ACF File Offset: 0x00057CCF
		[SecurityCritical]
		internal unsafe virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
		{
			return this.GetCharCount(bytes, count);
		}

		/// <summary>When overridden in a derived class, decodes a sequence of bytes from the specified byte array into a set of characters.</summary>
		/// <param name="bytes">The byte array containing the sequence of bytes to decode. </param>
		/// <param name="index">The index of the first byte to decode. </param>
		/// <param name="count">The number of bytes to decode. </param>
		/// <returns>A character array containing the results of decoding the specified sequence of bytes.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="bytes" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is less than zero.-or- 
		///         <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060015D4 RID: 5588 RVA: 0x00059ADC File Offset: 0x00057CDC
		public virtual char[] GetChars(byte[] bytes, int index, int count)
		{
			char[] array = new char[this.GetCharCount(bytes, index, count)];
			this.GetChars(bytes, index, count, array, 0);
			return array;
		}

		/// <summary>When overridden in a derived class, decodes a sequence of bytes from the specified byte array into the specified character array.</summary>
		/// <param name="bytes">The byte array containing the sequence of bytes to decode. </param>
		/// <param name="byteIndex">The index of the first byte to decode. </param>
		/// <param name="byteCount">The number of bytes to decode. </param>
		/// <param name="chars">The character array to contain the resulting set of characters. </param>
		/// <param name="charIndex">The index at which to start writing the resulting set of characters. </param>
		/// <returns>The actual number of characters written into <paramref name="chars" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="bytes" /> is <see langword="null" />.-or- 
		///         <paramref name="chars" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="byteIndex" /> or <paramref name="byteCount" /> or <paramref name="charIndex" /> is less than zero.-or- 
		///         <paramref name="byteindex" /> and <paramref name="byteCount" /> do not denote a valid range in <paramref name="bytes" />.-or- 
		///         <paramref name="charIndex" /> is not a valid index in <paramref name="chars" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="chars" /> does not have enough capacity from <paramref name="charIndex" /> to the end of the array to accommodate the resulting characters. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060015D5 RID: 5589
		public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

		/// <summary>When overridden in a derived class, decodes a sequence of bytes starting at the specified byte pointer into a set of characters that are stored starting at the specified character pointer.</summary>
		/// <param name="bytes">A pointer to the first byte to decode. </param>
		/// <param name="byteCount">The number of bytes to decode. </param>
		/// <param name="chars">A pointer to the location at which to start writing the resulting set of characters. </param>
		/// <param name="charCount">The maximum number of characters to write. </param>
		/// <returns>The actual number of characters written at the location indicated by the <paramref name="chars" /> parameter.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="bytes" /> is <see langword="null" />.-or- 
		///         <paramref name="chars" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="byteCount" /> or <paramref name="charCount" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="charCount" /> is less than the resulting number of characters. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060015D6 RID: 5590 RVA: 0x00059B08 File Offset: 0x00057D08
		[SecurityCritical]
		[CLSCompliant(false)]
		[ComVisible(false)]
		public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			if (chars == null || bytes == null)
			{
				throw new ArgumentNullException((chars == null) ? "chars" : "bytes", Environment.GetResourceString("Array cannot be null."));
			}
			if (byteCount < 0 || charCount < 0)
			{
				throw new ArgumentOutOfRangeException((byteCount < 0) ? "byteCount" : "charCount", Environment.GetResourceString("Non-negative number required."));
			}
			byte[] array = new byte[byteCount];
			for (int i = 0; i < byteCount; i++)
			{
				array[i] = bytes[i];
			}
			char[] array2 = new char[charCount];
			int chars2 = this.GetChars(array, 0, byteCount, array2, 0);
			if (chars2 < charCount)
			{
				charCount = chars2;
			}
			for (int i = 0; i < charCount; i++)
			{
				chars[i] = array2[i];
			}
			return charCount;
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00059BB8 File Offset: 0x00057DB8
		[SecurityCritical]
		internal unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
		{
			return this.GetChars(bytes, byteCount, chars, charCount);
		}

		/// <summary>When overridden in a derived class, decodes a specified number of bytes starting at a specified address into a string. </summary>
		/// <param name="bytes">A pointer to a byte array. </param>
		/// <param name="byteCount">The number of bytes to decode. </param>
		/// <returns>A string that contains the results of decoding the specified sequence of bytes. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="bytes" /> is a null pointer. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="byteCount" /> is less than zero. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A   fallback occurred (see Character Encoding in the .NET Framework for a complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />. </exception>
		// Token: 0x060015D8 RID: 5592 RVA: 0x00059BC5 File Offset: 0x00057DC5
		[SecurityCritical]
		[CLSCompliant(false)]
		[ComVisible(false)]
		public unsafe string GetString(byte* bytes, int byteCount)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", Environment.GetResourceString("Array cannot be null."));
			}
			if (byteCount < 0)
			{
				throw new ArgumentOutOfRangeException("byteCount", Environment.GetResourceString("Non-negative number required."));
			}
			return string.CreateStringFromEncoding(bytes, byteCount, this);
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00059C04 File Offset: 0x00057E04
		public unsafe virtual int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars)
		{
			fixed (byte* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
			{
				byte* bytes2 = nonNullPinnableReference;
				fixed (char* nonNullPinnableReference2 = MemoryMarshal.GetNonNullPinnableReference<char>(chars))
				{
					char* chars2 = nonNullPinnableReference2;
					return this.GetChars(bytes2, bytes.Length, chars2, chars.Length);
				}
			}
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00059C3C File Offset: 0x00057E3C
		public unsafe string GetString(ReadOnlySpan<byte> bytes)
		{
			fixed (byte* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
			{
				byte* bytes2 = nonNullPinnableReference;
				return this.GetString(bytes2, bytes.Length);
			}
		}

		/// <summary>When overridden in a derived class, gets the code page identifier of the current <see cref="T:System.Text.Encoding" />.</summary>
		/// <returns>The code page identifier of the current <see cref="T:System.Text.Encoding" />.</returns>
		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x00059C61 File Offset: 0x00057E61
		public virtual int CodePage
		{
			get
			{
				return this.m_codePage;
			}
		}

		/// <summary>When overridden in a derived class, obtains a decoder that converts an encoded sequence of bytes into a sequence of characters.</summary>
		/// <returns>A <see cref="T:System.Text.Decoder" /> that converts an encoded sequence of bytes into a sequence of characters.</returns>
		// Token: 0x060015DC RID: 5596 RVA: 0x00059C69 File Offset: 0x00057E69
		public virtual Decoder GetDecoder()
		{
			return new Encoding.DefaultDecoder(this);
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00059C71 File Offset: 0x00057E71
		[SecurityCritical]
		private static Encoding CreateDefaultEncoding()
		{
			Encoding encoding = EncodingHelper.GetDefaultEncoding();
			encoding.m_isReadOnly = true;
			return encoding;
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00059C7F File Offset: 0x00057E7F
		internal void setReadOnly(bool value = true)
		{
			this.m_isReadOnly = value;
		}

		/// <summary>Gets an encoding for the operating system's current ANSI code page.</summary>
		/// <returns>An encoding for the operating system's current ANSI code page.</returns>
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x00059C88 File Offset: 0x00057E88
		public static Encoding Default
		{
			[SecuritySafeCritical]
			get
			{
				if (Encoding.defaultEncoding == null)
				{
					Encoding.defaultEncoding = Encoding.CreateDefaultEncoding();
				}
				return Encoding.defaultEncoding;
			}
		}

		/// <summary>When overridden in a derived class, obtains an encoder that converts a sequence of Unicode characters into an encoded sequence of bytes.</summary>
		/// <returns>A <see cref="T:System.Text.Encoder" /> that converts a sequence of Unicode characters into an encoded sequence of bytes.</returns>
		// Token: 0x060015E0 RID: 5600 RVA: 0x00059CA6 File Offset: 0x00057EA6
		public virtual Encoder GetEncoder()
		{
			return new Encoding.DefaultEncoder(this);
		}

		/// <summary>When overridden in a derived class, calculates the maximum number of bytes produced by encoding the specified number of characters.</summary>
		/// <param name="charCount">The number of characters to encode. </param>
		/// <returns>The maximum number of bytes produced by encoding the specified number of characters.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="charCount" /> is less than zero. </exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		// Token: 0x060015E1 RID: 5601
		public abstract int GetMaxByteCount(int charCount);

		/// <summary>When overridden in a derived class, calculates the maximum number of characters produced by decoding the specified number of bytes.</summary>
		/// <param name="byteCount">The number of bytes to decode. </param>
		/// <returns>The maximum number of characters produced by decoding the specified number of bytes.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="byteCount" /> is less than zero. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060015E2 RID: 5602
		public abstract int GetMaxCharCount(int byteCount);

		/// <summary>When overridden in a derived class, decodes all the bytes in the specified byte array into a string.</summary>
		/// <param name="bytes">The byte array containing the sequence of bytes to decode. </param>
		/// <returns>A string that contains the results of decoding the specified sequence of bytes.</returns>
		/// <exception cref="T:System.ArgumentException">The byte array contains invalid Unicode code points.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="bytes" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060015E3 RID: 5603 RVA: 0x00059CAE File Offset: 0x00057EAE
		public virtual string GetString(byte[] bytes)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", Environment.GetResourceString("Array cannot be null."));
			}
			return this.GetString(bytes, 0, bytes.Length);
		}

		/// <summary>When overridden in a derived class, decodes a sequence of bytes from the specified byte array into a string.</summary>
		/// <param name="bytes">The byte array containing the sequence of bytes to decode. </param>
		/// <param name="index">The index of the first byte to decode. </param>
		/// <param name="count">The number of bytes to decode. </param>
		/// <returns>A string that contains the results of decoding the specified sequence of bytes.</returns>
		/// <exception cref="T:System.ArgumentException">The byte array contains invalid Unicode code points.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="bytes" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is less than zero.-or- 
		///         <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-
		///         <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		// Token: 0x060015E4 RID: 5604 RVA: 0x00059CD3 File Offset: 0x00057ED3
		public virtual string GetString(byte[] bytes, int index, int count)
		{
			return new string(this.GetChars(bytes, index, count));
		}

		/// <summary>Gets an encoding for the UTF-16 format using the little endian byte order.</summary>
		/// <returns>An encoding for the UTF-16 format using the little endian byte order.</returns>
		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x00059CE3 File Offset: 0x00057EE3
		public static Encoding Unicode
		{
			get
			{
				if (Encoding.unicodeEncoding == null)
				{
					Encoding.unicodeEncoding = new UnicodeEncoding(false, true);
				}
				return Encoding.unicodeEncoding;
			}
		}

		/// <summary>Gets an encoding for the UTF-16 format that uses the big endian byte order.</summary>
		/// <returns>An encoding object for the UTF-16 format that uses the big endian byte order.</returns>
		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x00059D03 File Offset: 0x00057F03
		public static Encoding BigEndianUnicode
		{
			get
			{
				if (Encoding.bigEndianUnicode == null)
				{
					Encoding.bigEndianUnicode = new UnicodeEncoding(true, true);
				}
				return Encoding.bigEndianUnicode;
			}
		}

		/// <summary>Gets an encoding for the UTF-7 format.</summary>
		/// <returns>An encoding for the UTF-7 format.</returns>
		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x00059D23 File Offset: 0x00057F23
		public static Encoding UTF7
		{
			get
			{
				if (Encoding.utf7Encoding == null)
				{
					Encoding.utf7Encoding = new UTF7Encoding();
				}
				return Encoding.utf7Encoding;
			}
		}

		/// <summary>Gets an encoding for the UTF-8 format.</summary>
		/// <returns>An encoding for the UTF-8 format.</returns>
		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060015E8 RID: 5608 RVA: 0x00059D41 File Offset: 0x00057F41
		public static Encoding UTF8
		{
			get
			{
				if (Encoding.utf8Encoding == null)
				{
					Encoding.utf8Encoding = new UTF8Encoding(true);
				}
				return Encoding.utf8Encoding;
			}
		}

		/// <summary>Gets an encoding for the UTF-32 format using the little endian byte order.</summary>
		/// <returns>An  encoding object for the UTF-32 format using the little endian byte order.</returns>
		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060015E9 RID: 5609 RVA: 0x00059D60 File Offset: 0x00057F60
		public static Encoding UTF32
		{
			get
			{
				if (Encoding.utf32Encoding == null)
				{
					Encoding.utf32Encoding = new UTF32Encoding(false, true);
				}
				return Encoding.utf32Encoding;
			}
		}

		/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current instance.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to compare with the current instance. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is an instance of <see cref="T:System.Text.Encoding" /> and is equal to the current instance; otherwise, <see langword="false" />. </returns>
		// Token: 0x060015EA RID: 5610 RVA: 0x00059D80 File Offset: 0x00057F80
		public override bool Equals(object value)
		{
			Encoding encoding = value as Encoding;
			return encoding != null && (this.m_codePage == encoding.m_codePage && this.EncoderFallback.Equals(encoding.EncoderFallback)) && this.DecoderFallback.Equals(encoding.DecoderFallback);
		}

		/// <summary>Returns the hash code for the current instance.</summary>
		/// <returns>The hash code for the current instance.</returns>
		// Token: 0x060015EB RID: 5611 RVA: 0x00059DCD File Offset: 0x00057FCD
		public override int GetHashCode()
		{
			return this.m_codePage + this.EncoderFallback.GetHashCode() + this.DecoderFallback.GetHashCode();
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00059DED File Offset: 0x00057FED
		internal virtual char[] GetBestFitUnicodeToBytesData()
		{
			return EmptyArray<char>.Value;
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00059DED File Offset: 0x00057FED
		internal virtual char[] GetBestFitBytesToUnicodeData()
		{
			return EmptyArray<char>.Value;
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00059DF4 File Offset: 0x00057FF4
		internal void ThrowBytesOverflow()
		{
			throw new ArgumentException(Environment.GetResourceString("The output byte buffer is too small to contain the encoded data, encoding '{0}' fallback '{1}'.", new object[]
			{
				this.EncodingName,
				this.EncoderFallback.GetType()
			}), "bytes");
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00059E27 File Offset: 0x00058027
		[SecurityCritical]
		internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded)
		{
			if (encoder == null || encoder._throwOnOverflow || nothingEncoded)
			{
				if (encoder != null && encoder.InternalHasFallbackBuffer)
				{
					encoder.FallbackBuffer.InternalReset();
				}
				this.ThrowBytesOverflow();
			}
			encoder.ClearMustFlush();
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00059E5B File Offset: 0x0005805B
		internal void ThrowCharsOverflow()
		{
			throw new ArgumentException(Environment.GetResourceString("The output char buffer is too small to contain the decoded characters, encoding '{0}' fallback '{1}'.", new object[]
			{
				this.EncodingName,
				this.DecoderFallback.GetType()
			}), "chars");
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00059E8E File Offset: 0x0005808E
		[SecurityCritical]
		internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded)
		{
			if (decoder == null || decoder._throwOnOverflow || nothingDecoded)
			{
				if (decoder != null && decoder.InternalHasFallbackBuffer)
				{
					decoder.FallbackBuffer.InternalReset();
				}
				this.ThrowCharsOverflow();
			}
			decoder.ClearMustFlush();
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00059EC4 File Offset: 0x000580C4
		public unsafe virtual int GetBytes(ReadOnlySpan<char> chars, Span<byte> bytes)
		{
			fixed (char* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<char>(chars))
			{
				char* chars2 = nonNullPinnableReference;
				fixed (byte* nonNullPinnableReference2 = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
				{
					byte* bytes2 = nonNullPinnableReference2;
					return this.GetBytes(chars2, chars.Length, bytes2, bytes.Length);
				}
			}
		}

		// Token: 0x04000874 RID: 2164
		private static volatile Encoding defaultEncoding;

		// Token: 0x04000875 RID: 2165
		private static volatile Encoding unicodeEncoding;

		// Token: 0x04000876 RID: 2166
		private static volatile Encoding bigEndianUnicode;

		// Token: 0x04000877 RID: 2167
		private static volatile Encoding utf7Encoding;

		// Token: 0x04000878 RID: 2168
		private static volatile Encoding utf8Encoding;

		// Token: 0x04000879 RID: 2169
		private static volatile Encoding utf32Encoding;

		// Token: 0x0400087A RID: 2170
		private static volatile Encoding asciiEncoding;

		// Token: 0x0400087B RID: 2171
		private static volatile Encoding latin1Encoding;

		// Token: 0x0400087C RID: 2172
		private static volatile Dictionary<int, Encoding> encodings;

		// Token: 0x0400087D RID: 2173
		internal int m_codePage;

		// Token: 0x0400087E RID: 2174
		internal CodePageDataItem dataItem;

		// Token: 0x0400087F RID: 2175
		[NonSerialized]
		internal bool m_deserializedFromEverett;

		// Token: 0x04000880 RID: 2176
		[OptionalField(VersionAdded = 2)]
		private bool m_isReadOnly = true;

		// Token: 0x04000881 RID: 2177
		[OptionalField(VersionAdded = 2)]
		internal EncoderFallback encoderFallback;

		// Token: 0x04000882 RID: 2178
		[OptionalField(VersionAdded = 2)]
		internal DecoderFallback decoderFallback;

		// Token: 0x04000883 RID: 2179
		private static object s_InternalSyncObject;

		// Token: 0x0200026F RID: 623
		[Serializable]
		internal class DefaultEncoder : Encoder, ISerializable, IObjectReference
		{
			// Token: 0x060015F3 RID: 5619 RVA: 0x00059EFB File Offset: 0x000580FB
			public DefaultEncoder(Encoding encoding)
			{
				this.m_encoding = encoding;
				this.m_hasInitializedEncoding = true;
			}

			// Token: 0x060015F4 RID: 5620 RVA: 0x00059F14 File Offset: 0x00058114
			internal DefaultEncoder(SerializationInfo info, StreamingContext context)
			{
				if (info == null)
				{
					throw new ArgumentNullException("info");
				}
				this.m_encoding = (Encoding)info.GetValue("encoding", typeof(Encoding));
				try
				{
					this._fallback = (EncoderFallback)info.GetValue("_fallback", typeof(EncoderFallback));
					this.charLeftOver = (char)info.GetValue("charLeftOver", typeof(char));
				}
				catch (SerializationException)
				{
				}
			}

			// Token: 0x060015F5 RID: 5621 RVA: 0x00059FAC File Offset: 0x000581AC
			[SecurityCritical]
			public object GetRealObject(StreamingContext context)
			{
				if (this.m_hasInitializedEncoding)
				{
					return this;
				}
				Encoder encoder = this.m_encoding.GetEncoder();
				if (this._fallback != null)
				{
					encoder._fallback = this._fallback;
				}
				if (this.charLeftOver != '\0')
				{
					EncoderNLS encoderNLS = encoder as EncoderNLS;
					if (encoderNLS != null)
					{
						encoderNLS._charLeftOver = this.charLeftOver;
					}
				}
				return encoder;
			}

			// Token: 0x060015F6 RID: 5622 RVA: 0x0005A002 File Offset: 0x00058202
			[SecurityCritical]
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
			{
				if (info == null)
				{
					throw new ArgumentNullException("info");
				}
				info.AddValue("encoding", this.m_encoding);
			}

			// Token: 0x060015F7 RID: 5623 RVA: 0x0005A023 File Offset: 0x00058223
			public override int GetByteCount(char[] chars, int index, int count, bool flush)
			{
				return this.m_encoding.GetByteCount(chars, index, count);
			}

			// Token: 0x060015F8 RID: 5624 RVA: 0x0005A033 File Offset: 0x00058233
			[SecurityCritical]
			public unsafe override int GetByteCount(char* chars, int count, bool flush)
			{
				return this.m_encoding.GetByteCount(chars, count);
			}

			// Token: 0x060015F9 RID: 5625 RVA: 0x0005A042 File Offset: 0x00058242
			public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
			{
				return this.m_encoding.GetBytes(chars, charIndex, charCount, bytes, byteIndex);
			}

			// Token: 0x060015FA RID: 5626 RVA: 0x0005A056 File Offset: 0x00058256
			[SecurityCritical]
			public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
			{
				return this.m_encoding.GetBytes(chars, charCount, bytes, byteCount);
			}

			// Token: 0x04000884 RID: 2180
			private Encoding m_encoding;

			// Token: 0x04000885 RID: 2181
			[NonSerialized]
			private bool m_hasInitializedEncoding;

			// Token: 0x04000886 RID: 2182
			[NonSerialized]
			internal char charLeftOver;
		}

		// Token: 0x02000270 RID: 624
		[Serializable]
		internal class DefaultDecoder : Decoder, ISerializable, IObjectReference
		{
			// Token: 0x060015FB RID: 5627 RVA: 0x0005A068 File Offset: 0x00058268
			public DefaultDecoder(Encoding encoding)
			{
				this.m_encoding = encoding;
				this.m_hasInitializedEncoding = true;
			}

			// Token: 0x060015FC RID: 5628 RVA: 0x0005A080 File Offset: 0x00058280
			internal DefaultDecoder(SerializationInfo info, StreamingContext context)
			{
				if (info == null)
				{
					throw new ArgumentNullException("info");
				}
				this.m_encoding = (Encoding)info.GetValue("encoding", typeof(Encoding));
				try
				{
					this._fallback = (DecoderFallback)info.GetValue("_fallback", typeof(DecoderFallback));
				}
				catch (SerializationException)
				{
					this._fallback = null;
				}
			}

			// Token: 0x060015FD RID: 5629 RVA: 0x0005A100 File Offset: 0x00058300
			[SecurityCritical]
			public object GetRealObject(StreamingContext context)
			{
				if (this.m_hasInitializedEncoding)
				{
					return this;
				}
				Decoder decoder = this.m_encoding.GetDecoder();
				if (this._fallback != null)
				{
					decoder._fallback = this._fallback;
				}
				return decoder;
			}

			// Token: 0x060015FE RID: 5630 RVA: 0x0005A138 File Offset: 0x00058338
			[SecurityCritical]
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
			{
				if (info == null)
				{
					throw new ArgumentNullException("info");
				}
				info.AddValue("encoding", this.m_encoding);
			}

			// Token: 0x060015FF RID: 5631 RVA: 0x0004FF49 File Offset: 0x0004E149
			public override int GetCharCount(byte[] bytes, int index, int count)
			{
				return this.GetCharCount(bytes, index, count, false);
			}

			// Token: 0x06001600 RID: 5632 RVA: 0x0005A159 File Offset: 0x00058359
			public override int GetCharCount(byte[] bytes, int index, int count, bool flush)
			{
				return this.m_encoding.GetCharCount(bytes, index, count);
			}

			// Token: 0x06001601 RID: 5633 RVA: 0x0005A169 File Offset: 0x00058369
			[SecurityCritical]
			public unsafe override int GetCharCount(byte* bytes, int count, bool flush)
			{
				return this.m_encoding.GetCharCount(bytes, count);
			}

			// Token: 0x06001602 RID: 5634 RVA: 0x00050022 File Offset: 0x0004E222
			public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
			{
				return this.GetChars(bytes, byteIndex, byteCount, chars, charIndex, false);
			}

			// Token: 0x06001603 RID: 5635 RVA: 0x0005A178 File Offset: 0x00058378
			public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
			{
				return this.m_encoding.GetChars(bytes, byteIndex, byteCount, chars, charIndex);
			}

			// Token: 0x06001604 RID: 5636 RVA: 0x0005A18C File Offset: 0x0005838C
			[SecurityCritical]
			public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
			{
				return this.m_encoding.GetChars(bytes, byteCount, chars, charCount);
			}

			// Token: 0x04000887 RID: 2183
			private Encoding m_encoding;

			// Token: 0x04000888 RID: 2184
			[NonSerialized]
			private bool m_hasInitializedEncoding;
		}

		// Token: 0x02000271 RID: 625
		internal class EncodingCharBuffer
		{
			// Token: 0x06001605 RID: 5637 RVA: 0x0005A1A0 File Offset: 0x000583A0
			[SecurityCritical]
			internal unsafe EncodingCharBuffer(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount)
			{
				this.enc = enc;
				this.decoder = decoder;
				this.chars = charStart;
				this.charStart = charStart;
				this.charEnd = charStart + charCount;
				this.byteStart = byteStart;
				this.bytes = byteStart;
				this.byteEnd = byteStart + byteCount;
				if (this.decoder == null)
				{
					this.fallbackBuffer = enc.DecoderFallback.CreateFallbackBuffer();
				}
				else
				{
					this.fallbackBuffer = this.decoder.FallbackBuffer;
				}
				this.fallbackBuffer.InternalInitialize(this.bytes, this.charEnd);
			}

			// Token: 0x06001606 RID: 5638 RVA: 0x0005A23C File Offset: 0x0005843C
			[SecurityCritical]
			internal unsafe bool AddChar(char ch, int numBytes)
			{
				if (this.chars != null)
				{
					if (this.chars >= this.charEnd)
					{
						this.bytes -= numBytes;
						this.enc.ThrowCharsOverflow(this.decoder, this.bytes == this.byteStart);
						return false;
					}
					char* ptr = this.chars;
					this.chars = ptr + 1;
					*ptr = ch;
				}
				this.charCountResult++;
				return true;
			}

			// Token: 0x06001607 RID: 5639 RVA: 0x0005A2B5 File Offset: 0x000584B5
			[SecurityCritical]
			internal bool AddChar(char ch)
			{
				return this.AddChar(ch, 1);
			}

			// Token: 0x06001608 RID: 5640 RVA: 0x0005A2BF File Offset: 0x000584BF
			[SecurityCritical]
			internal void AdjustBytes(int count)
			{
				this.bytes += count;
			}

			// Token: 0x1700023F RID: 575
			// (get) Token: 0x06001609 RID: 5641 RVA: 0x0005A2CF File Offset: 0x000584CF
			internal bool MoreData
			{
				[SecurityCritical]
				get
				{
					return this.bytes < this.byteEnd;
				}
			}

			// Token: 0x0600160A RID: 5642 RVA: 0x0005A2E0 File Offset: 0x000584E0
			[SecurityCritical]
			internal unsafe byte GetNextByte()
			{
				if (this.bytes >= this.byteEnd)
				{
					return 0;
				}
				byte* ptr = this.bytes;
				this.bytes = ptr + 1;
				return *ptr;
			}

			// Token: 0x17000240 RID: 576
			// (get) Token: 0x0600160B RID: 5643 RVA: 0x0005A30F File Offset: 0x0005850F
			internal int BytesUsed
			{
				[SecurityCritical]
				get
				{
					return (int)((long)(this.bytes - this.byteStart));
				}
			}

			// Token: 0x0600160C RID: 5644 RVA: 0x0005A324 File Offset: 0x00058524
			[SecurityCritical]
			internal bool Fallback(byte fallbackByte)
			{
				byte[] byteBuffer = new byte[]
				{
					fallbackByte
				};
				return this.Fallback(byteBuffer);
			}

			// Token: 0x0600160D RID: 5645 RVA: 0x0005A344 File Offset: 0x00058544
			[SecurityCritical]
			internal unsafe bool Fallback(byte[] byteBuffer)
			{
				if (this.chars != null)
				{
					char* ptr = this.chars;
					if (!this.fallbackBuffer.InternalFallback(byteBuffer, this.bytes, ref this.chars))
					{
						this.bytes -= byteBuffer.Length;
						this.fallbackBuffer.InternalReset();
						this.enc.ThrowCharsOverflow(this.decoder, this.chars == this.charStart);
						return false;
					}
					this.charCountResult += (int)((long)(this.chars - ptr));
				}
				else
				{
					this.charCountResult += this.fallbackBuffer.InternalFallback(byteBuffer, this.bytes);
				}
				return true;
			}

			// Token: 0x17000241 RID: 577
			// (get) Token: 0x0600160E RID: 5646 RVA: 0x0005A3F3 File Offset: 0x000585F3
			internal int Count
			{
				get
				{
					return this.charCountResult;
				}
			}

			// Token: 0x04000889 RID: 2185
			[SecurityCritical]
			private unsafe char* chars;

			// Token: 0x0400088A RID: 2186
			[SecurityCritical]
			private unsafe char* charStart;

			// Token: 0x0400088B RID: 2187
			[SecurityCritical]
			private unsafe char* charEnd;

			// Token: 0x0400088C RID: 2188
			private int charCountResult;

			// Token: 0x0400088D RID: 2189
			private Encoding enc;

			// Token: 0x0400088E RID: 2190
			private DecoderNLS decoder;

			// Token: 0x0400088F RID: 2191
			[SecurityCritical]
			private unsafe byte* byteStart;

			// Token: 0x04000890 RID: 2192
			[SecurityCritical]
			private unsafe byte* byteEnd;

			// Token: 0x04000891 RID: 2193
			[SecurityCritical]
			private unsafe byte* bytes;

			// Token: 0x04000892 RID: 2194
			private DecoderFallbackBuffer fallbackBuffer;
		}

		// Token: 0x02000272 RID: 626
		internal class EncodingByteBuffer
		{
			// Token: 0x0600160F RID: 5647 RVA: 0x0005A3FC File Offset: 0x000585FC
			[SecurityCritical]
			internal unsafe EncodingByteBuffer(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount)
			{
				this.enc = inEncoding;
				this.encoder = inEncoder;
				this.charStart = inCharStart;
				this.chars = inCharStart;
				this.charEnd = inCharStart + inCharCount;
				this.bytes = inByteStart;
				this.byteStart = inByteStart;
				this.byteEnd = inByteStart + inByteCount;
				if (this.encoder == null)
				{
					this.fallbackBuffer = this.enc.EncoderFallback.CreateFallbackBuffer();
				}
				else
				{
					this.fallbackBuffer = this.encoder.FallbackBuffer;
					if (this.encoder._throwOnOverflow && this.encoder.InternalHasFallbackBuffer && this.fallbackBuffer.Remaining > 0)
					{
						throw new ArgumentException(Environment.GetResourceString("Must complete Convert() operation or call Encoder.Reset() before calling GetBytes() or GetByteCount(). Encoder '{0}' fallback '{1}'.", new object[]
						{
							this.encoder.Encoding.EncodingName,
							this.encoder.Fallback.GetType()
						}));
					}
				}
				this.fallbackBuffer.InternalInitialize(this.chars, this.charEnd, this.encoder, this.bytes != null);
			}

			// Token: 0x06001610 RID: 5648 RVA: 0x0005A514 File Offset: 0x00058714
			[SecurityCritical]
			internal unsafe bool AddByte(byte b, int moreBytesExpected)
			{
				if (this.bytes != null)
				{
					if (this.bytes >= this.byteEnd - moreBytesExpected)
					{
						this.MovePrevious(true);
						return false;
					}
					byte* ptr = this.bytes;
					this.bytes = ptr + 1;
					*ptr = b;
				}
				this.byteCountResult++;
				return true;
			}

			// Token: 0x06001611 RID: 5649 RVA: 0x0005A566 File Offset: 0x00058766
			[SecurityCritical]
			internal bool AddByte(byte b1)
			{
				return this.AddByte(b1, 0);
			}

			// Token: 0x06001612 RID: 5650 RVA: 0x0005A570 File Offset: 0x00058770
			[SecurityCritical]
			internal bool AddByte(byte b1, byte b2)
			{
				return this.AddByte(b1, b2, 0);
			}

			// Token: 0x06001613 RID: 5651 RVA: 0x0005A57B File Offset: 0x0005877B
			[SecurityCritical]
			internal bool AddByte(byte b1, byte b2, int moreBytesExpected)
			{
				return this.AddByte(b1, 1 + moreBytesExpected) && this.AddByte(b2, moreBytesExpected);
			}

			// Token: 0x06001614 RID: 5652 RVA: 0x0005A594 File Offset: 0x00058794
			[SecurityCritical]
			internal void MovePrevious(bool bThrow)
			{
				if (this.fallbackBuffer.bFallingBack)
				{
					this.fallbackBuffer.MovePrevious();
				}
				else if (this.chars != this.charStart)
				{
					this.chars--;
				}
				if (bThrow)
				{
					this.enc.ThrowBytesOverflow(this.encoder, this.bytes == this.byteStart);
				}
			}

			// Token: 0x17000242 RID: 578
			// (get) Token: 0x06001615 RID: 5653 RVA: 0x0005A5FA File Offset: 0x000587FA
			internal bool MoreData
			{
				[SecurityCritical]
				get
				{
					return this.fallbackBuffer.Remaining > 0 || this.chars < this.charEnd;
				}
			}

			// Token: 0x06001616 RID: 5654 RVA: 0x0005A61C File Offset: 0x0005881C
			[SecurityCritical]
			internal unsafe char GetNextChar()
			{
				char c = this.fallbackBuffer.InternalGetNextChar();
				if (c == '\0' && this.chars < this.charEnd)
				{
					char* ptr = this.chars;
					this.chars = ptr + 1;
					c = *ptr;
				}
				return c;
			}

			// Token: 0x17000243 RID: 579
			// (get) Token: 0x06001617 RID: 5655 RVA: 0x0005A65A File Offset: 0x0005885A
			internal int CharsUsed
			{
				[SecurityCritical]
				get
				{
					return (int)((long)(this.chars - this.charStart));
				}
			}

			// Token: 0x17000244 RID: 580
			// (get) Token: 0x06001618 RID: 5656 RVA: 0x0005A66D File Offset: 0x0005886D
			internal int Count
			{
				get
				{
					return this.byteCountResult;
				}
			}

			// Token: 0x04000893 RID: 2195
			[SecurityCritical]
			private unsafe byte* bytes;

			// Token: 0x04000894 RID: 2196
			[SecurityCritical]
			private unsafe byte* byteStart;

			// Token: 0x04000895 RID: 2197
			[SecurityCritical]
			private unsafe byte* byteEnd;

			// Token: 0x04000896 RID: 2198
			[SecurityCritical]
			private unsafe char* chars;

			// Token: 0x04000897 RID: 2199
			[SecurityCritical]
			private unsafe char* charStart;

			// Token: 0x04000898 RID: 2200
			[SecurityCritical]
			private unsafe char* charEnd;

			// Token: 0x04000899 RID: 2201
			private int byteCountResult;

			// Token: 0x0400089A RID: 2202
			private Encoding enc;

			// Token: 0x0400089B RID: 2203
			private EncoderNLS encoder;

			// Token: 0x0400089C RID: 2204
			internal EncoderFallbackBuffer fallbackBuffer;
		}
	}
}
