using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>
	///     <see cref="T:System.Data.SqlTypes.SqlChars" /> is a mutable reference type that wraps a <see cref="T:System.Char" /> array or a <see cref="T:System.Data.SqlTypes.SqlString" /> instance.</summary>
	// Token: 0x020000B4 RID: 180
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public sealed class SqlChars : INullable, IXmlSerializable, ISerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlChars" /> class.</summary>
		// Token: 0x06000AFC RID: 2812 RVA: 0x0003DD3C File Offset: 0x0003BF3C
		public SqlChars()
		{
			this.SetNull();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlChars" /> class based on the specified character array.</summary>
		/// <param name="buffer">A <see cref="T:System.Char" /> array.</param>
		// Token: 0x06000AFD RID: 2813 RVA: 0x0003DD4C File Offset: 0x0003BF4C
		public SqlChars(char[] buffer)
		{
			this._rgchBuf = buffer;
			this._stream = null;
			if (this._rgchBuf == null)
			{
				this._state = SqlBytesCharsState.Null;
				this._lCurLen = -1L;
			}
			else
			{
				this._state = SqlBytesCharsState.Buffer;
				this._lCurLen = (long)this._rgchBuf.Length;
			}
			this._rgchWorkBuf = null;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlChars" /> class based on the specified <see cref="T:System.Data.SqlTypes.SqlString" /> value.</summary>
		/// <param name="value">A <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
		// Token: 0x06000AFE RID: 2814 RVA: 0x0003DDA3 File Offset: 0x0003BFA3
		public SqlChars(SqlString value) : this(value.IsNull ? null : value.Value.ToCharArray())
		{
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0003DDC3 File Offset: 0x0003BFC3
		internal SqlChars(SqlStreamChars s)
		{
			this._rgchBuf = null;
			this._lCurLen = -1L;
			this._stream = s;
			this._state = ((s == null) ? SqlBytesCharsState.Null : SqlBytesCharsState.Stream);
			this._rgchWorkBuf = null;
		}

		/// <summary>Gets a Boolean value that indicates whether this <see cref="T:System.Data.SqlTypes.SqlChars" /> is null.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Data.SqlTypes.SqlChars" /> is null. Otherwise, <see langword="false" />. </returns>
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x0003DDF5 File Offset: 0x0003BFF5
		public bool IsNull
		{
			get
			{
				return this._state == SqlBytesCharsState.Null;
			}
		}

		/// <summary>Returns a reference to the internal buffer. </summary>
		/// <returns>Returns a reference to the internal buffer. For <see cref="T:System.Data.SqlTypes.SqlChars" /> instances created on top of unmanaged pointers, it returns a managed copy of the internal buffer.</returns>
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x0003DE00 File Offset: 0x0003C000
		public char[] Buffer
		{
			get
			{
				if (this.FStream())
				{
					this.CopyStreamToBuffer();
				}
				return this._rgchBuf;
			}
		}

		/// <summary>Gets the length of the value that is contained in the <see cref="T:System.Data.SqlTypes.SqlChars" /> instance.</summary>
		/// <returns>A <see cref="T:System.Int64" /> value that indicates the length in characters of the value that is contained in the <see cref="T:System.Data.SqlTypes.SqlChars" /> instance.Returns -1 if no buffer is available to the instance, or if the value is null. Returns a <see cref="P:System.IO.Stream.Length" /> for a stream-wrapped instance.</returns>
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x0003DE18 File Offset: 0x0003C018
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

		/// <summary>Gets the maximum length in two-byte characters of the value the internal buffer can hold.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value representing the maximum length in two-byte characters of the value of the internal buffer. Returns -1 for a stream-wrapped <see cref="T:System.Data.SqlTypes.SqlChars" />.</returns>
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x0003DE4D File Offset: 0x0003C04D
		public long MaxLength
		{
			get
			{
				if (this._state == SqlBytesCharsState.Stream)
				{
					return -1L;
				}
				if (this._rgchBuf != null)
				{
					return (long)this._rgchBuf.Length;
				}
				return -1L;
			}
		}

		/// <summary>Returns a managed copy of the value held by this <see cref="T:System.Data.SqlTypes.SqlChars" />.</summary>
		/// <returns>The value of this <see cref="T:System.Data.SqlTypes.SqlChars" /> as an array of characters.</returns>
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0003DE70 File Offset: 0x0003C070
		public char[] Value
		{
			get
			{
				SqlBytesCharsState state = this._state;
				if (state != SqlBytesCharsState.Null)
				{
					char[] array;
					if (state != SqlBytesCharsState.Stream)
					{
						array = new char[this._lCurLen];
						Array.Copy(this._rgchBuf, 0, array, 0, (int)this._lCurLen);
					}
					else
					{
						if (this._stream.Length > 2147483647L)
						{
							throw new SqlTypeException("The buffer is insufficient. Read or write operation failed.");
						}
						array = new char[this._stream.Length];
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

		/// <summary>Gets or sets the <see cref="T:System.Data.SqlTypes.SqlChars" /> instance at the specified index.</summary>
		/// <param name="offset">An <see cref="T:System.Int64" /> value.</param>
		/// <returns>A <see cref="T:System.Char" /> value. </returns>
		// Token: 0x170001A1 RID: 417
		public char this[long offset]
		{
			get
			{
				if (offset < 0L || offset >= this.Length)
				{
					throw new ArgumentOutOfRangeException("offset");
				}
				if (this._rgchWorkBuf == null)
				{
					this._rgchWorkBuf = new char[1];
				}
				this.Read(offset, this._rgchWorkBuf, 0, 1);
				return this._rgchWorkBuf[0];
			}
			set
			{
				if (this._rgchWorkBuf == null)
				{
					this._rgchWorkBuf = new char[1];
				}
				this._rgchWorkBuf[0] = value;
				this.Write(offset, this._rgchWorkBuf, 0, 1);
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x0003DFA0 File Offset: 0x0003C1A0
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x0003DFB7 File Offset: 0x0003C1B7
		internal SqlStreamChars Stream
		{
			get
			{
				if (!this.FStream())
				{
					return new StreamOnSqlChars(this);
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

		/// <summary>Returns information about the storage state of this <see cref="T:System.Data.SqlTypes.SqlChars" /> instance.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.StorageState" /> enumeration.</returns>
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x0003DFD8 File Offset: 0x0003C1D8
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

		/// <summary>Sets this <see cref="T:System.Data.SqlTypes.SqlChars" /> instance to null.</summary>
		// Token: 0x06000B0A RID: 2826 RVA: 0x0003E00F File Offset: 0x0003C20F
		public void SetNull()
		{
			this._lCurLen = -1L;
			this._stream = null;
			this._state = SqlBytesCharsState.Null;
		}

		/// <summary>Sets the length of this <see cref="T:System.Data.SqlTypes.SqlChars" /> instance.</summary>
		/// <param name="value">The <see cref="T:System.Int64" /><see langword="long" /> value representing the length.</param>
		// Token: 0x06000B0B RID: 2827 RVA: 0x0003E028 File Offset: 0x0003C228
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
			if (this._rgchBuf == null)
			{
				throw new SqlTypeException("There is no buffer. Read or write operation failed.");
			}
			if (value > (long)this._rgchBuf.Length)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (this.IsNull)
			{
				this._state = SqlBytesCharsState.Buffer;
			}
			this._lCurLen = value;
		}

		/// <summary>Copies characters from this <see cref="T:System.Data.SqlTypes.SqlChars" /> instance to the passed-in buffer and returns the number of copied characters.</summary>
		/// <param name="offset">An <see cref="T:System.Int64" /><see langword="long" /> value offset into the value that is contained in the <see cref="T:System.Data.SqlTypes.SqlChars" /> instance.</param>
		/// <param name="buffer">The character array buffer to copy into.</param>
		/// <param name="offsetInBuffer">An <see cref="T:System.Int32" /> integer offset into the buffer to start copying into.</param>
		/// <param name="count">An <see cref="T:System.Int32" /> integer value representing the number of characters to copy.</param>
		/// <returns>An <see cref="T:System.Int64" /><see langword="long" /> value representing the number of copied bytes.</returns>
		// Token: 0x06000B0C RID: 2828 RVA: 0x0003E09C File Offset: 0x0003C29C
		public long Read(long offset, char[] buffer, int offsetInBuffer, int count)
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
					Array.Copy(this._rgchBuf, offset, buffer, (long)offsetInBuffer, (long)count);
				}
			}
			return (long)count;
		}

		/// <summary>Copies characters from the passed-in buffer to this <see cref="T:System.Data.SqlTypes.SqlChars" /> instance.</summary>
		/// <param name="offset">A <see langword="long" /> value offset into the value that is contained in the <see cref="T:System.Data.SqlTypes.SqlChars" /> instance.</param>
		/// <param name="buffer">The character array buffer to copy into.</param>
		/// <param name="offsetInBuffer">An <see cref="T:System.Int32" /> integer offset into the buffer to start copying into.</param>
		/// <param name="count">An <see cref="T:System.Int32" /> integer representing the number of characters to copy.</param>
		// Token: 0x06000B0D RID: 2829 RVA: 0x0003E174 File Offset: 0x0003C374
		public void Write(long offset, char[] buffer, int offsetInBuffer, int count)
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
			if (this._rgchBuf == null)
			{
				throw new SqlTypeException("There is no buffer. Read or write operation failed.");
			}
			if (offset < 0L)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (offset > (long)this._rgchBuf.Length)
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
			if ((long)count > (long)this._rgchBuf.Length - offset)
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
				Array.Copy(buffer, (long)offsetInBuffer, this._rgchBuf, offset, (long)count);
				if (this._lCurLen < offset + (long)count)
				{
					this._lCurLen = offset + (long)count;
				}
			}
		}

		/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlChars" /> instance to its equivalent <see cref="T:System.Data.SqlTypes.SqlString" /> representation.</summary>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlString" /> representation of this type.</returns>
		// Token: 0x06000B0E RID: 2830 RVA: 0x0003E2AF File Offset: 0x0003C4AF
		public SqlString ToSqlString()
		{
			if (!this.IsNull)
			{
				return new string(this.Value);
			}
			return SqlString.Null;
		}

		/// <summary>Converts a <see cref="T:System.Data.SqlTypes.SqlChars" /> structure to a <see cref="T:System.Data.SqlTypes.SqlString" /> structure.</summary>
		/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlChars" /> structure to be converted.</param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlString" /> structure.</returns>
		// Token: 0x06000B0F RID: 2831 RVA: 0x0003E2CF File Offset: 0x0003C4CF
		public static explicit operator SqlString(SqlChars value)
		{
			return value.ToSqlString();
		}

		/// <summary>Converts a <see cref="T:System.Data.SqlTypes.SqlString" /> structure to a <see cref="T:System.Data.SqlTypes.SqlChars" /> structure.</summary>
		/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlString" /> structure to be converted.</param>
		/// <returns>A <see cref="T:System.Data.SqlTypes.SqlChars" /> structure.</returns>
		// Token: 0x06000B10 RID: 2832 RVA: 0x0003E2D7 File Offset: 0x0003C4D7
		public static explicit operator SqlChars(SqlString value)
		{
			return new SqlChars(value);
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0003E2DF File Offset: 0x0003C4DF
		[Conditional("DEBUG")]
		private void AssertValid()
		{
			bool isNull = this.IsNull;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0003E2E8 File Offset: 0x0003C4E8
		internal bool FStream()
		{
			return this._state == SqlBytesCharsState.Stream;
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0003E2F4 File Offset: 0x0003C4F4
		private void CopyStreamToBuffer()
		{
			long length = this._stream.Length;
			if (length >= 2147483647L)
			{
				throw new SqlTypeException("The buffer is insufficient. Read or write operation failed.");
			}
			if (this._rgchBuf == null || (long)this._rgchBuf.Length < length)
			{
				this._rgchBuf = new char[length];
			}
			if (this._stream.Position != 0L)
			{
				this._stream.Seek(0L, SeekOrigin.Begin);
			}
			this._stream.Read(this._rgchBuf, 0, (int)length);
			this._stream = null;
			this._lCurLen = length;
			this._state = SqlBytesCharsState.Buffer;
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0003E388 File Offset: 0x0003C588
		private void SetBuffer(char[] buffer)
		{
			this._rgchBuf = buffer;
			this._lCurLen = ((this._rgchBuf == null) ? -1L : ((long)this._rgchBuf.Length));
			this._stream = null;
			this._state = ((this._rgchBuf == null) ? SqlBytesCharsState.Null : SqlBytesCharsState.Buffer);
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <returns>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</returns>
		// Token: 0x06000B15 RID: 2837 RVA: 0x000020F7 File Offset: 0x000002F7
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="r">
		///       <see langword="XmlReader" />
		///     </param>
		// Token: 0x06000B16 RID: 2838 RVA: 0x0003E3C8 File Offset: 0x0003C5C8
		void IXmlSerializable.ReadXml(XmlReader r)
		{
			string attribute = r.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				r.ReadElementString();
				this.SetNull();
				return;
			}
			char[] buffer = r.ReadElementString().ToCharArray();
			this.SetBuffer(buffer);
		}

		/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		/// <param name="writer">
		///       <see langword="XmlWriter" />
		///     </param>
		// Token: 0x06000B17 RID: 2839 RVA: 0x0003E414 File Offset: 0x0003C614
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
				return;
			}
			char[] buffer = this.Buffer;
			writer.WriteString(new string(buffer, 0, (int)this.Length));
		}

		/// <summary>Returns the XML Schema definition language (XSD) of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">A <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>A <see langword="string" /> value that indicates the XSD of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
		// Token: 0x06000B18 RID: 2840 RVA: 0x0003E45F File Offset: 0x0003C65F
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("string", "http://www.w3.org/2001/XMLSchema");
		}

		/// <summary>Gets serialization information with all the data needed to reinstantiate this <see cref="T:System.Data.SqlTypes.SqlChars" /> instance.</summary>
		/// <param name="info">The object to be populated with serialization information. </param>
		/// <param name="context">The destination context of the serialization.</param>
		// Token: 0x06000B19 RID: 2841 RVA: 0x0002BF6D File Offset: 0x0002A16D
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Returns a null instance of this <see cref="T:System.Data.SqlTypes.SqlChars" />.</summary>
		/// <returns>Returns an instance in such a way that <see cref="P:System.Data.SqlTypes.SqlChars.IsNull" /> returns <see langword="true" />. For more information, see Handling Null Values.</returns>
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x0003E470 File Offset: 0x0003C670
		public static SqlChars Null
		{
			get
			{
				return new SqlChars(null);
			}
		}

		// Token: 0x040003A1 RID: 929
		internal char[] _rgchBuf;

		// Token: 0x040003A2 RID: 930
		private long _lCurLen;

		// Token: 0x040003A3 RID: 931
		internal SqlStreamChars _stream;

		// Token: 0x040003A4 RID: 932
		private SqlBytesCharsState _state;

		// Token: 0x040003A5 RID: 933
		private char[] _rgchWorkBuf;

		// Token: 0x040003A6 RID: 934
		private const long x_lMaxLen = 2147483647L;

		// Token: 0x040003A7 RID: 935
		private const long x_lNull = -1L;
	}
}
