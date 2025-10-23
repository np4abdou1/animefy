using System;
using System.Collections.Generic;

namespace System.Dynamic
{
	// Token: 0x0200011F RID: 287
	internal class ExpandoClass
	{
		// Token: 0x0600093D RID: 2365 RVA: 0x00023682 File Offset: 0x00021882
		internal ExpandoClass()
		{
			this._hashCode = 6551;
			this._keys = Array.Empty<string>();
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x000236A0 File Offset: 0x000218A0
		internal ExpandoClass(string[] keys, int hashCode)
		{
			this._hashCode = hashCode;
			this._keys = keys;
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000236B8 File Offset: 0x000218B8
		internal ExpandoClass FindNewClass(string newKey)
		{
			int hashCode = this._hashCode ^ newKey.GetHashCode();
			ExpandoClass result;
			lock (this)
			{
				List<WeakReference> transitionList = this.GetTransitionList(hashCode);
				for (int i = 0; i < transitionList.Count; i++)
				{
					ExpandoClass expandoClass = transitionList[i].Target as ExpandoClass;
					if (expandoClass == null)
					{
						transitionList.RemoveAt(i);
						i--;
					}
					else if (string.Equals(expandoClass._keys[expandoClass._keys.Length - 1], newKey, StringComparison.Ordinal))
					{
						return expandoClass;
					}
				}
				string[] array = new string[this._keys.Length + 1];
				Array.Copy(this._keys, 0, array, 0, this._keys.Length);
				array[this._keys.Length] = newKey;
				ExpandoClass expandoClass2 = new ExpandoClass(array, hashCode);
				transitionList.Add(new WeakReference(expandoClass2));
				result = expandoClass2;
			}
			return result;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x000237B4 File Offset: 0x000219B4
		private List<WeakReference> GetTransitionList(int hashCode)
		{
			if (this._transitions == null)
			{
				this._transitions = new Dictionary<int, List<WeakReference>>();
			}
			List<WeakReference> result;
			if (!this._transitions.TryGetValue(hashCode, out result))
			{
				result = (this._transitions[hashCode] = new List<WeakReference>());
			}
			return result;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x000237F8 File Offset: 0x000219F8
		internal int GetValueIndex(string name, bool caseInsensitive, ExpandoObject obj)
		{
			if (caseInsensitive)
			{
				return this.GetValueIndexCaseInsensitive(name, obj);
			}
			return this.GetValueIndexCaseSensitive(name);
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00023810 File Offset: 0x00021A10
		internal int GetValueIndexCaseSensitive(string name)
		{
			for (int i = 0; i < this._keys.Length; i++)
			{
				if (string.Equals(this._keys[i], name, StringComparison.Ordinal))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00023844 File Offset: 0x00021A44
		private int GetValueIndexCaseInsensitive(string name, ExpandoObject obj)
		{
			int num = -1;
			object lockObject = obj.LockObject;
			lock (lockObject)
			{
				for (int i = this._keys.Length - 1; i >= 0; i--)
				{
					if (string.Equals(this._keys[i], name, StringComparison.OrdinalIgnoreCase) && !obj.IsDeletedMember(i))
					{
						if (num != -1)
						{
							return -2;
						}
						num = i;
					}
				}
			}
			return num;
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x000238C4 File Offset: 0x00021AC4
		internal string[] Keys
		{
			get
			{
				return this._keys;
			}
		}

		// Token: 0x040002BF RID: 703
		private readonly string[] _keys;

		// Token: 0x040002C0 RID: 704
		private readonly int _hashCode;

		// Token: 0x040002C1 RID: 705
		private Dictionary<int, List<WeakReference>> _transitions;

		// Token: 0x040002C2 RID: 706
		internal static readonly ExpandoClass Empty = new ExpandoClass();
	}
}
