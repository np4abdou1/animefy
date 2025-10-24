using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x0200010B RID: 267
	[Register("com/bumptech/glide/load/resource/bitmap/DownsampleStrategy", DoNotGenerateAcw = true)]
	public abstract class DownsampleStrategy : Java.Lang.Object
	{
		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x0002A7FC File Offset: 0x000289FC
		[Register("AT_LEAST")]
		public static DownsampleStrategy AtLeast
		{
			get
			{
				return Java.Lang.Object.GetObject<DownsampleStrategy>(DownsampleStrategy._members.StaticFields.GetObjectValue("AT_LEAST.Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x0002A82C File Offset: 0x00028A2C
		[Register("AT_MOST")]
		public static DownsampleStrategy AtMost
		{
			get
			{
				return Java.Lang.Object.GetObject<DownsampleStrategy>(DownsampleStrategy._members.StaticFields.GetObjectValue("AT_MOST.Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x0002A85C File Offset: 0x00028A5C
		[Register("CENTER_INSIDE")]
		public static DownsampleStrategy CenterInside
		{
			get
			{
				return Java.Lang.Object.GetObject<DownsampleStrategy>(DownsampleStrategy._members.StaticFields.GetObjectValue("CENTER_INSIDE.Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x0002A88C File Offset: 0x00028A8C
		[Register("CENTER_OUTSIDE")]
		public static DownsampleStrategy CenterOutside
		{
			get
			{
				return Java.Lang.Object.GetObject<DownsampleStrategy>(DownsampleStrategy._members.StaticFields.GetObjectValue("CENTER_OUTSIDE.Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x0002A8BC File Offset: 0x00028ABC
		[Register("DEFAULT")]
		public static DownsampleStrategy Default
		{
			get
			{
				return Java.Lang.Object.GetObject<DownsampleStrategy>(DownsampleStrategy._members.StaticFields.GetObjectValue("DEFAULT.Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x0002A8EC File Offset: 0x00028AEC
		[Register("FIT_CENTER")]
		public static DownsampleStrategy FitCenter
		{
			get
			{
				return Java.Lang.Object.GetObject<DownsampleStrategy>(DownsampleStrategy._members.StaticFields.GetObjectValue("FIT_CENTER.Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x0002A91C File Offset: 0x00028B1C
		[Register("NONE")]
		public static DownsampleStrategy None
		{
			get
			{
				return Java.Lang.Object.GetObject<DownsampleStrategy>(DownsampleStrategy._members.StaticFields.GetObjectValue("NONE.Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x0002A94C File Offset: 0x00028B4C
		[Register("OPTION")]
		public static Option Option
		{
			get
			{
				return Java.Lang.Object.GetObject<Option>(DownsampleStrategy._members.StaticFields.GetObjectValue("OPTION.Lcom/bumptech/glide/load/Option;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x0002A97C File Offset: 0x00028B7C
		internal static IntPtr class_ref
		{
			get
			{
				return DownsampleStrategy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x0002A9A0 File Offset: 0x00028BA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DownsampleStrategy._members;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x0002A9A8 File Offset: 0x00028BA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DownsampleStrategy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x0002A9CC File Offset: 0x00028BCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DownsampleStrategy._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x0002A9D8 File Offset: 0x00028BD8
		protected DownsampleStrategy(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0002A9E4 File Offset: 0x00028BE4
		[Register(".ctor", "()V", "")]
		public DownsampleStrategy() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(DownsampleStrategy._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			DownsampleStrategy._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0002AA52 File Offset: 0x00028C52
		private static Delegate GetGetSampleSizeRounding_IIIIHandler()
		{
			if (DownsampleStrategy.cb_getSampleSizeRounding_IIII == null)
			{
				DownsampleStrategy.cb_getSampleSizeRounding_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIII_L(DownsampleStrategy.n_GetSampleSizeRounding_IIII));
			}
			return DownsampleStrategy.cb_getSampleSizeRounding_IIII;
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x0002AA76 File Offset: 0x00028C76
		private static IntPtr n_GetSampleSizeRounding_IIII(IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<DownsampleStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetSampleSizeRounding(p0, p1, p2, p3));
		}

		// Token: 0x06000D78 RID: 3448
		[Register("getSampleSizeRounding", "(IIII)Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy$SampleSizeRounding;", "GetGetSampleSizeRounding_IIIIHandler")]
		public abstract DownsampleStrategy.SampleSizeRounding GetSampleSizeRounding(int p0, int p1, int p2, int p3);

		// Token: 0x06000D79 RID: 3449 RVA: 0x0002AA90 File Offset: 0x00028C90
		private static Delegate GetGetScaleFactor_IIIIHandler()
		{
			if (DownsampleStrategy.cb_getScaleFactor_IIII == null)
			{
				DownsampleStrategy.cb_getScaleFactor_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIII_F(DownsampleStrategy.n_GetScaleFactor_IIII));
			}
			return DownsampleStrategy.cb_getScaleFactor_IIII;
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0002AAB4 File Offset: 0x00028CB4
		private static float n_GetScaleFactor_IIII(IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			return Java.Lang.Object.GetObject<DownsampleStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetScaleFactor(p0, p1, p2, p3);
		}

		// Token: 0x06000D7B RID: 3451
		[Register("getScaleFactor", "(IIII)F", "GetGetScaleFactor_IIIIHandler")]
		public abstract float GetScaleFactor(int p0, int p1, int p2, int p3);

		// Token: 0x0400032B RID: 811
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/DownsampleStrategy", typeof(DownsampleStrategy));

		// Token: 0x0400032C RID: 812
		private static Delegate cb_getSampleSizeRounding_IIII;

		// Token: 0x0400032D RID: 813
		private static Delegate cb_getScaleFactor_IIII;

		// Token: 0x020001CB RID: 459
		[Register("com/bumptech/glide/load/resource/bitmap/DownsampleStrategy$SampleSizeRounding", DoNotGenerateAcw = true)]
		public sealed class SampleSizeRounding : Java.Lang.Enum
		{
			// Token: 0x170005F1 RID: 1521
			// (get) Token: 0x06001601 RID: 5633 RVA: 0x00044FB8 File Offset: 0x000431B8
			[Register("MEMORY")]
			public static DownsampleStrategy.SampleSizeRounding Memory
			{
				get
				{
					return Java.Lang.Object.GetObject<DownsampleStrategy.SampleSizeRounding>(DownsampleStrategy.SampleSizeRounding._members.StaticFields.GetObjectValue("MEMORY.Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy$SampleSizeRounding;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170005F2 RID: 1522
			// (get) Token: 0x06001602 RID: 5634 RVA: 0x00044FE8 File Offset: 0x000431E8
			[Register("QUALITY")]
			public static DownsampleStrategy.SampleSizeRounding Quality
			{
				get
				{
					return Java.Lang.Object.GetObject<DownsampleStrategy.SampleSizeRounding>(DownsampleStrategy.SampleSizeRounding._members.StaticFields.GetObjectValue("QUALITY.Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy$SampleSizeRounding;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170005F3 RID: 1523
			// (get) Token: 0x06001603 RID: 5635 RVA: 0x00045018 File Offset: 0x00043218
			internal static IntPtr class_ref
			{
				get
				{
					return DownsampleStrategy.SampleSizeRounding._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005F4 RID: 1524
			// (get) Token: 0x06001604 RID: 5636 RVA: 0x0004503C File Offset: 0x0004323C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return DownsampleStrategy.SampleSizeRounding._members;
				}
			}

			// Token: 0x170005F5 RID: 1525
			// (get) Token: 0x06001605 RID: 5637 RVA: 0x00045044 File Offset: 0x00043244
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return DownsampleStrategy.SampleSizeRounding._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005F6 RID: 1526
			// (get) Token: 0x06001606 RID: 5638 RVA: 0x00045068 File Offset: 0x00043268
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return DownsampleStrategy.SampleSizeRounding._members.ManagedPeerType;
				}
			}

			// Token: 0x06001607 RID: 5639 RVA: 0x00045074 File Offset: 0x00043274
			internal SampleSizeRounding(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001608 RID: 5640 RVA: 0x00045080 File Offset: 0x00043280
			[Register("valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy$SampleSizeRounding;", "")]
			public unsafe static DownsampleStrategy.SampleSizeRounding ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				DownsampleStrategy.SampleSizeRounding @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<DownsampleStrategy.SampleSizeRounding>(DownsampleStrategy.SampleSizeRounding._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy$SampleSizeRounding;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06001609 RID: 5641 RVA: 0x000450EC File Offset: 0x000432EC
			[Register("values", "()[Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy$SampleSizeRounding;", "")]
			public static DownsampleStrategy.SampleSizeRounding[] Values()
			{
				return (DownsampleStrategy.SampleSizeRounding[])JNIEnv.GetArray(DownsampleStrategy.SampleSizeRounding._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy$SampleSizeRounding;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(DownsampleStrategy.SampleSizeRounding));
			}

			// Token: 0x04000547 RID: 1351
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/DownsampleStrategy$SampleSizeRounding", typeof(DownsampleStrategy.SampleSizeRounding));
		}
	}
}
