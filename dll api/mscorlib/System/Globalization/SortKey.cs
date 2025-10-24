using System;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	/// <summary>Represents the result of mapping a string to its sort key.</summary>
	// Token: 0x020005A5 RID: 1445
	[ComVisible(true)]
	[Serializable]
	[StructLayout(0)]
	public class SortKey
	{
		/// <summary>Compares two sort keys.</summary>
		/// <param name="sortkey1">The first sort key to compare. </param>
		/// <param name="sortkey2">The second sort key to compare. </param>
		/// <returns>A signed integer that indicates the relationship between <paramref name="sortkey1" /> and <paramref name="sortkey2" />.Value Condition Less than zero 
		///             <paramref name="sortkey1" /> is less than <paramref name="sortkey2" />. Zero 
		///             <paramref name="sortkey1" /> is equal to <paramref name="sortkey2" />. Greater than zero 
		///             <paramref name="sortkey1" /> is greater than <paramref name="sortkey2" />. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="sortkey1" /> or <paramref name="sortkey2" /> is <see langword="null" />.</exception>
		// Token: 0x06002B89 RID: 11145 RVA: 0x000AFFA8 File Offset: 0x000AE1A8
		public static int Compare(SortKey sortkey1, SortKey sortkey2)
		{
			if (sortkey1 == null)
			{
				throw new ArgumentNullException("sortkey1");
			}
			if (sortkey2 == null)
			{
				throw new ArgumentNullException("sortkey2");
			}
			if (sortkey1 == sortkey2 || sortkey1.OriginalString == sortkey2.OriginalString)
			{
				return 0;
			}
			byte[] keyData = sortkey1.KeyData;
			byte[] keyData2 = sortkey2.KeyData;
			int num = (keyData.Length > keyData2.Length) ? keyData2.Length : keyData.Length;
			int i = 0;
			while (i < num)
			{
				if (keyData[i] != keyData2[i])
				{
					if (keyData[i] >= keyData2[i])
					{
						return 1;
					}
					return -1;
				}
				else
				{
					i++;
				}
			}
			if (keyData.Length == keyData2.Length)
			{
				return 0;
			}
			if (keyData.Length >= keyData2.Length)
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x000B003C File Offset: 0x000AE23C
		internal SortKey(int lcid, string source, CompareOptions opt)
		{
			this.lcid = lcid;
			this.source = source;
			this.options = opt;
			int length = source.Length;
			byte[] array = new byte[length];
			for (int i = 0; i < length; i++)
			{
				array[i] = (byte)source[i];
			}
			this.key = array;
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x000B0090 File Offset: 0x000AE290
		internal SortKey(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength)
		{
			this.lcid = lcid;
			this.source = source;
			this.key = buffer;
			this.options = opt;
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x000B00B5 File Offset: 0x000AE2B5
		internal SortKey(string localeName, string str, CompareOptions options, byte[] keyData)
		{
			throw new NotImplementedException();
		}

		/// <summary>Gets the original string used to create the current <see cref="T:System.Globalization.SortKey" /> object.</summary>
		/// <returns>The original string used to create the current <see cref="T:System.Globalization.SortKey" /> object.</returns>
		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06002B8D RID: 11149 RVA: 0x000B00C2 File Offset: 0x000AE2C2
		public virtual string OriginalString
		{
			get
			{
				return this.source;
			}
		}

		/// <summary>Gets the byte array representing the current <see cref="T:System.Globalization.SortKey" /> object.</summary>
		/// <returns>A byte array representing the current <see cref="T:System.Globalization.SortKey" /> object. </returns>
		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06002B8E RID: 11150 RVA: 0x000B00CA File Offset: 0x000AE2CA
		public virtual byte[] KeyData
		{
			get
			{
				return this.key;
			}
		}

		/// <summary>Determines whether the specified object is equal to the current <see cref="T:System.Globalization.SortKey" /> object.</summary>
		/// <param name="value">The object to compare with the current <see cref="T:System.Globalization.SortKey" /> object. </param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="value" /> parameter is equal to the current <see cref="T:System.Globalization.SortKey" /> object; otherwise, <see langword="false" />. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />.</exception>
		// Token: 0x06002B8F RID: 11151 RVA: 0x000B00D4 File Offset: 0x000AE2D4
		public override bool Equals(object value)
		{
			SortKey sortKey = value as SortKey;
			return sortKey != null && this.lcid == sortKey.lcid && this.options == sortKey.options && SortKey.Compare(this, sortKey) == 0;
		}

		/// <summary>Serves as a hash function for the current <see cref="T:System.Globalization.SortKey" /> object that is suitable for hashing algorithms and data structures such as a hash table.</summary>
		/// <returns>A hash code for the current <see cref="T:System.Globalization.SortKey" /> object.</returns>
		// Token: 0x06002B90 RID: 11152 RVA: 0x000B0114 File Offset: 0x000AE314
		public override int GetHashCode()
		{
			if (this.key.Length == 0)
			{
				return 0;
			}
			int num = (int)this.key[0];
			for (int i = 1; i < this.key.Length; i++)
			{
				num ^= (int)this.key[i] << (i & 3);
			}
			return num;
		}

		/// <summary>Returns a string that represents the current <see cref="T:System.Globalization.SortKey" /> object.</summary>
		/// <returns>A string that represents the current <see cref="T:System.Globalization.SortKey" /> object.</returns>
		// Token: 0x06002B91 RID: 11153 RVA: 0x000B015C File Offset: 0x000AE35C
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"SortKey - ",
				this.lcid.ToString(),
				", ",
				this.options.ToString(),
				", ",
				this.source
			});
		}

		// Token: 0x04001782 RID: 6018
		private readonly string source;

		// Token: 0x04001783 RID: 6019
		private readonly byte[] key;

		// Token: 0x04001784 RID: 6020
		private readonly CompareOptions options;

		// Token: 0x04001785 RID: 6021
		private readonly int lcid;
	}
}
