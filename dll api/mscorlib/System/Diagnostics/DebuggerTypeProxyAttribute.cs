using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Specifies the display proxy for a type.</summary>
	// Token: 0x020005BE RID: 1470
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
	[ComVisible(true)]
	public sealed class DebuggerTypeProxyAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerTypeProxyAttribute" /> class using the type of the proxy. </summary>
		/// <param name="type">The proxy type.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />.</exception>
		// Token: 0x06002C2C RID: 11308 RVA: 0x000B74C0 File Offset: 0x000B56C0
		public DebuggerTypeProxyAttribute(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			this.typeName = type.AssemblyQualifiedName;
		}

		// Token: 0x04001823 RID: 6179
		private string typeName;
	}
}
