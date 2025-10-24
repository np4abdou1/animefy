using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.ViewPager.Widget
{
	// Token: 0x0200001F RID: 31
	[Register("androidx/viewpager/widget/PagerAdapter", DoNotGenerateAcw = true)]
	internal class PagerAdapterInvoker : PagerAdapter
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00002EE3 File Offset: 0x000010E3
		public PagerAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00002EED File Offset: 0x000010ED
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PagerAdapterInvoker._members;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00002EF4 File Offset: 0x000010F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PagerAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00002F00 File Offset: 0x00001100
		public override int Count
		{
			[Register("getCount", "()I", "GetGetCountHandler")]
			get
			{
				return PagerAdapterInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getCount.()I", this, null);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002F1C File Offset: 0x0000111C
		[Register("isViewFromObject", "(Landroid/view/View;Ljava/lang/Object;)Z", "GetIsViewFromObject_Landroid_view_View_Ljava_lang_Object_Handler")]
		public unsafe override bool IsViewFromObject(View view, Java.Lang.Object @object)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue((@object == null) ? IntPtr.Zero : @object.Handle);
				result = PagerAdapterInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isViewFromObject.(Landroid/view/View;Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
				GC.KeepAlive(@object);
			}
			return result;
		}

		// Token: 0x04000018 RID: 24
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/viewpager/widget/PagerAdapter", typeof(PagerAdapterInvoker));
	}
}
