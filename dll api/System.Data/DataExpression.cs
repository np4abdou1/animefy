using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlTypes;

namespace System.Data
{
	// Token: 0x02000059 RID: 89
	internal sealed class DataExpression : IFilter
	{
		// Token: 0x060006B7 RID: 1719 RVA: 0x00020804 File Offset: 0x0001EA04
		internal DataExpression(DataTable table, string expression) : this(table, expression, null)
		{
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00020810 File Offset: 0x0001EA10
		internal DataExpression(DataTable table, string expression, Type type)
		{
			ExpressionParser expressionParser = new ExpressionParser(table);
			expressionParser.LoadExpression(expression);
			this._originalExpression = expression;
			this._expr = null;
			if (expression != null)
			{
				this._storageType = DataStorage.GetStorageType(type);
				if (this._storageType == StorageType.BigInteger)
				{
					throw ExprException.UnsupportedDataType(type);
				}
				this._dataType = type;
				this._expr = expressionParser.Parse();
				this._parsed = true;
				if (this._expr != null && table != null)
				{
					this.Bind(table);
					return;
				}
				this._bound = false;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x0002089E File Offset: 0x0001EA9E
		internal string Expression
		{
			get
			{
				if (this._originalExpression == null)
				{
					return "";
				}
				return this._originalExpression;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x000208B4 File Offset: 0x0001EAB4
		internal ExpressionNode ExpressionNode
		{
			get
			{
				return this._expr;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x000208BC File Offset: 0x0001EABC
		internal bool HasValue
		{
			get
			{
				return this._expr != null;
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x000208C8 File Offset: 0x0001EAC8
		internal void Bind(DataTable table)
		{
			this._table = table;
			if (table == null)
			{
				return;
			}
			if (this._expr != null)
			{
				List<DataColumn> list = new List<DataColumn>();
				this._expr.Bind(table, list);
				this._expr = this._expr.Optimize();
				this._table = table;
				this._bound = true;
				this._dependency = list.ToArray();
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00020926 File Offset: 0x0001EB26
		internal bool DependsOn(DataColumn column)
		{
			return this._expr != null && this._expr.DependsOn(column);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0002093E File Offset: 0x0001EB3E
		internal object Evaluate()
		{
			return this.Evaluate(null, DataRowVersion.Default);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0002094C File Offset: 0x0001EB4C
		internal object Evaluate(DataRow row, DataRowVersion version)
		{
			if (!this._bound)
			{
				this.Bind(this._table);
			}
			object obj;
			if (this._expr != null)
			{
				obj = this._expr.Eval(row, version);
				if (obj == DBNull.Value && StorageType.Uri >= this._storageType)
				{
					return obj;
				}
				try
				{
					if (StorageType.Object != this._storageType)
					{
						obj = SqlConvert.ChangeType2(obj, this._storageType, this._dataType, this._table.FormatProvider);
					}
					return obj;
				}
				catch (Exception ex) when (ADP.IsCatchableExceptionType(ex))
				{
					ExceptionBuilder.TraceExceptionForCapture(ex);
					throw ExprException.DatavalueConvertion(obj, this._dataType, ex);
				}
			}
			obj = null;
			return obj;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00020A00 File Offset: 0x0001EC00
		internal object Evaluate(DataRow[] rows)
		{
			return this.Evaluate(rows, DataRowVersion.Default);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00020A10 File Offset: 0x0001EC10
		internal object Evaluate(DataRow[] rows, DataRowVersion version)
		{
			if (!this._bound)
			{
				this.Bind(this._table);
			}
			if (this._expr != null)
			{
				List<int> list = new List<int>();
				foreach (DataRow dataRow in rows)
				{
					if (dataRow.RowState != DataRowState.Deleted && (version != DataRowVersion.Original || dataRow._oldRecord != -1))
					{
						list.Add(dataRow.GetRecordFromVersion(version));
					}
				}
				int[] recordNos = list.ToArray();
				return this._expr.Eval(recordNos);
			}
			return DBNull.Value;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00020A98 File Offset: 0x0001EC98
		public bool Invoke(DataRow row, DataRowVersion version)
		{
			if (this._expr == null)
			{
				return true;
			}
			if (row == null)
			{
				throw ExprException.InvokeArgument();
			}
			object value = this._expr.Eval(row, version);
			bool result;
			try
			{
				result = DataExpression.ToBoolean(value);
			}
			catch (EvaluateException)
			{
				throw ExprException.FilterConvertion(this.Expression);
			}
			return result;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00020AF0 File Offset: 0x0001ECF0
		internal DataColumn[] GetDependency()
		{
			return this._dependency;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00020AF8 File Offset: 0x0001ECF8
		internal bool IsTableAggregate()
		{
			return this._expr != null && this._expr.IsTableConstant();
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00020B0F File Offset: 0x0001ED0F
		internal static bool IsUnknown(object value)
		{
			return DataStorage.IsObjectNull(value);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00020B17 File Offset: 0x0001ED17
		internal bool HasLocalAggregate()
		{
			return this._expr != null && this._expr.HasLocalAggregate();
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00020B2E File Offset: 0x0001ED2E
		internal bool HasRemoteAggregate()
		{
			return this._expr != null && this._expr.HasRemoteAggregate();
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00020B48 File Offset: 0x0001ED48
		internal static bool ToBoolean(object value)
		{
			if (DataExpression.IsUnknown(value))
			{
				return false;
			}
			if (value is bool)
			{
				return (bool)value;
			}
			if (value is SqlBoolean)
			{
				return ((SqlBoolean)value).IsTrue;
			}
			if (value is string)
			{
				try
				{
					return bool.Parse((string)value);
				}
				catch (Exception ex) when (ADP.IsCatchableExceptionType(ex))
				{
					ExceptionBuilder.TraceExceptionForCapture(ex);
					throw ExprException.DatavalueConvertion(value, typeof(bool), ex);
				}
			}
			throw ExprException.DatavalueConvertion(value, typeof(bool), null);
		}

		// Token: 0x040001CC RID: 460
		internal string _originalExpression;

		// Token: 0x040001CD RID: 461
		private bool _parsed;

		// Token: 0x040001CE RID: 462
		private bool _bound;

		// Token: 0x040001CF RID: 463
		private ExpressionNode _expr;

		// Token: 0x040001D0 RID: 464
		private DataTable _table;

		// Token: 0x040001D1 RID: 465
		private readonly StorageType _storageType;

		// Token: 0x040001D2 RID: 466
		private readonly Type _dataType;

		// Token: 0x040001D3 RID: 467
		private DataColumn[] _dependency = Array.Empty<DataColumn>();
	}
}
