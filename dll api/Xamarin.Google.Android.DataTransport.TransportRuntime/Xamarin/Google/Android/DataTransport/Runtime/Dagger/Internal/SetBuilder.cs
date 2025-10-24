using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000F1 RID: 241
	[Register("com/google/android/datatransport/runtime/dagger/internal/SetBuilder", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public sealed class SetBuilder : Java.Lang.Object
	{
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x00017A34 File Offset: 0x00015C34
		internal static IntPtr class_ref
		{
			get
			{
				return SetBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x00017A58 File Offset: 0x00015C58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SetBuilder._members;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x00017A60 File Offset: 0x00015C60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SetBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x00017A84 File Offset: 0x00015C84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SetBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x000026C4 File Offset: 0x000008C4
		internal SetBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00017A90 File Offset: 0x00015C90
		[Register("add", "(Ljava/lang/Object;)Lcom/google/android/datatransport/runtime/dagger/internal/SetBuilder;", "")]
		public unsafe SetBuilder Add(Java.Lang.Object t)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(t);
			SetBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<SetBuilder>(SetBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("add.(Ljava/lang/Object;)Lcom/google/android/datatransport/runtime/dagger/internal/SetBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(t);
			}
			return @object;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00017B04 File Offset: 0x00015D04
		[Register("addAll", "(Ljava/util/Collection;)Lcom/google/android/datatransport/runtime/dagger/internal/SetBuilder;", "")]
		public unsafe SetBuilder AddAll(ICollection collection)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(collection);
			SetBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<SetBuilder>(SetBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("addAll.(Ljava/util/Collection;)Lcom/google/android/datatransport/runtime/dagger/internal/SetBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(collection);
			}
			return @object;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00017B78 File Offset: 0x00015D78
		[Register("build", "()Ljava/util/Set;", "")]
		public ICollection Build()
		{
			return JavaSet.FromJniHandle(SetBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00017BAC File Offset: 0x00015DAC
		[Register("newSetBuilder", "(I)Lcom/google/android/datatransport/runtime/dagger/internal/SetBuilder;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static SetBuilder NewSetBuilder(int estimatedSize)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(estimatedSize);
			return Java.Lang.Object.GetObject<SetBuilder>(SetBuilder._members.StaticMethods.InvokeObjectMethod("newSetBuilder.(I)Lcom/google/android/datatransport/runtime/dagger/internal/SetBuilder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000266 RID: 614
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/SetBuilder", typeof(SetBuilder));
	}
}
