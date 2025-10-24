using System;
using System.Runtime.CompilerServices;

namespace Mono
{
	// Token: 0x02000013 RID: 19
	internal struct RuntimeClassHandle
	{
		// Token: 0x06000033 RID: 51 RVA: 0x000025CC File Offset: 0x000007CC
		internal unsafe RuntimeClassHandle(RuntimeStructs.MonoClass* value)
		{
			this.value = value;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000025D5 File Offset: 0x000007D5
		internal unsafe RuntimeClassHandle(IntPtr ptr)
		{
			this.value = (RuntimeStructs.MonoClass*)((void*)ptr);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000025E3 File Offset: 0x000007E3
		internal unsafe RuntimeStructs.MonoClass* Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000025EC File Offset: 0x000007EC
		public override bool Equals(object obj)
		{
			return obj != null && !(base.GetType() != obj.GetType()) && this.value == ((RuntimeClassHandle)obj).Value;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002634 File Offset: 0x00000834
		public unsafe override int GetHashCode()
		{
			return ((IntPtr)((void*)this.value)).GetHashCode();
		}

		// Token: 0x06000038 RID: 56
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass);

		// Token: 0x06000039 RID: 57 RVA: 0x00002654 File Offset: 0x00000854
		internal RuntimeTypeHandle GetTypeHandle()
		{
			return new RuntimeTypeHandle(RuntimeClassHandle.GetTypeFromClass(this.value));
		}

		// Token: 0x04000089 RID: 137
		private unsafe RuntimeStructs.MonoClass* value;
	}
}
