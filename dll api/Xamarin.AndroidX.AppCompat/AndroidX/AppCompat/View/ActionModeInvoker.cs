using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.View
{
	// Token: 0x0200008B RID: 139
	[Register("androidx/appcompat/view/ActionMode", DoNotGenerateAcw = true)]
	internal class ActionModeInvoker : ActionMode
	{
		// Token: 0x060009C6 RID: 2502 RVA: 0x00019425 File Offset: 0x00017625
		public ActionModeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x0001942F File Offset: 0x0001762F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActionModeInvoker._members;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x00019436 File Offset: 0x00017636
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActionModeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x00019444 File Offset: 0x00017644
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x00019478 File Offset: 0x00017678
		public unsafe override View CustomView
		{
			[Register("getCustomView", "()Landroid/view/View;", "GetGetCustomViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<View>(ActionModeInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getCustomView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setCustomView", "(Landroid/view/View;)V", "GetSetCustomView_Landroid_view_View_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					ActionModeInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setCustomView.(Landroid/view/View;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x000194DC File Offset: 0x000176DC
		public override IMenu Menu
		{
			[Register("getMenu", "()Landroid/view/Menu;", "GetGetMenuHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IMenu>(ActionModeInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getMenu.()Landroid/view/Menu;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x00019510 File Offset: 0x00017710
		public override MenuInflater MenuInflater
		{
			[Register("getMenuInflater", "()Landroid/view/MenuInflater;", "GetGetMenuInflaterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<MenuInflater>(ActionModeInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getMenuInflater.()Landroid/view/MenuInflater;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x00019544 File Offset: 0x00017744
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x00019578 File Offset: 0x00017778
		public unsafe override ICharSequence SubtitleFormatted
		{
			[Register("getSubtitle", "()Ljava/lang/CharSequence;", "GetGetSubtitleHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(ActionModeInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getSubtitle.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setSubtitle", "(Ljava/lang/CharSequence;)V", "GetSetSubtitle_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ActionModeInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setSubtitle.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x000195DC File Offset: 0x000177DC
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x00019610 File Offset: 0x00017810
		public unsafe override ICharSequence TitleFormatted
		{
			[Register("getTitle", "()Ljava/lang/CharSequence;", "GetGetTitleHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(ActionModeInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getTitle.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ActionModeInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setTitle.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00019674 File Offset: 0x00017874
		[Register("finish", "()V", "GetFinishHandler")]
		public override void Finish()
		{
			ActionModeInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("finish.()V", this, null);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0001968D File Offset: 0x0001788D
		[Register("invalidate", "()V", "GetInvalidateHandler")]
		public override void Invalidate()
		{
			ActionModeInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("invalidate.()V", this, null);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000196A8 File Offset: 0x000178A8
		[Register("setSubtitle", "(I)V", "GetSetSubtitle_IHandler")]
		public unsafe override void SetSubtitle(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			ActionModeInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setSubtitle.(I)V", this, ptr);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x000196E4 File Offset: 0x000178E4
		[Register("setTitle", "(I)V", "GetSetTitle_IHandler")]
		public unsafe override void SetTitle(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			ActionModeInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setTitle.(I)V", this, ptr);
		}

		// Token: 0x040002E4 RID: 740
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/view/ActionMode", typeof(ActionModeInvoker));
	}
}
