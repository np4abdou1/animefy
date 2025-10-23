using System;

namespace System.Xml.Serialization
{
	/// <summary>Provides mappings between code entities in .NET Framework Web service methods and the content of Web Services Description Language (WSDL) messages that are defined for SOAP Web services. </summary>
	// Token: 0x020001F3 RID: 499
	public class XmlReflectionMember
	{
		// Token: 0x06001054 RID: 4180 RVA: 0x00067FA4 File Offset: 0x000661A4
		internal XmlReflectionMember(string name, Type type, XmlAttributes attributes)
		{
			this.memberName = name;
			this.memberType = type;
			this.xmlAttributes = attributes;
		}

		/// <summary>Gets or sets a value that indicates whether the <see cref="T:System.Xml.Serialization.XmlReflectionMember" /> represents a Web service method return value, as opposed to an output parameter. </summary>
		/// <returns>
		///     <see langword="true" />, if the member represents a Web service return value; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x00067FC1 File Offset: 0x000661C1
		public bool IsReturnValue
		{
			get
			{
				return this.isReturnValue;
			}
		}

		/// <summary>Gets or sets the name of the Web service method member for this mapping. </summary>
		/// <returns>The name of the Web service method.</returns>
		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x00067FC9 File Offset: 0x000661C9
		public string MemberName
		{
			get
			{
				return this.memberName;
			}
		}

		/// <summary>Gets or sets the type of the Web service method member code entity that is represented by this mapping. </summary>
		/// <returns>The <see cref="T:System.Type" /> of the Web service method member code entity that is represented by this mapping.</returns>
		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x00067FD1 File Offset: 0x000661D1
		public Type MemberType
		{
			get
			{
				return this.memberType;
			}
		}

		/// <summary>Gets or sets an <see cref="T:System.Xml.Serialization.XmlAttributes" /> with the collection of <see cref="T:System.Xml.Serialization.XmlSerializer" />-related attributes that have been applied to the member code entity. </summary>
		/// <returns>An <see cref="T:System.Xml.Serialization.XmlAttributes" /> that represents XML attributes that have been applied to the member code.</returns>
		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x00067FD9 File Offset: 0x000661D9
		public XmlAttributes XmlAttributes
		{
			get
			{
				if (this.xmlAttributes == null)
				{
					this.xmlAttributes = new XmlAttributes();
				}
				return this.xmlAttributes;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x00067FF4 File Offset: 0x000661F4
		// (set) Token: 0x0600105A RID: 4186 RVA: 0x00067FFC File Offset: 0x000661FC
		internal Type DeclaringType
		{
			get
			{
				return this.declaringType;
			}
			set
			{
				this.declaringType = value;
			}
		}

		// Token: 0x04000B8C RID: 2956
		private bool isReturnValue;

		// Token: 0x04000B8D RID: 2957
		private string memberName;

		// Token: 0x04000B8E RID: 2958
		private Type memberType;

		// Token: 0x04000B8F RID: 2959
		private XmlAttributes xmlAttributes;

		// Token: 0x04000B90 RID: 2960
		private Type declaringType;
	}
}
