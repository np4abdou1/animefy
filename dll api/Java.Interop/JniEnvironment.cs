using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading;

namespace Java.Interop
{
	// Token: 0x02000011 RID: 17
	public static class JniEnvironment
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00003386 File Offset: 0x00001586
		internal static JniEnvironmentInfo CurrentInfo
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				JniEnvironmentInfo value = JniEnvironment.Info.Value;
				if (!value.IsValid)
				{
					throw new NotSupportedException("JNI Environment Information has been invalidated on this thread.");
				}
				return value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000033A5 File Offset: 0x000015A5
		public static JniRuntime Runtime
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return JniEnvironment.CurrentInfo.Runtime;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000033B1 File Offset: 0x000015B1
		public static IntPtr EnvironmentPointer
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return JniEnvironment.CurrentInfo.EnvironmentPointer;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000033BD File Offset: 0x000015BD
		public static int LocalReferenceCount
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return JniEnvironment.CurrentInfo.LocalReferenceCount;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000033C9 File Offset: 0x000015C9
		// (set) Token: 0x060000AC RID: 172 RVA: 0x000033D5 File Offset: 0x000015D5
		public static bool WithinNewObjectScope
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return JniEnvironment.CurrentInfo.WithinNewObjectScope;
			}
			internal set
			{
				JniEnvironment.CurrentInfo.WithinNewObjectScope = value;
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000033E2 File Offset: 0x000015E2
		internal static void SetEnvironmentPointer(IntPtr environmentPointer)
		{
			JniEnvironment.CurrentInfo.EnvironmentPointer = environmentPointer;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000033EF File Offset: 0x000015EF
		internal static void SetEnvironmentInfo(JniEnvironmentInfo info)
		{
			JniEnvironment.Info.Value = info;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000033FC File Offset: 0x000015FC
		internal static Exception GetExceptionForLastThrowable()
		{
			JniObjectReference value = JniEnvironment.Exceptions.ExceptionOccurred();
			if (!value.IsValid)
			{
				return null;
			}
			JniEnvironment.Exceptions.ExceptionClear();
			JniEnvironment.LogCreateLocalRef(value);
			return JniEnvironment.Runtime.GetExceptionForThrowable(ref value, JniObjectReferenceOptions.CopyAndDispose);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003434 File Offset: 0x00001634
		internal static Exception GetExceptionForLastThrowable(IntPtr thrown)
		{
			if (thrown == IntPtr.Zero)
			{
				return null;
			}
			JniObjectReference value = new JniObjectReference(thrown, JniObjectReferenceType.Local);
			JniEnvironment.Exceptions.ExceptionClear();
			JniEnvironment.LogCreateLocalRef(value);
			return JniEnvironment.Runtime.GetExceptionForThrowable(ref value, JniObjectReferenceOptions.CopyAndDispose);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00003471 File Offset: 0x00001671
		internal static void LogCreateLocalRef(JniObjectReference value)
		{
			if (!value.IsValid)
			{
				return;
			}
			JniEnvironment.Runtime.ObjectReferenceManager.CreatedLocalReference(JniEnvironment.CurrentInfo, value);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003492 File Offset: 0x00001692
		internal static void LogCreateLocalRef(IntPtr value)
		{
			if (value == IntPtr.Zero)
			{
				return;
			}
			JniEnvironment.LogCreateLocalRef(new JniObjectReference(value, JniObjectReferenceType.Local));
		}

		// Token: 0x04000026 RID: 38
		internal static readonly ThreadLocal<JniEnvironmentInfo> Info = new ThreadLocal<JniEnvironmentInfo>(() => new JniEnvironmentInfo(), true);

		// Token: 0x02000012 RID: 18
		public static class Arrays
		{
			// Token: 0x060000B4 RID: 180 RVA: 0x000034CB File Offset: 0x000016CB
			public static int GetArrayLength(JniObjectReference array)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				return NativeMethods.java_interop_jnienv_get_array_length(JniEnvironment.EnvironmentPointer, array.Handle);
			}

			// Token: 0x060000B5 RID: 181 RVA: 0x000034F8 File Offset: 0x000016F8
			public static JniObjectReference NewObjectArray(int length, JniObjectReference elementClass, JniObjectReference initialElement)
			{
				if (!elementClass.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "elementClass");
				}
				IntPtr thrown;
				IntPtr intPtr = NativeMethods.java_interop_jnienv_new_object_array(JniEnvironment.EnvironmentPointer, out thrown, length, elementClass.Handle, initialElement.Handle);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x060000B6 RID: 182 RVA: 0x0000355C File Offset: 0x0000175C
			public static JniObjectReference GetObjectArrayElement(JniObjectReference array, int index)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				IntPtr thrown;
				IntPtr intPtr = NativeMethods.java_interop_jnienv_get_object_array_element(JniEnvironment.EnvironmentPointer, out thrown, array.Handle, index);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x060000B7 RID: 183 RVA: 0x000035B8 File Offset: 0x000017B8
			public static void SetObjectArrayElement(JniObjectReference array, int index, JniObjectReference value)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_set_object_array_element(JniEnvironment.EnvironmentPointer, out thrown, array.Handle, index, value.Handle);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x060000B8 RID: 184 RVA: 0x0000360E File Offset: 0x0000180E
			public static JniObjectReference NewBooleanArray(int length)
			{
				IntPtr intPtr = NativeMethods.java_interop_jnienv_new_boolean_array(JniEnvironment.EnvironmentPointer, length);
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x00003627 File Offset: 0x00001827
			public static JniObjectReference NewByteArray(int length)
			{
				IntPtr intPtr = NativeMethods.java_interop_jnienv_new_byte_array(JniEnvironment.EnvironmentPointer, length);
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x060000BA RID: 186 RVA: 0x00003640 File Offset: 0x00001840
			public static JniObjectReference NewCharArray(int length)
			{
				IntPtr intPtr = NativeMethods.java_interop_jnienv_new_char_array(JniEnvironment.EnvironmentPointer, length);
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x060000BB RID: 187 RVA: 0x00003659 File Offset: 0x00001859
			public static JniObjectReference NewShortArray(int length)
			{
				IntPtr intPtr = NativeMethods.java_interop_jnienv_new_short_array(JniEnvironment.EnvironmentPointer, length);
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x060000BC RID: 188 RVA: 0x00003672 File Offset: 0x00001872
			public static JniObjectReference NewIntArray(int length)
			{
				IntPtr intPtr = NativeMethods.java_interop_jnienv_new_int_array(JniEnvironment.EnvironmentPointer, length);
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x060000BD RID: 189 RVA: 0x0000368B File Offset: 0x0000188B
			public static JniObjectReference NewLongArray(int length)
			{
				IntPtr intPtr = NativeMethods.java_interop_jnienv_new_long_array(JniEnvironment.EnvironmentPointer, length);
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x060000BE RID: 190 RVA: 0x000036A4 File Offset: 0x000018A4
			public static JniObjectReference NewFloatArray(int length)
			{
				IntPtr intPtr = NativeMethods.java_interop_jnienv_new_float_array(JniEnvironment.EnvironmentPointer, length);
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x060000BF RID: 191 RVA: 0x000036BD File Offset: 0x000018BD
			public static JniObjectReference NewDoubleArray(int length)
			{
				IntPtr intPtr = NativeMethods.java_interop_jnienv_new_double_array(JniEnvironment.EnvironmentPointer, length);
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x000036D6 File Offset: 0x000018D6
			public unsafe static bool* GetBooleanArrayElements(JniObjectReference array, bool* isCopy)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				return NativeMethods.java_interop_jnienv_get_boolean_array_elements(JniEnvironment.EnvironmentPointer, array.Handle, isCopy);
			}

			// Token: 0x060000C1 RID: 193 RVA: 0x00003703 File Offset: 0x00001903
			public unsafe static sbyte* GetByteArrayElements(JniObjectReference array, bool* isCopy)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				return NativeMethods.java_interop_jnienv_get_byte_array_elements(JniEnvironment.EnvironmentPointer, array.Handle, isCopy);
			}

			// Token: 0x060000C2 RID: 194 RVA: 0x00003730 File Offset: 0x00001930
			public unsafe static char* GetCharArrayElements(JniObjectReference array, bool* isCopy)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				return NativeMethods.java_interop_jnienv_get_char_array_elements(JniEnvironment.EnvironmentPointer, array.Handle, isCopy);
			}

			// Token: 0x060000C3 RID: 195 RVA: 0x0000375D File Offset: 0x0000195D
			public unsafe static short* GetShortArrayElements(JniObjectReference array, bool* isCopy)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				return NativeMethods.java_interop_jnienv_get_short_array_elements(JniEnvironment.EnvironmentPointer, array.Handle, isCopy);
			}

			// Token: 0x060000C4 RID: 196 RVA: 0x0000378A File Offset: 0x0000198A
			public unsafe static int* GetIntArrayElements(JniObjectReference array, bool* isCopy)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				return NativeMethods.java_interop_jnienv_get_int_array_elements(JniEnvironment.EnvironmentPointer, array.Handle, isCopy);
			}

			// Token: 0x060000C5 RID: 197 RVA: 0x000037B7 File Offset: 0x000019B7
			public unsafe static long* GetLongArrayElements(JniObjectReference array, bool* isCopy)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				return NativeMethods.java_interop_jnienv_get_long_array_elements(JniEnvironment.EnvironmentPointer, array.Handle, isCopy);
			}

			// Token: 0x060000C6 RID: 198 RVA: 0x000037E4 File Offset: 0x000019E4
			public unsafe static float* GetFloatArrayElements(JniObjectReference array, bool* isCopy)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				return NativeMethods.java_interop_jnienv_get_float_array_elements(JniEnvironment.EnvironmentPointer, array.Handle, isCopy);
			}

			// Token: 0x060000C7 RID: 199 RVA: 0x00003811 File Offset: 0x00001A11
			public unsafe static double* GetDoubleArrayElements(JniObjectReference array, bool* isCopy)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				return NativeMethods.java_interop_jnienv_get_double_array_elements(JniEnvironment.EnvironmentPointer, array.Handle, isCopy);
			}

			// Token: 0x060000C8 RID: 200 RVA: 0x0000383E File Offset: 0x00001A3E
			public unsafe static void ReleaseBooleanArrayElements(JniObjectReference array, bool* elements, JniReleaseArrayElementsMode mode)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				NativeMethods.java_interop_jnienv_release_boolean_array_elements(JniEnvironment.EnvironmentPointer, array.Handle, elements, (int)mode);
			}

			// Token: 0x060000C9 RID: 201 RVA: 0x0000386C File Offset: 0x00001A6C
			public unsafe static void ReleaseByteArrayElements(JniObjectReference array, sbyte* elements, JniReleaseArrayElementsMode mode)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				NativeMethods.java_interop_jnienv_release_byte_array_elements(JniEnvironment.EnvironmentPointer, array.Handle, elements, (int)mode);
			}

			// Token: 0x060000CA RID: 202 RVA: 0x0000389A File Offset: 0x00001A9A
			public unsafe static void ReleaseCharArrayElements(JniObjectReference array, char* elements, JniReleaseArrayElementsMode mode)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				NativeMethods.java_interop_jnienv_release_char_array_elements(JniEnvironment.EnvironmentPointer, array.Handle, elements, (int)mode);
			}

			// Token: 0x060000CB RID: 203 RVA: 0x000038C8 File Offset: 0x00001AC8
			public unsafe static void ReleaseShortArrayElements(JniObjectReference array, short* elements, JniReleaseArrayElementsMode mode)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				NativeMethods.java_interop_jnienv_release_short_array_elements(JniEnvironment.EnvironmentPointer, array.Handle, elements, (int)mode);
			}

			// Token: 0x060000CC RID: 204 RVA: 0x000038F6 File Offset: 0x00001AF6
			public unsafe static void ReleaseIntArrayElements(JniObjectReference array, int* elements, JniReleaseArrayElementsMode mode)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				NativeMethods.java_interop_jnienv_release_int_array_elements(JniEnvironment.EnvironmentPointer, array.Handle, elements, (int)mode);
			}

			// Token: 0x060000CD RID: 205 RVA: 0x00003924 File Offset: 0x00001B24
			public unsafe static void ReleaseLongArrayElements(JniObjectReference array, long* elements, JniReleaseArrayElementsMode mode)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				NativeMethods.java_interop_jnienv_release_long_array_elements(JniEnvironment.EnvironmentPointer, array.Handle, elements, (int)mode);
			}

			// Token: 0x060000CE RID: 206 RVA: 0x00003952 File Offset: 0x00001B52
			public unsafe static void ReleaseFloatArrayElements(JniObjectReference array, float* elements, JniReleaseArrayElementsMode mode)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				NativeMethods.java_interop_jnienv_release_float_array_elements(JniEnvironment.EnvironmentPointer, array.Handle, elements, (int)mode);
			}

			// Token: 0x060000CF RID: 207 RVA: 0x00003980 File Offset: 0x00001B80
			public unsafe static void ReleaseDoubleArrayElements(JniObjectReference array, double* elements, JniReleaseArrayElementsMode mode)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				NativeMethods.java_interop_jnienv_release_double_array_elements(JniEnvironment.EnvironmentPointer, array.Handle, elements, (int)mode);
			}

			// Token: 0x060000D0 RID: 208 RVA: 0x000039B0 File Offset: 0x00001BB0
			public unsafe static void GetBooleanArrayRegion(JniObjectReference array, int start, int length, bool* buffer)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_get_boolean_array_region(JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x060000D1 RID: 209 RVA: 0x00003A04 File Offset: 0x00001C04
			public unsafe static void GetByteArrayRegion(JniObjectReference array, int start, int length, sbyte* buffer)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_get_byte_array_region(JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x060000D2 RID: 210 RVA: 0x00003A58 File Offset: 0x00001C58
			public unsafe static void GetCharArrayRegion(JniObjectReference array, int start, int length, char* buffer)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_get_char_array_region(JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x060000D3 RID: 211 RVA: 0x00003AAC File Offset: 0x00001CAC
			public unsafe static void GetShortArrayRegion(JniObjectReference array, int start, int length, short* buffer)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_get_short_array_region(JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x060000D4 RID: 212 RVA: 0x00003B00 File Offset: 0x00001D00
			public unsafe static void GetIntArrayRegion(JniObjectReference array, int start, int length, int* buffer)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_get_int_array_region(JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x060000D5 RID: 213 RVA: 0x00003B54 File Offset: 0x00001D54
			public unsafe static void GetLongArrayRegion(JniObjectReference array, int start, int length, long* buffer)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_get_long_array_region(JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x060000D6 RID: 214 RVA: 0x00003BA8 File Offset: 0x00001DA8
			public unsafe static void GetFloatArrayRegion(JniObjectReference array, int start, int length, float* buffer)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_get_float_array_region(JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x060000D7 RID: 215 RVA: 0x00003BFC File Offset: 0x00001DFC
			public unsafe static void GetDoubleArrayRegion(JniObjectReference array, int start, int length, double* buffer)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_get_double_array_region(JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x060000D8 RID: 216 RVA: 0x00003C50 File Offset: 0x00001E50
			public unsafe static void SetBooleanArrayRegion(JniObjectReference array, int start, int length, bool* buffer)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_set_boolean_array_region(JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x060000D9 RID: 217 RVA: 0x00003CA4 File Offset: 0x00001EA4
			public unsafe static void SetByteArrayRegion(JniObjectReference array, int start, int length, sbyte* buffer)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_set_byte_array_region(JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x060000DA RID: 218 RVA: 0x00003CF8 File Offset: 0x00001EF8
			public unsafe static void SetCharArrayRegion(JniObjectReference array, int start, int length, char* buffer)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_set_char_array_region(JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x060000DB RID: 219 RVA: 0x00003D4C File Offset: 0x00001F4C
			public unsafe static void SetShortArrayRegion(JniObjectReference array, int start, int length, short* buffer)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_set_short_array_region(JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x060000DC RID: 220 RVA: 0x00003DA0 File Offset: 0x00001FA0
			public unsafe static void SetIntArrayRegion(JniObjectReference array, int start, int length, int* buffer)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_set_int_array_region(JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x060000DD RID: 221 RVA: 0x00003DF4 File Offset: 0x00001FF4
			public unsafe static void SetLongArrayRegion(JniObjectReference array, int start, int length, long* buffer)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_set_long_array_region(JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x060000DE RID: 222 RVA: 0x00003E48 File Offset: 0x00002048
			public unsafe static void SetFloatArrayRegion(JniObjectReference array, int start, int length, float* buffer)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_set_float_array_region(JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x060000DF RID: 223 RVA: 0x00003E9C File Offset: 0x0000209C
			public unsafe static void SetDoubleArrayRegion(JniObjectReference array, int start, int length, double* buffer)
			{
				if (!array.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "array");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_set_double_array_region(JniEnvironment.EnvironmentPointer, out thrown, array.Handle, start, length, buffer);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}
		}

		// Token: 0x02000013 RID: 19
		public static class References
		{
			// Token: 0x060000E0 RID: 224 RVA: 0x00003EED File Offset: 0x000020ED
			internal static int GetJavaVM(IntPtr jnienv, out IntPtr vm)
			{
				return NativeMethods.java_interop_jnienv_get_java_vm(jnienv, out vm);
			}

			// Token: 0x060000E1 RID: 225 RVA: 0x00003EF6 File Offset: 0x000020F6
			internal static void RawDeleteLocalRef(IntPtr env, IntPtr localRef)
			{
				NativeMethods.java_interop_jnienv_delete_local_ref(env, localRef);
			}

			// Token: 0x060000E2 RID: 226 RVA: 0x00003F00 File Offset: 0x00002100
			public static void EnsureLocalCapacity(int capacity)
			{
				int num = JniEnvironment.References._EnsureLocalCapacity(capacity);
				if (num == 0)
				{
					return;
				}
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable();
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				throw new InvalidOperationException(string.Format("Could not ensure capacity; JNIEnv::EnsureLocalCapacity() returned {0}.", num));
			}

			// Token: 0x060000E3 RID: 227 RVA: 0x00003F44 File Offset: 0x00002144
			public static void PushLocalFrame(int capacity)
			{
				int num = JniEnvironment.References._PushLocalFrame(capacity);
				if (num == 0)
				{
					return;
				}
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable();
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				throw new InvalidOperationException(string.Format("Could not push a frame; JNIEnv::PushLocalFrame() returned {0}.", num));
			}

			// Token: 0x060000E4 RID: 228 RVA: 0x00003F85 File Offset: 0x00002185
			internal static int _PushLocalFrame(int capacity)
			{
				return NativeMethods.java_interop_jnienv_push_local_frame(JniEnvironment.EnvironmentPointer, capacity);
			}

			// Token: 0x060000E5 RID: 229 RVA: 0x00003F92 File Offset: 0x00002192
			public static JniObjectReference PopLocalFrame(JniObjectReference result)
			{
				IntPtr intPtr = NativeMethods.java_interop_jnienv_pop_local_frame(JniEnvironment.EnvironmentPointer, result.Handle);
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x060000E6 RID: 230 RVA: 0x00003FB1 File Offset: 0x000021B1
			internal static JniObjectReference NewGlobalRef(JniObjectReference instance)
			{
				return new JniObjectReference(NativeMethods.java_interop_jnienv_new_global_ref(JniEnvironment.EnvironmentPointer, instance.Handle), JniObjectReferenceType.Global);
			}

			// Token: 0x060000E7 RID: 231 RVA: 0x00003FCA File Offset: 0x000021CA
			internal static void DeleteGlobalRef(IntPtr instance)
			{
				NativeMethods.java_interop_jnienv_delete_global_ref(JniEnvironment.EnvironmentPointer, instance);
			}

			// Token: 0x060000E8 RID: 232 RVA: 0x00003FD7 File Offset: 0x000021D7
			internal static void DeleteLocalRef(IntPtr instance)
			{
				NativeMethods.java_interop_jnienv_delete_local_ref(JniEnvironment.EnvironmentPointer, instance);
			}

			// Token: 0x060000E9 RID: 233 RVA: 0x00003FE4 File Offset: 0x000021E4
			internal static JniObjectReference NewLocalRef(JniObjectReference instance)
			{
				return new JniObjectReference(NativeMethods.java_interop_jnienv_new_local_ref(JniEnvironment.EnvironmentPointer, instance.Handle), JniObjectReferenceType.Local);
			}

			// Token: 0x060000EA RID: 234 RVA: 0x00003FFD File Offset: 0x000021FD
			internal static int _EnsureLocalCapacity(int capacity)
			{
				return NativeMethods.java_interop_jnienv_ensure_local_capacity(JniEnvironment.EnvironmentPointer, capacity);
			}

			// Token: 0x060000EB RID: 235 RVA: 0x0000400A File Offset: 0x0000220A
			internal static void DeleteWeakGlobalRef(IntPtr instance)
			{
				NativeMethods.java_interop_jnienv_delete_weak_global_ref(JniEnvironment.EnvironmentPointer, instance);
			}
		}

		// Token: 0x02000014 RID: 20
		public static class Exceptions
		{
			// Token: 0x060000EC RID: 236 RVA: 0x00004018 File Offset: 0x00002218
			public static void Throw(JniObjectReference toThrow)
			{
				if (!toThrow.IsValid)
				{
					throw new ArgumentException("toThrow");
				}
				int num = JniEnvironment.Exceptions._Throw(toThrow);
				if (num != 0)
				{
					throw new InvalidOperationException(string.Format("Could not raise an exception; JNIEnv::Throw() returned {0}.", num));
				}
			}

			// Token: 0x060000ED RID: 237 RVA: 0x0000405C File Offset: 0x0000225C
			public static void ThrowNew(JniObjectReference klass, string message)
			{
				if (!klass.IsValid)
				{
					throw new ArgumentException("klass");
				}
				if (message == null)
				{
					throw new ArgumentNullException("message");
				}
				int num = JniEnvironment.Exceptions._ThrowNew(klass, message);
				if (num != 0)
				{
					throw new InvalidOperationException(string.Format("Could not raise an exception; JNIEnv::ThrowNew() returned {0}.", num));
				}
			}

			// Token: 0x060000EE RID: 238 RVA: 0x000040AC File Offset: 0x000022AC
			public static void Throw(Exception e)
			{
				if (e == null)
				{
					throw new ArgumentNullException("e");
				}
				JavaException ex = e as JavaException;
				if (ex == null)
				{
					ex = new JavaProxyThrowable(e);
				}
				JniEnvironment.Exceptions.Throw(ex.PeerReference);
			}

			// Token: 0x060000EF RID: 239 RVA: 0x000040E3 File Offset: 0x000022E3
			internal static int _Throw(JniObjectReference toThrow)
			{
				if (!toThrow.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "toThrow");
				}
				return NativeMethods.java_interop_jnienv_throw(JniEnvironment.EnvironmentPointer, toThrow.Handle);
			}

			// Token: 0x060000F0 RID: 240 RVA: 0x0000410F File Offset: 0x0000230F
			internal static int _ThrowNew(JniObjectReference type, string message)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (message == null)
				{
					throw new ArgumentNullException("message");
				}
				return NativeMethods.java_interop_jnienv_throw_new(JniEnvironment.EnvironmentPointer, type.Handle, message);
			}

			// Token: 0x060000F1 RID: 241 RVA: 0x0000414A File Offset: 0x0000234A
			public static JniObjectReference ExceptionOccurred()
			{
				return new JniObjectReference(NativeMethods.java_interop_jnienv_exception_occurred(JniEnvironment.EnvironmentPointer), JniObjectReferenceType.Local);
			}

			// Token: 0x060000F2 RID: 242 RVA: 0x0000415C File Offset: 0x0000235C
			public static void ExceptionDescribe()
			{
				NativeMethods.java_interop_jnienv_exception_describe(JniEnvironment.EnvironmentPointer);
			}

			// Token: 0x060000F3 RID: 243 RVA: 0x00004168 File Offset: 0x00002368
			public static void ExceptionClear()
			{
				NativeMethods.java_interop_jnienv_exception_clear(JniEnvironment.EnvironmentPointer);
			}
		}

		// Token: 0x02000015 RID: 21
		public static class Object
		{
			// Token: 0x060000F4 RID: 244 RVA: 0x00004174 File Offset: 0x00002374
			static Object()
			{
				using (JniType jniType = new JniType("java/lang/Object"))
				{
					JniEnvironment.Object.Object_toString = jniType.GetInstanceMethod("toString", "()Ljava/lang/String;");
				}
			}

			// Token: 0x060000F5 RID: 245 RVA: 0x000041C0 File Offset: 0x000023C0
			public static JniObjectReference NewObject(JniObjectReference type, JniMethodInfo method)
			{
				JniEnvironment.WithinNewObjectScope = true;
				JniObjectReference result;
				try
				{
					result = JniEnvironment.Object._NewObject(type, method);
				}
				finally
				{
					JniEnvironment.WithinNewObjectScope = false;
				}
				return result;
			}

			// Token: 0x060000F6 RID: 246 RVA: 0x000041F8 File Offset: 0x000023F8
			public unsafe static JniObjectReference NewObject(JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				JniEnvironment.WithinNewObjectScope = true;
				JniObjectReference result;
				try
				{
					result = JniEnvironment.Object._NewObject(type, method, args);
				}
				finally
				{
					JniEnvironment.WithinNewObjectScope = false;
				}
				return result;
			}

			// Token: 0x060000F7 RID: 247 RVA: 0x00004230 File Offset: 0x00002430
			public static JniObjectReference ToString(JniObjectReference value)
			{
				return JniEnvironment.InstanceMethods.CallObjectMethod(value, JniEnvironment.Object.Object_toString);
			}

			// Token: 0x060000F8 RID: 248 RVA: 0x00004240 File Offset: 0x00002440
			public static JniObjectReference AllocObject(JniObjectReference type)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				IntPtr thrown;
				IntPtr intPtr = NativeMethods.java_interop_jnienv_alloc_object(JniEnvironment.EnvironmentPointer, out thrown, type.Handle);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x060000F9 RID: 249 RVA: 0x0000429C File Offset: 0x0000249C
			internal static JniObjectReference _NewObject(JniObjectReference type, JniMethodInfo method)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				IntPtr intPtr = NativeMethods.java_interop_jnienv_new_object(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x060000FA RID: 250 RVA: 0x00004324 File Offset: 0x00002524
			internal unsafe static JniObjectReference _NewObject(JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				IntPtr intPtr = NativeMethods.java_interop_jnienv_new_object_a(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x04000027 RID: 39
			private static JniMethodInfo Object_toString;
		}

		// Token: 0x02000016 RID: 22
		public static class Strings
		{
			// Token: 0x060000FB RID: 251 RVA: 0x000043B0 File Offset: 0x000025B0
			public unsafe static JniObjectReference NewString(string value)
			{
				if (value == null)
				{
					return default(JniObjectReference);
				}
				char* ptr = value;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				return JniEnvironment.Strings.NewString(ptr, value.Length);
			}

			// Token: 0x060000FC RID: 252 RVA: 0x000043E6 File Offset: 0x000025E6
			public static string ToString(IntPtr reference)
			{
				return JniEnvironment.Strings.ToString(new JniObjectReference(reference, JniObjectReferenceType.Invalid));
			}

			// Token: 0x060000FD RID: 253 RVA: 0x000043F4 File Offset: 0x000025F4
			internal static string ToString(ref JniObjectReference reference, JniObjectReferenceOptions transfer, Type targetType)
			{
				return JniEnvironment.Strings.ToString(ref reference, transfer);
			}

			// Token: 0x060000FE RID: 254 RVA: 0x000043FD File Offset: 0x000025FD
			public static string ToString(JniObjectReference value)
			{
				return JniEnvironment.Strings.ToString(ref value, JniObjectReferenceOptions.Copy);
			}

			// Token: 0x060000FF RID: 255 RVA: 0x00004408 File Offset: 0x00002608
			public unsafe static string ToString(ref JniObjectReference value, JniObjectReferenceOptions transfer)
			{
				if (!value.IsValid)
				{
					return null;
				}
				int stringLength = JniEnvironment.Strings.GetStringLength(value);
				char* stringChars = JniEnvironment.Strings.GetStringChars(value, null);
				string result;
				try
				{
					result = new string(stringChars, 0, stringLength);
				}
				finally
				{
					JniEnvironment.Strings.ReleaseStringChars(value, stringChars);
					JniObjectReference.Dispose(ref value, transfer);
				}
				return result;
			}

			// Token: 0x06000100 RID: 256 RVA: 0x0000446C File Offset: 0x0000266C
			public unsafe static JniObjectReference NewString(char* unicodeChars, int length)
			{
				IntPtr thrown;
				IntPtr intPtr = NativeMethods.java_interop_jnienv_new_string(JniEnvironment.EnvironmentPointer, out thrown, unicodeChars, length);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x06000101 RID: 257 RVA: 0x000044A8 File Offset: 0x000026A8
			public static int GetStringLength(JniObjectReference stringInstance)
			{
				if (!stringInstance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "stringInstance");
				}
				return NativeMethods.java_interop_jnienv_get_string_length(JniEnvironment.EnvironmentPointer, stringInstance.Handle);
			}

			// Token: 0x06000102 RID: 258 RVA: 0x000044D4 File Offset: 0x000026D4
			public unsafe static char* GetStringChars(JniObjectReference stringInstance, bool* isCopy)
			{
				if (!stringInstance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "stringInstance");
				}
				return NativeMethods.java_interop_jnienv_get_string_chars(JniEnvironment.EnvironmentPointer, stringInstance.Handle, isCopy);
			}

			// Token: 0x06000103 RID: 259 RVA: 0x00004501 File Offset: 0x00002701
			public unsafe static void ReleaseStringChars(JniObjectReference stringInstance, char* chars)
			{
				if (!stringInstance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "stringInstance");
				}
				NativeMethods.java_interop_jnienv_release_string_chars(JniEnvironment.EnvironmentPointer, stringInstance.Handle, chars);
			}
		}

		// Token: 0x02000017 RID: 23
		public static class Types
		{
			// Token: 0x06000104 RID: 260 RVA: 0x00004530 File Offset: 0x00002730
			static Types()
			{
				using (JniType jniType = new JniType("java/lang/Class"))
				{
					JniEnvironment.Types.Class_getName = jniType.GetInstanceMethod("getName", "()Ljava/lang/String;");
				}
			}

			// Token: 0x06000105 RID: 261 RVA: 0x0000464C File Offset: 0x0000284C
			public static JniObjectReference FindClass(string classname)
			{
				return JniEnvironment.Types.TryFindClass(classname, true);
			}

			// Token: 0x06000106 RID: 262 RVA: 0x00004658 File Offset: 0x00002858
			private unsafe static JniObjectReference TryFindClass(string classname, bool throwOnError)
			{
				if (classname == null)
				{
					throw new ArgumentNullException("classname");
				}
				if (classname.Length == 0)
				{
					throw new ArgumentException("'classname' cannot be a zero-length string.", "classname");
				}
				JniEnvironmentInfo currentInfo = JniEnvironment.CurrentInfo;
				IntPtr handle;
				IntPtr intPtr;
				if (JniEnvironment.Types.TryRawFindClass(currentInfo.EnvironmentPointer, classname, out handle, out intPtr))
				{
					JniObjectReference jniObjectReference = new JniObjectReference(handle, JniObjectReferenceType.Local);
					JniEnvironment.LogCreateLocalRef(jniObjectReference);
					return jniObjectReference;
				}
				JniEnvironment.Types.RawExceptionClear(currentInfo.EnvironmentPointer);
				JniObjectReference value = new JniObjectReference(intPtr, JniObjectReferenceType.Local);
				JniEnvironment.LogCreateLocalRef(value);
				Exception exceptionForThrowable = currentInfo.Runtime.GetExceptionForThrowable(ref value, JniObjectReferenceOptions.CopyAndDispose);
				if (currentInfo.Runtime.ClassLoader_LoadClass != null)
				{
					JniObjectReference value2 = currentInfo.ToJavaName(classname);
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(value2);
					handle = JniEnvironment.Types.RawCallObjectMethodA(currentInfo.EnvironmentPointer, out intPtr, currentInfo.Runtime.ClassLoader.Handle, currentInfo.Runtime.ClassLoader_LoadClass.ID, (IntPtr)((void*)ptr));
					JniObjectReference.Dispose(ref value2);
					if (intPtr == IntPtr.Zero)
					{
						IJavaPeerable javaPeerable = exceptionForThrowable as IJavaPeerable;
						if (javaPeerable != null)
						{
							javaPeerable.Dispose();
						}
						JniObjectReference jniObjectReference2 = new JniObjectReference(handle, JniObjectReferenceType.Local);
						JniEnvironment.LogCreateLocalRef(jniObjectReference2);
						return jniObjectReference2;
					}
					JniEnvironment.Types.RawExceptionClear(currentInfo.EnvironmentPointer);
					if (exceptionForThrowable != null)
					{
						JniEnvironment.References.RawDeleteLocalRef(currentInfo.EnvironmentPointer, intPtr);
					}
					else
					{
						JniObjectReference value3 = new JniObjectReference(intPtr, JniObjectReferenceType.Local);
						JniEnvironment.LogCreateLocalRef(value3);
						exceptionForThrowable = currentInfo.Runtime.GetExceptionForThrowable(ref value3, JniObjectReferenceOptions.CopyAndDispose);
					}
				}
				if (!throwOnError)
				{
					IJavaPeerable javaPeerable2 = exceptionForThrowable as IJavaPeerable;
					if (javaPeerable2 != null)
					{
						javaPeerable2.Dispose();
					}
					return default(JniObjectReference);
				}
				throw exceptionForThrowable;
			}

			// Token: 0x06000107 RID: 263 RVA: 0x000047D7 File Offset: 0x000029D7
			private static bool TryRawFindClass(IntPtr env, string classname, out IntPtr klass, out IntPtr thrown)
			{
				klass = NativeMethods.java_interop_jnienv_find_class(env, out thrown, classname);
				return thrown == IntPtr.Zero;
			}

			// Token: 0x06000108 RID: 264 RVA: 0x000047F4 File Offset: 0x000029F4
			private static void RawExceptionClear(IntPtr env)
			{
				NativeMethods.java_interop_jnienv_exception_clear(env);
			}

			// Token: 0x06000109 RID: 265 RVA: 0x000047FC File Offset: 0x000029FC
			private static IntPtr RawCallObjectMethodA(IntPtr env, out IntPtr thrown, IntPtr instance, IntPtr jmethodID, IntPtr args)
			{
				return NativeMethods.java_interop_jnienv_call_object_method_a(env, out thrown, instance, jmethodID, args);
			}

			// Token: 0x0600010A RID: 266 RVA: 0x0000480C File Offset: 0x00002A0C
			public static string GetJniTypeNameFromInstance(JniObjectReference instance)
			{
				if (!instance.IsValid)
				{
					return null;
				}
				JniObjectReference objectClass = JniEnvironment.Types.GetObjectClass(instance);
				string jniTypeNameFromClass;
				try
				{
					jniTypeNameFromClass = JniEnvironment.Types.GetJniTypeNameFromClass(objectClass);
				}
				finally
				{
					JniObjectReference.Dispose(ref objectClass, JniObjectReferenceOptions.CopyAndDispose);
				}
				return jniTypeNameFromClass;
			}

			// Token: 0x0600010B RID: 267 RVA: 0x00004850 File Offset: 0x00002A50
			public static string GetJniTypeNameFromClass(JniObjectReference type)
			{
				if (!type.IsValid)
				{
					return null;
				}
				JniObjectReference jniObjectReference = JniEnvironment.InstanceMethods.CallObjectMethod(type, JniEnvironment.Types.Class_getName);
				return JniEnvironment.Types.JavaClassToJniType(JniEnvironment.Strings.ToString(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose));
			}

			// Token: 0x0600010C RID: 268 RVA: 0x00004884 File Offset: 0x00002A84
			private static string JavaClassToJniType(string value)
			{
				for (int i = 0; i < JniEnvironment.Types.BuiltinMappings.Length; i++)
				{
					if (value == JniEnvironment.Types.BuiltinMappings[i].Key)
					{
						return JniEnvironment.Types.BuiltinMappings[i].Value;
					}
				}
				return value.Replace('.', '/');
			}

			// Token: 0x0600010D RID: 269 RVA: 0x000048D8 File Offset: 0x00002AD8
			public static void RegisterNatives(JniObjectReference type, JniNativeMethodRegistration[] methods, int numMethods)
			{
				if (numMethods < 0 || numMethods > ((methods != null) ? methods.Length : 0))
				{
					throw new ArgumentOutOfRangeException("numMethods", numMethods, string.Format("`numMethods` must be between 0 and `methods.Length` ({0})!", (methods != null) ? methods.Length : 0));
				}
				int num = JniEnvironment.Types._RegisterNatives(type, methods, numMethods);
				if (num != 0)
				{
					throw new InvalidOperationException(string.Format("Could not register native methods for class '{0}'; JNIEnv::RegisterNatives() returned {1}.", JniEnvironment.Types.GetJniTypeNameFromClass(type), num));
				}
			}

			// Token: 0x0600010E RID: 270 RVA: 0x00004948 File Offset: 0x00002B48
			public static void UnregisterNatives(JniObjectReference type)
			{
				int num = JniEnvironment.Types._UnregisterNatives(type);
				if (num != 0)
				{
					throw new InvalidOperationException(string.Format("Could not unregister native methods for class '{0}'; JNIEnv::UnregisterNatives() returned {1}.", JniEnvironment.Types.GetJniTypeNameFromClass(type), num));
				}
			}

			// Token: 0x0600010F RID: 271 RVA: 0x0000497B File Offset: 0x00002B7B
			public static JniObjectReference GetSuperclass(JniObjectReference type)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				IntPtr intPtr = NativeMethods.java_interop_jnienv_get_superclass(JniEnvironment.EnvironmentPointer, type.Handle);
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x06000110 RID: 272 RVA: 0x000049B4 File Offset: 0x00002BB4
			public static bool IsAssignableFrom(JniObjectReference class1, JniObjectReference class2)
			{
				if (!class1.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "class1");
				}
				if (!class2.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "class2");
				}
				return NativeMethods.java_interop_jnienv_is_assignable_from(JniEnvironment.EnvironmentPointer, class1.Handle, class2.Handle) != 0;
			}

			// Token: 0x06000111 RID: 273 RVA: 0x00004A10 File Offset: 0x00002C10
			public static bool IsSameObject(JniObjectReference object1, JniObjectReference object2)
			{
				return NativeMethods.java_interop_jnienv_is_same_object(JniEnvironment.EnvironmentPointer, object1.Handle, object2.Handle) != 0;
			}

			// Token: 0x06000112 RID: 274 RVA: 0x00004A2F File Offset: 0x00002C2F
			public static JniObjectReference GetObjectClass(JniObjectReference instance)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				IntPtr intPtr = NativeMethods.java_interop_jnienv_get_object_class(JniEnvironment.EnvironmentPointer, instance.Handle);
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x06000113 RID: 275 RVA: 0x00004A68 File Offset: 0x00002C68
			public static bool IsInstanceOf(JniObjectReference instance, JniObjectReference type)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				return NativeMethods.java_interop_jnienv_is_instance_of(JniEnvironment.EnvironmentPointer, instance.Handle, type.Handle) != 0;
			}

			// Token: 0x06000114 RID: 276 RVA: 0x00004AC4 File Offset: 0x00002CC4
			internal static int _RegisterNatives(JniObjectReference type, JniNativeMethodRegistration[] methods, int numMethods)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				IntPtr thrown;
				int result = NativeMethods.java_interop_jnienv_register_natives(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, methods, numMethods);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000115 RID: 277 RVA: 0x00004B14 File Offset: 0x00002D14
			internal static int _UnregisterNatives(JniObjectReference type)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				return NativeMethods.java_interop_jnienv_unregister_natives(JniEnvironment.EnvironmentPointer, type.Handle);
			}

			// Token: 0x04000028 RID: 40
			private static readonly KeyValuePair<string, string>[] BuiltinMappings = new KeyValuePair<string, string>[]
			{
				new KeyValuePair<string, string>("byte", "B"),
				new KeyValuePair<string, string>("boolean", "Z"),
				new KeyValuePair<string, string>("char", "C"),
				new KeyValuePair<string, string>("double", "D"),
				new KeyValuePair<string, string>("float", "F"),
				new KeyValuePair<string, string>("int", "I"),
				new KeyValuePair<string, string>("long", "J"),
				new KeyValuePair<string, string>("short", "S"),
				new KeyValuePair<string, string>("void", "V")
			};

			// Token: 0x04000029 RID: 41
			private static readonly JniMethodInfo Class_getName;
		}

		// Token: 0x02000018 RID: 24
		public static class InstanceFields
		{
			// Token: 0x06000116 RID: 278 RVA: 0x00004B40 File Offset: 0x00002D40
			public static JniFieldInfo GetFieldID(JniObjectReference type, string name, string signature)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (name == null)
				{
					throw new ArgumentNullException("name");
				}
				if (signature == null)
				{
					throw new ArgumentNullException("signature");
				}
				IntPtr thrown;
				IntPtr intPtr = NativeMethods.java_interop_jnienv_get_field_id(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, name, signature);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				if (intPtr == IntPtr.Zero)
				{
					return null;
				}
				return new JniFieldInfo(name, signature, intPtr, false);
			}

			// Token: 0x06000117 RID: 279 RVA: 0x00004BC8 File Offset: 0x00002DC8
			public static JniObjectReference GetObjectField(JniObjectReference instance, JniFieldInfo field)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				IntPtr intPtr = NativeMethods.java_interop_jnienv_get_object_field(JniEnvironment.EnvironmentPointer, instance.Handle, field.ID);
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x06000118 RID: 280 RVA: 0x00004C38 File Offset: 0x00002E38
			public static bool GetBooleanField(JniObjectReference instance, JniFieldInfo field)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				return NativeMethods.java_interop_jnienv_get_boolean_field(JniEnvironment.EnvironmentPointer, instance.Handle, field.ID) != 0;
			}

			// Token: 0x06000119 RID: 281 RVA: 0x00004CA0 File Offset: 0x00002EA0
			public static sbyte GetByteField(JniObjectReference instance, JniFieldInfo field)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				return NativeMethods.java_interop_jnienv_get_byte_field(JniEnvironment.EnvironmentPointer, instance.Handle, field.ID);
			}

			// Token: 0x0600011A RID: 282 RVA: 0x00004D04 File Offset: 0x00002F04
			public static char GetCharField(JniObjectReference instance, JniFieldInfo field)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				return NativeMethods.java_interop_jnienv_get_char_field(JniEnvironment.EnvironmentPointer, instance.Handle, field.ID);
			}

			// Token: 0x0600011B RID: 283 RVA: 0x00004D68 File Offset: 0x00002F68
			public static short GetShortField(JniObjectReference instance, JniFieldInfo field)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				return NativeMethods.java_interop_jnienv_get_short_field(JniEnvironment.EnvironmentPointer, instance.Handle, field.ID);
			}

			// Token: 0x0600011C RID: 284 RVA: 0x00004DCC File Offset: 0x00002FCC
			public static int GetIntField(JniObjectReference instance, JniFieldInfo field)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				return NativeMethods.java_interop_jnienv_get_int_field(JniEnvironment.EnvironmentPointer, instance.Handle, field.ID);
			}

			// Token: 0x0600011D RID: 285 RVA: 0x00004E30 File Offset: 0x00003030
			public static long GetLongField(JniObjectReference instance, JniFieldInfo field)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				return NativeMethods.java_interop_jnienv_get_long_field(JniEnvironment.EnvironmentPointer, instance.Handle, field.ID);
			}

			// Token: 0x0600011E RID: 286 RVA: 0x00004E94 File Offset: 0x00003094
			public static float GetFloatField(JniObjectReference instance, JniFieldInfo field)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				return NativeMethods.java_interop_jnienv_get_float_field(JniEnvironment.EnvironmentPointer, instance.Handle, field.ID);
			}

			// Token: 0x0600011F RID: 287 RVA: 0x00004EF8 File Offset: 0x000030F8
			public static double GetDoubleField(JniObjectReference instance, JniFieldInfo field)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				return NativeMethods.java_interop_jnienv_get_double_field(JniEnvironment.EnvironmentPointer, instance.Handle, field.ID);
			}

			// Token: 0x06000120 RID: 288 RVA: 0x00004F5C File Offset: 0x0000315C
			public static void SetObjectField(JniObjectReference instance, JniFieldInfo field, JniObjectReference value)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				NativeMethods.java_interop_jnienv_set_object_field(JniEnvironment.EnvironmentPointer, instance.Handle, field.ID, value.Handle);
			}

			// Token: 0x06000121 RID: 289 RVA: 0x00004FC8 File Offset: 0x000031C8
			public static void SetBooleanField(JniObjectReference instance, JniFieldInfo field, bool value)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				NativeMethods.java_interop_jnienv_set_boolean_field(JniEnvironment.EnvironmentPointer, instance.Handle, field.ID, value ? 1 : 0);
			}

			// Token: 0x06000122 RID: 290 RVA: 0x00005034 File Offset: 0x00003234
			public static void SetByteField(JniObjectReference instance, JniFieldInfo field, sbyte value)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				NativeMethods.java_interop_jnienv_set_byte_field(JniEnvironment.EnvironmentPointer, instance.Handle, field.ID, value);
			}

			// Token: 0x06000123 RID: 291 RVA: 0x00005098 File Offset: 0x00003298
			public static void SetCharField(JniObjectReference instance, JniFieldInfo field, char value)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				NativeMethods.java_interop_jnienv_set_char_field(JniEnvironment.EnvironmentPointer, instance.Handle, field.ID, value);
			}

			// Token: 0x06000124 RID: 292 RVA: 0x000050FC File Offset: 0x000032FC
			public static void SetShortField(JniObjectReference instance, JniFieldInfo field, short value)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				NativeMethods.java_interop_jnienv_set_short_field(JniEnvironment.EnvironmentPointer, instance.Handle, field.ID, value);
			}

			// Token: 0x06000125 RID: 293 RVA: 0x00005160 File Offset: 0x00003360
			public static void SetIntField(JniObjectReference instance, JniFieldInfo field, int value)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				NativeMethods.java_interop_jnienv_set_int_field(JniEnvironment.EnvironmentPointer, instance.Handle, field.ID, value);
			}

			// Token: 0x06000126 RID: 294 RVA: 0x000051C4 File Offset: 0x000033C4
			public static void SetLongField(JniObjectReference instance, JniFieldInfo field, long value)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				NativeMethods.java_interop_jnienv_set_long_field(JniEnvironment.EnvironmentPointer, instance.Handle, field.ID, value);
			}

			// Token: 0x06000127 RID: 295 RVA: 0x00005228 File Offset: 0x00003428
			public static void SetFloatField(JniObjectReference instance, JniFieldInfo field, float value)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				NativeMethods.java_interop_jnienv_set_float_field(JniEnvironment.EnvironmentPointer, instance.Handle, field.ID, value);
			}

			// Token: 0x06000128 RID: 296 RVA: 0x0000528C File Offset: 0x0000348C
			public static void SetDoubleField(JniObjectReference instance, JniFieldInfo field, double value)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				NativeMethods.java_interop_jnienv_set_double_field(JniEnvironment.EnvironmentPointer, instance.Handle, field.ID, value);
			}
		}

		// Token: 0x02000019 RID: 25
		public static class InstanceMethods
		{
			// Token: 0x06000129 RID: 297 RVA: 0x000052F0 File Offset: 0x000034F0
			public static JniMethodInfo GetMethodID(JniObjectReference type, string name, string signature)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (name == null)
				{
					throw new ArgumentNullException("name");
				}
				if (signature == null)
				{
					throw new ArgumentNullException("signature");
				}
				IntPtr thrown;
				IntPtr intPtr = NativeMethods.java_interop_jnienv_get_method_id(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, name, signature);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				if (intPtr == IntPtr.Zero)
				{
					return null;
				}
				return new JniMethodInfo(name, signature, intPtr, false);
			}

			// Token: 0x0600012A RID: 298 RVA: 0x00005378 File Offset: 0x00003578
			public static JniObjectReference CallObjectMethod(JniObjectReference instance, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				IntPtr intPtr = NativeMethods.java_interop_jnienv_call_object_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x0600012B RID: 299 RVA: 0x00005400 File Offset: 0x00003600
			public unsafe static JniObjectReference CallObjectMethod(JniObjectReference instance, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				IntPtr intPtr = NativeMethods.java_interop_jnienv_call_object_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x0600012C RID: 300 RVA: 0x0000548C File Offset: 0x0000368C
			public static bool CallBooleanMethod(JniObjectReference instance, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				bool result = NativeMethods.java_interop_jnienv_call_boolean_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID) != 0;
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x0600012D RID: 301 RVA: 0x0000550C File Offset: 0x0000370C
			public unsafe static bool CallBooleanMethod(JniObjectReference instance, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				bool result = NativeMethods.java_interop_jnienv_call_boolean_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, (IntPtr)((void*)args)) != 0;
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x0600012E RID: 302 RVA: 0x00005594 File Offset: 0x00003794
			public static sbyte CallByteMethod(JniObjectReference instance, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				sbyte result = NativeMethods.java_interop_jnienv_call_byte_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x0600012F RID: 303 RVA: 0x00005610 File Offset: 0x00003810
			public unsafe static sbyte CallByteMethod(JniObjectReference instance, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				sbyte result = NativeMethods.java_interop_jnienv_call_byte_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000130 RID: 304 RVA: 0x00005690 File Offset: 0x00003890
			public static char CallCharMethod(JniObjectReference instance, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				char result = NativeMethods.java_interop_jnienv_call_char_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000131 RID: 305 RVA: 0x0000570C File Offset: 0x0000390C
			public unsafe static char CallCharMethod(JniObjectReference instance, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				char result = NativeMethods.java_interop_jnienv_call_char_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000132 RID: 306 RVA: 0x0000578C File Offset: 0x0000398C
			public static short CallShortMethod(JniObjectReference instance, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				short result = NativeMethods.java_interop_jnienv_call_short_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000133 RID: 307 RVA: 0x00005808 File Offset: 0x00003A08
			public unsafe static short CallShortMethod(JniObjectReference instance, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				short result = NativeMethods.java_interop_jnienv_call_short_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000134 RID: 308 RVA: 0x00005888 File Offset: 0x00003A88
			public static int CallIntMethod(JniObjectReference instance, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				int result = NativeMethods.java_interop_jnienv_call_int_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000135 RID: 309 RVA: 0x00005904 File Offset: 0x00003B04
			public unsafe static int CallIntMethod(JniObjectReference instance, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				int result = NativeMethods.java_interop_jnienv_call_int_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000136 RID: 310 RVA: 0x00005984 File Offset: 0x00003B84
			public static long CallLongMethod(JniObjectReference instance, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				long result = NativeMethods.java_interop_jnienv_call_long_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000137 RID: 311 RVA: 0x00005A00 File Offset: 0x00003C00
			public unsafe static long CallLongMethod(JniObjectReference instance, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				long result = NativeMethods.java_interop_jnienv_call_long_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000138 RID: 312 RVA: 0x00005A80 File Offset: 0x00003C80
			public static float CallFloatMethod(JniObjectReference instance, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				float result = NativeMethods.java_interop_jnienv_call_float_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000139 RID: 313 RVA: 0x00005AFC File Offset: 0x00003CFC
			public unsafe static float CallFloatMethod(JniObjectReference instance, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				float result = NativeMethods.java_interop_jnienv_call_float_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x0600013A RID: 314 RVA: 0x00005B7C File Offset: 0x00003D7C
			public static double CallDoubleMethod(JniObjectReference instance, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				double result = NativeMethods.java_interop_jnienv_call_double_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x0600013B RID: 315 RVA: 0x00005BF8 File Offset: 0x00003DF8
			public unsafe static double CallDoubleMethod(JniObjectReference instance, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				double result = NativeMethods.java_interop_jnienv_call_double_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x0600013C RID: 316 RVA: 0x00005C78 File Offset: 0x00003E78
			public static void CallVoidMethod(JniObjectReference instance, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_call_void_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x0600013D RID: 317 RVA: 0x00005CF4 File Offset: 0x00003EF4
			public unsafe static void CallVoidMethod(JniObjectReference instance, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_call_void_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x0600013E RID: 318 RVA: 0x00005D74 File Offset: 0x00003F74
			public static JniObjectReference CallNonvirtualObjectMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				IntPtr intPtr = NativeMethods.java_interop_jnienv_call_nonvirtual_object_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x0600013F RID: 319 RVA: 0x00005E1C File Offset: 0x0000401C
			public unsafe static JniObjectReference CallNonvirtualObjectMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				IntPtr intPtr = NativeMethods.java_interop_jnienv_call_nonvirtual_object_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x06000140 RID: 320 RVA: 0x00005EC8 File Offset: 0x000040C8
			public static bool CallNonvirtualBooleanMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				bool result = NativeMethods.java_interop_jnienv_call_nonvirtual_boolean_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID) != 0;
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000141 RID: 321 RVA: 0x00005F68 File Offset: 0x00004168
			public unsafe static bool CallNonvirtualBooleanMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				bool result = NativeMethods.java_interop_jnienv_call_nonvirtual_boolean_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, (IntPtr)((void*)args)) != 0;
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000142 RID: 322 RVA: 0x00006010 File Offset: 0x00004210
			public static sbyte CallNonvirtualByteMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				sbyte result = NativeMethods.java_interop_jnienv_call_nonvirtual_byte_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000143 RID: 323 RVA: 0x000060AC File Offset: 0x000042AC
			public unsafe static sbyte CallNonvirtualByteMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				sbyte result = NativeMethods.java_interop_jnienv_call_nonvirtual_byte_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000144 RID: 324 RVA: 0x0000614C File Offset: 0x0000434C
			public static char CallNonvirtualCharMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				char result = NativeMethods.java_interop_jnienv_call_nonvirtual_char_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000145 RID: 325 RVA: 0x000061E8 File Offset: 0x000043E8
			public unsafe static char CallNonvirtualCharMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				char result = NativeMethods.java_interop_jnienv_call_nonvirtual_char_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000146 RID: 326 RVA: 0x00006288 File Offset: 0x00004488
			public static short CallNonvirtualShortMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				short result = NativeMethods.java_interop_jnienv_call_nonvirtual_short_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000147 RID: 327 RVA: 0x00006324 File Offset: 0x00004524
			public unsafe static short CallNonvirtualShortMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				short result = NativeMethods.java_interop_jnienv_call_nonvirtual_short_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000148 RID: 328 RVA: 0x000063C4 File Offset: 0x000045C4
			public static int CallNonvirtualIntMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				int result = NativeMethods.java_interop_jnienv_call_nonvirtual_int_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000149 RID: 329 RVA: 0x00006460 File Offset: 0x00004660
			public unsafe static int CallNonvirtualIntMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				int result = NativeMethods.java_interop_jnienv_call_nonvirtual_int_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x0600014A RID: 330 RVA: 0x00006500 File Offset: 0x00004700
			public static long CallNonvirtualLongMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				long result = NativeMethods.java_interop_jnienv_call_nonvirtual_long_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x0600014B RID: 331 RVA: 0x0000659C File Offset: 0x0000479C
			public unsafe static long CallNonvirtualLongMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				long result = NativeMethods.java_interop_jnienv_call_nonvirtual_long_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x0600014C RID: 332 RVA: 0x0000663C File Offset: 0x0000483C
			public static float CallNonvirtualFloatMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				float result = NativeMethods.java_interop_jnienv_call_nonvirtual_float_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x0600014D RID: 333 RVA: 0x000066D8 File Offset: 0x000048D8
			public unsafe static float CallNonvirtualFloatMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				float result = NativeMethods.java_interop_jnienv_call_nonvirtual_float_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x0600014E RID: 334 RVA: 0x00006778 File Offset: 0x00004978
			public static double CallNonvirtualDoubleMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				double result = NativeMethods.java_interop_jnienv_call_nonvirtual_double_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x0600014F RID: 335 RVA: 0x00006814 File Offset: 0x00004A14
			public unsafe static double CallNonvirtualDoubleMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				double result = NativeMethods.java_interop_jnienv_call_nonvirtual_double_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000150 RID: 336 RVA: 0x000068B4 File Offset: 0x00004AB4
			public static void CallNonvirtualVoidMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_call_nonvirtual_void_method(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x06000151 RID: 337 RVA: 0x00006950 File Offset: 0x00004B50
			public unsafe static void CallNonvirtualVoidMethod(JniObjectReference instance, JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!instance.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "instance");
				}
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_call_nonvirtual_void_method_a(JniEnvironment.EnvironmentPointer, out thrown, instance.Handle, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}
		}

		// Token: 0x0200001A RID: 26
		public static class IO
		{
			// Token: 0x06000152 RID: 338 RVA: 0x000069F0 File Offset: 0x00004BF0
			public static JniObjectReference NewDirectByteBuffer(IntPtr address, long capacity)
			{
				if (address == IntPtr.Zero)
				{
					throw new ArgumentException("'address' must not be IntPtr.Zero.", "address");
				}
				IntPtr thrown;
				IntPtr intPtr = NativeMethods.java_interop_jnienv_new_direct_byte_buffer(JniEnvironment.EnvironmentPointer, out thrown, address, capacity);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x06000153 RID: 339 RVA: 0x00006A49 File Offset: 0x00004C49
			public static IntPtr GetDirectBufferAddress(JniObjectReference buffer)
			{
				if (!buffer.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "buffer");
				}
				return NativeMethods.java_interop_jnienv_get_direct_buffer_address(JniEnvironment.EnvironmentPointer, buffer.Handle);
			}

			// Token: 0x06000154 RID: 340 RVA: 0x00006A75 File Offset: 0x00004C75
			public static long GetDirectBufferCapacity(JniObjectReference buffer)
			{
				if (!buffer.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "buffer");
				}
				return NativeMethods.java_interop_jnienv_get_direct_buffer_capacity(JniEnvironment.EnvironmentPointer, buffer.Handle);
			}
		}

		// Token: 0x0200001B RID: 27
		public static class StaticFields
		{
			// Token: 0x06000155 RID: 341 RVA: 0x00006AA4 File Offset: 0x00004CA4
			public static JniFieldInfo GetStaticFieldID(JniObjectReference type, string name, string signature)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (name == null)
				{
					throw new ArgumentNullException("name");
				}
				if (signature == null)
				{
					throw new ArgumentNullException("signature");
				}
				IntPtr thrown;
				IntPtr intPtr = NativeMethods.java_interop_jnienv_get_static_field_id(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, name, signature);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				if (intPtr == IntPtr.Zero)
				{
					return null;
				}
				return new JniFieldInfo(name, signature, intPtr, true);
			}

			// Token: 0x06000156 RID: 342 RVA: 0x00006B2C File Offset: 0x00004D2C
			public static JniObjectReference GetStaticObjectField(JniObjectReference type, JniFieldInfo field)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				IntPtr intPtr = NativeMethods.java_interop_jnienv_get_static_object_field(JniEnvironment.EnvironmentPointer, type.Handle, field.ID);
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x06000157 RID: 343 RVA: 0x00006B9C File Offset: 0x00004D9C
			public static bool GetStaticBooleanField(JniObjectReference type, JniFieldInfo field)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				return NativeMethods.java_interop_jnienv_get_static_boolean_field(JniEnvironment.EnvironmentPointer, type.Handle, field.ID) != 0;
			}

			// Token: 0x06000158 RID: 344 RVA: 0x00006C04 File Offset: 0x00004E04
			public static sbyte GetStaticByteField(JniObjectReference type, JniFieldInfo field)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				return NativeMethods.java_interop_jnienv_get_static_byte_field(JniEnvironment.EnvironmentPointer, type.Handle, field.ID);
			}

			// Token: 0x06000159 RID: 345 RVA: 0x00006C68 File Offset: 0x00004E68
			public static char GetStaticCharField(JniObjectReference type, JniFieldInfo field)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				return NativeMethods.java_interop_jnienv_get_static_char_field(JniEnvironment.EnvironmentPointer, type.Handle, field.ID);
			}

			// Token: 0x0600015A RID: 346 RVA: 0x00006CCC File Offset: 0x00004ECC
			public static short GetStaticShortField(JniObjectReference type, JniFieldInfo field)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				return NativeMethods.java_interop_jnienv_get_static_short_field(JniEnvironment.EnvironmentPointer, type.Handle, field.ID);
			}

			// Token: 0x0600015B RID: 347 RVA: 0x00006D30 File Offset: 0x00004F30
			public static int GetStaticIntField(JniObjectReference type, JniFieldInfo field)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				return NativeMethods.java_interop_jnienv_get_static_int_field(JniEnvironment.EnvironmentPointer, type.Handle, field.ID);
			}

			// Token: 0x0600015C RID: 348 RVA: 0x00006D94 File Offset: 0x00004F94
			public static long GetStaticLongField(JniObjectReference type, JniFieldInfo field)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				return NativeMethods.java_interop_jnienv_get_static_long_field(JniEnvironment.EnvironmentPointer, type.Handle, field.ID);
			}

			// Token: 0x0600015D RID: 349 RVA: 0x00006DF8 File Offset: 0x00004FF8
			public static float GetStaticFloatField(JniObjectReference type, JniFieldInfo field)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				return NativeMethods.java_interop_jnienv_get_static_float_field(JniEnvironment.EnvironmentPointer, type.Handle, field.ID);
			}

			// Token: 0x0600015E RID: 350 RVA: 0x00006E5C File Offset: 0x0000505C
			public static double GetStaticDoubleField(JniObjectReference type, JniFieldInfo field)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				return NativeMethods.java_interop_jnienv_get_static_double_field(JniEnvironment.EnvironmentPointer, type.Handle, field.ID);
			}

			// Token: 0x0600015F RID: 351 RVA: 0x00006EC0 File Offset: 0x000050C0
			public static void SetStaticObjectField(JniObjectReference type, JniFieldInfo field, JniObjectReference value)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				NativeMethods.java_interop_jnienv_set_static_object_field(JniEnvironment.EnvironmentPointer, type.Handle, field.ID, value.Handle);
			}

			// Token: 0x06000160 RID: 352 RVA: 0x00006F2C File Offset: 0x0000512C
			public static void SetStaticBooleanField(JniObjectReference type, JniFieldInfo field, bool value)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				NativeMethods.java_interop_jnienv_set_static_boolean_field(JniEnvironment.EnvironmentPointer, type.Handle, field.ID, value ? 1 : 0);
			}

			// Token: 0x06000161 RID: 353 RVA: 0x00006F98 File Offset: 0x00005198
			public static void SetStaticByteField(JniObjectReference type, JniFieldInfo field, sbyte value)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				NativeMethods.java_interop_jnienv_set_static_byte_field(JniEnvironment.EnvironmentPointer, type.Handle, field.ID, value);
			}

			// Token: 0x06000162 RID: 354 RVA: 0x00006FFC File Offset: 0x000051FC
			public static void SetStaticCharField(JniObjectReference type, JniFieldInfo field, char value)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				NativeMethods.java_interop_jnienv_set_static_char_field(JniEnvironment.EnvironmentPointer, type.Handle, field.ID, value);
			}

			// Token: 0x06000163 RID: 355 RVA: 0x00007060 File Offset: 0x00005260
			public static void SetStaticShortField(JniObjectReference type, JniFieldInfo field, short value)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				NativeMethods.java_interop_jnienv_set_static_short_field(JniEnvironment.EnvironmentPointer, type.Handle, field.ID, value);
			}

			// Token: 0x06000164 RID: 356 RVA: 0x000070C4 File Offset: 0x000052C4
			public static void SetStaticIntField(JniObjectReference type, JniFieldInfo field, int value)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				NativeMethods.java_interop_jnienv_set_static_int_field(JniEnvironment.EnvironmentPointer, type.Handle, field.ID, value);
			}

			// Token: 0x06000165 RID: 357 RVA: 0x00007128 File Offset: 0x00005328
			public static void SetStaticLongField(JniObjectReference type, JniFieldInfo field, long value)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				NativeMethods.java_interop_jnienv_set_static_long_field(JniEnvironment.EnvironmentPointer, type.Handle, field.ID, value);
			}

			// Token: 0x06000166 RID: 358 RVA: 0x0000718C File Offset: 0x0000538C
			public static void SetStaticFloatField(JniObjectReference type, JniFieldInfo field, float value)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				NativeMethods.java_interop_jnienv_set_static_float_field(JniEnvironment.EnvironmentPointer, type.Handle, field.ID, value);
			}

			// Token: 0x06000167 RID: 359 RVA: 0x000071F0 File Offset: 0x000053F0
			public static void SetStaticDoubleField(JniObjectReference type, JniFieldInfo field, double value)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (field == null)
				{
					throw new ArgumentNullException("field");
				}
				if (!field.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "field");
				}
				NativeMethods.java_interop_jnienv_set_static_double_field(JniEnvironment.EnvironmentPointer, type.Handle, field.ID, value);
			}
		}

		// Token: 0x0200001C RID: 28
		public static class StaticMethods
		{
			// Token: 0x06000168 RID: 360 RVA: 0x00007254 File Offset: 0x00005454
			public static JniMethodInfo GetStaticMethodID(JniObjectReference type, string name, string signature)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (name == null)
				{
					throw new ArgumentNullException("name");
				}
				if (signature == null)
				{
					throw new ArgumentNullException("signature");
				}
				IntPtr thrown;
				IntPtr intPtr = NativeMethods.java_interop_jnienv_get_static_method_id(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, name, signature);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				if (intPtr == IntPtr.Zero)
				{
					return null;
				}
				return new JniMethodInfo(name, signature, intPtr, true);
			}

			// Token: 0x06000169 RID: 361 RVA: 0x000072DC File Offset: 0x000054DC
			public static JniObjectReference CallStaticObjectMethod(JniObjectReference type, JniMethodInfo method)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				IntPtr intPtr = NativeMethods.java_interop_jnienv_call_static_object_method(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x0600016A RID: 362 RVA: 0x00007364 File Offset: 0x00005564
			public unsafe static JniObjectReference CallStaticObjectMethod(JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				IntPtr intPtr = NativeMethods.java_interop_jnienv_call_static_object_method_a(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				JniEnvironment.LogCreateLocalRef(intPtr);
				return new JniObjectReference(intPtr, JniObjectReferenceType.Local);
			}

			// Token: 0x0600016B RID: 363 RVA: 0x000073F0 File Offset: 0x000055F0
			public static bool CallStaticBooleanMethod(JniObjectReference type, JniMethodInfo method)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				bool result = NativeMethods.java_interop_jnienv_call_static_boolean_method(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID) != 0;
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x0600016C RID: 364 RVA: 0x00007470 File Offset: 0x00005670
			public unsafe static bool CallStaticBooleanMethod(JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				bool result = NativeMethods.java_interop_jnienv_call_static_boolean_method_a(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, (IntPtr)((void*)args)) != 0;
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x0600016D RID: 365 RVA: 0x000074F8 File Offset: 0x000056F8
			public static sbyte CallStaticByteMethod(JniObjectReference type, JniMethodInfo method)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				sbyte result = NativeMethods.java_interop_jnienv_call_static_byte_method(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x0600016E RID: 366 RVA: 0x00007574 File Offset: 0x00005774
			public unsafe static sbyte CallStaticByteMethod(JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				sbyte result = NativeMethods.java_interop_jnienv_call_static_byte_method_a(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x0600016F RID: 367 RVA: 0x000075F4 File Offset: 0x000057F4
			public static char CallStaticCharMethod(JniObjectReference type, JniMethodInfo method)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				char result = NativeMethods.java_interop_jnienv_call_static_char_method(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000170 RID: 368 RVA: 0x00007670 File Offset: 0x00005870
			public unsafe static char CallStaticCharMethod(JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				char result = NativeMethods.java_interop_jnienv_call_static_char_method_a(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000171 RID: 369 RVA: 0x000076F0 File Offset: 0x000058F0
			public static short CallStaticShortMethod(JniObjectReference type, JniMethodInfo method)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				short result = NativeMethods.java_interop_jnienv_call_static_short_method(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000172 RID: 370 RVA: 0x0000776C File Offset: 0x0000596C
			public unsafe static short CallStaticShortMethod(JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				short result = NativeMethods.java_interop_jnienv_call_static_short_method_a(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000173 RID: 371 RVA: 0x000077EC File Offset: 0x000059EC
			public static int CallStaticIntMethod(JniObjectReference type, JniMethodInfo method)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				int result = NativeMethods.java_interop_jnienv_call_static_int_method(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000174 RID: 372 RVA: 0x00007868 File Offset: 0x00005A68
			public unsafe static int CallStaticIntMethod(JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				int result = NativeMethods.java_interop_jnienv_call_static_int_method_a(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000175 RID: 373 RVA: 0x000078E8 File Offset: 0x00005AE8
			public static long CallStaticLongMethod(JniObjectReference type, JniMethodInfo method)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				long result = NativeMethods.java_interop_jnienv_call_static_long_method(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000176 RID: 374 RVA: 0x00007964 File Offset: 0x00005B64
			public unsafe static long CallStaticLongMethod(JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				long result = NativeMethods.java_interop_jnienv_call_static_long_method_a(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000177 RID: 375 RVA: 0x000079E4 File Offset: 0x00005BE4
			public static float CallStaticFloatMethod(JniObjectReference type, JniMethodInfo method)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				float result = NativeMethods.java_interop_jnienv_call_static_float_method(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000178 RID: 376 RVA: 0x00007A60 File Offset: 0x00005C60
			public unsafe static float CallStaticFloatMethod(JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				float result = NativeMethods.java_interop_jnienv_call_static_float_method_a(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x06000179 RID: 377 RVA: 0x00007AE0 File Offset: 0x00005CE0
			public static double CallStaticDoubleMethod(JniObjectReference type, JniMethodInfo method)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				double result = NativeMethods.java_interop_jnienv_call_static_double_method(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x0600017A RID: 378 RVA: 0x00007B5C File Offset: 0x00005D5C
			public unsafe static double CallStaticDoubleMethod(JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				double result = NativeMethods.java_interop_jnienv_call_static_double_method_a(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
				return result;
			}

			// Token: 0x0600017B RID: 379 RVA: 0x00007BDC File Offset: 0x00005DDC
			public static void CallStaticVoidMethod(JniObjectReference type, JniMethodInfo method)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_call_static_void_method(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID);
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}

			// Token: 0x0600017C RID: 380 RVA: 0x00007C58 File Offset: 0x00005E58
			public unsafe static void CallStaticVoidMethod(JniObjectReference type, JniMethodInfo method, JniArgumentValue* args)
			{
				if (!type.IsValid)
				{
					throw new ArgumentException("Handle must be valid.", "type");
				}
				if (method == null)
				{
					throw new ArgumentNullException("method");
				}
				if (!method.IsValid)
				{
					throw new ArgumentException("Handle value is not valid.", "method");
				}
				IntPtr thrown;
				NativeMethods.java_interop_jnienv_call_static_void_method_a(JniEnvironment.EnvironmentPointer, out thrown, type.Handle, method.ID, (IntPtr)((void*)args));
				Exception exceptionForLastThrowable = JniEnvironment.GetExceptionForLastThrowable(thrown);
				if (exceptionForLastThrowable != null)
				{
					ExceptionDispatchInfo.Capture(exceptionForLastThrowable).Throw();
				}
			}
		}
	}
}
