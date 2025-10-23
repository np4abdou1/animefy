using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;

namespace System.Reflection
{
	// Token: 0x020004DB RID: 1243
	[Serializable]
	[StructLayout(0)]
	internal class RuntimeMethodInfo : MethodInfo, ISerializable
	{
		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		internal BindingFlags BindingFlags
		{
			get
			{
				return BindingFlags.Default;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x0008D605 File Offset: 0x0008B805
		public override Module Module
		{
			get
			{
				return this.GetRuntimeModule();
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x0008D10B File Offset: 0x0008B30B
		private RuntimeType ReflectedTypeInternal
		{
			get
			{
				return (RuntimeType)this.ReflectedType;
			}
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x0008D610 File Offset: 0x0008B810
		internal override string FormatNameAndSig(bool serialization)
		{
			StringBuilder stringBuilder = new StringBuilder(this.Name);
			TypeNameFormatFlags format = serialization ? TypeNameFormatFlags.FormatSerialization : TypeNameFormatFlags.FormatBasic;
			if (this.IsGenericMethod)
			{
				stringBuilder.Append(RuntimeMethodHandle.ConstructInstantiation(this, format));
			}
			stringBuilder.Append("(");
			RuntimeParameterInfo.FormatParameters(stringBuilder, this.GetParametersNoCopy(), this.CallingConvention, serialization);
			stringBuilder.Append(")");
			return stringBuilder.ToString();
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x0008D67C File Offset: 0x0008B87C
		public override Delegate CreateDelegate(Type delegateType)
		{
			return Delegate.CreateDelegate(delegateType, this);
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x0008D685 File Offset: 0x0008B885
		public override Delegate CreateDelegate(Type delegateType, object target)
		{
			return Delegate.CreateDelegate(delegateType, target, this);
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x0008D68F File Offset: 0x0008B88F
		public override string ToString()
		{
			return this.ReturnType.FormatTypeName() + " " + this.FormatNameAndSig(false);
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x0008D6AD File Offset: 0x0008B8AD
		internal RuntimeModule GetRuntimeModule()
		{
			return ((RuntimeType)this.DeclaringType).GetRuntimeModule();
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x0008D6C0 File Offset: 0x0008B8C0
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			MemberInfoSerializationHolder.GetSerializationInfo(info, this.Name, this.ReflectedTypeInternal, this.ToString(), this.SerializationToString(), MemberTypes.Method, (this.IsGenericMethod & !this.IsGenericMethodDefinition) ? this.GetGenericArguments() : null);
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x0008D715 File Offset: 0x0008B915
		internal string SerializationToString()
		{
			return this.ReturnType.FormatTypeName(true) + " " + this.FormatNameAndSig(true);
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x0008D734 File Offset: 0x0008B934
		internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle)
		{
			return RuntimeMethodInfo.GetMethodFromHandleInternalType_native(handle.Value, IntPtr.Zero, false);
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x0008D748 File Offset: 0x0008B948
		internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType)
		{
			return RuntimeMethodInfo.GetMethodFromHandleInternalType_native(handle.Value, reflectedType.Value, false);
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x0008D75E File Offset: 0x0008B95E
		internal static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle)
		{
			return RuntimeMethodInfo.GetMethodFromHandleInternalType_native(method_handle, type_handle, true);
		}

		// Token: 0x06002373 RID: 9075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck);

		// Token: 0x06002374 RID: 9076 RVA: 0x0008D768 File Offset: 0x0008B968
		internal RuntimeMethodInfo()
		{
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x0008D770 File Offset: 0x0008B970
		internal RuntimeMethodInfo(RuntimeMethodHandle mhandle)
		{
			this.mhandle = mhandle.Value;
		}

		// Token: 0x06002376 RID: 9078
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string get_name(MethodBase method);

		// Token: 0x06002377 RID: 9079
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern RuntimeMethodInfo get_base_method(RuntimeMethodInfo method, bool definition);

		// Token: 0x06002378 RID: 9080
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int get_metadata_token(RuntimeMethodInfo method);

		// Token: 0x06002379 RID: 9081 RVA: 0x0008D785 File Offset: 0x0008B985
		public override MethodInfo GetBaseDefinition()
		{
			return RuntimeMethodInfo.get_base_method(this, true);
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x0008D78E File Offset: 0x0008B98E
		internal MethodInfo GetBaseMethod()
		{
			return RuntimeMethodInfo.get_base_method(this, false);
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x0600237B RID: 9083 RVA: 0x0008D797 File Offset: 0x0008B997
		public override ParameterInfo ReturnParameter
		{
			get
			{
				return MonoMethodInfo.GetReturnParameterInfo(this);
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x0008D79F File Offset: 0x0008B99F
		public override Type ReturnType
		{
			get
			{
				return MonoMethodInfo.GetReturnType(this.mhandle);
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x0008D7AC File Offset: 0x0008B9AC
		public override int MetadataToken
		{
			get
			{
				return RuntimeMethodInfo.get_metadata_token(this);
			}
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x0008D7B4 File Offset: 0x0008B9B4
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return MonoMethodInfo.GetMethodImplementationFlags(this.mhandle);
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x0008D7C4 File Offset: 0x0008B9C4
		public override ParameterInfo[] GetParameters()
		{
			ParameterInfo[] parametersInfo = MonoMethodInfo.GetParametersInfo(this.mhandle, this);
			if (parametersInfo.Length == 0)
			{
				return parametersInfo;
			}
			ParameterInfo[] array = new ParameterInfo[parametersInfo.Length];
			Array.FastCopy(parametersInfo, 0, array, 0, parametersInfo.Length);
			return array;
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x0008D7FB File Offset: 0x0008B9FB
		internal override ParameterInfo[] GetParametersInternal()
		{
			return MonoMethodInfo.GetParametersInfo(this.mhandle, this);
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x0008D809 File Offset: 0x0008BA09
		internal override int GetParametersCount()
		{
			return MonoMethodInfo.GetParametersInfo(this.mhandle, this).Length;
		}

		// Token: 0x06002382 RID: 9090
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern object InternalInvoke(object obj, object[] parameters, out Exception exc);

		// Token: 0x06002383 RID: 9091 RVA: 0x0008D81C File Offset: 0x0008BA1C
		[DebuggerHidden]
		[DebuggerStepThrough]
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			if (!base.IsStatic && !this.DeclaringType.IsInstanceOfType(obj))
			{
				if (obj == null)
				{
					throw new TargetException("Non-static method requires a target.");
				}
				throw new TargetException("Object does not match target type.");
			}
			else
			{
				if (binder == null)
				{
					binder = Type.DefaultBinder;
				}
				ParameterInfo[] parametersInternal = this.GetParametersInternal();
				RuntimeMethodInfo.ConvertValues(binder, parameters, parametersInternal, culture, invokeAttr);
				if (this.ContainsGenericParameters)
				{
					throw new InvalidOperationException("Late bound operations cannot be performed on types or methods for which ContainsGenericParameters is true.");
				}
				object result = null;
				Exception ex;
				if ((invokeAttr & BindingFlags.DoNotWrapExceptions) == BindingFlags.Default)
				{
					try
					{
						result = this.InternalInvoke(obj, parameters, out ex);
						goto IL_93;
					}
					catch (ThreadAbortException)
					{
						throw;
					}
					catch (MethodAccessException)
					{
						throw;
					}
					catch (OverflowException)
					{
						throw;
					}
					catch (Exception inner)
					{
						throw new TargetInvocationException(inner);
					}
				}
				result = this.InternalInvoke(obj, parameters, out ex);
				IL_93:
				if (ex != null)
				{
					throw ex;
				}
				return result;
			}
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x0008D8F8 File Offset: 0x0008BAF8
		internal static void ConvertValues(Binder binder, object[] args, ParameterInfo[] pinfo, CultureInfo culture, BindingFlags invokeAttr)
		{
			if (args == null)
			{
				if (pinfo.Length == 0)
				{
					return;
				}
				throw new TargetParameterCountException();
			}
			else
			{
				if (pinfo.Length != args.Length)
				{
					throw new TargetParameterCountException();
				}
				for (int i = 0; i < args.Length; i++)
				{
					object obj = args[i];
					ParameterInfo parameterInfo = pinfo[i];
					if (obj == Type.Missing)
					{
						if (parameterInfo.DefaultValue == DBNull.Value)
						{
							throw new ArgumentException(Environment.GetResourceString("Missing parameter does not have a default value."), "parameters");
						}
						args[i] = parameterInfo.DefaultValue;
					}
					else
					{
						RuntimeType runtimeType = (RuntimeType)parameterInfo.ParameterType;
						args[i] = runtimeType.CheckValue(obj, binder, culture, invokeAttr);
					}
				}
				return;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06002385 RID: 9093 RVA: 0x0008D986 File Offset: 0x0008BB86
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				return new RuntimeMethodHandle(this.mhandle);
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x0008D993 File Offset: 0x0008BB93
		public override MethodAttributes Attributes
		{
			get
			{
				return MonoMethodInfo.GetAttributes(this.mhandle);
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x0008D9A0 File Offset: 0x0008BBA0
		public override CallingConventions CallingConvention
		{
			get
			{
				return MonoMethodInfo.GetCallingConvention(this.mhandle);
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x0008D9AD File Offset: 0x0008BBAD
		public override Type ReflectedType
		{
			get
			{
				return this.reftype;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06002389 RID: 9097 RVA: 0x0008D9B5 File Offset: 0x0008BBB5
		public override Type DeclaringType
		{
			get
			{
				return MonoMethodInfo.GetDeclaringType(this.mhandle);
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x0008D9C2 File Offset: 0x0008BBC2
		public override string Name
		{
			get
			{
				if (this.name != null)
				{
					return this.name;
				}
				return RuntimeMethodInfo.get_name(this);
			}
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x00032332 File Offset: 0x00030532
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x0008D062 File Offset: 0x0008B262
		public override object[] GetCustomAttributes(bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, inherit);
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x0008D06B File Offset: 0x0008B26B
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, attributeType, inherit);
		}

		// Token: 0x0600238E RID: 9102
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName);

		// Token: 0x0600238F RID: 9103 RVA: 0x0008D9DC File Offset: 0x0008BBDC
		internal object[] GetPseudoCustomAttributes()
		{
			int num = 0;
			MonoMethodInfo methodInfo = MonoMethodInfo.GetMethodInfo(this.mhandle);
			if ((methodInfo.iattrs & MethodImplAttributes.PreserveSig) != MethodImplAttributes.IL)
			{
				num++;
			}
			if ((methodInfo.attrs & MethodAttributes.PinvokeImpl) != MethodAttributes.PrivateScope)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			object[] array = new object[num];
			num = 0;
			if ((methodInfo.iattrs & MethodImplAttributes.PreserveSig) != MethodImplAttributes.IL)
			{
				array[num++] = new PreserveSigAttribute();
			}
			if ((methodInfo.attrs & MethodAttributes.PinvokeImpl) != MethodAttributes.PrivateScope)
			{
				array[num++] = DllImportAttribute.GetCustomAttribute(this);
			}
			return array;
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x0008DA60 File Offset: 0x0008BC60
		internal CustomAttributeData[] GetPseudoCustomAttributesData()
		{
			int num = 0;
			MonoMethodInfo methodInfo = MonoMethodInfo.GetMethodInfo(this.mhandle);
			if ((methodInfo.iattrs & MethodImplAttributes.PreserveSig) != MethodImplAttributes.IL)
			{
				num++;
			}
			if ((methodInfo.attrs & MethodAttributes.PinvokeImpl) != MethodAttributes.PrivateScope)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			CustomAttributeData[] array = new CustomAttributeData[num];
			num = 0;
			if ((methodInfo.iattrs & MethodImplAttributes.PreserveSig) != MethodImplAttributes.IL)
			{
				array[num++] = new CustomAttributeData(typeof(PreserveSigAttribute).GetConstructor(Type.EmptyTypes));
			}
			if ((methodInfo.attrs & MethodAttributes.PinvokeImpl) != MethodAttributes.PrivateScope)
			{
				array[num++] = this.GetDllImportAttributeData();
			}
			return array;
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x0008DAF8 File Offset: 0x0008BCF8
		private CustomAttributeData GetDllImportAttributeData()
		{
			if ((this.Attributes & MethodAttributes.PinvokeImpl) == MethodAttributes.PrivateScope)
			{
				return null;
			}
			string value = null;
			PInvokeAttributes pinvokeAttributes = PInvokeAttributes.CharSetNotSpec;
			string value2;
			this.GetPInvoke(out pinvokeAttributes, out value2, out value);
			CharSet charSet;
			switch (pinvokeAttributes & PInvokeAttributes.CharSetMask)
			{
			case PInvokeAttributes.CharSetNotSpec:
				charSet = CharSet.None;
				goto IL_5C;
			case PInvokeAttributes.CharSetAnsi:
				charSet = CharSet.Ansi;
				goto IL_5C;
			case PInvokeAttributes.CharSetUnicode:
				charSet = CharSet.Unicode;
				goto IL_5C;
			case PInvokeAttributes.CharSetMask:
				charSet = CharSet.Auto;
				goto IL_5C;
			}
			charSet = CharSet.None;
			IL_5C:
			PInvokeAttributes pinvokeAttributes2 = pinvokeAttributes & PInvokeAttributes.CallConvMask;
			CallingConvention callingConvention;
			if (pinvokeAttributes2 <= PInvokeAttributes.CallConvCdecl)
			{
				if (pinvokeAttributes2 == PInvokeAttributes.CallConvWinapi)
				{
					callingConvention = System.Runtime.InteropServices.CallingConvention.Winapi;
					goto IL_BB;
				}
				if (pinvokeAttributes2 == PInvokeAttributes.CallConvCdecl)
				{
					callingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl;
					goto IL_BB;
				}
			}
			else
			{
				if (pinvokeAttributes2 == PInvokeAttributes.CallConvStdcall)
				{
					callingConvention = System.Runtime.InteropServices.CallingConvention.StdCall;
					goto IL_BB;
				}
				if (pinvokeAttributes2 == PInvokeAttributes.CallConvThiscall)
				{
					callingConvention = System.Runtime.InteropServices.CallingConvention.ThisCall;
					goto IL_BB;
				}
				if (pinvokeAttributes2 == PInvokeAttributes.CallConvFastcall)
				{
					callingConvention = System.Runtime.InteropServices.CallingConvention.FastCall;
					goto IL_BB;
				}
			}
			callingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl;
			IL_BB:
			bool flag = (pinvokeAttributes & PInvokeAttributes.NoMangle) > PInvokeAttributes.CharSetNotSpec;
			bool flag2 = (pinvokeAttributes & PInvokeAttributes.SupportsLastError) > PInvokeAttributes.CharSetNotSpec;
			bool flag3 = (pinvokeAttributes & PInvokeAttributes.BestFitMask) == PInvokeAttributes.BestFitEnabled;
			bool flag4 = (pinvokeAttributes & PInvokeAttributes.ThrowOnUnmappableCharMask) == PInvokeAttributes.ThrowOnUnmappableCharEnabled;
			bool flag5 = (this.GetMethodImplementationFlags() & MethodImplAttributes.PreserveSig) > MethodImplAttributes.IL;
			CustomAttributeTypedArgument[] ctorArgs = new CustomAttributeTypedArgument[]
			{
				new CustomAttributeTypedArgument(typeof(string), value)
			};
			Type typeFromHandle = typeof(DllImportAttribute);
			CustomAttributeNamedArgument[] namedArgs = new CustomAttributeNamedArgument[]
			{
				new CustomAttributeNamedArgument(typeFromHandle.GetField("EntryPoint"), value2),
				new CustomAttributeNamedArgument(typeFromHandle.GetField("CharSet"), charSet),
				new CustomAttributeNamedArgument(typeFromHandle.GetField("ExactSpelling"), flag),
				new CustomAttributeNamedArgument(typeFromHandle.GetField("SetLastError"), flag2),
				new CustomAttributeNamedArgument(typeFromHandle.GetField("PreserveSig"), flag5),
				new CustomAttributeNamedArgument(typeFromHandle.GetField("CallingConvention"), callingConvention),
				new CustomAttributeNamedArgument(typeFromHandle.GetField("BestFitMapping"), flag3),
				new CustomAttributeNamedArgument(typeFromHandle.GetField("ThrowOnUnmappableChar"), flag4)
			};
			return new CustomAttributeData(typeFromHandle.GetConstructor(new Type[]
			{
				typeof(string)
			}), ctorArgs, namedArgs);
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x0008DD44 File Offset: 0x0008BF44
		public override MethodInfo MakeGenericMethod(params Type[] methodInstantiation)
		{
			if (methodInstantiation == null)
			{
				throw new ArgumentNullException("methodInstantiation");
			}
			if (!this.IsGenericMethodDefinition)
			{
				throw new InvalidOperationException("not a generic method definition");
			}
			if (this.GetGenericArguments().Length != methodInstantiation.Length)
			{
				throw new ArgumentException("Incorrect length");
			}
			bool flag = false;
			foreach (Type type in methodInstantiation)
			{
				if (type == null)
				{
					throw new ArgumentNullException();
				}
				if (!(type is RuntimeType))
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (RuntimeFeature.IsDynamicCodeSupported)
				{
					return new MethodOnTypeBuilderInst(this, methodInstantiation);
				}
				throw new NotSupportedException("User types are not supported under full aot");
			}
			else
			{
				MethodInfo methodInfo = this.MakeGenericMethod_impl(methodInstantiation);
				if (methodInfo == null)
				{
					throw new ArgumentException(string.Format("The method has {0} generic parameter(s) but {1} generic argument(s) were provided.", this.GetGenericArguments().Length, methodInstantiation.Length));
				}
				return methodInfo;
			}
		}

		// Token: 0x06002393 RID: 9107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern MethodInfo MakeGenericMethod_impl(Type[] types);

		// Token: 0x06002394 RID: 9108
		[MethodImpl(MethodImplOptions.InternalCall)]
		public override extern Type[] GetGenericArguments();

		// Token: 0x06002395 RID: 9109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern MethodInfo GetGenericMethodDefinition_impl();

		// Token: 0x06002396 RID: 9110 RVA: 0x0008DE09 File Offset: 0x0008C009
		public override MethodInfo GetGenericMethodDefinition()
		{
			MethodInfo genericMethodDefinition_impl = this.GetGenericMethodDefinition_impl();
			if (genericMethodDefinition_impl == null)
			{
				throw new InvalidOperationException();
			}
			return genericMethodDefinition_impl;
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06002397 RID: 9111
		public override extern bool IsGenericMethodDefinition { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06002398 RID: 9112
		public override extern bool IsGenericMethod { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06002399 RID: 9113 RVA: 0x0008DE20 File Offset: 0x0008C020
		public override bool ContainsGenericParameters
		{
			get
			{
				if (this.IsGenericMethod)
				{
					Type[] genericArguments = this.GetGenericArguments();
					for (int i = 0; i < genericArguments.Length; i++)
					{
						if (genericArguments[i].ContainsGenericParameters)
						{
							return true;
						}
					}
				}
				return this.DeclaringType.ContainsGenericParameters;
			}
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x0008D2C1 File Offset: 0x0008B4C1
		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return CustomAttributeData.GetCustomAttributes(this);
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x0000B18D File Offset: 0x0000938D
		private static int get_core_clr_security_level()
		{
			return 1;
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x0600239C RID: 9116 RVA: 0x0008DE61 File Offset: 0x0008C061
		public override bool IsSecurityCritical
		{
			get
			{
				return RuntimeMethodInfo.get_core_clr_security_level() > 0;
			}
		}

		// Token: 0x04001134 RID: 4404
		internal IntPtr mhandle;

		// Token: 0x04001135 RID: 4405
		private string name;

		// Token: 0x04001136 RID: 4406
		private Type reftype;
	}
}
