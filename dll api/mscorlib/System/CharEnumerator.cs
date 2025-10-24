using System;
using System.Collections;
using System.Collections.Generic;

namespace System
{
	/// <summary>Supports iterating over a <see cref="T:System.String" /> object and reading its individual characters. This class cannot be inherited.</summary>
	// Token: 0x0200008B RID: 139
	[Serializable]
	public sealed class CharEnumerator : IEnumerator, IEnumerator<char>, IDisposable, ICloneable
	{
		// Token: 0x0600035F RID: 863 RVA: 0x0000FDC0 File Offset: 0x0000DFC0
		internal CharEnumerator(string str)
		{
			this._str = str;
			this._index = -1;
		}

		/// <summary>Creates a copy of the current <see cref="T:System.CharEnumerator" /> object.</summary>
		/// <returns>An <see cref="T:System.Object" /> that is a copy of the current <see cref="T:System.CharEnumerator" /> object.</returns>
		// Token: 0x06000360 RID: 864 RVA: 0x0000FDD6 File Offset: 0x0000DFD6
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		/// <summary>Increments the internal index of the current <see cref="T:System.CharEnumerator" /> object to the next character of the enumerated string.</summary>
		/// <returns>
		///     <see langword="true" /> if the index is successfully incremented and within the enumerated string; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000361 RID: 865 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
		public bool MoveNext()
		{
			if (this._index < this._str.Length - 1)
			{
				this._index++;
				this._currentElement = this._str[this._index];
				return true;
			}
			this._index = this._str.Length;
			return false;
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.CharEnumerator" /> class.</summary>
		// Token: 0x06000362 RID: 866 RVA: 0x0000FE3B File Offset: 0x0000E03B
		public void Dispose()
		{
			if (this._str != null)
			{
				this._index = this._str.Length;
			}
			this._str = null;
		}

		/// <summary>Gets the currently referenced character in the string enumerated by this <see cref="T:System.CharEnumerator" /> object. For a description of this member, see <see cref="P:System.Collections.IEnumerator.Current" />. </summary>
		/// <returns>The boxed Unicode character currently referenced by this <see cref="T:System.CharEnumerator" /> object.</returns>
		/// <exception cref="T:System.InvalidOperationException">Enumeration has not started.-or-Enumeration has ended.</exception>
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000363 RID: 867 RVA: 0x0000FE5D File Offset: 0x0000E05D
		object IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		/// <summary>Gets the currently referenced character in the string enumerated by this <see cref="T:System.CharEnumerator" /> object.</summary>
		/// <returns>The Unicode character currently referenced by this <see cref="T:System.CharEnumerator" /> object.</returns>
		/// <exception cref="T:System.InvalidOperationException">The index is invalid; that is, it is before the first or after the last character of the enumerated string. </exception>
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0000FE6A File Offset: 0x0000E06A
		public char Current
		{
			get
			{
				if (this._index == -1)
				{
					throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
				}
				if (this._index >= this._str.Length)
				{
					throw new InvalidOperationException("Enumeration already finished.");
				}
				return this._currentElement;
			}
		}

		/// <summary>Initializes the index to a position logically before the first character of the enumerated string.</summary>
		// Token: 0x06000365 RID: 869 RVA: 0x0000FEA4 File Offset: 0x0000E0A4
		public void Reset()
		{
			this._currentElement = '\0';
			this._index = -1;
		}

		// Token: 0x040001D5 RID: 469
		private string _str;

		// Token: 0x040001D6 RID: 470
		private int _index;

		// Token: 0x040001D7 RID: 471
		private char _currentElement;
	}
}
