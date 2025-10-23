using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Provides a hint to the common language runtime (CLR) indicating how likely a dependency is to be loaded. This class is used in a dependent assembly to indicate what hint should be used when the parent does not specify the <see cref="T:System.Runtime.CompilerServices.DependencyAttribute" /> attribute.  This class cannot be inherited. </summary>
	// Token: 0x0200046C RID: 1132
	[AttributeUsage(AttributeTargets.Assembly)]
	[Serializable]
	public sealed class DefaultDependencyAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.DefaultDependencyAttribute" /> class with the specified <see cref="T:System.Runtime.CompilerServices.LoadHint" /> binding. </summary>
		/// <param name="loadHintArgument">One of the <see cref="T:System.Runtime.CompilerServices.LoadHint" /> values that indicates the default binding preference.</param>
		// Token: 0x0600207E RID: 8318 RVA: 0x00089019 File Offset: 0x00087219
		public DefaultDependencyAttribute(LoadHint loadHintArgument)
		{
			this.loadHint = loadHintArgument;
		}

		// Token: 0x04000F75 RID: 3957
		private LoadHint loadHint;
	}
}
