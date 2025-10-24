using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x0200019E RID: 414
	[Register("android/text/GetChars", DoNotGenerateAcw = true)]
	internal class IGetCharsInvoker : Java.Lang.Object, IGetChars, ICharSequence, IJavaObject, IDisposable, IJavaPeerable, IEnumerable<char>, IEnumerable
	{
		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x00025C50 File Offset: 0x00023E50
		private static IntPtr java_class_ref
		{
			get
			{
				return IGetCharsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x00025C74 File Offset: 0x00023E74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IGetCharsInvoker._members;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x00025C7B File Offset: 0x00023E7B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x00025C83 File Offset: 0x00023E83
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IGetCharsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00025C8F File Offset: 0x00023E8F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IGetCharsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.text.GetChars'.");
			}
			return handle;
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00025CBA File Offset: 0x00023EBA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00025CEC File Offset: 0x00023EEC
		public IGetCharsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IGetCharsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00025D24 File Offset: 0x00023F24
		private static Delegate GetGetChars_IIarrayCIHandler()
		{
			if (IGetCharsInvoker.cb_getChars_IIarrayCI == null)
			{
				IGetCharsInvoker.cb_getChars_IIarrayCI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIILI_V(IGetCharsInvoker.n_GetChars_IIarrayCI));
			}
			return IGetCharsInvoker.cb_getChars_IIarrayCI;
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00025D48 File Offset: 0x00023F48
		private static void n_GetChars_IIarrayCI(IntPtr jnienv, IntPtr native__this, int start, int end, IntPtr native_dest, int destoff)
		{
			IGetChars @object = Java.Lang.Object.GetObject<IGetChars>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			char[] array = (char[])JNIEnv.GetArray(native_dest, JniHandleOwnership.DoNotTransfer, typeof(char));
			@object.GetChars(start, end, array, destoff);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_dest);
			}
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00025D8C File Offset: 0x00023F8C
		public unsafe void GetChars(int start, int end, char[] dest, int destoff)
		{
			if (this.id_getChars_IIarrayCI == IntPtr.Zero)
			{
				this.id_getChars_IIarrayCI = JNIEnv.GetMethodID(this.class_ref, "getChars", "(II[CI)V");
			}
			IntPtr intPtr = JNIEnv.NewArray(dest);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(start);
			ptr[1] = new JValue(end);
			ptr[2] = new JValue(intPtr);
			ptr[3] = new JValue(destoff);
			JNIEnv.CallVoidMethod(base.Handle, this.id_getChars_IIarrayCI, ptr);
			if (dest != null)
			{
				JNIEnv.CopyArray(intPtr, dest);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00025E48 File Offset: 0x00024048
		public unsafe char CharAt(int index)
		{
			if (this.id_charAt_I == IntPtr.Zero)
			{
				this.id_charAt_I = JNIEnv.GetMethodID(this.class_ref, "charAt", "(I)C");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(index);
			return JNIEnv.CallCharMethod(base.Handle, this.id_charAt_I, ptr);
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00025EAC File Offset: 0x000240AC
		public int Length()
		{
			if (this.id_length == IntPtr.Zero)
			{
				this.id_length = JNIEnv.GetMethodID(this.class_ref, "length", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_length);
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00025EEC File Offset: 0x000240EC
		public unsafe ICharSequence SubSequenceFormatted(int start, int end)
		{
			if (this.id_subSequence_II == IntPtr.Zero)
			{
				this.id_subSequence_II = JNIEnv.GetMethodID(this.class_ref, "subSequence", "(II)Ljava/lang/CharSequence;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(start);
			ptr[1] = new JValue(end);
			return Java.Lang.Object.GetObject<ICharSequence>(JNIEnv.CallObjectMethod(base.Handle, this.id_subSequence_II, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00025F6C File Offset: 0x0002416C
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00025FBD File Offset: 0x000241BD
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00025FC5 File Offset: 0x000241C5
		public IEnumerator<char> GetEnumerator()
		{
			int num;
			for (int i = 0; i < this.Length(); i = num + 1)
			{
				yield return this.CharAt(i);
				num = i;
			}
			yield break;
		}

		// Token: 0x040006D3 RID: 1747
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/GetChars", typeof(IGetCharsInvoker));

		// Token: 0x040006D4 RID: 1748
		private IntPtr class_ref;

		// Token: 0x040006D5 RID: 1749
		private static Delegate cb_getChars_IIarrayCI;

		// Token: 0x040006D6 RID: 1750
		private IntPtr id_getChars_IIarrayCI;

		// Token: 0x040006D7 RID: 1751
		private IntPtr id_charAt_I;

		// Token: 0x040006D8 RID: 1752
		private IntPtr id_length;

		// Token: 0x040006D9 RID: 1753
		private IntPtr id_subSequence_II;

		// Token: 0x040006DA RID: 1754
		private IntPtr id_toString;
	}
}
