using System;
using System.Collections;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200037C RID: 892
	[Serializable]
	internal class MessageDictionary : IDictionary, ICollection, IEnumerable
	{
		// Token: 0x06001BE0 RID: 7136 RVA: 0x000777C1 File Offset: 0x000759C1
		public MessageDictionary(IMethodMessage message)
		{
			this._message = message;
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x000777D0 File Offset: 0x000759D0
		internal bool HasUserData()
		{
			if (this._internalProperties == null)
			{
				return false;
			}
			if (this._internalProperties is MessageDictionary)
			{
				return ((MessageDictionary)this._internalProperties).HasUserData();
			}
			return this._internalProperties.Count > 0;
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x00077808 File Offset: 0x00075A08
		internal IDictionary InternalDictionary
		{
			get
			{
				if (this._internalProperties != null && this._internalProperties is MessageDictionary)
				{
					return ((MessageDictionary)this._internalProperties).InternalDictionary;
				}
				return this._internalProperties;
			}
		}

		// Token: 0x1700035F RID: 863
		// (set) Token: 0x06001BE3 RID: 7139 RVA: 0x00077836 File Offset: 0x00075A36
		public string[] MethodKeys
		{
			set
			{
				this._methodKeys = value;
			}
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x0007783F File Offset: 0x00075A3F
		protected virtual IDictionary AllocInternalProperties()
		{
			this._ownProperties = true;
			return new Hashtable();
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0007784D File Offset: 0x00075A4D
		public IDictionary GetInternalProperties()
		{
			if (this._internalProperties == null)
			{
				this._internalProperties = this.AllocInternalProperties();
			}
			return this._internalProperties;
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x0007786C File Offset: 0x00075A6C
		private bool IsOverridenKey(string key)
		{
			if (this._ownProperties)
			{
				return false;
			}
			foreach (string b in this._methodKeys)
			{
				if (key == b)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000362 RID: 866
		public object this[object key]
		{
			get
			{
				string text = (string)key;
				for (int i = 0; i < this._methodKeys.Length; i++)
				{
					if (this._methodKeys[i] == text)
					{
						return this.GetMethodProperty(text);
					}
				}
				if (this._internalProperties != null)
				{
					return this._internalProperties[key];
				}
				return null;
			}
			set
			{
				this.Add(key, value);
			}
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x00077908 File Offset: 0x00075B08
		protected virtual object GetMethodProperty(string key)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(key);
			if (num <= 1637783905U)
			{
				if (num <= 1201911322U)
				{
					if (num != 990701179U)
					{
						if (num == 1201911322U)
						{
							if (key == "__CallContext")
							{
								return this._message.LogicalCallContext;
							}
						}
					}
					else if (key == "__Uri")
					{
						return this._message.Uri;
					}
				}
				else if (num != 1619225942U)
				{
					if (num == 1637783905U)
					{
						if (key == "__Return")
						{
							return ((IMethodReturnMessage)this._message).ReturnValue;
						}
					}
				}
				else if (key == "__Args")
				{
					return this._message.Args;
				}
			}
			else if (num <= 2010141056U)
			{
				if (num != 1960967436U)
				{
					if (num == 2010141056U)
					{
						if (key == "__TypeName")
						{
							return this._message.TypeName;
						}
					}
				}
				else if (key == "__OutArgs")
				{
					return ((IMethodReturnMessage)this._message).OutArgs;
				}
			}
			else if (num != 3166241401U)
			{
				if (num == 3679129400U)
				{
					if (key == "__MethodSignature")
					{
						return this._message.MethodSignature;
					}
				}
			}
			else if (key == "__MethodName")
			{
				return this._message.MethodName;
			}
			return null;
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00077A8C File Offset: 0x00075C8C
		protected virtual void SetMethodProperty(string key, object value)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(key);
			if (num <= 1637783905U)
			{
				if (num <= 1201911322U)
				{
					if (num != 990701179U)
					{
						if (num != 1201911322U)
						{
							return;
						}
						key == "__CallContext";
						return;
					}
					else
					{
						if (!(key == "__Uri"))
						{
							return;
						}
						((IInternalMessage)this._message).Uri = (string)value;
						return;
					}
				}
				else
				{
					if (num == 1619225942U)
					{
						key == "__Args";
						return;
					}
					if (num != 1637783905U)
					{
						return;
					}
					key == "__Return";
					return;
				}
			}
			else if (num <= 2010141056U)
			{
				if (num == 1960967436U)
				{
					key == "__OutArgs";
					return;
				}
				if (num != 2010141056U)
				{
					return;
				}
				key == "__TypeName";
				return;
			}
			else
			{
				if (num == 3166241401U)
				{
					key == "__MethodName";
					return;
				}
				if (num != 3679129400U)
				{
					return;
				}
				key == "__MethodSignature";
				return;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x00077B84 File Offset: 0x00075D84
		public ICollection Keys
		{
			get
			{
				ArrayList arrayList = new ArrayList();
				for (int i = 0; i < this._methodKeys.Length; i++)
				{
					arrayList.Add(this._methodKeys[i]);
				}
				if (this._internalProperties != null)
				{
					foreach (object obj in this._internalProperties.Keys)
					{
						string text = (string)obj;
						if (!this.IsOverridenKey(text))
						{
							arrayList.Add(text);
						}
					}
				}
				return arrayList;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x00077C20 File Offset: 0x00075E20
		public ICollection Values
		{
			get
			{
				ArrayList arrayList = new ArrayList();
				for (int i = 0; i < this._methodKeys.Length; i++)
				{
					arrayList.Add(this.GetMethodProperty(this._methodKeys[i]));
				}
				if (this._internalProperties != null)
				{
					foreach (object obj in this._internalProperties)
					{
						DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
						if (!this.IsOverridenKey((string)dictionaryEntry.Key))
						{
							arrayList.Add(dictionaryEntry.Value);
						}
					}
				}
				return arrayList;
			}
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00077CD0 File Offset: 0x00075ED0
		public void Add(object key, object value)
		{
			string text = (string)key;
			for (int i = 0; i < this._methodKeys.Length; i++)
			{
				if (this._methodKeys[i] == text)
				{
					this.SetMethodProperty(text, value);
					return;
				}
			}
			if (this._internalProperties == null)
			{
				this._internalProperties = this.AllocInternalProperties();
			}
			this._internalProperties[key] = value;
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x00077D31 File Offset: 0x00075F31
		public void Clear()
		{
			if (this._internalProperties != null)
			{
				this._internalProperties.Clear();
			}
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00077D48 File Offset: 0x00075F48
		public bool Contains(object key)
		{
			string b = (string)key;
			for (int i = 0; i < this._methodKeys.Length; i++)
			{
				if (this._methodKeys[i] == b)
				{
					return true;
				}
			}
			return this._internalProperties != null && this._internalProperties.Contains(key);
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00077D98 File Offset: 0x00075F98
		public void Remove(object key)
		{
			string b = (string)key;
			for (int i = 0; i < this._methodKeys.Length; i++)
			{
				if (this._methodKeys[i] == b)
				{
					throw new ArgumentException("key was invalid");
				}
			}
			if (this._internalProperties != null)
			{
				this._internalProperties.Remove(key);
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x00077DEE File Offset: 0x00075FEE
		public int Count
		{
			get
			{
				if (this._internalProperties != null)
				{
					return this._internalProperties.Count + this._methodKeys.Length;
				}
				return this._methodKeys.Length;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x0000245A File Offset: 0x0000065A
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00077E15 File Offset: 0x00076015
		public void CopyTo(Array array, int index)
		{
			this.Values.CopyTo(array, index);
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00077E24 File Offset: 0x00076024
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new MessageDictionary.DictionaryEnumerator(this);
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00077E24 File Offset: 0x00076024
		public IDictionaryEnumerator GetEnumerator()
		{
			return new MessageDictionary.DictionaryEnumerator(this);
		}

		// Token: 0x04000BAB RID: 2987
		private IDictionary _internalProperties;

		// Token: 0x04000BAC RID: 2988
		protected IMethodMessage _message;

		// Token: 0x04000BAD RID: 2989
		private string[] _methodKeys;

		// Token: 0x04000BAE RID: 2990
		private bool _ownProperties;

		// Token: 0x0200037D RID: 893
		private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06001BF9 RID: 7161 RVA: 0x00077E2C File Offset: 0x0007602C
			public DictionaryEnumerator(MessageDictionary methodDictionary)
			{
				this._methodDictionary = methodDictionary;
				this._hashtableEnum = ((this._methodDictionary._internalProperties != null) ? this._methodDictionary._internalProperties.GetEnumerator() : null);
				this._posMethod = -1;
			}

			// Token: 0x17000368 RID: 872
			// (get) Token: 0x06001BFA RID: 7162 RVA: 0x00077E68 File Offset: 0x00076068
			public object Current
			{
				get
				{
					return this.Entry;
				}
			}

			// Token: 0x06001BFB RID: 7163 RVA: 0x00077E78 File Offset: 0x00076078
			public bool MoveNext()
			{
				if (this._posMethod != -2)
				{
					this._posMethod++;
					if (this._posMethod < this._methodDictionary._methodKeys.Length)
					{
						return true;
					}
					this._posMethod = -2;
				}
				if (this._hashtableEnum == null)
				{
					return false;
				}
				while (this._hashtableEnum.MoveNext())
				{
					if (!this._methodDictionary.IsOverridenKey((string)this._hashtableEnum.Key))
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x06001BFC RID: 7164 RVA: 0x00077EF3 File Offset: 0x000760F3
			public void Reset()
			{
				this._posMethod = -1;
				this._hashtableEnum.Reset();
			}

			// Token: 0x17000369 RID: 873
			// (get) Token: 0x06001BFD RID: 7165 RVA: 0x00077F08 File Offset: 0x00076108
			public DictionaryEntry Entry
			{
				get
				{
					if (this._posMethod >= 0)
					{
						return new DictionaryEntry(this._methodDictionary._methodKeys[this._posMethod], this._methodDictionary.GetMethodProperty(this._methodDictionary._methodKeys[this._posMethod]));
					}
					if (this._posMethod == -1 || this._hashtableEnum == null)
					{
						throw new InvalidOperationException("The enumerator is positioned before the first element of the collection or after the last element");
					}
					return this._hashtableEnum.Entry;
				}
			}

			// Token: 0x1700036A RID: 874
			// (get) Token: 0x06001BFE RID: 7166 RVA: 0x00077F7C File Offset: 0x0007617C
			public object Key
			{
				get
				{
					return this.Entry.Key;
				}
			}

			// Token: 0x1700036B RID: 875
			// (get) Token: 0x06001BFF RID: 7167 RVA: 0x00077F98 File Offset: 0x00076198
			public object Value
			{
				get
				{
					return this.Entry.Value;
				}
			}

			// Token: 0x04000BAF RID: 2991
			private MessageDictionary _methodDictionary;

			// Token: 0x04000BB0 RID: 2992
			private IDictionaryEnumerator _hashtableEnum;

			// Token: 0x04000BB1 RID: 2993
			private int _posMethod;
		}
	}
}
