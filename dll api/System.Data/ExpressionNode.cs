using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;

namespace System.Data
{
	// Token: 0x0200005A RID: 90
	internal abstract class ExpressionNode
	{
		// Token: 0x060006C9 RID: 1737 RVA: 0x00020BF0 File Offset: 0x0001EDF0
		protected ExpressionNode(DataTable table)
		{
			this._table = table;
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x00020C00 File Offset: 0x0001EE00
		internal IFormatProvider FormatProvider
		{
			get
			{
				if (this._table == null)
				{
					return CultureInfo.CurrentCulture;
				}
				return this._table.FormatProvider;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x000020BC File Offset: 0x000002BC
		internal virtual bool IsSqlColumn
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x00020C28 File Offset: 0x0001EE28
		protected DataTable table
		{
			get
			{
				return this._table;
			}
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00020C30 File Offset: 0x0001EE30
		protected void BindTable(DataTable table)
		{
			this._table = table;
		}

		// Token: 0x060006CE RID: 1742
		internal abstract void Bind(DataTable table, List<DataColumn> list);

		// Token: 0x060006CF RID: 1743
		internal abstract object Eval();

		// Token: 0x060006D0 RID: 1744
		internal abstract object Eval(DataRow row, DataRowVersion version);

		// Token: 0x060006D1 RID: 1745
		internal abstract object Eval(int[] recordNos);

		// Token: 0x060006D2 RID: 1746
		internal abstract bool IsConstant();

		// Token: 0x060006D3 RID: 1747
		internal abstract bool IsTableConstant();

		// Token: 0x060006D4 RID: 1748
		internal abstract bool HasLocalAggregate();

		// Token: 0x060006D5 RID: 1749
		internal abstract bool HasRemoteAggregate();

		// Token: 0x060006D6 RID: 1750
		internal abstract ExpressionNode Optimize();

		// Token: 0x060006D7 RID: 1751 RVA: 0x000020BC File Offset: 0x000002BC
		internal virtual bool DependsOn(DataColumn column)
		{
			return false;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00020C39 File Offset: 0x0001EE39
		internal static bool IsInteger(StorageType type)
		{
			return type == StorageType.Int16 || type == StorageType.Int32 || type == StorageType.Int64 || type == StorageType.UInt16 || type == StorageType.UInt32 || type == StorageType.UInt64 || type == StorageType.SByte || type == StorageType.Byte;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00020C61 File Offset: 0x0001EE61
		internal static bool IsIntegerSql(StorageType type)
		{
			return type == StorageType.Int16 || type == StorageType.Int32 || type == StorageType.Int64 || type == StorageType.UInt16 || type == StorageType.UInt32 || type == StorageType.UInt64 || type == StorageType.SByte || type == StorageType.Byte || type == StorageType.SqlInt64 || type == StorageType.SqlInt32 || type == StorageType.SqlInt16 || type == StorageType.SqlByte;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00020C9D File Offset: 0x0001EE9D
		internal static bool IsSigned(StorageType type)
		{
			return type == StorageType.Int16 || type == StorageType.Int32 || type == StorageType.Int64 || type == StorageType.SByte || ExpressionNode.IsFloat(type);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00020CB9 File Offset: 0x0001EEB9
		internal static bool IsSignedSql(StorageType type)
		{
			return type == StorageType.Int16 || type == StorageType.Int32 || type == StorageType.Int64 || type == StorageType.SByte || type == StorageType.SqlInt64 || type == StorageType.SqlInt32 || type == StorageType.SqlInt16 || ExpressionNode.IsFloatSql(type);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00020CE4 File Offset: 0x0001EEE4
		internal static bool IsUnsigned(StorageType type)
		{
			return type == StorageType.UInt16 || type == StorageType.UInt32 || type == StorageType.UInt64 || type == StorageType.Byte;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00020CFA File Offset: 0x0001EEFA
		internal static bool IsUnsignedSql(StorageType type)
		{
			return type == StorageType.UInt16 || type == StorageType.UInt32 || type == StorageType.UInt64 || type == StorageType.SqlByte || type == StorageType.Byte;
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00020D15 File Offset: 0x0001EF15
		internal static bool IsNumeric(StorageType type)
		{
			return ExpressionNode.IsFloat(type) || ExpressionNode.IsInteger(type);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00020D27 File Offset: 0x0001EF27
		internal static bool IsNumericSql(StorageType type)
		{
			return ExpressionNode.IsFloatSql(type) || ExpressionNode.IsIntegerSql(type);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00020D39 File Offset: 0x0001EF39
		internal static bool IsFloat(StorageType type)
		{
			return type == StorageType.Single || type == StorageType.Double || type == StorageType.Decimal;
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00020D4C File Offset: 0x0001EF4C
		internal static bool IsFloatSql(StorageType type)
		{
			return type == StorageType.Single || type == StorageType.Double || type == StorageType.Decimal || type == StorageType.SqlDouble || type == StorageType.SqlDecimal || type == StorageType.SqlMoney || type == StorageType.SqlSingle;
		}

		// Token: 0x040001D4 RID: 468
		private DataTable _table;
	}
}
