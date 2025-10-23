using System;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang.Reflect
{
	// Token: 0x02000401 RID: 1025
	[Register("java/lang/reflect/GenericDeclaration", "", "Java.Lang.Reflect.IGenericDeclarationInvoker")]
	public interface IGenericDeclaration : IAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002D30 RID: 11568
		ITypeVariable[] GetTypeParameters();
	}
}
