using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Jvm.Internal.Markers;

namespace Kotlin.Enums
{
	// Token: 0x0200024A RID: 586
	[Register("kotlin/enums/EnumEntries", "", "Kotlin.Enums.IEnumEntriesInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E extends java.lang.Enum<E>"
	})]
	public interface IEnumEntries : IList, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
	}
}
