using System;
using System.Reflection;

namespace System.Xml.Serialization
{
	/// <summary>Provides mappings between .NET Framework Web service methods and Web Services Description Language (WSDL) messages that are defined for SOAP Web services. </summary>
	// Token: 0x020001EF RID: 495
	[DefaultMember("Item")]
	public class XmlMembersMapping : XmlMapping
	{
		/// <summary>Gets the number of .NET Framework code entities that belong to a Web service method to which a SOAP message is being mapped. </summary>
		/// <returns>The number of mappings in the collection.</returns>
		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x00065E3D File Offset: 0x0006403D
		public int Count
		{
			get
			{
				return this._mapping.Length;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x00065E47 File Offset: 0x00064047
		internal bool HasWrapperElement
		{
			get
			{
				return this._hasWrapperElement;
			}
		}

		// Token: 0x04000B7F RID: 2943
		private bool _hasWrapperElement;

		// Token: 0x04000B80 RID: 2944
		private XmlMemberMapping[] _mapping;
	}
}
