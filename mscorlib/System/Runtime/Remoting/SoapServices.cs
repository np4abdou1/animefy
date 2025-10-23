using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;

namespace System.Runtime.Remoting
{
	/// <summary>Provides several methods for using and publishing remoted objects in SOAP format.</summary>
	// Token: 0x02000317 RID: 791
	[ComVisible(true)]
	public class SoapServices
	{
		/// <summary>Gets the default XML namespace prefix that should be used for XML encoding of a common language runtime class that has an assembly, but no native namespace.</summary>
		/// <returns>The default XML namespace prefix that should be used for XML encoding of a common language runtime class that has an assembly, but no native namespace.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001A07 RID: 6663 RVA: 0x00071BA0 File Offset: 0x0006FDA0
		public static string XmlNsForClrTypeWithAssembly
		{
			get
			{
				return "http://schemas.microsoft.com/clr/assem/";
			}
		}

		/// <summary>Gets the XML namespace prefix that should be used for XML encoding of a common language runtime class that is part of the mscorlib.dll file.</summary>
		/// <returns>The XML namespace prefix that should be used for XML encoding of a common language runtime class that is part of the mscorlib.dll file.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x00071BA7 File Offset: 0x0006FDA7
		public static string XmlNsForClrTypeWithNs
		{
			get
			{
				return "http://schemas.microsoft.com/clr/ns/";
			}
		}

		/// <summary>Gets the default XML namespace prefix that should be used for XML encoding of a common language runtime class that has both a common language runtime namespace and an assembly.</summary>
		/// <returns>The default XML namespace prefix that should be used for XML encoding of a common language runtime class that has both a common language runtime namespace and an assembly.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x00071BAE File Offset: 0x0006FDAE
		public static string XmlNsForClrTypeWithNsAndAssembly
		{
			get
			{
				return "http://schemas.microsoft.com/clr/nsassem/";
			}
		}

