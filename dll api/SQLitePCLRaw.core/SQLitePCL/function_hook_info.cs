using System;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x0200003B RID: 59
	public class function_hook_info
	{
		// Token: 0x060001FA RID: 506 RVA: 0x00003AB2 File Offset: 0x00001CB2
		public function_hook_info(delegate_function_scalar func_scalar, object user_data)
		{
			this._func_scalar = func_scalar;
			this._user_data = user_data;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00003AC8 File Offset: 0x00001CC8
		public function_hook_info(delegate_function_aggregate_step func_step, delegate_function_aggregate_final func_final, object user_data)
		{
			this._func_step = func_step;
			this._func_final = func_final;
			this._user_data = user_data;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00003AE8 File Offset: 0x00001CE8
		public static function_hook_info from_ptr(IntPtr p)
		{
			return ((GCHandle)p).Target as function_hook_info;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00003B08 File Offset: 0x00001D08
		private sqlite3_context get_context(IntPtr context, IntPtr agg_context)
		{
			IntPtr intPtr = Marshal.ReadIntPtr(agg_context);
			function_hook_info.agg_sqlite3_context agg_sqlite3_context;
			if (intPtr == IntPtr.Zero)
			{
				agg_sqlite3_context = new function_hook_info.agg_sqlite3_context(this._user_data);
				GCHandle value = GCHandle.Alloc(agg_sqlite3_context);
				Marshal.WriteIntPtr(agg_context, (IntPtr)value);
			}
			else
			{
				agg_sqlite3_context = (((GCHandle)intPtr).Target as function_hook_info.agg_sqlite3_context);
			}
			agg_sqlite3_context.fix_ptr(context);
			return agg_sqlite3_context;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00003B68 File Offset: 0x00001D68
		public void call_scalar(IntPtr context, int num_args, IntPtr argsptr)
		{
			function_hook_info.scalar_sqlite3_context ctx = new function_hook_info.scalar_sqlite3_context(context, this._user_data);
			sqlite3_value[] array = new sqlite3_value[num_args];
			int num = Marshal.SizeOf(typeof(IntPtr));
			for (int i = 0; i < num_args; i++)
			{
				IntPtr p = Marshal.ReadIntPtr(argsptr, i * num);
				array[i] = new sqlite3_value(p);
			}
			this._func_scalar(ctx, this._user_data, array);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00003BD0 File Offset: 0x00001DD0
		public void call_step(IntPtr context, IntPtr agg_context, int num_args, IntPtr argsptr)
		{
			sqlite3_context ctx = this.get_context(context, agg_context);
			sqlite3_value[] array = new sqlite3_value[num_args];
			int num = Marshal.SizeOf(typeof(IntPtr));
			for (int i = 0; i < num_args; i++)
			{
				IntPtr p = Marshal.ReadIntPtr(argsptr, i * num);
				array[i] = new sqlite3_value(p);
			}
			this._func_step(ctx, this._user_data, array);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00003C34 File Offset: 0x00001E34
		public void call_final(IntPtr context, IntPtr agg_context)
		{
			sqlite3_context ctx = this.get_context(context, agg_context);
			this._func_final(ctx, this._user_data);
			((GCHandle)Marshal.ReadIntPtr(agg_context)).Free();
		}

		// Token: 0x04000105 RID: 261
		private delegate_function_scalar _func_scalar;

		// Token: 0x04000106 RID: 262
		private delegate_function_aggregate_step _func_step;

		// Token: 0x04000107 RID: 263
		private delegate_function_aggregate_final _func_final;

		// Token: 0x04000108 RID: 264
		private object _user_data;

		// Token: 0x0200003C RID: 60
		private class agg_sqlite3_context : sqlite3_context
		{
			// Token: 0x06000201 RID: 513 RVA: 0x00003C6F File Offset: 0x00001E6F
			public agg_sqlite3_context(object v) : base(v)
			{
			}

			// Token: 0x06000202 RID: 514 RVA: 0x00003C78 File Offset: 0x00001E78
			public void fix_ptr(IntPtr p)
			{
				base.set_context_ptr(p);
			}
		}

		// Token: 0x0200003D RID: 61
		private class scalar_sqlite3_context : sqlite3_context
		{
			// Token: 0x06000203 RID: 515 RVA: 0x00003C81 File Offset: 0x00001E81
			public scalar_sqlite3_context(IntPtr p, object v) : base(v)
			{
				base.set_context_ptr(p);
			}
		}
	}
}
