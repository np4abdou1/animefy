using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001BF RID: 447
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/PrimitiveSpreadBuilder", DoNotGenerateAcw = true)]
	internal class PrimitiveSpreadBuilderInvoker : PrimitiveSpreadBuilder
	{
		// Token: 0x0600160E RID: 5646 RVA: 0x00047633 File Offset: 0x00045833
		public PrimitiveSpreadBuilderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x0004763D File Offset: 0x0004583D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PrimitiveSpreadBuilderInvoker._members;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001610 RID: 5648 RVA: 0x00047644 File Offset: 0x00045844
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PrimitiveSpreadBuilderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00047650 File Offset: 0x00045850
		[Register("getSize", "(Ljava/lang/Object;)I", "GetGetSize_Ljava_lang_Object_Handler")]
		protected unsafe override int GetSize(Java.Lang.Object p0)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = PrimitiveSpreadBuilderInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getSize.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x0400070B RID: 1803
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/PrimitiveSpreadBuilder", typeof(PrimitiveSpreadBuilderInvoker));
	}
}
