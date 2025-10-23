using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata
{
	/// <summary>Customizes SOAP generation and processing for target types. This class cannot be inherited.</summary>
	// Token: 0x0200035A RID: 858
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
	[ComVisible(true)]
	public sealed class SoapTypeAttribute : SoapAttribute
	{
		/// <summary>Gets or sets a value indicating whether the target of the current attribute will be serialized as an XML attribute instead of an XML field.</summary>
		/// <returns>The current implementation always returns <see langword="false" />.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">An attempt was made to set the current property. </exception>
		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x000754CD File Offset: 0x000736CD
		public override bool UseAttribute
		{
			get
			{
				return this._useAttribute;
			}
		}

		/// <summary>Gets or sets the XML element name.</summary>
		/// <returns>The XML element name.</returns>
		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x000754D5 File Offset: 0x000736D5
		public string XmlElementName
		{
			get
			{
				return this._xmlElementName;
			}
		}

		/// <summary>Gets or sets the XML namespace that is used during serialization of the target object type.</summary>
		/// <returns>The XML namespace that is used during serialization of the target object type.</returns>
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001B21 RID: 6945 RVA: 0x000754DD File Offset: 0x000736DD
		public override string XmlNamespace
		{
			get
			{
				return this._xmlNamespace;
			}
		}

		/// <summary>Gets or sets the XML type name for the target object type.</summary>
		/// <returns>The XML type name for the target object type.</returns>
		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001B22 RID: 6946 RVA: 0x000754E5 File Offset: 0x000736E5
		public string XmlTypeName
		{
			get
			{
				return this._xmlTypeName;
			}
		}

		/// <summary>Gets or sets the XML type namespace for the current object type.</summary>
		/// <returns>The XML type namespace for the current object type.</returns>
		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x000754ED File Offset: 0x000736ED
		public string XmlTypeNamespace
		{
			get
			{
				return this._xmlTypeNamespace;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06001B24 RID: 6948 RVA: 0x000754F5 File Offset: 0x000736F5
		internal bool IsInteropXmlElement
		{
			get
			{
				return this._isElement;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06001B25 RID: 6949 RVA: 0x000754FD File Offset: 0x000736FD
		internal bool IsInteropXmlType
		{
			get
			{
				return this._isType;
			}
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x00075508 File Offset: 0x00073708
		internal override void SetReflectionObject(object reflectionObject)
		{
			Type type = (Type)reflectionObject;
			if (this._xmlElementName == null)
			{
				this._xmlElementName = type.Name;
			}
			if (this._xmlTypeName == null)
			{
				this._xmlTypeName = type.Name;
			}
			if (this._xmlTypeNamespace == null)
			{
				string assemblyName;
				if (type.Assembly == typeof(object).Assembly)
				{
					assemblyName = string.Empty;
				}
				else
				{
					assemblyName = type.Assembly.GetName().Name;
				}
				this._xmlTypeNamespace = SoapServices.CodeXmlNamespaceForClrTypeNamespace(type.Namespace, assemblyName);
			}
			if (this._xmlNamespace == null)
			{
				this._xmlNamespace = this._xmlTypeNamespace;
			}
		}

		// Token: 0x04000B58 RID: 2904
		private bool _useAttribute;

		// Token: 0x04000B59 RID: 2905
		private string _xmlElementName;

		// Token: 0x04000B5A RID: 2906
		private string _xmlNamespace;

		// Token: 0x04000B5B RID: 2907
		private string _xmlTypeName;

		// Token: 0x04000B5C RID: 2908
		private string _xmlTypeNamespace;

		// Token: 0x04000B5D RID: 2909
		private bool _isType;

		// Token: 0x04000B5E RID: 2910
		private bool _isElement;
	}
}
