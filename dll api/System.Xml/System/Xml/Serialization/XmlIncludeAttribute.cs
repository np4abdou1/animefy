using System;

namespace System.Xml.Serialization
{
	/// <summary>Allows the <see cref="T:System.Xml.Serialization.XmlSerializer" /> to recognize a type when it serializes or deserializes an object.</summary>
	// Token: 0x020001EA RID: 490
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface, AllowMultiple = true)]
	public class XmlIncludeAttribute : Attribute
	{
		/// <summary>Gets or sets the type of the object to include.</summary>
		/// <returns>The <see cref="T:System.Type" /> of the object to include.</returns>
		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x00065DCB File Offset: 0x00063FCB
		public Type Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x04000B74 RID: 2932
		private Type type;
	}
}
