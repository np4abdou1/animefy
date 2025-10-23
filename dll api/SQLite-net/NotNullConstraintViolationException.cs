using System;
using System.Collections.Generic;
using System.Linq;

namespace SQLite
{
	// Token: 0x02000003 RID: 3
	public class NotNullConstraintViolationException : SQLiteException
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000207A File Offset: 0x0000027A
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002082 File Offset: 0x00000282
		public IEnumerable<TableMapping.Column> Columns { get; protected set; }

		// Token: 0x06000007 RID: 7 RVA: 0x0000208B File Offset: 0x0000028B
		protected NotNullConstraintViolationException(SQLite3.Result r, string message) : this(r, message, null, null)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002098 File Offset: 0x00000298
		protected NotNullConstraintViolationException(SQLite3.Result r, string message, TableMapping mapping, object obj) : base(r, message)
		{
			if (mapping != null && obj != null)
			{
				this.Columns = from c in mapping.Columns
				where !c.IsNullable && c.GetValue(obj) == null
				select c;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020E3 File Offset: 0x000002E3
		public new static NotNullConstraintViolationException New(SQLite3.Result r, string message)
		{
			return new NotNullConstraintViolationException(r, message);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020EC File Offset: 0x000002EC
		public static NotNullConstraintViolationException New(SQLite3.Result r, string message, TableMapping mapping, object obj)
		{
			return new NotNullConstraintViolationException(r, message, mapping, obj);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020F7 File Offset: 0x000002F7
		public static NotNullConstraintViolationException New(SQLiteException exception, TableMapping mapping, object obj)
		{
			return new NotNullConstraintViolationException(exception.Result, exception.Message, mapping, obj);
		}
	}
}
