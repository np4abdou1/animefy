using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security;

namespace System.Xml
{
	// Token: 0x02000041 RID: 65
	internal class SecureStringHasher : IEqualityComparer<string>
	{
		// Token: 0x060001CE RID: 462 RVA: 0x0000ACE3 File Offset: 0x00008EE3
		public SecureStringHasher()
		{
			this.hashCodeRandomizer = Environment.TickCount;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000ACF6 File Offset: 0x00008EF6
		public bool Equals(string x, string y)
		{
			return string.Equals(x, y, StringComparison.Ordinal);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000AD00 File Offset: 0x00008F00
		[SecuritySafeCritical]
		public int GetHashCode(string key)
		{
			if (SecureStringHasher.hashCodeDelegate == null)
			{
				SecureStringHasher.hashCodeDelegate = SecureStringHasher.GetHashCodeDelegate();
			}
			return SecureStringHasher.hashCodeDelegate(key, key.Length, (long)this.hashCodeRandomizer);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000AD2C File Offset: 0x00008F2C
		[SecurityCritical]
		private static int GetHashCodeOfString(string key, int sLen, long additionalEntropy)
		{
			int num = (int)additionalEntropy;
			for (int i = 0; i < key.Length; i++)
			{
				num += (num << 7 ^ (int)key[i]);
			}
			num -= num >> 17;
			num -= num >> 11;
			return num - (num >> 5);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000AD70 File Offset: 0x00008F70
		[SecuritySafeCritical]
		private static SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate()
		{
			MethodInfo method = typeof(string).GetMethod("InternalMarvin32HashString", BindingFlags.Static | BindingFlags.NonPublic);
			if (method != null)
			{
				return (SecureStringHasher.HashCodeOfStringDelegate)Delegate.CreateDelegate(typeof(SecureStringHasher.HashCodeOfStringDelegate), method);
			}
			return new SecureStringHasher.HashCodeOfStringDelegate(SecureStringHasher.GetHashCodeOfString);
		}

		// Token: 0x0400015D RID: 349
		[SecurityCritical]
		private static SecureStringHasher.HashCodeOfStringDelegate hashCodeDelegate;

		// Token: 0x0400015E RID: 350
		private int hashCodeRandomizer;

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x060001D4 RID: 468
		[SecurityCritical]
		private delegate int HashCodeOfStringDelegate(string s, int sLen, long additionalEntropy);
	}
}
