using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001B2 RID: 434
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/LongSpreadBuilder", DoNotGenerateAcw = true)]
	public sealed class LongSpreadBuilder : PrimitiveSpreadBuilder
	{
		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x00044BF4 File Offset: 0x00042DF4
		internal new static IntPtr class_ref
		{
			get
			{
				return LongSpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x00044C18 File Offset: 0x00042E18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LongSpreadBuilder._members;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x00044C20 File Offset: 0x00042E20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LongSpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x00044C44 File Offset: 0x00042E44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LongSpreadBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x00044C50 File Offset: 0x00042E50
		internal LongSpreadBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00044C5C File Offset: 0x00042E5C
		[Register(".ctor", "(I)V", "")]
		public unsafe LongSpreadBuilder(int size) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			base.SetHandle(LongSpreadBuilder._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			LongSpreadBuilder._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00044CE0 File Offset: 0x00042EE0
		[Register("add", "(J)V", "")]
		public unsafe void Add(long value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			LongSpreadBuilder._members.InstanceMethods.InvokeNonvirtualVoidMethod("add.(J)V", this, ptr);
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x00044D1C File Offset: 0x00042F1C
		[Register("getSize", "(Ljava/lang/Object;)I", "")]
		protected unsafe override int GetSize(Java.Lang.Object _this_getSize)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_getSize == null) ? IntPtr.Zero : _this_getSize.Handle);
				result = LongSpreadBuilder._members.InstanceMethods.InvokeAbstractInt32Method("getSize.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(_this_getSize);
			}
			return result;
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00044D84 File Offset: 0x00042F84
		[Register("toArray", "()[J", "")]
		public long[] ToArray()
		{
			return (long[])JNIEnv.GetArray(LongSpreadBuilder._members.InstanceMethods.InvokeNonvirtualObjectMethod("toArray.()[J", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(long));
		}

		// Token: 0x040006E5 RID: 1765
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/LongSpreadBuilder", typeof(LongSpreadBuilder));
	}
}
