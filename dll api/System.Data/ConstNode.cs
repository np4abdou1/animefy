using System;
using System.Collections.Generic;
using System.Globalization;

namespace System.Data
{
	// Token: 0x02000058 RID: 88
	internal sealed class ConstNode : ExpressionNode
	{
		// Token: 0x060006AA RID: 1706 RVA: 0x00020408 File Offset: 0x0001E608
		internal ConstNode(DataTable table, ValueType type, object constant) : this(table, type, constant, true)
		{
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00020414 File Offset: 0x0001E614
		internal ConstNode(DataTable table, ValueType type, object constant, bool fParseQuotes) : base(table)
		{
			switch (type)
			{
			case ValueType.Null:
				this._val = DBNull.Value;
				return;
			case ValueType.Bool:
				this._val = Convert.ToBoolean(constant, CultureInfo.InvariantCulture);
				return;
			case ValueType.Numeric:
				this._val = this.SmallestNumeric(constant);
				return;
			case ValueType.Str:
				if (fParseQuotes)
				{
					this._val = ((string)constant).Replace("''", "'");
					return;
				}
				this._val = (string)constant;
				return;
			case ValueType.Float:
				this._val = Convert.ToDouble(constant, NumberFormatInfo.InvariantInfo);
				return;
			case ValueType.Decimal:
				this._val = this.SmallestDecimal(constant);
				return;
			case ValueType.Date:
				this._val = DateTime.Parse((string)constant, CultureInfo.InvariantCulture);
				return;
			}
			this._val = constant;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x000204F9 File Offset: 0x0001E6F9
		internal override void Bind(DataTable table, List<DataColumn> list)
		{
			base.BindTable(table);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00020502 File Offset: 0x0001E702
		internal override object Eval()
		{
			return this._val;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0002050A File Offset: 0x0001E70A
		internal override object Eval(DataRow row, DataRowVersion version)
		{
			return this.Eval();
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0002050A File Offset: 0x0001E70A
		internal override object Eval(int[] recordNos)
		{
			return this.Eval();
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00002317 File Offset: 0x00000517
		internal override bool IsConstant()
		{
			return true;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00002317 File Offset: 0x00000517
		internal override bool IsTableConstant()
		{
			return true;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x000020BC File Offset: 0x000002BC
		internal override bool HasLocalAggregate()
		{
			return false;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x000020BC File Offset: 0x000002BC
		internal override bool HasRemoteAggregate()
		{
			return false;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00002050 File Offset: 0x00000250
		internal override ExpressionNode Optimize()
		{
			return this;
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00020514 File Offset: 0x0001E714
		private object SmallestDecimal(object constant)
		{
			if (constant == null)
			{
				return 0.0;
			}
			string text = constant as string;
			if (text != null)
			{
				decimal num;
				if (decimal.TryParse(text, NumberStyles.Number, NumberFormatInfo.InvariantInfo, out num))
				{
					return num;
				}
				double num2;
				if (double.TryParse(text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out num2))
				{
					return num2;
				}
			}
			else
			{
				IConvertible convertible = constant as IConvertible;
				if (convertible != null)
				{
					try
					{
						return convertible.ToDecimal(NumberFormatInfo.InvariantInfo);
					}
					catch (ArgumentException e)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e);
					}
					catch (FormatException e2)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e2);
					}
					catch (InvalidCastException e3)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e3);
					}
					catch (OverflowException e4)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e4);
					}
					try
					{
						return convertible.ToDouble(NumberFormatInfo.InvariantInfo);
					}
					catch (ArgumentException e5)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e5);
					}
					catch (FormatException e6)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e6);
					}
					catch (InvalidCastException e7)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e7);
					}
					catch (OverflowException e8)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e8);
					}
					return constant;
				}
			}
			return constant;
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0002064C File Offset: 0x0001E84C
		private object SmallestNumeric(object constant)
		{
			if (constant == null)
			{
				return 0;
			}
			string text = constant as string;
			if (text != null)
			{
				int num;
				if (int.TryParse(text, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out num))
				{
					return num;
				}
				long num2;
				if (long.TryParse(text, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out num2))
				{
					return num2;
				}
				double num3;
				if (double.TryParse(text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out num3))
				{
					return num3;
				}
			}
			else
			{
				IConvertible convertible = constant as IConvertible;
				if (convertible != null)
				{
					try
					{
						return convertible.ToInt32(NumberFormatInfo.InvariantInfo);
					}
					catch (ArgumentException e)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e);
					}
					catch (FormatException e2)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e2);
					}
					catch (InvalidCastException e3)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e3);
					}
					catch (OverflowException e4)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e4);
					}
					try
					{
						return convertible.ToInt64(NumberFormatInfo.InvariantInfo);
					}
					catch (ArgumentException e5)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e5);
					}
					catch (FormatException e6)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e6);
					}
					catch (InvalidCastException e7)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e7);
					}
					catch (OverflowException e8)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e8);
					}
					try
					{
						return convertible.ToDouble(NumberFormatInfo.InvariantInfo);
					}
					catch (ArgumentException e9)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e9);
					}
					catch (FormatException e10)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e10);
					}
					catch (InvalidCastException e11)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e11);
					}
					catch (OverflowException e12)
					{
						ExceptionBuilder.TraceExceptionWithoutRethrow(e12);
					}
					return constant;
				}
			}
			return constant;
		}

		// Token: 0x040001CB RID: 459
		internal readonly object _val;
	}
}
