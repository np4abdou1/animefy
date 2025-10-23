using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000DB RID: 219
	[Register("com/google/android/datatransport/runtime/dagger/internal/DaggerCollections", DoNotGenerateAcw = true)]
	public sealed class DaggerCollections : Java.Lang.Object
	{
		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00015BB0 File Offset: 0x00013DB0
		internal static IntPtr class_ref
		{
			get
			{
				return DaggerCollections._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00015BD4 File Offset: 0x00013DD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DaggerCollections._members;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00015BDC File Offset: 0x00013DDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DaggerCollections._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00015C00 File Offset: 0x00013E00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DaggerCollections._members.ManagedPeerType;
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x000026C4 File Offset: 0x000008C4
		internal DaggerCollections(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00015C0C File Offset: 0x00013E0C
		[Register("hasDuplicates", "(Ljava/util/List;)Z", "")]
		public unsafe static bool HasDuplicates(IList<object> list)
		{
			IntPtr intPtr = JavaList<object>.ToLocalJniHandle(list);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = DaggerCollections._members.StaticMethods.InvokeBooleanMethod("hasDuplicates.(Ljava/util/List;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(list);
			}
			return result;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00015C70 File Offset: 0x00013E70
		[Register("newLinkedHashMapWithExpectedSize", "(I)Ljava/util/LinkedHashMap;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static LinkedHashMap NewLinkedHashMapWithExpectedSize(int expectedSize)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(expectedSize);
			return Java.Lang.Object.GetObject<LinkedHashMap>(DaggerCollections._members.StaticMethods.InvokeObjectMethod("newLinkedHashMapWithExpectedSize.(I)Ljava/util/LinkedHashMap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00015CB8 File Offset: 0x00013EB8
		[Register("presizedList", "(I)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList PresizedList(int size)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			return JavaList.FromJniHandle(DaggerCollections._members.StaticMethods.InvokeObjectMethod("presizedList.(I)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400022B RID: 555
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/DaggerCollections", typeof(DaggerCollections));
	}
}
