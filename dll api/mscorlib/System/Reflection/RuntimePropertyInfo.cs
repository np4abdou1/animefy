using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using Mono;

namespace System.Reflection
{
	// Token: 0x020004E2 RID: 1250
	[Serializable]
	[StructLayout(0)]
	internal class RuntimePropertyInfo : PropertyInfo, ISerializable
	{
		// Token: 0x060023E3 RID: 9187
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void get_property_info(RuntimePropertyInfo prop, ref MonoPropertyInfo info, PInfo req_info);

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060023E4 RID: 9188 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		internal BindingFlags BindingFlags
		{
			get
			{
				return BindingFlags.Default;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060023E5 RID: 9189 RVA: 0x0008E799 File Offset: 0x0008C999
		public override Module Module
		{
			get
			{
				return this.GetRuntimeModule();
			}
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x0008D0FE File Offset: 0x0008B2FE
		internal RuntimeType GetDeclaringTypeInternal()
		{
			return (RuntimeType)this.DeclaringType;
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060023E7 RID: 9191 RVA: 0x0008D10B File Offset: 0x0008B30B
		private RuntimeType ReflectedTypeInternal
		{
			get
			{
				return (RuntimeType)this.ReflectedType;
			}
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x0008E7A1 File Offset: 0x0008C9A1
		internal RuntimeModule GetRuntimeModule()
		{
			return this.GetDeclaringTypeInternal().GetRuntimeModule();
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x0008E7AE File Offset: 0x0008C9AE
		public override string ToString()
		{
			return this.FormatNameAndSig(false);
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x0008E7B8 File Offset: 0x0008C9B8
		private string FormatNameAndSig(bool serialization)
		{
			StringBuilder stringBuilder = new StringBuilder(this.PropertyType.FormatTypeName(serialization));
			stringBuilder.Append(" ");
			stringBuilder.Append(this.Name);
			ParameterInfo[] indexParameters = this.GetIndexParameters();
			if (indexParameters.Length != 0)
			{
				stringBuilder.Append(" [");
				RuntimeParameterInfo.FormatParameters(stringBuilder, indexParameters, (CallingConventions)0, serialization);
				stringBuilder.Append("]");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x0008E822 File Offset: 0x0008CA22
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			MemberInfoSerializationHolder.GetSerializationInfo(info, this.Name, this.ReflectedTypeInternal, this.ToString(), this.SerializationToString(), MemberTypes.Property, null);
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x0008E853 File Offset: 0x0008CA53
		internal string SerializationToString()
		{
			return this.FormatNameAndSig(true);
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x0008E85C File Offset: 0x0008CA5C
		private void CachePropertyInfo(PInfo flags)
		{
			if ((this.cached & flags) != flags)
			{
				RuntimePropertyInfo.get_property_info(this, ref this.info, flags);
				this.cached |= flags;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x0008E884 File Offset: 0x0008CA84
		public override bool CanRead
		{
			get
			{
				this.CachePropertyInfo(PInfo.GetMethod);
				return this.info.get_method != null;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060023EF RID: 9199 RVA: 0x0008E89E File Offset: 0x0008CA9E
		public override bool CanWrite
		{
			get
			{
				this.CachePropertyInfo(PInfo.SetMethod);
				return this.info.set_method != null;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060023F0 RID: 9200 RVA: 0x0008E8B8 File Offset: 0x0008CAB8
		public override Type PropertyType
		{
			get
			{
				this.CachePropertyInfo(PInfo.GetMethod | PInfo.SetMethod);
				if (this.info.get_method != null)
				{
					return this.info.get_method.ReturnType;
				}
				ParameterInfo[] parametersInternal = this.info.set_method.GetParametersInternal();
				return parametersInternal[parametersInternal.Length - 1].ParameterType;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x0008E90B File Offset: 0x0008CB0B
		public override Type ReflectedType
		{
			get
			{
				this.CachePropertyInfo(PInfo.ReflectedType);
				return this.info.parent;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x0008E91F File Offset: 0x0008CB1F
		public override Type DeclaringType
		{
			get
			{
				this.CachePropertyInfo(PInfo.DeclaringType);
				return this.info.declaring_type;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x0008E934 File Offset: 0x0008CB34
		public override string Name
		{
			get
			{
				this.CachePropertyInfo(PInfo.Name);
				return this.info.name;
			}
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x0008E949 File Offset: 0x0008CB49
		public override MethodInfo GetGetMethod(bool nonPublic)
		{
			this.CachePropertyInfo(PInfo.GetMethod);
			if (this.info.get_method != null && (nonPublic || this.info.get_method.IsPublic))
			{
				return this.info.get_method;
			}
			return null;
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x0008E988 File Offset: 0x0008CB88
		public override ParameterInfo[] GetIndexParameters()
		{
			this.CachePropertyInfo(PInfo.GetMethod | PInfo.SetMethod);
			ParameterInfo[] parametersInternal;
			int num;
			if (this.info.get_method != null)
			{
				parametersInternal = this.info.get_method.GetParametersInternal();
				num = parametersInternal.Length;
			}
			else
			{
				if (!(this.info.set_method != null))
				{
					return EmptyArray<ParameterInfo>.Value;
				}
				parametersInternal = this.info.set_method.GetParametersInternal();
				num = parametersInternal.Length - 1;
			}
			ParameterInfo[] array = new ParameterInfo[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = RuntimeParameterInfo.New(parametersInternal[i], this);
			}
			return array;
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x0008EA18 File Offset: 0x0008CC18
		public override MethodInfo GetSetMethod(bool nonPublic)
		{
			this.CachePropertyInfo(PInfo.SetMethod);
			if (this.info.set_method != null && (nonPublic || this.info.set_method.IsPublic))
			{
				return this.info.set_method;
			}
			return null;
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x0008EA56 File Offset: 0x0008CC56
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.IsDefined(this, attributeType, false);
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x0008E574 File Offset: 0x0008C774
		public override object[] GetCustomAttributes(bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, false);
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x0008E57D File Offset: 0x0008C77D
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, attributeType, false);
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x0008EA60 File Offset: 0x0008CC60
		private static object GetterAdapterFrame<T, R>(RuntimePropertyInfo.Getter<T, R> getter, object obj)
		{
			return getter((T)((object)obj));
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x0008EA73 File Offset: 0x0008CC73
		private static object StaticGetterAdapterFrame<R>(RuntimePropertyInfo.StaticGetter<R> getter, object obj)
		{
			return getter();
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x0008EA80 File Offset: 0x0008CC80
		private static RuntimePropertyInfo.GetterAdapter CreateGetterDelegate(MethodInfo method)
		{
			Type[] typeArguments;
			Type typeFromHandle;
			string name;
			if (method.IsStatic)
			{
				typeArguments = new Type[]
				{
					method.ReturnType
				};
				typeFromHandle = typeof(RuntimePropertyInfo.StaticGetter<>);
				name = "StaticGetterAdapterFrame";
			}
			else
			{
				typeArguments = new Type[]
				{
					method.DeclaringType,
					method.ReturnType
				};
				typeFromHandle = typeof(RuntimePropertyInfo.Getter<, >);
				name = "GetterAdapterFrame";
			}
			object firstArgument = Delegate.CreateDelegate(typeFromHandle.MakeGenericType(typeArguments), method);
			MethodInfo methodInfo = typeof(RuntimePropertyInfo).GetMethod(name, BindingFlags.Static | BindingFlags.NonPublic);
			methodInfo = methodInfo.MakeGenericMethod(typeArguments);
			return (RuntimePropertyInfo.GetterAdapter)Delegate.CreateDelegate(typeof(RuntimePropertyInfo.GetterAdapter), firstArgument, methodInfo, true);
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x0008EB28 File Offset: 0x0008CD28
		public override object GetValue(object obj, object[] index)
		{
			if (index == null || index.Length == 0)
			{
				if (this.cached_getter == null)
				{
					MethodInfo getMethod = this.GetGetMethod(true);
					if (getMethod == null)
					{
						throw new ArgumentException("Get Method not found for '" + this.Name + "'");
					}
					if (this.DeclaringType.IsValueType || this.PropertyType.IsByRef || getMethod.ContainsGenericParameters)
					{
						goto IL_97;
					}
					this.cached_getter = RuntimePropertyInfo.CreateGetterDelegate(getMethod);
					try
					{
						return this.cached_getter(obj);
					}
					catch (Exception inner)
					{
						throw new TargetInvocationException(inner);
					}
				}
				try
				{
					return this.cached_getter(obj);
				}
				catch (Exception inner2)
				{
					throw new TargetInvocationException(inner2);
				}
			}
			IL_97:
			return this.GetValue(obj, BindingFlags.Default, null, index, null);
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x0008EBF8 File Offset: 0x0008CDF8
		public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
			object result = null;
			MethodInfo getMethod = this.GetGetMethod(true);
			if (getMethod == null)
			{
				throw new ArgumentException("Get Method not found for '" + this.Name + "'");
			}
			try
			{
				if (index == null || index.Length == 0)
				{
					result = getMethod.Invoke(obj, invokeAttr, binder, null, culture);
				}
				else
				{
					result = getMethod.Invoke(obj, invokeAttr, binder, index, culture);
				}
			}
			catch (SecurityException inner)
			{
				throw new TargetInvocationException(inner);
			}
			return result;
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x0008EC74 File Offset: 0x0008CE74
		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
			MethodInfo setMethod = this.GetSetMethod(true);
			if (setMethod == null)
			{
				throw new ArgumentException("Set Method not found for '" + this.Name + "'");
			}
			object[] array;
			if (index == null || index.Length == 0)
			{
				array = new object[]
				{
					value
				};
			}
			else
			{
				int num = index.Length;
				array = new object[num + 1];
				index.CopyTo(array, 0);
				array[num] = value;
			}
			setMethod.Invoke(obj, invokeAttr, binder, array, culture);
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x0008D2C1 File Offset: 0x0008B4C1
		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return CustomAttributeData.GetCustomAttributes(this);
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x0008ECEC File Offset: 0x0008CEEC
		public override int MetadataToken
		{
			get
			{
				return RuntimePropertyInfo.get_metadata_token(this);
			}
		}

		// Token: 0x06002402 RID: 9218
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int get_metadata_token(RuntimePropertyInfo monoProperty);

		// Token: 0x06002403 RID: 9219
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle);

		// Token: 0x06002404 RID: 9220 RVA: 0x0008ECF4 File Offset: 0x0008CEF4
		internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType)
		{
			if (handle.Value == IntPtr.Zero)
			{
				throw new ArgumentException("The handle is invalid.");
			}
			PropertyInfo propertyInfo = RuntimePropertyInfo.internal_from_handle_type(handle.Value, reflectedType.Value);
			if (propertyInfo == null)
			{
				throw new ArgumentException("The property handle and the type handle are incompatible.");
			}
			return propertyInfo;
		}

		// Token: 0x04001153 RID: 4435
		internal IntPtr klass;

		// Token: 0x04001154 RID: 4436
		internal IntPtr prop;

		// Token: 0x04001155 RID: 4437
		private MonoPropertyInfo info;

		// Token: 0x04001156 RID: 4438
		private PInfo cached;

		// Token: 0x04001157 RID: 4439
		private RuntimePropertyInfo.GetterAdapter cached_getter;

		// Token: 0x020004E3 RID: 1251
		// (Invoke) Token: 0x06002407 RID: 9223
		private delegate object GetterAdapter(object _this);

		// Token: 0x020004E4 RID: 1252
		// (Invoke) Token: 0x0600240B RID: 9227
		private delegate R Getter<T, R>(T _this);

		// Token: 0x020004E5 RID: 1253
		// (Invoke) Token: 0x0600240F RID: 9231
		private delegate R StaticGetter<R>();
	}
}
