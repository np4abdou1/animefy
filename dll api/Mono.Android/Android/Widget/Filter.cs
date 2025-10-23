using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000C2 RID: 194
	[Register("android/widget/Filter", DoNotGenerateAcw = true)]
	public abstract class Filter : Java.Lang.Object
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00006936 File Offset: 0x00004B36
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Filter._members;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00006940 File Offset: 0x00004B40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Filter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00006964 File Offset: 0x00004B64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Filter._members.ManagedPeerType;
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Filter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040000A0 RID: 160
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/Filter", typeof(Filter));

		// Token: 0x020000C3 RID: 195
		[Register("android/widget/Filter$FilterListener", "", "Android.Widget.Filter/IFilterListenerInvoker")]
		public interface IFilterListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060003C7 RID: 967
			[Register("onFilterComplete", "(I)V", "GetOnFilterComplete_IHandler:Android.Widget.Filter/IFilterListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnFilterComplete(int count);
		}

		// Token: 0x020000C4 RID: 196
		[Register("android/widget/Filter$FilterListener", DoNotGenerateAcw = true)]
		internal class IFilterListenerInvoker : Java.Lang.Object, Filter.IFilterListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000070 RID: 112
			// (get) Token: 0x060003C8 RID: 968 RVA: 0x0000698C File Offset: 0x00004B8C
			private static IntPtr java_class_ref
			{
				get
				{
					return Filter.IFilterListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x060003C9 RID: 969 RVA: 0x000069B0 File Offset: 0x00004BB0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Filter.IFilterListenerInvoker._members;
				}
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x060003CA RID: 970 RVA: 0x000069B7 File Offset: 0x00004BB7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x060003CB RID: 971 RVA: 0x000069BF File Offset: 0x00004BBF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Filter.IFilterListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060003CC RID: 972 RVA: 0x000069CB File Offset: 0x00004BCB
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Filter.IFilterListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.widget.Filter.FilterListener'.");
				}
				return handle;
			}

			// Token: 0x060003CD RID: 973 RVA: 0x000069F6 File Offset: 0x00004BF6
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060003CE RID: 974 RVA: 0x00006A28 File Offset: 0x00004C28
			public IFilterListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Filter.IFilterListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060003CF RID: 975 RVA: 0x00006A60 File Offset: 0x00004C60
			private static Delegate GetOnFilterComplete_IHandler()
			{
				if (Filter.IFilterListenerInvoker.cb_onFilterComplete_I == null)
				{
					Filter.IFilterListenerInvoker.cb_onFilterComplete_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Filter.IFilterListenerInvoker.n_OnFilterComplete_I));
				}
				return Filter.IFilterListenerInvoker.cb_onFilterComplete_I;
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x00006A84 File Offset: 0x00004C84
			private static void n_OnFilterComplete_I(IntPtr jnienv, IntPtr native__this, int count)
			{
				Java.Lang.Object.GetObject<Filter.IFilterListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnFilterComplete(count);
			}

			// Token: 0x060003D1 RID: 977 RVA: 0x00006A94 File Offset: 0x00004C94
			public unsafe void OnFilterComplete(int count)
			{
				if (this.id_onFilterComplete_I == IntPtr.Zero)
				{
					this.id_onFilterComplete_I = JNIEnv.GetMethodID(this.class_ref, "onFilterComplete", "(I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(count);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onFilterComplete_I, ptr);
			}

			// Token: 0x040000A1 RID: 161
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/Filter$FilterListener", typeof(Filter.IFilterListenerInvoker));

			// Token: 0x040000A2 RID: 162
			private IntPtr class_ref;

			// Token: 0x040000A3 RID: 163
			private static Delegate cb_onFilterComplete_I;

			// Token: 0x040000A4 RID: 164
			private IntPtr id_onFilterComplete_I;
		}
	}
}
