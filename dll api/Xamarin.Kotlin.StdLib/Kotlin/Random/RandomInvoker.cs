using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Random
{
	// Token: 0x02000140 RID: 320
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/random/Random", DoNotGenerateAcw = true)]
	internal class RandomInvoker : Random
	{
		// Token: 0x060010F8 RID: 4344 RVA: 0x00038889 File Offset: 0x00036A89
		public RandomInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x00038893 File Offset: 0x00036A93
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RandomInvoker._members;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x0003889A File Offset: 0x00036A9A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RandomInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x000388A8 File Offset: 0x00036AA8
		[Register("nextBits", "(I)I", "GetNextBits_IHandler")]
		public unsafe override int NextBits(int bitCount)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(bitCount);
			return RandomInvoker._members.InstanceMethods.InvokeAbstractInt32Method("nextBits.(I)I", this, ptr);
		}

		// Token: 0x04000583 RID: 1411
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/random/Random", typeof(RandomInvoker));
	}
}
