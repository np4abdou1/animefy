using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Helps build custom attributes.</summary>
	// Token: 0x020004F3 RID: 1267
	[StructLayout(0)]
	public class CustomAttributeBuilder
	{
		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06002496 RID: 9366 RVA: 0x0008FDD7 File Offset: 0x0008DFD7
		internal ConstructorInfo Ctor
		{
			get
			{
				return this.ctor;
			}
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x0008FDE0 File Offset: 0x0008DFE0
		internal object Invoke()
		{
			object obj = this.ctor.Invoke(this.args);
			for (int i = 0; i < this.namedFields.Length; i++)
			{
				this.namedFields[i].SetValue(obj, this.fieldValues[i]);
			}
			for (int j = 0; j < this.namedProperties.Length; j++)
			{
				this.namedProperties[j].SetValue(obj, this.propertyValues[j]);
			}
			return obj;
		}

		// Token: 0x040011EE RID: 4590
		private ConstructorInfo ctor;

		// Token: 0x040011EF RID: 4591
		private byte[] data;

		// Token: 0x040011F0 RID: 4592
		private object[] args;

		// Token: 0x040011F1 RID: 4593
		private PropertyInfo[] namedProperties;

		// Token: 0x040011F2 RID: 4594
		private object[] propertyValues;

		// Token: 0x040011F3 RID: 4595
		private FieldInfo[] namedFields;

		// Token: 0x040011F4 RID: 4596
		private object[] fieldValues;
	}
}
