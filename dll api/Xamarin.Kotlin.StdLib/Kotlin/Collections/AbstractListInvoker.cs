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
	// Token: 0x020002AA RID: 682
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/AbstractList", DoNotGenerateAcw = true)]
	internal class AbstractListInvoker : AbstractList, Java.Util.IList, Java.Util.ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001F72 RID: 8050 RVA: 0x00069844 File Offset: 0x00067A44
		public AbstractListInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x0006984E File Offset: 0x00067A4E
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractListInvoker._members;
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x00069855 File Offset: 0x00067A55
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractListInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x00069864 File Offset: 0x00067A64
		[NullableContext(2)]
		[Register("get", "(I)Ljava/lang/Object;", "GetGet_IHandler")]
		public unsafe override Java.Lang.Object Get(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractListInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("get.(I)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x000698B0 File Offset: 0x00067AB0
		unsafe bool Java.Util.IList.AddAll(System.Collections.ICollection c)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AbstractListInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("addAll.(LSystem/Collections/ICollection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(c);
			}
			return result;
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x00069914 File Offset: 0x00067B14
		unsafe bool Java.Util.IList.ContainsAll(System.Collections.ICollection c)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AbstractListInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("containsAll.(LSystem/Collections/ICollection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(c);
			}
			return result;
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x00069978 File Offset: 0x00067B78
		unsafe bool Java.Util.IList.RemoveAll(System.Collections.ICollection c)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AbstractListInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("removeAll.(LSystem/Collections/ICollection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(c);
			}
			return result;
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x000699DC File Offset: 0x00067BDC
		unsafe bool Java.Util.IList.RetainAll(System.Collections.ICollection c)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AbstractListInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("retainAll.(LSystem/Collections/ICollection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(c);
			}
			return result;
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x00069A40 File Offset: 0x00067C40
		[Register("getSize", "()I", "GetGetSizeHandler")]
		public override int GetSize()
		{
			return AbstractListInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getSize.()I", this, null);
		}

		// Token: 0x04000948 RID: 2376
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractList", typeof(AbstractListInvoker));
	}
}
