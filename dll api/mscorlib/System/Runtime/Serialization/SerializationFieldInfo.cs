using System;
using System.Globalization;
using System.Reflection;
using System.Security;

namespace System.Runtime.Serialization
{
	// Token: 0x020003B5 RID: 949
	internal sealed class SerializationFieldInfo : FieldInfo
	{
		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x0007BE54 File Offset: 0x0007A054
		public override Module Module
		{
			get
			{
				return this.m_field.Module;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x0007BE61 File Offset: 0x0007A061
		public override int MetadataToken
		{
			get
			{
				return this.m_field.MetadataToken;
			}
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x0007BE6E File Offset: 0x0007A06E
		internal SerializationFieldInfo(RuntimeFieldInfo field, string namePrefix)
		{
			this.m_field = field;
			this.m_serializationName = namePrefix + "+" + this.m_field.Name;
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x0007BE99 File Offset: 0x0007A099
		public override string Name
		{
			get
			{
				return this.m_serializationName;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x0007BEA1 File Offset: 0x0007A0A1
		public override Type DeclaringType
		{
			get
			{
				return this.m_field.DeclaringType;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001D47 RID: 7495 RVA: 0x0007BEAE File Offset: 0x0007A0AE
		public override Type ReflectedType
		{
			get
			{
				return this.m_field.ReflectedType;
			}
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x0007BEBB File Offset: 0x0007A0BB
		public override object[] GetCustomAttributes(bool inherit)
		{
			return this.m_field.GetCustomAttributes(inherit);
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x0007BEC9 File Offset: 0x0007A0C9
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return this.m_field.GetCustomAttributes(attributeType, inherit);
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x0007BED8 File Offset: 0x0007A0D8
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return this.m_field.IsDefined(attributeType, inherit);
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001D4B RID: 7499 RVA: 0x0007BEE7 File Offset: 0x0007A0E7
		public override Type FieldType
		{
			get
			{
				return this.m_field.FieldType;
			}
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x0007BEF4 File Offset: 0x0007A0F4
		public override object GetValue(object obj)
		{
			return this.m_field.GetValue(obj);
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x0007BF04 File Offset: 0x0007A104
		[SecurityCritical]
		internal object InternalGetValue(object obj)
		{
			RtFieldInfo field = this.m_field;
			if (field != null)
			{
				field.CheckConsistency(obj);
				return field.UnsafeGetValue(obj);
			}
			return this.m_field.GetValue(obj);
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x0007BF3C File Offset: 0x0007A13C
		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
			this.m_field.SetValue(obj, value, invokeAttr, binder, culture);
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x0007BF50 File Offset: 0x0007A150
		[SecurityCritical]
		internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
			RtFieldInfo field = this.m_field;
			if (field != null)
			{
				field.CheckConsistency(obj);
				field.UnsafeSetValue(obj, value, invokeAttr, binder, culture);
				return;
			}
			this.m_field.SetValue(obj, value, invokeAttr, binder, culture);
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x0007BF94 File Offset: 0x0007A194
		internal RuntimeFieldInfo FieldInfo
		{
			get
			{
				return this.m_field;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x0007BF9C File Offset: 0x0007A19C
		public override RuntimeFieldHandle FieldHandle
		{
			get
			{
				return this.m_field.FieldHandle;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x0007BFA9 File Offset: 0x0007A1A9
		public override FieldAttributes Attributes
		{
			get
			{
				return this.m_field.Attributes;
			}
		}

		// Token: 0x04000C41 RID: 3137
		private RuntimeFieldInfo m_field;

		// Token: 0x04000C42 RID: 3138
		private string m_serializationName;
	}
}
