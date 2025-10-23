using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Warkiz.Widgets
{
	// Token: 0x02000006 RID: 6
	[Register("com/warkiz/widget/ColorCollector", DoNotGenerateAcw = true)]
	internal class IColorCollectorInvoker : Java.Lang.Object, IColorCollector, IJavaObject, IDisposable
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00003DC0 File Offset: 0x00001FC0
		private static IntPtr java_class_ref
		{
			get
			{
				return IColorCollectorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00003DE4 File Offset: 0x00001FE4
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IColorCollectorInvoker._members;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00003DEB File Offset: 0x00001FEB
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00003DF3 File Offset: 0x00001FF3
		protected override Type ThresholdType
		{
			get
			{
				return IColorCollectorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003DFF File Offset: 0x00001FFF
		public static IColorCollector GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IColorCollector>(handle, transfer);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003E08 File Offset: 0x00002008
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IColorCollectorInvoker.java_class_ref))
			{
				throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance(handle), "com.warkiz.widget.ColorCollector"));
			}
			return handle;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003E33 File Offset: 0x00002033
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00003E64 File Offset: 0x00002064
		public IColorCollectorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IColorCollectorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00003E9C File Offset: 0x0000209C
		private static Delegate GetCollectSectionTrackColor_arrayIHandler()
		{
			if (IColorCollectorInvoker.cb_collectSectionTrackColor_arrayI == null)
			{
				IColorCollectorInvoker.cb_collectSectionTrackColor_arrayI = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr, bool>(IColorCollectorInvoker.n_CollectSectionTrackColor_arrayI));
			}
			return IColorCollectorInvoker.cb_collectSectionTrackColor_arrayI;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00003EC0 File Offset: 0x000020C0
		private static bool n_CollectSectionTrackColor_arrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_colorIntArr)
		{
			IColorCollector @object = Java.Lang.Object.GetObject<IColorCollector>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_colorIntArr, JniHandleOwnership.DoNotTransfer, typeof(int));
			bool result = @object.CollectSectionTrackColor(array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_colorIntArr);
			}
			return result;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003EFC File Offset: 0x000020FC
		public unsafe bool CollectSectionTrackColor(int[] colorIntArr)
		{
			if (this.id_collectSectionTrackColor_arrayI == IntPtr.Zero)
			{
				this.id_collectSectionTrackColor_arrayI = JNIEnv.GetMethodID(this.class_ref, "collectSectionTrackColor", "([I)Z");
			}
			IntPtr intPtr = JNIEnv.NewArray(colorIntArr);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_collectSectionTrackColor_arrayI, ptr);
			if (colorIntArr != null)
			{
				JNIEnv.CopyArray(intPtr, colorIntArr);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x04000032 RID: 50
		internal static readonly JniPeerMembers _members = new JniPeerMembers("com/warkiz/widget/ColorCollector", typeof(IColorCollectorInvoker));

		// Token: 0x04000033 RID: 51
		private IntPtr class_ref;

		// Token: 0x04000034 RID: 52
		private static Delegate cb_collectSectionTrackColor_arrayI;

		// Token: 0x04000035 RID: 53
		private IntPtr id_collectSectionTrackColor_arrayI;
	}
}
