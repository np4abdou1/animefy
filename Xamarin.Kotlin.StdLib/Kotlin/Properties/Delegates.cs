using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.Properties
{
	// Token: 0x02000143 RID: 323
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/properties/Delegates", DoNotGenerateAcw = true)]
	public sealed class Delegates : Java.Lang.Object
	{
		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x000391C8 File Offset: 0x000373C8
		[Register("INSTANCE")]
		public static Delegates Instance
		{
			get
			{
				return Java.Lang.Object.GetObject<Delegates>(Delegates._members.StaticFields.GetObjectValue("INSTANCE.Lkotlin/properties/Delegates;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x000391F8 File Offset: 0x000373F8
		internal static IntPtr class_ref
		{
			get
			{
				return Delegates._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x0003921C File Offset: 0x0003741C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Delegates._members;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x00039224 File Offset: 0x00037424
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Delegates._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x00039248 File Offset: 0x00037448
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Delegates._members.ManagedPeerType;
			}
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00039254 File Offset: 0x00037454
		internal Delegates(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00039260 File Offset: 0x00037460
		[Register("notNull", "()Lkotlin/properties/ReadWriteProperty;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public IReadWriteProperty NotNull()
		{
			return Java.Lang.Object.GetObject<IReadWriteProperty>(Delegates._members.InstanceMethods.InvokeNonvirtualObjectMethod("notNull.()Lkotlin/properties/ReadWriteProperty;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00039294 File Offset: 0x00037494
		[Register("observable", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Lkotlin/properties/ReadWriteProperty;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe IReadWriteProperty Observable([Nullable(2)] Java.Lang.Object initialValue, IFunction3 onChange)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initialValue);
			IReadWriteProperty @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((onChange == null) ? IntPtr.Zero : ((Java.Lang.Object)onChange).Handle);
				@object = Java.Lang.Object.GetObject<IReadWriteProperty>(Delegates._members.InstanceMethods.InvokeNonvirtualObjectMethod("observable.(Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Lkotlin/properties/ReadWriteProperty;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(initialValue);
				GC.KeepAlive(onChange);
			}
			return @object;
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00039334 File Offset: 0x00037534
		[Register("vetoable", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Lkotlin/properties/ReadWriteProperty;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe IReadWriteProperty Vetoable([Nullable(2)] Java.Lang.Object initialValue, IFunction3 onChange)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initialValue);
			IReadWriteProperty @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((onChange == null) ? IntPtr.Zero : ((Java.Lang.Object)onChange).Handle);
				@object = Java.Lang.Object.GetObject<IReadWriteProperty>(Delegates._members.InstanceMethods.InvokeNonvirtualObjectMethod("vetoable.(Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Lkotlin/properties/ReadWriteProperty;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(initialValue);
				GC.KeepAlive(onChange);
			}
			return @object;
		}

		// Token: 0x04000586 RID: 1414
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/properties/Delegates", typeof(Delegates));
	}
}
