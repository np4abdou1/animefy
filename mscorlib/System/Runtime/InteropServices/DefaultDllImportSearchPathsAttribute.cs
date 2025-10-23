using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Specifies the paths that are used to search for DLLs that provide functions for platform invokes. </summary>
	// Token: 0x02000414 RID: 1044
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Method, AllowMultiple = false)]
	[ComVisible(false)]
	public sealed class DefaultDllImportSearchPathsAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute" /> class, specifying the paths to use when searching for the targets of platform invokes. </summary>
		/// <param name="paths">A bitwise combination of enumeration values that specify the paths that the LoadLibraryEx function searches during platform invokes. </param>
		// Token: 0x06001F4C RID: 8012 RVA: 0x00086739 File Offset: 0x00084939
		public DefaultDllImportSearchPathsAttribute(DllImportSearchPath paths)
		{
			this._paths = paths;
		}

		// Token: 0x04000EF5 RID: 3829
		internal DllImportSearchPath _paths;
	}
}
