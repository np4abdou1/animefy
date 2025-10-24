using System;

namespace System.Xml.Serialization
{
	/// <summary>When applied to a type, stores the name of a static method of the type that returns an XML schema and a <see cref="T:System.Xml.XmlQualifiedName" /> (or <see cref="T:System.Xml.Schema.XmlSchemaType" /> for anonymous types) that controls the serialization of the type.</summary>
	// Token: 0x020001F5 RID: 501
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	public sealed class XmlSchemaProviderAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSchemaProviderAttribute" /> class, taking the name of the static method that supplies the type's XML schema.</summary>
		/// <param name="methodName">The name of the static method that must be implemented.</param>
		// Token: 0x06001066 RID: 4198 RVA: 0x000680E2 File Offset: 0x000662E2
		public XmlSchemaProviderAttribute(string methodName)
		{
			this._methodName = methodName;
		}

		/// <summary>Gets the name of the static method that supplies the type's XML schema and the name of its XML Schema data type.</summary>
		/// <returns>The name of the method that is invoked by the XML infrastructure to return an XML schema.</returns>
		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x000680F1 File Offset: 0x000662F1
		public string MethodName
		{
			get
			{
				return this._methodName;
			}
		}

		/// <summary>Gets or sets a value that determines whether the target class is a wildcard, or that the schema for the class has contains only an <see langword="xs:any" /> element.</summary>
		/// <returns>
		///     <see langword="true" />, if the class is a wildcard, or if the schema contains only the <see langword="xs:any" /> element; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x000680F9 File Offset: 0x000662F9
		// (set) Token: 0x06001069 RID: 4201 RVA: 0x00068101 File Offset: 0x00066301
		public bool IsAny
		{
			get
			{
				return this._isAny;
			}
			set
			{
				this._isAny = value;
			}
		}

		// Token: 0x04000B95 RID: 2965
		private string _methodName;

		// Token: 0x04000B96 RID: 2966
		private bool _isAny;
	}
}
