using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Kotlin.Collections
{
	// Token: 0x020002A9 RID: 681
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/AbstractSet", DoNotGenerateAcw = true)]
	internal class AbstractSetInvoker : AbstractSet, ISet, Java.Util.ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001F69 RID: 8041 RVA: 0x00069662 File Offset: 0x00067862
		public AbstractSetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x0006966C File Offset: 0x0006786C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractSetInvoker._members;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001F6B RID: 8043 RVA: 0x00069673 File Offset: 0x00067873
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractSetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x00069680 File Offset: 0x00067880
		unsafe bool ISet.AddAll(System.Collections.ICollection c)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AbstractSetInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("addAll.(LSystem/Collections/ICollection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(c);
			}
			return result;
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x000696E4 File Offset: 0x000678E4
		unsafe bool ISet.ContainsAll(System.Collections.ICollection c)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AbstractSetInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("containsAll.(LSystem/Collections/ICollection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(c);
			}
			return result;
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x00069748 File Offset: 0x00067948
		unsafe bool ISet.RemoveAll(System.Collections.ICollection c)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AbstractSetInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("removeAll.(LSystem/Collections/ICollection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(c);
			}
			return result;
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x000697AC File Offset: 0x000679AC
		unsafe bool ISet.RetainAll(System.Collections.ICollection c)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AbstractSetInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("retainAll.(LSystem/Collections/ICollection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(c);
			}
			return result;
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x00069810 File Offset: 0x00067A10
		[Register("getSize", "()I", "GetGetSizeHandler")]
		public override int GetSize()
		{
			return AbstractSetInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getSize.()I", this, null);
		}

		// Token: 0x04000947 RID: 2375
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractSet", typeof(AbstractSetInvoker));
	}
}
