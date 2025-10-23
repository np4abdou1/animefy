using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Determines the set of valid key sizes for the symmetric cryptographic algorithms.</summary>
	// Token: 0x020002A9 RID: 681
	[ComVisible(true)]
	public sealed class KeySizes
	{
		/// <summary>Specifies the minimum key size in bits.</summary>
		/// <returns>The minimum key size in bits.</returns>
		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x0005F70A File Offset: 0x0005D90A
		public int MinSize
		{
			get
			{
				return this.m_minSize;
			}
		}

		/// <summary>Specifies the maximum key size in bits.</summary>
		/// <returns>The maximum key size in bits.</returns>
		// Token: 0x17000268 RID: 616
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x0005F712 File Offset: 0x0005D912
		public int MaxSize
		{
			get
			{
				return this.m_maxSize;
			}
		}

		/// <summary>Specifies the interval between valid key sizes in bits.</summary>
		/// <returns>The interval between valid key sizes in bits.</returns>
		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600171B RID: 5915 RVA: 0x0005F71A File Offset: 0x0005D91A
		public int SkipSize
		{
			get
			{
				return this.m_skipSize;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.KeySizes" /> class with the specified key values.</summary>
		/// <param name="minSize">The minimum valid key size. </param>
		/// <param name="maxSize">The maximum valid key size. </param>
		/// <param name="skipSize">The interval between valid key sizes. </param>
		// Token: 0x0600171C RID: 5916 RVA: 0x0005F722 File Offset: 0x0005D922
		public KeySizes(int minSize, int maxSize, int skipSize)
		{
			this.m_minSize = minSize;
			this.m_maxSize = maxSize;
			this.m_skipSize = skipSize;
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x0005F740 File Offset: 0x0005D940
		internal bool IsLegal(int keySize)
		{
			int num = keySize - this.MinSize;
			bool flag = num >= 0 && keySize <= this.MaxSize;
			if (this.SkipSize != 0)
			{
				return flag && num % this.SkipSize == 0;
			}
			return flag;
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x0005F784 File Offset: 0x0005D984
		internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size)
		{
			for (int i = 0; i < legalKeys.Length; i++)
			{
				if (legalKeys[i].IsLegal(size))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000973 RID: 2419
		private int m_minSize;

		// Token: 0x04000974 RID: 2420
		private int m_maxSize;

		// Token: 0x04000975 RID: 2421
		private int m_skipSize;
	}
}
