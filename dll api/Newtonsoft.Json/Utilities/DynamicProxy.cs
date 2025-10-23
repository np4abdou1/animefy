using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000A7 RID: 167
	[NullableContext(1)]
	[Nullable(0)]
	internal class DynamicProxy<[Nullable(2)] T>
	{
		// Token: 0x06000595 RID: 1429 RVA: 0x0001EA0C File Offset: 0x0001CC0C
		public virtual IEnumerable<string> GetDynamicMemberNames(T instance)
		{
			return CollectionUtils.ArrayEmpty<string>();
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0001EA13 File Offset: 0x0001CC13
		public virtual bool TryBinaryOperation(T instance, BinaryOperationBinder binder, object arg, [Nullable(2)] out object result)
		{
			result = null;
			return false;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0001EA1A File Offset: 0x0001CC1A
		public virtual bool TryConvert(T instance, ConvertBinder binder, [Nullable(2)] out object result)
		{
			result = null;
			return false;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0001EA13 File Offset: 0x0001CC13
		public virtual bool TryCreateInstance(T instance, CreateInstanceBinder binder, object[] args, [Nullable(2)] out object result)
		{
			result = null;
			return false;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00016B42 File Offset: 0x00014D42
		public virtual bool TryDeleteIndex(T instance, DeleteIndexBinder binder, object[] indexes)
		{
			return false;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00016B42 File Offset: 0x00014D42
		public virtual bool TryDeleteMember(T instance, DeleteMemberBinder binder)
		{
			return false;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0001EA13 File Offset: 0x0001CC13
		public virtual bool TryGetIndex(T instance, GetIndexBinder binder, object[] indexes, [Nullable(2)] out object result)
		{
			result = null;
			return false;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0001EA1A File Offset: 0x0001CC1A
		public virtual bool TryGetMember(T instance, GetMemberBinder binder, [Nullable(2)] out object result)
		{
			result = null;
			return false;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0001EA13 File Offset: 0x0001CC13
		public virtual bool TryInvoke(T instance, InvokeBinder binder, object[] args, [Nullable(2)] out object result)
		{
			result = null;
			return false;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0001EA13 File Offset: 0x0001CC13
		public virtual bool TryInvokeMember(T instance, InvokeMemberBinder binder, object[] args, [Nullable(2)] out object result)
		{
			result = null;
			return false;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00016B42 File Offset: 0x00014D42
		public virtual bool TrySetIndex(T instance, SetIndexBinder binder, object[] indexes, object value)
		{
			return false;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00016B42 File Offset: 0x00014D42
		public virtual bool TrySetMember(T instance, SetMemberBinder binder, object value)
		{
			return false;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0001EA1A File Offset: 0x0001CC1A
		public virtual bool TryUnaryOperation(T instance, UnaryOperationBinder binder, [Nullable(2)] out object result)
		{
			result = null;
			return false;
		}
	}
}
