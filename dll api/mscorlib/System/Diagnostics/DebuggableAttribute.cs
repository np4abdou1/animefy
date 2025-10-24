using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Modifies code generation for runtime just-in-time (JIT) debugging. This class cannot be inherited.</summary>
	// Token: 0x020005BA RID: 1466
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = false)]
	[ComVisible(true)]
	public sealed class DebuggableAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggableAttribute" /> class, using the specified debugging modes for the just-in-time (JIT) compiler. </summary>
		/// <param name="modes">A bitwise combination of the <see cref="T:System.Diagnostics.DebuggableAttribute.DebuggingModes" />  values specifying the debugging mode for the JIT compiler.</param>
		// Token: 0x06002C2A RID: 11306 RVA: 0x000B748F File Offset: 0x000B568F
		public DebuggableAttribute(DebuggableAttribute.DebuggingModes modes)
		{
			this.m_debuggingModes = modes;
		}

		// Token: 0x04001817 RID: 6167
		private DebuggableAttribute.DebuggingModes m_debuggingModes;

		/// <summary>Specifies the debugging mode for the just-in-time (JIT) compiler.</summary>
		// Token: 0x020005BB RID: 1467
		[Flags]
		[ComVisible(true)]
		public enum DebuggingModes
		{
			/// <summary>Starting with the .NET Framework version 2.0, JIT tracking information is always generated, and this flag has the same effect as <see cref="F:System.Diagnostics.DebuggableAttribute.DebuggingModes.Default" />, except that it sets the <see cref="P:System.Diagnostics.DebuggableAttribute.IsJITTrackingEnabled" /> property to <see langword="false" />. However, because JIT tracking is always enabled, the property value is ignored in version 2.0 or later. Note that, unlike the <see cref="F:System.Diagnostics.DebuggableAttribute.DebuggingModes.None" /> flag, the <see cref="F:System.Diagnostics.DebuggableAttribute.DebuggingModes.None" /> flag cannot be used to disable JIT optimizations. </summary>
			// Token: 0x04001819 RID: 6169
			None = 0,
			/// <summary>Instructs the just-in-time (JIT) compiler to use its default behavior, which includes enabling optimizations, disabling Edit and Continue support, and using symbol store sequence points if present. Starting with the .NET Framework version 2.0, JIT tracking information, the Microsoft intermediate language (MSIL) offset to the native-code offset within a method, is always generated.</summary>
			// Token: 0x0400181A RID: 6170
			Default = 1,
			/// <summary>Disable optimizations performed by the compiler to make your output file smaller, faster, and more efficient. Optimizations result in code rearrangement in the output file, which can make debugging difficult. Typically optimization should be disabled while debugging. In versions 2.0 or later, combine this value with Default (Default | DisableOptimizations) to enable JIT tracking and disable optimizations.</summary>
			// Token: 0x0400181B RID: 6171
			DisableOptimizations = 256,
			/// <summary>Use the implicit MSIL sequence points, not the program database (PDB) sequence points. The symbolic information normally includes at least one Microsoft intermediate language (MSIL) offset for each source line. When the just-in-time (JIT) compiler is about to compile a method, it asks the profiling services for a list of MSIL offsets that should be preserved. These MSIL offsets are called sequence points.</summary>
			// Token: 0x0400181C RID: 6172
			IgnoreSymbolStoreSequencePoints = 2,
			/// <summary>Enable edit and continue. Edit and continue enables you to make changes to your source code while your program is in break mode. The ability to edit and continue is compiler dependent. </summary>
			// Token: 0x0400181D RID: 6173
			EnableEditAndContinue = 4
		}
	}
}
