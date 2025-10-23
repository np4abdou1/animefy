using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.ComponentModel
{
	/// <summary>Provides information about the characteristics for a component, such as its attributes, properties, and events. This class cannot be inherited.</summary>
	// Token: 0x020002A5 RID: 677
	public sealed class TypeDescriptor
	{
		/// <summary>Gets the type of the Component Object Model (COM) object represented by the target component.</summary>
		/// <returns>The <see cref="T:System.Type" /> of the COM object represented by this component, or <see langword="null" /> for non-COM objects.</returns>
		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x0005641D File Offset: 0x0005461D
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Type ComObjectType
		{
			get
			{
				return typeof(TypeDescriptor.TypeDescriptorComObject);
			}
		}

		/// <summary>Gets a type that represents a type description provider for all interface types. </summary>
		/// <returns>A <see cref="T:System.Type" /> that represents a custom type description provider for all interface types. </returns>
		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x00056429 File Offset: 0x00054629
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Type InterfaceType
		{
			get
			{
				return typeof(TypeDescriptor.TypeDescriptorInterface);
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x00056435 File Offset: 0x00054635
		internal static int MetadataVersion
		{
			get
			{
				return TypeDescriptor._metadataVersion;
			}
		}

		/// <summary>Adds a type description provider for a component class.</summary>
		/// <param name="provider">The <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> to add.</param>
		/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
		/// <exception cref="T:System.ArgumentNullException">One or both of the parameters are <see langword="null" />.</exception>
		// Token: 0x06001226 RID: 4646 RVA: 0x0005643C File Offset: 0x0005463C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static void AddProvider(TypeDescriptionProvider provider, Type type)
		{
			if (provider == null)
			{
				throw new ArgumentNullException("provider");
			}
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			WeakHashtable providerTable = TypeDescriptor._providerTable;
			lock (providerTable)
			{
				TypeDescriptor.TypeDescriptionNode next = TypeDescriptor.NodeFor(type, true);
				TypeDescriptor.TypeDescriptionNode typeDescriptionNode = new TypeDescriptor.TypeDescriptionNode(provider);
				typeDescriptionNode.Next = next;
				TypeDescriptor._providerTable[type] = typeDescriptionNode;
				TypeDescriptor._providerTypeTable.Clear();
			}
			TypeDescriptor.Refresh(type);
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x000564CC File Offset: 0x000546CC
		private static void CheckDefaultProvider(Type type)
		{
			object internalSyncObject;
			if (TypeDescriptor._defaultProviders == null)
			{
				internalSyncObject = TypeDescriptor._internalSyncObject;
				lock (internalSyncObject)
				{
					if (TypeDescriptor._defaultProviders == null)
					{
						TypeDescriptor._defaultProviders = new Hashtable();
					}
				}
			}
			if (TypeDescriptor._defaultProviders.ContainsKey(type))
			{
				return;
			}
			internalSyncObject = TypeDescriptor._internalSyncObject;
			lock (internalSyncObject)
			{
				if (TypeDescriptor._defaultProviders.ContainsKey(type))
				{
					return;
				}
				TypeDescriptor._defaultProviders[type] = null;
			}
			object[] customAttributes = type.GetCustomAttributes(typeof(TypeDescriptionProviderAttribute), false);
			bool flag2 = false;
			for (int i = customAttributes.Length - 1; i >= 0; i--)
			{
				Type type2 = Type.GetType(((TypeDescriptionProviderAttribute)customAttributes[i]).TypeName);
				if (type2 != null && typeof(TypeDescriptionProvider).IsAssignableFrom(type2))
				{
					TypeDescriptor.AddProvider((TypeDescriptionProvider)Activator.CreateInstance(type2), type);
					flag2 = true;
				}
			}
			if (!flag2)
			{
				Type baseType = type.BaseType;
				if (baseType != null && baseType != type)
				{
					TypeDescriptor.CheckDefaultProvider(baseType);
				}
			}
		}

		/// <summary>Creates an object that can substitute for another data type. </summary>
		/// <param name="provider">The service provider that provides a <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> service. This parameter can be <see langword="null" />.</param>
		/// <param name="objectType">The <see cref="T:System.Type" /> of object to create.</param>
		/// <param name="argTypes">An optional array of parameter types to be passed to the object's constructor. This parameter can be <see langword="null" /> or an array of zero length.</param>
		/// <param name="args">An optional array of parameter values to pass to the object's constructor. If not <see langword="null" />, the number of elements must be the same as <paramref name="argTypes" />. </param>
		/// <returns>An instance of the substitute data type if an associated <see cref="T:System.ComponentModel.TypeDescriptionProvider" /> is found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="objectType" /> is <see langword="null" />, or <paramref name="args" /> is <see langword="null" /> when <paramref name="argTypes" /> is not <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="argTypes" /> and <paramref name="args" /> have different number of elements.</exception>
		// Token: 0x06001228 RID: 4648 RVA: 0x00056614 File Offset: 0x00054814
		public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			if (objectType == null)
			{
				throw new ArgumentNullException("objectType");
			}
			if (argTypes != null)
			{
				if (args == null)
				{
					throw new ArgumentNullException("args");
				}
				if (argTypes.Length != args.Length)
				{
					throw new ArgumentException(SR.GetString("The number of elements in the Type and Object arrays must match."));
				}
			}
			object obj = null;
			if (provider != null)
			{
				TypeDescriptionProvider typeDescriptionProvider = provider.GetService(typeof(TypeDescriptionProvider)) as TypeDescriptionProvider;
				if (typeDescriptionProvider != null)
				{
					obj = typeDescriptionProvider.CreateInstance(provider, objectType, argTypes, args);
				}
			}
			if (obj == null)
			{
				obj = TypeDescriptor.NodeFor(objectType).CreateInstance(provider, objectType, argTypes, args);
			}
			return obj;
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0005669C File Offset: 0x0005489C
		private static ArrayList FilterMembers(IList members, Attribute[] attributes)
		{
			ArrayList arrayList = null;
			int count = members.Count;
			for (int i = 0; i < count; i++)
			{
				bool flag = false;
				for (int j = 0; j < attributes.Length; j++)
				{
					if (TypeDescriptor.ShouldHideMember((MemberDescriptor)members[i], attributes[j]))
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					if (arrayList == null)
					{
						arrayList = new ArrayList(count);
						for (int k = 0; k < i; k++)
						{
							arrayList.Add(members[k]);
						}
					}
				}
				else if (arrayList != null)
				{
					arrayList.Add(members[i]);
				}
			}
			return arrayList;
		}

		/// <summary>Returns an instance of the type associated with the specified primary object.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
		/// <param name="primary">The primary object of the association.</param>
		/// <returns>An instance of the secondary type that has been associated with the primary object if an association exists; otherwise, <paramref name="primary" /> if no specified association exists.</returns>
		/// <exception cref="T:System.ArgumentNullException">One or both of the parameters are <see langword="null" />.</exception>
		// Token: 0x0600122A RID: 4650 RVA: 0x00056730 File Offset: 0x00054930
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static object GetAssociation(Type type, object primary)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (primary == null)
			{
				throw new ArgumentNullException("primary");
			}
			object obj = primary;
			if (!type.IsInstanceOfType(primary))
			{
				Hashtable associationTable = TypeDescriptor._associationTable;
				if (associationTable != null)
				{
					IList list = (IList)associationTable[primary];
					if (list != null)
					{
						IList obj2 = list;
						lock (obj2)
						{
							for (int i = list.Count - 1; i >= 0; i--)
							{
								object target = ((WeakReference)list[i]).Target;
								if (target == null)
								{
									list.RemoveAt(i);
								}
								else if (type.IsInstanceOfType(target))
								{
									obj = target;
								}
							}
						}
					}
				}
				if (obj == primary)
				{
					IComponent component = primary as IComponent;
					if (component != null)
					{
						ISite site = component.Site;
						if (site != null && site.DesignMode)
						{
							IDesignerHost designerHost = site.GetService(typeof(IDesignerHost)) as IDesignerHost;
							if (designerHost != null)
							{
								object designer = designerHost.GetDesigner(component);
								if (designer != null && type.IsInstanceOfType(designer))
								{
									obj = designer;
								}
							}
						}
					}
				}
			}
			return obj;
		}

		/// <summary>Returns a collection of attributes for the specified type of component.</summary>
		/// <param name="componentType">The <see cref="T:System.Type" /> of the target component. </param>
		/// <returns>An <see cref="T:System.ComponentModel.AttributeCollection" /> with the attributes for the type of the component. If the component is <see langword="null" />, this method returns an empty collection.</returns>
		// Token: 0x0600122B RID: 4651 RVA: 0x00056858 File Offset: 0x00054A58
		public static AttributeCollection GetAttributes(Type componentType)
		{
			if (componentType == null)
			{
				return new AttributeCollection(null);
			}
			return TypeDescriptor.GetDescriptor(componentType, "componentType").GetAttributes();
		}

		/// <summary>Returns the collection of attributes for the specified component.</summary>
		/// <param name="component">The component for which you want to get attributes. </param>
		/// <returns>An <see cref="T:System.ComponentModel.AttributeCollection" /> containing the attributes for the component. If <paramref name="component" /> is <see langword="null" />, this method returns an empty collection.</returns>
		// Token: 0x0600122C RID: 4652 RVA: 0x0005687A File Offset: 0x00054A7A
		public static AttributeCollection GetAttributes(object component)
		{
			return TypeDescriptor.GetAttributes(component, false);
		}

		/// <summary>Returns a collection of attributes for the specified component and a Boolean indicating that a custom type descriptor has been created.</summary>
		/// <param name="component">The component for which you want to get attributes. </param>
		/// <param name="noCustomTypeDesc">
		///       <see langword="true" /> to use a baseline set of attributes from the custom type descriptor if <paramref name="component" /> is of type <see cref="T:System.ComponentModel.ICustomTypeDescriptor" />; otherwise, <see langword="false" />.</param>
		/// <returns>An <see cref="T:System.ComponentModel.AttributeCollection" /> with the attributes for the component. If the component is <see langword="null" />, this method returns an empty collection.</returns>
		// Token: 0x0600122D RID: 4653 RVA: 0x00056884 File Offset: 0x00054A84
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc)
		{
			if (component == null)
			{
				return new AttributeCollection(null);
			}
			ICollection collection = TypeDescriptor.GetDescriptor(component, noCustomTypeDesc).GetAttributes();
			if (component is ICustomTypeDescriptor)
			{
				if (noCustomTypeDesc)
				{
					ICustomTypeDescriptor extendedDescriptor = TypeDescriptor.GetExtendedDescriptor(component);
					if (extendedDescriptor != null)
					{
						ICollection attributes = extendedDescriptor.GetAttributes();
						collection = TypeDescriptor.PipelineMerge(0, collection, attributes, component, null);
					}
				}
				else
				{
					collection = TypeDescriptor.PipelineFilter(0, collection, component, null);
				}
			}
			else
			{
				IDictionary cache = TypeDescriptor.GetCache(component);
				collection = TypeDescriptor.PipelineInitialize(0, collection, cache);
				ICustomTypeDescriptor extendedDescriptor2 = TypeDescriptor.GetExtendedDescriptor(component);
				if (extendedDescriptor2 != null)
				{
					ICollection attributes2 = extendedDescriptor2.GetAttributes();
					collection = TypeDescriptor.PipelineMerge(0, collection, attributes2, component, cache);
				}
				collection = TypeDescriptor.PipelineFilter(0, collection, component, cache);
			}
			AttributeCollection attributeCollection = collection as AttributeCollection;
			if (attributeCollection == null)
			{
				Attribute[] array = new Attribute[collection.Count];
				collection.CopyTo(array, 0);
				attributeCollection = new AttributeCollection(array);
			}
			return attributeCollection;
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00056945 File Offset: 0x00054B45
		internal static IDictionary GetCache(object instance)
		{
			return TypeDescriptor.NodeFor(instance).GetCache(instance);
		}

		/// <summary>Returns a type converter for the specified type.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of the target component. </param>
		/// <returns>A <see cref="T:System.ComponentModel.TypeConverter" /> for the specified type.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="component" /> is <see langword="null" />. </exception>
		// Token: 0x0600122F RID: 4655 RVA: 0x00056953 File Offset: 0x00054B53
		public static TypeConverter GetConverter(Type type)
		{
			return TypeDescriptor.GetDescriptor(type, "type").GetConverter();
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00056965 File Offset: 0x00054B65
		internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName)
		{
			if (type == null)
			{
				throw new ArgumentNullException(typeName);
			}
			return TypeDescriptor.NodeFor(type).GetTypeDescriptor(type);
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00056984 File Offset: 0x00054B84
		internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc)
		{
			if (component == null)
			{
				throw new ArgumentException("component");
			}
			if (component is TypeDescriptor.IUnimplemented)
			{
				throw new NotSupportedException(SR.GetString("The object {0} is being remoted by a proxy that does not support interface discovery.  This type of remoted object is not supported.", new object[]
				{
					component.GetType().FullName
				}));
			}
			ICustomTypeDescriptor customTypeDescriptor = TypeDescriptor.NodeFor(component).GetTypeDescriptor(component);
			ICustomTypeDescriptor customTypeDescriptor2 = component as ICustomTypeDescriptor;
			if (!noCustomTypeDesc && customTypeDescriptor2 != null)
			{
				customTypeDescriptor = new TypeDescriptor.MergedTypeDescriptor(customTypeDescriptor2, customTypeDescriptor);
			}
			return customTypeDescriptor;
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x000569EE File Offset: 0x00054BEE
		internal static ICustomTypeDescriptor GetExtendedDescriptor(object component)
		{
			if (component == null)
			{
				throw new ArgumentException("component");
			}
			return TypeDescriptor.NodeFor(component).GetExtendedTypeDescriptor(component);
		}

		/// <summary>Returns the collection of events for a specified type of component.</summary>
		/// <param name="componentType">The <see cref="T:System.Type" /> of the target component.</param>
		/// <returns>An <see cref="T:System.ComponentModel.EventDescriptorCollection" /> with the events for this component.</returns>
		// Token: 0x06001233 RID: 4659 RVA: 0x00056A0A File Offset: 0x00054C0A
		public static EventDescriptorCollection GetEvents(Type componentType)
		{
			if (componentType == null)
			{
				return new EventDescriptorCollection(null, true);
			}
			return TypeDescriptor.GetDescriptor(componentType, "componentType").GetEvents();
		}

		/// <summary>Returns the collection of events for the specified component.</summary>
		/// <param name="component">A component to get the events for. </param>
		/// <returns>An <see cref="T:System.ComponentModel.EventDescriptorCollection" /> with the events for this component.</returns>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="component" /> is a cross-process remoted object.</exception>
		// Token: 0x06001234 RID: 4660 RVA: 0x00056A2D File Offset: 0x00054C2D
		public static EventDescriptorCollection GetEvents(object component)
		{
			return TypeDescriptor.GetEvents(component, null, false);
		}

		/// <summary>Returns the collection of events for a specified component using a specified array of attributes as a filter and using a custom type descriptor.</summary>
		/// <param name="component">A component to get the events for. </param>
		/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> to use as a filter. </param>
		/// <param name="noCustomTypeDesc">
		///       <see langword="true" /> to consider custom type description information; otherwise, <see langword="false" />.</param>
		/// <returns>An <see cref="T:System.ComponentModel.EventDescriptorCollection" /> with the events that match the specified attributes for this component.</returns>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="component" /> is a cross-process remoted object.</exception>
		// Token: 0x06001235 RID: 4661 RVA: 0x00056A38 File Offset: 0x00054C38
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes, bool noCustomTypeDesc)
		{
			if (component == null)
			{
				return new EventDescriptorCollection(null, true);
			}
			ICustomTypeDescriptor descriptor = TypeDescriptor.GetDescriptor(component, noCustomTypeDesc);
			ICollection collection;
			if (component is ICustomTypeDescriptor)
			{
				collection = descriptor.GetEvents(attributes);
				if (noCustomTypeDesc)
				{
					ICustomTypeDescriptor extendedDescriptor = TypeDescriptor.GetExtendedDescriptor(component);
					if (extendedDescriptor != null)
					{
						ICollection events = extendedDescriptor.GetEvents(attributes);
						collection = TypeDescriptor.PipelineMerge(2, collection, events, component, null);
					}
				}
				else
				{
					collection = TypeDescriptor.PipelineFilter(2, collection, component, null);
					collection = TypeDescriptor.PipelineAttributeFilter(2, collection, attributes, component, null);
				}
			}
			else
			{
				IDictionary cache = TypeDescriptor.GetCache(component);
				collection = descriptor.GetEvents(attributes);
				collection = TypeDescriptor.PipelineInitialize(2, collection, cache);
				ICustomTypeDescriptor extendedDescriptor2 = TypeDescriptor.GetExtendedDescriptor(component);
				if (extendedDescriptor2 != null)
				{
					ICollection events2 = extendedDescriptor2.GetEvents(attributes);
					collection = TypeDescriptor.PipelineMerge(2, collection, events2, component, cache);
				}
				collection = TypeDescriptor.PipelineFilter(2, collection, component, cache);
				collection = TypeDescriptor.PipelineAttributeFilter(2, collection, attributes, component, cache);
			}
			EventDescriptorCollection eventDescriptorCollection = collection as EventDescriptorCollection;
			if (eventDescriptorCollection == null)
			{
				EventDescriptor[] array = new EventDescriptor[collection.Count];
				collection.CopyTo(array, 0);
				eventDescriptorCollection = new EventDescriptorCollection(array, true);
			}
			return eventDescriptorCollection;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00056B24 File Offset: 0x00054D24
		private static string GetExtenderCollisionSuffix(MemberDescriptor member)
		{
			string result = null;
			ExtenderProvidedPropertyAttribute extenderProvidedPropertyAttribute = member.Attributes[typeof(ExtenderProvidedPropertyAttribute)] as ExtenderProvidedPropertyAttribute;
			if (extenderProvidedPropertyAttribute != null)
			{
				IExtenderProvider provider = extenderProvidedPropertyAttribute.Provider;
				if (provider != null)
				{
					string text = null;
					IComponent component = provider as IComponent;
					if (component != null && component.Site != null)
					{
						text = component.Site.Name;
					}
					if (text == null || text.Length == 0)
					{
						text = (Interlocked.Increment(ref TypeDescriptor._collisionIndex) - 1).ToString(CultureInfo.InvariantCulture);
					}
					result = string.Format(CultureInfo.InvariantCulture, "_{0}", text);
				}
			}
			return result;
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00056BB7 File Offset: 0x00054DB7
		private static Type GetNodeForBaseType(Type searchType)
		{
			if (searchType.IsInterface)
			{
				return TypeDescriptor.InterfaceType;
			}
			if (searchType == TypeDescriptor.InterfaceType)
			{
				return null;
			}
			return searchType.BaseType;
		}

		/// <summary>Returns the collection of properties for a specified type of component.</summary>
		/// <param name="componentType">A <see cref="T:System.Type" /> that represents the component to get properties for.</param>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties for a specified type of component.</returns>
		// Token: 0x06001238 RID: 4664 RVA: 0x00056BDC File Offset: 0x00054DDC
		public static PropertyDescriptorCollection GetProperties(Type componentType)
		{
			if (componentType == null)
			{
				return new PropertyDescriptorCollection(null, true);
			}
			return TypeDescriptor.GetDescriptor(componentType, "componentType").GetProperties();
		}

		/// <summary>Returns the collection of properties for a specified component.</summary>
		/// <param name="component">A component to get the properties for. </param>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties for the specified component.</returns>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="component" /> is a cross-process remoted object.</exception>
		// Token: 0x06001239 RID: 4665 RVA: 0x00056BFF File Offset: 0x00054DFF
		public static PropertyDescriptorCollection GetProperties(object component)
		{
			return TypeDescriptor.GetProperties(component, false);
		}

		/// <summary>Returns the collection of properties for a specified component using the default type descriptor.</summary>
		/// <param name="component">A component to get the properties for. </param>
		/// <param name="noCustomTypeDesc">
		///       <see langword="true" /> to not consider custom type description information; otherwise, <see langword="false" />.</param>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties for a specified component.</returns>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="component" /> is a cross-process remoted object.</exception>
		// Token: 0x0600123A RID: 4666 RVA: 0x00056C08 File Offset: 0x00054E08
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc)
		{
			return TypeDescriptor.GetPropertiesImpl(component, null, noCustomTypeDesc, true);
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00056C14 File Offset: 0x00054E14
		private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes)
		{
			if (component == null)
			{
				return new PropertyDescriptorCollection(null, true);
			}
			ICustomTypeDescriptor descriptor = TypeDescriptor.GetDescriptor(component, noCustomTypeDesc);
			ICollection collection;
			if (component is ICustomTypeDescriptor)
			{
				collection = (noAttributes ? descriptor.GetProperties() : descriptor.GetProperties(attributes));
				if (noCustomTypeDesc)
				{
					ICustomTypeDescriptor extendedDescriptor = TypeDescriptor.GetExtendedDescriptor(component);
					if (extendedDescriptor != null)
					{
						ICollection secondary = noAttributes ? extendedDescriptor.GetProperties() : extendedDescriptor.GetProperties(attributes);
						collection = TypeDescriptor.PipelineMerge(1, collection, secondary, component, null);
					}
				}
				else
				{
					collection = TypeDescriptor.PipelineFilter(1, collection, component, null);
					collection = TypeDescriptor.PipelineAttributeFilter(1, collection, attributes, component, null);
				}
			}
			else
			{
				IDictionary cache = TypeDescriptor.GetCache(component);
				collection = (noAttributes ? descriptor.GetProperties() : descriptor.GetProperties(attributes));
				collection = TypeDescriptor.PipelineInitialize(1, collection, cache);
				ICustomTypeDescriptor extendedDescriptor2 = TypeDescriptor.GetExtendedDescriptor(component);
				if (extendedDescriptor2 != null)
				{
					ICollection secondary2 = noAttributes ? extendedDescriptor2.GetProperties() : extendedDescriptor2.GetProperties(attributes);
					collection = TypeDescriptor.PipelineMerge(1, collection, secondary2, component, cache);
				}
				collection = TypeDescriptor.PipelineFilter(1, collection, component, cache);
				collection = TypeDescriptor.PipelineAttributeFilter(1, collection, attributes, component, cache);
			}
			PropertyDescriptorCollection propertyDescriptorCollection = collection as PropertyDescriptorCollection;
			if (propertyDescriptorCollection == null)
			{
				PropertyDescriptor[] array = new PropertyDescriptor[collection.Count];
				collection.CopyTo(array, 0);
				propertyDescriptorCollection = new PropertyDescriptorCollection(array, true);
			}
			return propertyDescriptorCollection;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x00056D30 File Offset: 0x00054F30
		internal static TypeDescriptionProvider GetProviderRecursive(Type type)
		{
			return TypeDescriptor.NodeFor(type, false);
		}

		/// <summary>Returns a <see cref="T:System.Type" /> that can be used to perform reflection, given a class type.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
		/// <returns>A <see cref="T:System.Type" /> of the specified class.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />.</exception>
		// Token: 0x0600123D RID: 4669 RVA: 0x00056D39 File Offset: 0x00054F39
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Type GetReflectionType(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return TypeDescriptor.NodeFor(type).GetReflectionType(type);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00056D30 File Offset: 0x00054F30
		private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type)
		{
			return TypeDescriptor.NodeFor(type, false);
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00056D5C File Offset: 0x00054F5C
		private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type, bool createDelegator)
		{
			TypeDescriptor.CheckDefaultProvider(type);
			TypeDescriptor.TypeDescriptionNode typeDescriptionNode = null;
			Type type2 = type;
			while (typeDescriptionNode == null)
			{
				typeDescriptionNode = (TypeDescriptor.TypeDescriptionNode)TypeDescriptor._providerTypeTable[type2];
				if (typeDescriptionNode == null)
				{
					typeDescriptionNode = (TypeDescriptor.TypeDescriptionNode)TypeDescriptor._providerTable[type2];
				}
				if (typeDescriptionNode == null)
				{
					Type nodeForBaseType = TypeDescriptor.GetNodeForBaseType(type2);
					if (type2 == typeof(object) || nodeForBaseType == null)
					{
						WeakHashtable providerTable = TypeDescriptor._providerTable;
						lock (providerTable)
						{
							typeDescriptionNode = (TypeDescriptor.TypeDescriptionNode)TypeDescriptor._providerTable[type2];
							if (typeDescriptionNode == null)
							{
								typeDescriptionNode = new TypeDescriptor.TypeDescriptionNode(new ReflectTypeDescriptionProvider());
								TypeDescriptor._providerTable[type2] = typeDescriptionNode;
							}
							continue;
						}
					}
					if (createDelegator)
					{
						typeDescriptionNode = new TypeDescriptor.TypeDescriptionNode(new DelegatingTypeDescriptionProvider(nodeForBaseType));
						WeakHashtable providerTable = TypeDescriptor._providerTable;
						lock (providerTable)
						{
							TypeDescriptor._providerTypeTable[type2] = typeDescriptionNode;
							continue;
						}
					}
					type2 = nodeForBaseType;
				}
			}
			return typeDescriptionNode;
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00056E6C File Offset: 0x0005506C
		private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance)
		{
			return TypeDescriptor.NodeFor(instance, false);
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00056E78 File Offset: 0x00055078
		private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance, bool createDelegator)
		{
			TypeDescriptor.TypeDescriptionNode typeDescriptionNode = (TypeDescriptor.TypeDescriptionNode)TypeDescriptor._providerTable[instance];
			if (typeDescriptionNode == null)
			{
				Type type = instance.GetType();
				if (type.IsCOMObject)
				{
					type = TypeDescriptor.ComObjectType;
				}
				if (createDelegator)
				{
					typeDescriptionNode = new TypeDescriptor.TypeDescriptionNode(new DelegatingTypeDescriptionProvider(type));
				}
				else
				{
					typeDescriptionNode = TypeDescriptor.NodeFor(type);
				}
			}
			return typeDescriptionNode;
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00056EC8 File Offset: 0x000550C8
		private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache)
		{
			IList list = members as ArrayList;
			if (filter == null || filter.Length == 0)
			{
				return members;
			}
			if (cache != null && (list == null || list.IsReadOnly))
			{
				TypeDescriptor.AttributeFilterCacheItem attributeFilterCacheItem = cache[TypeDescriptor._pipelineAttributeFilterKeys[pipelineType]] as TypeDescriptor.AttributeFilterCacheItem;
				if (attributeFilterCacheItem != null && attributeFilterCacheItem.IsValid(filter))
				{
					return attributeFilterCacheItem.FilteredMembers;
				}
			}
			if (list == null || list.IsReadOnly)
			{
				list = new ArrayList(members);
			}
			ArrayList arrayList = TypeDescriptor.FilterMembers(list, filter);
			if (arrayList != null)
			{
				list = arrayList;
			}
			if (cache != null)
			{
				ICollection filteredMembers;
				if (pipelineType != 1)
				{
					if (pipelineType != 2)
					{
						filteredMembers = null;
					}
					else
					{
						EventDescriptor[] array = new EventDescriptor[list.Count];
						list.CopyTo(array, 0);
						filteredMembers = new EventDescriptorCollection(array, true);
					}
				}
				else
				{
					PropertyDescriptor[] array2 = new PropertyDescriptor[list.Count];
					list.CopyTo(array2, 0);
					filteredMembers = new PropertyDescriptorCollection(array2, true);
				}
				TypeDescriptor.AttributeFilterCacheItem value = new TypeDescriptor.AttributeFilterCacheItem(filter, filteredMembers);
				cache[TypeDescriptor._pipelineAttributeFilterKeys[pipelineType]] = value;
			}
			return list;
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00056FB8 File Offset: 0x000551B8
		private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache)
		{
			IComponent component = instance as IComponent;
			ITypeDescriptorFilterService typeDescriptorFilterService = null;
			if (component != null)
			{
				ISite site = component.Site;
				if (site != null)
				{
					typeDescriptorFilterService = (site.GetService(typeof(ITypeDescriptorFilterService)) as ITypeDescriptorFilterService);
				}
			}
			IList list = members as ArrayList;
			if (typeDescriptorFilterService == null)
			{
				return members;
			}
			if (cache != null && (list == null || list.IsReadOnly))
			{
				TypeDescriptor.FilterCacheItem filterCacheItem = cache[TypeDescriptor._pipelineFilterKeys[pipelineType]] as TypeDescriptor.FilterCacheItem;
				if (filterCacheItem != null && filterCacheItem.IsValid(typeDescriptorFilterService))
				{
					return filterCacheItem.FilteredMembers;
				}
			}
			OrderedDictionary orderedDictionary = new OrderedDictionary(members.Count);
			bool flag;
			if (pipelineType != 0)
			{
				if (pipelineType - 1 > 1)
				{
					flag = false;
				}
				else
				{
					foreach (object obj in members)
					{
						MemberDescriptor memberDescriptor = (MemberDescriptor)obj;
						string name = memberDescriptor.Name;
						if (orderedDictionary.Contains(name))
						{
							string extenderCollisionSuffix = TypeDescriptor.GetExtenderCollisionSuffix(memberDescriptor);
							if (extenderCollisionSuffix != null)
							{
								orderedDictionary[name + extenderCollisionSuffix] = memberDescriptor;
							}
							MemberDescriptor memberDescriptor2 = (MemberDescriptor)orderedDictionary[name];
							extenderCollisionSuffix = TypeDescriptor.GetExtenderCollisionSuffix(memberDescriptor2);
							if (extenderCollisionSuffix != null)
							{
								orderedDictionary.Remove(name);
								orderedDictionary[memberDescriptor2.Name + extenderCollisionSuffix] = memberDescriptor2;
							}
						}
						else
						{
							orderedDictionary[name] = memberDescriptor;
						}
					}
					if (pipelineType == 1)
					{
						flag = typeDescriptorFilterService.FilterProperties(component, orderedDictionary);
					}
					else
					{
						flag = typeDescriptorFilterService.FilterEvents(component, orderedDictionary);
					}
				}
			}
			else
			{
				foreach (object obj2 in members)
				{
					Attribute attribute = (Attribute)obj2;
					orderedDictionary[attribute.TypeId] = attribute;
				}
				flag = typeDescriptorFilterService.FilterAttributes(component, orderedDictionary);
			}
			if (list == null || list.IsReadOnly)
			{
				list = new ArrayList(orderedDictionary.Values);
			}
			else
			{
				list.Clear();
				foreach (object value in orderedDictionary.Values)
				{
					list.Add(value);
				}
			}
			if (flag && cache != null)
			{
				ICollection filteredMembers;
				switch (pipelineType)
				{
				case 0:
				{
					Attribute[] array = new Attribute[list.Count];
					try
					{
						list.CopyTo(array, 0);
					}
					catch (InvalidCastException)
					{
						throw new ArgumentException(SR.GetString("Expected types in the collection to be of type {0}.", new object[]
						{
							typeof(Attribute).FullName
						}));
					}
					filteredMembers = new AttributeCollection(array);
					break;
				}
				case 1:
				{
					PropertyDescriptor[] array2 = new PropertyDescriptor[list.Count];
					try
					{
						list.CopyTo(array2, 0);
					}
					catch (InvalidCastException)
					{
						throw new ArgumentException(SR.GetString("Expected types in the collection to be of type {0}.", new object[]
						{
							typeof(PropertyDescriptor).FullName
						}));
					}
					filteredMembers = new PropertyDescriptorCollection(array2, true);
					break;
				}
				case 2:
				{
					EventDescriptor[] array3 = new EventDescriptor[list.Count];
					try
					{
						list.CopyTo(array3, 0);
					}
					catch (InvalidCastException)
					{
						throw new ArgumentException(SR.GetString("Expected types in the collection to be of type {0}.", new object[]
						{
							typeof(EventDescriptor).FullName
						}));
					}
					filteredMembers = new EventDescriptorCollection(array3, true);
					break;
				}
				default:
					filteredMembers = null;
					break;
				}
				TypeDescriptor.FilterCacheItem value2 = new TypeDescriptor.FilterCacheItem(typeDescriptorFilterService, filteredMembers);
				cache[TypeDescriptor._pipelineFilterKeys[pipelineType]] = value2;
				cache.Remove(TypeDescriptor._pipelineAttributeFilterKeys[pipelineType]);
			}
			return list;
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x0005737C File Offset: 0x0005557C
		private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache)
		{
			if (cache != null)
			{
				bool flag = true;
				ICollection collection = cache[TypeDescriptor._pipelineInitializeKeys[pipelineType]] as ICollection;
				if (collection != null && collection.Count == members.Count)
				{
					IEnumerator enumerator = collection.GetEnumerator();
					IEnumerator enumerator2 = members.GetEnumerator();
					while (enumerator.MoveNext() && enumerator2.MoveNext())
					{
						if (enumerator.Current != enumerator2.Current)
						{
							flag = false;
							break;
						}
					}
				}
				if (!flag)
				{
					cache.Remove(TypeDescriptor._pipelineMergeKeys[pipelineType]);
					cache.Remove(TypeDescriptor._pipelineFilterKeys[pipelineType]);
					cache.Remove(TypeDescriptor._pipelineAttributeFilterKeys[pipelineType]);
					cache[TypeDescriptor._pipelineInitializeKeys[pipelineType]] = members;
				}
			}
			return members;
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00057450 File Offset: 0x00055650
		private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache)
		{
			if (secondary == null || secondary.Count == 0)
			{
				return primary;
			}
			if (cache != null)
			{
				ICollection collection = cache[TypeDescriptor._pipelineMergeKeys[pipelineType]] as ICollection;
				if (collection != null && collection.Count == primary.Count + secondary.Count)
				{
					IEnumerator enumerator = collection.GetEnumerator();
					IEnumerator enumerator2 = primary.GetEnumerator();
					bool flag = true;
					while (enumerator2.MoveNext() && enumerator.MoveNext())
					{
						if (enumerator2.Current != enumerator.Current)
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						IEnumerator enumerator3 = secondary.GetEnumerator();
						while (enumerator3.MoveNext() && enumerator.MoveNext())
						{
							if (enumerator3.Current != enumerator.Current)
							{
								flag = false;
								break;
							}
						}
					}
					if (flag)
					{
						return collection;
					}
				}
			}
			ArrayList arrayList = new ArrayList(primary.Count + secondary.Count);
			foreach (object value in primary)
			{
				arrayList.Add(value);
			}
			foreach (object value2 in secondary)
			{
				arrayList.Add(value2);
			}
			if (cache != null)
			{
				ICollection value3;
				switch (pipelineType)
				{
				case 0:
				{
					Attribute[] array = new Attribute[arrayList.Count];
					arrayList.CopyTo(array, 0);
					value3 = new AttributeCollection(array);
					break;
				}
				case 1:
				{
					PropertyDescriptor[] array2 = new PropertyDescriptor[arrayList.Count];
					arrayList.CopyTo(array2, 0);
					value3 = new PropertyDescriptorCollection(array2, true);
					break;
				}
				case 2:
				{
					EventDescriptor[] array3 = new EventDescriptor[arrayList.Count];
					arrayList.CopyTo(array3, 0);
					value3 = new EventDescriptorCollection(array3, true);
					break;
				}
				default:
					value3 = null;
					break;
				}
				cache[TypeDescriptor._pipelineMergeKeys[pipelineType]] = value3;
				cache.Remove(TypeDescriptor._pipelineFilterKeys[pipelineType]);
				cache.Remove(TypeDescriptor._pipelineAttributeFilterKeys[pipelineType]);
			}
			return arrayList;
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x0005768C File Offset: 0x0005588C
		private static void RaiseRefresh(Type type)
		{
			RefreshEventHandler refreshEventHandler = Volatile.Read<RefreshEventHandler>(ref TypeDescriptor.Refreshed);
			if (refreshEventHandler != null)
			{
				refreshEventHandler(new RefreshEventArgs(type));
			}
		}

		/// <summary>Clears the properties and events for the specified type of component from the cache.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of the target component.</param>
		// Token: 0x06001247 RID: 4679 RVA: 0x000576B4 File Offset: 0x000558B4
		public static void Refresh(Type type)
		{
			if (type == null)
			{
				return;
			}
			bool flag = false;
			WeakHashtable providerTable = TypeDescriptor._providerTable;
			lock (providerTable)
			{
				foreach (object obj in TypeDescriptor._providerTable)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					Type type2 = dictionaryEntry.Key as Type;
					if ((type2 != null && type.IsAssignableFrom(type2)) || type2 == typeof(object))
					{
						TypeDescriptor.TypeDescriptionNode typeDescriptionNode = (TypeDescriptor.TypeDescriptionNode)dictionaryEntry.Value;
						while (typeDescriptionNode != null && !(typeDescriptionNode.Provider is ReflectTypeDescriptionProvider))
						{
							flag = true;
							typeDescriptionNode = typeDescriptionNode.Next;
						}
						if (typeDescriptionNode != null)
						{
							ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = (ReflectTypeDescriptionProvider)typeDescriptionNode.Provider;
							if (reflectTypeDescriptionProvider.IsPopulated(type))
							{
								flag = true;
								reflectTypeDescriptionProvider.Refresh(type);
							}
						}
					}
				}
			}
			if (flag)
			{
				Interlocked.Increment(ref TypeDescriptor._metadataVersion);
				TypeDescriptor.RaiseRefresh(type);
			}
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x000577E0 File Offset: 0x000559E0
		private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute)
		{
			if (member == null || attribute == null)
			{
				return true;
			}
			Attribute attribute2 = member.Attributes[attribute.GetType()];
			if (attribute2 == null)
			{
				return !attribute.IsDefaultAttribute();
			}
			return !attribute.Match(attribute2);
		}

		/// <summary>Sorts descriptors using the name of the descriptor.</summary>
		/// <param name="infos">An <see cref="T:System.Collections.IList" /> that contains the descriptors to sort. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="infos" /> is <see langword="null" />.</exception>
		// Token: 0x06001249 RID: 4681 RVA: 0x0005781E File Offset: 0x00055A1E
		public static void SortDescriptorArray(IList infos)
		{
			if (infos == null)
			{
				throw new ArgumentNullException("infos");
			}
			ArrayList.Adapter(infos).Sort(TypeDescriptor.MemberDescriptorComparer.Instance);
		}

		// Token: 0x04000CE6 RID: 3302
		private static WeakHashtable _providerTable = new WeakHashtable();

		// Token: 0x04000CE7 RID: 3303
		private static Hashtable _providerTypeTable = new Hashtable();

		// Token: 0x04000CE8 RID: 3304
		private static volatile Hashtable _defaultProviders = new Hashtable();

		// Token: 0x04000CE9 RID: 3305
		private static volatile WeakHashtable _associationTable;

		// Token: 0x04000CEA RID: 3306
		private static int _metadataVersion;

		// Token: 0x04000CEB RID: 3307
		private static int _collisionIndex;

		// Token: 0x04000CEC RID: 3308
		private static BooleanSwitch TraceDescriptor = new BooleanSwitch("TypeDescriptor", "Debug TypeDescriptor.");

		// Token: 0x04000CED RID: 3309
		private static readonly Guid[] _pipelineInitializeKeys = new Guid[]
		{
			Guid.NewGuid(),
			Guid.NewGuid(),
			Guid.NewGuid()
		};

		// Token: 0x04000CEE RID: 3310
		private static readonly Guid[] _pipelineMergeKeys = new Guid[]
		{
			Guid.NewGuid(),
			Guid.NewGuid(),
			Guid.NewGuid()
		};

		// Token: 0x04000CEF RID: 3311
		private static readonly Guid[] _pipelineFilterKeys = new Guid[]
		{
			Guid.NewGuid(),
			Guid.NewGuid(),
			Guid.NewGuid()
		};

		// Token: 0x04000CF0 RID: 3312
		private static readonly Guid[] _pipelineAttributeFilterKeys = new Guid[]
		{
			Guid.NewGuid(),
			Guid.NewGuid(),
			Guid.NewGuid()
		};

		// Token: 0x04000CF1 RID: 3313
		private static object _internalSyncObject = new object();

		// Token: 0x04000CF2 RID: 3314
		[CompilerGenerated]
		private static RefreshEventHandler Refreshed;

		// Token: 0x020002A6 RID: 678
		private sealed class AttributeFilterCacheItem
		{
			// Token: 0x0600124B RID: 4683 RVA: 0x00057947 File Offset: 0x00055B47
			internal AttributeFilterCacheItem(Attribute[] filter, ICollection filteredMembers)
			{
				this._filter = filter;
				this.FilteredMembers = filteredMembers;
			}

			// Token: 0x0600124C RID: 4684 RVA: 0x00057960 File Offset: 0x00055B60
			internal bool IsValid(Attribute[] filter)
			{
				if (this._filter.Length != filter.Length)
				{
					return false;
				}
				for (int i = 0; i < filter.Length; i++)
				{
					if (this._filter[i] != filter[i])
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x04000CF3 RID: 3315
			private Attribute[] _filter;

			// Token: 0x04000CF4 RID: 3316
			internal ICollection FilteredMembers;
		}

		// Token: 0x020002A7 RID: 679
		private sealed class FilterCacheItem
		{
			// Token: 0x0600124D RID: 4685 RVA: 0x0005799A File Offset: 0x00055B9A
			internal FilterCacheItem(ITypeDescriptorFilterService filterService, ICollection filteredMembers)
			{
				this._filterService = filterService;
				this.FilteredMembers = filteredMembers;
			}

			// Token: 0x0600124E RID: 4686 RVA: 0x000579B0 File Offset: 0x00055BB0
			internal bool IsValid(ITypeDescriptorFilterService filterService)
			{
				return this._filterService == filterService;
			}

			// Token: 0x04000CF5 RID: 3317
			private ITypeDescriptorFilterService _filterService;

			// Token: 0x04000CF6 RID: 3318
			internal ICollection FilteredMembers;
		}

		// Token: 0x020002A8 RID: 680
		private interface IUnimplemented
		{
		}

		// Token: 0x020002A9 RID: 681
		private sealed class MemberDescriptorComparer : IComparer
		{
			// Token: 0x0600124F RID: 4687 RVA: 0x000579BE File Offset: 0x00055BBE
			public int Compare(object left, object right)
			{
				return string.Compare(((MemberDescriptor)left).Name, ((MemberDescriptor)right).Name, false, CultureInfo.InvariantCulture);
			}

			// Token: 0x04000CF7 RID: 3319
			public static readonly TypeDescriptor.MemberDescriptorComparer Instance = new TypeDescriptor.MemberDescriptorComparer();
		}

		// Token: 0x020002AA RID: 682
		private sealed class MergedTypeDescriptor : ICustomTypeDescriptor
		{
			// Token: 0x06001252 RID: 4690 RVA: 0x000579ED File Offset: 0x00055BED
			internal MergedTypeDescriptor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary)
			{
				this._primary = primary;
				this._secondary = secondary;
			}

			// Token: 0x06001253 RID: 4691 RVA: 0x00057A04 File Offset: 0x00055C04
			AttributeCollection ICustomTypeDescriptor.GetAttributes()
			{
				AttributeCollection attributes = this._primary.GetAttributes();
				if (attributes == null)
				{
					attributes = this._secondary.GetAttributes();
				}
				return attributes;
			}

			// Token: 0x06001254 RID: 4692 RVA: 0x00057A30 File Offset: 0x00055C30
			string ICustomTypeDescriptor.GetClassName()
			{
				string className = this._primary.GetClassName();
				if (className == null)
				{
					className = this._secondary.GetClassName();
				}
				return className;
			}

			// Token: 0x06001255 RID: 4693 RVA: 0x00057A5C File Offset: 0x00055C5C
			string ICustomTypeDescriptor.GetComponentName()
			{
				string componentName = this._primary.GetComponentName();
				if (componentName == null)
				{
					componentName = this._secondary.GetComponentName();
				}
				return componentName;
			}

			// Token: 0x06001256 RID: 4694 RVA: 0x00057A88 File Offset: 0x00055C88
			TypeConverter ICustomTypeDescriptor.GetConverter()
			{
				TypeConverter converter = this._primary.GetConverter();
				if (converter == null)
				{
					converter = this._secondary.GetConverter();
				}
				return converter;
			}

			// Token: 0x06001257 RID: 4695 RVA: 0x00057AB4 File Offset: 0x00055CB4
			EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
			{
				EventDescriptor defaultEvent = this._primary.GetDefaultEvent();
				if (defaultEvent == null)
				{
					defaultEvent = this._secondary.GetDefaultEvent();
				}
				return defaultEvent;
			}

			// Token: 0x06001258 RID: 4696 RVA: 0x00057AE0 File Offset: 0x00055CE0
			PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
			{
				PropertyDescriptor defaultProperty = this._primary.GetDefaultProperty();
				if (defaultProperty == null)
				{
					defaultProperty = this._secondary.GetDefaultProperty();
				}
				return defaultProperty;
			}

			// Token: 0x06001259 RID: 4697 RVA: 0x00057B0C File Offset: 0x00055D0C
			object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
			{
				if (editorBaseType == null)
				{
					throw new ArgumentNullException("editorBaseType");
				}
				object editor = this._primary.GetEditor(editorBaseType);
				if (editor == null)
				{
					editor = this._secondary.GetEditor(editorBaseType);
				}
				return editor;
			}

			// Token: 0x0600125A RID: 4698 RVA: 0x00057B4C File Offset: 0x00055D4C
			EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
			{
				EventDescriptorCollection events = this._primary.GetEvents();
				if (events == null)
				{
					events = this._secondary.GetEvents();
				}
				return events;
			}

			// Token: 0x0600125B RID: 4699 RVA: 0x00057B78 File Offset: 0x00055D78
			EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
			{
				EventDescriptorCollection events = this._primary.GetEvents(attributes);
				if (events == null)
				{
					events = this._secondary.GetEvents(attributes);
				}
				return events;
			}

			// Token: 0x0600125C RID: 4700 RVA: 0x00057BA4 File Offset: 0x00055DA4
			PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
			{
				PropertyDescriptorCollection properties = this._primary.GetProperties();
				if (properties == null)
				{
					properties = this._secondary.GetProperties();
				}
				return properties;
			}

			// Token: 0x0600125D RID: 4701 RVA: 0x00057BD0 File Offset: 0x00055DD0
			PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
			{
				PropertyDescriptorCollection properties = this._primary.GetProperties(attributes);
				if (properties == null)
				{
					properties = this._secondary.GetProperties(attributes);
				}
				return properties;
			}

			// Token: 0x0600125E RID: 4702 RVA: 0x00057BFC File Offset: 0x00055DFC
			object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
			{
				object propertyOwner = this._primary.GetPropertyOwner(pd);
				if (propertyOwner == null)
				{
					propertyOwner = this._secondary.GetPropertyOwner(pd);
				}
				return propertyOwner;
			}

			// Token: 0x04000CF8 RID: 3320
			private ICustomTypeDescriptor _primary;

			// Token: 0x04000CF9 RID: 3321
			private ICustomTypeDescriptor _secondary;
		}

		// Token: 0x020002AB RID: 683
		private sealed class TypeDescriptionNode : TypeDescriptionProvider
		{
			// Token: 0x0600125F RID: 4703 RVA: 0x00057C27 File Offset: 0x00055E27
			internal TypeDescriptionNode(TypeDescriptionProvider provider)
			{
				this.Provider = provider;
			}

			// Token: 0x06001260 RID: 4704 RVA: 0x00057C38 File Offset: 0x00055E38
			public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
			{
				if (objectType == null)
				{
					throw new ArgumentNullException("objectType");
				}
				if (argTypes != null)
				{
					if (args == null)
					{
						throw new ArgumentNullException("args");
					}
					if (argTypes.Length != args.Length)
					{
						throw new ArgumentException(SR.GetString("The number of elements in the Type and Object arrays must match."));
					}
				}
				return this.Provider.CreateInstance(provider, objectType, argTypes, args);
			}

			// Token: 0x06001261 RID: 4705 RVA: 0x00057C94 File Offset: 0x00055E94
			public override IDictionary GetCache(object instance)
			{
				if (instance == null)
				{
					throw new ArgumentNullException("instance");
				}
				return this.Provider.GetCache(instance);
			}

			// Token: 0x06001262 RID: 4706 RVA: 0x00057CB0 File Offset: 0x00055EB0
			public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
			{
				if (instance == null)
				{
					throw new ArgumentNullException("instance");
				}
				return new TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor(this, instance);
			}

			// Token: 0x06001263 RID: 4707 RVA: 0x00057CCC File Offset: 0x00055ECC
			protected internal override IExtenderProvider[] GetExtenderProviders(object instance)
			{
				if (instance == null)
				{
					throw new ArgumentNullException("instance");
				}
				return this.Provider.GetExtenderProviders(instance);
			}

			// Token: 0x06001264 RID: 4708 RVA: 0x00057CE8 File Offset: 0x00055EE8
			public override Type GetReflectionType(Type objectType, object instance)
			{
				if (objectType == null)
				{
					throw new ArgumentNullException("objectType");
				}
				return this.Provider.GetReflectionType(objectType, instance);
			}

			// Token: 0x06001265 RID: 4709 RVA: 0x00057D0B File Offset: 0x00055F0B
			public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
			{
				if (objectType == null)
				{
					throw new ArgumentNullException("objectType");
				}
				if (instance != null && !objectType.IsInstanceOfType(instance))
				{
					throw new ArgumentException("instance");
				}
				return new TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor(this, objectType, instance);
			}

			// Token: 0x04000CFA RID: 3322
			internal TypeDescriptor.TypeDescriptionNode Next;

			// Token: 0x04000CFB RID: 3323
			internal TypeDescriptionProvider Provider;

			// Token: 0x020002AC RID: 684
			private struct DefaultExtendedTypeDescriptor : ICustomTypeDescriptor
			{
				// Token: 0x06001266 RID: 4710 RVA: 0x00057D45 File Offset: 0x00055F45
				internal DefaultExtendedTypeDescriptor(TypeDescriptor.TypeDescriptionNode node, object instance)
				{
					this._node = node;
					this._instance = instance;
				}

				// Token: 0x06001267 RID: 4711 RVA: 0x00057D58 File Offset: 0x00055F58
				AttributeCollection ICustomTypeDescriptor.GetAttributes()
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					if (reflectTypeDescriptionProvider != null)
					{
						return reflectTypeDescriptionProvider.GetExtendedAttributes(this._instance);
					}
					ICustomTypeDescriptor extendedTypeDescriptor = provider.GetExtendedTypeDescriptor(this._instance);
					if (extendedTypeDescriptor == null)
					{
						throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
						{
							this._node.Provider.GetType().FullName,
							"GetExtendedTypeDescriptor"
						}));
					}
					AttributeCollection attributes = extendedTypeDescriptor.GetAttributes();
					if (attributes == null)
					{
						throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
						{
							this._node.Provider.GetType().FullName,
							"GetAttributes"
						}));
					}
					return attributes;
				}

				// Token: 0x06001268 RID: 4712 RVA: 0x00057E10 File Offset: 0x00056010
				string ICustomTypeDescriptor.GetClassName()
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					if (reflectTypeDescriptionProvider != null)
					{
						return reflectTypeDescriptionProvider.GetExtendedClassName(this._instance);
					}
					ICustomTypeDescriptor extendedTypeDescriptor = provider.GetExtendedTypeDescriptor(this._instance);
					if (extendedTypeDescriptor == null)
					{
						throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
						{
							this._node.Provider.GetType().FullName,
							"GetExtendedTypeDescriptor"
						}));
					}
					string text = extendedTypeDescriptor.GetClassName();
					if (text == null)
					{
						text = this._instance.GetType().FullName;
					}
					return text;
				}

				// Token: 0x06001269 RID: 4713 RVA: 0x00057EA4 File Offset: 0x000560A4
				string ICustomTypeDescriptor.GetComponentName()
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					if (reflectTypeDescriptionProvider != null)
					{
						return reflectTypeDescriptionProvider.GetExtendedComponentName(this._instance);
					}
					ICustomTypeDescriptor extendedTypeDescriptor = provider.GetExtendedTypeDescriptor(this._instance);
					if (extendedTypeDescriptor == null)
					{
						throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
						{
							this._node.Provider.GetType().FullName,
							"GetExtendedTypeDescriptor"
						}));
					}
					return extendedTypeDescriptor.GetComponentName();
				}

				// Token: 0x0600126A RID: 4714 RVA: 0x00057F20 File Offset: 0x00056120
				TypeConverter ICustomTypeDescriptor.GetConverter()
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					if (reflectTypeDescriptionProvider != null)
					{
						return reflectTypeDescriptionProvider.GetExtendedConverter(this._instance);
					}
					ICustomTypeDescriptor extendedTypeDescriptor = provider.GetExtendedTypeDescriptor(this._instance);
					if (extendedTypeDescriptor == null)
					{
						throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
						{
							this._node.Provider.GetType().FullName,
							"GetExtendedTypeDescriptor"
						}));
					}
					TypeConverter converter = extendedTypeDescriptor.GetConverter();
					if (converter == null)
					{
						throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
						{
							this._node.Provider.GetType().FullName,
							"GetConverter"
						}));
					}
					return converter;
				}

				// Token: 0x0600126B RID: 4715 RVA: 0x00057FD8 File Offset: 0x000561D8
				EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					if (reflectTypeDescriptionProvider != null)
					{
						return reflectTypeDescriptionProvider.GetExtendedDefaultEvent(this._instance);
					}
					ICustomTypeDescriptor extendedTypeDescriptor = provider.GetExtendedTypeDescriptor(this._instance);
					if (extendedTypeDescriptor == null)
					{
						throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
						{
							this._node.Provider.GetType().FullName,
							"GetExtendedTypeDescriptor"
						}));
					}
					return extendedTypeDescriptor.GetDefaultEvent();
				}

				// Token: 0x0600126C RID: 4716 RVA: 0x00058054 File Offset: 0x00056254
				PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					if (reflectTypeDescriptionProvider != null)
					{
						return reflectTypeDescriptionProvider.GetExtendedDefaultProperty(this._instance);
					}
					ICustomTypeDescriptor extendedTypeDescriptor = provider.GetExtendedTypeDescriptor(this._instance);
					if (extendedTypeDescriptor == null)
					{
						throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
						{
							this._node.Provider.GetType().FullName,
							"GetExtendedTypeDescriptor"
						}));
					}
					return extendedTypeDescriptor.GetDefaultProperty();
				}

				// Token: 0x0600126D RID: 4717 RVA: 0x000580D0 File Offset: 0x000562D0
				object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
				{
					if (editorBaseType == null)
					{
						throw new ArgumentNullException("editorBaseType");
					}
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					if (reflectTypeDescriptionProvider != null)
					{
						return reflectTypeDescriptionProvider.GetExtendedEditor(this._instance, editorBaseType);
					}
					ICustomTypeDescriptor extendedTypeDescriptor = provider.GetExtendedTypeDescriptor(this._instance);
					if (extendedTypeDescriptor == null)
					{
						throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
						{
							this._node.Provider.GetType().FullName,
							"GetExtendedTypeDescriptor"
						}));
					}
					return extendedTypeDescriptor.GetEditor(editorBaseType);
				}

				// Token: 0x0600126E RID: 4718 RVA: 0x00058164 File Offset: 0x00056364
				EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					if (reflectTypeDescriptionProvider != null)
					{
						return reflectTypeDescriptionProvider.GetExtendedEvents(this._instance);
					}
					ICustomTypeDescriptor extendedTypeDescriptor = provider.GetExtendedTypeDescriptor(this._instance);
					if (extendedTypeDescriptor == null)
					{
						throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
						{
							this._node.Provider.GetType().FullName,
							"GetExtendedTypeDescriptor"
						}));
					}
					EventDescriptorCollection events = extendedTypeDescriptor.GetEvents();
					if (events == null)
					{
						throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
						{
							this._node.Provider.GetType().FullName,
							"GetEvents"
						}));
					}
					return events;
				}

				// Token: 0x0600126F RID: 4719 RVA: 0x0005821C File Offset: 0x0005641C
				EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					if (reflectTypeDescriptionProvider != null)
					{
						return reflectTypeDescriptionProvider.GetExtendedEvents(this._instance);
					}
					ICustomTypeDescriptor extendedTypeDescriptor = provider.GetExtendedTypeDescriptor(this._instance);
					if (extendedTypeDescriptor == null)
					{
						throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
						{
							this._node.Provider.GetType().FullName,
							"GetExtendedTypeDescriptor"
						}));
					}
					EventDescriptorCollection events = extendedTypeDescriptor.GetEvents(attributes);
					if (events == null)
					{
						throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
						{
							this._node.Provider.GetType().FullName,
							"GetEvents"
						}));
					}
					return events;
				}

				// Token: 0x06001270 RID: 4720 RVA: 0x000582D4 File Offset: 0x000564D4
				PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					if (reflectTypeDescriptionProvider != null)
					{
						return reflectTypeDescriptionProvider.GetExtendedProperties(this._instance);
					}
					ICustomTypeDescriptor extendedTypeDescriptor = provider.GetExtendedTypeDescriptor(this._instance);
					if (extendedTypeDescriptor == null)
					{
						throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
						{
							this._node.Provider.GetType().FullName,
							"GetExtendedTypeDescriptor"
						}));
					}
					PropertyDescriptorCollection properties = extendedTypeDescriptor.GetProperties();
					if (properties == null)
					{
						throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
						{
							this._node.Provider.GetType().FullName,
							"GetProperties"
						}));
					}
					return properties;
				}

				// Token: 0x06001271 RID: 4721 RVA: 0x0005838C File Offset: 0x0005658C
				PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					if (reflectTypeDescriptionProvider != null)
					{
						return reflectTypeDescriptionProvider.GetExtendedProperties(this._instance);
					}
					ICustomTypeDescriptor extendedTypeDescriptor = provider.GetExtendedTypeDescriptor(this._instance);
					if (extendedTypeDescriptor == null)
					{
						throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
						{
							this._node.Provider.GetType().FullName,
							"GetExtendedTypeDescriptor"
						}));
					}
					PropertyDescriptorCollection properties = extendedTypeDescriptor.GetProperties(attributes);
					if (properties == null)
					{
						throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
						{
							this._node.Provider.GetType().FullName,
							"GetProperties"
						}));
					}
					return properties;
				}

				// Token: 0x06001272 RID: 4722 RVA: 0x00058444 File Offset: 0x00056644
				object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					if (reflectTypeDescriptionProvider != null)
					{
						return reflectTypeDescriptionProvider.GetExtendedPropertyOwner(this._instance, pd);
					}
					ICustomTypeDescriptor extendedTypeDescriptor = provider.GetExtendedTypeDescriptor(this._instance);
					if (extendedTypeDescriptor == null)
					{
						throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
						{
							this._node.Provider.GetType().FullName,
							"GetExtendedTypeDescriptor"
						}));
					}
					object obj = extendedTypeDescriptor.GetPropertyOwner(pd);
					if (obj == null)
					{
						obj = this._instance;
					}
					return obj;
				}

				// Token: 0x04000CFC RID: 3324
				private TypeDescriptor.TypeDescriptionNode _node;

				// Token: 0x04000CFD RID: 3325
				private object _instance;
			}

			// Token: 0x020002AD RID: 685
			private struct DefaultTypeDescriptor : ICustomTypeDescriptor
			{
				// Token: 0x06001273 RID: 4723 RVA: 0x000584CE File Offset: 0x000566CE
				internal DefaultTypeDescriptor(TypeDescriptor.TypeDescriptionNode node, Type objectType, object instance)
				{
					this._node = node;
					this._objectType = objectType;
					this._instance = instance;
				}

				// Token: 0x06001274 RID: 4724 RVA: 0x000584E8 File Offset: 0x000566E8
				AttributeCollection ICustomTypeDescriptor.GetAttributes()
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					AttributeCollection attributes;
					if (reflectTypeDescriptionProvider != null)
					{
						attributes = reflectTypeDescriptionProvider.GetAttributes(this._objectType);
					}
					else
					{
						ICustomTypeDescriptor typeDescriptor = provider.GetTypeDescriptor(this._objectType, this._instance);
						if (typeDescriptor == null)
						{
							throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
							{
								this._node.Provider.GetType().FullName,
								"GetTypeDescriptor"
							}));
						}
						attributes = typeDescriptor.GetAttributes();
						if (attributes == null)
						{
							throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
							{
								this._node.Provider.GetType().FullName,
								"GetAttributes"
							}));
						}
					}
					return attributes;
				}

				// Token: 0x06001275 RID: 4725 RVA: 0x000585AC File Offset: 0x000567AC
				string ICustomTypeDescriptor.GetClassName()
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					string text;
					if (reflectTypeDescriptionProvider != null)
					{
						text = reflectTypeDescriptionProvider.GetClassName(this._objectType);
					}
					else
					{
						ICustomTypeDescriptor typeDescriptor = provider.GetTypeDescriptor(this._objectType, this._instance);
						if (typeDescriptor == null)
						{
							throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
							{
								this._node.Provider.GetType().FullName,
								"GetTypeDescriptor"
							}));
						}
						text = typeDescriptor.GetClassName();
						if (text == null)
						{
							text = this._objectType.FullName;
						}
					}
					return text;
				}

				// Token: 0x06001276 RID: 4726 RVA: 0x00058644 File Offset: 0x00056844
				string ICustomTypeDescriptor.GetComponentName()
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					string componentName;
					if (reflectTypeDescriptionProvider != null)
					{
						componentName = reflectTypeDescriptionProvider.GetComponentName(this._objectType, this._instance);
					}
					else
					{
						ICustomTypeDescriptor typeDescriptor = provider.GetTypeDescriptor(this._objectType, this._instance);
						if (typeDescriptor == null)
						{
							throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
							{
								this._node.Provider.GetType().FullName,
								"GetTypeDescriptor"
							}));
						}
						componentName = typeDescriptor.GetComponentName();
					}
					return componentName;
				}

				// Token: 0x06001277 RID: 4727 RVA: 0x000586D0 File Offset: 0x000568D0
				TypeConverter ICustomTypeDescriptor.GetConverter()
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					TypeConverter converter;
					if (reflectTypeDescriptionProvider != null)
					{
						converter = reflectTypeDescriptionProvider.GetConverter(this._objectType, this._instance);
					}
					else
					{
						ICustomTypeDescriptor typeDescriptor = provider.GetTypeDescriptor(this._objectType, this._instance);
						if (typeDescriptor == null)
						{
							throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
							{
								this._node.Provider.GetType().FullName,
								"GetTypeDescriptor"
							}));
						}
						converter = typeDescriptor.GetConverter();
						if (converter == null)
						{
							throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
							{
								this._node.Provider.GetType().FullName,
								"GetConverter"
							}));
						}
					}
					return converter;
				}

				// Token: 0x06001278 RID: 4728 RVA: 0x00058798 File Offset: 0x00056998
				EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					EventDescriptor defaultEvent;
					if (reflectTypeDescriptionProvider != null)
					{
						defaultEvent = reflectTypeDescriptionProvider.GetDefaultEvent(this._objectType, this._instance);
					}
					else
					{
						ICustomTypeDescriptor typeDescriptor = provider.GetTypeDescriptor(this._objectType, this._instance);
						if (typeDescriptor == null)
						{
							throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
							{
								this._node.Provider.GetType().FullName,
								"GetTypeDescriptor"
							}));
						}
						defaultEvent = typeDescriptor.GetDefaultEvent();
					}
					return defaultEvent;
				}

				// Token: 0x06001279 RID: 4729 RVA: 0x00058824 File Offset: 0x00056A24
				PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					PropertyDescriptor defaultProperty;
					if (reflectTypeDescriptionProvider != null)
					{
						defaultProperty = reflectTypeDescriptionProvider.GetDefaultProperty(this._objectType, this._instance);
					}
					else
					{
						ICustomTypeDescriptor typeDescriptor = provider.GetTypeDescriptor(this._objectType, this._instance);
						if (typeDescriptor == null)
						{
							throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
							{
								this._node.Provider.GetType().FullName,
								"GetTypeDescriptor"
							}));
						}
						defaultProperty = typeDescriptor.GetDefaultProperty();
					}
					return defaultProperty;
				}

				// Token: 0x0600127A RID: 4730 RVA: 0x000588B0 File Offset: 0x00056AB0
				object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
				{
					if (editorBaseType == null)
					{
						throw new ArgumentNullException("editorBaseType");
					}
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					object editor;
					if (reflectTypeDescriptionProvider != null)
					{
						editor = reflectTypeDescriptionProvider.GetEditor(this._objectType, this._instance, editorBaseType);
					}
					else
					{
						ICustomTypeDescriptor typeDescriptor = provider.GetTypeDescriptor(this._objectType, this._instance);
						if (typeDescriptor == null)
						{
							throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
							{
								this._node.Provider.GetType().FullName,
								"GetTypeDescriptor"
							}));
						}
						editor = typeDescriptor.GetEditor(editorBaseType);
					}
					return editor;
				}

				// Token: 0x0600127B RID: 4731 RVA: 0x00058954 File Offset: 0x00056B54
				EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					EventDescriptorCollection events;
					if (reflectTypeDescriptionProvider != null)
					{
						events = reflectTypeDescriptionProvider.GetEvents(this._objectType);
					}
					else
					{
						ICustomTypeDescriptor typeDescriptor = provider.GetTypeDescriptor(this._objectType, this._instance);
						if (typeDescriptor == null)
						{
							throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
							{
								this._node.Provider.GetType().FullName,
								"GetTypeDescriptor"
							}));
						}
						events = typeDescriptor.GetEvents();
						if (events == null)
						{
							throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
							{
								this._node.Provider.GetType().FullName,
								"GetEvents"
							}));
						}
					}
					return events;
				}

				// Token: 0x0600127C RID: 4732 RVA: 0x00058A18 File Offset: 0x00056C18
				EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					EventDescriptorCollection events;
					if (reflectTypeDescriptionProvider != null)
					{
						events = reflectTypeDescriptionProvider.GetEvents(this._objectType);
					}
					else
					{
						ICustomTypeDescriptor typeDescriptor = provider.GetTypeDescriptor(this._objectType, this._instance);
						if (typeDescriptor == null)
						{
							throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
							{
								this._node.Provider.GetType().FullName,
								"GetTypeDescriptor"
							}));
						}
						events = typeDescriptor.GetEvents(attributes);
						if (events == null)
						{
							throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
							{
								this._node.Provider.GetType().FullName,
								"GetEvents"
							}));
						}
					}
					return events;
				}

				// Token: 0x0600127D RID: 4733 RVA: 0x00058ADC File Offset: 0x00056CDC
				PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					PropertyDescriptorCollection properties;
					if (reflectTypeDescriptionProvider != null)
					{
						properties = reflectTypeDescriptionProvider.GetProperties(this._objectType);
					}
					else
					{
						ICustomTypeDescriptor typeDescriptor = provider.GetTypeDescriptor(this._objectType, this._instance);
						if (typeDescriptor == null)
						{
							throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
							{
								this._node.Provider.GetType().FullName,
								"GetTypeDescriptor"
							}));
						}
						properties = typeDescriptor.GetProperties();
						if (properties == null)
						{
							throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
							{
								this._node.Provider.GetType().FullName,
								"GetProperties"
							}));
						}
					}
					return properties;
				}

				// Token: 0x0600127E RID: 4734 RVA: 0x00058BA0 File Offset: 0x00056DA0
				PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					PropertyDescriptorCollection properties;
					if (reflectTypeDescriptionProvider != null)
					{
						properties = reflectTypeDescriptionProvider.GetProperties(this._objectType);
					}
					else
					{
						ICustomTypeDescriptor typeDescriptor = provider.GetTypeDescriptor(this._objectType, this._instance);
						if (typeDescriptor == null)
						{
							throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
							{
								this._node.Provider.GetType().FullName,
								"GetTypeDescriptor"
							}));
						}
						properties = typeDescriptor.GetProperties(attributes);
						if (properties == null)
						{
							throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
							{
								this._node.Provider.GetType().FullName,
								"GetProperties"
							}));
						}
					}
					return properties;
				}

				// Token: 0x0600127F RID: 4735 RVA: 0x00058C64 File Offset: 0x00056E64
				object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
				{
					TypeDescriptionProvider provider = this._node.Provider;
					ReflectTypeDescriptionProvider reflectTypeDescriptionProvider = provider as ReflectTypeDescriptionProvider;
					object obj;
					if (reflectTypeDescriptionProvider != null)
					{
						obj = reflectTypeDescriptionProvider.GetPropertyOwner(this._objectType, this._instance, pd);
					}
					else
					{
						ICustomTypeDescriptor typeDescriptor = provider.GetTypeDescriptor(this._objectType, this._instance);
						if (typeDescriptor == null)
						{
							throw new InvalidOperationException(SR.GetString("The type description provider {0} has returned null from {1} which is illegal.", new object[]
							{
								this._node.Provider.GetType().FullName,
								"GetTypeDescriptor"
							}));
						}
						obj = typeDescriptor.GetPropertyOwner(pd);
						if (obj == null)
						{
							obj = this._instance;
						}
					}
					return obj;
				}

				// Token: 0x04000CFE RID: 3326
				private TypeDescriptor.TypeDescriptionNode _node;

				// Token: 0x04000CFF RID: 3327
				private Type _objectType;

				// Token: 0x04000D00 RID: 3328
				private object _instance;
			}
		}

		// Token: 0x020002AE RID: 686
		[TypeDescriptionProvider("System.Windows.Forms.ComponentModel.Com2Interop.ComNativeDescriptor, System.Windows.Forms, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
		private sealed class TypeDescriptorComObject
		{
		}

		// Token: 0x020002AF RID: 687
		private sealed class TypeDescriptorInterface
		{
		}
	}
}
