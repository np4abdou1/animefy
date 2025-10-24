using System;
using System.Data.Common;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>Represents XML data stored in or retrieved from a server.</summary>
	// Token: 0x020000C7 RID: 199
	[XmlSchemaProvider("GetXsdType")]
	[Serializable]
	public sealed class SqlXml : INullable, IXmlSerializable
	{
		/// <summary>Creates a new <see cref="T:System.Data.SqlTypes.SqlXml" /> instance.</summary>
		// Token: 0x06000DD4 RID: 3540 RVA: 0x000464C9 File Offset: 0x000446C9
		public SqlXml()
		{
			this.SetNull();
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x000464C9 File Offset: 0x000446C9
		private SqlXml(bool fNull)
		{
			this.SetNull();
		}

		/// <summary>Creates a new <see cref="T:System.Data.SqlTypes.SqlXml" /> instance and associates it with the content of the supplied <see cref="T:System.Xml.XmlReader" />.</summary>
		/// <param name="value">An <see cref="T:System.Xml.XmlReader" />-derived class instance to be used as the value of the new <see cref="T:System.Data.SqlTypes.SqlXml" /> instance.</param>
		// Token: 0x06000DD6 RID: 3542 RVA: 0x000464D7 File Offset: 0x000446D7
		public SqlXml(XmlReader value)
		{
			if (value == null)
			{
				this.SetNull();
				return;
			}
			this._fNotNull = true;
			this._firstCreateReader = true;
			this._stream = this.CreateMemoryStreamFromXmlReader(value);
		}

		/// <summary>Creates a new <see cref="T:System.Data.SqlTypes.SqlXml" /> instance, supplying the XML value from the supplied <see cref="T:System.IO.Stream" />-derived instance.</summary>
		/// <param name="value">A <see cref="T:System.IO.Stream" />-derived instance (such as <see cref="T:System.IO.FileStream" />) from which to load the <see cref="T:System.Data.SqlTypes.SqlXml" /> instance's Xml content.</param>
		// Token: 0x06000DD7 RID: 3543 RVA: 0x00046504 File Offset: 0x00044704
		public SqlXml(Stream value)
		{
			if (value == null)
			{
				this.SetNull();
				return;
			}
			this._firstCreateReader = true;
			this._fNotNull = true;
			this._stream = value;
		}

		/// <summary>Gets the value of the XML content of this <see cref="T:System.Data.SqlTypes.SqlXml" /> as a <see cref="T:System.Xml.XmlReader" />.</summary>
		/// <returns>A <see cref="T:System.Xml.XmlReader" />-derived instance that contains the XML content. The actual type may vary (for example, the return value might be <see cref="T:System.Xml.XmlTextReader" />) depending on how the information is represented internally, on the server.</returns>
		/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">Attempt was made to access this property on a null instance of <see cref="T:System.Data.SqlTypes.SqlXml" />.</exception>
		// Token: 0x06000DD8 RID: 3544 RVA: 0x0004652C File Offset: 0x0004472C
		public XmlReader CreateReader()
		{
			if (this.IsNull)
			{
				throw new SqlNullValueException();
			}
			SqlXmlStreamWrapper sqlXmlStreamWrapper = new SqlXmlStreamWrapper(this._stream);
			if ((!this._firstCreateReader || sqlXmlStreamWrapper.CanSeek) && sqlXmlStreamWrapper.Position != 0L)
			{
				sqlXmlStreamWrapper.Seek(0L, SeekOrigin.Begin);
			}
			if (this._createSqlReaderMethodInfo == null)
			{
				this._createSqlReaderMethodInfo = SqlXml.CreateSqlReaderMethodInfo;
			}
			XmlReader result = SqlXml.CreateSqlXmlReader(sqlXmlStreamWrapper, false, false);
			this._firstCreateReader = false;
			return result;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x000465A0 File Offset: 0x000447A0
		internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = false, bool throwTargetInvocationExceptions = false)
		{
			XmlReaderSettings arg = closeInput ? SqlXml.s_defaultXmlReaderSettingsCloseInput : SqlXml.s_defaultXmlReaderSettings;
			XmlReader result;
			try
			{
				result = SqlXml.s_sqlReaderDelegate(stream, arg, null);
			}
			catch (Exception ex)
			{
				if (!throwTargetInvocationExceptions || !ADP.IsCatchableExceptionType(ex))
				{
					throw;
				}
				throw new TargetInvocationException(ex);
			}
			return result;
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x000465F4 File Offset: 0x000447F4
		private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate()
		{
			return (Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader>)SqlXml.CreateSqlReaderMethodInfo.CreateDelegate(typeof(Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader>));
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x0004660F File Offset: 0x0004480F
		private static MethodInfo CreateSqlReaderMethodInfo
		{
			get
			{
				if (SqlXml.s_createSqlReaderMethodInfo == null)
				{
					SqlXml.s_createSqlReaderMethodInfo = typeof(XmlReader).GetMethod("CreateSqlReader", BindingFlags.Static | BindingFlags.NonPublic);
				}
				return SqlXml.s_createSqlReaderMethodInfo;
			}
		}

		/// <summary>Indicates whether this instance represents a null <see cref="T:System.Data.SqlTypes.SqlXml" /> value.</summary>
		/// <returns>
		///     <see langword="true" /> if <see langword="Value" /> is null. Otherwise, <see langword="false" />.</returns>
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x0004663E File Offset: 0x0004483E
		public bool IsNull
		{
			get
			{
				return !this._fNotNull;
			}
		}

		/// <summary>Gets the string representation of the XML content of this <see cref="T:System.Data.SqlTypes.SqlXml" /> instance.</summary>
		/// <returns>The string representation of the XML content.</returns>
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x0004664C File Offset: 0x0004484C
		public string Value
		{
			get
			{
				if (this.IsNull)
				{
					throw new SqlNullValueException();
				}
				StringWriter stringWriter = new StringWriter(null);
				XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings
				{
					CloseOutput = false,
					ConformanceLevel = ConformanceLevel.Fragment
				});
				XmlReader xmlReader = this.CreateReader();
				if (xmlReader.ReadState == ReadState.Initial)
				{
					xmlReader.Read();
				}
				while (!xmlReader.EOF)
				{
					xmlWriter.WriteNode(xmlReader, true);
				}
				xmlWriter.Flush();
				return stringWriter.ToString();
			}
		}

		/// <summary>Represents a null instance of the <see cref="T:System.Data.SqlTypes.SqlXml" /> type.</summary>
		/// <returns>A null instance of the <see cref="T:System.Data.SqlTypes.SqlXml" /> type.</returns>
		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x000466BE File Offset: 0x000448BE
		public static SqlXml Null
		{
			get
			{
				return new SqlXml(true);
			}
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x000466C6 File Offset: 0x000448C6
		private void SetNull()
		{
			this._fNotNull = false;
			this._stream = null;
			this._firstCreateReader = true;
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x000466E0 File Offset: 0x000448E0
		private Stream CreateMemoryStreamFromXmlReader(XmlReader reader)
		{
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			xmlWriterSettings.CloseOutput = false;
			xmlWriterSettings.ConformanceLevel = ConformanceLevel.Fragment;
			xmlWriterSettings.Encoding = Encoding.GetEncoding("utf-16");
			xmlWriterSettings.OmitXmlDeclaration = true;
			MemoryStream memoryStream = new MemoryStream();
			XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
			if (reader.ReadState == ReadState.Closed)
			{
				throw new InvalidOperationException(SQLResource.ClosedXmlReaderMessage);
			}
			if (reader.ReadState == ReadState.Initial)
			{
				reader.Read();
			}
			while (!reader.EOF)
			{
				xmlWriter.WriteNode(reader, true);
			}
			xmlWriter.Flush();
			memoryStream.Seek(0L, SeekOrigin.Begin);
			return memoryStream;
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.GetSchema" />.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchema" /> that describes the XML representation of the object that is produced by the <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" /> method and consumed by the <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" /> method.</returns>
		// Token: 0x06000DE1 RID: 3553 RVA: 0x000020F7 File Offset: 0x000002F7
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" />.</summary>
		/// <param name="r">An XmlReader.</param>
		// Token: 0x06000DE2 RID: 3554 RVA: 0x0004676C File Offset: 0x0004496C
		void IXmlSerializable.ReadXml(XmlReader r)
		{
			string attribute = r.GetAttribute("nil", "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute != null && XmlConvert.ToBoolean(attribute))
			{
				r.ReadInnerXml();
				this.SetNull();
				return;
			}
			this._fNotNull = true;
			this._firstCreateReader = true;
			this._stream = new MemoryStream();
			StreamWriter streamWriter = new StreamWriter(this._stream);
			streamWriter.Write(r.ReadInnerXml());
			streamWriter.Flush();
			if (this._stream.CanSeek)
			{
				this._stream.Seek(0L, SeekOrigin.Begin);
			}
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" />.</summary>
		/// <param name="writer">An XmlWriter</param>
		// Token: 0x06000DE3 RID: 3555 RVA: 0x000467F4 File Offset: 0x000449F4
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			if (this.IsNull)
			{
				writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
			}
			else
			{
				XmlReader xmlReader = this.CreateReader();
				if (xmlReader.ReadState == ReadState.Initial)
				{
					xmlReader.Read();
				}
				while (!xmlReader.EOF)
				{
					writer.WriteNode(xmlReader, true);
				}
			}
			writer.Flush();
		}

		/// <summary>Returns the XML Schema definition language (XSD) of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
		/// <param name="schemaSet">An <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
		/// <returns>A string that indicates the XSD of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />. </returns>
		// Token: 0x06000DE4 RID: 3556 RVA: 0x00046853 File Offset: 0x00044A53
		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return new XmlQualifiedName("anyType", "http://www.w3.org/2001/XMLSchema");
		}

		// Token: 0x0400045F RID: 1119
		private static readonly Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate = SqlXml.CreateSqlReaderDelegate();

		// Token: 0x04000460 RID: 1120
		private static readonly XmlReaderSettings s_defaultXmlReaderSettings = new XmlReaderSettings
		{
			ConformanceLevel = ConformanceLevel.Fragment
		};

		// Token: 0x04000461 RID: 1121
		private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput = new XmlReaderSettings
		{
			ConformanceLevel = ConformanceLevel.Fragment,
			CloseInput = true
		};

		// Token: 0x04000462 RID: 1122
		private static MethodInfo s_createSqlReaderMethodInfo;

		// Token: 0x04000463 RID: 1123
		private MethodInfo _createSqlReaderMethodInfo;

		// Token: 0x04000464 RID: 1124
		private bool _fNotNull;

		// Token: 0x04000465 RID: 1125
		private Stream _stream;

		// Token: 0x04000466 RID: 1126
		private bool _firstCreateReader;
	}
}
