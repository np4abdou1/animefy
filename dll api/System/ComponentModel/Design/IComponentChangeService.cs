using System;

namespace System.ComponentModel.Design
{
	/// <summary>Provides an interface to add and remove the event handlers for events that add, change, remove or rename components, and provides methods to raise a <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentChanged" /> or <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentChanging" /> event.</summary>
	// Token: 0x020002B6 RID: 694
	public interface IComponentChangeService
	{
		/// <summary>Announces to the component change service that a particular component has changed.</summary>
		/// <param name="component">The component that has changed. </param>
		/// <param name="member">The member that has changed. This is <see langword="null" /> if this change is not related to a single member. </param>
		/// <param name="oldValue">The old value of the member. This is valid only if the member is not <see langword="null" />. </param>
		/// <param name="newValue">The new value of the member. This is valid only if the member is not <see langword="null" />. </param>
		// Token: 0x06001298 RID: 4760
		void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue);

		/// <summary>Announces to the component change service that a particular component is changing.</summary>
		/// <param name="component">The component that is about to change. </param>
		/// <param name="member">The member that is changing. This is <see langword="null" /> if this change is not related to a single member. </param>
		// Token: 0x06001299 RID: 4761
		void OnComponentChanging(object component, MemberDescriptor member);
	}
}
