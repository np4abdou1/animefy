using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000040 RID: 64
	[Register("com/google/errorprone/annotations/Modifier", DoNotGenerateAcw = true)]
	public sealed class Modifier : Java.Lang.Enum
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00007094 File Offset: 0x00005294
		[Register("ABSTRACT")]
		public static Modifier Abstract
		{
			get
			{
				return Java.Lang.Object.GetObject<Modifier>(Modifier._members.StaticFields.GetObjectValue("ABSTRACT.Lcom/google/errorprone/annotations/Modifier;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000237 RID: 567 RVA: 0x000070C4 File Offset: 0x000052C4
		[Register("DEFAULT")]
		public static Modifier Default
		{
			get
			{
				return Java.Lang.Object.GetObject<Modifier>(Modifier._members.StaticFields.GetObjectValue("DEFAULT.Lcom/google/errorprone/annotations/Modifier;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000238 RID: 568 RVA: 0x000070F4 File Offset: 0x000052F4
		[Register("FINAL")]
		public static Modifier Final
		{
			get
			{
				return Java.Lang.Object.GetObject<Modifier>(Modifier._members.StaticFields.GetObjectValue("FINAL.Lcom/google/errorprone/annotations/Modifier;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00007124 File Offset: 0x00005324
		[Register("NATIVE")]
		public static Modifier Native
		{
			get
			{
				return Java.Lang.Object.GetObject<Modifier>(Modifier._members.StaticFields.GetObjectValue("NATIVE.Lcom/google/errorprone/annotations/Modifier;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00007154 File Offset: 0x00005354
		[Register("PRIVATE")]
		public static Modifier Private
		{
			get
			{
				return Java.Lang.Object.GetObject<Modifier>(Modifier._members.StaticFields.GetObjectValue("PRIVATE.Lcom/google/errorprone/annotations/Modifier;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00007184 File Offset: 0x00005384
		[Register("PROTECTED")]
		public static Modifier Protected
		{
			get
			{
				return Java.Lang.Object.GetObject<Modifier>(Modifier._members.StaticFields.GetObjectValue("PROTECTED.Lcom/google/errorprone/annotations/Modifier;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600023C RID: 572 RVA: 0x000071B4 File Offset: 0x000053B4
		[Register("PUBLIC")]
		public static Modifier Public
		{
			get
			{
				return Java.Lang.Object.GetObject<Modifier>(Modifier._members.StaticFields.GetObjectValue("PUBLIC.Lcom/google/errorprone/annotations/Modifier;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600023D RID: 573 RVA: 0x000071E4 File Offset: 0x000053E4
		[Register("STATIC")]
		public static Modifier Static
		{
			get
			{
				return Java.Lang.Object.GetObject<Modifier>(Modifier._members.StaticFields.GetObjectValue("STATIC.Lcom/google/errorprone/annotations/Modifier;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00007214 File Offset: 0x00005414
		[Register("STRICTFP")]
		public static Modifier Strictfp
		{
			get
			{
				return Java.Lang.Object.GetObject<Modifier>(Modifier._members.StaticFields.GetObjectValue("STRICTFP.Lcom/google/errorprone/annotations/Modifier;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00007244 File Offset: 0x00005444
		[Register("SYNCHRONIZED")]
		public static Modifier Synchronized
		{
			get
			{
				return Java.Lang.Object.GetObject<Modifier>(Modifier._members.StaticFields.GetObjectValue("SYNCHRONIZED.Lcom/google/errorprone/annotations/Modifier;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00007274 File Offset: 0x00005474
		[Register("TRANSIENT")]
		public static Modifier Transient
		{
			get
			{
				return Java.Lang.Object.GetObject<Modifier>(Modifier._members.StaticFields.GetObjectValue("TRANSIENT.Lcom/google/errorprone/annotations/Modifier;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000241 RID: 577 RVA: 0x000072A4 File Offset: 0x000054A4
		[Register("VOLATILE")]
		public static Modifier Volatile
		{
			get
			{
				return Java.Lang.Object.GetObject<Modifier>(Modifier._members.StaticFields.GetObjectValue("VOLATILE.Lcom/google/errorprone/annotations/Modifier;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000242 RID: 578 RVA: 0x000072D4 File Offset: 0x000054D4
		internal static IntPtr class_ref
		{
			get
			{
				return Modifier._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000243 RID: 579 RVA: 0x000072F8 File Offset: 0x000054F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Modifier._members;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00007300 File Offset: 0x00005500
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Modifier._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00007324 File Offset: 0x00005524
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Modifier._members.ManagedPeerType;
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00007330 File Offset: 0x00005530
		internal Modifier(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000733C File Offset: 0x0000553C
		[Register("valueOf", "(Ljava/lang/String;)Lcom/google/errorprone/annotations/Modifier;", "")]
		public unsafe static Modifier ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			Modifier @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Modifier>(Modifier._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/google/errorprone/annotations/Modifier;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000073A8 File Offset: 0x000055A8
		[Register("values", "()[Lcom/google/errorprone/annotations/Modifier;", "")]
		public static Modifier[] Values()
		{
			return (Modifier[])JNIEnv.GetArray(Modifier._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/google/errorprone/annotations/Modifier;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Modifier));
		}

		// Token: 0x04000103 RID: 259
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/Modifier", typeof(Modifier));
	}
}
