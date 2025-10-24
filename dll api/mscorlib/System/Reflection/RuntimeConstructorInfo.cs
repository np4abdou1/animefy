using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x020004DC RID: 1244
	[Serializable]
	[StructLayout(0)]
	internal class RuntimeConstructorInfo : ConstructorInfo, ISerializable
	{
		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x0600239D RID: 9117 RVA: 0x0008DE6B File Offset: 0x0008C06B
		public override Module Module
		{
			get
			{
				return this.GetRuntimeModule();
			}
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x0008DE73 File Offset: 0x0008C073
		internal RuntimeModule GetRuntimeModule()
		{
			return RuntimeTypeHandle.GetModule((RuntimeType)this.DeclaringType);
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x0600239F RID: 9119 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		internal BindingFlags BindingFlags
		{
			get
			{
				return BindingFlags.Default;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x0008D10B File Offset: 0x0008B30B
		private RuntimeType ReflectedTypeInternal
		{
			get
			{
				return (RuntimeType)this.ReflectedType;
			}
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x0008DE85 File Offset: 0x0008C085
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			MemberInfoSerializationHolder.GetSerializationInfo(info, this.Name, this.ReflectedTypeInternal, this.ToString(), this.SerializationToString(), MemberTypes.Constructor, null);
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x0008DEB5 File Offset: 0x0008C0B5
		internal string SerializationToString()
		{
			return this.FormatNameAndSig(true);
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x0008DEBE File Offset: 0x0008C0BE
		internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context)
		{
			base.Invoke(target, new object[]
			{
				info,
				context
			});
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x0008DEDB File Offset: 0x0008C0DB
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return MonoMethodInfo.GetMethodImplementationFlags(this.mhandle);
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x0008DEE8 File Offset: 0x0008C0E8
		public override ParameterInfo[] GetParameters()
		{
			return MonoMethodInfo.GetParametersInfo(this.mhandle, this);
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x0008DEE8 File Offset: 0x0008C0E8
		internal override ParameterInfo[] GetParametersInternal()
		{
			return MonoMethodInfo.GetParametersInfo(this.mhandle, this);
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x0008DEF8 File Offset: 0x0008C0F8
		internal override int GetParametersCount()
		{
			ParameterInfo[] parametersInfo = MonoMethodInfo.GetParametersInfo(this.mhandle, this);
			if (parametersInfo != null)
			{
				return parametersInfo.Length;
			}
			return 0;
		}

		// Token: 0x060023A8 RID: 9128
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern object InternalInvoke(object obj, object[] parameters, out Exception exc);

		// Token: 0x060023A9 RID: 9129 RVA: 0x0008DF1A File Offset: 0x0008C11A
		[DebuggerHidden]
		[DebuggerStepThrough]
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			if (obj == null)
			{
				if (!base.IsStatic)
				{
					throw new TargetException("Instance constructor requires a target");
				}
			}
			else if (!this.DeclaringType.IsInstanceOfType(obj))
			{
				throw new TargetException("Constructor does not match target type");
			}
			return this.DoInvoke(obj, invokeAttr, binder, parameters, culture);
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x0008DF58 File Offset: 0x0008C158
		private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			if (binder == null)
			{
				binder = Type.DefaultBinder;
			}
			ParameterInfo[] parametersInfo = MonoMethodInfo.GetParametersInfo(this.mhandle, this);
			RuntimeMethodInfo.ConvertValues(binder, parameters, parametersInfo, culture, invokeAttr);
			if (obj == null && this.DeclaringType.ContainsGenericParameters)
			{
				string str = "Cannot create an instance of ";
				Type declaringType = this.DeclaringType;
				throw new MemberAccessException(str + ((declaringType != null) ? declaringType.ToString() : null) + " because Type.ContainsGenericParameters is true.");
			}
			if ((invokeAttr & BindingFlags.CreateInstance) != BindingFlags.Default && this.DeclaringType.IsAbstract)
			{
				throw new MemberAccessException(string.Format("Cannot create an instance of {0} because it is an abstract class", this.DeclaringType));
			}
			return this.InternalInvoke(obj, parameters, (invokeAttr & BindingFlags.DoNotWrapExceptions) == BindingFlags.Default);
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x0008E000 File Offset: 0x0008C200
		public object InternalInvoke(object obj, object[] parameters, bool wrapExceptions)
		{
			object result = null;
			Exception ex;
			if (wrapExceptions)
			{
				try
				{
					result = this.InternalInvoke(obj, parameters, out ex);
					goto IL_29;
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
			IL_29:
			if (ex != null)
			{
				throw ex;
			}
			if (obj != null)
			{
				return null;
			}
			return result;
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x0008E06C File Offset: 0x0008C26C
		[DebuggerHidden]
		[DebuggerStepThrough]
		public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			return this.DoInvoke(null, invokeAttr, binder, parameters, culture);
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060023AD RID: 9133 RVA: 0x0008E07A File Offset: 0x0008C27A
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				return new RuntimeMethodHandle(this.mhandle);
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x0008E087 File Offset: 0x0008C287
		public override MethodAttributes Attributes
		{
			get
			{
				return MonoMethodInfo.GetAttributes(this.mhandle);
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060023AF RID: 9135 RVA: 0x0008E094 File Offset: 0x0008C294
		public override CallingConventions CallingConvention
		{
			get
			{
				return MonoMethodInfo.GetCallingConvention(this.mhandle);
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x0008E0A1 File Offset: 0x0008C2A1
		public override bool ContainsGenericParameters
		{
			get
			{
				return this.DeclaringType.ContainsGenericParameters;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060023B1 RID: 9137 RVA: 0x0008E0AE File Offset: 0x0008C2AE
		public override Type ReflectedType
		{
			get
			{
				return this.reftype;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060023B2 RID: 9138 RVA: 0x0008E0B6 File Offset: 0x0008C2B6
		public override Type DeclaringType
		{
			get
			{
				return MonoMethodInfo.GetDeclaringType(this.mhandle);
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060023B3 RID: 9139 RVA: 0x0008E0C3 File Offset: 0x0008C2C3
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

		// Token: 0x060023B4 RID: 9140 RVA: 0x00032332 File Offset: 0x00030532
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x0008D062 File Offset: 0x0008B262
		public override object[] GetCustomAttributes(bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, inherit);
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x0008D06B File Offset: 0x0008B26B
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, attributeType, inherit);
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x0008E0DA File Offset: 0x0008C2DA
		public override string ToString()
		{
			return "Void " + this.FormatNameAndSig(false);
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x0008D2C1 File Offset: 0x0008B4C1
		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return CustomAttributeData.GetCustomAttributes(this);
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x0000B18D File Offset: 0x0000938D
		private static int get_core_clr_security_level()
		{
			return 1;
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x0008E0ED File Offset: 0x0008C2ED
		public override bool IsSecurityCritical
		{
			get
			{
				return RuntimeConstructorInfo.get_core_clr_security_level() > 0;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060023BB RID: 9147 RVA: 0x0008E0F7 File Offset: 0x0008C2F7
		public override int MetadataToken
		{
			get
			{
				return RuntimeConstructorInfo.get_metadata_token(this);
			}
		}

		// Token: 0x060023BC RID: 9148
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int get_metadata_token(RuntimeConstructorInfo method);

		// Token: 0x04001137 RID: 4407
		internal IntPtr mhandle;

		// Token: 0x04001138 RID: 4408
		private string name;

		// Token: 0x04001139 RID: 4409
		private Type reftype;
	}
}
