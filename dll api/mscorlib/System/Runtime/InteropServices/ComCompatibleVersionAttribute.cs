using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Indicates to a COM client that all classes in the current version of an assembly are compatible with classes in an earlier version of the assembly.</summary>
	// Token: 0x02000417 RID: 1047
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	[ComVisible(true)]
	public sealed class ComCompatibleVersionAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.ComCompatibleVersionAttribute" /> class with the major version, minor version, build, and revision numbers of the assembly.</summary>
		/// <param name="major">The major version number of the assembly. </param>
		/// <param name="minor">The minor version number of the assembly. </param>
		/// <param name="build">The build number of the assembly. </param>
		/// <param name="revision">The revision number of the assembly. </param>
		// Token: 0x06001F51 RID: 8017 RVA: 0x000868DA File Offset: 0x00084ADA
		public ComCompatibleVersionAttribute(int major, int minor, int build, int revision)
		{
			this._major = major;
			this._minor = minor;
			this._build = build;
			this._revision = revision;
		}

		// Token: 0x04000F00 RID: 3840
		internal int _major;

		// Token: 0x04000F01 RID: 3841
		internal int _minor;

		// Token: 0x04000F02 RID: 3842
		internal int _build;

		// Token: 0x04000F03 RID: 3843
		internal int _revision;
	}
}
