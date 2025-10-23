using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Collection;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Util
{
	// Token: 0x02000045 RID: 69
	[Register("com/bumptech/glide/util/CachedHashCodeArrayMap", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"K",
		"V"
	})]
	public sealed class CachedHashCodeArrayMap : ArrayMap
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0000A8F4 File Offset: 0x00008AF4
		internal static IntPtr class_ref
		{
			get
			{
				return CachedHashCodeArrayMap._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0000A918 File Offset: 0x00008B18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CachedHashCodeArrayMap._members;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0000A920 File Offset: 0x00008B20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CachedHashCodeArrayMap._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600030F RID: 783 RVA: 0x0000A944 File Offset: 0x00008B44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CachedHashCodeArrayMap._members.ManagedPeerType;
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000A950 File Offset: 0x00008B50
		internal CachedHashCodeArrayMap(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000A95C File Offset: 0x00008B5C
		[Register(".ctor", "()V", "")]
		public CachedHashCodeArrayMap() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(CachedHashCodeArrayMap._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			CachedHashCodeArrayMap._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000A9CC File Offset: 0x00008BCC
		[Register("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
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
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CachedHashCodeArrayMap._members.InstanceMethods.InvokeAbstractObjectMethod("put.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000313 RID: 787 RVA: 0x0000AA68 File Offset: 0x00008C68
		[Register("putAll", "(Landroidx/collection/SimpleArrayMap;)V", "")]
		public unsafe override void PutAll(SimpleArrayMap simpleArrayMap)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((simpleArrayMap == null) ? IntPtr.Zero : simpleArrayMap.Handle);
				CachedHashCodeArrayMap._members.InstanceMethods.InvokeAbstractVoidMethod("putAll.(Landroidx/collection/SimpleArrayMap;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(simpleArrayMap);
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000AACC File Offset: 0x00008CCC
		[Register("setValueAt", "(ILjava/lang/Object;)Ljava/lang/Object;", "")]
		public unsafe override Java.Lang.Object SetValueAt(int index, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CachedHashCodeArrayMap._members.InstanceMethods.InvokeAbstractObjectMethod("setValueAt.(ILjava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x040000A5 RID: 165
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/CachedHashCodeArrayMap", typeof(CachedHashCodeArrayMap));
	}
}
