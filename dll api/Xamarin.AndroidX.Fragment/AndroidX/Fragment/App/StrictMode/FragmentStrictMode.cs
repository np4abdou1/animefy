using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Fragment.App.StrictMode
{
	// Token: 0x02000050 RID: 80
	[Register("androidx/fragment/app/strictmode/FragmentStrictMode", DoNotGenerateAcw = true)]
	public sealed class FragmentStrictMode : Java.Lang.Object
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0000E020 File Offset: 0x0000C220
		[Register("INSTANCE")]
		public static FragmentStrictMode Instance
		{
			get
			{
				return Java.Lang.Object.GetObject<FragmentStrictMode>(FragmentStrictMode._members.StaticFields.GetObjectValue("INSTANCE.Landroidx/fragment/app/strictmode/FragmentStrictMode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0000E050 File Offset: 0x0000C250
		internal static IntPtr class_ref
		{
			get
			{
				return FragmentStrictMode._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0000E074 File Offset: 0x0000C274
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FragmentStrictMode._members;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0000E07C File Offset: 0x0000C27C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FragmentStrictMode._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FragmentStrictMode._members.ManagedPeerType;
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00003624 File Offset: 0x00001824
		internal FragmentStrictMode(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x0000E0AC File Offset: 0x0000C2AC
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x0000E0E0 File Offset: 0x0000C2E0
		public unsafe FragmentStrictMode.Policy DefaultPolicy
		{
			[Register("getDefaultPolicy", "()Landroidx/fragment/app/strictmode/FragmentStrictMode$Policy;", "")]
			get
			{
				return Java.Lang.Object.GetObject<FragmentStrictMode.Policy>(FragmentStrictMode._members.InstanceMethods.InvokeNonvirtualObjectMethod("getDefaultPolicy.()Landroidx/fragment/app/strictmode/FragmentStrictMode$Policy;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setDefaultPolicy", "(Landroidx/fragment/app/strictmode/FragmentStrictMode$Policy;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					FragmentStrictMode._members.InstanceMethods.InvokeNonvirtualVoidMethod("setDefaultPolicy.(Landroidx/fragment/app/strictmode/FragmentStrictMode$Policy;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000E144 File Offset: 0x0000C344
		[Register("onFragmentReuse", "(Landroidx/fragment/app/Fragment;Ljava/lang/String;)V", "")]
		public unsafe static void OnFragmentReuse(Fragment fragment, string previousFragmentId)
		{
			IntPtr intPtr = JNIEnv.NewString(previousFragmentId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				FragmentStrictMode._members.StaticMethods.InvokeVoidMethod("onFragmentReuse.(Landroidx/fragment/app/Fragment;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(fragment);
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000E1C8 File Offset: 0x0000C3C8
		[Register("onFragmentTagUsage", "(Landroidx/fragment/app/Fragment;Landroid/view/ViewGroup;)V", "")]
		public unsafe static void OnFragmentTagUsage(Fragment fragment, ViewGroup container)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				ptr[1] = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				FragmentStrictMode._members.StaticMethods.InvokeVoidMethod("onFragmentTagUsage.(Landroidx/fragment/app/Fragment;Landroid/view/ViewGroup;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
				GC.KeepAlive(container);
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000E254 File Offset: 0x0000C454
		[Register("onGetRetainInstanceUsage", "(Landroidx/fragment/app/Fragment;)V", "")]
		public unsafe static void OnGetRetainInstanceUsage(Fragment fragment)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				FragmentStrictMode._members.StaticMethods.InvokeVoidMethod("onGetRetainInstanceUsage.(Landroidx/fragment/app/Fragment;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0000E2B8 File Offset: 0x0000C4B8
		[Register("onGetTargetFragmentRequestCodeUsage", "(Landroidx/fragment/app/Fragment;)V", "")]
		public unsafe static void OnGetTargetFragmentRequestCodeUsage(Fragment fragment)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				FragmentStrictMode._members.StaticMethods.InvokeVoidMethod("onGetTargetFragmentRequestCodeUsage.(Landroidx/fragment/app/Fragment;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0000E31C File Offset: 0x0000C51C
		[Register("onGetTargetFragmentUsage", "(Landroidx/fragment/app/Fragment;)V", "")]
		public unsafe static void OnGetTargetFragmentUsage(Fragment fragment)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				FragmentStrictMode._members.StaticMethods.InvokeVoidMethod("onGetTargetFragmentUsage.(Landroidx/fragment/app/Fragment;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000E380 File Offset: 0x0000C580
		[Register("onPolicyViolation", "(Landroidx/fragment/app/strictmode/Violation;)V", "")]
		public unsafe void OnPolicyViolation(Violation violation)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((violation == null) ? IntPtr.Zero : violation.Handle);
				FragmentStrictMode._members.InstanceMethods.InvokeNonvirtualVoidMethod("onPolicyViolation.(Landroidx/fragment/app/strictmode/Violation;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(violation);
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000E3E4 File Offset: 0x0000C5E4
		[Register("onSetRetainInstanceUsage", "(Landroidx/fragment/app/Fragment;)V", "")]
		public unsafe static void OnSetRetainInstanceUsage(Fragment fragment)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				FragmentStrictMode._members.StaticMethods.InvokeVoidMethod("onSetRetainInstanceUsage.(Landroidx/fragment/app/Fragment;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000E448 File Offset: 0x0000C648
		[Register("onSetTargetFragmentUsage", "(Landroidx/fragment/app/Fragment;Landroidx/fragment/app/Fragment;I)V", "")]
		public unsafe static void OnSetTargetFragmentUsage(Fragment violatingFragment, Fragment targetFragment, int requestCode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((violatingFragment == null) ? IntPtr.Zero : violatingFragment.Handle);
				ptr[1] = new JniArgumentValue((targetFragment == null) ? IntPtr.Zero : targetFragment.Handle);
				ptr[2] = new JniArgumentValue(requestCode);
				FragmentStrictMode._members.StaticMethods.InvokeVoidMethod("onSetTargetFragmentUsage.(Landroidx/fragment/app/Fragment;Landroidx/fragment/app/Fragment;I)V", ptr);
			}
			finally
			{
				GC.KeepAlive(violatingFragment);
				GC.KeepAlive(targetFragment);
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0000E4E8 File Offset: 0x0000C6E8
		[Register("onSetUserVisibleHint", "(Landroidx/fragment/app/Fragment;Z)V", "")]
		public unsafe static void OnSetUserVisibleHint(Fragment fragment, bool isVisibleToUser)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				ptr[1] = new JniArgumentValue(isVisibleToUser);
				FragmentStrictMode._members.StaticMethods.InvokeVoidMethod("onSetUserVisibleHint.(Landroidx/fragment/app/Fragment;Z)V", ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000E560 File Offset: 0x0000C760
		[Register("onWrongFragmentContainer", "(Landroidx/fragment/app/Fragment;Landroid/view/ViewGroup;)V", "")]
		public unsafe static void OnWrongFragmentContainer(Fragment fragment, ViewGroup container)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				ptr[1] = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				FragmentStrictMode._members.StaticMethods.InvokeVoidMethod("onWrongFragmentContainer.(Landroidx/fragment/app/Fragment;Landroid/view/ViewGroup;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
				GC.KeepAlive(container);
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0000E5EC File Offset: 0x0000C7EC
		[Register("onWrongNestedHierarchy", "(Landroidx/fragment/app/Fragment;Landroidx/fragment/app/Fragment;I)V", "")]
		public unsafe static void OnWrongNestedHierarchy(Fragment fragment, Fragment expectedParentFragment, int containerId)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				ptr[1] = new JniArgumentValue((expectedParentFragment == null) ? IntPtr.Zero : expectedParentFragment.Handle);
				ptr[2] = new JniArgumentValue(containerId);
				FragmentStrictMode._members.StaticMethods.InvokeVoidMethod("onWrongNestedHierarchy.(Landroidx/fragment/app/Fragment;Landroidx/fragment/app/Fragment;I)V", ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
				GC.KeepAlive(expectedParentFragment);
			}
		}

		// Token: 0x0400012D RID: 301
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/strictmode/FragmentStrictMode", typeof(FragmentStrictMode));

		// Token: 0x02000051 RID: 81
		[Register("androidx/fragment/app/strictmode/FragmentStrictMode$Policy", DoNotGenerateAcw = true)]
		public sealed class Policy : Java.Lang.Object
		{
			// Token: 0x1700009F RID: 159
			// (get) Token: 0x06000469 RID: 1129 RVA: 0x0000E6A8 File Offset: 0x0000C8A8
			[Register("LAX")]
			public static FragmentStrictMode.Policy Lax
			{
				get
				{
					return Java.Lang.Object.GetObject<FragmentStrictMode.Policy>(FragmentStrictMode.Policy._members.StaticFields.GetObjectValue("LAX.Landroidx/fragment/app/strictmode/FragmentStrictMode$Policy;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x0600046A RID: 1130 RVA: 0x0000E6D8 File Offset: 0x0000C8D8
			internal static IntPtr class_ref
			{
				get
				{
					return FragmentStrictMode.Policy._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x0600046B RID: 1131 RVA: 0x0000E6FC File Offset: 0x0000C8FC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return FragmentStrictMode.Policy._members;
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x0600046C RID: 1132 RVA: 0x0000E704 File Offset: 0x0000C904
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return FragmentStrictMode.Policy._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x0600046D RID: 1133 RVA: 0x0000E728 File Offset: 0x0000C928
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return FragmentStrictMode.Policy._members.ManagedPeerType;
				}
			}

			// Token: 0x0600046E RID: 1134 RVA: 0x00003624 File Offset: 0x00001824
			internal Policy(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0400012E RID: 302
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/strictmode/FragmentStrictMode$Policy", typeof(FragmentStrictMode.Policy));
		}
	}
}
