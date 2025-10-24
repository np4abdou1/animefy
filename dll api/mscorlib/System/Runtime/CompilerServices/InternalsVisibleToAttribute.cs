using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Specifies that types that are ordinarily visible only within the current assembly are visible to a specified assembly.</summary>
	// Token: 0x0200046F RID: 1135
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
	public sealed class InternalsVisibleToAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.InternalsVisibleToAttribute" /> class with the name of the specified friend assembly. </summary>
		/// <param name="assemblyName">The name of a friend assembly.</param>
		// Token: 0x06002081 RID: 8321 RVA: 0x00089037 File Offset: 0x00087237
		public InternalsVisibleToAttribute(string assemblyName)
		{
			this._assemblyName = assemblyName;
		}

		/// <summary>This property is not implemented.</summary>
		/// <returns>This property does not return a value.</returns>
		// Token: 0x17000414 RID: 1044
		// (set) Token: 0x06002082 RID: 8322 RVA: 0x0008904D File Offset: 0x0008724D
		public bool AllInternalsVisible
		{
			set
			{
				this._allInternalsVisible = value;
			}
		}

		// Token: 0x04000F79 RID: 3961
		private string _assemblyName;

		// Token: 0x04000F7A RID: 3962
		private bool _allInternalsVisible = true;
	}
}
