﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000174 RID: 372
	internal static class MonoCustomAttrs
	{
		// Token: 0x06000ECE RID: 3790 RVA: 0x0003E1C4 File Offset: 0x0003C3C4
		private static bool IsUserCattrProvider(object obj)
		{
			Type type = obj as Type;
			if (type is RuntimeType || (RuntimeFeature.IsDynamicCodeSupported && type is TypeBuilder))
			{
				return false;
			}
			if (obj is Type)
			{
				return true;
			}
			if (MonoCustomAttrs.corlib == null)
			{
				MonoCustomAttrs.corlib = typeof(int).Assembly;
			}
			return obj.GetType().Assembly != MonoCustomAttrs.corlib;
		}

		// Token: 0x06000ECF RID: 3791
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Attribute[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs);

		// Token: 0x06000ED0 RID: 3792 RVA: 0x0003E234 File Offset: 0x0003C434
		internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType)
		{
			object[] array = null;
			RuntimeMethodInfo runtimeMethodInfo = obj as RuntimeMethodInfo;
			if (runtimeMethodInfo != null)
			{
				array = runtimeMethodInfo.GetPseudoCustomAttributes();
			}
			else
			{
				RuntimeFieldInfo runtimeFieldInfo = obj as RuntimeFieldInfo;
				if (runtimeFieldInfo != null)
				{
					array = runtimeFieldInfo.GetPseudoCustomAttributes();
				}
				else
				{
					RuntimeParameterInfo runtimeParameterInfo = obj as RuntimeParameterInfo;
					if (runtimeParameterInfo != null)
					{
						array = runtimeParameterInfo.GetPseudoCustomAttributes();
					}
					else
					{
						Type type = obj as Type;
						if (type != null)
						{
							array = MonoCustomAttrs.GetPseudoCustomAttributes(type);
						}
					}
				}
			}
			if (attributeType != null && array != null)
			{
				int i = 0;
				while (i < array.Length)
				{
					if (attributeType.IsAssignableFrom(array[i].GetType()))
					{
						if (array.Length == 1)
						{
							return array;
						}
						return new object[]
						{
							array[i]
						};
					}
					else
					{
						i++;
					}
				}
				return Array.Empty<object>();
			}
			return array;
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0003E2DC File Offset: 0x0003C4DC
		private static object[] GetPseudoCustomAttributes(Type type)
		{
			int num = 0;
			TypeAttributes attributes = type.Attributes;
			if ((attributes & TypeAttributes.Serializable) != TypeAttributes.NotPublic)
			{
				num++;
			}
			if ((attributes & TypeAttributes.Import) != TypeAttributes.NotPublic)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			object[] array = new object[num];
			num = 0;
			if ((attributes & TypeAttributes.Serializable) != TypeAttributes.NotPublic)
			{
				array[num++] = new SerializableAttribute();
			}
			if ((attributes & TypeAttributes.Import) != TypeAttributes.NotPublic)
			{
				array[num++] = new ComImportAttribute();
			}
			return array;
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x0003E348 File Offset: 0x0003C548
		internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly)
		{
			object[] array;
			if (MonoCustomAttrs.IsUserCattrProvider(obj))
			{
				array = obj.GetCustomAttributes(attributeType, true);
			}
			else
			{
				object[] array2 = MonoCustomAttrs.GetCustomAttributesInternal(obj, attributeType, false);
				array = array2;
			}
			if (!inheritedOnly)
			{
				object[] pseudoCustomAttributes = MonoCustomAttrs.GetPseudoCustomAttributes(obj, attributeType);
				if (pseudoCustomAttributes != null)
				{
					object[] array2 = new Attribute[array.Length + pseudoCustomAttributes.Length];
					object[] array3 = array2;
					Array.Copy(array, array3, array.Length);
					Array.Copy(pseudoCustomAttributes, 0, array3, array.Length, pseudoCustomAttributes.Length);
					return array3;
				}
			}
			return array;
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x0003E3AC File Offset: 0x0003C5AC
		internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			if (attributeType == typeof(MonoCustomAttrs))
			{
				attributeType = null;
			}
			object[] customAttributesBase = MonoCustomAttrs.GetCustomAttributesBase(obj, attributeType, false);
			if (!inherit && customAttributesBase.Length == 1)
			{
				if (customAttributesBase[0] == null)
				{
					throw new CustomAttributeFormatException("Invalid custom attribute format");
				}
				object[] array;
				if (attributeType != null)
				{
					if (attributeType.IsAssignableFrom(customAttributesBase[0].GetType()))
					{
						array = (object[])Array.CreateInstance(attributeType, 1);
						array[0] = customAttributesBase[0];
					}
					else
					{
						array = (object[])Array.CreateInstance(attributeType, 0);
					}
				}
				else
				{
					array = (object[])Array.CreateInstance(customAttributesBase[0].GetType(), 1);
					array[0] = customAttributesBase[0];
				}
				return array;
			}
			else
			{
				if (inherit && MonoCustomAttrs.GetBase(obj) == null)
				{
					inherit = false;
				}
				if (attributeType != null && attributeType.IsSealed && inherit && !MonoCustomAttrs.RetrieveAttributeUsage(attributeType).Inherited)
				{
					inherit = false;
				}
				int capacity = Math.Max(customAttributesBase.Length, 16);
				ICustomAttributeProvider customAttributeProvider = obj;
				List<object> list;
				object[] array3;
				if (inherit)
				{
					Dictionary<Type, MonoCustomAttrs.AttributeInfo> dictionary = new Dictionary<Type, MonoCustomAttrs.AttributeInfo>(capacity);
					int num = 0;
					list = new List<object>(capacity);
					for (;;)
					{
						foreach (object obj2 in customAttributesBase)
						{
							if (obj2 == null)
							{
								goto Block_22;
							}
							Type type = obj2.GetType();
							if (!(attributeType != null) || attributeType.IsAssignableFrom(type))
							{
								MonoCustomAttrs.AttributeInfo attributeInfo;
								AttributeUsageAttribute attributeUsageAttribute;
								if (dictionary.TryGetValue(type, out attributeInfo))
								{
									attributeUsageAttribute = attributeInfo.Usage;
								}
								else
								{
									attributeUsageAttribute = MonoCustomAttrs.RetrieveAttributeUsage(type);
								}
								if ((num == 0 || attributeUsageAttribute.Inherited) && (attributeUsageAttribute.AllowMultiple || attributeInfo == null || (attributeInfo != null && attributeInfo.InheritanceLevel == num)))
								{
									list.Add(obj2);
								}
								if (attributeInfo == null)
								{
									dictionary.Add(type, new MonoCustomAttrs.AttributeInfo(attributeUsageAttribute, num));
								}
							}
						}
						if ((customAttributeProvider = MonoCustomAttrs.GetBase(customAttributeProvider)) != null)
						{
							num++;
							customAttributesBase = MonoCustomAttrs.GetCustomAttributesBase(customAttributeProvider, attributeType, true);
						}
						if (!inherit || customAttributeProvider == null)
						{
							goto IL_2CF;
						}
					}
					Block_22:
					throw new CustomAttributeFormatException("Invalid custom attribute format");
					IL_2CF:
					if (attributeType == null || attributeType.IsValueType)
					{
						object[] array2 = new Attribute[list.Count];
						array3 = array2;
					}
					else
					{
						array3 = (Array.CreateInstance(attributeType, list.Count) as object[]);
					}
					list.CopyTo(array3, 0);
					return array3;
				}
				if (attributeType == null)
				{
					object[] array2 = customAttributesBase;
					for (int i = 0; i < array2.Length; i++)
					{
						if (array2[i] == null)
						{
							throw new CustomAttributeFormatException("Invalid custom attribute format");
						}
					}
					Attribute[] array4 = new Attribute[customAttributesBase.Length];
					customAttributesBase.CopyTo(array4, 0);
					return array4;
				}
				list = new List<object>(capacity);
				foreach (object obj3 in customAttributesBase)
				{
					if (obj3 == null)
					{
						throw new CustomAttributeFormatException("Invalid custom attribute format");
					}
					Type type2 = obj3.GetType();
					if (!(attributeType != null) || attributeType.IsAssignableFrom(type2))
					{
						list.Add(obj3);
					}
				}
				if (attributeType == null || attributeType.IsValueType)
				{
					object[] array2 = new Attribute[list.Count];
					array3 = array2;
				}
				else
				{
					array3 = (Array.CreateInstance(attributeType, list.Count) as object[]);
				}
				list.CopyTo(array3, 0);
				return array3;
			}
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0003E6CA File Offset: 0x0003C8CA
		internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			if (!inherit)
			{
				return (object[])MonoCustomAttrs.GetCustomAttributesBase(obj, null, false).Clone();
			}
			return MonoCustomAttrs.GetCustomAttributes(obj, typeof(MonoCustomAttrs), inherit);
		}

		// Token: 0x06000ED5 RID: 3797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj);

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0003E701 File Offset: 0x0003C901
		internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, bool inherit = false)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			if (!inherit)
			{
				return MonoCustomAttrs.GetCustomAttributesDataBase(obj, null, false);
			}
			return MonoCustomAttrs.GetCustomAttributesData(obj, typeof(MonoCustomAttrs), inherit);
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0003E730 File Offset: 0x0003C930
		internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			if (attributeType == typeof(MonoCustomAttrs))
			{
				attributeType = null;
			}
			IList<CustomAttributeData> customAttributesDataBase = MonoCustomAttrs.GetCustomAttributesDataBase(obj, attributeType, false);
			if (!inherit && customAttributesDataBase.Count == 1)
			{
				if (customAttributesDataBase[0] == null)
				{
					throw new CustomAttributeFormatException("Invalid custom attribute data format");
				}
				IList<CustomAttributeData> result;
				if (attributeType != null)
				{
					if (attributeType.IsAssignableFrom(customAttributesDataBase[0].AttributeType))
					{
						result = new CustomAttributeData[]
						{
							customAttributesDataBase[0]
						};
					}
					else
					{
						result = Array.Empty<CustomAttributeData>();
					}
				}
				else
				{
					result = new CustomAttributeData[]
					{
						customAttributesDataBase[0]
					};
				}
				return result;
			}
			else
			{
				if (inherit && MonoCustomAttrs.GetBase(obj) == null)
				{
					inherit = false;
				}
				if (attributeType != null && attributeType.IsSealed && inherit && !MonoCustomAttrs.RetrieveAttributeUsage(attributeType).Inherited)
				{
					inherit = false;
				}
				int capacity = Math.Max(customAttributesDataBase.Count, 16);
				List<CustomAttributeData> list = null;
				ICustomAttributeProvider customAttributeProvider = obj;
				if (inherit)
				{
					Dictionary<Type, MonoCustomAttrs.AttributeInfo> dictionary = new Dictionary<Type, MonoCustomAttrs.AttributeInfo>(capacity);
					int num = 0;
					list = new List<CustomAttributeData>(capacity);
					do
					{
						foreach (CustomAttributeData customAttributeData in customAttributesDataBase)
						{
							if (customAttributeData == null)
							{
								throw new CustomAttributeFormatException("Invalid custom attribute data format");
							}
							Type attributeType2 = customAttributeData.AttributeType;
							if (!(attributeType != null) || attributeType.IsAssignableFrom(attributeType2))
							{
								MonoCustomAttrs.AttributeInfo attributeInfo;
								AttributeUsageAttribute attributeUsageAttribute;
								if (dictionary.TryGetValue(attributeType2, out attributeInfo))
								{
									attributeUsageAttribute = attributeInfo.Usage;
								}
								else
								{
									attributeUsageAttribute = MonoCustomAttrs.RetrieveAttributeUsage(attributeType2);
								}
								if ((num == 0 || attributeUsageAttribute.Inherited) && (attributeUsageAttribute.AllowMultiple || attributeInfo == null || (attributeInfo != null && attributeInfo.InheritanceLevel == num)))
								{
									list.Add(customAttributeData);
								}
								if (attributeInfo == null)
								{
									dictionary.Add(attributeType2, new MonoCustomAttrs.AttributeInfo(attributeUsageAttribute, num));
								}
							}
						}
						if ((customAttributeProvider = MonoCustomAttrs.GetBase(customAttributeProvider)) != null)
						{
							num++;
							customAttributesDataBase = MonoCustomAttrs.GetCustomAttributesDataBase(customAttributeProvider, attributeType, true);
						}
					}
					while (inherit && customAttributeProvider != null);
					return list.ToArray();
				}
				if (attributeType == null)
				{
					using (IEnumerator<CustomAttributeData> enumerator = customAttributesDataBase.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current == null)
							{
								throw new CustomAttributeFormatException("Invalid custom attribute data format");
							}
						}
					}
					CustomAttributeData[] array = new CustomAttributeData[customAttributesDataBase.Count];
					customAttributesDataBase.CopyTo(array, 0);
					return array;
				}
				list = new List<CustomAttributeData>(capacity);
				foreach (CustomAttributeData customAttributeData2 in customAttributesDataBase)
				{
					if (customAttributeData2 == null)
					{
						throw new CustomAttributeFormatException("Invalid custom attribute data format");
					}
					if (attributeType.IsAssignableFrom(customAttributeData2.AttributeType))
					{
						list.Add(customAttributeData2);
					}
				}
				return list.ToArray();
			}
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0003EA14 File Offset: 0x0003CC14
		internal static IList<CustomAttributeData> GetCustomAttributesDataBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly)
		{
			CustomAttributeData[] array;
			if (MonoCustomAttrs.IsUserCattrProvider(obj))
			{
				array = Array.Empty<CustomAttributeData>();
			}
			else
			{
				array = MonoCustomAttrs.GetCustomAttributesDataInternal(obj);
			}
			if (!inheritedOnly)
			{
				CustomAttributeData[] pseudoCustomAttributesData = MonoCustomAttrs.GetPseudoCustomAttributesData(obj, attributeType);
				if (pseudoCustomAttributesData != null)
				{
					if (array.Length == 0)
					{
						return Array.AsReadOnly<CustomAttributeData>(pseudoCustomAttributesData);
					}
					CustomAttributeData[] array2 = new CustomAttributeData[array.Length + pseudoCustomAttributesData.Length];
					Array.Copy(array, array2, array.Length);
					Array.Copy(pseudoCustomAttributesData, 0, array2, array.Length, pseudoCustomAttributesData.Length);
					return Array.AsReadOnly<CustomAttributeData>(array2);
				}
			}
			return Array.AsReadOnly<CustomAttributeData>(array);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0003EA84 File Offset: 0x0003CC84
		internal static CustomAttributeData[] GetPseudoCustomAttributesData(ICustomAttributeProvider obj, Type attributeType)
		{
			CustomAttributeData[] array = null;
			RuntimeMethodInfo runtimeMethodInfo = obj as RuntimeMethodInfo;
			if (runtimeMethodInfo != null)
			{
				array = runtimeMethodInfo.GetPseudoCustomAttributesData();
			}
			else
			{
				RuntimeFieldInfo runtimeFieldInfo = obj as RuntimeFieldInfo;
				if (runtimeFieldInfo != null)
				{
					array = runtimeFieldInfo.GetPseudoCustomAttributesData();
				}
				else
				{
					RuntimeParameterInfo runtimeParameterInfo = obj as RuntimeParameterInfo;
					if (runtimeParameterInfo != null)
					{
						array = runtimeParameterInfo.GetPseudoCustomAttributesData();
					}
					else
					{
						Type type = obj as Type;
						if (type != null)
						{
							array = MonoCustomAttrs.GetPseudoCustomAttributesData(type);
						}
					}
				}
			}
			if (attributeType != null && array != null)
			{
				int i = 0;
				while (i < array.Length)
				{
					if (attributeType.IsAssignableFrom(array[i].AttributeType))
					{
						if (array.Length == 1)
						{
							return array;
						}
						return new CustomAttributeData[]
						{
							array[i]
						};
					}
					else
					{
						i++;
					}
				}
				return Array.Empty<CustomAttributeData>();
			}
			return array;
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0003EB2C File Offset: 0x0003CD2C
		private static CustomAttributeData[] GetPseudoCustomAttributesData(Type type)
		{
			int num = 0;
			TypeAttributes attributes = type.Attributes;
			if ((attributes & TypeAttributes.Serializable) != TypeAttributes.NotPublic)
			{
				num++;
			}
			if ((attributes & TypeAttributes.Import) != TypeAttributes.NotPublic)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			CustomAttributeData[] array = new CustomAttributeData[num];
			num = 0;
			if ((attributes & TypeAttributes.Serializable) != TypeAttributes.NotPublic)
			{
				array[num++] = new CustomAttributeData(typeof(SerializableAttribute).GetConstructor(Type.EmptyTypes));
			}
			if ((attributes & TypeAttributes.Import) != TypeAttributes.NotPublic)
			{
				array[num++] = new CustomAttributeData(typeof(ComImportAttribute).GetConstructor(Type.EmptyTypes));
			}
			return array;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0003EBC0 File Offset: 0x0003CDC0
		internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			AttributeUsageAttribute attributeUsageAttribute = null;
			while (!MonoCustomAttrs.IsUserCattrProvider(obj))
			{
				if (MonoCustomAttrs.IsDefinedInternal(obj, attributeType))
				{
					return true;
				}
				object[] pseudoCustomAttributes = MonoCustomAttrs.GetPseudoCustomAttributes(obj, attributeType);
				if (pseudoCustomAttributes != null)
				{
					for (int i = 0; i < pseudoCustomAttributes.Length; i++)
					{
						if (attributeType.IsAssignableFrom(pseudoCustomAttributes[i].GetType()))
						{
							return true;
						}
					}
				}
				if (attributeUsageAttribute == null)
				{
					if (!inherit)
					{
						return false;
					}
					attributeUsageAttribute = MonoCustomAttrs.RetrieveAttributeUsage(attributeType);
					if (!attributeUsageAttribute.Inherited)
					{
						return false;
					}
				}
				obj = MonoCustomAttrs.GetBase(obj);
				if (obj == null)
				{
					return false;
				}
			}
			return obj.IsDefined(attributeType, inherit);
		}

		// Token: 0x06000EDC RID: 3804
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType);

		// Token: 0x06000EDD RID: 3805 RVA: 0x0003EC50 File Offset: 0x0003CE50
		private static PropertyInfo GetBasePropertyDefinition(RuntimePropertyInfo property)
		{
			MethodInfo methodInfo = property.GetGetMethod(true);
			if (methodInfo == null || !methodInfo.IsVirtual)
			{
				methodInfo = property.GetSetMethod(true);
			}
			if (methodInfo == null || !methodInfo.IsVirtual)
			{
				return null;
			}
			MethodInfo baseMethod = ((RuntimeMethodInfo)methodInfo).GetBaseMethod();
			if (!(baseMethod != null) || !(baseMethod != methodInfo))
			{
				return null;
			}
			ParameterInfo[] indexParameters = property.GetIndexParameters();
			if (indexParameters != null && indexParameters.Length != 0)
			{
				Type[] array = new Type[indexParameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = indexParameters[i].ParameterType;
				}
				return baseMethod.DeclaringType.GetProperty(property.Name, property.PropertyType, array);
			}
			return baseMethod.DeclaringType.GetProperty(property.Name, property.PropertyType);
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x0003ED18 File Offset: 0x0003CF18
		private static EventInfo GetBaseEventDefinition(RuntimeEventInfo evt)
		{
			MethodInfo methodInfo = evt.GetAddMethod(true);
			if (methodInfo == null || !methodInfo.IsVirtual)
			{
				methodInfo = evt.GetRaiseMethod(true);
			}
			if (methodInfo == null || !methodInfo.IsVirtual)
			{
				methodInfo = evt.GetRemoveMethod(true);
			}
			if (methodInfo == null || !methodInfo.IsVirtual)
			{
				return null;
			}
			MethodInfo baseMethod = ((RuntimeMethodInfo)methodInfo).GetBaseMethod();
			if (baseMethod != null && baseMethod != methodInfo)
			{
				BindingFlags bindingFlags = methodInfo.IsPublic ? BindingFlags.Public : BindingFlags.NonPublic;
				bindingFlags |= (methodInfo.IsStatic ? BindingFlags.Static : BindingFlags.Instance);
				return baseMethod.DeclaringType.GetEvent(evt.Name, bindingFlags);
			}
			return null;
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x0003EDC4 File Offset: 0x0003CFC4
		private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj)
		{
			if (obj == null)
			{
				return null;
			}
			if (obj is Type)
			{
				return ((Type)obj).BaseType;
			}
			MethodInfo methodInfo = null;
			if (obj is RuntimePropertyInfo)
			{
				return MonoCustomAttrs.GetBasePropertyDefinition((RuntimePropertyInfo)obj);
			}
			if (obj is RuntimeEventInfo)
			{
				return MonoCustomAttrs.GetBaseEventDefinition((RuntimeEventInfo)obj);
			}
			if (obj is RuntimeMethodInfo)
			{
				methodInfo = (MethodInfo)obj;
			}
			RuntimeParameterInfo runtimeParameterInfo = obj as RuntimeParameterInfo;
			if (runtimeParameterInfo != null)
			{
				MemberInfo member = runtimeParameterInfo.Member;
				if (member is MethodInfo)
				{
					methodInfo = (MethodInfo)member;
					MethodInfo baseMethod = ((RuntimeMethodInfo)methodInfo).GetBaseMethod();
					if (baseMethod == methodInfo)
					{
						return null;
					}
					return baseMethod.GetParameters()[runtimeParameterInfo.Position];
				}
			}
			if (methodInfo == null || !methodInfo.IsVirtual)
			{
				return null;
			}
			MethodInfo baseMethod2 = ((RuntimeMethodInfo)methodInfo).GetBaseMethod();
			if (baseMethod2 == methodInfo)
			{
				return null;
			}
			return baseMethod2;
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0003EE98 File Offset: 0x0003D098
		private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType)
		{
			if (attributeType == typeof(AttributeUsageAttribute))
			{
				return new AttributeUsageAttribute(AttributeTargets.Class);
			}
			AttributeUsageAttribute attributeUsageAttribute = null;
			object[] customAttributes = MonoCustomAttrs.GetCustomAttributes(attributeType, typeof(AttributeUsageAttribute), false);
			if (customAttributes.Length == 0)
			{
				if (attributeType.BaseType != null)
				{
					attributeUsageAttribute = MonoCustomAttrs.RetrieveAttributeUsage(attributeType.BaseType);
				}
				if (attributeUsageAttribute != null)
				{
					return attributeUsageAttribute;
				}
				return MonoCustomAttrs.DefaultAttributeUsage;
			}
			else
			{
				if (customAttributes.Length > 1)
				{
					throw new FormatException("Duplicate AttributeUsageAttribute cannot be specified on an attribute type.");
				}
				return (AttributeUsageAttribute)customAttributes[0];
			}
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0003EF14 File Offset: 0x0003D114
		private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType)
		{
			AttributeUsageAttribute attributeUsageAttribute = null;
			if (MonoCustomAttrs.usage_cache == null)
			{
				MonoCustomAttrs.usage_cache = new Dictionary<Type, AttributeUsageAttribute>();
			}
			if (MonoCustomAttrs.usage_cache.TryGetValue(attributeType, out attributeUsageAttribute))
			{
				return attributeUsageAttribute;
			}
			attributeUsageAttribute = MonoCustomAttrs.RetrieveAttributeUsageNoCache(attributeType);
			MonoCustomAttrs.usage_cache[attributeType] = attributeUsageAttribute;
			return attributeUsageAttribute;
		}

		// Token: 0x0400059F RID: 1439
		private static Assembly corlib;

		// Token: 0x040005A0 RID: 1440
		[ThreadStatic]
		private static Dictionary<Type, AttributeUsageAttribute> usage_cache;

		// Token: 0x040005A1 RID: 1441
		private static readonly AttributeUsageAttribute DefaultAttributeUsage = new AttributeUsageAttribute(AttributeTargets.All);

		// Token: 0x02000175 RID: 373
		private class AttributeInfo
		{
			// Token: 0x06000EE3 RID: 3811 RVA: 0x0003EF6A File Offset: 0x0003D16A
			public AttributeInfo(AttributeUsageAttribute usage, int inheritanceLevel)
			{
				this._usage = usage;
				this._inheritanceLevel = inheritanceLevel;
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x0003EF80 File Offset: 0x0003D180
			public AttributeUsageAttribute Usage
			{
				get
				{
					return this._usage;
				}
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x0003EF88 File Offset: 0x0003D188
			public int InheritanceLevel
			{
				get
				{
					return this._inheritanceLevel;
				}
			}

			// Token: 0x040005A2 RID: 1442
			private AttributeUsageAttribute _usage;

			// Token: 0x040005A3 RID: 1443
			private int _inheritanceLevel;
		}
	}
}
