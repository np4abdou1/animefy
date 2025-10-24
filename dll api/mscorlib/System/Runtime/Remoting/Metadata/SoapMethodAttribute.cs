using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata
{
	/// <summary>Customizes SOAP generation and processing for a method. This class cannot be inherited.</summary>
	// Token: 0x02000358 RID: 856
	[AttributeUsage(AttributeTargets.Method)]
	[ComVisible(true)]
	public sealed class SoapMethodAttribute : SoapAttribute
	{
		/// <summary>Gets or sets a value indicating whether the target of the current attribute will be serialized as an XML attribute instead of an XML field.</summary>
		/// <returns>The current implementation always returns <see langword="false" />.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">An attempt was made to set the current property. </exception>
		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06001B1A RID: 6938 RVA: 0x0007542C File Offset: 0x0007362C
		public override bool UseAttribute
		{
			get
			{
				return this._useAttribute;
			}
		}

		/// <summary>Gets or sets the XML namespace that is used during serialization of remote method calls of the target method.</summary>
		/// <returns>The XML namespace that is used during serialization of remote method calls of the target method.</returns>
		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x00075434 File Offset: 0x00073634
		public override string XmlNamespace
		{
			get
			{
				return this._namespace;
			}
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0007543C File Offset: 0x0007363C
		internal override void SetReflectionObject(object reflectionObject)
		{
			MethodBase methodBase = (MethodBase)reflectionObject;
			if (this._responseElement == null)
			{
				this._responseElement = methodBase.Name + "Response";
			}
			if (this._responseNamespace == null)
			{
				this._responseNamespace = SoapServices.GetXmlNamespaceForMethodResponse(methodBase);
			}
			if (this._returnElement == null)
			{
				this._returnElement = "return";
			}
			if (this._soapAction == null)
			{
				this._soapAction = SoapServices.GetXmlNamespaceForMethodCall(methodBase) + "#" + methodBase.Name;
			}
			if (this._namespace == null)
			{
				this._namespace = SoapServices.GetXmlNamespaceForMethodCall(methodBase);
			}
		}

		// Token: 0x04000B52 RID: 2898
		private string _responseElement;

		// Token: 0x04000B53 RID: 2899
		private string _responseNamespace;

		// Token: 0x04000B54 RID: 2900
		private string _returnElement;

		// Token: 0x04000B55 RID: 2901
		private string _soapAction;

		// Token: 0x04000B56 RID: 2902
		private bool _useAttribute;

		// Token: 0x04000B57 RID: 2903
		private string _namespace;
	}
}
