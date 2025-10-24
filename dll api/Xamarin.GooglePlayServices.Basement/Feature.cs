using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Common.Internal.SafeParcel;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common
{
	// Token: 0x0200000F RID: 15
	[Register("com/google/android/gms/common/Feature", DoNotGenerateAcw = true)]
	public class Feature : AbstractSafeParcelable
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002500 File Offset: 0x00000700
		[Register("CREATOR")]
		public static IParcelableCreator Creator
		{
			get
			{
				return Java.Lang.Object.GetObject<IParcelableCreator>(Feature._members.StaticFields.GetObjectValue("CREATOR.Landroid/os/Parcelable$Creator;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002530 File Offset: 0x00000730
		internal new static IntPtr class_ref
		{
			get
			{
				return Feature._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002554 File Offset: 0x00000754
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Feature._members;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000255C File Offset: 0x0000075C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Feature._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002580 File Offset: 0x00000780
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Feature._members.ManagedPeerType;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000210C File Offset: 0x0000030C
		protected Feature(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000258C File Offset: 0x0000078C
		[Register(".ctor", "(Ljava/lang/String;IJ)V", "")]
		public unsafe Feature(string p0, int p1, long p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				ptr[2] = new JniArgumentValue(p2);
				base.SetHandle(Feature._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;IJ)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Feature._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;IJ)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000265C File Offset: 0x0000085C
		[Register(".ctor", "(Ljava/lang/String;J)V", "")]
		public unsafe Feature(string name, long version) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(name);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(version);
				base.SetHandle(Feature._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;J)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Feature._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;J)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002714 File Offset: 0x00000914
		private static Delegate GetGetNameHandler()
		{
			if (Feature.cb_getName == null)
			{
				Feature.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Feature.n_GetName));
			}
			return Feature.cb_getName;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002738 File Offset: 0x00000938
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Feature>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004D RID: 77 RVA: 0x0000274C File Offset: 0x0000094C
		public virtual string Name
		{
			[Register("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get
			{
				return JNIEnv.GetString(Feature._members.InstanceMethods.InvokeVirtualObjectMethod("getName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000277E File Offset: 0x0000097E
		private static Delegate GetGetVersionHandler()
		{
			if (Feature.cb_getVersion == null)
			{
				Feature.cb_getVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(Feature.n_GetVersion));
			}
			return Feature.cb_getVersion;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000027A2 File Offset: 0x000009A2
		private static long n_GetVersion(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Feature>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Version;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000027B1 File Offset: 0x000009B1
		public virtual long Version
		{
			[Register("getVersion", "()J", "GetGetVersionHandler")]
			get
			{
				return Feature._members.InstanceMethods.InvokeVirtualInt64Method("getVersion.()J", this, null);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000027CC File Offset: 0x000009CC
		[Register("equals", "(Ljava/lang/Object;)Z", "")]
		public unsafe sealed override bool Equals(Java.Lang.Object p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = Feature._members.InstanceMethods.InvokeNonvirtualBooleanMethod("equals.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002834 File Offset: 0x00000A34
		[Register("hashCode", "()I", "")]
		public sealed override int GetHashCode()
		{
			return Feature._members.InstanceMethods.InvokeNonvirtualInt32Method("hashCode.()I", this, null);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002850 File Offset: 0x00000A50
		[Register("toString", "()Ljava/lang/String;", "")]
		public sealed override string ToString()
		{
			return JNIEnv.GetString(Feature._members.InstanceMethods.InvokeNonvirtualObjectMethod("toString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002884 File Offset: 0x00000A84
		[Register("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe sealed override void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				Feature._members.InstanceMethods.InvokeNonvirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000002 RID: 2
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/Feature", typeof(Feature));

		// Token: 0x04000003 RID: 3
		private static Delegate cb_getName;

		// Token: 0x04000004 RID: 4
		private static Delegate cb_getVersion;
	}
}
