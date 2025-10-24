using System;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang.Reflect
{
	// Token: 0x02000409 RID: 1033
	[Register("java/lang/reflect/TypeVariable", "", "Java.Lang.Reflect.ITypeVariableInvoker")]
	[JavaTypeParameters(new string[]
	{
		"D extends java.lang.reflect.GenericDeclaration"
	})]
	public interface ITypeVariable : IType, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06002D70 RID: 11632
		Object GenericDeclaration { get; }

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06002D71 RID: 11633
		string Name { get; }

		// Token: 0x06002D72 RID: 11634
		IType[] GetBounds();
	}
}
