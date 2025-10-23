using System;

namespace System
{
	/// <summary>Specifies the application elements on which it is valid to apply an attribute.</summary>
	// Token: 0x02000082 RID: 130
	[Flags]
	public enum AttributeTargets
	{
		/// <summary>Attribute can be applied to an assembly.</summary>
		// Token: 0x040001B5 RID: 437
		Assembly = 1,
		/// <summary>Attribute can be applied to a module.</summary>
		// Token: 0x040001B6 RID: 438
		Module = 2,
		/// <summary>Attribute can be applied to a class.</summary>
		// Token: 0x040001B7 RID: 439
		Class = 4,
		/// <summary>Attribute can be applied to a structure; that is, a value type.</summary>
		// Token: 0x040001B8 RID: 440
		Struct = 8,
		/// <summary>Attribute can be applied to an enumeration.</summary>
		// Token: 0x040001B9 RID: 441
		Enum = 16,
		/// <summary>Attribute can be applied to a constructor.</summary>
		// Token: 0x040001BA RID: 442
		Constructor = 32,
		/// <summary>Attribute can be applied to a method.</summary>
		// Token: 0x040001BB RID: 443
		Method = 64,
		/// <summary>Attribute can be applied to a property.</summary>
		// Token: 0x040001BC RID: 444
		Property = 128,
		/// <summary>Attribute can be applied to a field.</summary>
		// Token: 0x040001BD RID: 445
		Field = 256,
		/// <summary>Attribute can be applied to an event.</summary>
		// Token: 0x040001BE RID: 446
		Event = 512,
		/// <summary>Attribute can be applied to an interface.</summary>
		// Token: 0x040001BF RID: 447
		Interface = 1024,
		/// <summary>Attribute can be applied to a parameter.</summary>
		// Token: 0x040001C0 RID: 448
		Parameter = 2048,
		/// <summary>Attribute can be applied to a delegate.</summary>
		// Token: 0x040001C1 RID: 449
		Delegate = 4096,
		/// <summary>Attribute can be applied to a return value.</summary>
		// Token: 0x040001C2 RID: 450
		ReturnValue = 8192,
		/// <summary>Attribute can be applied to a generic parameter.</summary>
		// Token: 0x040001C3 RID: 451
		GenericParameter = 16384,
		/// <summary>Attribute can be applied to any application element.</summary>
		// Token: 0x040001C4 RID: 452
		All = 32767
	}
}
