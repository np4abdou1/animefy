using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x0200013F RID: 319
	[Register("com/bumptech/glide/load/model/LazyHeaders", DoNotGenerateAcw = true)]
	public sealed class LazyHeaders : Java.Lang.Object, IHeaders, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x00033954 File Offset: 0x00031B54
		internal static IntPtr class_ref
		{
			get
			{
				return LazyHeaders._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x00033978 File Offset: 0x00031B78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LazyHeaders._members;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x00033980 File Offset: 0x00031B80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LazyHeaders._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x000339A4 File Offset: 0x00031BA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LazyHeaders._members.ManagedPeerType;
			}
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x000339B0 File Offset: 0x00031BB0
		internal LazyHeaders(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x000339BC File Offset: 0x00031BBC
		public IDictionary<string, string> Headers
		{
			[Register("getHeaders", "()Ljava/util/Map;", "")]
			get
			{
				return JavaDictionary<string, string>.FromJniHandle(LazyHeaders._members.InstanceMethods.InvokeAbstractObjectMethod("getHeaders.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040003B7 RID: 951
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/LazyHeaders", typeof(LazyHeaders));

		// Token: 0x020001EC RID: 492
		public static class InterfaceConsts
		{
			// Token: 0x17000662 RID: 1634
			// (get) Token: 0x06001767 RID: 5991 RVA: 0x00048884 File Offset: 0x00046A84
			[Register("DEFAULT")]
			public static IHeaders Default
			{
				get
				{
					return Java.Lang.Object.GetObject<IHeaders>(LazyHeaders._members.StaticFields.GetObjectValue("DEFAULT.Lcom/bumptech/glide/load/model/Headers;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000663 RID: 1635
			// (get) Token: 0x06001768 RID: 5992 RVA: 0x000488B4 File Offset: 0x00046AB4
			[Register("NONE")]
			[Obsolete("deprecated")]
			public static IHeaders None
			{
				get
				{
					return Java.Lang.Object.GetObject<IHeaders>(LazyHeaders._members.StaticFields.GetObjectValue("NONE.Lcom/bumptech/glide/load/model/Headers;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
		}

		// Token: 0x020001ED RID: 493
		[Register("com/bumptech/glide/load/model/LazyHeaders$Builder", DoNotGenerateAcw = true)]
		public sealed class Builder : Java.Lang.Object
		{
			// Token: 0x17000664 RID: 1636
			// (get) Token: 0x06001769 RID: 5993 RVA: 0x000488E4 File Offset: 0x00046AE4
			internal static IntPtr class_ref
			{
				get
				{
					return LazyHeaders.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000665 RID: 1637
			// (get) Token: 0x0600176A RID: 5994 RVA: 0x00048908 File Offset: 0x00046B08
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return LazyHeaders.Builder._members;
				}
			}

			// Token: 0x17000666 RID: 1638
			// (get) Token: 0x0600176B RID: 5995 RVA: 0x00048910 File Offset: 0x00046B10
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return LazyHeaders.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000667 RID: 1639
			// (get) Token: 0x0600176C RID: 5996 RVA: 0x00048934 File Offset: 0x00046B34
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return LazyHeaders.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x0600176D RID: 5997 RVA: 0x00048940 File Offset: 0x00046B40
			internal Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600176E RID: 5998 RVA: 0x0004894C File Offset: 0x00046B4C
			[Register(".ctor", "()V", "")]
			public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(LazyHeaders.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				LazyHeaders.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x0600176F RID: 5999 RVA: 0x000489BC File Offset: 0x00046BBC
			[Register("addHeader", "(Ljava/lang/String;Lcom/bumptech/glide/load/model/LazyHeaderFactory;)Lcom/bumptech/glide/load/model/LazyHeaders$Builder;", "")]
			public unsafe LazyHeaders.Builder AddHeader(string key, ILazyHeaderFactory factory)
			{
				IntPtr intPtr = JNIEnv.NewString(key);
				LazyHeaders.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
					@object = Java.Lang.Object.GetObject<LazyHeaders.Builder>(LazyHeaders.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("addHeader.(Ljava/lang/String;Lcom/bumptech/glide/load/model/LazyHeaderFactory;)Lcom/bumptech/glide/load/model/LazyHeaders$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(factory);
				}
				return @object;
			}

			// Token: 0x06001770 RID: 6000 RVA: 0x00048A54 File Offset: 0x00046C54
			[Register("addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/bumptech/glide/load/model/LazyHeaders$Builder;", "")]
			public unsafe LazyHeaders.Builder AddHeader(string key, string value)
			{
				IntPtr intPtr = JNIEnv.NewString(key);
				IntPtr intPtr2 = JNIEnv.NewString(value);
				LazyHeaders.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue(intPtr2);
					@object = Java.Lang.Object.GetObject<LazyHeaders.Builder>(LazyHeaders.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("addHeader.(Ljava/lang/String;Ljava/lang/String;)Lcom/bumptech/glide/load/model/LazyHeaders$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				return @object;
			}

			// Token: 0x06001771 RID: 6001 RVA: 0x00048AE4 File Offset: 0x00046CE4
			[Register("build", "()Lcom/bumptech/glide/load/model/LazyHeaders;", "")]
			public LazyHeaders Build()
			{
				return Java.Lang.Object.GetObject<LazyHeaders>(LazyHeaders.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/bumptech/glide/load/model/LazyHeaders;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06001772 RID: 6002 RVA: 0x00048B18 File Offset: 0x00046D18
			[Register("setHeader", "(Ljava/lang/String;Lcom/bumptech/glide/load/model/LazyHeaderFactory;)Lcom/bumptech/glide/load/model/LazyHeaders$Builder;", "")]
			public unsafe LazyHeaders.Builder SetHeader(string key, ILazyHeaderFactory factory)
			{
				IntPtr intPtr = JNIEnv.NewString(key);
				LazyHeaders.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
					@object = Java.Lang.Object.GetObject<LazyHeaders.Builder>(LazyHeaders.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setHeader.(Ljava/lang/String;Lcom/bumptech/glide/load/model/LazyHeaderFactory;)Lcom/bumptech/glide/load/model/LazyHeaders$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(factory);
				}
				return @object;
			}

			// Token: 0x06001773 RID: 6003 RVA: 0x00048BB0 File Offset: 0x00046DB0
			[Register("setHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/bumptech/glide/load/model/LazyHeaders$Builder;", "")]
			public unsafe LazyHeaders.Builder SetHeader(string key, string value)
			{
				IntPtr intPtr = JNIEnv.NewString(key);
				IntPtr intPtr2 = JNIEnv.NewString(value);
				LazyHeaders.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue(intPtr2);
					@object = Java.Lang.Object.GetObject<LazyHeaders.Builder>(LazyHeaders.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setHeader.(Ljava/lang/String;Ljava/lang/String;)Lcom/bumptech/glide/load/model/LazyHeaders$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				return @object;
			}

			// Token: 0x0400059A RID: 1434
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/LazyHeaders$Builder", typeof(LazyHeaders.Builder));
		}
	}
}
