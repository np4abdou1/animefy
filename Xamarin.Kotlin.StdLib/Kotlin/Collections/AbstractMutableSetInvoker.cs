using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Kotlin.Collections
{
	// Token: 0x020002B9 RID: 697
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/AbstractMutableSet", DoNotGenerateAcw = true)]
	internal class AbstractMutableSetInvoker : AbstractMutableSet
	{
		// Token: 0x06002082 RID: 8322 RVA: 0x0006C1EE File Offset: 0x0006A3EE
		public AbstractMutableSetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x0006C1F8 File Offset: 0x0006A3F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractMutableSetInvoker._members;
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06002084 RID: 8324 RVA: 0x0006C1FF File Offset: 0x0006A3FF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractMutableSetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x0006C20C File Offset: 0x0006A40C
		[NullableContext(2)]
		[Register("add", "(Ljava/lang/Object;)Z", "GetAdd_Ljava_lang_Object_Handler")]
		public unsafe override bool Add(Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AbstractMutableSetInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("add.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x0006C270 File Offset: 0x0006A470
		[Register("getSize", "()I", "GetGetSizeHandler")]
		public override int GetSize()
		{
			return AbstractMutableSetInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getSize.()I", this, null);
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x0006C28C File Offset: 0x0006A48C
		[Register("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public override IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(AbstractMutableSetInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400098A RID: 2442
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractMutableSet", typeof(AbstractMutableSetInvoker));
	}
}
