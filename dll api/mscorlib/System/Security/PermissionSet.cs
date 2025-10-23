using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Security
{
	/// <summary>Represents a collection that can contain many different types of permissions.</summary>
	// Token: 0x02000282 RID: 642
	[ComVisible(true)]
	[Serializable]
	public class PermissionSet : ISecurityEncodable, ICollection, IEnumerable, IDeserializationCallback
	{
		// Token: 0x0600165D RID: 5725 RVA: 0x0005B65B File Offset: 0x0005985B
		internal PermissionSet()
		{
			this.list = new ArrayList();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.PermissionSet" /> class with the specified <see cref="T:System.Security.Permissions.PermissionState" />.</summary>
		/// <param name="state">One of the enumeration values that specifies the permission set's access to resources. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="state" /> parameter is not a valid <see cref="T:System.Security.Permissions.PermissionState" />. </exception>
		// Token: 0x0600165E RID: 5726 RVA: 0x0005B66E File Offset: 0x0005986E
		public PermissionSet(PermissionState state) : this()
		{
			this.state = CodeAccessPermission.CheckPermissionState(state, true);
		}

		/// <summary>Copies the permission objects of the set to the indicated location in an <see cref="T:System.Array" />.</summary>
		/// <param name="array">The target array to which to copy. </param>
		/// <param name="index">The starting position in the array to begin copying (zero based). </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="array" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="array" /> parameter has more than one dimension. </exception>
		/// <exception cref="T:System.IndexOutOfRangeException">The <paramref name="index" /> parameter is out of the range of the <paramref name="array" /> parameter. </exception>
		// Token: 0x0600165F RID: 5727 RVA: 0x0005B684 File Offset: 0x00059884
		public virtual void CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (this.list.Count > 0)
			{
				if (array.Rank > 1)
				{
					throw new ArgumentException(Locale.GetText("Array has more than one dimension"));
				}
				if (index < 0 || index >= array.Length)
				{
					throw new IndexOutOfRangeException("index");
				}
				this.list.CopyTo(array, index);
			}
		}

		/// <summary>Forces a <see cref="T:System.Security.SecurityException" /> at run time if all callers higher in the call stack have not been granted the permissions specified by the current instance.</summary>
		/// <exception cref="T:System.Security.SecurityException">A caller in the call chain does not have the permission demanded. </exception>
		// Token: 0x06001660 RID: 5728 RVA: 0x0005B6EC File Offset: 0x000598EC
		public void Demand()
		{
			if (this.IsEmpty())
			{
				return;
			}
			int count = this.list.Count;
			if (this._ignored == null || this._ignored.Length != count)
			{
				this._ignored = new bool[count];
			}
			bool flag = this.IsUnrestricted();
			for (int i = 0; i < count; i++)
			{
				IPermission permission = (IPermission)this.list[i];
				if (permission.GetType().IsSubclassOf(typeof(CodeAccessPermission)))
				{
					this._ignored[i] = false;
					flag = true;
				}
				else
				{
					this._ignored[i] = true;
					permission.Demand();
				}
			}
			if (flag && SecurityManager.SecurityEnabled)
			{
				this.CasOnlyDemand(this._declsec ? 5 : 3);
			}
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x0005B7A1 File Offset: 0x000599A1
		internal void CasOnlyDemand(int skip)
		{
			if (this._ignored == null)
			{
				this._ignored = new bool[this.list.Count];
			}
		}

		/// <summary>Returns an enumerator for the permissions of the set.</summary>
		/// <returns>An enumerator object for the permissions of the set.</returns>
		// Token: 0x06001662 RID: 5730 RVA: 0x0005B7C1 File Offset: 0x000599C1
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Security.PermissionSet" /> is empty.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Security.PermissionSet" /> is empty; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001663 RID: 5731 RVA: 0x0005B7D0 File Offset: 0x000599D0
		public bool IsEmpty()
		{
			if (this.state == PermissionState.Unrestricted)
			{
				return false;
			}
			if (this.list == null || this.list.Count == 0)
			{
				return true;
			}
			using (IEnumerator enumerator = this.list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!((IPermission)enumerator.Current).IsSubsetOf(null))
					{
						return false;
					}
				}
			}
			return true;
		}

		/// <summary>Determines whether the <see cref="T:System.Security.PermissionSet" /> is <see langword="Unrestricted" />.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Security.PermissionSet" /> is <see langword="Unrestricted" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001664 RID: 5732 RVA: 0x0005B854 File Offset: 0x00059A54
		public bool IsUnrestricted()
		{
			return this.state == PermissionState.Unrestricted;
		}

		/// <summary>Returns a string representation of the <see cref="T:System.Security.PermissionSet" />.</summary>
		/// <returns>A representation of the <see cref="T:System.Security.PermissionSet" />.</returns>
		// Token: 0x06001665 RID: 5733 RVA: 0x0005B85F File Offset: 0x00059A5F
		public override string ToString()
		{
			return this.ToXml().ToString();
		}

		/// <summary>Creates an XML encoding of the security object and its current state.</summary>
		/// <returns>An XML encoding of the security object, including any state information.</returns>
		// Token: 0x06001666 RID: 5734 RVA: 0x0005B86C File Offset: 0x00059A6C
		public virtual SecurityElement ToXml()
		{
			SecurityElement securityElement = new SecurityElement("PermissionSet");
			securityElement.AddAttribute("class", base.GetType().FullName);
			securityElement.AddAttribute("version", 1.ToString());
			if (this.state == PermissionState.Unrestricted)
			{
				securityElement.AddAttribute("Unrestricted", "true");
			}
			foreach (object obj in this.list)
			{
				IPermission permission = (IPermission)obj;
				securityElement.AddChild(permission.ToXml());
			}
			return securityElement;
		}

		/// <summary>Gets the number of permission objects contained in the permission set.</summary>
		/// <returns>The number of permission objects contained in the <see cref="T:System.Security.PermissionSet" />.</returns>
		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06001667 RID: 5735 RVA: 0x0005B91C File Offset: 0x00059B1C
		public virtual int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		/// <summary>Gets a value indicating whether the collection is guaranteed to be thread safe.</summary>
		/// <returns>Always <see langword="false" />.</returns>
		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06001668 RID: 5736 RVA: 0x0005B929 File Offset: 0x00059B29
		public virtual bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		/// <summary>Gets the root object of the current collection.</summary>
		/// <returns>The root object of the current collection.</returns>
		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x0000245A File Offset: 0x0000065A
		public virtual object SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Runs when the entire object graph has been deserialized.</summary>
		/// <param name="sender">The object that initiated the callback. The functionality for this parameter is not currently implemented.</param>
		// Token: 0x0600166A RID: 5738 RVA: 0x00002A7D File Offset: 0x00000C7D
		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		/// <summary>Determines whether the specified <see cref="T:System.Security.PermissionSet" /> or <see cref="T:System.Security.NamedPermissionSet" /> object is equal to the current <see cref="T:System.Security.PermissionSet" />.</summary>
		/// <param name="obj">The object to compare with the current <see cref="T:System.Security.PermissionSet" />. </param>
		/// <returns>
		///     <see langword="true" /> if the specified object is equal to the current <see cref="T:System.Security.PermissionSet" /> object; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600166B RID: 5739 RVA: 0x0005B938 File Offset: 0x00059B38
		[ComVisible(false)]
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			PermissionSet permissionSet = obj as PermissionSet;
			if (permissionSet == null)
			{
				return false;
			}
			if (this.state != permissionSet.state)
			{
				return false;
			}
			if (this.list.Count != permissionSet.Count)
			{
				return false;
			}
			for (int i = 0; i < this.list.Count; i++)
			{
				bool flag = false;
				int num = 0;
				while (i < permissionSet.list.Count)
				{
					if (this.list[i].Equals(permissionSet.list[num]))
					{
						flag = true;
						break;
					}
					num++;
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Gets a hash code for the <see cref="T:System.Security.PermissionSet" /> object that is suitable for use in hashing algorithms and data structures such as a hash table.</summary>
		/// <returns>A hash code for the current <see cref="T:System.Security.PermissionSet" /> object.</returns>
		// Token: 0x0600166C RID: 5740 RVA: 0x0005B9D2 File Offset: 0x00059BD2
		[ComVisible(false)]
		public override int GetHashCode()
		{
			if (this.list.Count != 0)
			{
				return base.GetHashCode();
			}
			return (int)this.state;
		}

		// Token: 0x040008B0 RID: 2224
		private static object[] psUnrestricted = new object[]
		{
			PermissionState.Unrestricted
		};

		// Token: 0x040008B1 RID: 2225
		private PermissionState state;

		// Token: 0x040008B2 RID: 2226
		private ArrayList list;

		// Token: 0x040008B3 RID: 2227
		private bool _declsec;

		// Token: 0x040008B4 RID: 2228
		private bool[] _ignored;

		// Token: 0x040008B5 RID: 2229
		private static object[] action = new object[]
		{
			(SecurityAction)0
		};
	}
}
