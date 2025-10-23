using System;

namespace Java.Interop
{
	// Token: 0x0200008C RID: 140
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = false)]
	public class JniValueMarshalerAttribute : Attribute
	{
		// Token: 0x06000495 RID: 1173 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		public JniValueMarshalerAttribute(Type marshalerType)
		{
			if (marshalerType == null)
			{
				throw new ArgumentNullException("marshalerType");
			}
			if (!typeof(JniValueMarshaler).IsAssignableFrom(marshalerType))
			{
				throw new ArgumentException(string.Format("`{0}` must inherit from JniValueMarshaler!", marshalerType.FullName), "marshalerType");
			}
			this.MarshalerType = marshalerType;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00010B2B File Offset: 0x0000ED2B
		public Type MarshalerType { get; }
	}
}