		/// <summary>Returns the common language runtime type namespace name from the provided namespace and assembly names.</summary>
		/// <param name="typeNamespace">The namespace that is to be coded. </param>
		/// <param name="assemblyName">The name of the assembly that is to be coded. </param>
		/// <returns>The common language runtime type namespace name from the provided namespace and assembly names.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="assemblyName" /> and <paramref name="typeNamespace" /> parameters are both either <see langword="null" /> or empty. </exception>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x06001A0A RID: 6666 RVA: 0x00071BB8 File Offset: 0x0006FDB8
		public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName)
		{
			if (assemblyName == string.Empty)
			{
				return SoapServices.XmlNsForClrTypeWithNs + typeNamespace;
			}
			if (typeNamespace == string.Empty)
			{
				return SoapServices.EncodeNs(SoapServices.XmlNsForClrTypeWithAssembly + assemblyName);
			}
			return SoapServices.EncodeNs(SoapServices.XmlNsForClrTypeWithNsAndAssembly + typeNamespace + "/" + assemblyName);
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00071C12 File Offset: 0x0006FE12
		private static string GetNameKey(string name, string namspace)
		{
			if (namspace == null)
			{
				return name;
			}
			return name + " " + namspace;
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00071C25 File Offset: 0x0006FE25
		private static string GetAssemblyName(MethodBase mb)
		{
			if (mb.DeclaringType.Assembly == typeof(object).Assembly)
			{
				return string.Empty;
			}
			return mb.DeclaringType.Assembly.GetName().Name;
		}

		/// <summary>Returns XML element information that should be used when serializing the given type.</summary>
		/// <param name="type">The object <see cref="T:System.Type" /> for which the XML element and namespace names were requested. </param>
		/// <param name="xmlElement">When this method returns, contains a <see cref="T:System.String" /> that holds the XML element name of the specified object type. This parameter is passed uninitialized. </param>
		/// <param name="xmlNamespace">When this method returns, contains a <see cref="T:System.String" /> that holds the XML namespace name of the specified object type. This parameter is passed uninitialized. </param>
		/// <returns>
		///     <see langword="true" /> if the requested values have been set flagged with <see cref="T:System.Runtime.Remoting.Metadata.SoapTypeAttribute" />; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x06001A0D RID: 6669 RVA: 0x00071C64 File Offset: 0x0006FE64
		public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace)
		{
			SoapTypeAttribute soapTypeAttribute = (SoapTypeAttribute)InternalRemotingServices.GetCachedSoapAttribute(type);
			if (!soapTypeAttribute.IsInteropXmlElement)
			{
				xmlElement = null;
				xmlNamespace = null;
				return false;
			}
			xmlElement = soapTypeAttribute.XmlElementName;
			xmlNamespace = soapTypeAttribute.XmlNamespace;
			return true;
		}

		/// <summary>Retrieves the XML namespace used during remote calls of the method specified in the given <see cref="T:System.Reflection.MethodBase" />.</summary>
		/// <param name="mb">The <see cref="T:System.Reflection.MethodBase" /> of the method for which the XML namespace was requested. </param>
		/// <returns>The XML namespace used during remote calls of the specified method.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x06001A0E RID: 6670 RVA: 0x00071C9E File Offset: 0x0006FE9E
		public static string GetXmlNamespaceForMethodCall(MethodBase mb)
		{
			return SoapServices.CodeXmlNamespaceForClrTypeNamespace(mb.DeclaringType.FullName, SoapServices.GetAssemblyName(mb));
		}

		/// <summary>Retrieves the XML namespace used during the generation of responses to the remote call to the method specified in the given <see cref="T:System.Reflection.MethodBase" />.</summary>
		/// <param name="mb">The <see cref="T:System.Reflection.MethodBase" /> of the method for which the XML namespace was requested. </param>
		/// <returns>The XML namespace used during the generation of responses to a remote method call.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x06001A0F RID: 6671 RVA: 0x00071C9E File Offset: 0x0006FE9E
		public static string GetXmlNamespaceForMethodResponse(MethodBase mb)
		{
			return SoapServices.CodeXmlNamespaceForClrTypeNamespace(mb.DeclaringType.FullName, SoapServices.GetAssemblyName(mb));
		}

		/// <summary>Returns XML type information that should be used when serializing the given <see cref="T:System.Type" />.</summary>
		/// <param name="type">The object <see cref="T:System.Type" /> for which the XML element and namespace names were requested. </param>
		/// <param name="xmlType">The XML type of the specified object <see cref="T:System.Type" />. </param>
		/// <param name="xmlTypeNamespace">The XML type namespace of the specified object <see cref="T:System.Type" />. </param>
		/// <returns>
		///     <see langword="true" /> if the requested values have been set flagged with <see cref="T:System.Runtime.Remoting.Metadata.SoapTypeAttribute" />; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x06001A10 RID: 6672 RVA: 0x00071CB8 File Offset: 0x0006FEB8
		public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace)
		{
			SoapTypeAttribute soapTypeAttribute = (SoapTypeAttribute)InternalRemotingServices.GetCachedSoapAttribute(type);
			if (!soapTypeAttribute.IsInteropXmlType)
			{
				xmlType = null;
				xmlTypeNamespace = null;
				return false;
			}
			xmlType = soapTypeAttribute.XmlTypeName;
			xmlTypeNamespace = soapTypeAttribute.XmlTypeNamespace;
			return true;
		}

		/// <summary>Preloads every <see cref="T:System.Type" /> found in the specified <see cref="T:System.Reflection.Assembly" /> from the information found in the <see cref="T:System.Runtime.Remoting.Metadata.SoapTypeAttribute" /> associated with each type.</summary>
		/// <param name="assembly">The <see cref="T:System.Reflection.Assembly" /> for each type of which to call <see cref="M:System.Runtime.Remoting.SoapServices.PreLoad(System.Type)" />. </param>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x06001A11 RID: 6673 RVA: 0x00071CF4 File Offset: 0x0006FEF4
		public static void PreLoad(Assembly assembly)
		{
			Type[] types = assembly.GetTypes();
			for (int i = 0; i < types.Length; i++)
			{
				SoapServices.PreLoad(types[i]);
			}
		}

