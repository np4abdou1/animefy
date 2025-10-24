using System;
using System.Globalization;

namespace System.Collections.Specialized
{
	// Token: 0x020002D2 RID: 722
	[Serializable]
	internal class CompatibleComparer : IEqualityComparer
	{
		// Token: 0x06001365 RID: 4965 RVA: 0x0005B3A2 File Offset: 0x000595A2
		internal CompatibleComparer(IComparer comparer, IHashCodeProvider hashCodeProvider)
		{
			this._comparer = comparer;
			this._hcp = hashCodeProvider;
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x0005B3B8 File Offset: 0x000595B8
		public bool Equals(object a, object b)
		{
			if (a == b)
			{
				return true;
			}
			if (a == null || b == null)
			{
				return false;
			}
			try
			{
				if (this._comparer != null)
				{
					return this._comparer.Compare(a, b) == 0;
				}
				IComparable comparable = a as IComparable;
				if (comparable != null)
				{
					return comparable.CompareTo(b) == 0;
				}
			}
			catch (ArgumentException)
			{
				return false;
			}
			return a.Equals(b);
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x0005B428 File Offset: 0x00059628
		public int GetHashCode(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			if (this._hcp != null)
			{
				return this._hcp.GetHashCode(obj);
			}
			return obj.GetHashCode();
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x0005B453 File Offset: 0x00059653
		public IComparer Comparer
		{
			get
			{
				return this._comparer;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x0005B45B File Offset: 0x0005965B
		public IHashCodeProvider HashCodeProvider
		{
			get
			{
				return this._hcp;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x0005B463 File Offset: 0x00059663
		public static IComparer DefaultComparer
		{
			get
			{
				if (CompatibleComparer.defaultComparer == null)
				{
					CompatibleComparer.defaultComparer = new CaseInsensitiveComparer(CultureInfo.InvariantCulture);
				}
				return CompatibleComparer.defaultComparer;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x0005B486 File Offset: 0x00059686
		public static IHashCodeProvider DefaultHashCodeProvider
		{
			get
			{
				if (CompatibleComparer.defaultHashProvider == null)
				{
					CompatibleComparer.defaultHashProvider = new CaseInsensitiveHashCodeProvider(CultureInfo.InvariantCulture);
				}
				return CompatibleComparer.defaultHashProvider;
			}
		}

		// Token: 0x04000D4F RID: 3407
		private IComparer _comparer;

		// Token: 0x04000D50 RID: 3408
		private static volatile IComparer defaultComparer;

		// Token: 0x04000D51 RID: 3409
		private IHashCodeProvider _hcp;

		// Token: 0x04000D52 RID: 3410
		private static volatile IHashCodeProvider defaultHashProvider;
	}
}
