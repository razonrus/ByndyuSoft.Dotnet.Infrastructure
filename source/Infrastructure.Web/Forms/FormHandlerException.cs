namespace ByndyuSoft.Infrastructure.Web.Forms
{
    using System;

    public class FormHandlerException : Exception
	{
		public FormHandlerException()
		{
		}

		public FormHandlerException(string key, string message)
			: this(message)
		{
			Key = key;
		}

		public FormHandlerException(string message)
			: base(message)
		{
		}

		public FormHandlerException(string message, Exception inner)
			: base(message, inner)
		{
		}

		public string Key { get; private set; }
	}
}