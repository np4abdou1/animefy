using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000473 RID: 1139
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
	internal sealed class TypeDependencyAttribute : Attribute
	{
		// Token: 0x06002086 RID: 8326 RVA: 0x0008907A File Offset: 0x0008727A
		public TypeDependencyAttribute(string typeName)
		{
			if (typeName == null)
			{
				throw new ArgumentNullException("typeName");
			}
			this.typeName = typeName;
		}

		// Token: 0x04000F85 RID: 3973
		private string typeName;
	}
}
