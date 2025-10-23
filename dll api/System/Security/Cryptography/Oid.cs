using System;
using Internal.Cryptography;

namespace System.Security.Cryptography
{
	/// <summary>Represents a cryptographic object identifier. This class cannot be inherited.</summary>
	// Token: 0x020000DB RID: 219
	public sealed class Oid
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Oid" /> class.</summary>
		// Token: 0x06000649 RID: 1609 RVA: 0x0000222D File Offset: 0x0000042D
		public Oid()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Oid" /> class using a string value of an <see cref="T:System.Security.Cryptography.Oid" /> object.</summary>
		/// <param name="oid">An object identifier.</param>
		// Token: 0x0600064A RID: 1610 RVA: 0x00025D84 File Offset: 0x00023F84
		public Oid(string oid)
		{
			string text = OidLookup.ToOid(oid, OidGroup.All, false);
			if (text == null)
			{
				text = oid;
			}
			this.Value = text;
			this._group = OidGroup.All;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Oid" /> class using the specified value and friendly name.</summary>
		/// <param name="value">The dotted number of the identifier.</param>
		/// <param name="friendlyName">The friendly name of the identifier.</param>
		// Token: 0x0600064B RID: 1611 RVA: 0x00025DB3 File Offset: 0x00023FB3
		public Oid(string value, string friendlyName)
		{
			this._value = value;
			this._friendlyName = friendlyName;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Oid" /> class using the specified <see cref="T:System.Security.Cryptography.Oid" /> object.</summary>
		/// <param name="oid">The object identifier information to use to create the new object identifier.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="oid " />is <see langword="null" />.</exception>
		// Token: 0x0600064C RID: 1612 RVA: 0x00025DC9 File Offset: 0x00023FC9
		public Oid(Oid oid)
		{
			if (oid == null)
			{
				throw new ArgumentNullException("oid");
			}
			this._value = oid._value;
			this._friendlyName = oid._friendlyName;
			this._group = oid._group;
		}

		/// <summary>Creates an <see cref="T:System.Security.Cryptography.Oid" /> object by using the specified OID value and group.</summary>
		/// <param name="oidValue">The OID value.</param>
		/// <param name="group">The group to search in.</param>
		/// <returns>A new instance of an <see cref="T:System.Security.Cryptography.Oid" /> object.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="oidValue" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The friendly name for the OID value was not found.</exception>
		// Token: 0x0600064D RID: 1613 RVA: 0x00025E04 File Offset: 0x00024004
		public static Oid FromOidValue(string oidValue, OidGroup group)
		{
			if (oidValue == null)
			{
				throw new ArgumentNullException("oidValue");
			}
			string text = OidLookup.ToFriendlyName(oidValue, group, false);
			if (text == null)
			{
				throw new CryptographicException("The OID value is invalid.");
			}
			return new Oid(oidValue, text, group);
		}

		/// <summary>Gets or sets the dotted number of the identifier.</summary>
		/// <returns>The dotted number of the identifier.</returns>
		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00025E3E File Offset: 0x0002403E
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x00025E46 File Offset: 0x00024046
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		/// <summary>Gets or sets the friendly name of the identifier.</summary>
		/// <returns>The friendly name of the identifier.</returns>
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00025E4F File Offset: 0x0002404F
		public string FriendlyName
		{
			get
			{
				if (this._friendlyName == null && this._value != null)
				{
					this._friendlyName = OidLookup.ToFriendlyName(this._value, this._group, true);
				}
				return this._friendlyName;
			}
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00025E7F File Offset: 0x0002407F
		private Oid(string value, string friendlyName, OidGroup group)
		{
			this._value = value;
			this._friendlyName = friendlyName;
			this._group = group;
		}

		// Token: 0x04000434 RID: 1076
		private string _value;

		// Token: 0x04000435 RID: 1077
		private string _friendlyName;

		// Token: 0x04000436 RID: 1078
		private OidGroup _group;
	}
}
