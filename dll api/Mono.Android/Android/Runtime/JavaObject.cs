using System;
using Java.Lang;

namespace Android.Runtime
{
	// Token: 0x020002DC RID: 732
	[Register("mono/android/runtime/JavaObject")]
	internal sealed class JavaObject : Java.Lang.Object
	{
		// Token: 0x06001BD9 RID: 7129 RVA: 0x0004A4EC File Offset: 0x000486EC
		public static IntPtr GetHandle(object obj)
		{
			if (obj == null)
			{
				return IntPtr.Zero;
			}
			Type type = obj.GetType();
			if (type == typeof(bool))
			{
				return new Java.Lang.Boolean((bool)obj).Handle;
			}
			if (type == typeof(sbyte))
			{
				return new Java.Lang.Byte((sbyte)obj).Handle;
			}
			if (type == typeof(char))
			{
				return new Character((char)obj).Handle;
			}
			if (type == typeof(short))
			{
				return new Short((short)obj).Handle;
			}
			if (type == typeof(int))
			{
				return new Integer((int)obj).Handle;
			}
			if (type == typeof(long))
			{
				return new Long((long)obj).Handle;
			}
			if (type == typeof(float))
			{
				return new Float((float)obj).Handle;
			}
			if (type == typeof(double))
			{
				return new Java.Lang.Double((double)obj).Handle;
			}
			if (type == typeof(string))
			{
				return JNIEnv.NewString((string)obj);
			}
			if (typeof(IJavaObject).IsAssignableFrom(type))
			{
				return ((IJavaObject)obj).Handle;
			}
			return new JavaObject(obj).Handle;
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0004A668 File Offset: 0x00048868
		public static object GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			Java.Lang.Object @object = Java.Lang.Object.GetObject(handle, transfer, null) as Java.Lang.Object;
			if (@object == null)
			{
				return null;
			}
			if (@object is Java.Lang.Boolean)
			{
				return JavaObject.Dispose<Java.Lang.Boolean, bool>((Java.Lang.Boolean)@object, (Java.Lang.Boolean v) => v.BooleanValue());
			}
			if (@object is Java.Lang.Byte)
			{
				return JavaObject.Dispose<Java.Lang.Byte, sbyte>((Java.Lang.Byte)@object, (Java.Lang.Byte v) => v.ByteValue());
			}
			if (@object is Character)
			{
				return JavaObject.Dispose<Character, char>((Character)@object, (Character v) => v.CharValue());
			}
			if (@object is Short)
			{
				return JavaObject.Dispose<Short, short>((Short)@object, (Short v) => v.ShortValue());
			}
			if (@object is Integer)
			{
				return JavaObject.Dispose<Integer, int>((Integer)@object, (Integer v) => v.IntValue());
			}
			if (@object is Long)
			{
				return JavaObject.Dispose<Long, long>((Long)@object, (Long v) => v.LongValue());
			}
			if (@object is Float)
			{
				return JavaObject.Dispose<Float, float>((Float)@object, (Float v) => v.FloatValue());
			}
			if (@object is Java.Lang.Double)
			{
				return JavaObject.Dispose<Java.Lang.Double, double>((Java.Lang.Double)@object, (Java.Lang.Double v) => v.DoubleValue());
			}
			if (@object is Java.Lang.String)
			{
				return JavaObject.Dispose<Java.Lang.Object, string>(@object, (Java.Lang.Object v) => JNIEnv.GetString(v.Handle, JniHandleOwnership.DoNotTransfer));
			}
			if (@object is JavaObject)
			{
				return ((JavaObject)@object).inst;
			}
			return @object;
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0004A88C File Offset: 0x00048A8C
		private static TRet Dispose<T, TRet>(T value, Func<T, TRet> c) where T : IDisposable
		{
			TRet result;
			try
			{
				result = c(value);
			}
			finally
			{
				value.Dispose();
			}
			return result;
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0004A8C4 File Offset: 0x00048AC4
		public JavaObject(object inst) : base(JNIEnv.StartCreateInstance("mono/android/runtime/JavaObject", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.inst = inst;
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x0004A8FD File Offset: 0x00048AFD
		public object Instance
		{
			get
			{
				return this.inst;
			}
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0004A908 File Offset: 0x00048B08
		public override bool Equals(Java.Lang.Object obj)
		{
			JavaObject javaObject = obj as JavaObject;
			return javaObject != null && javaObject.inst == this.inst;
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0004A92F File Offset: 0x00048B2F
		public override int GetHashCode()
		{
			return this.inst.GetHashCode();
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0004A93C File Offset: 0x00048B3C
		public override string ToString()
		{
			if (this.inst == null)
			{
				return "";
			}
			return this.inst.ToString();
		}

		// Token: 0x04000BB2 RID: 2994
		private object inst;
	}
}
