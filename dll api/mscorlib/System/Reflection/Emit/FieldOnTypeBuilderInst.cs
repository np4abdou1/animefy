using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020004FE RID: 1278
	[StructLayout(0)]
	internal class FieldOnTypeBuilderInst : FieldInfo
	{
		// Token: 0x06002504 RID: 9476 RVA: 0x00090970 File Offset: 0x0008EB70
		public FieldOnTypeBuilderInst(TypeBuilderInstantiation instantiation, FieldInfo fb)
		{
			this.instantiation = instantiation;
			this.fb = fb;
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06002505 RID: 9477 RVA: 0x00090986 File Offset: 0x0008EB86
		public override Type DeclaringType
		{
			get
			{
				return this.instantiation;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06002506 RID: 9478 RVA: 0x0009098E File Offset: 0x0008EB8E
		public override string Name
		{
			get
			{
				return this.fb.Name;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06002507 RID: 9479 RVA: 0x00090986 File Offset: 0x0008EB86
		public override Type ReflectedType
		{
			get
			{
				return this.instantiation;
			}
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x0009099B File Offset: 0x0008EB9B
		public override string ToString()
		{
			return this.fb.FieldType.ToString() + " " + this.Name;
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x0600250C RID: 9484 RVA: 0x000909BD File Offset: 0x0008EBBD
		public override FieldAttributes Attributes
		{
			get
			{
				return this.fb.Attributes;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x0600250D RID: 9485 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override RuntimeFieldHandle FieldHandle
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x0600250E RID: 9486 RVA: 0x0008A04D File Offset: 0x0008824D
		public override int MetadataToken
		{
			get
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override Type FieldType
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override object GetValue(object obj)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x000909CA File Offset: 0x0008EBCA
		internal FieldInfo RuntimeResolve()
		{
			return this.instantiation.RuntimeResolve().GetField(this.fb);
		}

		// Token: 0x04001224 RID: 4644
		internal TypeBuilderInstantiation instantiation;

		// Token: 0x04001225 RID: 4645
		internal FieldInfo fb;
	}
}
