using System;
using System.Collections.Generic;

namespace System.Xml.Schema
{
	// Token: 0x020002B0 RID: 688
	internal abstract class SchemaDeclBase
	{
		// Token: 0x06001631 RID: 5681 RVA: 0x0008A154 File Offset: 0x00088354
		protected SchemaDeclBase(XmlQualifiedName name, string prefix)
		{
			this.name = name;
			this.prefix = prefix;
			this.maxLength = -1L;
			this.minLength = -1L;
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x0008A185 File Offset: 0x00088385
		protected SchemaDeclBase()
		{
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x0008A198 File Offset: 0x00088398
		// (set) Token: 0x06001634 RID: 5684 RVA: 0x0008A1A0 File Offset: 0x000883A0
		internal XmlQualifiedName Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x0008A1A9 File Offset: 0x000883A9
		// (set) Token: 0x06001636 RID: 5686 RVA: 0x0008A1BF File Offset: 0x000883BF
		internal string Prefix
		{
			get
			{
				if (this.prefix != null)
				{
					return this.prefix;
				}
				return string.Empty;
			}
			set
			{
				this.prefix = value;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001637 RID: 5687 RVA: 0x0008A1C8 File Offset: 0x000883C8
		// (set) Token: 0x06001638 RID: 5688 RVA: 0x0008A1D0 File Offset: 0x000883D0
		internal bool IsDeclaredInExternal
		{
			get
			{
				return this.isDeclaredInExternal;
			}
			set
			{
				this.isDeclaredInExternal = value;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x0008A1D9 File Offset: 0x000883D9
		// (set) Token: 0x0600163A RID: 5690 RVA: 0x0008A1E1 File Offset: 0x000883E1
		internal SchemaDeclBase.Use Presence
		{
			get
			{
				return this.presence;
			}
			set
			{
				this.presence = value;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x0008A1EA File Offset: 0x000883EA
		// (set) Token: 0x0600163C RID: 5692 RVA: 0x0008A1F2 File Offset: 0x000883F2
		internal long MaxLength
		{
			get
			{
				return this.maxLength;
			}
			set
			{
				this.maxLength = value;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x0008A1FB File Offset: 0x000883FB
		// (set) Token: 0x0600163E RID: 5694 RVA: 0x0008A203 File Offset: 0x00088403
		internal long MinLength
		{
			get
			{
				return this.minLength;
			}
			set
			{
				this.minLength = value;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x0600163F RID: 5695 RVA: 0x0008A20C File Offset: 0x0008840C
		// (set) Token: 0x06001640 RID: 5696 RVA: 0x0008A214 File Offset: 0x00088414
		internal XmlSchemaType SchemaType
		{
			get
			{
				return this.schemaType;
			}
			set
			{
				this.schemaType = value;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001641 RID: 5697 RVA: 0x0008A21D File Offset: 0x0008841D
		// (set) Token: 0x06001642 RID: 5698 RVA: 0x0008A225 File Offset: 0x00088425
		internal XmlSchemaDatatype Datatype
		{
			get
			{
				return this.datatype;
			}
			set
			{
				this.datatype = value;
			}
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0008A22E File Offset: 0x0008842E
		internal void AddValue(string value)
		{
			if (this.values == null)
			{
				this.values = new List<string>();
			}
			this.values.Add(value);
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x0008A24F File Offset: 0x0008844F
		// (set) Token: 0x06001645 RID: 5701 RVA: 0x0008A257 File Offset: 0x00088457
		internal List<string> Values
		{
			get
			{
				return this.values;
			}
			set
			{
				this.values = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x0008A260 File Offset: 0x00088460
		// (set) Token: 0x06001647 RID: 5703 RVA: 0x0008A276 File Offset: 0x00088476
		internal string DefaultValueRaw
		{
			get
			{
				if (this.defaultValueRaw == null)
				{
					return string.Empty;
				}
				return this.defaultValueRaw;
			}
			set
			{
				this.defaultValueRaw = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x0008A27F File Offset: 0x0008847F
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x0008A287 File Offset: 0x00088487
		internal object DefaultValueTyped
		{
			get
			{
				return this.defaultValueTyped;
			}
			set
			{
				this.defaultValueTyped = value;
			}
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x0008A290 File Offset: 0x00088490
		internal bool CheckEnumeration(object pVal)
		{
			return (this.datatype.TokenizedType != XmlTokenizedType.NOTATION && this.datatype.TokenizedType != XmlTokenizedType.ENUMERATION) || this.values.Contains(pVal.ToString());
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0008A2C2 File Offset: 0x000884C2
		internal bool CheckValue(object pVal)
		{
			return (this.presence != SchemaDeclBase.Use.Fixed && this.presence != SchemaDeclBase.Use.RequiredFixed) || (this.defaultValueTyped != null && this.datatype.IsEqual(pVal, this.defaultValueTyped));
		}

		// Token: 0x04000E22 RID: 3618
		protected XmlQualifiedName name = XmlQualifiedName.Empty;

		// Token: 0x04000E23 RID: 3619
		protected string prefix;

		// Token: 0x04000E24 RID: 3620
		protected bool isDeclaredInExternal;

		// Token: 0x04000E25 RID: 3621
		protected SchemaDeclBase.Use presence;

		// Token: 0x04000E26 RID: 3622
		protected XmlSchemaType schemaType;

		// Token: 0x04000E27 RID: 3623
		protected XmlSchemaDatatype datatype;

		// Token: 0x04000E28 RID: 3624
		protected string defaultValueRaw;

		// Token: 0x04000E29 RID: 3625
		protected object defaultValueTyped;

		// Token: 0x04000E2A RID: 3626
		protected long maxLength;

		// Token: 0x04000E2B RID: 3627
		protected long minLength;

		// Token: 0x04000E2C RID: 3628
		protected List<string> values;

		// Token: 0x020002B1 RID: 689
		internal enum Use
		{
			// Token: 0x04000E2E RID: 3630
			Default,
			// Token: 0x04000E2F RID: 3631
			Required,
			// Token: 0x04000E30 RID: 3632
			Implied,
			// Token: 0x04000E31 RID: 3633
			Fixed,
			// Token: 0x04000E32 RID: 3634
			RequiredFixed
		}
	}
}
