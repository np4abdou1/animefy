using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	// Token: 0x020002A1 RID: 673
	internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider
	{
		// Token: 0x060011D1 RID: 4561 RVA: 0x0005441B File Offset: 0x0005261B
		internal ReflectTypeDescriptionProvider()
		{
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x00054424 File Offset: 0x00052624
		private static Hashtable IntrinsicTypeConverters
		{
			get
			{
				if (ReflectTypeDescriptionProvider._intrinsicTypeConverters == null)
				{
					Hashtable hashtable = new Hashtable();
					hashtable[typeof(bool)] = typeof(BooleanConverter);
					hashtable[typeof(byte)] = typeof(ByteConverter);
					hashtable[typeof(sbyte)] = typeof(SByteConverter);
					hashtable[typeof(char)] = typeof(CharConverter);
					hashtable[typeof(double)] = typeof(DoubleConverter);
					hashtable[typeof(string)] = typeof(StringConverter);
					hashtable[typeof(int)] = typeof(Int32Converter);
					hashtable[typeof(short)] = typeof(Int16Converter);
					hashtable[typeof(long)] = typeof(Int64Converter);
					hashtable[typeof(float)] = typeof(SingleConverter);
					hashtable[typeof(ushort)] = typeof(UInt16Converter);
					hashtable[typeof(uint)] = typeof(UInt32Converter);
					hashtable[typeof(ulong)] = typeof(UInt64Converter);
					hashtable[typeof(object)] = typeof(TypeConverter);
					hashtable[typeof(void)] = typeof(TypeConverter);
					hashtable[typeof(CultureInfo)] = typeof(CultureInfoConverter);
					hashtable[typeof(DateTime)] = typeof(DateTimeConverter);
					hashtable[typeof(DateTimeOffset)] = typeof(DateTimeOffsetConverter);
					hashtable[typeof(decimal)] = typeof(DecimalConverter);
					hashtable[typeof(TimeSpan)] = typeof(TimeSpanConverter);
					hashtable[typeof(Guid)] = typeof(GuidConverter);
					hashtable[typeof(Array)] = typeof(ArrayConverter);
					hashtable[typeof(ICollection)] = typeof(CollectionConverter);
					hashtable[typeof(Enum)] = typeof(EnumConverter);
					hashtable[ReflectTypeDescriptionProvider._intrinsicReferenceKey] = typeof(ReferenceConverter);
					hashtable[ReflectTypeDescriptionProvider._intrinsicNullableKey] = typeof(NullableConverter);
					ReflectTypeDescriptionProvider._intrinsicTypeConverters = hashtable;
				}
				return ReflectTypeDescriptionProvider._intrinsicTypeConverters;
			}
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x000546EC File Offset: 0x000528EC
		public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			object obj;
			if (argTypes != null)
			{
				obj = SecurityUtils.SecureConstructorInvoke(objectType, argTypes, args, true, BindingFlags.ExactBinding);
			}
			else
			{
				if (args != null)
				{
					argTypes = new Type[args.Length];
					for (int i = 0; i < args.Length; i++)
					{
						if (args[i] != null)
						{
							argTypes[i] = args[i].GetType();
						}
						else
						{
							argTypes[i] = typeof(object);
						}
					}
				}
				else
				{
					argTypes = new Type[0];
				}
				obj = SecurityUtils.SecureConstructorInvoke(objectType, argTypes, args, true);
			}
			if (obj == null)
			{
				obj = SecurityUtils.SecureCreateInstance(objectType, args);
			}
			return obj;
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00054774 File Offset: 0x00052974
		private static object CreateInstance(Type objectType, Type callingType)
		{
			object obj = SecurityUtils.SecureConstructorInvoke(objectType, ReflectTypeDescriptionProvider._typeConstructor, new object[]
			{
				callingType
			}, false);
			if (obj == null)
			{
				obj = SecurityUtils.SecureCreateInstance(objectType);
			}
			return obj;
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x000547A3 File Offset: 0x000529A3
		internal AttributeCollection GetAttributes(Type type)
		{
			return this.GetTypeData(type, true).GetAttributes();
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x000547B4 File Offset: 0x000529B4
		public override IDictionary GetCache(object instance)
		{
			IComponent component = instance as IComponent;
			if (component != null && component.Site != null)
			{
				IDictionaryService dictionaryService = component.Site.GetService(typeof(IDictionaryService)) as IDictionaryService;
				if (dictionaryService != null)
				{
					IDictionary dictionary = dictionaryService.GetValue(ReflectTypeDescriptionProvider._dictionaryKey) as IDictionary;
					if (dictionary == null)
					{
						dictionary = new Hashtable();
						dictionaryService.SetValue(ReflectTypeDescriptionProvider._dictionaryKey, dictionary);
					}
					return dictionary;
				}
			}
			return null;
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0005481A File Offset: 0x00052A1A
		internal string GetClassName(Type type)
		{
			return this.GetTypeData(type, true).GetClassName(null);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0005482A File Offset: 0x00052A2A
		internal string GetComponentName(Type type, object instance)
		{
			return this.GetTypeData(type, true).GetComponentName(instance);
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x0005483A File Offset: 0x00052A3A
		internal TypeConverter GetConverter(Type type, object instance)
		{
			return this.GetTypeData(type, true).GetConverter(instance);
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x0005484A File Offset: 0x00052A4A
		internal EventDescriptor GetDefaultEvent(Type type, object instance)
		{
			return this.GetTypeData(type, true).GetDefaultEvent(instance);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0005485A File Offset: 0x00052A5A
		internal PropertyDescriptor GetDefaultProperty(Type type, object instance)
		{
			return this.GetTypeData(type, true).GetDefaultProperty(instance);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x0005486A File Offset: 0x00052A6A
		internal object GetEditor(Type type, object instance, Type editorBaseType)
		{
			return this.GetTypeData(type, true).GetEditor(instance, editorBaseType);
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x0005487C File Offset: 0x00052A7C
		private static Hashtable GetEditorTable(Type editorBaseType)
		{
			if (ReflectTypeDescriptionProvider._editorTables == null)
			{
				object internalSyncObject = ReflectTypeDescriptionProvider._internalSyncObject;
				lock (internalSyncObject)
				{
					if (ReflectTypeDescriptionProvider._editorTables == null)
					{
						ReflectTypeDescriptionProvider._editorTables = new Hashtable(4);
					}
				}
			}
			object obj = ReflectTypeDescriptionProvider._editorTables[editorBaseType];
			if (obj == null)
			{
				RuntimeHelpers.RunClassConstructor(editorBaseType.TypeHandle);
				obj = ReflectTypeDescriptionProvider._editorTables[editorBaseType];
				if (obj == null)
				{
					object internalSyncObject = ReflectTypeDescriptionProvider._internalSyncObject;
					lock (internalSyncObject)
					{
						obj = ReflectTypeDescriptionProvider._editorTables[editorBaseType];
						if (obj == null)
						{
							ReflectTypeDescriptionProvider._editorTables[editorBaseType] = ReflectTypeDescriptionProvider._editorTables;
						}
					}
				}
			}
			if (obj == ReflectTypeDescriptionProvider._editorTables)
			{
				obj = null;
			}
			return (Hashtable)obj;
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00054960 File Offset: 0x00052B60
		internal EventDescriptorCollection GetEvents(Type type)
		{
			return this.GetTypeData(type, true).GetEvents();
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x0005496F File Offset: 0x00052B6F
		internal AttributeCollection GetExtendedAttributes(object instance)
		{
			return AttributeCollection.Empty;
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00054976 File Offset: 0x00052B76
		internal string GetExtendedClassName(object instance)
		{
			return this.GetClassName(instance.GetType());
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00054984 File Offset: 0x00052B84
		internal string GetExtendedComponentName(object instance)
		{
			return this.GetComponentName(instance.GetType(), instance);
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00054993 File Offset: 0x00052B93
		internal TypeConverter GetExtendedConverter(object instance)
		{
			return this.GetConverter(instance.GetType(), instance);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x000022FE File Offset: 0x000004FE
		internal EventDescriptor GetExtendedDefaultEvent(object instance)
		{
			return null;
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x000022FE File Offset: 0x000004FE
		internal PropertyDescriptor GetExtendedDefaultProperty(object instance)
		{
			return null;
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x000549A2 File Offset: 0x00052BA2
		internal object GetExtendedEditor(object instance, Type editorBaseType)
		{
			return this.GetEditor(instance.GetType(), instance, editorBaseType);
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x000549B2 File Offset: 0x00052BB2
		internal EventDescriptorCollection GetExtendedEvents(object instance)
		{
			return EventDescriptorCollection.Empty;
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x000549BC File Offset: 0x00052BBC
		internal PropertyDescriptorCollection GetExtendedProperties(object instance)
		{
			Type type = instance.GetType();
			IExtenderProvider[] extenderProviders = this.GetExtenderProviders(instance);
			IDictionary cache = TypeDescriptor.GetCache(instance);
			if (extenderProviders.Length == 0)
			{
				return PropertyDescriptorCollection.Empty;
			}
			PropertyDescriptorCollection propertyDescriptorCollection = null;
			if (cache != null)
			{
				propertyDescriptorCollection = (cache[ReflectTypeDescriptionProvider._extenderPropertiesKey] as PropertyDescriptorCollection);
			}
			if (propertyDescriptorCollection != null)
			{
				return propertyDescriptorCollection;
			}
			ArrayList arrayList = null;
			for (int i = 0; i < extenderProviders.Length; i++)
			{
				PropertyDescriptor[] array = ReflectTypeDescriptionProvider.ReflectGetExtendedProperties(extenderProviders[i]);
				if (arrayList == null)
				{
					arrayList = new ArrayList(array.Length * extenderProviders.Length);
				}
				foreach (PropertyDescriptor propertyDescriptor in array)
				{
					ExtenderProvidedPropertyAttribute extenderProvidedPropertyAttribute = propertyDescriptor.Attributes[typeof(ExtenderProvidedPropertyAttribute)] as ExtenderProvidedPropertyAttribute;
					if (extenderProvidedPropertyAttribute != null)
					{
						Type receiverType = extenderProvidedPropertyAttribute.ReceiverType;
						if (receiverType != null && receiverType.IsAssignableFrom(type))
						{
							arrayList.Add(propertyDescriptor);
						}
					}
				}
			}
			if (arrayList != null)
			{
				PropertyDescriptor[] array2 = new PropertyDescriptor[arrayList.Count];
				arrayList.CopyTo(array2, 0);
				propertyDescriptorCollection = new PropertyDescriptorCollection(array2, true);
			}
			else
			{
				propertyDescriptorCollection = PropertyDescriptorCollection.Empty;
			}
			if (cache != null)
			{
				cache[ReflectTypeDescriptionProvider._extenderPropertiesKey] = propertyDescriptorCollection;
			}
			return propertyDescriptorCollection;
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x00054AE8 File Offset: 0x00052CE8
		protected internal override IExtenderProvider[] GetExtenderProviders(object instance)
		{
			if (instance == null)
			{
				throw new ArgumentNullException("instance");
			}
			IComponent component = instance as IComponent;
			if (component != null && component.Site != null)
			{
				IExtenderListService extenderListService = component.Site.GetService(typeof(IExtenderListService)) as IExtenderListService;
				IDictionary cache = TypeDescriptor.GetCache(instance);
				if (extenderListService != null)
				{
					return ReflectTypeDescriptionProvider.GetExtenders(extenderListService.GetExtenderProviders(), instance, cache);
				}
				IContainer container = component.Site.Container;
				if (container != null)
				{
					return ReflectTypeDescriptionProvider.GetExtenders(container.Components, instance, cache);
				}
			}
			return new IExtenderProvider[0];
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00054B6C File Offset: 0x00052D6C
		private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache)
		{
			bool flag = false;
			int num = 0;
			IExtenderProvider[] array = null;
			ulong num2 = 0UL;
			int num3 = 64;
			IExtenderProvider[] array2 = components as IExtenderProvider[];
			if (cache != null)
			{
				array = (cache[ReflectTypeDescriptionProvider._extenderProviderKey] as IExtenderProvider[]);
			}
			if (array == null)
			{
				flag = true;
			}
			int i = 0;
			int num4 = 0;
			if (array2 != null)
			{
				for (i = 0; i < array2.Length; i++)
				{
					if (array2[i].CanExtend(instance))
					{
						num++;
						if (i < num3)
						{
							num2 |= 1UL << i;
						}
						if (!flag && (num4 >= array.Length || array2[i] != array[num4++]))
						{
							flag = true;
						}
					}
				}
			}
			else if (components != null)
			{
				foreach (object obj in components)
				{
					IExtenderProvider extenderProvider = obj as IExtenderProvider;
					if (extenderProvider != null && extenderProvider.CanExtend(instance))
					{
						num++;
						if (i < num3)
						{
							num2 |= 1UL << i;
						}
						if (!flag && (num4 >= array.Length || extenderProvider != array[num4++]))
						{
							flag = true;
						}
					}
					i++;
				}
			}
			if (array != null && num != array.Length)
			{
				flag = true;
			}
			if (flag)
			{
				if (array2 == null || num != array2.Length)
				{
					IExtenderProvider[] array3 = new IExtenderProvider[num];
					i = 0;
					num4 = 0;
					if (array2 != null && num > 0)
					{
						while (i < array2.Length)
						{
							if ((i < num3 && (num2 & 1UL << i) != 0UL) || (i >= num3 && array2[i].CanExtend(instance)))
							{
								array3[num4++] = array2[i];
							}
							i++;
						}
					}
					else if (num > 0)
					{
						foreach (object obj2 in components)
						{
							IExtenderProvider extenderProvider2 = obj2 as IExtenderProvider;
							if (extenderProvider2 != null && ((i < num3 && (num2 & 1UL << i) != 0UL) || (i >= num3 && extenderProvider2.CanExtend(instance))))
							{
								array3[num4++] = extenderProvider2;
							}
							i++;
						}
					}
					array2 = array3;
				}
				if (cache != null)
				{
					cache[ReflectTypeDescriptionProvider._extenderProviderKey] = array2;
					cache.Remove(ReflectTypeDescriptionProvider._extenderPropertiesKey);
				}
			}
			else
			{
				array2 = array;
			}
			return array2;
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00054DA0 File Offset: 0x00052FA0
		internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd)
		{
			return this.GetPropertyOwner(instance.GetType(), instance, pd);
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x000022FE File Offset: 0x000004FE
		public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
		{
			return null;
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00054DB0 File Offset: 0x00052FB0
		internal PropertyDescriptorCollection GetProperties(Type type)
		{
			return this.GetTypeData(type, true).GetProperties();
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00054DBF File Offset: 0x00052FBF
		internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd)
		{
			return TypeDescriptor.GetAssociation(type, instance);
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00054DC8 File Offset: 0x00052FC8
		public override Type GetReflectionType(Type objectType, object instance)
		{
			return objectType;
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00054DCC File Offset: 0x00052FCC
		private ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(Type type, bool createIfNeeded)
		{
			ReflectTypeDescriptionProvider.ReflectedTypeData reflectedTypeData = null;
			if (this._typeData != null)
			{
				reflectedTypeData = (ReflectTypeDescriptionProvider.ReflectedTypeData)this._typeData[type];
				if (reflectedTypeData != null)
				{
					return reflectedTypeData;
				}
			}
			object internalSyncObject = ReflectTypeDescriptionProvider._internalSyncObject;
			lock (internalSyncObject)
			{
				if (this._typeData != null)
				{
					reflectedTypeData = (ReflectTypeDescriptionProvider.ReflectedTypeData)this._typeData[type];
				}
				if (reflectedTypeData == null && createIfNeeded)
				{
					reflectedTypeData = new ReflectTypeDescriptionProvider.ReflectedTypeData(type);
					if (this._typeData == null)
					{
						this._typeData = new Hashtable();
					}
					this._typeData[type] = reflectedTypeData;
				}
			}
			return reflectedTypeData;
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x000022FE File Offset: 0x000004FE
		public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
		{
			return null;
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00054E70 File Offset: 0x00053070
		private static Type GetTypeFromName(string typeName)
		{
			Type type = Type.GetType(typeName);
			if (type == null)
			{
				int num = typeName.IndexOf(',');
				if (num != -1)
				{
					type = Type.GetType(typeName.Substring(0, num));
				}
			}
			return type;
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00054EAC File Offset: 0x000530AC
		internal bool IsPopulated(Type type)
		{
			ReflectTypeDescriptionProvider.ReflectedTypeData typeData = this.GetTypeData(type, false);
			return typeData != null && typeData.IsPopulated;
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00054ED0 File Offset: 0x000530D0
		private static Attribute[] ReflectGetAttributes(Type type)
		{
			object internalSyncObject;
			if (ReflectTypeDescriptionProvider._attributeCache == null)
			{
				internalSyncObject = ReflectTypeDescriptionProvider._internalSyncObject;
				lock (internalSyncObject)
				{
					if (ReflectTypeDescriptionProvider._attributeCache == null)
					{
						ReflectTypeDescriptionProvider._attributeCache = new Hashtable();
					}
				}
			}
			Attribute[] array = (Attribute[])ReflectTypeDescriptionProvider._attributeCache[type];
			if (array != null)
			{
				return array;
			}
			internalSyncObject = ReflectTypeDescriptionProvider._internalSyncObject;
			lock (internalSyncObject)
			{
				array = (Attribute[])ReflectTypeDescriptionProvider._attributeCache[type];
				if (array == null)
				{
					object[] customAttributes = type.GetCustomAttributes(typeof(Attribute), false);
					array = new Attribute[customAttributes.Length];
					customAttributes.CopyTo(array, 0);
					ReflectTypeDescriptionProvider._attributeCache[type] = array;
				}
			}
			return array;
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00054FB0 File Offset: 0x000531B0
		internal static Attribute[] ReflectGetAttributes(MemberInfo member)
		{
			object internalSyncObject;
			if (ReflectTypeDescriptionProvider._attributeCache == null)
			{
				internalSyncObject = ReflectTypeDescriptionProvider._internalSyncObject;
				lock (internalSyncObject)
				{
					if (ReflectTypeDescriptionProvider._attributeCache == null)
					{
						ReflectTypeDescriptionProvider._attributeCache = new Hashtable();
					}
				}
			}
			Attribute[] array = (Attribute[])ReflectTypeDescriptionProvider._attributeCache[member];
			if (array != null)
			{
				return array;
			}
			internalSyncObject = ReflectTypeDescriptionProvider._internalSyncObject;
			lock (internalSyncObject)
			{
				array = (Attribute[])ReflectTypeDescriptionProvider._attributeCache[member];
				if (array == null)
				{
					object[] customAttributes = member.GetCustomAttributes(typeof(Attribute), false);
					array = new Attribute[customAttributes.Length];
					customAttributes.CopyTo(array, 0);
					ReflectTypeDescriptionProvider._attributeCache[member] = array;
				}
			}
			return array;
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00055090 File Offset: 0x00053290
		private static EventDescriptor[] ReflectGetEvents(Type type)
		{
			object internalSyncObject;
			if (ReflectTypeDescriptionProvider._eventCache == null)
			{
				internalSyncObject = ReflectTypeDescriptionProvider._internalSyncObject;
				lock (internalSyncObject)
				{
					if (ReflectTypeDescriptionProvider._eventCache == null)
					{
						ReflectTypeDescriptionProvider._eventCache = new Hashtable();
					}
				}
			}
			EventDescriptor[] array = (EventDescriptor[])ReflectTypeDescriptionProvider._eventCache[type];
			if (array != null)
			{
				return array;
			}
			internalSyncObject = ReflectTypeDescriptionProvider._internalSyncObject;
			lock (internalSyncObject)
			{
				array = (EventDescriptor[])ReflectTypeDescriptionProvider._eventCache[type];
				if (array == null)
				{
					BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public;
					EventInfo[] events = type.GetEvents(bindingAttr);
					array = new EventDescriptor[events.Length];
					int num = 0;
					foreach (EventInfo eventInfo in events)
					{
						if (eventInfo.DeclaringType.IsPublic || eventInfo.DeclaringType.IsNestedPublic || !(eventInfo.DeclaringType.Assembly == typeof(ReflectTypeDescriptionProvider).Assembly))
						{
							MethodInfo addMethod = eventInfo.GetAddMethod();
							MethodInfo removeMethod = eventInfo.GetRemoveMethod();
							if (addMethod != null && removeMethod != null)
							{
								array[num++] = new ReflectEventDescriptor(type, eventInfo);
							}
						}
					}
					if (num != array.Length)
					{
						EventDescriptor[] array2 = new EventDescriptor[num];
						Array.Copy(array, 0, array2, 0, num);
						array = array2;
					}
					ReflectTypeDescriptionProvider._eventCache[type] = array;
				}
			}
			return array;
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00055218 File Offset: 0x00053418
		private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider)
		{
			IDictionary cache = TypeDescriptor.GetCache(provider);
			PropertyDescriptor[] array;
			if (cache != null)
			{
				array = (cache[ReflectTypeDescriptionProvider._extenderProviderPropertiesKey] as PropertyDescriptor[]);
				if (array != null)
				{
					return array;
				}
			}
			if (ReflectTypeDescriptionProvider._extendedPropertyCache == null)
			{
				object internalSyncObject = ReflectTypeDescriptionProvider._internalSyncObject;
				lock (internalSyncObject)
				{
					if (ReflectTypeDescriptionProvider._extendedPropertyCache == null)
					{
						ReflectTypeDescriptionProvider._extendedPropertyCache = new Hashtable();
					}
				}
			}
			Type type = provider.GetType();
			ReflectPropertyDescriptor[] array2 = (ReflectPropertyDescriptor[])ReflectTypeDescriptionProvider._extendedPropertyCache[type];
			if (array2 == null)
			{
				object internalSyncObject = ReflectTypeDescriptionProvider._internalSyncObject;
				lock (internalSyncObject)
				{
					array2 = (ReflectPropertyDescriptor[])ReflectTypeDescriptionProvider._extendedPropertyCache[type];
					if (array2 == null)
					{
						AttributeCollection attributes = TypeDescriptor.GetAttributes(type);
						ArrayList arrayList = new ArrayList(attributes.Count);
						foreach (object obj in attributes)
						{
							ProvidePropertyAttribute providePropertyAttribute = ((Attribute)obj) as ProvidePropertyAttribute;
							if (providePropertyAttribute != null)
							{
								Type typeFromName = ReflectTypeDescriptionProvider.GetTypeFromName(providePropertyAttribute.ReceiverTypeName);
								if (typeFromName != null)
								{
									MethodInfo method = type.GetMethod("Get" + providePropertyAttribute.PropertyName, new Type[]
									{
										typeFromName
									});
									if (method != null && !method.IsStatic && method.IsPublic)
									{
										MethodInfo methodInfo = type.GetMethod("Set" + providePropertyAttribute.PropertyName, new Type[]
										{
											typeFromName,
											method.ReturnType
										});
										if (methodInfo != null && (methodInfo.IsStatic || !methodInfo.IsPublic))
										{
											methodInfo = null;
										}
										arrayList.Add(new ReflectPropertyDescriptor(type, providePropertyAttribute.PropertyName, method.ReturnType, typeFromName, method, methodInfo, null));
									}
								}
							}
						}
						array2 = new ReflectPropertyDescriptor[arrayList.Count];
						arrayList.CopyTo(array2, 0);
						ReflectTypeDescriptionProvider._extendedPropertyCache[type] = array2;
					}
				}
			}
			array = new PropertyDescriptor[array2.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				Attribute[] attributes2 = null;
				IComponent component = provider as IComponent;
				if (component == null || component.Site == null)
				{
					attributes2 = new Attribute[]
					{
						DesignOnlyAttribute.Yes
					};
				}
				ReflectPropertyDescriptor reflectPropertyDescriptor = array2[i];
				ExtendedPropertyDescriptor extendedPropertyDescriptor = new ExtendedPropertyDescriptor(reflectPropertyDescriptor, reflectPropertyDescriptor.ExtenderGetReceiverType(), provider, attributes2);
				array[i] = extendedPropertyDescriptor;
			}
			if (cache != null)
			{
				cache[ReflectTypeDescriptionProvider._extenderProviderPropertiesKey] = array;
			}
			return array;
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x000554F0 File Offset: 0x000536F0
		private static PropertyDescriptor[] ReflectGetProperties(Type type)
		{
			object internalSyncObject;
			if (ReflectTypeDescriptionProvider._propertyCache == null)
			{
				internalSyncObject = ReflectTypeDescriptionProvider._internalSyncObject;
				lock (internalSyncObject)
				{
					if (ReflectTypeDescriptionProvider._propertyCache == null)
					{
						ReflectTypeDescriptionProvider._propertyCache = new Hashtable();
					}
				}
			}
			PropertyDescriptor[] array = (PropertyDescriptor[])ReflectTypeDescriptionProvider._propertyCache[type];
			if (array != null)
			{
				return array;
			}
			internalSyncObject = ReflectTypeDescriptionProvider._internalSyncObject;
			lock (internalSyncObject)
			{
				array = (PropertyDescriptor[])ReflectTypeDescriptionProvider._propertyCache[type];
				if (array == null)
				{
					BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public;
					PropertyInfo[] properties = type.GetProperties(bindingAttr);
					array = new PropertyDescriptor[properties.Length];
					int num = 0;
					foreach (PropertyInfo propertyInfo in properties)
					{
						if (propertyInfo.GetIndexParameters().Length == 0)
						{
							MethodInfo getMethod = propertyInfo.GetGetMethod();
							MethodInfo setMethod = propertyInfo.GetSetMethod();
							string name = propertyInfo.Name;
							if (getMethod != null)
							{
								array[num++] = new ReflectPropertyDescriptor(type, name, propertyInfo.PropertyType, propertyInfo, getMethod, setMethod, null);
							}
						}
					}
					if (num != array.Length)
					{
						PropertyDescriptor[] array2 = new PropertyDescriptor[num];
						Array.Copy(array, 0, array2, 0, num);
						array = array2;
					}
					ReflectTypeDescriptionProvider._propertyCache[type] = array;
				}
			}
			return array;
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00055650 File Offset: 0x00053850
		internal void Refresh(Type type)
		{
			ReflectTypeDescriptionProvider.ReflectedTypeData typeData = this.GetTypeData(type, false);
			if (typeData != null)
			{
				typeData.Refresh();
			}
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00055670 File Offset: 0x00053870
		private static object SearchIntrinsicTable(Hashtable table, Type callingType)
		{
			object obj = null;
			lock (table)
			{
				Type type = callingType;
				while (type != null && type != typeof(object))
				{
					obj = table[type];
					string text = obj as string;
					if (text != null)
					{
						obj = Type.GetType(text);
						if (obj != null)
						{
							table[type] = obj;
						}
					}
					if (obj != null)
					{
						break;
					}
					type = type.BaseType;
				}
				if (obj == null)
				{
					foreach (object obj2 in table)
					{
						DictionaryEntry dictionaryEntry = (DictionaryEntry)obj2;
						Type type2 = dictionaryEntry.Key as Type;
						if (type2 != null && type2.IsInterface && type2.IsAssignableFrom(callingType))
						{
							obj = dictionaryEntry.Value;
							string text2 = obj as string;
							if (text2 != null)
							{
								obj = Type.GetType(text2);
								if (obj != null)
								{
									table[callingType] = obj;
								}
							}
							if (obj != null)
							{
								break;
							}
						}
					}
				}
				if (obj == null)
				{
					if (callingType.IsGenericType && callingType.GetGenericTypeDefinition() == typeof(Nullable<>))
					{
						obj = table[ReflectTypeDescriptionProvider._intrinsicNullableKey];
					}
					else if (callingType.IsInterface)
					{
						obj = table[ReflectTypeDescriptionProvider._intrinsicReferenceKey];
					}
				}
				if (obj == null)
				{
					obj = table[typeof(object)];
				}
				Type type3 = obj as Type;
				if (type3 != null)
				{
					obj = ReflectTypeDescriptionProvider.CreateInstance(type3, callingType);
					if (type3.GetConstructor(ReflectTypeDescriptionProvider._typeConstructor) == null)
					{
						table[callingType] = obj;
					}
				}
			}
			return obj;
		}

		// Token: 0x04000CCC RID: 3276
		private Hashtable _typeData;

		// Token: 0x04000CCD RID: 3277
		private static Type[] _typeConstructor = new Type[]
		{
			typeof(Type)
		};

		// Token: 0x04000CCE RID: 3278
		private static volatile Hashtable _editorTables;

		// Token: 0x04000CCF RID: 3279
		private static volatile Hashtable _intrinsicTypeConverters;

		// Token: 0x04000CD0 RID: 3280
		private static object _intrinsicReferenceKey = new object();

		// Token: 0x04000CD1 RID: 3281
		private static object _intrinsicNullableKey = new object();

		// Token: 0x04000CD2 RID: 3282
		private static object _dictionaryKey = new object();

		// Token: 0x04000CD3 RID: 3283
		private static volatile Hashtable _propertyCache;

		// Token: 0x04000CD4 RID: 3284
		private static volatile Hashtable _eventCache;

		// Token: 0x04000CD5 RID: 3285
		private static volatile Hashtable _attributeCache;

		// Token: 0x04000CD6 RID: 3286
		private static volatile Hashtable _extendedPropertyCache;

		// Token: 0x04000CD7 RID: 3287
		private static readonly Guid _extenderProviderKey = Guid.NewGuid();

		// Token: 0x04000CD8 RID: 3288
		private static readonly Guid _extenderPropertiesKey = Guid.NewGuid();

		// Token: 0x04000CD9 RID: 3289
		private static readonly Guid _extenderProviderPropertiesKey = Guid.NewGuid();

		// Token: 0x04000CDA RID: 3290
		private static readonly Type[] _skipInterfaceAttributeList = new Type[]
		{
			typeof(GuidAttribute),
			typeof(ComVisibleAttribute),
			typeof(InterfaceTypeAttribute)
		};

		// Token: 0x04000CDB RID: 3291
		private static object _internalSyncObject = new object();

		// Token: 0x020002A2 RID: 674
		private class ReflectedTypeData
		{
			// Token: 0x060011FB RID: 4603 RVA: 0x000558DD File Offset: 0x00053ADD
			internal ReflectedTypeData(Type type)
			{
				this._type = type;
			}

			// Token: 0x170003A4 RID: 932
			// (get) Token: 0x060011FC RID: 4604 RVA: 0x000558EC File Offset: 0x00053AEC
			internal bool IsPopulated
			{
				get
				{
					return this._attributes != null | this._events != null | this._properties != null;
				}
			}

			// Token: 0x060011FD RID: 4605 RVA: 0x0005590C File Offset: 0x00053B0C
			internal AttributeCollection GetAttributes()
			{
				if (this._attributes == null)
				{
					Attribute[] array = ReflectTypeDescriptionProvider.ReflectGetAttributes(this._type);
					Type baseType = this._type.BaseType;
					while (baseType != null && baseType != typeof(object))
					{
						Attribute[] array2 = ReflectTypeDescriptionProvider.ReflectGetAttributes(baseType);
						Attribute[] array3 = new Attribute[array.Length + array2.Length];
						Array.Copy(array, 0, array3, 0, array.Length);
						Array.Copy(array2, 0, array3, array.Length, array2.Length);
						array = array3;
						baseType = baseType.BaseType;
					}
					int num = array.Length;
					foreach (Type type in this._type.GetInterfaces())
					{
						if ((type.Attributes & TypeAttributes.NestedPrivate) != TypeAttributes.NotPublic)
						{
							AttributeCollection attributes = TypeDescriptor.GetAttributes(type);
							if (attributes.Count > 0)
							{
								Attribute[] array4 = new Attribute[array.Length + attributes.Count];
								Array.Copy(array, 0, array4, 0, array.Length);
								attributes.CopyTo(array4, array.Length);
								array = array4;
							}
						}
					}
					OrderedDictionary orderedDictionary = new OrderedDictionary(array.Length);
					for (int j = 0; j < array.Length; j++)
					{
						bool flag = true;
						if (j >= num)
						{
							for (int k = 0; k < ReflectTypeDescriptionProvider._skipInterfaceAttributeList.Length; k++)
							{
								if (ReflectTypeDescriptionProvider._skipInterfaceAttributeList[k].IsInstanceOfType(array[j]))
								{
									flag = false;
									break;
								}
							}
						}
						if (flag && !orderedDictionary.Contains(array[j].TypeId))
						{
							orderedDictionary[array[j].TypeId] = array[j];
						}
					}
					array = new Attribute[orderedDictionary.Count];
					orderedDictionary.Values.CopyTo(array, 0);
					this._attributes = new AttributeCollection(array);
				}
				return this._attributes;
			}

			// Token: 0x060011FE RID: 4606 RVA: 0x00055AB5 File Offset: 0x00053CB5
			internal string GetClassName(object instance)
			{
				return this._type.FullName;
			}

			// Token: 0x060011FF RID: 4607 RVA: 0x00055AC4 File Offset: 0x00053CC4
			internal string GetComponentName(object instance)
			{
				IComponent component = instance as IComponent;
				if (component != null)
				{
					ISite site = component.Site;
					if (site != null)
					{
						INestedSite nestedSite = site as INestedSite;
						if (nestedSite != null)
						{
							return nestedSite.FullName;
						}
						return site.Name;
					}
				}
				return null;
			}

			// Token: 0x06001200 RID: 4608 RVA: 0x00055B00 File Offset: 0x00053D00
			internal TypeConverter GetConverter(object instance)
			{
				TypeConverterAttribute typeConverterAttribute = null;
				if (instance != null)
				{
					typeConverterAttribute = (TypeConverterAttribute)TypeDescriptor.GetAttributes(this._type)[typeof(TypeConverterAttribute)];
					TypeConverterAttribute typeConverterAttribute2 = (TypeConverterAttribute)TypeDescriptor.GetAttributes(instance)[typeof(TypeConverterAttribute)];
					if (typeConverterAttribute != typeConverterAttribute2)
					{
						Type typeFromName = this.GetTypeFromName(typeConverterAttribute2.ConverterTypeName);
						if (typeFromName != null && typeof(TypeConverter).IsAssignableFrom(typeFromName))
						{
							return (TypeConverter)ReflectTypeDescriptionProvider.CreateInstance(typeFromName, this._type);
						}
					}
				}
				if (this._converter == null)
				{
					if (typeConverterAttribute == null)
					{
						typeConverterAttribute = (TypeConverterAttribute)TypeDescriptor.GetAttributes(this._type)[typeof(TypeConverterAttribute)];
					}
					if (typeConverterAttribute != null)
					{
						Type typeFromName2 = this.GetTypeFromName(typeConverterAttribute.ConverterTypeName);
						if (typeFromName2 != null && typeof(TypeConverter).IsAssignableFrom(typeFromName2))
						{
							this._converter = (TypeConverter)ReflectTypeDescriptionProvider.CreateInstance(typeFromName2, this._type);
						}
					}
					if (this._converter == null)
					{
						this._converter = (TypeConverter)ReflectTypeDescriptionProvider.SearchIntrinsicTable(ReflectTypeDescriptionProvider.IntrinsicTypeConverters, this._type);
					}
				}
				return this._converter;
			}

			// Token: 0x06001201 RID: 4609 RVA: 0x00055C24 File Offset: 0x00053E24
			internal EventDescriptor GetDefaultEvent(object instance)
			{
				AttributeCollection attributes;
				if (instance != null)
				{
					attributes = TypeDescriptor.GetAttributes(instance);
				}
				else
				{
					attributes = TypeDescriptor.GetAttributes(this._type);
				}
				DefaultEventAttribute defaultEventAttribute = (DefaultEventAttribute)attributes[typeof(DefaultEventAttribute)];
				if (defaultEventAttribute == null || defaultEventAttribute.Name == null)
				{
					return null;
				}
				if (instance != null)
				{
					return TypeDescriptor.GetEvents(instance)[defaultEventAttribute.Name];
				}
				return TypeDescriptor.GetEvents(this._type)[defaultEventAttribute.Name];
			}

			// Token: 0x06001202 RID: 4610 RVA: 0x00055C98 File Offset: 0x00053E98
			internal PropertyDescriptor GetDefaultProperty(object instance)
			{
				AttributeCollection attributes;
				if (instance != null)
				{
					attributes = TypeDescriptor.GetAttributes(instance);
				}
				else
				{
					attributes = TypeDescriptor.GetAttributes(this._type);
				}
				DefaultPropertyAttribute defaultPropertyAttribute = (DefaultPropertyAttribute)attributes[typeof(DefaultPropertyAttribute)];
				if (defaultPropertyAttribute == null || defaultPropertyAttribute.Name == null)
				{
					return null;
				}
				if (instance != null)
				{
					return TypeDescriptor.GetProperties(instance)[defaultPropertyAttribute.Name];
				}
				return TypeDescriptor.GetProperties(this._type)[defaultPropertyAttribute.Name];
			}

			// Token: 0x06001203 RID: 4611 RVA: 0x00055D0C File Offset: 0x00053F0C
			internal object GetEditor(object instance, Type editorBaseType)
			{
				EditorAttribute editorAttribute;
				if (instance != null)
				{
					editorAttribute = ReflectTypeDescriptionProvider.ReflectedTypeData.GetEditorAttribute(TypeDescriptor.GetAttributes(this._type), editorBaseType);
					EditorAttribute editorAttribute2 = ReflectTypeDescriptionProvider.ReflectedTypeData.GetEditorAttribute(TypeDescriptor.GetAttributes(instance), editorBaseType);
					if (editorAttribute != editorAttribute2)
					{
						Type typeFromName = this.GetTypeFromName(editorAttribute2.EditorTypeName);
						if (typeFromName != null && editorBaseType.IsAssignableFrom(typeFromName))
						{
							return ReflectTypeDescriptionProvider.CreateInstance(typeFromName, this._type);
						}
					}
				}
				ReflectTypeDescriptionProvider.ReflectedTypeData obj = this;
				lock (obj)
				{
					for (int i = 0; i < this._editorCount; i++)
					{
						if (this._editorTypes[i] == editorBaseType)
						{
							return this._editors[i];
						}
					}
				}
				object obj2 = null;
				editorAttribute = ReflectTypeDescriptionProvider.ReflectedTypeData.GetEditorAttribute(TypeDescriptor.GetAttributes(this._type), editorBaseType);
				if (editorAttribute != null)
				{
					Type typeFromName2 = this.GetTypeFromName(editorAttribute.EditorTypeName);
					if (typeFromName2 != null && editorBaseType.IsAssignableFrom(typeFromName2))
					{
						obj2 = ReflectTypeDescriptionProvider.CreateInstance(typeFromName2, this._type);
					}
				}
				if (obj2 == null)
				{
					Hashtable editorTable = ReflectTypeDescriptionProvider.GetEditorTable(editorBaseType);
					if (editorTable != null)
					{
						obj2 = ReflectTypeDescriptionProvider.SearchIntrinsicTable(editorTable, this._type);
					}
					if (obj2 != null && !editorBaseType.IsInstanceOfType(obj2))
					{
						obj2 = null;
					}
				}
				if (obj2 != null)
				{
					obj = this;
					lock (obj)
					{
						if (this._editorTypes == null || this._editorTypes.Length == this._editorCount)
						{
							int num = (this._editorTypes == null) ? 4 : (this._editorTypes.Length * 2);
							Type[] array = new Type[num];
							object[] array2 = new object[num];
							if (this._editorTypes != null)
							{
								this._editorTypes.CopyTo(array, 0);
								this._editors.CopyTo(array2, 0);
							}
							this._editorTypes = array;
							this._editors = array2;
							this._editorTypes[this._editorCount] = editorBaseType;
							object[] editors = this._editors;
							int editorCount = this._editorCount;
							this._editorCount = editorCount + 1;
							editors[editorCount] = obj2;
						}
					}
				}
				return obj2;
			}

			// Token: 0x06001204 RID: 4612 RVA: 0x00055F10 File Offset: 0x00054110
			private static EditorAttribute GetEditorAttribute(AttributeCollection attributes, Type editorBaseType)
			{
				foreach (object obj in attributes)
				{
					EditorAttribute editorAttribute = ((Attribute)obj) as EditorAttribute;
					if (editorAttribute != null)
					{
						Type type = Type.GetType(editorAttribute.EditorBaseTypeName);
						if (type != null && type == editorBaseType)
						{
							return editorAttribute;
						}
					}
				}
				return null;
			}

			// Token: 0x06001205 RID: 4613 RVA: 0x00055F90 File Offset: 0x00054190
			internal EventDescriptorCollection GetEvents()
			{
				if (this._events == null)
				{
					Dictionary<string, EventDescriptor> dictionary = new Dictionary<string, EventDescriptor>(16);
					Type type = this._type;
					Type typeFromHandle = typeof(object);
					EventDescriptor[] array;
					do
					{
						array = ReflectTypeDescriptionProvider.ReflectGetEvents(type);
						foreach (EventDescriptor eventDescriptor in array)
						{
							if (!dictionary.ContainsKey(eventDescriptor.Name))
							{
								dictionary.Add(eventDescriptor.Name, eventDescriptor);
							}
						}
						type = type.BaseType;
					}
					while (type != null && type != typeFromHandle);
					array = new EventDescriptor[dictionary.Count];
					dictionary.Values.CopyTo(array, 0);
					this._events = new EventDescriptorCollection(array, true);
				}
				return this._events;
			}

			// Token: 0x06001206 RID: 4614 RVA: 0x0005604C File Offset: 0x0005424C
			internal PropertyDescriptorCollection GetProperties()
			{
				if (this._properties == null)
				{
					Dictionary<string, PropertyDescriptor> dictionary = new Dictionary<string, PropertyDescriptor>(10);
					Type type = this._type;
					Type typeFromHandle = typeof(object);
					PropertyDescriptor[] array;
					do
					{
						array = ReflectTypeDescriptionProvider.ReflectGetProperties(type);
						foreach (PropertyDescriptor propertyDescriptor in array)
						{
							if (!dictionary.ContainsKey(propertyDescriptor.Name))
							{
								dictionary.Add(propertyDescriptor.Name, propertyDescriptor);
							}
						}
						type = type.BaseType;
					}
					while (type != null && type != typeFromHandle);
					array = new PropertyDescriptor[dictionary.Count];
					dictionary.Values.CopyTo(array, 0);
					this._properties = new PropertyDescriptorCollection(array, true);
				}
				return this._properties;
			}

			// Token: 0x06001207 RID: 4615 RVA: 0x00056108 File Offset: 0x00054308
			private Type GetTypeFromName(string typeName)
			{
				if (typeName == null || typeName.Length == 0)
				{
					return null;
				}
				int num = typeName.IndexOf(',');
				Type type = null;
				if (num == -1)
				{
					type = this._type.Assembly.GetType(typeName);
				}
				if (type == null)
				{
					type = Type.GetType(typeName);
				}
				if (type == null && num != -1)
				{
					type = Type.GetType(typeName.Substring(0, num));
				}
				return type;
			}

			// Token: 0x06001208 RID: 4616 RVA: 0x0005616F File Offset: 0x0005436F
			internal void Refresh()
			{
				this._attributes = null;
				this._events = null;
				this._properties = null;
				this._converter = null;
				this._editors = null;
				this._editorTypes = null;
				this._editorCount = 0;
			}

			// Token: 0x04000CDC RID: 3292
			private Type _type;

			// Token: 0x04000CDD RID: 3293
			private AttributeCollection _attributes;

			// Token: 0x04000CDE RID: 3294
			private EventDescriptorCollection _events;

			// Token: 0x04000CDF RID: 3295
			private PropertyDescriptorCollection _properties;

			// Token: 0x04000CE0 RID: 3296
			private TypeConverter _converter;

			// Token: 0x04000CE1 RID: 3297
			private object[] _editors;

			// Token: 0x04000CE2 RID: 3298
			private Type[] _editorTypes;

			// Token: 0x04000CE3 RID: 3299
			private int _editorCount;
		}
	}
}
