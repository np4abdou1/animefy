using System;

namespace System.ComponentModel
{
	/// <summary>Specifies a property that is offered by an extender provider. This class cannot be inherited.</summary>
	// Token: 0x02000266 RID: 614
	[AttributeUsage(AttributeTargets.All)]
	public sealed class ExtenderProvidedPropertyAttribute : Attribute
	{
		// Token: 0x06001078 RID: 4216 RVA: 0x00050247 File Offset: 0x0004E447
		internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider)
		{
			return new ExtenderProvidedPropertyAttribute
			{
				ExtenderProperty = extenderProperty,
				ReceiverType = receiverType,
				Provider = provider
			};
		}

		/// <summary>Gets the property that is being provided.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptor" /> encapsulating the property that is being provided.</returns>
		// Token: 0x17000350 RID: 848
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x00050263 File Offset: 0x0004E463
		// (set) Token: 0x0600107B RID: 4219 RVA: 0x0005026B File Offset: 0x0004E46B
		public PropertyDescriptor ExtenderProperty { get; private set; }

		/// <summary>Gets the extender provider that is providing the property.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.IExtenderProvider" /> that is providing the property.</returns>
		// Token: 0x17000351 RID: 849
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x00050274 File Offset: 0x0004E474
		// (set) Token: 0x0600107D RID: 4221 RVA: 0x0005027C File Offset: 0x0004E47C
		public IExtenderProvider Provider { get; private set; }

		/// <summary>Gets the type of object that can receive the property.</summary>
		/// <returns>A <see cref="T:System.Type" /> describing the type of object that can receive the property.</returns>
		// Token: 0x17000352 RID: 850
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x00050285 File Offset: 0x0004E485
		// (set) Token: 0x0600107F RID: 4223 RVA: 0x0005028D File Offset: 0x0004E48D
		public Type ReceiverType { get; private set; }

		/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An <see cref="T:System.Object" /> to compare with this instance or a null reference (<see langword="Nothing" /> in Visual Basic).</param>
		/// <returns>
		///   <see langword="true" /> if <paramref name="obj" /> equals the type and value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001080 RID: 4224 RVA: 0x00050298 File Offset: 0x0004E498
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			ExtenderProvidedPropertyAttribute extenderProvidedPropertyAttribute = obj as ExtenderProvidedPropertyAttribute;
			return extenderProvidedPropertyAttribute != null && extenderProvidedPropertyAttribute.ExtenderProperty.Equals(this.ExtenderProperty) && extenderProvidedPropertyAttribute.Provider.Equals(this.Provider) && extenderProvidedPropertyAttribute.ReceiverType.Equals(this.ReceiverType);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06001081 RID: 4225 RVA: 0x0004CFC2 File Offset: 0x0004B1C2
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Provides an indication whether the value of this instance is the default value for the derived class.</summary>
		/// <returns>
		///     <see langword="true" /> if this instance is the default attribute for the class; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001082 RID: 4226 RVA: 0x000502EE File Offset: 0x0004E4EE
		public override bool IsDefaultAttribute()
		{
			return this.ReceiverType == null;
		}
	}
}
