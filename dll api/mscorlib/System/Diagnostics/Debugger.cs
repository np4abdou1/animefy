using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Enables communication with a debugger. This class cannot be inherited.</summary>
	// Token: 0x020005C0 RID: 1472
	[ComVisible(true)]
	public sealed class Debugger
	{
		/// <summary>Gets a value that indicates whether a debugger is attached to the process.</summary>
		/// <returns>
		///     <see langword="true" /> if a debugger is attached; otherwise, <see langword="false" />.</returns>
		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06002C2E RID: 11310 RVA: 0x000B751D File Offset: 0x000B571D
		public static bool IsAttached
		{
			get
			{
				return Debugger.IsAttached_internal();
			}
		}

		// Token: 0x06002C2F RID: 11311
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsAttached_internal();

		/// <summary>Checks to see if logging is enabled by an attached debugger.</summary>
		/// <returns>
		///     <see langword="true" /> if a debugger is attached and logging is enabled; otherwise, <see langword="false" />. The attached debugger is the registered managed debugger in the <see langword="DbgManagedDebugger" /> registry key. For more information on this key, see Enabling JIT-Attach Debugging.</returns>
		// Token: 0x06002C30 RID: 11312
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsLogging();

		// Token: 0x06002C31 RID: 11313
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Log_icall(int level, ref string category, ref string message);

		/// <summary>Posts a message for the attached debugger.</summary>
		/// <param name="level">A description of the importance of the message. </param>
		/// <param name="category">The category of the message. </param>
		/// <param name="message">The message to show. </param>
		// Token: 0x06002C32 RID: 11314 RVA: 0x000B7524 File Offset: 0x000B5724
		public static void Log(int level, string category, string message)
		{
			Debugger.Log_icall(level, ref category, ref message);
		}

		/// <summary>Notifies a debugger that execution is about to enter a path that involves a cross-thread dependency.</summary>
		// Token: 0x06002C33 RID: 11315 RVA: 0x00002A7D File Offset: 0x00000C7D
		public static void NotifyOfCrossThreadDependency()
		{
		}

		// Token: 0x06002C34 RID: 11316
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Mono_UnhandledException_internal(Exception ex);

		// Token: 0x06002C35 RID: 11317 RVA: 0x000B7530 File Offset: 0x000B5730
		internal static void Mono_UnhandledException(Exception ex)
		{
			Debugger.Mono_UnhandledException_internal(ex);
		}
	}
}
