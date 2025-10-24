using System;

namespace System.Xml
{
	/// <summary>Implements a single-threaded <see cref="T:System.Xml.XmlNameTable" />.</summary>
	// Token: 0x02000160 RID: 352
	public class NameTable : XmlNameTable
	{
		/// <summary>Initializes a new instance of the <see langword="NameTable" /> class.</summary>
		// Token: 0x06000D02 RID: 3330 RVA: 0x0004EC8D File Offset: 0x0004CE8D
		public NameTable()
		{
			this.mask = 31;
			this.entries = new NameTable.Entry[this.mask + 1];
			this.hashCodeRandomizer = Environment.TickCount;
		}

		/// <summary>Atomizes the specified string and adds it to the <see langword="NameTable" />.</summary>
		/// <param name="key">The string to add. </param>
		/// <returns>The atomized string or the existing string if it already exists in the <see langword="NameTable" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		// Token: 0x06000D03 RID: 3331 RVA: 0x0004ECBC File Offset: 0x0004CEBC
		public override string Add(string key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			int length = key.Length;
			if (length == 0)
			{
				return string.Empty;
			}
			int num = length + this.hashCodeRandomizer;
			for (int i = 0; i < key.Length; i++)
			{
				num += (num << 7 ^ (int)key[i]);
			}
			num -= num >> 17;
			num -= num >> 11;
			num -= num >> 5;
			for (NameTable.Entry entry = this.entries[num & this.mask]; entry != null; entry = entry.next)
			{
				if (entry.hashCode == num && entry.str.Equals(key))
				{
					return entry.str;
				}
			}
			return this.AddEntry(key, num);
		}

		/// <summary>Atomizes the specified string and adds it to the <see langword="NameTable" />.</summary>
		/// <param name="key">The character array containing the string to add. </param>
		/// <param name="start">The zero-based index into the array specifying the first character of the string. </param>
		/// <param name="len">The number of characters in the string. </param>
		/// <returns>The atomized string or the existing string if one already exists in the <see langword="NameTable" />. If <paramref name="len" /> is zero, String.Empty is returned.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">0 &gt; <paramref name="start" />-or- 
		///         <paramref name="start" /> &gt;= <paramref name="key" />.Length -or- 
		///         <paramref name="len" /> &gt;= <paramref name="key" />.Length The above conditions do not cause an exception to be thrown if <paramref name="len" /> =0. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="len" /> &lt; 0. </exception>
		// Token: 0x06000D04 RID: 3332 RVA: 0x0004ED68 File Offset: 0x0004CF68
		public override string Add(char[] key, int start, int len)
		{
			if (len == 0)
			{
				return string.Empty;
			}
			int num = len + this.hashCodeRandomizer;
			num += (num << 7 ^ (int)key[start]);
			int num2 = start + len;
			for (int i = start + 1; i < num2; i++)
			{
				num += (num << 7 ^ (int)key[i]);
			}
			num -= num >> 17;
			num -= num >> 11;
			num -= num >> 5;
			for (NameTable.Entry entry = this.entries[num & this.mask]; entry != null; entry = entry.next)
			{
				if (entry.hashCode == num && NameTable.TextEquals(entry.str, key, start, len))
				{
					return entry.str;
				}
			}
			return this.AddEntry(new string(key, start, len), num);
		}

		/// <summary>Gets the atomized string with the specified value.</summary>
		/// <param name="value">The name to find. </param>
		/// <returns>The atomized string object or <see langword="null" /> if the string has not already been atomized.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		// Token: 0x06000D05 RID: 3333 RVA: 0x0004EE0C File Offset: 0x0004D00C
		public override string Get(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Length == 0)
			{
				return string.Empty;
			}
			int num = value.Length + this.hashCodeRandomizer;
			for (int i = 0; i < value.Length; i++)
			{
				num += (num << 7 ^ (int)value[i]);
			}
			num -= num >> 17;
			num -= num >> 11;
			num -= num >> 5;
			for (NameTable.Entry entry = this.entries[num & this.mask]; entry != null; entry = entry.next)
			{
				if (entry.hashCode == num && entry.str.Equals(value))
				{
					return entry.str;
				}
			}
			return null;
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0004EEB4 File Offset: 0x0004D0B4
		private string AddEntry(string str, int hashCode)
		{
			int num = hashCode & this.mask;
			NameTable.Entry entry = new NameTable.Entry(str, hashCode, this.entries[num]);
			this.entries[num] = entry;
			int num2 = this.count;
			this.count = num2 + 1;
			if (num2 == this.mask)
			{
				this.Grow();
			}
			return entry.str;
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0004EF08 File Offset: 0x0004D108
		private void Grow()
		{
			int num = this.mask * 2 + 1;
			NameTable.Entry[] array = this.entries;
			NameTable.Entry[] array2 = new NameTable.Entry[num + 1];
			foreach (NameTable.Entry entry in array)
			{
				while (entry != null)
				{
					int num2 = entry.hashCode & num;
					NameTable.Entry next = entry.next;
					entry.next = array2[num2];
					array2[num2] = entry;
					entry = next;
				}
			}
			this.entries = array2;
			this.mask = num;
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0004EF7C File Offset: 0x0004D17C
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length)
		{
			if (str1.Length != str2Length)
			{
				return false;
			}
			for (int i = 0; i < str1.Length; i++)
			{
				if (str1[i] != str2[str2Start + i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040008F8 RID: 2296
		private NameTable.Entry[] entries;

		// Token: 0x040008F9 RID: 2297
		private int count;

		// Token: 0x040008FA RID: 2298
		private int mask;

		// Token: 0x040008FB RID: 2299
		private int hashCodeRandomizer;

		// Token: 0x02000161 RID: 353
		private class Entry
		{
			// Token: 0x06000D09 RID: 3337 RVA: 0x0004EFB6 File Offset: 0x0004D1B6
			internal Entry(string str, int hashCode, NameTable.Entry next)
			{
				this.str = str;
				this.hashCode = hashCode;
				this.next = next;
			}

			// Token: 0x040008FC RID: 2300
			internal string str;

			// Token: 0x040008FD RID: 2301
			internal int hashCode;

			// Token: 0x040008FE RID: 2302
			internal NameTable.Entry next;
		}
	}
}
