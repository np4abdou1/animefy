using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics
{
	// Token: 0x0200021E RID: 542
	[Register("android/graphics/ImageDecoder", DoNotGenerateAcw = true, ApiSince = 28)]
	public sealed class ImageDecoder : Java.Lang.Object, IAutoCloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x000325CB File Offset: 0x000307CB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ImageDecoder._members;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x000325D4 File Offset: 0x000307D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ImageDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x000325F8 File Offset: 0x000307F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ImageDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x000021E0 File Offset: 0x000003E0
		internal ImageDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00032604 File Offset: 0x00030804
		public void Close()
		{
			ImageDecoder._members.InstanceMethods.InvokeAbstractVoidMethod("close.()V", this, null);
		}

		// Token: 0x04000896 RID: 2198
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/ImageDecoder", typeof(ImageDecoder));

		// Token: 0x0200021F RID: 543
		[Register("android/graphics/ImageDecoder$ImageInfo", DoNotGenerateAcw = true, ApiSince = 28)]
		public class ImageInfo : Java.Lang.Object
		{
			// Token: 0x1700041F RID: 1055
			// (get) Token: 0x06001352 RID: 4946 RVA: 0x00032638 File Offset: 0x00030838
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ImageDecoder.ImageInfo._members;
				}
			}

			// Token: 0x17000420 RID: 1056
			// (get) Token: 0x06001353 RID: 4947 RVA: 0x00032640 File Offset: 0x00030840
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ImageDecoder.ImageInfo._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000421 RID: 1057
			// (get) Token: 0x06001354 RID: 4948 RVA: 0x00032664 File Offset: 0x00030864
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ImageDecoder.ImageInfo._members.ManagedPeerType;
				}
			}

			// Token: 0x06001355 RID: 4949 RVA: 0x000021E0 File Offset: 0x000003E0
			protected ImageInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000897 RID: 2199
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/ImageDecoder$ImageInfo", typeof(ImageDecoder.ImageInfo));
		}

		// Token: 0x02000220 RID: 544
		[Register("android/graphics/ImageDecoder$OnHeaderDecodedListener", "", "Android.Graphics.ImageDecoder/IOnHeaderDecodedListenerInvoker", ApiSince = 28)]
		public interface IOnHeaderDecodedListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06001357 RID: 4951
			[Register("onHeaderDecoded", "(Landroid/graphics/ImageDecoder;Landroid/graphics/ImageDecoder$ImageInfo;Landroid/graphics/ImageDecoder$Source;)V", "GetOnHeaderDecoded_Landroid_graphics_ImageDecoder_Landroid_graphics_ImageDecoder_ImageInfo_Landroid_graphics_ImageDecoder_Source_Handler:Android.Graphics.ImageDecoder/IOnHeaderDecodedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 28)]
			void OnHeaderDecoded(ImageDecoder decoder, ImageDecoder.ImageInfo info, ImageDecoder.Source source);
		}

		// Token: 0x02000221 RID: 545
		[Register("android/graphics/ImageDecoder$OnHeaderDecodedListener", DoNotGenerateAcw = true, ApiSince = 28)]
		internal class IOnHeaderDecodedListenerInvoker : Java.Lang.Object, ImageDecoder.IOnHeaderDecodedListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000422 RID: 1058
			// (get) Token: 0x06001358 RID: 4952 RVA: 0x0003268C File Offset: 0x0003088C
			private static IntPtr java_class_ref
			{
				get
				{
					return ImageDecoder.IOnHeaderDecodedListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000423 RID: 1059
			// (get) Token: 0x06001359 RID: 4953 RVA: 0x000326B0 File Offset: 0x000308B0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ImageDecoder.IOnHeaderDecodedListenerInvoker._members;
				}
			}

			// Token: 0x17000424 RID: 1060
			// (get) Token: 0x0600135A RID: 4954 RVA: 0x000326B7 File Offset: 0x000308B7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000425 RID: 1061
			// (get) Token: 0x0600135B RID: 4955 RVA: 0x000326BF File Offset: 0x000308BF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ImageDecoder.IOnHeaderDecodedListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600135C RID: 4956 RVA: 0x000326CB File Offset: 0x000308CB
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ImageDecoder.IOnHeaderDecodedListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.graphics.ImageDecoder.OnHeaderDecodedListener'.");
				}
				return handle;
			}

			// Token: 0x0600135D RID: 4957 RVA: 0x000326F6 File Offset: 0x000308F6
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600135E RID: 4958 RVA: 0x00032728 File Offset: 0x00030928
			public IOnHeaderDecodedListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ImageDecoder.IOnHeaderDecodedListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600135F RID: 4959 RVA: 0x00032760 File Offset: 0x00030960
			private static Delegate GetOnHeaderDecoded_Landroid_graphics_ImageDecoder_Landroid_graphics_ImageDecoder_ImageInfo_Landroid_graphics_ImageDecoder_Source_Handler()
			{
				if (ImageDecoder.IOnHeaderDecodedListenerInvoker.cb_onHeaderDecoded_Landroid_graphics_ImageDecoder_Landroid_graphics_ImageDecoder_ImageInfo_Landroid_graphics_ImageDecoder_Source_ == null)
				{
					ImageDecoder.IOnHeaderDecodedListenerInvoker.cb_onHeaderDecoded_Landroid_graphics_ImageDecoder_Landroid_graphics_ImageDecoder_ImageInfo_Landroid_graphics_ImageDecoder_Source_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ImageDecoder.IOnHeaderDecodedListenerInvoker.n_OnHeaderDecoded_Landroid_graphics_ImageDecoder_Landroid_graphics_ImageDecoder_ImageInfo_Landroid_graphics_ImageDecoder_Source_));
				}
				return ImageDecoder.IOnHeaderDecodedListenerInvoker.cb_onHeaderDecoded_Landroid_graphics_ImageDecoder_Landroid_graphics_ImageDecoder_ImageInfo_Landroid_graphics_ImageDecoder_Source_;
			}

			// Token: 0x06001360 RID: 4960 RVA: 0x00032784 File Offset: 0x00030984
			private static void n_OnHeaderDecoded_Landroid_graphics_ImageDecoder_Landroid_graphics_ImageDecoder_ImageInfo_Landroid_graphics_ImageDecoder_Source_(IntPtr jnienv, IntPtr native__this, IntPtr native_decoder, IntPtr native_info, IntPtr native_source)
			{
				ImageDecoder.IOnHeaderDecodedListener @object = Java.Lang.Object.GetObject<ImageDecoder.IOnHeaderDecodedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ImageDecoder object2 = Java.Lang.Object.GetObject<ImageDecoder>(native_decoder, JniHandleOwnership.DoNotTransfer);
				ImageDecoder.ImageInfo object3 = Java.Lang.Object.GetObject<ImageDecoder.ImageInfo>(native_info, JniHandleOwnership.DoNotTransfer);
				ImageDecoder.Source object4 = Java.Lang.Object.GetObject<ImageDecoder.Source>(native_source, JniHandleOwnership.DoNotTransfer);
				@object.OnHeaderDecoded(object2, object3, object4);
			}

			// Token: 0x06001361 RID: 4961 RVA: 0x000327BC File Offset: 0x000309BC
			public unsafe void OnHeaderDecoded(ImageDecoder decoder, ImageDecoder.ImageInfo info, ImageDecoder.Source source)
			{
				if (this.id_onHeaderDecoded_Landroid_graphics_ImageDecoder_Landroid_graphics_ImageDecoder_ImageInfo_Landroid_graphics_ImageDecoder_Source_ == IntPtr.Zero)
				{
					this.id_onHeaderDecoded_Landroid_graphics_ImageDecoder_Landroid_graphics_ImageDecoder_ImageInfo_Landroid_graphics_ImageDecoder_Source_ = JNIEnv.GetMethodID(this.class_ref, "onHeaderDecoded", "(Landroid/graphics/ImageDecoder;Landroid/graphics/ImageDecoder$ImageInfo;Landroid/graphics/ImageDecoder$Source;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((decoder == null) ? IntPtr.Zero : decoder.Handle);
				ptr[1] = new JValue((info == null) ? IntPtr.Zero : info.Handle);
				ptr[2] = new JValue((source == null) ? IntPtr.Zero : source.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onHeaderDecoded_Landroid_graphics_ImageDecoder_Landroid_graphics_ImageDecoder_ImageInfo_Landroid_graphics_ImageDecoder_Source_, ptr);
			}

			// Token: 0x04000898 RID: 2200
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/ImageDecoder$OnHeaderDecodedListener", typeof(ImageDecoder.IOnHeaderDecodedListenerInvoker));

			// Token: 0x04000899 RID: 2201
			private IntPtr class_ref;

			// Token: 0x0400089A RID: 2202
			private static Delegate cb_onHeaderDecoded_Landroid_graphics_ImageDecoder_Landroid_graphics_ImageDecoder_ImageInfo_Landroid_graphics_ImageDecoder_Source_;

			// Token: 0x0400089B RID: 2203
			private IntPtr id_onHeaderDecoded_Landroid_graphics_ImageDecoder_Landroid_graphics_ImageDecoder_ImageInfo_Landroid_graphics_ImageDecoder_Source_;
		}

		// Token: 0x02000222 RID: 546
		[Register("android/graphics/ImageDecoder$Source", DoNotGenerateAcw = true, ApiSince = 28)]
		public abstract class Source : Java.Lang.Object
		{
			// Token: 0x17000426 RID: 1062
			// (get) Token: 0x06001363 RID: 4963 RVA: 0x00032891 File Offset: 0x00030A91
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ImageDecoder.Source._members;
				}
			}

			// Token: 0x17000427 RID: 1063
			// (get) Token: 0x06001364 RID: 4964 RVA: 0x00032898 File Offset: 0x00030A98
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ImageDecoder.Source._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000428 RID: 1064
			// (get) Token: 0x06001365 RID: 4965 RVA: 0x000328BC File Offset: 0x00030ABC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ImageDecoder.Source._members.ManagedPeerType;
				}
			}

			// Token: 0x06001366 RID: 4966 RVA: 0x000021E0 File Offset: 0x000003E0
			protected Source(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0400089C RID: 2204
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/ImageDecoder$Source", typeof(ImageDecoder.Source));
		}

		// Token: 0x02000223 RID: 547
		[Register("android/graphics/ImageDecoder$Source", DoNotGenerateAcw = true, ApiSince = 28)]
		internal class SourceInvoker : ImageDecoder.Source
		{
			// Token: 0x06001368 RID: 4968 RVA: 0x000328E3 File Offset: 0x00030AE3
			public SourceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x17000429 RID: 1065
			// (get) Token: 0x06001369 RID: 4969 RVA: 0x000328ED File Offset: 0x00030AED
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ImageDecoder.SourceInvoker._members;
				}
			}

			// Token: 0x1700042A RID: 1066
			// (get) Token: 0x0600136A RID: 4970 RVA: 0x000328F4 File Offset: 0x00030AF4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ImageDecoder.SourceInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0400089D RID: 2205
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/ImageDecoder$Source", typeof(ImageDecoder.SourceInvoker));
		}
	}
}
