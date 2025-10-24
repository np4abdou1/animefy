using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata
{
	/// <summary>Customizes SOAP generation and processing for a field. This class cannot be inherited.</summary>
	// Token: 0x02000357 RID: 855
	[AttributeUsage(AttributeTargets.Field)]
	[ComVisible(true)]
	public sealed class SoapFieldAttribute : SoapAttribute
	{
		/// <summary>Gets or sets the XML element name of the field contained in the <see cref="T:System.Runtime.Remoting.Metadata.SoapFieldAttribute" /> attribute.</summary>
		/// <returns>The XML element name of the field contained in this attribute.</returns>
		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x000753F1 File Offset: 0x000735F1
		public string XmlElementName
		{
			get
			{
				return this._elementName;
			}
		}

		/// <summary>Returns a value indicating whether the current attribute contains interop XML element values.</summary>
		/// <returns>
		///     <see langword="true" /> if the current attribute contains interop XML element values; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001B17 RID: 6935 RVA: 0x000753F9 File Offset: 0x000735F9
		public bool IsInteropXmlElement()
		{
			return this._isElement;
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00075404 File Offset: 0x00073604
		internal override void SetReflectionObject(object reflectionObject)
		{
			FieldInfo fieldInfo = (FieldInfo)reflectionObject;
			if (this._elementName == null)
			{
				this._elementName = fieldInfo.Name;
			}
		}

		// Token: 0x04000B50 RID: 2896
		private string _elementName;

		// Token: 0x04000B51 RID: 2897
		private bool _isElement;
	}
}
