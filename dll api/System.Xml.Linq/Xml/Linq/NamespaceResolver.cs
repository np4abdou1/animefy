using System;

namespace System.Xml.Linq
{
	// Token: 0x0200002A RID: 42
	internal struct NamespaceResolver
	{
		// Token: 0x0600013F RID: 319 RVA: 0x00007DBA File Offset: 0x00005FBA
		public void PushScope()
		{
			this._scope++;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00007DCC File Offset: 0x00005FCC
		public void PopScope()
		{
			NamespaceResolver.NamespaceDeclaration namespaceDeclaration = this._declaration;
			if (namespaceDeclaration != null)
			{
				do
				{
					namespaceDeclaration = namespaceDeclaration.prev;
					if (namespaceDeclaration.scope != this._scope)
					{
						break;
					}
					if (namespaceDeclaration == this._declaration)
					{
						this._declaration = null;
					}
					else
					{
						this._declaration.prev = namespaceDeclaration.prev;
					}
					this._rover = null;
				}
				while (namespaceDeclaration != this._declaration && this._declaration != null);
			}
			this._scope--;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00007E44 File Offset: 0x00006044
		public void Add(string prefix, XNamespace ns)
		{
			NamespaceResolver.NamespaceDeclaration namespaceDeclaration = new NamespaceResolver.NamespaceDeclaration();
			namespaceDeclaration.prefix = prefix;
			namespaceDeclaration.ns = ns;
			namespaceDeclaration.scope = this._scope;
			if (this._declaration == null)
			{
				this._declaration = namespaceDeclaration;
			}
			else
			{
				namespaceDeclaration.prev = this._declaration.prev;
			}
			this._declaration.prev = namespaceDeclaration;
			this._rover = null;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00007EA8 File Offset: 0x000060A8
		public void AddFirst(string prefix, XNamespace ns)
		{
			NamespaceResolver.NamespaceDeclaration namespaceDeclaration = new NamespaceResolver.NamespaceDeclaration();
			namespaceDeclaration.prefix = prefix;
			namespaceDeclaration.ns = ns;
			namespaceDeclaration.scope = this._scope;
			if (this._declaration == null)
			{
				namespaceDeclaration.prev = namespaceDeclaration;
			}
			else
			{
				namespaceDeclaration.prev = this._declaration.prev;
				this._declaration.prev = namespaceDeclaration;
			}
			this._declaration = namespaceDeclaration;
			this._rover = null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00007F14 File Offset: 0x00006114
		public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace)
		{
			if (this._rover != null && this._rover.ns == ns && (allowDefaultNamespace || this._rover.prefix.Length > 0))
			{
				return this._rover.prefix;
			}
			NamespaceResolver.NamespaceDeclaration namespaceDeclaration = this._declaration;
			if (namespaceDeclaration != null)
			{
				for (;;)
				{
					namespaceDeclaration = namespaceDeclaration.prev;
					if (namespaceDeclaration.ns == ns)
					{
						NamespaceResolver.NamespaceDeclaration prev = this._declaration.prev;
						while (prev != namespaceDeclaration && prev.prefix != namespaceDeclaration.prefix)
						{
							prev = prev.prev;
						}
						if (prev == namespaceDeclaration)
						{
							if (allowDefaultNamespace)
							{
								break;
							}
							if (namespaceDeclaration.prefix.Length > 0)
							{
								goto Block_8;
							}
						}
					}
					if (namespaceDeclaration == this._declaration)
					{
						goto IL_BB;
					}
				}
				this._rover = namespaceDeclaration;
				return namespaceDeclaration.prefix;
				Block_8:
				return namespaceDeclaration.prefix;
			}
			IL_BB:
			return null;
		}

		// Token: 0x040000B0 RID: 176
		private int _scope;

		// Token: 0x040000B1 RID: 177
		private NamespaceResolver.NamespaceDeclaration _declaration;

		// Token: 0x040000B2 RID: 178
		private NamespaceResolver.NamespaceDeclaration _rover;

		// Token: 0x0200002B RID: 43
		private class NamespaceDeclaration
		{
			// Token: 0x040000B3 RID: 179
			public string prefix;

			// Token: 0x040000B4 RID: 180
			public XNamespace ns;

			// Token: 0x040000B5 RID: 181
			public int scope;

			// Token: 0x040000B6 RID: 182
			public NamespaceResolver.NamespaceDeclaration prev;
		}
	}
}
