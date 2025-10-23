using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata
{
	/// <summary>Provides default functionality for all SOAP attributes.</summary>
	// Token: 0x02000356 RID: 854
	[ComVisible(true)]
	public class SoapAttribute : Attribute
	{
		/// <summary>Gets or sets a value indicating whether the target of the current attribute will be serialized as an XML attribute instead of an XML field.</summary>
		/// <returns>
		///     <see langword="true" /> if the target object of the current attribute must be serialized as an XML attribute; <see langword="false" /> if the target object must be serialized as a subelement.</returns>
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x000753D0 File Offset: 0x000735D0
		public virtual bool UseAttribute
		{
			get
			{
				return this._useAttribute;
			}
		}

		/// <summary>Gets or sets the XML namespace name.</summary>
		/// <returns>The XML namespace name under which the target of the current attribute is serialized.</returns>
		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001B13 RID: 6931 RVA: 0x000753D8 File Offset: 0x000735D8
		public virtual string XmlNamespace
		{
			get
			{
				return this.ProtXmlNamespace;
			}
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x000753E0 File Offset: 0x000735E0
		internal virtual void SetReflectionObject(object reflectionObject)
		{
			this.ReflectInfo = reflectionObject;
		}

		// Token: 0x04000B4D RID: 2893
		private bool _useAttribute;

		/// <summary>The XML namespace to which the target of the current SOAP attribute is serialized.</summary>
		// Token: 0x04000B4E RID: 2894
		protected string ProtXmlNamespace;

		/// <summary>A reflection object used by attribute classes derived from the <see cref="T:System.Runtime.Remoting.Metadata.SoapAttribute" /> class to set XML serialization information.</summary>
		// Token: 0x04000B4F RID: 2895
		protected object ReflectInfo;
	}
}
