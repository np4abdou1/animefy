using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001A6 RID: 422
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/Intrinsics", DoNotGenerateAcw = true)]
	public class Intrinsics : Java.Lang.Object
	{
		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x00042B6C File Offset: 0x00040D6C
		internal static IntPtr class_ref
		{
			get
			{
				return Intrinsics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x00042B90 File Offset: 0x00040D90
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return Intrinsics._members;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x00042B98 File Offset: 0x00040D98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Intrinsics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x00042BBC File Offset: 0x00040DBC
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return Intrinsics._members.ManagedPeerType;
			}
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00042BC8 File Offset: 0x00040DC8
		protected Intrinsics(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00042BD4 File Offset: 0x00040DD4
		[Register("areEqual", "(DLjava/lang/Double;)Z", "")]
		public unsafe static bool AreEqual(double first, Java.Lang.Double second)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(first);
				ptr[1] = new JniArgumentValue((second == null) ? IntPtr.Zero : second.Handle);
				result = Intrinsics._members.StaticMethods.InvokeBooleanMethod("areEqual.(DLjava/lang/Double;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(second);
			}
			return result;
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00042C4C File Offset: 0x00040E4C
		[Register("areEqual", "(FLjava/lang/Float;)Z", "")]
		public unsafe static bool AreEqual(float first, Float second)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(first);
				ptr[1] = new JniArgumentValue((second == null) ? IntPtr.Zero : second.Handle);
				result = Intrinsics._members.StaticMethods.InvokeBooleanMethod("areEqual.(FLjava/lang/Float;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(second);
			}
			return result;
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00042CC4 File Offset: 0x00040EC4
		[Register("areEqual", "(Ljava/lang/Double;D)Z", "")]
		public unsafe static bool AreEqual(Java.Lang.Double first, double second)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((first == null) ? IntPtr.Zero : first.Handle);
				ptr[1] = new JniArgumentValue(second);
				result = Intrinsics._members.StaticMethods.InvokeBooleanMethod("areEqual.(Ljava/lang/Double;D)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(first);
			}
			return result;
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00042D3C File Offset: 0x00040F3C
		[Register("areEqual", "(Ljava/lang/Double;Ljava/lang/Double;)Z", "")]
		public unsafe static bool AreEqual(Java.Lang.Double first, Java.Lang.Double second)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((first == null) ? IntPtr.Zero : first.Handle);
				ptr[1] = new JniArgumentValue((second == null) ? IntPtr.Zero : second.Handle);
				result = Intrinsics._members.StaticMethods.InvokeBooleanMethod("areEqual.(Ljava/lang/Double;Ljava/lang/Double;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(first);
				GC.KeepAlive(second);
			}
			return result;
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00042DC8 File Offset: 0x00040FC8
		[Register("areEqual", "(Ljava/lang/Float;F)Z", "")]
		public unsafe static bool AreEqual(Float first, float second)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((first == null) ? IntPtr.Zero : first.Handle);
				ptr[1] = new JniArgumentValue(second);
				result = Intrinsics._members.StaticMethods.InvokeBooleanMethod("areEqual.(Ljava/lang/Float;F)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(first);
			}
			return result;
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00042E40 File Offset: 0x00041040
		[Register("areEqual", "(Ljava/lang/Float;Ljava/lang/Float;)Z", "")]
		public unsafe static bool AreEqual(Float first, Float second)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((first == null) ? IntPtr.Zero : first.Handle);
				ptr[1] = new JniArgumentValue((second == null) ? IntPtr.Zero : second.Handle);
				result = Intrinsics._members.StaticMethods.InvokeBooleanMethod("areEqual.(Ljava/lang/Float;Ljava/lang/Float;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(first);
				GC.KeepAlive(second);
			}
			return result;
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00042ECC File Offset: 0x000410CC
		[Register("areEqual", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public unsafe static bool AreEqual(Java.Lang.Object first, Java.Lang.Object second)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((first == null) ? IntPtr.Zero : first.Handle);
				ptr[1] = new JniArgumentValue((second == null) ? IntPtr.Zero : second.Handle);
				result = Intrinsics._members.StaticMethods.InvokeBooleanMethod("areEqual.(Ljava/lang/Object;Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(first);
				GC.KeepAlive(second);
			}
			return result;
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00042F58 File Offset: 0x00041158
		[Register("checkExpressionValueIsNotNull", "(Ljava/lang/Object;Ljava/lang/String;)V", "")]
		public unsafe static void CheckExpressionValueIsNotNull(Java.Lang.Object value, string expression)
		{
			IntPtr intPtr = JNIEnv.NewString(expression);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("checkExpressionValueIsNotNull.(Ljava/lang/Object;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00042FDC File Offset: 0x000411DC
		[Register("checkFieldIsNotNull", "(Ljava/lang/Object;Ljava/lang/String;)V", "")]
		public unsafe static void CheckFieldIsNotNull(Java.Lang.Object value, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("checkFieldIsNotNull.(Ljava/lang/Object;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00043060 File Offset: 0x00041260
		[Register("checkFieldIsNotNull", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe static void CheckFieldIsNotNull(Java.Lang.Object value, string className, string fieldName)
		{
			IntPtr intPtr = JNIEnv.NewString(className);
			IntPtr intPtr2 = JNIEnv.NewString(fieldName);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("checkFieldIsNotNull.(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00043108 File Offset: 0x00041308
		[Register("checkHasClass", "(Ljava/lang/String;)V", "")]
		public unsafe static void CheckHasClass(string internalName)
		{
			IntPtr intPtr = JNIEnv.NewString(internalName);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("checkHasClass.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00043164 File Offset: 0x00041364
		[Register("checkHasClass", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe static void CheckHasClass(string internalName, string requiredVersion)
		{
			IntPtr intPtr = JNIEnv.NewString(internalName);
			IntPtr intPtr2 = JNIEnv.NewString(requiredVersion);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("checkHasClass.(Ljava/lang/String;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x000431E0 File Offset: 0x000413E0
		[Register("checkNotNull", "(Ljava/lang/Object;)V", "")]
		public unsafe static void CheckNotNull(Java.Lang.Object @object)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@object == null) ? IntPtr.Zero : @object.Handle);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("checkNotNull.(Ljava/lang/Object;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(@object);
			}
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00043244 File Offset: 0x00041444
		[Register("checkNotNull", "(Ljava/lang/Object;Ljava/lang/String;)V", "")]
		public unsafe static void CheckNotNull(Java.Lang.Object @object, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@object == null) ? IntPtr.Zero : @object.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("checkNotNull.(Ljava/lang/Object;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(@object);
			}
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x000432C8 File Offset: 0x000414C8
		[Register("checkNotNullExpressionValue", "(Ljava/lang/Object;Ljava/lang/String;)V", "")]
		public unsafe static void CheckNotNullExpressionValue(Java.Lang.Object value, string expression)
		{
			IntPtr intPtr = JNIEnv.NewString(expression);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("checkNotNullExpressionValue.(Ljava/lang/Object;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0004334C File Offset: 0x0004154C
		[Register("checkNotNullParameter", "(Ljava/lang/Object;Ljava/lang/String;)V", "")]
		public unsafe static void CheckNotNullParameter(Java.Lang.Object value, string paramName)
		{
			IntPtr intPtr = JNIEnv.NewString(paramName);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("checkNotNullParameter.(Ljava/lang/Object;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x000433D0 File Offset: 0x000415D0
		[Register("checkParameterIsNotNull", "(Ljava/lang/Object;Ljava/lang/String;)V", "")]
		public unsafe static void CheckParameterIsNotNull(Java.Lang.Object value, string paramName)
		{
			IntPtr intPtr = JNIEnv.NewString(paramName);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("checkParameterIsNotNull.(Ljava/lang/Object;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x00043454 File Offset: 0x00041654
		[Register("checkReturnedValueIsNotNull", "(Ljava/lang/Object;Ljava/lang/String;)V", "")]
		public unsafe static void CheckReturnedValueIsNotNull(Java.Lang.Object value, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("checkReturnedValueIsNotNull.(Ljava/lang/Object;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x000434D8 File Offset: 0x000416D8
		[Register("checkReturnedValueIsNotNull", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe static void CheckReturnedValueIsNotNull(Java.Lang.Object value, string className, string methodName)
		{
			IntPtr intPtr = JNIEnv.NewString(className);
			IntPtr intPtr2 = JNIEnv.NewString(methodName);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("checkReturnedValueIsNotNull.(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x00043580 File Offset: 0x00041780
		[Register("compare", "(II)I", "")]
		public unsafe static int Compare(int thisVal, int anotherVal)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(thisVal);
			ptr[1] = new JniArgumentValue(anotherVal);
			return Intrinsics._members.StaticMethods.InvokeInt32Method("compare.(II)I", ptr);
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x000435D0 File Offset: 0x000417D0
		[Register("compare", "(JJ)I", "")]
		public unsafe static int Compare(long thisVal, long anotherVal)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(thisVal);
			ptr[1] = new JniArgumentValue(anotherVal);
			return Intrinsics._members.StaticMethods.InvokeInt32Method("compare.(JJ)I", ptr);
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x0004361D File Offset: 0x0004181D
		[Register("needClassReification", "()V", "")]
		public static void NeedClassReification()
		{
			Intrinsics._members.StaticMethods.InvokeVoidMethod("needClassReification.()V", null);
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00043638 File Offset: 0x00041838
		[Register("needClassReification", "(Ljava/lang/String;)V", "")]
		public unsafe static void NeedClassReification(string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("needClassReification.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00043694 File Offset: 0x00041894
		[Register("reifiedOperationMarker", "(ILjava/lang/String;)V", "")]
		public unsafe static void ReifiedOperationMarker(int id, string typeParameterIdentifier)
		{
			IntPtr intPtr = JNIEnv.NewString(typeParameterIdentifier);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(id);
				ptr[1] = new JniArgumentValue(intPtr);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("reifiedOperationMarker.(ILjava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00043704 File Offset: 0x00041904
		[Register("reifiedOperationMarker", "(ILjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe static void ReifiedOperationMarker(int id, string typeParameterIdentifier, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(typeParameterIdentifier);
			IntPtr intPtr2 = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(id);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("reifiedOperationMarker.(ILjava/lang/String;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00043794 File Offset: 0x00041994
		[Register("stringPlus", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;", "")]
		public unsafe static string StringPlus(string self, Java.Lang.Object other)
		{
			IntPtr intPtr = JNIEnv.NewString(self);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : other.Handle);
				@string = JNIEnv.GetString(Intrinsics._members.StaticMethods.InvokeObjectMethod("stringPlus.(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(other);
			}
			return @string;
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00043828 File Offset: 0x00041A28
		[Register("throwAssert", "()V", "")]
		public static void ThrowAssert()
		{
			Intrinsics._members.StaticMethods.InvokeVoidMethod("throwAssert.()V", null);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00043840 File Offset: 0x00041A40
		[Register("throwAssert", "(Ljava/lang/String;)V", "")]
		public unsafe static void ThrowAssert(string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("throwAssert.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0004389C File Offset: 0x00041A9C
		[Register("throwIllegalArgument", "()V", "")]
		public static void ThrowIllegalArgument()
		{
			Intrinsics._members.StaticMethods.InvokeVoidMethod("throwIllegalArgument.()V", null);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x000438B4 File Offset: 0x00041AB4
		[Register("throwIllegalArgument", "(Ljava/lang/String;)V", "")]
		public unsafe static void ThrowIllegalArgument(string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("throwIllegalArgument.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00043910 File Offset: 0x00041B10
		[Register("throwIllegalState", "()V", "")]
		public static void ThrowIllegalState()
		{
			Intrinsics._members.StaticMethods.InvokeVoidMethod("throwIllegalState.()V", null);
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00043928 File Offset: 0x00041B28
		[Register("throwIllegalState", "(Ljava/lang/String;)V", "")]
		public unsafe static void ThrowIllegalState(string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("throwIllegalState.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x00043984 File Offset: 0x00041B84
		[Register("throwJavaNpe", "()V", "")]
		public static void ThrowJavaNpe()
		{
			Intrinsics._members.StaticMethods.InvokeVoidMethod("throwJavaNpe.()V", null);
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0004399C File Offset: 0x00041B9C
		[Register("throwJavaNpe", "(Ljava/lang/String;)V", "")]
		public unsafe static void ThrowJavaNpe(string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("throwJavaNpe.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x000439F8 File Offset: 0x00041BF8
		[Register("throwNpe", "()V", "")]
		public static void ThrowNpe()
		{
			Intrinsics._members.StaticMethods.InvokeVoidMethod("throwNpe.()V", null);
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x00043A10 File Offset: 0x00041C10
		[Register("throwNpe", "(Ljava/lang/String;)V", "")]
		public unsafe static void ThrowNpe(string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("throwNpe.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00043A6C File Offset: 0x00041C6C
		[Register("throwUndefinedForReified", "()V", "")]
		public static void ThrowUndefinedForReified()
		{
			Intrinsics._members.StaticMethods.InvokeVoidMethod("throwUndefinedForReified.()V", null);
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x00043A84 File Offset: 0x00041C84
		[Register("throwUndefinedForReified", "(Ljava/lang/String;)V", "")]
		public unsafe static void ThrowUndefinedForReified(string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("throwUndefinedForReified.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00043AE0 File Offset: 0x00041CE0
		[Register("throwUninitializedProperty", "(Ljava/lang/String;)V", "")]
		public unsafe static void ThrowUninitializedProperty(string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("throwUninitializedProperty.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00043B3C File Offset: 0x00041D3C
		[Register("throwUninitializedPropertyAccessException", "(Ljava/lang/String;)V", "")]
		public unsafe static void ThrowUninitializedPropertyAccessException(string propertyName)
		{
			IntPtr intPtr = JNIEnv.NewString(propertyName);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				Intrinsics._members.StaticMethods.InvokeVoidMethod("throwUninitializedPropertyAccessException.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x040006BB RID: 1723
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/Intrinsics", typeof(Intrinsics));

		// Token: 0x020002EB RID: 747
		[NullableContext(1)]
		[Nullable(0)]
		[Register("kotlin/jvm/internal/Intrinsics$Kotlin", DoNotGenerateAcw = true)]
		public class Kotlin : Java.Lang.Object
		{
			// Token: 0x17000A44 RID: 2628
			// (get) Token: 0x060029C8 RID: 10696 RVA: 0x000B9118 File Offset: 0x000B7318
			internal static IntPtr class_ref
			{
				get
				{
					return Intrinsics.Kotlin._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A45 RID: 2629
			// (get) Token: 0x060029C9 RID: 10697 RVA: 0x000B913C File Offset: 0x000B733C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Intrinsics.Kotlin._members;
				}
			}

			// Token: 0x17000A46 RID: 2630
			// (get) Token: 0x060029CA RID: 10698 RVA: 0x000B9144 File Offset: 0x000B7344
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Intrinsics.Kotlin._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A47 RID: 2631
			// (get) Token: 0x060029CB RID: 10699 RVA: 0x000B9168 File Offset: 0x000B7368
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Intrinsics.Kotlin._members.ManagedPeerType;
				}
			}

			// Token: 0x060029CC RID: 10700 RVA: 0x000B9174 File Offset: 0x000B7374
			protected Kotlin(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040009E2 RID: 2530
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/Intrinsics$Kotlin", typeof(Intrinsics.Kotlin));
		}
	}
}
