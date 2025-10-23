using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Specifies access flags for the security permission object.</summary>
	// Token: 0x02000299 RID: 665
	[ComVisible(true)]
	[Flags]
	[Serializable]
	public enum SecurityPermissionFlag
	{
		/// <summary>No security access.</summary>
		// Token: 0x0400090C RID: 2316
		NoFlags = 0,
		/// <summary>Ability to assert that all this code's callers have the requisite permission for the operation.</summary>
		// Token: 0x0400090D RID: 2317
		Assertion = 1,
		/// <summary>Ability to call unmanaged code.</summary>
		// Token: 0x0400090E RID: 2318
		UnmanagedCode = 2,
		/// <summary>Ability to skip verification of code in this assembly. Code that is unverifiable can be run if this permission is granted.</summary>
		// Token: 0x0400090F RID: 2319
		SkipVerification = 4,
		/// <summary>Permission for the code to run. Without this permission, managed code will not be executed.</summary>
		// Token: 0x04000910 RID: 2320
		Execution = 8,
		/// <summary>Ability to use certain advanced operations on threads.</summary>
		// Token: 0x04000911 RID: 2321
		ControlThread = 16,
		/// <summary>Ability to provide evidence, including the ability to alter the evidence provided by the common language runtime.</summary>
		// Token: 0x04000912 RID: 2322
		ControlEvidence = 32,
		/// <summary>Ability to view and modify policy.</summary>
		// Token: 0x04000913 RID: 2323
		ControlPolicy = 64,
		/// <summary>Ability to provide serialization services. Used by serialization formatters.</summary>
		// Token: 0x04000914 RID: 2324
		SerializationFormatter = 128,
		/// <summary>Ability to specify domain policy.</summary>
		// Token: 0x04000915 RID: 2325
		ControlDomainPolicy = 256,
		/// <summary>Ability to manipulate the principal object.</summary>
		// Token: 0x04000916 RID: 2326
		ControlPrincipal = 512,
		/// <summary>Ability to create and manipulate an <see cref="T:System.AppDomain" />.</summary>
		// Token: 0x04000917 RID: 2327
		ControlAppDomain = 1024,
		/// <summary>Permission to configure Remoting types and channels.</summary>
		// Token: 0x04000918 RID: 2328
		RemotingConfiguration = 2048,
		/// <summary>Permission to plug code into the common language runtime infrastructure, such as adding Remoting Context Sinks, Envoy Sinks and Dynamic Sinks.</summary>
		// Token: 0x04000919 RID: 2329
		Infrastructure = 4096,
		/// <summary>Permission to perform explicit binding redirection in the application configuration file. This includes redirection of .NET Framework assemblies that have been unified as well as other assemblies found outside the .NET Framework.</summary>
		// Token: 0x0400091A RID: 2330
		BindingRedirects = 8192,
		/// <summary>The unrestricted state of the permission.</summary>
		// Token: 0x0400091B RID: 2331
		AllFlags = 16383
	}
}
