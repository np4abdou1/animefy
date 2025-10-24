using System;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x02000101 RID: 257
	[Register("android/widget/AdapterView", DoNotGenerateAcw = true)]
	public abstract class AdapterView<T> : AdapterView where T : IAdapter
	{
		// Token: 0x0600063A RID: 1594 RVA: 0x00004B6A File Offset: 0x00002D6A
		public AdapterView(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0000DE4C File Offset: 0x0000C04C
		public AdapterView(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() == typeof(AdapterView<T>))
			{
				if (AdapterView<T>.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				{
					AdapterView<T>.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID(AdapterView.class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				}
				base.SetHandle(JNIEnv.StartCreateInstance(AdapterView.class_ref, AdapterView<T>.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue[]
				{
					new JValue(context),
					new JValue(attrs)
				}), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, AdapterView.class_ref, AdapterView<T>.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue[]
				{
					new JValue(context),
					new JValue(attrs)
				});
				return;
			}
			base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue[]
			{
				new JValue(context),
				new JValue(attrs)
			}), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue[]
			{
				new JValue(context),
				new JValue(attrs)
			});
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0000DF90 File Offset: 0x0000C190
		public AdapterView(Context context, IAttributeSet attrs, int defStyle) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() == typeof(AdapterView<T>))
			{
				if (AdapterView<T>.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
				{
					AdapterView<T>.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID(AdapterView.class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				}
				base.SetHandle(JNIEnv.StartCreateInstance(AdapterView.class_ref, AdapterView<T>.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue[]
				{
					new JValue(context),
					new JValue(attrs),
					new JValue(defStyle)
				}), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, AdapterView.class_ref, AdapterView<T>.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue[]
				{
					new JValue(context),
					new JValue(attrs),
					new JValue(defStyle)
				});
				return;
			}
			base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue[]
			{
				new JValue(context),
				new JValue(attrs),
				new JValue(defStyle)
			}), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue[]
			{
				new JValue(context),
				new JValue(attrs),
				new JValue(defStyle)
			});
		}

		// Token: 0x17000121 RID: 289
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x0000E107 File Offset: 0x0000C307
		protected override Java.Lang.Object RawAdapter
		{
			set
			{
				this.Adapter = JavaConvert.FromJavaObject<T>(value);
			}
		}

		// Token: 0x17000122 RID: 290
		// (set) Token: 0x0600063E RID: 1598
		public abstract T Adapter { set; }

		// Token: 0x0400018D RID: 397
		private static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;

		// Token: 0x0400018E RID: 398
		private static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
	}
}
