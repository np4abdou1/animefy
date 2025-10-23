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
	// Token: 0x020002B3 RID: 691
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/AbstractMutableCollection", DoNotGenerateAcw = true)]
	internal class AbstractMutableCollectionInvoker : AbstractMutableCollection
	{
		// Token: 0x0600202F RID: 8239 RVA: 0x0006B6DA File Offset: 0x000698DA
		public AbstractMutableCollectionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x0006B6E4 File Offset: 0x000698E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractMutableCollectionInvoker._members;
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06002031 RID: 8241 RVA: 0x0006B6EB File Offset: 0x000698EB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractMutableCollectionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x0006B6F8 File Offset: 0x000698F8
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
				result = AbstractMutableCollectionInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("add.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x0006B75C File Offset: 0x0006995C
		[Register("getSize", "()I", "GetGetSizeHandler")]
		public override int GetSize()
		{
			return AbstractMutableCollectionInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getSize.()I", this, null);
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x0006B778 File Offset: 0x00069978
		[Register("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public override IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(AbstractMutableCollectionInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000979 RID: 2425
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractMutableCollection", typeof(AbstractMutableCollectionInvoker));
	}
}
