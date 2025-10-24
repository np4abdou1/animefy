using System;

namespace System.Collections
{
	// Token: 0x020005DC RID: 1500
	[Serializable]
	internal sealed class CompatibleComparer : IEqualityComparer
	{
		// Token: 0x06002CA6 RID: 11430 RVA: 0x000B8179 File Offset: 0x000B6379
		internal CompatibleComparer(IHashCodeProvider hashCodeProvider, IComparer comparer)
		{
			this._hcp = hashCodeProvider;
			this._comparer = comparer;
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06002CA7 RID: 11431 RVA: 0x000B818F File Offset: 0x000B638F
		internal IHashCodeProvider HashCodeProvider
		{
			get
			{
				return this._hcp;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x000B8197 File Offset: 0x000B6397
		internal IComparer Comparer
		{
			get
			{
				return this._comparer;
			}
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x000B819F File Offset: 0x000B639F
		public bool Equals(object a, object b)
		{
			return this.Compare(a, b) == 0;
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x000B81AC File Offset: 0x000B63AC
		public int Compare(object a, object b)
		{
			if (a == b)
			{
				return 0;
			}
			if (a == null)
			{
				return -1;
			}
			if (b == null)
			{
				return 1;
			}
			if (this._comparer != null)
			{
				return this._comparer.Compare(a, b);
			}
			IComparable comparable = a as IComparable;
			if (comparable != null)
			{
				return comparable.CompareTo(b);
			}
			throw new ArgumentException("At least one object must implement IComparable.");
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x000B81FB File Offset: 0x000B63FB
		public int GetHashCode(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			if (this._hcp == null)
			{
				return obj.GetHashCode();
			}
			return this._hcp.GetHashCode(obj);
		}

		// Token: 0x04001868 RID: 6248
		private readonly IHashCodeProvider _hcp;

		// Token: 0x04001869 RID: 6249
		private readonly IComparer _comparer;
	}
}
