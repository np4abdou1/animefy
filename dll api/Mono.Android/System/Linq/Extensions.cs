using System;
using System.Collections;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Util;

namespace System.Linq
{
	// Token: 0x02000093 RID: 147
	public static class Extensions
	{
		// Token: 0x06000252 RID: 594 RVA: 0x0000287B File Offset: 0x00000A7B
		static Extensions()
		{
			IntPtr intPtr = JNIEnv.FindClass("java/util/Iterator");
			Extensions.id_next = JNIEnv.GetMethodID(intPtr, "next", "()Ljava/lang/Object;");
			JNIEnv.DeleteGlobalRef(intPtr);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000028A1 File Offset: 0x00000AA1
		internal static IEnumerator ToEnumerator_Dispose(this IIterator source)
		{
			using (source)
			{
				while (source.HasNext)
				{
					yield return JavaConvert.FromJniHandle(JNIEnv.CallObjectMethod(source.Handle, Extensions.id_next), JniHandleOwnership.TransferLocalRef, null);
				}
			}
			IIterator iterator = null;
			yield break;
			yield break;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000028B0 File Offset: 0x00000AB0
		internal static IEnumerator<T> ToEnumerator_Dispose<T>(this IIterator source)
		{
			using (source)
			{
				while (source.HasNext)
				{
					yield return JavaConvert.FromJniHandle<T>(JNIEnv.CallObjectMethod(source.Handle, Extensions.id_next), JniHandleOwnership.TransferLocalRef);
				}
			}
			IIterator iterator = null;
			yield break;
			yield break;
		}

		// Token: 0x04000012 RID: 18
		private static IntPtr id_next;
	}
}
