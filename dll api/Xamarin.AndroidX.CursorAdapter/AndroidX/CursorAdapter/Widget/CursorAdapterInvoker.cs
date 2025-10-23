using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Database;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.CursorAdapter.Widget
{
	// Token: 0x02000011 RID: 17
	[Register("androidx/cursoradapter/widget/CursorAdapter", DoNotGenerateAcw = true)]
	internal class CursorAdapterInvoker : CursorAdapter
	{
		// Token: 0x0600007C RID: 124 RVA: 0x000030EB File Offset: 0x000012EB
		public CursorAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000030F5 File Offset: 0x000012F5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CursorAdapterInvoker._members;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000030FC File Offset: 0x000012FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CursorAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003108 File Offset: 0x00001308
		[Register("bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V", "GetBindView_Landroid_view_View_Landroid_content_Context_Landroid_database_Cursor_Handler")]
		public unsafe override void BindView(View view, Context context, ICursor cursor)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[2] = new JniArgumentValue((cursor == null) ? IntPtr.Zero : ((Java.Lang.Object)cursor).Handle);
				CursorAdapterInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("bindView.(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
				GC.KeepAlive(context);
				GC.KeepAlive(cursor);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000031C4 File Offset: 0x000013C4
		[Register("newView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;", "GetNewView_Landroid_content_Context_Landroid_database_Cursor_Landroid_view_ViewGroup_Handler")]
		public unsafe override View NewView(Context context, ICursor cursor, ViewGroup parent)
		{
			View @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((cursor == null) ? IntPtr.Zero : ((Java.Lang.Object)cursor).Handle);
				ptr[2] = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				@object = Java.Lang.Object.GetObject<View>(CursorAdapterInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("newView.(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(cursor);
				GC.KeepAlive(parent);
			}
			return @object;
		}

		// Token: 0x04000015 RID: 21
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/cursoradapter/widget/CursorAdapter", typeof(CursorAdapterInvoker));
	}
}
