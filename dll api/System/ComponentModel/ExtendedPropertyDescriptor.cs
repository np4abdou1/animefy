using System;
using System.Collections.Generic;

namespace System.ComponentModel
{
	// Token: 0x02000265 RID: 613
	internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x0600106E RID: 4206 RVA: 0x000500C4 File Offset: 0x0004E2C4
		public ExtendedPropertyDescriptor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) : base(extenderInfo, attributes)
		{
			List<Attribute> list = new List<Attribute>(this.AttributeArray);
			list.Add(ExtenderProvidedPropertyAttribute.Create(extenderInfo, receiverType, provider));
			if (extenderInfo.IsReadOnly)
			{
				list.Add(ReadOnlyAttribute.Yes);
			}
			Attribute[] array = new Attribute[list.Count];
			list.CopyTo(array, 0);
			this.AttributeArray = array;
			this._extenderInfo = extenderInfo;
			this._provider = provider;
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x00050130 File Offset: 0x0004E330
		public override bool CanResetValue(object comp)
		{
			return this._extenderInfo.ExtenderCanResetValue(this._provider, comp);
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x00050144 File Offset: 0x0004E344
		public override Type ComponentType
		{
			get
			{
				return this._extenderInfo.ComponentType;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x00050151 File Offset: 0x0004E351
		public override bool IsReadOnly
		{
			get
			{
				return this.Attributes[typeof(ReadOnlyAttribute)].Equals(ReadOnlyAttribute.Yes);
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x00050172 File Offset: 0x0004E372
		public override Type PropertyType
		{
			get
			{
				return this._extenderInfo.ExtenderGetType(this._provider);
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x00050188 File Offset: 0x0004E388
		public override string DisplayName
		{
			get
			{
				string text = base.DisplayName;
				DisplayNameAttribute displayNameAttribute = this.Attributes[typeof(DisplayNameAttribute)] as DisplayNameAttribute;
				if (displayNameAttribute == null || displayNameAttribute.IsDefaultAttribute())
				{
					ISite site = MemberDescriptor.GetSite(this._provider);
					string text2 = (site != null) ? site.Name : null;
					if (text2 != null && text2.Length > 0)
					{
						text = string.Format("{0} on {1}", text, text2);
					}
				}
				return text;
			}
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x000501F4 File Offset: 0x0004E3F4
		public override object GetValue(object comp)
		{
			return this._extenderInfo.ExtenderGetValue(this._provider, comp);
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00050208 File Offset: 0x0004E408
		public override void ResetValue(object comp)
		{
			this._extenderInfo.ExtenderResetValue(this._provider, comp, this);
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0005021D File Offset: 0x0004E41D
		public override void SetValue(object component, object value)
		{
			this._extenderInfo.ExtenderSetValue(this._provider, component, value, this);
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00050233 File Offset: 0x0004E433
		public override bool ShouldSerializeValue(object comp)
		{
			return this._extenderInfo.ExtenderShouldSerializeValue(this._provider, comp);
		}

		// Token: 0x04000C57 RID: 3159
		private readonly ReflectPropertyDescriptor _extenderInfo;

		// Token: 0x04000C58 RID: 3160
		private readonly IExtenderProvider _provider;
	}
}
