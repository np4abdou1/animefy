using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x0200033F RID: 831
	[Register("java/util/function/UnaryOperator", "", "Java.Util.Functions.IUnaryOperatorInvoker", ApiSince = 24)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IUnaryOperator : IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002344 RID: 9028 RVA: 0x00063528 File Offset: 0x00061728
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public static IUnaryOperator Identity()
		{
			return Java.Lang.Object.GetObject<IUnaryOperator>(IUnaryOperator._members.StaticMethods.InvokeObjectMethod("identity.()Ljava/util/function/UnaryOperator;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000E88 RID: 3720
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/function/UnaryOperator", typeof(IUnaryOperator), true);
	}
}
