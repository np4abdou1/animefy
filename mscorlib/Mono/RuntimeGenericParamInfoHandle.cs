using System;
using System.Reflection;

namespace Mono
{
	// Token: 0x02000015 RID: 21
	internal struct RuntimeGenericParamInfoHandle
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00002678 File Offset: 0x00000878
		internal unsafe RuntimeGenericParamInfoHandle(IntPtr ptr)
		{
			this.value = (RuntimeStructs.GenericParamInfo*)((void*)ptr);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002686 File Offset: 0x00000886
		internal Type[] Constraints
		{
			get
			{
				return this.GetConstraints();
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000268E File Offset: 0x0000088E
		internal unsafe GenericParameterAttributes Attributes
		{
			get
			{
				return (GenericParameterAttributes)this.value->flags;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000269C File Offset: 0x0000089C
		private unsafe Type[] GetConstraints()
		{
			int constraintsCount = this.GetConstraintsCount();
			Type[] array = new Type[constraintsCount];
			for (int i = 0; i < constraintsCount; i++)
			{
				RuntimeClassHandle runtimeClassHandle = new RuntimeClassHandle(*(IntPtr*)(this.value->constraints + (IntPtr)i * (IntPtr)sizeof(RuntimeStructs.MonoClass*) / (IntPtr)sizeof(RuntimeStructs.MonoClass*)));
				array[i] = Type.GetTypeFromHandle(runtimeClassHandle.GetTypeHandle());
			}
			return array;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000026F0 File Offset: 0x000008F0
		private unsafe int GetConstraintsCount()
		{
			int num = 0;
			RuntimeStructs.MonoClass** ptr = this.value->constraints;
			while (ptr != null && *(IntPtr*)ptr != (IntPtr)((UIntPtr)0))
			{
				ptr += sizeof(RuntimeStructs.MonoClass*) / sizeof(RuntimeStructs.MonoClass*);
				num++;
			}
			return num;
		}

		// Token: 0x0400008B RID: 139
		private unsafe RuntimeStructs.GenericParamInfo* value;
	}
}
