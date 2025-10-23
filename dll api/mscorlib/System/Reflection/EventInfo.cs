using System;
using System.Runtime.CompilerServices;
using Mono;

namespace System.Reflection
{
	/// <summary>Discovers the attributes of an event and provides access to event metadata.</summary>
	// Token: 0x02000498 RID: 1176
	[Serializable]
	public abstract class EventInfo : MemberInfo
	{
		/// <summary>Gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is an event.</summary>
		/// <returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is an event.</returns>
		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060020E7 RID: 8423 RVA: 0x0000E0F3 File Offset: 0x0000C2F3
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Event;
			}
		}

		/// <summary>Returns the method used to add an event handler delegate to the event source.</summary>
		/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the method used to add an event handler delegate to the event source.</returns>
		// Token: 0x060020E8 RID: 8424 RVA: 0x00089B9C File Offset: 0x00087D9C
		public MethodInfo GetAddMethod()
		{
			return this.GetAddMethod(false);
		}

		/// <summary>Returns the method used to remove an event handler delegate from the event source.</summary>
		/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the method used to remove an event handler delegate from the event source.</returns>
		// Token: 0x060020E9 RID: 8425 RVA: 0x00089BA5 File Offset: 0x00087DA5
		public MethodInfo GetRemoveMethod()
		{
			return this.GetRemoveMethod(false);
		}

		/// <summary>When overridden in a derived class, retrieves the <see langword="MethodInfo" /> object for the <see cref="M:System.Reflection.EventInfo.AddEventHandler(System.Object,System.Delegate)" /> method of the event, specifying whether to return non-public methods.</summary>
		/// <param name="nonPublic">
		///       <see langword="true" /> if non-public methods can be returned; otherwise, <see langword="false" />. </param>
		/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the method used to add an event handler delegate to the event source.</returns>
		/// <exception cref="T:System.MethodAccessException">
		///         <paramref name="nonPublic" /> is <see langword="true" />, the method used to add an event handler delegate is non-public, and the caller does not have permission to reflect on non-public methods. </exception>
		// Token: 0x060020EA RID: 8426
		public abstract MethodInfo GetAddMethod(bool nonPublic);

		/// <summary>When overridden in a derived class, retrieves the <see langword="MethodInfo" /> object for removing a method of the event, specifying whether to return non-public methods.</summary>
		/// <param name="nonPublic">
		///       <see langword="true" /> if non-public methods can be returned; otherwise, <see langword="false" />. </param>
		/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the method used to remove an event handler delegate from the event source.</returns>
		/// <exception cref="T:System.MethodAccessException">
		///         <paramref name="nonPublic" /> is <see langword="true" />, the method used to add an event handler delegate is non-public, and the caller does not have permission to reflect on non-public methods. </exception>
		// Token: 0x060020EB RID: 8427
		public abstract MethodInfo GetRemoveMethod(bool nonPublic);

		/// <summary>When overridden in a derived class, returns the method that is called when the event is raised, specifying whether to return non-public methods.</summary>
		/// <param name="nonPublic">
		///       <see langword="true" /> if non-public methods can be returned; otherwise, <see langword="false" />. </param>
		/// <returns>A <see langword="MethodInfo" /> object that was called when the event was raised.</returns>
		/// <exception cref="T:System.MethodAccessException">
		///         <paramref name="nonPublic" /> is <see langword="true" />, the method used to add an event handler delegate is non-public, and the caller does not have permission to reflect on non-public methods. </exception>
		// Token: 0x060020EC RID: 8428
		public abstract MethodInfo GetRaiseMethod(bool nonPublic);

		/// <summary>Gets the <see langword="Type" /> object of the underlying event-handler delegate associated with this event.</summary>
		/// <returns>A read-only <see langword="Type" /> object representing the delegate event handler.</returns>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060020ED RID: 8429 RVA: 0x00089BB0 File Offset: 0x00087DB0
		public virtual Type EventHandlerType
		{
			get
			{
				ParameterInfo[] parametersInternal = this.GetAddMethod(true).GetParametersInternal();
				Type typeFromHandle = typeof(Delegate);
				for (int i = 0; i < parametersInternal.Length; i++)
				{
					Type parameterType = parametersInternal[i].ParameterType;
					if (parameterType.IsSubclassOf(typeFromHandle))
					{
						return parameterType;
					}
				}
				return null;
			}
		}

		/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An object to compare with this instance, or <see langword="null" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> equals the type and value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x060020EE RID: 8430 RVA: 0x00089BF8 File Offset: 0x00087DF8
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x060020EF RID: 8431 RVA: 0x00089C01 File Offset: 0x00087E01
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.EventInfo" /> objects are equal.</summary>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060020F0 RID: 8432 RVA: 0x0003F3D8 File Offset: 0x0003D5D8
		public static bool operator ==(EventInfo left, EventInfo right)
		{
			return left == right || (left != null && right != null && left.Equals(right));
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.EventInfo" /> objects are not equal.</summary>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060020F1 RID: 8433 RVA: 0x00089C09 File Offset: 0x00087E09
		public static bool operator !=(EventInfo left, EventInfo right)
		{
			return !(left == right);
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x00089C18 File Offset: 0x00087E18
		private static void AddEventFrame<T, D>(EventInfo.AddEvent<T, D> addEvent, object obj, object dele)
		{
			if (obj == null)
			{
				throw new TargetException("Cannot add a handler to a non static event with a null target");
			}
			if (!(obj is T))
			{
				throw new TargetException("Object doesn't match target");
			}
			if (!(dele is D))
			{
				throw new ArgumentException(string.Format("Object of type {0} cannot be converted to type {1}.", dele.GetType(), typeof(D)));
			}
			addEvent((T)((object)obj), (D)((object)dele));
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00089C80 File Offset: 0x00087E80
		private static void StaticAddEventAdapterFrame<D>(EventInfo.StaticAddEvent<D> addEvent, object obj, object dele)
		{
			addEvent((D)((object)dele));
		}

		// Token: 0x060020F4 RID: 8436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle);

		// Token: 0x060020F5 RID: 8437 RVA: 0x00089C90 File Offset: 0x00087E90
		internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType)
		{
			if (handle.Value == IntPtr.Zero)
			{
				throw new ArgumentException("The handle is invalid.");
			}
			EventInfo eventInfo = EventInfo.internal_from_handle_type(handle.Value, reflectedType.Value);
			if (eventInfo == null)
			{
				throw new ArgumentException("The event handle and the type handle are incompatible.");
			}
			return eventInfo;
		}

		// Token: 0x04000FCF RID: 4047
		private EventInfo.AddEventAdapter cached_add_event;

		// Token: 0x02000499 RID: 1177
		// (Invoke) Token: 0x060020F7 RID: 8439
		private delegate void AddEventAdapter(object _this, Delegate dele);

		// Token: 0x0200049A RID: 1178
		// (Invoke) Token: 0x060020FB RID: 8443
		private delegate void AddEvent<T, D>(T _this, D dele);

		// Token: 0x0200049B RID: 1179
		// (Invoke) Token: 0x060020FF RID: 8447
		private delegate void StaticAddEvent<D>(D dele);
	}
}
