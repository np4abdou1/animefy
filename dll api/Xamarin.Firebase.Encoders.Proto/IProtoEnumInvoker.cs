using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Firebase.Encoders.Proto
{
	// Token: 0x02000004 RID: 4
	[Register("com/google/firebase/encoders/proto/ProtoEnum", DoNotGenerateAcw = true)]
	internal class IProtoEnumInvoker : Java.Lang.Object, IProtoEnum, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		private static IntPtr java_class_ref
		{
			get
			{
				return IProtoEnumInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002074 File Offset: 0x00000274
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IProtoEnumInvoker._members;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000207B File Offset: 0x0000027B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002083 File Offset: 0x00000283
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IProtoEnumInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000208F File Offset: 0x0000028F
		public static IProtoEnum GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IProtoEnum>(handle, transfer);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002098 File Offset: 0x00000298
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IProtoEnumInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.firebase.encoders.proto.ProtoEnum'.");
			}
			return handle;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020C3 File Offset: 0x000002C3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020F4 File Offset: 0x000002F4
		public IProtoEnumInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IProtoEnumInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000212C File Offset: 0x0000032C
		private static Delegate GetGetNumberHandler()
		{
			if (IProtoEnumInvoker.cb_getNumber == null)
			{
				IProtoEnumInvoker.cb_getNumber = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IProtoEnumInvoker.n_GetNumber));
			}
			return IProtoEnumInvoker.cb_getNumber;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002150 File Offset: 0x00000350
		private static int n_GetNumber(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IProtoEnum>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Number;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000215F File Offset: 0x0000035F
		public int Number
		{
			get
			{
				if (this.id_getNumber == IntPtr.Zero)
				{
					this.id_getNumber = JNIEnv.GetMethodID(this.class_ref, "getNumber", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getNumber);
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/firebase/encoders/proto/ProtoEnum", typeof(IProtoEnumInvoker));

		// Token: 0x04000002 RID: 2
		private IntPtr class_ref;

		// Token: 0x04000003 RID: 3
		private static Delegate cb_getNumber;

		// Token: 0x04000004 RID: 4
		private IntPtr id_getNumber;
	}
}
