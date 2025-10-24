using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System.Threading
{
	// Token: 0x020001F5 RID: 501
	[StructLayout(0)]
	internal sealed class InternalThread : CriticalFinalizerObject
	{
		// Token: 0x04000704 RID: 1796
		private int lock_thread_id;

		// Token: 0x04000705 RID: 1797
		private IntPtr handle;

		// Token: 0x04000706 RID: 1798
		private IntPtr native_handle;

		// Token: 0x04000707 RID: 1799
		private IntPtr name_chars;

		// Token: 0x04000708 RID: 1800
		private int name_free;

		// Token: 0x04000709 RID: 1801
		private int name_length;

		// Token: 0x0400070A RID: 1802
		private ThreadState state;

		// Token: 0x0400070B RID: 1803
		private object abort_exc;

		// Token: 0x0400070C RID: 1804
		private int abort_state_handle;

		// Token: 0x0400070D RID: 1805
		internal long thread_id;

		// Token: 0x0400070E RID: 1806
		private IntPtr debugger_thread;

		// Token: 0x0400070F RID: 1807
		private UIntPtr static_data;

		// Token: 0x04000710 RID: 1808
		private IntPtr runtime_thread_info;

		// Token: 0x04000711 RID: 1809
		private object current_appcontext;

		// Token: 0x04000712 RID: 1810
		private object root_domain_thread;

		// Token: 0x04000713 RID: 1811
		internal byte[] _serialized_principal;

		// Token: 0x04000714 RID: 1812
		internal int _serialized_principal_version;

		// Token: 0x04000715 RID: 1813
		private IntPtr appdomain_refs;

		// Token: 0x04000716 RID: 1814
		private int interruption_requested;

		// Token: 0x04000717 RID: 1815
		private IntPtr longlived;

		// Token: 0x04000718 RID: 1816
		internal bool threadpool_thread;

		// Token: 0x04000719 RID: 1817
		private bool thread_interrupt_requested;

		// Token: 0x0400071A RID: 1818
		internal int stack_size;

		// Token: 0x0400071B RID: 1819
		internal byte apartment_state;

		// Token: 0x0400071C RID: 1820
		internal volatile int critical_region_level;

		// Token: 0x0400071D RID: 1821
		internal int managed_id;

		// Token: 0x0400071E RID: 1822
		private int small_id;

		// Token: 0x0400071F RID: 1823
		private IntPtr manage_callback;

		// Token: 0x04000720 RID: 1824
		private IntPtr flags;

		// Token: 0x04000721 RID: 1825
		private IntPtr thread_pinning_ref;

		// Token: 0x04000722 RID: 1826
		private IntPtr abort_protected_block_count;

		// Token: 0x04000723 RID: 1827
		private int priority;

		// Token: 0x04000724 RID: 1828
		private IntPtr owned_mutex;

		// Token: 0x04000725 RID: 1829
		private IntPtr suspended_event;

		// Token: 0x04000726 RID: 1830
		private int self_suspended;

		// Token: 0x04000727 RID: 1831
		private IntPtr thread_state;

		// Token: 0x04000728 RID: 1832
		private IntPtr netcore0;

		// Token: 0x04000729 RID: 1833
		private IntPtr netcore1;

		// Token: 0x0400072A RID: 1834
		private IntPtr netcore2;

		// Token: 0x0400072B RID: 1835
		private IntPtr last;
	}
}
