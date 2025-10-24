using System;
using Android.Runtime;
using Java.Interop;

namespace Java.IO
{
	// Token: 0x0200041E RID: 1054
	[Register("java/io/Serializable", "", "Java.IO.ISerializableInvoker")]
	public interface ISerializable : IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
