using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Represents a mutable reference type that wraps either a <see cref="P:System.Data.SqlTypes.SqlBytes.Buffer" /> or a <see cref="P:System.Data.SqlTypes.SqlBytes.Stream" />.</summary>
	// Token: 0x020000B2 RID: 178
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public sealed class SqlBytes : INullable, IXmlSerializable, ISerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlBytes" /> class.</summary>
		// Token: 0x06000ACC RID: 2764 RVA: 0x0003D263 File Offset: 0x0003B463
		public SqlBytes()
		{
			this.SetNull();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlBytes" /> class based on the specified byte array.</summary>
		/// <param name="buffer">The array of unsigned bytes. </param>
		// Token: 0x06000ACD RID: 2765 RVA: 0x0003D274 File Offset: 0x0003B474
		public SqlBytes(byte[] buffer)
		{
			this._rgbBuf = buffer;
			this._stream = null;
			if (this._rgbBuf == null)
			{
				this._state = SqlBytesCharsState.Null;
				this._lCurLen = -1L;
			}
			else
			{
				this._state = SqlBytesCharsState.Buffer;
				this._lCurLen = (long)this._rgbBuf.Length;
			}
			this._rgbWorkBuf = null;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlBytes" /> class based on the specified <see cref="T:System.Data.SqlTypes.SqlBinary" /> value.</summary>
		/// <param name="value">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> value.</param>
		// Token: 0x06000ACE RID: 2766 RVA: 0x0003D2CB File Offset: 0x0003B4CB
		public SqlBytes(SqlBinary value) : this(value.IsNull ? null : value.Value)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlBytes" /> class based on the specified <see cref="T:System.IO.Stream" /> value.</summary>
		/// <param name="s">A <see cref="T:System.IO.Stream" />. </param>
		// Token: 0x06000ACF RID: 2767 RVA: 0x0003D2E6 File Offset: 0x0003B4E6
		public SqlBytes(Stream s)
		{
			this._rgbBuf = null;
			this._lCurLen = -1L;
			this._stream = s;
			this._state = ((s == null) ? SqlBytesCharsState.Null : SqlBytesCharsState.Stream);
			this._rgbWorkBuf = null;
		}

		/// <summary>Gets a Boolean value that indicates whether this <see cref="T:System.Data.SqlTypes.SqlBytes" /> is null.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Data.SqlTypes.SqlBytes" /> is null, <see langword="false" /> otherwise.</returns>
		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x0003D318 File Offset: 0x0003B518
		public bool IsNull
		{
			get
			{
				return this._state == SqlBytesCharsState.Null;
			}
		}

		/// <summary>Returns a reference to the internal buffer. </summary>
		/// <returns>Returns a reference to the internal buffer. For <see cref="T:System.Data.SqlTypes.SqlBytes" /> instances created on top of unmanaged pointers, it returns a managed copy of the internal buffer.</returns>
		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0003D323 File Offset: 0x0003B523
		public byte[] Buffer
		{
			get
			{
				if (this.FStream())
				{
					this.CopyStreamToBuffer();
				}
				return this._rgbBuf;
			}
		}

		/// <summary>Gets the length of the value that is contained in the <see cref="T:System.Data.SqlTypes.SqlBytes" /> instance.</summary>
		/// <returns>A <see cref="T:System.Int64" /> value representing the length of the value that is contained in the <see cref="T:System.Data.SqlTypes.SqlBytes" /> instance. Returns -1 if no buffer is available to the instance or if the value is null. Returns a <see cref="P:System.IO.Stream.Length" /> for a stream-wrapped instance.</returns>
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x0003D33C File Offset: 0x0003B53C
		public long Length
		{
			get
			{
				SqlBytesCharsState state = this._state;
				if (state == SqlBytesCharsState.Null)
				{
					throw new SqlNullValueException();
				}
				if (state != SqlBytesCharsState.Stream)
				{
					return this._lCurLen;
				}
				return this._stream.Length;
			}
		}

		/// <summary>Gets the maximum length of the value of the internal buffer of this <see cref="T:System.Data.SqlTypes.SqlBytes" />.</summary>
		/// <returns>A long representing the maximum length of the value of the internal buffer. Returns -1 for a stream-wrapped <see cref="T:System.Data.SqlTypes.SqlBytes" />.</returns>
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0003D371 File Offset: 0x0003B571
		public long MaxLength
		{
			get
			{
				if (this._state == SqlBytesCharsState.Stream)
				{
					return -1L;
				}
				if (this._rgbBuf != null)
				{
					return (long)this._rgbBuf.Length;
				}
				return -1L;
			}
		}

		/// <summary>Returns a managed copy of the value held by this <see cref="T:System.Data.SqlTypes.SqlBytes" />.</summary>
		/// <returns>The value of this <see cref="T:System.Data.SqlTypes.SqlBytes" /> as an array of bytes.</returns>
		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x0003D394 File Offset: 0x0003B594
		public byte[] Value
		{
			get
			{
				SqlBytesCharsState state = this._state;
				if (state != SqlBytesCharsState.Null)
				{
					byte[] array;
					if (state != SqlBytesCharsState.Stream)
					{
						array = new byte[this._lCurLen];
						Array.Copy(this._rgbBuf, 0, array, 0, (int)this._lCurLen);
					}
					else
					{
						if (this._stream.Length > 2147483647L)
						{
							throw new SqlTypeException("The buffer is insufficient. Read or write operation failed.");
						}
						array = new byte[this._stream.Length];
						if (this._stream.Position != 0L)
						{
							this._stream.Seek(0L, SeekOrigin.Begin);
						}
						this._stream.Read(array, 0, checked((int)this._stream.Length));
					}
					return array;
				}
				throw new SqlNullValueException();
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Data.SqlTypes.SqlBytes" /> instance at the specified index.</summary>
		/// <param name="offset">A <see cref="T:System.Int64" /> value.</param>
		/// <returns>A <see cref="T:System.Byte" /> value. </returns>
		// Token: 0x17000193 RID: 403
		public byte this[long offset]
		{
			get
			{
				if (offset < 0L || offset >= this.Length)
				{
					throw new ArgumentOutOfRangeException("offset");
				}
				if (this._rgbWorkBuf == null)
				{
					this._rgbWorkBuf = new byte[1];
				}
				this.Read(offset, this._rgbWorkBuf, 0, 1);
				return this._rgbWorkBuf[0];
			}
			set
			{
				if (this._rgbWorkBuf == null)
				{
					this._rgbWorkBuf = new byte[1];
				}
				this._rgbWorkBuf[0] = value;
				this.Write(offset, this._rgbWorkBuf, 0, 1);
			}
		}

		/// <summary>Returns information about the storage state of this <see cref="T:System.Data.SqlTypes.SqlBytes" /> instance.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.StorageState" /> enumeration.</returns>
		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0003D4C4 File Offset: 0x0003B6C4
		public StorageState Storage
		{
			get
			{
				switch (this._state)
				{
				case SqlBytesCharsState.Null:
					throw new SqlNullValueException();
				case SqlBytesCharsState.Buffer:
					return StorageState.Buffer;
				case SqlBytesCharsState.Stream:
					return StorageState.Stream;
				}
				return StorageState.UnmanagedBuffer;
			}
		}

		/// <summary>Gets or sets the data of this <see cref="T:System.Data.SqlTypes.SqlBytes" /> as a stream.</summary>
		/// <returns>The stream that contains the SqlBytes data.</returns>
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0003D4FB File Offset: 0x0003B6FB
		// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x0003D512 File Offset: 0x0003B712
		public Stream Stream
		{
			get
			{
				if (!this.FStream())
				{
					return new StreamOnSqlBytes(this);
				}
				return this._stream;
			}
			set
			{
				this._lCurLen = -1L;
				this._stream = value;
				this._state = ((value == null) ? SqlBytesCharsState.Null : SqlBytesCharsState.Stream);
			}
		}

		/// <summary>Sets this <see cref="T:System.Data.SqlTypes.SqlBytes" /> instance to null.</summary>
		// Token: 0x06000ADA RID: 2778 RVA: 0x0003D530 File Offset: 0x0003B730
		public void SetNull()
		{
			this._lCurLen = -1L;
			this._stream = null;
			this._state = SqlBytesCharsState.Null;
		}

		/// <summary>Sets the length of this <see cref="T:System.Data.SqlTypes.SqlBytes" /> instance.</summary>
		/// <param name="value">The <see cref="T:System.Int64" /> long value representing the length.</param>
		// Token: 0x06000ADB RID: 2779 RVA: 0x0003D548 File Offset: 0x0003B748
		public void SetLength(long value)
		{
			if (value < 0L)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (this.FStream())
			{
				this._stream.SetLength(value);
				return;
			}
			if (this._rgbBuf == null)
			{
				throw new SqlTypeException("There is no buffer. Read or write operation failed.");
			}
			if (value > (long)this._rgbBuf.Length)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (this.IsNull)
			{
				this._state = SqlBytesCharsState.Buffer;
			}
			this._lCurLen = value;
		}

		/// <summary>Copies bytes from this <see cref="T:System.Data.SqlTypes.SqlBytes" /> instance to the passed-in buffer and returns the number of copied bytes.</summary>
		/// <param name="offset">An <see cref="T:System.Int64" /> long value offset into the value that is contained in the <see cref="T:System.Data.SqlTypes.SqlBytes" /> instance.</param>
		/// <param name="buffer">The byte array buffer to copy into.</param>
		/// <param name="offsetInBuffer">An <see cref="T:System.Int32" /> integer offset into the buffer to start copying into.</param>
		/// <param name="count">An <see cref="T:System.Int32" /> integer representing the number of bytes to copy.</param>
		/// <returns>An <see cref="T:System.Int64" /> long value representing the number of copied bytes.</returns>
		// Token: 0x06000ADC RID: 2780 RVA: 0x0003D5BC File Offset: 0x0003B7BC
		public long Read(long offset, byte[] buffer, int offsetInBuffer, int count)
		{
			if (this.IsNull)
			{
				throw new SqlNullValueException();
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset > this.Length || offset < 0L)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (offsetInBuffer > buffer.Length || offsetInBuffer < 0)
			{
				throw new ArgumentOutOfRangeException("offsetInBuffer");
			}
			if (count < 0 || count > buffer.Length - offsetInBuffer)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if ((long)count > this.Length - offset)
			{
				count = (int)(this.Length - offset);
			}
			if (count != 0)
			{
				if (this._state == SqlBytesCharsState.Stream)
				{
					if (this._stream.Position != offset)
					{
						this._stream.Seek(offset, SeekOrigin.Begin);
					}
					this._stream.Read(buffer, offsetInBuffer, count);
				}
				else
				{
					Array.Copy(this._rgbBuf, offset, buffer, (long)offsetInBuffer, (long)count);
				}
			}
			return (long)count;
		}

		/// <summary>Copies bytes from the passed-in buffer to this <see cref="T:System.Data.SqlTypes.SqlBytes" /> instance.</summary>
		/// <param name="offset">An <see cref="T:System.Int64" /> long value offset into the value that is contained in the <see cref="T:System.Data.SqlTypes.SqlBytes" /> instance.</param>
		/// <param name="buffer">The byte array buffer to copy into.</param>
		/// <param name="offsetInBuffer">An <see cref="T:System.Int32" /> integer offset into the buffer to start copying into.</param>
		/// <param name="count">An <see cref="T:System.Int32" /> integer representing the number of bytes to copy.</param>
		// Token: 0x06000ADD RID: 2781 RVA: 0x0003D694 File Offset: 0x0003B894
		public void Write(long offset, byte[] buffer, int offsetInBuffer, int count)
		{
			if (this.FStream())
			{
				if (this._stream.Position != offset)
				{
					this._stream.Seek(offset, SeekOrigin.Begin);
				}
				this._stream.Write(buffer, offsetInBuffer, count);
				return;
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (this._rgbBuf == null)
			{
				throw new SqlTypeException("There is no buffer. Read or write operation failed.");
			}
			if (offset < 0L)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (offset > (long)this._rgbBuf.Length)
			{
				throw new SqlTypeException("The buffer is insufficient. Read or write operation failed.");
			}
			if (offsetInBuffer < 0 || offsetInBuffer > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("offsetInBuffer");
			}
			if (count < 0 || count > buffer.Length - offsetInBuffer)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if ((long)count > (long)this._rgbBuf.Length - offset)
			{
				throw new SqlTypeException("The buffer is insufficient. Read or write operation failed.");
			}
			if (this.IsNull)
			{
				if (offset != 0L)
				{
					throw new SqlTypeException("Cannot write to non-zero offset, because current value is Null.");
				}
				this._lCurLen = 0L;
				this._state = SqlBytesCharsState.Buffer;
			}
			else if (offset > this._lCurLen)
			{
				throw new SqlTypeException("Cannot write from an offset that is larger than current length. It would leave uninitialized data in the buffer.");
			}
			if (count != 0)
			{
				Array.Copy(buffer, (long)offsetInBuffer, this._rgbBuf, offset, (long)count);
				if (this._lCurLen < offset + (long)count)
				{
					this._lCurLen = offset + (long)count;
				}
			}
		}

		/// <summary>Constructs and returns a <see cref="T:System.Data.SqlTypes.SqlBinary" /> from this <see cref="T:System.Data.SqlTypes.SqlBytes" /> instance.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBinary" /> from this instance.</returns>
		// Token: 0x06000ADE RID: 2782 RVA: 0x0003D7CF File Offset: 0x0003B9CF
		public SqlBinary ToSqlBinary()
		{
			if (!this.IsNull)
			{
				return new SqlBinary(this.Value);
			}
			return SqlBinary.Null;
		}

		/// <summary>Converts a <see cref="T:System.Data.SqlTypes.SqlBytes" /> structure to a <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure.</summary>
		/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlBytes" /> structure to be converted.</param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure.</returns>
		// Token: 0x06000ADF RID: 2783 RVA: 0x0003D7EA File Offset: 0x0003B9EA
		public static explicit operator SqlBinary(SqlBytes value)
		{
			return value.ToSqlBinary();
		}

		/// <summary>Converts a <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure to a <see cref="T:System.Data.SqlTypes.SqlBytes" /> structure.</summary>
		/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlBinary" /> structure to be converted.</param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBytes" /> structure.</returns>
		// Token: 0x06000AE0 RID: 2784 RVA: 0x0003D7F2 File Offset: 0x0003B9F2
		public static explicit operator SqlBytes(SqlBinary value)
		{
			return new SqlBytes(value);
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0003D7FA File Offset: 0x0003B9FA
		[Conditional("DEBUG")]
		private void AssertValid()
		{
			bool isNull = this.IsNull;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0003D804 File Offset: 0x0003BA04
		private void CopyStreamToBuffer()
		{
			long length = this._stream.Length;
			if (length >= 2147483647L)
			{
				throw new SqlTypeException("Cannot write from an offset that is larger than current length. It would leave uninitialized data in the buffer.");
			}
			if (this._rgbBuf == null || (long)this._rgbBuf.Length < length)
			{
				this._rgbBuf = new byte[length];
			}
			if (this._stream.Position != 0L)
			{
				this._stream.Seek(0L, SeekOrigin.Begin);
			}
			this._stream.Read(this._rgbBuf, 0, (int)length);
			this._stream = null;
			this._lCurLen = length;
			this._state = SqlBytesCharsState.Buffer;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0003D898 File Offset: 0x0003BA98
		internal bool FStream()
		{
			return this._state == SqlBytesCharsState.Stream;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0003D8A3 File Offset: 0x0003BAA3
		private void SetBuffer(byte[] buffer)
		{
			this._rgbBuf = buffer;
			this._lCurLen = ((this._rgbBuf == null) ? -1L : ((long)this._rgbBuf.Length));
			this._stream = null;
			this._state = ((this._rgbBuf == null) ? SqlBytesCharsState.Null : SqlBytesCharsState.Buffer);
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <returns>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</returns>
		// Token: 0x06000AE5 RID: 2789 RVA: 0x000020F7 File Offset: 0x000002F7
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="r">
		///       <see langword="XmlReader" />
		///     </param>
		// Token: 0x06000AE6 RID: 2790 RVA: 0x0003D8E0 File Offset: 0x0003BAE0
		void IXmlSerializable.ReadXml(XmlReader r)
		{
			byte[] buffer = null;
			string attribute = r.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				r.ReadElementString();
				this.SetNull();
			}
			else
			{
				string text = r.ReadElementString();
				if (text == null)
				{
					buffer = Array.Empty<byte>();
				}
				else
				{
					text = text.Trim();
					if (text.Length == 0)
					{
						buffer = Array.Empty<byte>();
					}
					else
					{
						buffer = Convert.FromBase64String(text);
					}
				}
			}
			this.SetBuffer(buffer);
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="writer">
		///       <see langword="XmlWriter" />
		///     </param>
		// Token: 0x06000AE7 RID: 2791 RVA: 0x0003D954 File Offset: 0x0003BB54
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			byte[] buffer = this.Buffer;
			writer.WriteString(Convert.ToBase64String(buffer, 0, (int)this.Length));
		}

		/// <summary>Returns the XML Schema definition language (XSD) of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">A <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>A <see langword="string" /> that indicates the XSD of the specified <see langword="XmlSchemaSet" />.</returns>
		// Token: 0x06000AE8 RID: 2792 RVA: 0x0003C267 File Offset: 0x0003A467
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("base64Binary", "http://www.w3.org/2001/XMLSchema");
		}

		/// <summary>Gets serialization information with all the data needed to reinstantiate this <see cref="T:System.Data.SqlTypes.SqlBytes" /> instance.</summary>
		/// <param name="info">The object to be populated with serialization information. </param>
		/// <param name="context">The destination context of the serialization.</param>
		// Token: 0x06000AE9 RID: 2793 RVA: 0x0002BF6D File Offset: 0x0002A16D
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Returns a null instance of this <see cref="T:System.Data.SqlTypes.SqlBytes" />.</summary>
		/// <returns>Returns an instance in such a way that <see cref="P:System.Data.SqlTypes.SqlBytes.IsNull" /> returns <see langword="true" />.</returns>
		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x0003D99F File Offset: 0x0003BB9F
		public static SqlBytes Null
		{
			get
			{
				return new SqlBytes(null);
			}
		}

		// Token: 0x04000398 RID: 920
		internal byte[] _rgbBuf;

		// Token: 0x04000399 RID: 921
		private long _lCurLen;

		// Token: 0x0400039A RID: 922
		internal Stream _stream;

		// Token: 0x0400039B RID: 923
		private SqlBytesCharsState _state;

		// Token: 0x0400039C RID: 924
		private byte[] _rgbWorkBuf;

		// Token: 0x0400039D RID: 925
		private const long x_lMaxLen = 2147483647L;

		// Token: 0x0400039E RID: 926
		private const long x_lNull = -1L;
	}
}
