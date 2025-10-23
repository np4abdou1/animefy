using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security
{
	/// <summary>Defines a permission set that has a name and description associated with it. This class cannot be inherited.</summary>
	// Token: 0x02000281 RID: 641
	[ComVisible(true)]
	[Serializable]
	public sealed class NamedPermissionSet : PermissionSet
	{
		// Token: 0x06001655 RID: 5717 RVA: 0x0005B557 File Offset: 0x00059757
		internal NamedPermissionSet()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.NamedPermissionSet" /> class with the specified name in either an unrestricted or a fully restricted state.</summary>
		/// <param name="name">The name for the new named permission set. </param>
		/// <param name="state">One of the <see cref="T:System.Security.Permissions.PermissionState" /> values. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is <see langword="null" /> or is an empty string (""). </exception>
		// Token: 0x06001656 RID: 5718 RVA: 0x0005B55F File Offset: 0x0005975F
		public NamedPermissionSet(string name, PermissionState state) : base(state)
		{
			this.Name = name;
		}

		/// <summary>Initializes a new, empty instance of the <see cref="T:System.Security.NamedPermissionSet" /> class with the specified name.</summary>
		/// <param name="name">The name for the new named permission set. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is <see langword="null" /> or is an empty string (""). </exception>
		// Token: 0x06001657 RID: 5719 RVA: 0x0005B56F File Offset: 0x0005976F
		public NamedPermissionSet(string name) : this(name, PermissionState.Unrestricted)
		{
		}

		/// <summary>Gets or sets the name of the current named permission set.</summary>
		/// <returns>The name of the named permission set.</returns>
		/// <exception cref="T:System.ArgumentException">The name is <see langword="null" /> or is an empty string (""). </exception>
		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x0005B579 File Offset: 0x00059779
		// (set) Token: 0x06001659 RID: 5721 RVA: 0x0005B581 File Offset: 0x00059781
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (value == null || value == string.Empty)
				{
					throw new ArgumentException(Locale.GetText("invalid name"));
				}
				this.name = value;
			}
		}

		/// <summary>Creates an XML element description of the named permission set.</summary>
		/// <returns>The XML representation of the named permission set.</returns>
		// Token: 0x0600165A RID: 5722 RVA: 0x0005B5AC File Offset: 0x000597AC
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = base.ToXml();
			if (this.name != null)
			{
				securityElement.AddAttribute("Name", this.name);
			}
			if (this.description != null)
			{
				securityElement.AddAttribute("Description", this.description);
			}
			return securityElement;
		}

		/// <summary>Determines whether the specified <see cref="T:System.Security.NamedPermissionSet" /> object is equal to the current <see cref="T:System.Security.NamedPermissionSet" />.</summary>
		/// <param name="obj">The <see cref="T:System.Security.NamedPermissionSet" /> object to compare with the current <see cref="T:System.Security.NamedPermissionSet" />. </param>
		/// <returns>
		///     <see langword="true" /> if the specified <see cref="T:System.Security.NamedPermissionSet" /> is equal to the current <see cref="T:System.Security.NamedPermissionSet" /> object; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600165B RID: 5723 RVA: 0x0005B5F4 File Offset: 0x000597F4
		[ComVisible(false)]
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			NamedPermissionSet namedPermissionSet = obj as NamedPermissionSet;
			return namedPermissionSet != null && this.name == namedPermissionSet.Name && base.Equals(obj);
		}

		/// <summary>Gets a hash code for the <see cref="T:System.Security.NamedPermissionSet" /> object that is suitable for use in hashing algorithms and data structures such as a hash table.</summary>
		/// <returns>A hash code for the current <see cref="T:System.Security.NamedPermissionSet" /> object.</returns>
		// Token: 0x0600165C RID: 5724 RVA: 0x0005B630 File Offset: 0x00059830
		[ComVisible(false)]
		public override int GetHashCode()
		{
			int num = base.GetHashCode();
			if (this.name != null)
			{
				num ^= this.name.GetHashCode();
			}
			return num;
		}

		// Token: 0x040008AE RID: 2222
		private string name;

		// Token: 0x040008AF RID: 2223
		private string description;
	}
}
