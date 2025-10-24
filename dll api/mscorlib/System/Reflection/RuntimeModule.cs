using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x020004DD RID: 1245
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_Module))]
	[ClassInterface(ClassInterfaceType.None)]
	[Serializable]
	[StructLayout(0)]
	internal class RuntimeModule : Module
	{
		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060023BE RID: 9150 RVA: 0x0008E107 File Offset: 0x0008C307
		public override Assembly Assembly
		{
			get
			{
				return this.assembly;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060023BF RID: 9151 RVA: 0x0008E10F File Offset: 0x0008C30F
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060023C0 RID: 9152 RVA: 0x0008E117 File Offset: 0x0008C317
		public override string ScopeName
		{
			get
			{
				return this.scopename;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060023C1 RID: 9153 RVA: 0x0008E11F File Offset: 0x0008C31F
		public override Guid ModuleVersionId
		{
			get
			{
				return this.GetModuleVersionId();
			}
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x0008E127 File Offset: 0x0008C327
		public override bool IsResource()
		{
			return this.is_resource;
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x0008D062 File Offset: 0x0008B262
		public override object[] GetCustomAttributes(bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, inherit);
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x0008D06B File Offset: 0x0008B26B
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, attributeType, inherit);
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x00032332 File Offset: 0x00030532
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x0008E12F File Offset: 0x0008C32F
		public override MethodBase ResolveMethod(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			return RuntimeModule.ResolveMethod(this, this._impl, metadataToken, genericTypeArguments, genericMethodArguments);
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x0008E140 File Offset: 0x0008C340
		internal static MethodBase ResolveMethod(Module module, IntPtr monoModule, int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			ResolveTokenError error;
			IntPtr intPtr = RuntimeModule.ResolveMethodToken(monoModule, metadataToken, RuntimeModule.ptrs_from_types(genericTypeArguments), RuntimeModule.ptrs_from_types(genericMethodArguments), out error);
			if (intPtr == IntPtr.Zero)
			{
				throw RuntimeModule.resolve_token_exception(module.Name, metadataToken, error, "MethodBase");
			}
			return RuntimeMethodInfo.GetMethodFromHandleNoGenericCheck(new RuntimeMethodHandle(intPtr));
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x0008E18F File Offset: 0x0008C38F
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			UnitySerializationHolder.GetUnitySerializationInfo(info, 5, this.ScopeName, this.GetRuntimeAssembly());
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x0008E1B2 File Offset: 0x0008C3B2
		public override Type[] GetTypes()
		{
			return RuntimeModule.InternalGetTypes(this._impl);
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x0008E1BF File Offset: 0x0008C3BF
		internal RuntimeAssembly GetRuntimeAssembly()
		{
			return (RuntimeAssembly)this.assembly;
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x0008E1CC File Offset: 0x0008C3CC
		internal override Guid GetModuleVersionId()
		{
			byte[] array = new byte[16];
			RuntimeModule.GetGuidInternal(this._impl, array);
			return new Guid(array);
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x0008E1F3 File Offset: 0x0008C3F3
		internal static Exception resolve_token_exception(string name, int metadataToken, ResolveTokenError error, string tokenType)
		{
			if (error == ResolveTokenError.OutOfRange)
			{
				return new ArgumentOutOfRangeException("metadataToken", string.Format("Token 0x{0:x} is not valid in the scope of module {1}", metadataToken, name));
			}
			return new ArgumentException(string.Format("Token 0x{0:x} is not a valid {1} token in the scope of module {2}", metadataToken, tokenType, name), "metadataToken");
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x0008E230 File Offset: 0x0008C430
		internal static IntPtr[] ptrs_from_types(Type[] types)
		{
			if (types == null)
			{
				return null;
			}
			IntPtr[] array = new IntPtr[types.Length];
			for (int i = 0; i < types.Length; i++)
			{
				if (types[i] == null)
				{
					throw new ArgumentException();
				}
				array[i] = types[i].TypeHandle.Value;
			}
			return array;
		}

		// Token: 0x060023CE RID: 9166
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Type[] InternalGetTypes(IntPtr module);

		// Token: 0x060023CF RID: 9167
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetGuidInternal(IntPtr module, byte[] guid);

		// Token: 0x060023D0 RID: 9168
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern IntPtr ResolveMethodToken(IntPtr module, int token, IntPtr[] type_args, IntPtr[] method_args, out ResolveTokenError error);

		// Token: 0x0400113A RID: 4410
		internal IntPtr _impl;

		// Token: 0x0400113B RID: 4411
		internal Assembly assembly;

		// Token: 0x0400113C RID: 4412
		internal string fqname;

		// Token: 0x0400113D RID: 4413
		internal string name;

		// Token: 0x0400113E RID: 4414
		internal string scopename;

		// Token: 0x0400113F RID: 4415
		internal bool is_resource;

		// Token: 0x04001140 RID: 4416
		internal int token;
	}
}
