using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlTypes;

namespace System.Data
{
	// Token: 0x0200006C RID: 108
	internal sealed class UnaryNode : ExpressionNode
	{
		// Token: 0x0600076F RID: 1903 RVA: 0x0002433F File Offset: 0x0002253F
		internal UnaryNode(DataTable table, int op, ExpressionNode right) : base(table)
		{
			this._op = op;
			this._right = right;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00024356 File Offset: 0x00022556
		internal override void Bind(DataTable table, List<DataColumn> list)
		{
			base.BindTable(table);
			this._right.Bind(table, list);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0001DAEA File Offset: 0x0001BCEA
		internal override object Eval()
		{
			return this.Eval(null, DataRowVersion.Default);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0002436C File Offset: 0x0002256C
		internal override object Eval(DataRow row, DataRowVersion version)
		{
			return this.EvalUnaryOp(this._op, this._right.Eval(row, version));
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00024387 File Offset: 0x00022587
		internal override object Eval(int[] recordNos)
		{
			return this._right.Eval(recordNos);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00024398 File Offset: 0x00022598
		private object EvalUnaryOp(int op, object vl)
		{
			object value = DBNull.Value;
			if (DataExpression.IsUnknown(vl))
			{
				return DBNull.Value;
			}
			switch (op)
			{
			case 0:
				return vl;
			case 1:
			{
				StorageType storageType = DataStorage.GetStorageType(vl.GetType());
				if (ExpressionNode.IsNumericSql(storageType))
				{
					switch (storageType)
					{
					case StorageType.Byte:
						return (int)(-(int)((byte)vl));
					case StorageType.Int16:
						return (int)(-(int)((short)vl));
					case StorageType.UInt16:
					case StorageType.UInt32:
					case StorageType.UInt64:
						break;
					case StorageType.Int32:
						return -(int)vl;
					case StorageType.Int64:
						return -(long)vl;
					case StorageType.Single:
						return -(float)vl;
					case StorageType.Double:
						return -(double)vl;
					case StorageType.Decimal:
						return -(decimal)vl;
					default:
						switch (storageType)
						{
						case StorageType.SqlDecimal:
							return -(SqlDecimal)vl;
						case StorageType.SqlDouble:
							return -(SqlDouble)vl;
						case StorageType.SqlInt16:
							return -(SqlInt16)vl;
						case StorageType.SqlInt32:
							return -(SqlInt32)vl;
						case StorageType.SqlInt64:
							return -(SqlInt64)vl;
						case StorageType.SqlMoney:
							return -(SqlMoney)vl;
						case StorageType.SqlSingle:
							return -(SqlSingle)vl;
						}
						break;
					}
					return DBNull.Value;
				}
				throw ExprException.TypeMismatch(this.ToString());
			}
			case 2:
			{
				StorageType storageType = DataStorage.GetStorageType(vl.GetType());
				if (ExpressionNode.IsNumericSql(storageType))
				{
					return vl;
				}
				throw ExprException.TypeMismatch(this.ToString());
			}
			case 3:
				if (vl is SqlBoolean)
				{
					if (((SqlBoolean)vl).IsFalse)
					{
						return SqlBoolean.True;
					}
					if (((SqlBoolean)vl).IsTrue)
					{
						return SqlBoolean.False;
					}
					throw ExprException.UnsupportedOperator(op);
				}
				else
				{
					if (DataExpression.ToBoolean(vl))
					{
						return false;
					}
					return true;
				}
				break;
			default:
				throw ExprException.UnsupportedOperator(op);
			}
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x000245E9 File Offset: 0x000227E9
		internal override bool IsConstant()
		{
			return this._right.IsConstant();
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000245F6 File Offset: 0x000227F6
		internal override bool IsTableConstant()
		{
			return this._right.IsTableConstant();
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00024603 File Offset: 0x00022803
		internal override bool HasLocalAggregate()
		{
			return this._right.HasLocalAggregate();
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00024610 File Offset: 0x00022810
		internal override bool HasRemoteAggregate()
		{
			return this._right.HasRemoteAggregate();
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0002461D File Offset: 0x0002281D
		internal override bool DependsOn(DataColumn column)
		{
			return this._right.DependsOn(column);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0002462C File Offset: 0x0002282C
		internal override ExpressionNode Optimize()
		{
			this._right = this._right.Optimize();
			if (this.IsConstant())
			{
				object constant = this.Eval();
				return new ConstNode(base.table, ValueType.Object, constant, false);
			}
			return this;
		}

		// Token: 0x04000255 RID: 597
		internal readonly int _op;

		// Token: 0x04000256 RID: 598
		internal ExpressionNode _right;
	}
}
