using System;
using System.Collections;

namespace System.Security.Cryptography
{
	/// <summary>Provides the ability to navigate through an <see cref="T:System.Security.Cryptography.OidCollection" /> object. This class cannot be inherited.</summary>
	// Token: 0x020000DD RID: 221
	public sealed class OidEnumerator : IEnumerator
	{
		// Token: 0x0600065B RID: 1627 RVA: 0x00025F7F File Offset: 0x0002417F
		internal OidEnumerator(OidCollection oids)
		{
			this._oids = oids;
			this._current = -1;
		}

		/// <summary>Gets the current <see cref="T:System.Security.Cryptography.Oid" /> object in an <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
		/// <returns>The current <see cref="T:System.Security.Cryptography.Oid" /> object in the collection.</returns>
		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x00025F95 File Offset: 0x00024195
		public Oid Current
		{
			get
			{
				return this._oids[this._current];
			}
		}

		/// <summary>Gets the current <see cref="T:System.Security.Cryptography.Oid" /> object in an <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
		/// <returns>The current <see cref="T:System.Security.Cryptography.Oid" /> object.</returns>
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x00025FA8 File Offset: 0x000241A8
		object IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		/// <summary>Advances to the next <see cref="T:System.Security.Cryptography.Oid" /> object in an <see cref="T:System.Security.Cryptography.OidCollection" /> object.</summary>
		/// <returns>
		///     <see langword="true" />, if the enumerator was successfully advanced to the next element; <see langword="false" />, if the enumerator has passed the end of the collection.</returns>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created.</exception>
		// Token: 0x0600065E RID: 1630 RVA: 0x00025FB0 File Offset: 0x000241B0
		public bool MoveNext()
		{
			if (this._current >= this._oids.Count - 1)
			{
				return false;
			}
			this._current++;
			return true;
		}

		/// <summary>Sets an enumerator to its initial position.</summary>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created.</exception>
		// Token: 0x0600065F RID: 1631 RVA: 0x00025FD8 File Offset: 0x000241D8
		public void Reset()
		{
			this._current = -1;
		}

		// Token: 0x04000438 RID: 1080
		private readonly OidCollection _oids;

		// Token: 0x04000439 RID: 1081
		private int _current;
	}
}