		/// <summary>Preloads the given <see cref="T:System.Type" /> based on values set in a <see cref="T:System.Runtime.Remoting.Metadata.SoapTypeAttribute" /> on the type.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> to preload. </param>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x06001A12 RID: 6674 RVA: 0x00071D20 File Offset: 0x0006FF20
		public static void PreLoad(Type type)
		{
			SoapServices.TypeInfo typeInfo = SoapServices._typeInfos[type] as SoapServices.TypeInfo;
			if (typeInfo != null)
			{
				return;
			}
			string text;
			string text2;
			if (SoapServices.GetXmlTypeForInteropType(type, out text, out text2))
			{
				SoapServices.RegisterInteropXmlType(text, text2, type);
			}
			if (SoapServices.GetXmlElementForInteropType(type, out text, out text2))
			{
				SoapServices.RegisterInteropXmlElement(text, text2, type);
			}
			object syncRoot = SoapServices._typeInfos.SyncRoot;
			lock (syncRoot)
			{
				typeInfo = new SoapServices.TypeInfo();
				foreach (FieldInfo fieldInfo in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
				{
					SoapFieldAttribute soapFieldAttribute = (SoapFieldAttribute)InternalRemotingServices.GetCachedSoapAttribute(fieldInfo);
					if (soapFieldAttribute.IsInteropXmlElement())
					{
						string nameKey = SoapServices.GetNameKey(soapFieldAttribute.XmlElementName, soapFieldAttribute.XmlNamespace);
						if (soapFieldAttribute.UseAttribute)
						{
							if (typeInfo.Attributes == null)
							{
								typeInfo.Attributes = new Hashtable();
							}
							typeInfo.Attributes[nameKey] = fieldInfo;
						}
						else
						{
							if (typeInfo.Elements == null)
							{
								typeInfo.Elements = new Hashtable();
							}
							typeInfo.Elements[nameKey] = fieldInfo;
						}
					}
				}
				SoapServices._typeInfos[type] = typeInfo;
			}
		}

		/// <summary>Associates the given XML element name and namespace with a run-time type that should be used for deserialization.</summary>
		/// <param name="xmlElement">The XML element name to use in deserialization. </param>
		/// <param name="xmlNamespace">The XML namespace to use in deserialization. </param>
		/// <param name="type">The run-time <see cref="T:System.Type" /> to use in deserialization. </param>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x06001A13 RID: 6675 RVA: 0x00071E54 File Offset: 0x00070054
		public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type)
		{
			object syncRoot = SoapServices._xmlElements.SyncRoot;
			lock (syncRoot)
			{
				SoapServices._xmlElements[xmlElement + " " + xmlNamespace] = type;
			}
		}

		/// <summary>Associates the given XML type name and namespace with the run-time type that should be used for deserialization.</summary>
		/// <param name="xmlType">The XML type to use in deserialization. </param>
		/// <param name="xmlTypeNamespace">The XML namespace to use in deserialization. </param>
		/// <param name="type">The run-time <see cref="T:System.Type" /> to use in deserialization. </param>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x06001A14 RID: 6676 RVA: 0x00071EAC File Offset: 0x000700AC
		public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type)
		{
			object syncRoot = SoapServices._xmlTypes.SyncRoot;
			lock (syncRoot)
			{
				SoapServices._xmlTypes[xmlType + " " + xmlTypeNamespace] = type;
			}
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00071F04 File Offset: 0x00070104
		private static string EncodeNs(string ns)
		{
			ns = ns.Replace(",", "%2C");
			ns = ns.Replace(" ", "%20");
			return ns.Replace("=", "%3D");
		}

		// Token: 0x04000AD8 RID: 2776
		private static Hashtable _xmlTypes = new Hashtable();

		// Token: 0x04000AD9 RID: 2777
		private static Hashtable _xmlElements = new Hashtable();

		// Token: 0x04000ADA RID: 2778
		private static Hashtable _soapActions = new Hashtable();

		// Token: 0x04000ADB RID: 2779
		private static Hashtable _soapActionsMethods = new Hashtable();

		// Token: 0x04000ADC RID: 2780
		private static Hashtable _typeInfos = new Hashtable();

		// Token: 0x02000318 RID: 792
		private class TypeInfo
		{
			// Token: 0x04000ADD RID: 2781
			public Hashtable Attributes;

			// Token: 0x04000ADE RID: 2782
			public Hashtable Elements;
		}
	}
}
