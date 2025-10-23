using System;

namespace System.Runtime.Versioning
{
	/// <summary>Identifies the version of the .NET Framework that a particular assembly was compiled against.</summary>
	// Token: 0x0200038C RID: 908
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	public sealed class TargetFrameworkAttribute : Attribute
	{
		/// <summary>Initializes an instance of the <see cref="T:System.Runtime.Versioning.TargetFrameworkAttribute" /> class by specifying the .NET Framework version against which an assembly was built.</summary>
		/// <param name="frameworkName">The version of the .NET Framework against which the assembly was built.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="frameworkName" /> is <see langword="null" />.</exception>
		// Token: 0x06001C66 RID: 7270 RVA: 0x000790D0 File Offset: 0x000772D0
		public TargetFrameworkAttribute(string frameworkName)
		{
			if (frameworkName == null)
			{
				throw new ArgumentNullException("frameworkName");
			}
			this._frameworkName = frameworkName;
		}

		/// <summary>Gets the display name of the .NET Framework version against which an assembly was built.</summary>
		/// <returns>The display name of the .NET Framework version.</returns>
		// Token: 0x17000398 RID: 920
		// (set) Token: 0x06001C67 RID: 7271 RVA: 0x000790ED File Offset: 0x000772ED
		public string FrameworkDisplayName
		{
			set
			{
				this._frameworkDisplayName = value;
			}
		}

		// Token: 0x04000BEB RID: 3051
		private string _frameworkName;

		// Token: 0x04000BEC RID: 3052
		private string _frameworkDisplayName;
	}
}
