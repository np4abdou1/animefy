using System;
using System.Collections;

namespace System.ComponentModel
{
	/// <summary>Provides supplemental metadata to the <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
	// Token: 0x02000288 RID: 648
	public abstract class TypeDescriptionProvider
	{
		/// <summary>Creates an object that can substitute for another data type.</summary>
		/// <param name="provider">An optional service provider.</param>
		/// <param name="objectType">The type of object to create. This parameter is never <see langword="null" />.</param>
		/// <param name="argTypes">An optional array of types that represent the parameter types to be passed to the object's constructor. This array can be <see langword="null" /> or of zero length.</param>
		/// <param name="args">An optional array of parameter values to pass to the object's constructor.</param>
		/// <returns>The substitute <see cref="T:System.Object" />.</returns>
		// Token: 0x06001155 RID: 4437 RVA: 0x00051DDF File Offset: 0x0004FFDF
		public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			if (this._parent != null)
			{
				return this._parent.CreateInstance(provider, objectType, argTypes, args);
			}
			if (objectType == null)
			{
				throw new ArgumentNullException("objectType");
			}
			return Activator.CreateInstance(objectType, args);
		}

		/// <summary>Gets a per-object cache, accessed as an <see cref="T:System.Collections.IDictionary" /> of key/value pairs.</summary>
		/// <param name="instance">The object for which to get the cache.</param>
		/// <returns>An <see cref="T:System.Collections.IDictionary" /> if the provided object supports caching; otherwise, <see langword="null" />.</returns>
		// Token: 0x06001156 RID: 4438 RVA: 0x00051E16 File Offset: 0x00050016
		public virtual IDictionary GetCache(object instance)
		{
			TypeDescriptionProvider parent = this._parent;
			if (parent == null)
			{
				return null;
			}
			return parent.GetCache(instance);
		}

		/// <summary>Gets an extended custom type descriptor for the given object.</summary>
		/// <param name="instance">The object for which to get the extended type descriptor.</param>
		/// <returns>An <see cref="T:System.ComponentModel.ICustomTypeDescriptor" /> that can provide extended metadata for the object.</returns>
		// Token: 0x06001157 RID: 4439 RVA: 0x00051E2C File Offset: 0x0005002C
		public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
		{
			if (this._parent != null)
			{
				return this._parent.GetExtendedTypeDescriptor(instance);
			}
			TypeDescriptionProvider.EmptyCustomTypeDescriptor result;
			if ((result = this._emptyDescriptor) == null)
			{
				result = (this._emptyDescriptor = new TypeDescriptionProvider.EmptyCustomTypeDescriptor());
			}
			return result;
		}

		/// <summary>Gets the extender providers for the specified object.</summary>
		/// <param name="instance">The object to get extender providers for.</param>
		/// <returns>An array of extender providers for <paramref name="instance" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="instance" /> is <see langword="null" />.</exception>
		// Token: 0x06001158 RID: 4440 RVA: 0x00051E66 File Offset: 0x00050066
		protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance)
		{
			if (this._parent != null)
			{
				return this._parent.GetExtenderProviders(instance);
			}
			if (instance == null)
			{
				throw new ArgumentNullException("instance");
			}
			return Array.Empty<IExtenderProvider>();
		}

		/// <summary>Performs normal reflection against a type.</summary>
		/// <param name="objectType">The type of object for which to retrieve the <see cref="T:System.Reflection.IReflect" />.</param>
		/// <returns>The type of reflection for this <paramref name="objectType" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="objectType" /> is <see langword="null" />.</exception>
		// Token: 0x06001159 RID: 4441 RVA: 0x00051E90 File Offset: 0x00050090
		public Type GetReflectionType(Type objectType)
		{
			return this.GetReflectionType(objectType, null);
		}

		/// <summary>Performs normal reflection against the given object with the given type.</summary>
		/// <param name="objectType">The type of object for which to retrieve the <see cref="T:System.Reflection.IReflect" />.</param>
		/// <param name="instance">An instance of the type. Can be <see langword="null" />.</param>
		/// <returns>The type of reflection for this <paramref name="objectType" />.</returns>
		// Token: 0x0600115A RID: 4442 RVA: 0x00051E9A File Offset: 0x0005009A
		public virtual Type GetReflectionType(Type objectType, object instance)
		{
			if (this._parent != null)
			{
				return this._parent.GetReflectionType(objectType, instance);
			}
			return objectType;
		}

		/// <summary>Gets a custom type descriptor for the given type.</summary>
		/// <param name="objectType">The type of object for which to retrieve the type descriptor.</param>
		/// <returns>An <see cref="T:System.ComponentModel.ICustomTypeDescriptor" /> that can provide metadata for the type.</returns>
		// Token: 0x0600115B RID: 4443 RVA: 0x00051EB3 File Offset: 0x000500B3
		public ICustomTypeDescriptor GetTypeDescriptor(Type objectType)
		{
			return this.GetTypeDescriptor(objectType, null);
		}

		/// <summary>Gets a custom type descriptor for the given object.</summary>
		/// <param name="instance">An instance of the type. Can be <see langword="null" /> if no instance was passed to the <see cref="T:System.ComponentModel.TypeDescriptor" />.</param>
		/// <returns>An <see cref="T:System.ComponentModel.ICustomTypeDescriptor" /> that can provide metadata for the type.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="instance" /> is <see langword="null" />.</exception>
		// Token: 0x0600115C RID: 4444 RVA: 0x00051EBD File Offset: 0x000500BD
		public ICustomTypeDescriptor GetTypeDescriptor(object instance)
		{
			if (instance == null)
			{
				throw new ArgumentNullException("instance");
			}
			return this.GetTypeDescriptor(instance.GetType(), instance);
		}

		/// <summary>Gets a custom type descriptor for the given type and object.</summary>
		/// <param name="objectType">The type of object for which to retrieve the type descriptor.</param>
		/// <param name="instance">An instance of the type. Can be <see langword="null" /> if no instance was passed to the <see cref="T:System.ComponentModel.TypeDescriptor" />.</param>
		/// <returns>An <see cref="T:System.ComponentModel.ICustomTypeDescriptor" /> that can provide metadata for the type.</returns>
		// Token: 0x0600115D RID: 4445 RVA: 0x00051EDC File Offset: 0x000500DC
		public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
		{
			if (this._parent != null)
			{
				return this._parent.GetTypeDescriptor(objectType, instance);
			}
			TypeDescriptionProvider.EmptyCustomTypeDescriptor result;
			if ((result = this._emptyDescriptor) == null)
			{
				result = (this._emptyDescriptor = new TypeDescriptionProvider.EmptyCustomTypeDescriptor());
			}
			return result;
		}

		// Token: 0x04000C97 RID: 3223
		private readonly TypeDescriptionProvider _parent;

		// Token: 0x04000C98 RID: 3224
		private TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor;

		// Token: 0x02000289 RID: 649
		private sealed class EmptyCustomTypeDescriptor : CustomTypeDescriptor
		{
		}
	}
}
