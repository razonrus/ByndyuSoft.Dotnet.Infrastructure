using Microsoft.AspNetCore.Http;

namespace ByndyuSoft.Infrastructure.Web.Extensions
{
	public static class HttpContextExtensions
	{
		/// <summary>
		/// Проверка аутентифицирован пользователь
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		public static bool IsAuthenticated(this HttpContext context)
		{
			return context.User != null && context.User.Identity.IsAuthenticated;
		}
	}
}