using System;
using System.Collections;

namespace System.Runtime.Serialization
{
	/// <summary>Provides a formatter-friendly mechanism for parsing the data in <see cref="T:System.Runtime.Serialization.SerializationInfo" />. This class cannot be inherited.</summary>
	// Token: 0x02000394 RID: 916
	public sealed class SerializationInfoEnumerator : IEnumerator
	{
		// Token: 0x06001C7A RID: 7290 RVA: 0x00079178 File Offset: 0x00077378
		internal SerializationInfoEnumerator(string[] members, object[] info, Type[] types, int numItems)
		{
			this._members = members;
			this._data = info;
			this._types = types;
			this._numItems = numItems - 1;
			this._currItem = -1;
			this._current = false;
		}

		/// <summary>Updates the enumerator to the next item.</summary>
		/// <returns>
		///     <see langword="true" /> if a new element is found; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001C7B RID: 7291 RVA: 0x000791AD File Offset: 0x000773AD
		public bool MoveNext()
		{
			if (this._currItem < this._numItems)
			{
				this._currItem++;
				this._current = true;
			}
			else
			{
				this._current = false;
			}
			return this._current;
		}

		/// <summary>Gets the current item in the collection.</summary>
		/// <returns>A <see cref="T:System.Runtime.Serialization.SerializationEntry" /> that contains the current serialization data.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumeration has not started or has already ended. </exception>
		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001C7C RID: 7292 RVA: 0x000791E1 File Offset: 0x000773E1
		object IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		/// <summary>Gets the item currently being examined.</summary>
		/// <returns>The item currently being examined.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumerator has not started enumerating items or has reached the end of the enumeration. </exception>
		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x000791F0 File Offset: 0x000773F0
		public SerializationEntry Current
		{
			get
			{
				if (!this._current)
				{
					throw new InvalidOperationException("Enumeration has either not started or has already finished.");
				}
				return new SerializationEntry(this._members[this._currItem], this._data[this._currItem], this._types[this._currItem]);
			}
		}

		/// <summary>Resets the enumerator to the first item.</summary>
		// Token: 0x06001C7E RID: 7294 RVA: 0x0007923C File Offset: 0x0007743C
		public void Reset()
		{
			this._currItem = -1;
			this._current = false;
		}

		/// <summary>Gets the name for the item currently being examined.</summary>
		/// <returns>The item name.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumerator has not started enumerating items or has reached the end of the enumeration. </exception>
		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x0007924C File Offset: 0x0007744C
		public string Name
		{
			get
			{
				if (!this._current)
				{
					throw new InvalidOperationException("Enumeration has either not started or has already finished.");
				}
				return this._members[this._currItem];
			}
		}

		/// <summary>Gets the value of the item currently being examined.</summary>
		/// <returns>The value of the item currently being examined.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumerator has not started enumerating items or has reached the end of the enumeration. </exception>
		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x0007926E File Offset: 0x0007746E
		public object Value
		{
			get
			{
				if (!this._current)
				{
					throw new InvalidOperationException("Enumeration has either not started or has already finished.");
				}
				return this._data[this._currItem];
			}
		}

		/// <summary>Gets the type of the item currently being examined.</summary>
		/// <returns>The type of the item currently being examined.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enumerator has not started enumerating items or has reached the end of the enumeration. </exception>
		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x00079290 File Offset: 0x00077490
		public Type ObjectType
		{
			get
			{
				if (!this._current)
				{
					throw new InvalidOperationException("Enumeration has either not started or has already finished.");
				}
				return this._types[this._currItem];
			}
		}

		// Token: 0x04000BF3 RID: 3059
		private readonly string[] _members;

		// Token: 0x04000BF4 RID: 3060
		private readonly object[] _data;

		// Token: 0x04000BF5 RID: 3061
		private readonly Type[] _types;

		// Token: 0x04000BF6 RID: 3062
		private readonly int _numItems;

		// Token: 0x04000BF7 RID: 3063
		private int _currItem;

		// Token: 0x04000BF8 RID: 3064
		private bool _current;
	}
}
