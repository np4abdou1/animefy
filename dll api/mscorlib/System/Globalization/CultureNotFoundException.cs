using System;
using System.Runtime.Serialization;

namespace System.Globalization
{
	/// <summary>The exception that is thrown when a method attempts to construct a culture that is not available.</summary>
	// Token: 0x02000579 RID: 1401
	[Serializable]
	public class CultureNotFoundException : ArgumentException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureNotFoundException" /> class with its message string set to a system-supplied message.</summary>
		// Token: 0x060029FB RID: 10747 RVA: 0x000A7AAA File Offset: 0x000A5CAA
		public CultureNotFoundException() : base(CultureNotFoundException.DefaultMessage)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureNotFoundException" /> class with a specified error message and the name of the parameter that is the cause this exception.</summary>
		/// <param name="paramName">The name of the parameter that is the cause of the current exception.</param>
		/// <param name="message">The error message to display with this exception.</param>
		// Token: 0x060029FC RID: 10748 RVA: 0x000A7AB7 File Offset: 0x000A5CB7
		public CultureNotFoundException(string paramName, string message) : base(message, paramName)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureNotFoundException" /> class using the specified serialization data and context.</summary>
		/// <param name="info">The object that holds the serialized object data.</param>
		/// <param name="context">The contextual information about the source or destination.</param>
		// Token: 0x060029FD RID: 10749 RVA: 0x000A7AC4 File Offset: 0x000A5CC4
		protected CultureNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._invalidCultureId = (int?)info.GetValue("InvalidCultureId", typeof(int?));
			this._invalidCultureName = (string)info.GetValue("InvalidCultureName", typeof(string));
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the parameter name and additional exception information.</summary>
		/// <param name="info">The object that holds the serialized object data.</param>
		/// <param name="context">The contextual information about the source or destination.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />.</exception>
		// Token: 0x060029FE RID: 10750 RVA: 0x000A7B1C File Offset: 0x000A5D1C
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("InvalidCultureId", this._invalidCultureId, typeof(int?));
			info.AddValue("InvalidCultureName", this._invalidCultureName, typeof(string));
		}

		/// <summary>Gets the culture identifier that cannot be found.</summary>
		/// <returns>The invalid culture identifier. </returns>
		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060029FF RID: 10751 RVA: 0x000A7B6C File Offset: 0x000A5D6C
		public virtual int? InvalidCultureId
		{
			get
			{
				return this._invalidCultureId;
			}
		}

		/// <summary>Gets the culture name that cannot be found.</summary>
		/// <returns>The invalid culture name.</returns>
		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06002A00 RID: 10752 RVA: 0x000A7B74 File Offset: 0x000A5D74
		public virtual string InvalidCultureName
		{
			get
			{
				return this._invalidCultureName;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06002A01 RID: 10753 RVA: 0x000A7B7C File Offset: 0x000A5D7C
		private static string DefaultMessage
		{
			get
			{
				return "Culture is not supported.";
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06002A02 RID: 10754 RVA: 0x000A7B84 File Offset: 0x000A5D84
		private string FormatedInvalidCultureId
		{
			get
			{
				if (this.InvalidCultureId == null)
				{
					return this.InvalidCultureName;
				}
				return string.Format(CultureInfo.InvariantCulture, "{0} (0x{0:x4})", this.InvalidCultureId.Value);
			}
		}

		/// <summary>Gets the error message that explains the reason for the exception.</summary>
		/// <returns>A text string describing the details of the exception.</returns>
		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06002A03 RID: 10755 RVA: 0x000A7BCC File Offset: 0x000A5DCC
		public override string Message
		{
			get
			{
				string message = base.Message;
				if (this._invalidCultureId == null && this._invalidCultureName == null)
				{
					return message;
				}
				string text = SR.Format("{0} is an invalid culture identifier.", this.FormatedInvalidCultureId);
				if (message == null)
				{
					return text;
				}
				return message + Environment.NewLine + text;
			}
		}

		// Token: 0x040015D5 RID: 5589
		private string _invalidCultureName;

		// Token: 0x040015D6 RID: 5590
		private int? _invalidCultureId;
	}
}
