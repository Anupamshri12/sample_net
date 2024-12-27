//using Microsoft.AspNetCore.Mvc;
//using Microsoft.IdentityModel.Tokens;
//namespace WebApplication1.Middleware
//{
//    public class CustomAuthMiddleware
//    {
//        public readonly RequestDelegate _next;
//        public CustomAuthMiddleware(RequestDelegate next)
//        {
//            this._next = next;
//        }
//        public Task Invoke(HttpContext context)
//        {
//            var request = context.Request;
//            var path = request.Path.Value?.ToLower();
//            if (path != null && path.Contains("/postlogin"))
//            {
//                if (request.Headers.TryGetValue(path, out var value))
//                {

//                }
//            }


//        }
//    }
//}
