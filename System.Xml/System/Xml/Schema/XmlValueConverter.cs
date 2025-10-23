using System;

namespace System.Xml.Schema
{
	// Token: 0x0200032C RID: 812
	internal abstract class XmlValueConverter
	{
		// Token: 0x06001B08 RID: 6920
		public abstract bool ToBoolean(long value);

		// Token: 0x06001B09 RID: 6921
		public abstract bool ToBoolean(int value);

		// Token: 0x06001B0A RID: 6922
		public abstract bool ToBoolean(double value);

		// Token: 0x06001B0B RID: 6923
		public abstract bool ToBoolean(DateTime value);

		// Token: 0x06001B0C RID: 6924
		public abstract bool ToBoolean(string value);

		// Token: 0x06001B0D RID: 6925
		public abstract bool ToBoolean(object value);

		// Token: 0x06001B0E RID: 6926
		public abstract int ToInt32(bool value);

		// Token: 0x06001B0F RID: 6927
		public abstract int ToInt32(long value);

		// Token: 0x06001B10 RID: 6928
		public abstract int ToInt32(double value);

		// Token: 0x06001B11 RID: 6929
		public abstract int ToInt32(DateTime value);

		// Token: 0x06001B12 RID: 6930
		public abstract int ToInt32(string value);

		// Token: 0x06001B13 RID: 6931
		public abstract int ToInt32(object value);

		// Token: 0x06001B14 RID: 6932
		public abstract long ToInt64(bool value);

		// Token: 0x06001B15 RID: 6933
		public abstract long ToInt64(int value);

		// Token: 0x06001B16 RID: 6934
		public abstract long ToInt64(double value);

		// Token: 0x06001B17 RID: 6935
		public abstract long ToInt64(DateTime value);

		// Token: 0x06001B18 RID: 6936
		public abstract long ToInt64(string value);

		// Token: 0x06001B19 RID: 6937
		public abstract long ToInt64(object value);

		// Token: 0x06001B1A RID: 6938
		public abstract decimal ToDecimal(string value);

		// Token: 0x06001B1B RID: 6939
		public abstract decimal ToDecimal(object value);

		// Token: 0x06001B1C RID: 6940
		public abstract double ToDouble(bool value);

		// Token: 0x06001B1D RID: 6941
		public abstract double ToDouble(int value);

		// Token: 0x06001B1E RID: 6942
		public abstract double ToDouble(long value);

		// Token: 0x06001B1F RID: 6943
		public abstract double ToDouble(DateTime value);

		// Token: 0x06001B20 RID: 6944
		public abstract double ToDouble(string value);

		// Token: 0x06001B21 RID: 6945
		public abstract double ToDouble(object value);

		// Token: 0x06001B22 RID: 6946
		public abstract float ToSingle(double value);

		// Token: 0x06001B23 RID: 6947
		public abstract float ToSingle(string value);

		// Token: 0x06001B24 RID: 6948
		public abstract float ToSingle(object value);

		// Token: 0x06001B25 RID: 6949
		public abstract DateTime ToDateTime(bool value);

		// Token: 0x06001B26 RID: 6950
		public abstract DateTime ToDateTime(int value);

		// Token: 0x06001B27 RID: 6951
		public abstract DateTime ToDateTime(long value);

		// Token: 0x06001B28 RID: 6952
		public abstract DateTime ToDateTime(double value);

		// Token: 0x06001B29 RID: 6953
		public abstract DateTime ToDateTime(DateTimeOffset value);

		// Token: 0x06001B2A RID: 6954
		public abstract DateTime ToDateTime(string value);

		// Token: 0x06001B2B RID: 6955
		public abstract DateTime ToDateTime(object value);

		// Token: 0x06001B2C RID: 6956
		public abstract DateTimeOffset ToDateTimeOffset(DateTime value);

		// Token: 0x06001B2D RID: 6957
		public abstract DateTimeOffset ToDateTimeOffset(string value);

		// Token: 0x06001B2E RID: 6958
		public abstract DateTimeOffset ToDateTimeOffset(object value);

		// Token: 0x06001B2F RID: 6959
		public abstract string ToString(bool value);

		// Token: 0x06001B30 RID: 6960
		public abstract string ToString(int value);

		// Token: 0x06001B31 RID: 6961
		public abstract string ToString(long value);

		// Token: 0x06001B32 RID: 6962
		public abstract string ToString(decimal value);

		// Token: 0x06001B33 RID: 6963
		public abstract string ToString(float value);

		// Token: 0x06001B34 RID: 6964
		public abstract string ToString(double value);

		// Token: 0x06001B35 RID: 6965
		public abstract string ToString(DateTime value);

		// Token: 0x06001B36 RID: 6966
		public abstract string ToString(DateTimeOffset value);

		// Token: 0x06001B37 RID: 6967
		public abstract string ToString(object value);

		// Token: 0x06001B38 RID: 6968
		public abstract string ToString(object value, IXmlNamespaceResolver nsResolver);

		// Token: 0x06001B39 RID: 6969
		public abstract object ChangeType(bool value, Type destinationType);

		// Token: 0x06001B3A RID: 6970
		public abstract object ChangeType(int value, Type destinationType);

		// Token: 0x06001B3B RID: 6971
		public abstract object ChangeType(long value, Type destinationType);

		// Token: 0x06001B3C RID: 6972
		public abstract object ChangeType(decimal value, Type destinationType);

		// Token: 0x06001B3D RID: 6973
		public abstract object ChangeType(double value, Type destinationType);

		// Token: 0x06001B3E RID: 6974
		public abstract object ChangeType(DateTime value, Type destinationType);

		// Token: 0x06001B3F RID: 6975
		public abstract object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver);

		// Token: 0x06001B40 RID: 6976
		public abstract object ChangeType(object value, Type destinationType);

		// Token: 0x06001B41 RID: 6977
		public abstract object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver);
	}
}
