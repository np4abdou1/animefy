using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang.Reflect
{
	// Token: 0x020003FD RID: 1021
	[Register("java/lang/reflect/Executable", DoNotGenerateAcw = true, ApiSince = 26)]
	internal class ExecutableInvoker : Executable
	{
		// Token: 0x06002CFB RID: 11515 RVA: 0x0007BD83 File Offset: 0x00079F83
		public ExecutableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06002CFC RID: 11516 RVA: 0x0007BD8D File Offset: 0x00079F8D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExecutableInvoker._members;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06002CFD RID: 11517 RVA: 0x0007BD94 File Offset: 0x00079F94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExecutableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06002CFE RID: 11518 RVA: 0x0007BDA0 File Offset: 0x00079FA0
		public override Class DeclaringClass
		{
			get
			{
				return Object.GetObject<Class>(ExecutableInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getDeclaringClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06002CFF RID: 11519 RVA: 0x0007BDD2 File Offset: 0x00079FD2
		public override int Modifiers
		{
			get
			{
				return ExecutableInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getModifiers.()I", this, null);
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06002D00 RID: 11520 RVA: 0x0007BDEC File Offset: 0x00079FEC
		public override string Name
		{
			get
			{
				return JNIEnv.GetString(ExecutableInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x0007BE20 File Offset: 0x0007A020
		public override ITypeVariable[] GetTypeParameters()
		{
			return (ITypeVariable[])JNIEnv.GetArray(ExecutableInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getTypeParameters.()[Ljava/lang/reflect/TypeVariable;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ITypeVariable));
		}

		// Token: 0x040011C2 RID: 4546
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/reflect/Executable", typeof(ExecutableInvoker));
	}
}
