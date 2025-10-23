using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000FC RID: 252
	[Serializable]
	public sealed class CultureAwareComparer : StringComparer, ISerializable
	{
		// Token: 0x06000934 RID: 2356 RVA: 0x000293D9 File Offset: 0x000275D9
		internal CultureAwareComparer(CultureInfo culture, CompareOptions options) : this(culture.CompareInfo, options)
		{
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x000293E8 File Offset: 0x000275E8
		internal CultureAwareComparer(CompareInfo compareInfo, CompareOptions options)
		{
			this._compareInfo = compareInfo;
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
			{
				throw new ArgumentException("Value of flags is invalid.", "options");
			}
			this._options = options;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00029418 File Offset: 0x00027618
		private CultureAwareComparer(SerializationInfo info, StreamingContext context)
		{
			this._compareInfo = (CompareInfo)info.GetValue("_compareInfo", typeof(CompareInfo));
			bool boolean = info.GetBoolean("_ignoreCase");
			object valueNoThrow = info.GetValueNoThrow("_options", typeof(CompareOptions));
			if (valueNoThrow != null)
			{
				this._options = (CompareOptions)valueNoThrow;
			}
			this._options |= (boolean ? CompareOptions.IgnoreCase : CompareOptions.None);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00029490 File Offset: 0x00027690
		public override int Compare(string x, string y)
		{
			if (x == y)
			{
				return 0;
			}
			if (x == null)
			{
				return -1;
			}
			if (y == null)
			{
				return 1;
			}
			return this._compareInfo.Compare(x, y, this._options);
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x000294B5 File Offset: 0x000276B5
		public override bool Equals(string x, string y)
		{
			return x == y || (x != null && y != null && this._compareInfo.Compare(x, y, this._options) == 0);
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x000294DB File Offset: 0x000276DB
		public override int GetHashCode(string obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			return this._compareInfo.GetHashCodeOfString(obj, this._options);
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00029500 File Offset: 0x00027700
		public override bool Equals(object obj)
		{
			CultureAwareComparer cultureAwareComparer = obj as CultureAwareComparer;
			return cultureAwareComparer != null && this._options == cultureAwareComparer._options && this._compareInfo.Equals(cultureAwareComparer._compareInfo);
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00029538 File Offset: 0x00027738
		public override int GetHashCode()
		{
			return this._compareInfo.GetHashCode() ^ (int)(this._options & (CompareOptions)2147483647);
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00029552 File Offset: 0x00027752
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_compareInfo", this._compareInfo);
			info.AddValue("_options", this._options);
			info.AddValue("_ignoreCase", (this._options & CompareOptions.IgnoreCase) > CompareOptions.None);
		}

		// Token: 0x0400036F RID: 879
		private readonly CompareInfo _compareInfo;

		// Token: 0x04000370 RID: 880
		private CompareOptions _options;
	}
}
