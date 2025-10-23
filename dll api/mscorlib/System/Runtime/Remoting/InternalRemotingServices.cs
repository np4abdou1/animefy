using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;

namespace System.Runtime.Remoting
{
	/// <summary>Defines utility methods for use by the .NET Framework remoting infrastructure.</summary>
	// Token: 0x02000308 RID: 776
	[ComVisible(true)]
	public class InternalRemotingServices
	{
		/// <summary>Gets an appropriate SOAP-related attribute for the specified class member or method parameter. </summary>
		/// <param name="reflectionObject">A class member or method parameter.</param>
		/// <returns>The SOAP-related attribute for the specified class member or method parameter.</returns>
		// Token: 0x06001972 RID: 6514 RVA: 0x0006EB58 File Offset: 0x0006CD58
		public static SoapAttribute GetCachedSoapAttribute(object reflectionObject)
		{
			object syncRoot = InternalRemotingServices._soapAttributes.SyncRoot;
			SoapAttribute result;
			lock (syncRoot)
			{
				SoapAttribute soapAttribute = InternalRemotingServices._soapAttributes[reflectionObject] as SoapAttribute;
				if (soapAttribute != null)
				{
					result = soapAttribute;
				}
				else
				{
					object[] customAttributes = ((ICustomAttributeProvider)reflectionObject).GetCustomAttributes(typeof(SoapAttribute), true);
					if (customAttributes.Length != 0)
					{
						soapAttribute = (SoapAttribute)customAttributes[0];
					}
					else if (reflectionObject is Type)
					{
						soapAttribute = new SoapTypeAttribute();
					}
					else if (reflectionObject is FieldInfo)
					{
						soapAttribute = new SoapFieldAttribute();
					}
					else if (reflectionObject is MethodBase)
					{
						soapAttribute = new SoapMethodAttribute();
					}
					else if (reflectionObject is ParameterInfo)
					{
						soapAttribute = new SoapParameterAttribute();
					}
					soapAttribute.SetReflectionObject(reflectionObject);
					InternalRemotingServices._soapAttributes[reflectionObject] = soapAttribute;
					result = soapAttribute;
				}
			}
			return result;
		}

		// Token: 0x04000A9C RID: 2716
		private static Hashtable _soapAttributes = new Hashtable();
	}
}
