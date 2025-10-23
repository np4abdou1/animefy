using System;
using System.Globalization;

namespace System.Xml.Schema
{
	// Token: 0x02000231 RID: 561
	internal class TypedObject
	{
		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x000714AA File Offset: 0x0006F6AA
		public int Dim
		{
			get
			{
				return this.dim;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x000714B2 File Offset: 0x0006F6B2
		public bool IsList
		{
			get
			{
				return this.isList;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x000714BA File Offset: 0x0006F6BA
		public bool IsDecimal
		{
			get
			{
				return this.dstruct.IsDecimal;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x000714C7 File Offset: 0x0006F6C7
		public decimal[] Dvalue
		{
			get
			{
				return this.dstruct.Dvalue;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x000714D4 File Offset: 0x0006F6D4
		public object Value
		{
			get
			{
				return this.ovalue;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x000714DC File Offset: 0x0006F6DC
		public XmlSchemaDatatype Type
		{
			get
			{
				return this.xsdtype;
			}
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x000714E4 File Offset: 0x0006F6E4
		public TypedObject(object obj, string svalue, XmlSchemaDatatype xsdtype)
		{
			this.ovalue = obj;
			this.svalue = svalue;
			this.xsdtype = xsdtype;
			if (xsdtype.Variety == XmlSchemaDatatypeVariety.List || xsdtype is Datatype_base64Binary || xsdtype is Datatype_hexBinary)
			{
				this.isList = true;
				this.dim = ((Array)obj).Length;
			}
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00071544 File Offset: 0x0006F744
		public override string ToString()
		{
			return this.svalue;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x0007154C File Offset: 0x0006F74C
		public void SetDecimal()
		{
			if (this.dstruct != null)
			{
				return;
			}
			XmlTypeCode typeCode = this.xsdtype.TypeCode;
			if (typeCode == XmlTypeCode.Decimal || typeCode - XmlTypeCode.Integer <= 12)
			{
				if (this.isList)
				{
					this.dstruct = new TypedObject.DecimalStruct(this.dim);
					for (int i = 0; i < this.dim; i++)
					{
						this.dstruct.Dvalue[i] = Convert.ToDecimal(((Array)this.ovalue).GetValue(i), NumberFormatInfo.InvariantInfo);
					}
				}
				else
				{
					this.dstruct = new TypedObject.DecimalStruct();
					this.dstruct.Dvalue[0] = Convert.ToDecimal(this.ovalue, NumberFormatInfo.InvariantInfo);
				}
				this.dstruct.IsDecimal = true;
				return;
			}
			if (this.isList)
			{
				this.dstruct = new TypedObject.DecimalStruct(this.dim);
				return;
			}
			this.dstruct = new TypedObject.DecimalStruct();
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00071634 File Offset: 0x0006F834
		private bool ListDValueEquals(TypedObject other)
		{
			for (int i = 0; i < this.Dim; i++)
			{
				if (this.Dvalue[i] != other.Dvalue[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00071674 File Offset: 0x0006F874
		public bool Equals(TypedObject other)
		{
			if (this.Dim != other.Dim)
			{
				return false;
			}
			if (this.Type != other.Type)
			{
				if (!this.Type.IsComparable(other.Type))
				{
					return false;
				}
				other.SetDecimal();
				this.SetDecimal();
				if (this.IsDecimal && other.IsDecimal)
				{
					return this.ListDValueEquals(other);
				}
			}
			if (this.IsList)
			{
				if (other.IsList)
				{
					return this.Type.Compare(this.Value, other.Value) == 0;
				}
				Array array = this.Value as Array;
				XmlAtomicValue[] array2 = array as XmlAtomicValue[];
				if (array2 != null)
				{
					return array2.Length == 1 && array2.GetValue(0).Equals(other.Value);
				}
				return array.Length == 1 && array.GetValue(0).Equals(other.Value);
			}
			else
			{
				if (!other.IsList)
				{
					return this.Value.Equals(other.Value);
				}
				Array array3 = other.Value as Array;
				XmlAtomicValue[] array4 = array3 as XmlAtomicValue[];
				if (array4 != null)
				{
					return array4.Length == 1 && array4.GetValue(0).Equals(this.Value);
				}
				return array3.Length == 1 && array3.GetValue(0).Equals(this.Value);
			}
		}

		// Token: 0x04000C82 RID: 3202
		private TypedObject.DecimalStruct dstruct;

		// Token: 0x04000C83 RID: 3203
		private object ovalue;

		// Token: 0x04000C84 RID: 3204
		private string svalue;

		// Token: 0x04000C85 RID: 3205
		private XmlSchemaDatatype xsdtype;

		// Token: 0x04000C86 RID: 3206
		private int dim = 1;

		// Token: 0x04000C87 RID: 3207
		private bool isList;

		// Token: 0x02000232 RID: 562
		private class DecimalStruct
		{
			// Token: 0x170003D7 RID: 983
			// (get) Token: 0x06001284 RID: 4740 RVA: 0x000717BA File Offset: 0x0006F9BA
			// (set) Token: 0x06001285 RID: 4741 RVA: 0x000717C2 File Offset: 0x0006F9C2
			public bool IsDecimal
			{
				get
				{
					return this.isDecimal;
				}
				set
				{
					this.isDecimal = value;
				}
			}

			// Token: 0x170003D8 RID: 984
			// (get) Token: 0x06001286 RID: 4742 RVA: 0x000717CB File Offset: 0x0006F9CB
			public decimal[] Dvalue
			{
				get
				{
					return this.dvalue;
				}
			}

			// Token: 0x06001287 RID: 4743 RVA: 0x000717D3 File Offset: 0x0006F9D3
			public DecimalStruct()
			{
				this.dvalue = new decimal[1];
			}

			// Token: 0x06001288 RID: 4744 RVA: 0x000717E7 File Offset: 0x0006F9E7
			public DecimalStruct(int dim)
			{
				this.dvalue = new decimal[dim];
			}

			// Token: 0x04000C88 RID: 3208
			private bool isDecimal;

			// Token: 0x04000C89 RID: 3209
			private decimal[] dvalue;
		}
	}
}
