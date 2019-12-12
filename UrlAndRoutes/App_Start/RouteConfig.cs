using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;
using UrlAndRoutes.Infrastructure;

namespace UrlAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            // 어트리뷰트 라우트 활성화
            routes.MapMvcAttributeRoutes();

            routes.MapRoute("Default", "{controller}/{action}/{id}"
                , new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                , new[] { "UrlAndRoutes.Controllers" });

            /*
            routes.MapRoute("ChromeRoute", "{*catchall}"
                , new { controller = "Home", action = "Index" }
                , new { customConstraint = new UserAgentConstraint("Chrome") }
                , new[] { "UrlAndRoutes.AdditionalControllers" }
            );

            routes.MapRoute("defaultRoute", "{controller}/{action}"
                , new { controller = "Home", action = "Index" }
                , new[] { "UrlAndRoutes.Controllers" });

            routes.MapRoute("ShopSchema2", "Shop/OldAction", new { controller = "Home", action = "Index" });

            // 공개된 URL이 유지되어야하는 상태에서 응용프로그램이 변경되었을때 URL 유지하는 라우팅
            routes.MapRoute("ShopSchema", "Shop/{action}", new { controller = "Home" });

            // 정적 , 가변 URL 세그먼트 
            // 첫번째 세그먼트는 문자 X로 시작해야한다.
            routes.MapRoute("", "X{controller}/{action}");

            routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}"
                , new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                , new { 
                    controller = "^H.*"
                    , action = "^Index$|^About$"
                    , httpMethod = new HttpMethodConstraint("GET")
                    , id = new CompoundRouteConstraint(new IRouteConstraint[] { 
                        new AlphaRouteConstraint(), new MinLengthRouteConstraint(6) 
                    }) 
                } 
                , new[] { "UrlAndRoutes.Controllers" });

            // 정적 URL 세그먼트 사용하기
            routes.MapRoute("", "Public/{controller}/{action}", new { controller = "Home", action = "Index" });

            */
        }
    }
}
