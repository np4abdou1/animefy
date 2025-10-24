using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Nio;

namespace Bumptech.Glide.GifDecoder
{
	// Token: 0x02000013 RID: 19
	[Register("com/bumptech/glide/gifdecoder/GifHeaderParser", DoNotGenerateAcw = true)]
	public class GifHeaderParser : Java.Lang.Object
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002308 File Offset: 0x00000508
		internal static IntPtr class_ref
		{
			get
			{
				return GifHeaderParser._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000232C File Offset: 0x0000052C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GifHeaderParser._members;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002334 File Offset: 0x00000534
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GifHeaderParser._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002358 File Offset: 0x00000558
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GifHeaderParser._members.ManagedPeerType;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002364 File Offset: 0x00000564
		protected GifHeaderParser(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002370 File Offset: 0x00000570
		[Register(".ctor", "()V", "")]
		public GifHeaderParser() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(GifHeaderParser._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			GifHeaderParser._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000023DE File Offset: 0x000005DE
		private static Delegate GetIsAnimatedHandler()
		{
			if (GifHeaderParser.cb_isAnimated == null)
			{
				GifHeaderParser.cb_isAnimated = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(GifHeaderParser.n_IsAnimated));
			}
			return GifHeaderParser.cb_isAnimated;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002402 File Offset: 0x00000602
		private static bool n_IsAnimated(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GifHeaderParser>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAnimated;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002411 File Offset: 0x00000611
		public virtual bool IsAnimated
		{
			[Register("isAnimated", "()Z", "GetIsAnimatedHandler")]
			get
			{
				return GifHeaderParser._members.InstanceMethods.InvokeVirtualBooleanMethod("isAnimated.()Z", this, null);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000242A File Offset: 0x0000062A
		private static Delegate GetClearHandler()
		{
			if (GifHeaderParser.cb_clear == null)
			{
				GifHeaderParser.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(GifHeaderParser.n_Clear));
			}
			return GifHeaderParser.cb_clear;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000244E File Offset: 0x0000064E
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<GifHeaderParser>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000245D File Offset: 0x0000065D
		[Register("clear", "()V", "GetClearHandler")]
		public virtual void Clear()
		{
			GifHeaderParser._members.InstanceMethods.InvokeVirtualVoidMethod("clear.()V", this, null);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002476 File Offset: 0x00000676
		private static Delegate GetParseHeaderHandler()
		{
			if (GifHeaderParser.cb_parseHeader == null)
			{
				GifHeaderParser.cb_parseHeader = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GifHeaderParser.n_ParseHeader));
			}
			return GifHeaderParser.cb_parseHeader;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000249A File Offset: 0x0000069A
		private static IntPtr n_ParseHeader(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GifHeaderParser>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ParseHeader());
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000024B0 File Offset: 0x000006B0
		[Register("parseHeader", "()Lcom/bumptech/glide/gifdecoder/GifHeader;", "GetParseHeaderHandler")]
		public virtual GifHeader ParseHeader()
		{
			return Java.Lang.Object.GetObject<GifHeader>(GifHeaderParser._members.InstanceMethods.InvokeVirtualObjectMethod("parseHeader.()Lcom/bumptech/glide/gifdecoder/GifHeader;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000024E2 File Offset: 0x000006E2
		private static Delegate GetSetData_arrayBHandler()
		{
			if (GifHeaderParser.cb_setData_arrayB == null)
			{
				GifHeaderParser.cb_setData_arrayB = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(GifHeaderParser.n_SetData_arrayB));
			}
			return GifHeaderParser.cb_setData_arrayB;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002508 File Offset: 0x00000708
		private static IntPtr n_SetData_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			GifHeaderParser @object = Java.Lang.Object.GetObject<GifHeaderParser>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[])JNIEnv.GetArray(native_data, JniHandleOwnership.DoNotTransfer, typeof(byte));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.SetData(array));
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_data);
			}
			return result;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000254C File Offset: 0x0000074C
		[Register("setData", "([B)Lcom/bumptech/glide/gifdecoder/GifHeaderParser;", "GetSetData_arrayBHandler")]
		public unsafe virtual GifHeaderParser SetData(byte[] data)
		{
			IntPtr intPtr = JNIEnv.NewArray(data);
			GifHeaderParser @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<GifHeaderParser>(GifHeaderParser._members.InstanceMethods.InvokeVirtualObjectMethod("setData.([B)Lcom/bumptech/glide/gifdecoder/GifHeaderParser;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (data != null)
				{
					JNIEnv.CopyArray(intPtr, data);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(data);
			}
			return @object;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000025C8 File Offset: 0x000007C8
		private static Delegate GetSetData_Ljava_nio_ByteBuffer_Handler()
		{
			if (GifHeaderParser.cb_setData_Ljava_nio_ByteBuffer_ == null)
			{
				GifHeaderParser.cb_setData_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(GifHeaderParser.n_SetData_Ljava_nio_ByteBuffer_));
			}
			return GifHeaderParser.cb_setData_Ljava_nio_ByteBuffer_;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000025EC File Offset: 0x000007EC
		private static IntPtr n_SetData_Ljava_nio_ByteBuffer_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			GifHeaderParser @object = Java.Lang.Object.GetObject<GifHeaderParser>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object2 = Java.Lang.Object.GetObject<ByteBuffer>(native_data, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetData(object2));
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002614 File Offset: 0x00000814
		[Register("setData", "(Ljava/nio/ByteBuffer;)Lcom/bumptech/glide/gifdecoder/GifHeaderParser;", "GetSetData_Ljava_nio_ByteBuffer_Handler")]
		public unsafe virtual GifHeaderParser SetData(ByteBuffer data)
		{
			GifHeaderParser @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((data == null) ? IntPtr.Zero : data.Handle);
				@object = Java.Lang.Object.GetObject<GifHeaderParser>(GifHeaderParser._members.InstanceMethods.InvokeVirtualObjectMethod("setData.(Ljava/nio/ByteBuffer;)Lcom/bumptech/glide/gifdecoder/GifHeaderParser;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(data);
			}
			return @object;
		}

		// Token: 0x04000009 RID: 9
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/gifdecoder/GifHeaderParser", typeof(GifHeaderParser));

		// Token: 0x0400000A RID: 10
		private static Delegate cb_isAnimated;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_clear;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_parseHeader;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_setData_arrayB;

		// Token: 0x0400000E RID: 14
		private static Delegate cb_setData_Ljava_nio_ByteBuffer_;
	}
}
