using System;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Firebase.Encoders
{
	// Token: 0x02000004 RID: 4
	[Register("com/google/firebase/encoders/DataEncoder", "", "Firebase.Encoders.IDataEncoderInvoker")]
	public interface IDataEncoder : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000009 RID: 9
		[Register("encode", "(Ljava/lang/Object;)Ljava/lang/String;", "GetEncode_Ljava_lang_Object_Handler:Firebase.Encoders.IDataEncoderInvoker, Xamarin.Firebase.Encoders")]
		string Encode(Java.Lang.Object p0);

		// Token: 0x0600000A RID: 10
		[Register("encode", "(Ljava/lang/Object;Ljava/io/Writer;)V", "GetEncode_Ljava_lang_Object_Ljava_io_Writer_Handler:Firebase.Encoders.IDataEncoderInvoker, Xamarin.Firebase.Encoders")]
		void Encode(Java.Lang.Object p0, Writer p1);
	}
}
