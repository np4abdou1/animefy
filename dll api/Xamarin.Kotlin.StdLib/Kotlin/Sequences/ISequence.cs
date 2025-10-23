using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Util;

namespace Kotlin.Sequences
{
	// Token: 0x020000F6 RID: 246
	[Register("kotlin/sequences/Sequence", "", "Kotlin.Sequences.ISequenceInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface ISequence : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000A08 RID: 2568
		[NullableContext(1)]
		[Register("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler:Kotlin.Sequences.ISequenceInvoker, Xamarin.Kotlin.StdLib")]
		IIterator Iterator();
	}
}
