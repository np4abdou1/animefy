using System;
using System.Runtime.CompilerServices;

namespace Java.Interop
{
	// Token: 0x02000049 RID: 73
	[JniTypeSignature("com/xamarin/java_interop/internal/JavaProxyObject")]
	internal sealed class JavaProxyObject : JavaObject, IEquatable<JavaProxyObject>
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000C42A File Offset: 0x0000A62A
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JavaProxyObject._members;
			}
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000C431 File Offset: 0x0000A631
		private JavaProxyObject(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this.Value = value;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000C44E File Offset: 0x0000A64E
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x0000C456 File Offset: 0x0000A656
		public object Value { get; private set; }

		// Token: 0x060002D8 RID: 728 RVA: 0x0000C45F File Offset: 0x0000A65F
		public override int GetHashCode()
		{
			return this.Value.GetHashCode();
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000C46C File Offset: 0x0000A66C
		public override bool Equals(object obj)
		{
			JavaProxyObject javaProxyObject = obj as JavaProxyObject;
			if (javaProxyObject != null)
			{
				return object.Equals(this.Value, javaProxyObject.Value);
			}
			return object.Equals(this.Value, obj);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000C4A1 File Offset: 0x0000A6A1
		public bool Equals(JavaProxyObject other)
		{
			return object.Equals(this.Value, (other != null) ? other.Value : null);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000C4BA File Offset: 0x0000A6BA
		public override string ToString()
		{
			return this.Value.ToString();
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		public static JavaProxyObject GetProxy(object value)
		{
			if (value == null)
			{
				return null;
			}
			ConditionalWeakTable<object, JavaProxyObject> cachedValues = JavaProxyObject.CachedValues;
			JavaProxyObject result;
			lock (cachedValues)
			{
				JavaProxyObject javaProxyObject;
				if (JavaProxyObject.CachedValues.TryGetValue(value, out javaProxyObject))
				{
					result = javaProxyObject;
				}
				else
				{
					javaProxyObject = new JavaProxyObject(value);
					JavaProxyObject.CachedValues.Add(value, javaProxyObject);
					result = javaProxyObject;
				}
			}
			return result;
		}

		// Token: 0x040000AE RID: 174
		private static readonly JniPeerMembers _members = new JniPeerMembers("com/xamarin/java_interop/internal/JavaProxyObject", typeof(JavaProxyObject));

		// Token: 0x040000AF RID: 175
		private static readonly ConditionalWeakTable<object, JavaProxyObject> CachedValues = new ConditionalWeakTable<object, JavaProxyObject>();
	}
}
