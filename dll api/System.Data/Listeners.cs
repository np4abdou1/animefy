using System;
using System.Collections.Generic;

namespace System.Data
{
	// Token: 0x02000092 RID: 146
	internal sealed class Listeners<TElem> where TElem : class
	{
		// Token: 0x060008AA RID: 2218 RVA: 0x0002BCA6 File Offset: 0x00029EA6
		internal Listeners(int ObjectID, Listeners<TElem>.Func<TElem, bool> notifyFilter)
		{
			this._listeners = new List<TElem>();
			this._filter = notifyFilter;
			this._objectID = ObjectID;
			this._listenerReaderCount = 0;
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x0002BCCE File Offset: 0x00029ECE
		internal bool HasListeners
		{
			get
			{
				return 0 < this._listeners.Count;
			}
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0002BCDE File Offset: 0x00029EDE
		internal void Add(TElem listener)
		{
			this._listeners.Add(listener);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0002BCEC File Offset: 0x00029EEC
		internal int IndexOfReference(TElem listener)
		{
			return Index.IndexOfReference<TElem>(this._listeners, listener);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0002BCFC File Offset: 0x00029EFC
		internal void Remove(TElem listener)
		{
			int index = this.IndexOfReference(listener);
			this._listeners[index] = default(TElem);
			if (this._listenerReaderCount == 0)
			{
				this._listeners.RemoveAt(index);
				this._listeners.TrimExcess();
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0002BD48 File Offset: 0x00029F48
		internal void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, Listeners<TElem>.Action<TElem, T1, T2, T3> action)
		{
			int count = this._listeners.Count;
			if (0 < count)
			{
				int nullIndex = -1;
				this._listenerReaderCount++;
				try
				{
					for (int i = 0; i < count; i++)
					{
						TElem arg4 = this._listeners[i];
						if (this._filter(arg4))
						{
							action(arg4, arg1, arg2, arg3);
						}
						else
						{
							this._listeners[i] = default(TElem);
							nullIndex = i;
						}
					}
				}
				finally
				{
					this._listenerReaderCount--;
				}
				if (this._listenerReaderCount == 0)
				{
					this.RemoveNullListeners(nullIndex);
				}
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0002BDF4 File Offset: 0x00029FF4
		private void RemoveNullListeners(int nullIndex)
		{
			int num = nullIndex;
			while (0 <= num)
			{
				if (this._listeners[num] == null)
				{
					this._listeners.RemoveAt(num);
				}
				num--;
			}
		}

		// Token: 0x040002EF RID: 751
		private readonly List<TElem> _listeners;

		// Token: 0x040002F0 RID: 752
		private readonly Listeners<TElem>.Func<TElem, bool> _filter;

		// Token: 0x040002F1 RID: 753
		private readonly int _objectID;

		// Token: 0x040002F2 RID: 754
		private int _listenerReaderCount;

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x060008B2 RID: 2226
		internal delegate void Action<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x060008B6 RID: 2230
		internal delegate TResult Func<T1, TResult>(T1 arg1);
	}
}
