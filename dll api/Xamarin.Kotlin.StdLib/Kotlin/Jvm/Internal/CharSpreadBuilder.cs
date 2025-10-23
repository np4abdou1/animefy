using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x02000195 RID: 405
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/CharSpreadBuilder", DoNotGenerateAcw = true)]
	public sealed class CharSpreadBuilder : PrimitiveSpreadBuilder
	{
		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x00040D60 File Offset: 0x0003EF60
		internal new static IntPtr class_ref
		{
			get
			{
				return CharSpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x00040D84 File Offset: 0x0003EF84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CharSpreadBuilder._members;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x00040D8C File Offset: 0x0003EF8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CharSpreadBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x00040DB0 File Offset: 0x0003EFB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CharSpreadBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00040DBC File Offset: 0x0003EFBC
		internal CharSpreadBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00040DC8 File Offset: 0x0003EFC8
		[Register(".ctor", "(I)V", "")]
		public unsafe CharSpreadBuilder(int size) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			base.SetHandle(CharSpreadBuilder._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			CharSpreadBuilder._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00040E4C File Offset: 0x0003F04C
		[Register("add", "(C)V", "")]
		public unsafe void Add(char value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			CharSpreadBuilder._members.InstanceMethods.InvokeNonvirtualVoidMethod("add.(C)V", this, ptr);
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00040E88 File Offset: 0x0003F088
		[Register("getSize", "(Ljava/lang/Object;)I", "")]
		protected unsafe override int GetSize(Java.Lang.Object _this_getSize)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_getSize == null) ? IntPtr.Zero : _this_getSize.Handle);
				result = CharSpreadBuilder._members.InstanceMethods.InvokeAbstractInt32Method("getSize.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(_this_getSize);
			}
			return result;
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00040EF0 File Offset: 0x0003F0F0
		[Register("toArray", "()[C", "")]
		public char[] ToArray()
		{
			return (char[])JNIEnv.GetArray(CharSpreadBuilder._members.InstanceMethods.InvokeNonvirtualObjectMethod("toArray.()[C", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(char));
		}

		// Token: 0x04000692 RID: 1682
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/CharSpreadBuilder", typeof(CharSpreadBuilder));
	}
}
