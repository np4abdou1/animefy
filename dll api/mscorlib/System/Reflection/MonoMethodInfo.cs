using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x020004DA RID: 1242
	internal struct MonoMethodInfo
	{
		// Token: 0x0600235A RID: 9050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_method_info(IntPtr handle, out MonoMethodInfo info);

		// Token: 0x0600235B RID: 9051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int get_method_attributes(IntPtr handle);

		// Token: 0x0600235C RID: 9052 RVA: 0x0008D58C File Offset: 0x0008B78C
		internal static MonoMethodInfo GetMethodInfo(IntPtr handle)
		{
			MonoMethodInfo result;
			MonoMethodInfo.get_method_info(handle, out result);
			return result;
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x0008D5A2 File Offset: 0x0008B7A2
		internal static Type GetDeclaringType(IntPtr handle)
		{
			return MonoMethodInfo.GetMethodInfo(handle).parent;
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x0008D5AF File Offset: 0x0008B7AF
		internal static Type GetReturnType(IntPtr handle)
		{
			return MonoMethodInfo.GetMethodInfo(handle).ret;
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x0008D5BC File Offset: 0x0008B7BC
		internal static MethodAttributes GetAttributes(IntPtr handle)
		{
			return (MethodAttributes)MonoMethodInfo.get_method_attributes(handle);
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x0008D5C4 File Offset: 0x0008B7C4
		internal static CallingConventions GetCallingConvention(IntPtr handle)
		{
			return MonoMethodInfo.GetMethodInfo(handle).callconv;
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x0008D5D1 File Offset: 0x0008B7D1
		internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle)
		{
			return MonoMethodInfo.GetMethodInfo(handle).iattrs;
		}

		// Token: 0x06002362 RID: 9058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member);

		// Token: 0x06002363 RID: 9059 RVA: 0x0008D5DE File Offset: 0x0008B7DE
		internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member)
		{
			return MonoMethodInfo.get_parameter_info(handle, member);
		}

		// Token: 0x06002364 RID: 9060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern MarshalAsAttribute get_retval_marshal(IntPtr handle);

		// Token: 0x06002365 RID: 9061 RVA: 0x0008D5E7 File Offset: 0x0008B7E7
		internal static ParameterInfo GetReturnParameterInfo(RuntimeMethodInfo method)
		{
			return RuntimeParameterInfo.New(MonoMethodInfo.GetReturnType(method.mhandle), method, MonoMethodInfo.get_retval_marshal(method.mhandle));
		}

		// Token: 0x0400112F RID: 4399
		private Type parent;

		// Token: 0x04001130 RID: 4400
		private Type ret;

		// Token: 0x04001131 RID: 4401
		internal MethodAttributes attrs;

		// Token: 0x04001132 RID: 4402
		internal MethodImplAttributes iattrs;

		// Token: 0x04001133 RID: 4403
		private CallingConventions callconv;
	}
}
