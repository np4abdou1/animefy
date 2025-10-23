using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace System.Net
{
	/// <summary>Contains protocol headers associated with a request or response.</summary>
	// Token: 0x02000164 RID: 356
	[DefaultMember("Item")]
	[ComVisible(true)]
	[Serializable]
	public class WebHeaderCollection : NameValueCollection, ISerializable
	{
		// Token: 0x060009A1 RID: 2465 RVA: 0x00033F88 File Offset: 0x00032188
		private void NormalizeCommonHeaders()
		{
			if (this.m_CommonHeaders == null)
			{
				return;
			}
			for (int i = 0; i < this.m_CommonHeaders.Length; i++)
			{
				if (this.m_CommonHeaders[i] != null)
				{
					this.InnerCollection.Add(WebHeaderCollection.s_CommonHeaderNames[i], this.m_CommonHeaders[i]);
				}
			}
			this.m_CommonHeaders = null;
			this.m_NumCommonHeaders = 0;
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00033FE3 File Offset: 0x000321E3
		private NameValueCollection InnerCollection
		{
			get
			{
				if (this.m_InnerCollection == null)
				{
					this.m_InnerCollection = new NameValueCollection(16, CaseInsensitiveAscii.StaticInstance);
				}
				return this.m_InnerCollection;
			}
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00034008 File Offset: 0x00032208
		internal static bool AllowMultiValues(string name)
		{
			HeaderInfo headerInfo = WebHeaderCollection.HInfo[name];
			return headerInfo.AllowMultiValues || headerInfo.HeaderName == "";
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x0003403B File Offset: 0x0003223B
		private bool AllowHttpRequestHeader
		{
			get
			{
				if (this.m_Type == WebHeaderCollectionType.Unknown)
				{
					this.m_Type = WebHeaderCollectionType.WebRequest;
				}
				return this.m_Type == WebHeaderCollectionType.WebRequest || this.m_Type == WebHeaderCollectionType.HttpWebRequest || this.m_Type == WebHeaderCollectionType.HttpListenerRequest;
			}
		}

		/// <summary>Removes the specified header from the collection.</summary>
		/// <param name="header">The <see cref="T:System.Net.HttpRequestHeader" /> instance to remove from the collection. </param>
		/// <exception cref="T:System.InvalidOperationException">This <see cref="T:System.Net.WebHeaderCollection" /> instance does not allow instances of <see cref="T:System.Net.HttpRequestHeader" />. </exception>
		// Token: 0x060009A5 RID: 2469 RVA: 0x00034069 File Offset: 0x00032269
		public void Remove(HttpRequestHeader header)
		{
			if (!this.AllowHttpRequestHeader)
			{
				throw new InvalidOperationException(SR.GetString("This collection holds response headers and cannot contain the specified request header."));
			}
			this.Remove(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID.ToString((int)header));
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0003408F File Offset: 0x0003228F
		internal void AddInternal(string name, string value)
		{
			this.NormalizeCommonHeaders();
			base.InvalidateCachedArrays();
			this.InnerCollection.Add(name, value);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x000340AA File Offset: 0x000322AA
		internal void ChangeInternal(string name, string value)
		{
			this.NormalizeCommonHeaders();
			base.InvalidateCachedArrays();
			this.InnerCollection.Set(name, value);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x000340C5 File Offset: 0x000322C5
		internal void RemoveInternal(string name)
		{
			this.NormalizeCommonHeaders();
			if (this.m_InnerCollection != null)
			{
				base.InvalidateCachedArrays();
				this.m_InnerCollection.Remove(name);
			}
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x000340E7 File Offset: 0x000322E7
		internal void CheckUpdate(string name, string value)
		{
			value = WebHeaderCollection.CheckBadChars(value, true);
			this.ChangeInternal(name, value);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x000340FC File Offset: 0x000322FC
		internal static string CheckBadChars(string name, bool isHeaderValue)
		{
			if (name != null && name.Length != 0)
			{
				if (isHeaderValue)
				{
					name = name.Trim(WebHeaderCollection.HttpTrimCharacters);
					int num = 0;
					for (int i = 0; i < name.Length; i++)
					{
						char c = 'ÿ' & name[i];
						switch (num)
						{
						case 0:
							if (c == '\r')
							{
								num = 1;
							}
							else if (c == '\n')
							{
								num = 2;
							}
							else if (c == '\u007f' || (c < ' ' && c != '\t'))
							{
								throw new ArgumentException(SR.GetString("Specified value has invalid Control characters."), "value");
							}
							break;
						case 1:
							if (c != '\n')
							{
								throw new ArgumentException(SR.GetString("Specified value has invalid CRLF characters."), "value");
							}
							num = 2;
							break;
						case 2:
							if (c != ' ' && c != '\t')
							{
								throw new ArgumentException(SR.GetString("Specified value has invalid CRLF characters."), "value");
							}
							num = 0;
							break;
						}
					}
					if (num != 0)
					{
						throw new ArgumentException(SR.GetString("Specified value has invalid CRLF characters."), "value");
					}
				}
				else
				{
					if (name.IndexOfAny(ValidationHelper.InvalidParamChars) != -1)
					{
						throw new ArgumentException(SR.GetString("Specified value has invalid HTTP Header characters."), "name");
					}
					if (WebHeaderCollection.ContainsNonAsciiChars(name))
					{
						throw new ArgumentException(SR.GetString("Specified value has invalid non-ASCII characters."), "name");
					}
				}
				return name;
			}
			if (!isHeaderValue)
			{
				throw (name == null) ? new ArgumentNullException("name") : new ArgumentException(SR.GetString("The parameter '{0}' cannot be an empty string.", new object[]
				{
					"name"
				}), "name");
			}
			return string.Empty;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00034270 File Offset: 0x00032470
		internal static bool ContainsNonAsciiChars(string token)
		{
			for (int i = 0; i < token.Length; i++)
			{
				if (token[i] < ' ' || token[i] > '~')
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x000342A8 File Offset: 0x000324A8
		internal void ThrowOnRestrictedHeader(string headerName)
		{
			if (this.m_Type == WebHeaderCollectionType.HttpWebRequest)
			{
				if (WebHeaderCollection.HInfo[headerName].IsRequestRestricted)
				{
					throw new ArgumentException(SR.GetString("The '{0}' header must be modified using the appropriate property or method.", new object[]
					{
						headerName
					}), "name");
				}
			}
			else if (this.m_Type == WebHeaderCollectionType.HttpListenerResponse && WebHeaderCollection.HInfo[headerName].IsResponseRestricted)
			{
				throw new ArgumentException(SR.GetString("The '{0}' header must be modified using the appropriate property or method.", new object[]
				{
					headerName
				}), "name");
			}
		}

		/// <summary>Inserts a header with the specified name and value into the collection.</summary>
		/// <param name="name">The header to add to the collection.</param>
		/// <param name="value">The content of the header.</param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="name" /> is <see langword="null" />, <see cref="F:System.String.Empty" />, or contains invalid characters.-or- 
		///         <paramref name="name" /> is a restricted header that must be set with a property setting.-or- 
		///         <paramref name="value" /> contains invalid characters.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The length of <paramref name="value" /> is greater than 65535. </exception>
		// Token: 0x060009AD RID: 2477 RVA: 0x0003432C File Offset: 0x0003252C
		public override void Add(string name, string value)
		{
			name = WebHeaderCollection.CheckBadChars(name, false);
			this.ThrowOnRestrictedHeader(name);
			value = WebHeaderCollection.CheckBadChars(value, true);
			if (this.m_Type == WebHeaderCollectionType.HttpListenerResponse && value != null && value.Length > 65535)
			{
				throw new ArgumentOutOfRangeException("value", value, SR.GetString("Header values cannot be longer than {0} characters.", new object[]
				{
					ushort.MaxValue
				}));
			}
			this.NormalizeCommonHeaders();
			base.InvalidateCachedArrays();
			this.InnerCollection.Add(name, value);
		}

		/// <summary>Inserts the specified header into the collection.</summary>
		/// <param name="header">The header to add, with the name and value separated by a colon.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="header" /> is <see langword="null" /> or <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="header" /> does not contain a colon (:) character.The length of <paramref name="value" /> is greater than 65535.-or- The name part of <paramref name="header" /> is <see cref="F:System.String.Empty" /> or contains invalid characters.-or- 
		///         <paramref name="header" /> is a restricted header that should be set with a property.-or- The value part of <paramref name="header" /> contains invalid characters. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The length the string after the colon (:) is greater than 65535. </exception>
		// Token: 0x060009AE RID: 2478 RVA: 0x000343B0 File Offset: 0x000325B0
		public void Add(string header)
		{
			if (ValidationHelper.IsBlankString(header))
			{
				throw new ArgumentNullException("header");
			}
			int num = header.IndexOf(':');
			if (num < 0)
			{
				throw new ArgumentException(SR.GetString("Specified value does not have a ':' separator."), "header");
			}
			string text = header.Substring(0, num);
			string text2 = header.Substring(num + 1);
			text = WebHeaderCollection.CheckBadChars(text, false);
			this.ThrowOnRestrictedHeader(text);
			text2 = WebHeaderCollection.CheckBadChars(text2, true);
			if (this.m_Type == WebHeaderCollectionType.HttpListenerResponse && text2 != null && text2.Length > 65535)
			{
				throw new ArgumentOutOfRangeException("value", text2, SR.GetString("Header values cannot be longer than {0} characters.", new object[]
				{
					ushort.MaxValue
				}));
			}
			this.NormalizeCommonHeaders();
			base.InvalidateCachedArrays();
			this.InnerCollection.Add(text, text2);
		}

		/// <summary>Sets the specified header to the specified value.</summary>
		/// <param name="name">The header to set. </param>
		/// <param name="value">The content of the header to set. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" /> or <see cref="F:System.String.Empty" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The length of <paramref name="value" /> is greater than 65535. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="name" /> is a restricted header.-or- 
		///         <paramref name="name" /> or <paramref name="value" /> contain invalid characters. </exception>
		// Token: 0x060009AF RID: 2479 RVA: 0x00034478 File Offset: 0x00032678
		public override void Set(string name, string value)
		{
			if (ValidationHelper.IsBlankString(name))
			{
				throw new ArgumentNullException("name");
			}
			name = WebHeaderCollection.CheckBadChars(name, false);
			this.ThrowOnRestrictedHeader(name);
			value = WebHeaderCollection.CheckBadChars(value, true);
			if (this.m_Type == WebHeaderCollectionType.HttpListenerResponse && value != null && value.Length > 65535)
			{
				throw new ArgumentOutOfRangeException("value", value, SR.GetString("Header values cannot be longer than {0} characters.", new object[]
				{
					ushort.MaxValue
				}));
			}
			this.NormalizeCommonHeaders();
			base.InvalidateCachedArrays();
			this.InnerCollection.Set(name, value);
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0003450C File Offset: 0x0003270C
		internal void SetInternal(string name, string value)
		{
			if (ValidationHelper.IsBlankString(name))
			{
				throw new ArgumentNullException("name");
			}
			name = WebHeaderCollection.CheckBadChars(name, false);
			value = WebHeaderCollection.CheckBadChars(value, true);
			if (this.m_Type == WebHeaderCollectionType.HttpListenerResponse && value != null && value.Length > 65535)
			{
				throw new ArgumentOutOfRangeException("value", value, SR.GetString("Header values cannot be longer than {0} characters.", new object[]
				{
					ushort.MaxValue
				}));
			}
			this.NormalizeCommonHeaders();
			base.InvalidateCachedArrays();
			this.InnerCollection.Set(name, value);
		}

		/// <summary>Removes the specified header from the collection.</summary>
		/// <param name="name">The name of the header to remove from the collection. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" /><see cref="F:System.String.Empty" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="name" /> is a restricted header.-or- 
		///         <paramref name="name" /> contains invalid characters. </exception>
		// Token: 0x060009B1 RID: 2481 RVA: 0x0003459C File Offset: 0x0003279C
		public override void Remove(string name)
		{
			if (ValidationHelper.IsBlankString(name))
			{
				throw new ArgumentNullException("name");
			}
			this.ThrowOnRestrictedHeader(name);
			name = WebHeaderCollection.CheckBadChars(name, false);
			this.NormalizeCommonHeaders();
			if (this.m_InnerCollection != null)
			{
				base.InvalidateCachedArrays();
				this.m_InnerCollection.Remove(name);
			}
		}

		/// <summary>Gets an array of header values stored in a header.</summary>
		/// <param name="header">The header to return. </param>
		/// <returns>An array of header strings.</returns>
		// Token: 0x060009B2 RID: 2482 RVA: 0x000345EC File Offset: 0x000327EC
		public override string[] GetValues(string header)
		{
			this.NormalizeCommonHeaders();
			HeaderInfo headerInfo = WebHeaderCollection.HInfo[header];
			string[] values = this.InnerCollection.GetValues(header);
			if (headerInfo == null || values == null || !headerInfo.AllowMultiValues)
			{
				return values;
			}
			ArrayList arrayList = null;
			for (int i = 0; i < values.Length; i++)
			{
				string[] array = headerInfo.Parser(values[i]);
				if (arrayList == null)
				{
					if (array.Length > 1)
					{
						arrayList = new ArrayList(values);
						arrayList.RemoveRange(i, values.Length - i);
						arrayList.AddRange(array);
					}
				}
				else
				{
					arrayList.AddRange(array);
				}
			}
			if (arrayList != null)
			{
				string[] array2 = new string[arrayList.Count];
				arrayList.CopyTo(array2);
				return array2;
			}
			return values;
		}

		/// <summary>This method is obsolete.</summary>
		/// <returns>The <see cref="T:System.String" /> representation of the collection.</returns>
		// Token: 0x060009B3 RID: 2483 RVA: 0x00034696 File Offset: 0x00032896
		public override string ToString()
		{
			return WebHeaderCollection.GetAsString(this, false, false);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x000346A0 File Offset: 0x000328A0
		internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace)
		{
			if (winInetCompat)
			{
				throw new InvalidOperationException();
			}
			if (cc == null || cc.Count == 0)
			{
				return "\r\n";
			}
			StringBuilder stringBuilder = new StringBuilder(30 * cc.Count);
			string text = cc[string.Empty];
			if (text != null)
			{
				stringBuilder.Append(text).Append("\r\n");
			}
			for (int i = 0; i < cc.Count; i++)
			{
				string key = cc.GetKey(i);
				string value = cc.Get(i);
				if (!ValidationHelper.IsBlankString(key))
				{
					stringBuilder.Append(key);
					if (winInetCompat)
					{
						stringBuilder.Append(':');
					}
					else
					{
						stringBuilder.Append(": ");
					}
					stringBuilder.Append(value).Append("\r\n");
				}
			}
			if (!forTrace)
			{
				stringBuilder.Append("\r\n");
			}
			return stringBuilder.ToString();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebHeaderCollection" /> class.</summary>
		// Token: 0x060009B5 RID: 2485 RVA: 0x0003476B File Offset: 0x0003296B
		public WebHeaderCollection() : base(DBNull.Value)
		{
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00034778 File Offset: 0x00032978
		internal WebHeaderCollection(WebHeaderCollectionType type) : base(DBNull.Value)
		{
			this.m_Type = type;
			if (type == WebHeaderCollectionType.HttpWebResponse)
			{
				this.m_CommonHeaders = new string[WebHeaderCollection.s_CommonHeaderNames.Length - 1];
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.WebHeaderCollection" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> containing the information required to serialize the <see cref="T:System.Net.WebHeaderCollection" />.</param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> containing the source of the serialized stream associated with the new <see cref="T:System.Net.WebHeaderCollection" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="headerName" /> contains invalid characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="headerName" /> is a null reference or <see cref="F:System.String.Empty" />.</exception>
		// Token: 0x060009B7 RID: 2487 RVA: 0x000347A4 File Offset: 0x000329A4
		protected WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(DBNull.Value)
		{
			int @int = serializationInfo.GetInt32("Count");
			this.m_InnerCollection = new NameValueCollection(@int + 2, CaseInsensitiveAscii.StaticInstance);
			for (int i = 0; i < @int; i++)
			{
				string @string = serializationInfo.GetString(i.ToString(NumberFormatInfo.InvariantInfo));
				string string2 = serializationInfo.GetString((i + @int).ToString(NumberFormatInfo.InvariantInfo));
				this.InnerCollection.Add(@string, string2);
			}
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and raises the deserialization event when the deserialization is complete.</summary>
		/// <param name="sender">The source of the deserialization event.</param>
		// Token: 0x060009B8 RID: 2488 RVA: 0x00004D67 File Offset: 0x00002F67
		public override void OnDeserialization(object sender)
		{
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
		/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that specifies the destination for this serialization.</param>
		// Token: 0x060009B9 RID: 2489 RVA: 0x00034820 File Offset: 0x00032A20
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.NormalizeCommonHeaders();
			serializationInfo.AddValue("Count", this.Count);
			for (int i = 0; i < this.Count; i++)
			{
				serializationInfo.AddValue(i.ToString(NumberFormatInfo.InvariantInfo), this.GetKey(i));
				serializationInfo.AddValue((i + this.Count).ToString(NumberFormatInfo.InvariantInfo), this.Get(i));
			}
		}

		/// <summary>Serializes this instance into the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object.</summary>
		/// <param name="serializationInfo">The object into which this <see cref="T:System.Net.WebHeaderCollection" /> will be serialized. </param>
		/// <param name="streamingContext">The destination of the serialization. </param>
		// Token: 0x060009BA RID: 2490 RVA: 0x00034890 File Offset: 0x00032A90
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Gets the value of a particular header in the collection, specified by the name of the header.</summary>
		/// <param name="name">The name of the Web header.</param>
		/// <returns>A <see cref="T:System.String" /> holding the value of the specified header.</returns>
		// Token: 0x060009BB RID: 2491 RVA: 0x0003489C File Offset: 0x00032A9C
		public override string Get(string name)
		{
			if (this.m_CommonHeaders != null && name != null && name.Length > 0 && name[0] < 'Ā')
			{
				int num = (int)WebHeaderCollection.s_CommonHeaderHints[(int)(name[0] & '\u001f')];
				if (num >= 0)
				{
					for (;;)
					{
						string text = WebHeaderCollection.s_CommonHeaderNames[num++];
						if (text.Length < name.Length || CaseInsensitiveAscii.AsciiToLower[(int)name[0]] != CaseInsensitiveAscii.AsciiToLower[(int)text[0]])
						{
							goto IL_EF;
						}
						if (text.Length <= name.Length)
						{
							int num2 = 1;
							while (num2 < text.Length && (name[num2] == text[num2] || (name[num2] <= 'ÿ' && CaseInsensitiveAscii.AsciiToLower[(int)name[num2]] == CaseInsensitiveAscii.AsciiToLower[(int)text[num2]])))
							{
								num2++;
							}
							if (num2 == text.Length)
							{
								break;
							}
						}
					}
					return this.m_CommonHeaders[num - 1];
				}
			}
			IL_EF:
			if (this.m_InnerCollection == null)
			{
				return null;
			}
			return this.m_InnerCollection.Get(name);
		}

		/// <summary>Returns an enumerator that can iterate through the <see cref="T:System.Net.WebHeaderCollection" /> instance.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Net.WebHeaderCollection" />.</returns>
		// Token: 0x060009BC RID: 2492 RVA: 0x000349AE File Offset: 0x00032BAE
		public override IEnumerator GetEnumerator()
		{
			this.NormalizeCommonHeaders();
			return new NameObjectCollectionBase.NameObjectKeysEnumerator(this.InnerCollection);
		}

		/// <summary>Gets the number of headers in the collection.</summary>
		/// <returns>An <see cref="T:System.Int32" /> indicating the number of headers in a request.</returns>
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x000349C1 File Offset: 0x00032BC1
		public override int Count
		{
			get
			{
				return ((this.m_InnerCollection == null) ? 0 : this.m_InnerCollection.Count) + this.m_NumCommonHeaders;
			}
		}

		/// <summary>Gets the value of a particular header in the collection, specified by an index into the collection.</summary>
		/// <param name="index">The zero-based index of the key to get from the collection.</param>
		/// <returns>A <see cref="T:System.String" /> containing the value of the specified header.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is negative. -or-
		///         <paramref name="index" /> exceeds the size of the collection.</exception>
		// Token: 0x060009BE RID: 2494 RVA: 0x000349E0 File Offset: 0x00032BE0
		public override string Get(int index)
		{
			this.NormalizeCommonHeaders();
			return this.InnerCollection.Get(index);
		}

		/// <summary>Gets the header name at the specified position in the collection.</summary>
		/// <param name="index">The zero-based index of the key to get from the collection.</param>
		/// <returns>A <see cref="T:System.String" /> holding the header name.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is negative. -or-
		///         <paramref name="index" /> exceeds the size of the collection.</exception>
		// Token: 0x060009BF RID: 2495 RVA: 0x000349F4 File Offset: 0x00032BF4
		public override string GetKey(int index)
		{
			this.NormalizeCommonHeaders();
			return this.InnerCollection.GetKey(index);
		}

		/// <summary>Gets all header names (keys) in the collection.</summary>
		/// <returns>An array of type <see cref="T:System.String" /> containing all header names in a Web request.</returns>
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x00034A08 File Offset: 0x00032C08
		public override string[] AllKeys
		{
			get
			{
				this.NormalizeCommonHeaders();
				return this.InnerCollection.AllKeys;
			}
		}

		// Token: 0x04000729 RID: 1833
		private static readonly HeaderInfoTable HInfo = new HeaderInfoTable();

		// Token: 0x0400072A RID: 1834
		private string[] m_CommonHeaders;

		// Token: 0x0400072B RID: 1835
		private int m_NumCommonHeaders;

		// Token: 0x0400072C RID: 1836
		private static readonly string[] s_CommonHeaderNames = new string[]
		{
			"Accept-Ranges",
			"Content-Length",
			"Cache-Control",
			"Content-Type",
			"Date",
			"Expires",
			"ETag",
			"Last-Modified",
			"Location",
			"Proxy-Authenticate",
			"P3P",
			"Set-Cookie2",
			"Set-Cookie",
			"Server",
			"Via",
			"WWW-Authenticate",
			"X-AspNet-Version",
			"X-Powered-By",
			"["
		};

		// Token: 0x0400072D RID: 1837
		private static readonly sbyte[] s_CommonHeaderHints = new sbyte[]
		{
			-1,
			0,
			-1,
			1,
			4,
			5,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			7,
			-1,
			-1,
			-1,
			9,
			-1,
			-1,
			11,
			-1,
			-1,
			14,
			15,
			16,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1,
			-1
		};

		// Token: 0x0400072E RID: 1838
		private NameValueCollection m_InnerCollection;

		// Token: 0x0400072F RID: 1839
		private WebHeaderCollectionType m_Type;

		// Token: 0x04000730 RID: 1840
		private static readonly char[] HttpTrimCharacters = new char[]
		{
			'\t',
			'\n',
			'\v',
			'\f',
			'\r',
			' '
		};

		// Token: 0x04000731 RID: 1841
		private static WebHeaderCollection.RfcChar[] RfcCharMap = new WebHeaderCollection.RfcChar[]
		{
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.WS,
			WebHeaderCollection.RfcChar.LF,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.CR,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.Ctl,
			WebHeaderCollection.RfcChar.WS,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Delim,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Delim,
			WebHeaderCollection.RfcChar.Delim,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Delim,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Delim,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Colon,
			WebHeaderCollection.RfcChar.Delim,
			WebHeaderCollection.RfcChar.Delim,
			WebHeaderCollection.RfcChar.Delim,
			WebHeaderCollection.RfcChar.Delim,
			WebHeaderCollection.RfcChar.Delim,
			WebHeaderCollection.RfcChar.Delim,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Delim,
			WebHeaderCollection.RfcChar.Delim,
			WebHeaderCollection.RfcChar.Delim,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Delim,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Delim,
			WebHeaderCollection.RfcChar.Reg,
			WebHeaderCollection.RfcChar.Ctl
		};

		// Token: 0x02000165 RID: 357
		private enum RfcChar : byte
		{
			// Token: 0x04000733 RID: 1843
			High,
			// Token: 0x04000734 RID: 1844
			Reg,
			// Token: 0x04000735 RID: 1845
			Ctl,
			// Token: 0x04000736 RID: 1846
			CR,
			// Token: 0x04000737 RID: 1847
			LF,
			// Token: 0x04000738 RID: 1848
			WS,
			// Token: 0x04000739 RID: 1849
			Colon,
			// Token: 0x0400073A RID: 1850
			Delim
		}
	}
}
