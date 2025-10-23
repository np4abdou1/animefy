using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Defines the access modes for a dynamic assembly.</summary>
	// Token: 0x020004F0 RID: 1264
	[ComVisible(true)]
	[Flags]
	[Serializable]
	public enum AssemblyBuilderAccess
	{
		/// <summary>The dynamic assembly can be executed, but not saved.</summary>
		// Token: 0x040011D9 RID: 4569
		Run = 1,
		/// <summary>The dynamic assembly can be saved, but not executed.</summary>
		// Token: 0x040011DA RID: 4570
		Save = 2,
		/// <summary>The dynamic assembly can be executed and saved.</summary>
		// Token: 0x040011DB RID: 4571
		RunAndSave = 3,
		/// <summary>
		///
		///     The dynamic assembly is loaded into the reflection-only context, and cannot be executed.</summary>
		// Token: 0x040011DC RID: 4572
		ReflectionOnly = 6,
		/// <summary>The dynamic assembly can be unloaded and its memory reclaimed, subject to the restrictions described in Collectible Assemblies for Dynamic Type Generation.</summary>
		// Token: 0x040011DD RID: 4573
		RunAndCollect = 9
	}
}
