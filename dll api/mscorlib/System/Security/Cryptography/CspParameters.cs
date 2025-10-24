using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Contains parameters that are passed to the cryptographic service provider (CSP) that performs cryptographic computations. This class cannot be inherited.</summary>
	// Token: 0x020002AD RID: 685
	[ComVisible(true)]
	public sealed class CspParameters
	{
		/// <summary>Represents the flags for <see cref="T:System.Security.Cryptography.CspParameters" /> that modify the behavior of the cryptographic service provider (CSP).</summary>
		/// <returns>An enumeration value, or a bitwise combination of enumeration values.</returns>
		/// <exception cref="T:System.ArgumentException">Value is not a valid enumeration value.</exception>
		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x0005F87A File Offset: 0x0005DA7A
		// (set) Token: 0x06001729 RID: 5929 RVA: 0x0005F884 File Offset: 0x0005DA84
		public CspProviderFlags Flags
		{
			get
			{
				return (CspProviderFlags)this.m_flags;
			}
			set
			{
				int num = 255;
				if ((value & (CspProviderFlags)(~(CspProviderFlags)num)) != CspProviderFlags.NoFlags)
				{
					throw new ArgumentException(Environment.GetResourceString("Illegal enum value: {0}.", new object[]
					{
						(int)value
					}), "value");
				}
				this.m_flags = (int)value;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CspParameters" /> class.</summary>
		// Token: 0x0600172A RID: 5930 RVA: 0x0005F8CA File Offset: 0x0005DACA
		public CspParameters() : this(1, null, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CspParameters" /> class with the specified provider type code.</summary>
		/// <param name="dwTypeIn">A provider type code that specifies the kind of provider to create. </param>
		// Token: 0x0600172B RID: 5931 RVA: 0x0005F8D5 File Offset: 0x0005DAD5
		public CspParameters(int dwTypeIn) : this(dwTypeIn, null, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CspParameters" /> class with the specified provider type code and name, and the specified container name.</summary>
		/// <param name="dwTypeIn">The provider type code that specifies the kind of provider to create.</param>
		/// <param name="strProviderNameIn">A provider name. </param>
		/// <param name="strContainerNameIn">A container name. </param>
		// Token: 0x0600172C RID: 5932 RVA: 0x0005F8E0 File Offset: 0x0005DAE0
		public CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) : this(dwTypeIn, strProviderNameIn, strContainerNameIn, CspProviderFlags.NoFlags)
		{
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x0005F8EC File Offset: 0x0005DAEC
		internal CspParameters(int providerType, string providerName, string keyContainerName, CspProviderFlags flags)
		{
			this.ProviderType = providerType;
			this.ProviderName = providerName;
			this.KeyContainerName = keyContainerName;
			this.KeyNumber = -1;
			this.Flags = flags;
		}

		/// <summary>Represents the provider type code for <see cref="T:System.Security.Cryptography.CspParameters" />.</summary>
		// Token: 0x04000980 RID: 2432
		public int ProviderType;

		/// <summary>Represents the provider name for <see cref="T:System.Security.Cryptography.CspParameters" />.</summary>
		// Token: 0x04000981 RID: 2433
		public string ProviderName;

		/// <summary>Represents the key container name for <see cref="T:System.Security.Cryptography.CspParameters" />.</summary>
		// Token: 0x04000982 RID: 2434
		public string KeyContainerName;

		/// <summary>Specifies whether an asymmetric key is created as a signature key or an exchange key.</summary>
		// Token: 0x04000983 RID: 2435
		public int KeyNumber;

		// Token: 0x04000984 RID: 2436
		private int m_flags;
	}
}
