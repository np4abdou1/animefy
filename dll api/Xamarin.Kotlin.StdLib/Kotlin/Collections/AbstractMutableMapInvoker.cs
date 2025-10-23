using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Collections
{
	// Token: 0x020002B7 RID: 695
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/AbstractMutableMap", DoNotGenerateAcw = true)]
	internal class AbstractMutableMapInvoker : AbstractMutableMap
	{
		// Token: 0x0600206E RID: 8302 RVA: 0x0006BF5D File Offset: 0x0006A15D
		public AbstractMutableMapInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x0006BF67 File Offset: 0x0006A167
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractMutableMapInvoker._members;
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x0006BF6E File Offset: 0x0006A16E
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractMutableMapInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06002071 RID: 8305 RVA: 0x0006BF7C File Offset: 0x0006A17C
		[Nullable(2)]
		public override ICollection Entries
		{
			[NullableContext(2)]
			[Register("getEntries", "()Ljava/util/Set;", "GetGetEntriesHandler")]
			get
			{
				return JavaSet.FromJniHandle(AbstractMutableMapInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getEntries.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x0006BFB0 File Offset: 0x0006A1B0
		[NullableContext(2)]
		[Register("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public unsafe override Java.Lang.Object Put(Java.Lang.Object key, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(value);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractMutableMapInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("put.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(key);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x04000986 RID: 2438
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractMutableMap", typeof(AbstractMutableMapInvoker));
	}
}
