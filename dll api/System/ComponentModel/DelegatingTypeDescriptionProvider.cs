using System;
using System.Collections;

namespace System.ComponentModel
{
	// Token: 0x0200025C RID: 604
	internal sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider
	{
		// Token: 0x06001027 RID: 4135 RVA: 0x0004F8E7 File Offset: 0x0004DAE7
		internal DelegatingTypeDescriptionProvider(Type type)
		{
			this._type = type;
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x0004F8F6 File Offset: 0x0004DAF6
		internal TypeDescriptionProvider Provider
		{
			get
			{
				return TypeDescriptor.GetProviderRecursive(this._type);
			}
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0004F903 File Offset: 0x0004DB03
		public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			return this.Provider.CreateInstance(provider, objectType, argTypes, args);
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0004F915 File Offset: 0x0004DB15
		public override IDictionary GetCache(object instance)
		{
			return this.Provider.GetCache(instance);
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0004F923 File Offset: 0x0004DB23
		public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
		{
			return this.Provider.GetExtendedTypeDescriptor(instance);
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0004F931 File Offset: 0x0004DB31
		protected internal override IExtenderProvider[] GetExtenderProviders(object instance)
		{
			return this.Provider.GetExtenderProviders(instance);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0004F93F File Offset: 0x0004DB3F
		public override Type GetReflectionType(Type objectType, object instance)
		{
			return this.Provider.GetReflectionType(objectType, instance);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0004F94E File Offset: 0x0004DB4E
		public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
		{
			return this.Provider.GetTypeDescriptor(objectType, instance);
		}

		// Token: 0x04000C42 RID: 3138
		private readonly Type _type;
	}
}
