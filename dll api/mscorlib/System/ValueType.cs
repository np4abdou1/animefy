using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Provides the base class for value types.</summary>
	// Token: 0x02000193 RID: 403
	[ComVisible(true)]
	[Serializable]
	public abstract class ValueType
	{
		// Token: 0x06000F75 RID: 3957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool InternalEquals(object o1, object o2, out object[] fields);

		// Token: 0x06000F76 RID: 3958 RVA: 0x00040DC8 File Offset: 0x0003EFC8
		internal static bool DefaultEquals(object o1, object o2)
		{
			if (o1 == null && o2 == null)
			{
				return true;
			}
			if (o1 == null || o2 == null)
			{
				return false;
			}
			RuntimeType left = (RuntimeType)o1.GetType();
			RuntimeType right = (RuntimeType)o2.GetType();
			if (left != right)
			{
				return false;
			}
			object[] array;
			bool result = ValueType.InternalEquals(o1, o2, out array);
			if (array == null)
			{
				return result;
			}
			for (int i = 0; i < array.Length; i += 2)
			{
				object obj = array[i];
				object obj2 = array[i + 1];
				if (obj == null)
				{
					if (obj2 != null)
					{
						return false;
					}
				}
				else if (!obj.Equals(obj2))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Indicates whether this instance and a specified object are equal.</summary>
		/// <param name="obj">The object to compare with the current instance. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />. </returns>
		// Token: 0x06000F77 RID: 3959 RVA: 0x00034D1F File Offset: 0x00032F1F
		public override bool Equals(object obj)
		{
			return ValueType.DefaultEquals(this, obj);
		}

		// Token: 0x06000F78 RID: 3960
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int InternalGetHashCode(object o, out object[] fields);

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
		// Token: 0x06000F79 RID: 3961 RVA: 0x00040E48 File Offset: 0x0003F048
		public override int GetHashCode()
		{
			object[] array;
			int num = ValueType.InternalGetHashCode(this, out array);
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != null)
					{
						num ^= array[i].GetHashCode();
					}
				}
			}
			return num;
		}

		/// <summary>Returns the fully qualified type name of this instance.</summary>
		/// <returns>The fully qualified type name.</returns>
		// Token: 0x06000F7A RID: 3962 RVA: 0x00040E80 File Offset: 0x0003F080
		public override string ToString()
		{
			return base.GetType().FullName;
		}
	}
}
