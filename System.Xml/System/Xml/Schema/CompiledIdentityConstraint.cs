using System;

namespace System.Xml.Schema
{
	// Token: 0x0200022B RID: 555
	internal class CompiledIdentityConstraint
	{
		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x000710FD File Offset: 0x0006F2FD
		public CompiledIdentityConstraint.ConstraintRole Role
		{
			get
			{
				return this.role;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x00071105 File Offset: 0x0006F305
		public Asttree Selector
		{
			get
			{
				return this.selector;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x0007110D File Offset: 0x0006F30D
		public Asttree[] Fields
		{
			get
			{
				return this.fields;
			}
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00071115 File Offset: 0x0006F315
		private CompiledIdentityConstraint()
		{
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00071134 File Offset: 0x0006F334
		public CompiledIdentityConstraint(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr)
		{
			this.name = constraint.QualifiedName;
			try
			{
				this.selector = new Asttree(constraint.Selector.XPath, false, nsmgr);
			}
			catch (XmlSchemaException ex)
			{
				ex.SetSource(constraint.Selector);
				throw ex;
			}
			XmlSchemaObjectCollection xmlSchemaObjectCollection = constraint.Fields;
			this.fields = new Asttree[xmlSchemaObjectCollection.Count];
			for (int i = 0; i < xmlSchemaObjectCollection.Count; i++)
			{
				try
				{
					this.fields[i] = new Asttree(((XmlSchemaXPath)xmlSchemaObjectCollection[i]).XPath, true, nsmgr);
				}
				catch (XmlSchemaException ex2)
				{
					ex2.SetSource(constraint.Fields[i]);
					throw ex2;
				}
			}
			if (constraint is XmlSchemaUnique)
			{
				this.role = CompiledIdentityConstraint.ConstraintRole.Unique;
				return;
			}
			if (constraint is XmlSchemaKey)
			{
				this.role = CompiledIdentityConstraint.ConstraintRole.Key;
				return;
			}
			this.role = CompiledIdentityConstraint.ConstraintRole.Keyref;
			this.refer = ((XmlSchemaKeyref)constraint).Refer;
		}

		// Token: 0x04000C69 RID: 3177
		internal XmlQualifiedName name = XmlQualifiedName.Empty;

		// Token: 0x04000C6A RID: 3178
		private CompiledIdentityConstraint.ConstraintRole role;

		// Token: 0x04000C6B RID: 3179
		private Asttree selector;

		// Token: 0x04000C6C RID: 3180
		private Asttree[] fields;

		// Token: 0x04000C6D RID: 3181
		internal XmlQualifiedName refer = XmlQualifiedName.Empty;

		// Token: 0x04000C6E RID: 3182
		public static readonly CompiledIdentityConstraint Empty = new CompiledIdentityConstraint();

		// Token: 0x0200022C RID: 556
		public enum ConstraintRole
		{
			// Token: 0x04000C70 RID: 3184
			Unique,
			// Token: 0x04000C71 RID: 3185
			Key,
			// Token: 0x04000C72 RID: 3186
			Keyref
		}
	}
}
