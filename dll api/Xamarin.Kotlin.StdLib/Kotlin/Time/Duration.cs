using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Internal;

namespace Kotlin.Time
{
	// Token: 0x020000BF RID: 191
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/Duration", DoNotGenerateAcw = true)]
	public sealed class Duration : Java.Lang.Object, Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x0000D7F8 File Offset: 0x0000B9F8
		[Register("Companion")]
		public static Duration.CompanionStatic Companion
		{
			get
			{
				return Java.Lang.Object.GetObject<Duration.CompanionStatic>(Duration._members.StaticFields.GetObjectValue("Companion.Lkotlin/time/Duration$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x0000D828 File Offset: 0x0000BA28
		internal static IntPtr class_ref
		{
			get
			{
				return Duration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x0000D84C File Offset: 0x0000BA4C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Duration._members;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0000D854 File Offset: 0x0000BA54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Duration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x0000D878 File Offset: 0x0000BA78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Duration._members.ManagedPeerType;
			}
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0000D884 File Offset: 0x0000BA84
		internal Duration(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0000D890 File Offset: 0x0000BA90
		[Register("compareTo-LRDsOJo", "(J)I", "")]
		public unsafe int CompareTo(long other)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(other);
			return Duration._members.InstanceMethods.InvokeNonvirtualInt32Method("compareTo-LRDsOJo.(J)I", this, ptr);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0000D8CC File Offset: 0x0000BACC
		[Register("compareTo-LRDsOJo", "(JJ)I", "")]
		public unsafe static int CompareTo(long arg0, long other)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(arg0);
			ptr[1] = new JniArgumentValue(other);
			return Duration._members.StaticMethods.InvokeInt32Method("compareTo-LRDsOJo.(JJ)I", ptr);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0000D91C File Offset: 0x0000BB1C
		[Register("div-LRDsOJo", "(JJ)D", "")]
		public unsafe static double Div(long arg0, long other)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(arg0);
			ptr[1] = new JniArgumentValue(other);
			return Duration._members.StaticMethods.InvokeDoubleMethod("div-LRDsOJo.(JJ)D", ptr);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0000D96C File Offset: 0x0000BB6C
		[Register("div-UwyO8pc", "(JD)J", "")]
		public unsafe static long Div(long arg0, double scale)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(arg0);
			ptr[1] = new JniArgumentValue(scale);
			return Duration._members.StaticMethods.InvokeInt64Method("div-UwyO8pc.(JD)J", ptr);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0000D9BC File Offset: 0x0000BBBC
		[Register("div-UwyO8pc", "(JI)J", "")]
		public unsafe static long Div(long arg0, int scale)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(arg0);
			ptr[1] = new JniArgumentValue(scale);
			return Duration._members.StaticMethods.InvokeInt64Method("div-UwyO8pc.(JI)J", ptr);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0000DA0C File Offset: 0x0000BC0C
		[Register("getAbsoluteValue-UwyO8pc", "(J)J", "")]
		public unsafe static long GetAbsoluteValue(long arg0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(arg0);
			return Duration._members.StaticMethods.InvokeInt64Method("getAbsoluteValue-UwyO8pc.(J)J", ptr);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0000DA48 File Offset: 0x0000BC48
		[Register("minus-LRDsOJo", "(JJ)J", "")]
		public unsafe static long Minus(long arg0, long other)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(arg0);
			ptr[1] = new JniArgumentValue(other);
			return Duration._members.StaticMethods.InvokeInt64Method("minus-LRDsOJo.(JJ)J", ptr);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0000DA98 File Offset: 0x0000BC98
		[Register("plus-LRDsOJo", "(JJ)J", "")]
		public unsafe static long Plus(long arg0, long other)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(arg0);
			ptr[1] = new JniArgumentValue(other);
			return Duration._members.StaticMethods.InvokeInt64Method("plus-LRDsOJo.(JJ)J", ptr);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
		[Register("times-UwyO8pc", "(JD)J", "")]
		public unsafe static long Times(long arg0, double scale)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(arg0);
			ptr[1] = new JniArgumentValue(scale);
			return Duration._members.StaticMethods.InvokeInt64Method("times-UwyO8pc.(JD)J", ptr);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0000DB38 File Offset: 0x0000BD38
		[Register("times-UwyO8pc", "(JI)J", "")]
		public unsafe static long Times(long arg0, int scale)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(arg0);
			ptr[1] = new JniArgumentValue(scale);
			return Duration._members.StaticMethods.InvokeInt64Method("times-UwyO8pc.(JI)J", ptr);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0000DB88 File Offset: 0x0000BD88
		[Register("unaryMinus-UwyO8pc", "(J)J", "")]
		public unsafe static long UnaryMinus(long arg0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(arg0);
			return Duration._members.StaticMethods.InvokeInt64Method("unaryMinus-UwyO8pc.(J)J", ptr);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0000DBC4 File Offset: 0x0000BDC4
		[NullableContext(2)]
		[Register("compareTo", "(Ljava/lang/Object;)I", "")]
		public unsafe int CompareTo(Java.Lang.Object p0)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = Duration._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x04000187 RID: 391
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/Duration", typeof(Duration));

		// Token: 0x020002DD RID: 733
		[Nullable(0)]
		[Register("kotlin/time/Duration$Companion", DoNotGenerateAcw = true)]
		public sealed class CompanionStatic : Java.Lang.Object
		{
			// Token: 0x170009FA RID: 2554
			// (get) Token: 0x0600293F RID: 10559 RVA: 0x000B7724 File Offset: 0x000B5924
			internal static IntPtr class_ref
			{
				get
				{
					return Duration.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170009FB RID: 2555
			// (get) Token: 0x06002940 RID: 10560 RVA: 0x000B7748 File Offset: 0x000B5948
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Duration.CompanionStatic._members;
				}
			}

			// Token: 0x170009FC RID: 2556
			// (get) Token: 0x06002941 RID: 10561 RVA: 0x000B7750 File Offset: 0x000B5950
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Duration.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170009FD RID: 2557
			// (get) Token: 0x06002942 RID: 10562 RVA: 0x000B7774 File Offset: 0x000B5974
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Duration.CompanionStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x06002943 RID: 10563 RVA: 0x000B7780 File Offset: 0x000B5980
			internal CompanionStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002944 RID: 10564 RVA: 0x000B778C File Offset: 0x000B598C
			[NullableContext(2)]
			[Register(".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
			public unsafe CompanionStatic(DefaultConstructorMarker _constructor_marker) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((_constructor_marker == null) ? IntPtr.Zero : _constructor_marker.Handle);
					base.SetHandle(Duration.CompanionStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					Duration.CompanionStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x170009FE RID: 2558
			// (get) Token: 0x06002945 RID: 10565 RVA: 0x000B783C File Offset: 0x000B5A3C
			public long INFINITE_UwyO8pc
			{
				[Register("getINFINITE-UwyO8pc", "()J", "")]
				get
				{
					return Duration.CompanionStatic._members.InstanceMethods.InvokeNonvirtualInt64Method("getINFINITE-UwyO8pc.()J", this, null);
				}
			}

			// Token: 0x170009FF RID: 2559
			// (get) Token: 0x06002946 RID: 10566 RVA: 0x000B7855 File Offset: 0x000B5A55
			public long ZERO_UwyO8pc
			{
				[Register("getZERO-UwyO8pc", "()J", "")]
				get
				{
					return Duration.CompanionStatic._members.InstanceMethods.InvokeNonvirtualInt64Method("getZERO-UwyO8pc.()J", this, null);
				}
			}

			// Token: 0x06002947 RID: 10567 RVA: 0x000B7870 File Offset: 0x000B5A70
			[Register("convert", "(DLkotlin/time/DurationUnit;Lkotlin/time/DurationUnit;)D", "")]
			public unsafe double Convert(double value, DurationUnit sourceUnit, DurationUnit targetUnit)
			{
				double result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(value);
					ptr[1] = new JniArgumentValue((sourceUnit == null) ? IntPtr.Zero : sourceUnit.Handle);
					ptr[2] = new JniArgumentValue((targetUnit == null) ? IntPtr.Zero : targetUnit.Handle);
					result = Duration.CompanionStatic._members.InstanceMethods.InvokeNonvirtualDoubleMethod("convert.(DLkotlin/time/DurationUnit;Lkotlin/time/DurationUnit;)D", this, ptr);
				}
				finally
				{
					GC.KeepAlive(sourceUnit);
					GC.KeepAlive(targetUnit);
				}
				return result;
			}

			// Token: 0x06002948 RID: 10568 RVA: 0x000B7914 File Offset: 0x000B5B14
			[Register("parse-UwyO8pc", "(Ljava/lang/String;)J", "")]
			public unsafe long Parse_UwyO8pc(string value)
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				long result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					result = Duration.CompanionStatic._members.InstanceMethods.InvokeNonvirtualInt64Method("parse-UwyO8pc.(Ljava/lang/String;)J", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return result;
			}

			// Token: 0x06002949 RID: 10569 RVA: 0x000B7974 File Offset: 0x000B5B74
			[Register("parseIsoString-UwyO8pc", "(Ljava/lang/String;)J", "")]
			public unsafe long ParseIsoString_UwyO8pc(string value)
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				long result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					result = Duration.CompanionStatic._members.InstanceMethods.InvokeNonvirtualInt64Method("parseIsoString-UwyO8pc.(Ljava/lang/String;)J", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return result;
			}

			// Token: 0x0600294A RID: 10570 RVA: 0x000B79D4 File Offset: 0x000B5BD4
			[Register("parseIsoStringOrNull-FghU774", "(Ljava/lang/String;)Lkotlin/time/Duration;", "")]
			[return: Nullable(2)]
			public unsafe Duration ParseIsoStringOrNull_FghU774(string value)
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				Duration @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<Duration>(Duration.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("parseIsoStringOrNull-FghU774.(Ljava/lang/String;)Lkotlin/time/Duration;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0600294B RID: 10571 RVA: 0x000B7A40 File Offset: 0x000B5C40
			[Register("parseOrNull-FghU774", "(Ljava/lang/String;)Lkotlin/time/Duration;", "")]
			[return: Nullable(2)]
			public unsafe Duration ParseOrNull_FghU774(string value)
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				Duration @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<Duration>(Duration.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("parseOrNull-FghU774.(Ljava/lang/String;)Lkotlin/time/Duration;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x040009D4 RID: 2516
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/Duration$Companion", typeof(Duration.CompanionStatic));
		}
	}
}
