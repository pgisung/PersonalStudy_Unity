using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStudy
{
    // SPA Single Page Application
    // 레이아웃으로 사용하기 위해선 @inherits LayoutComponentBase
    // @layout << 해당 레이아웃 적용
    //_Imports.razor = 같은 디렉토리 경로에 존재하는 모든 파일에 이 코드 적용
    // App.razor => Startup.cs의 endpoint에서 작성하던 도메인 여기서
    // NavLink / NavigationManager - 비슷한 이런 것도 있다
    // @page "/[상대경로]" 형식으로 도메인을 찾아가는데 RouteParameter를 이용해 도메인 값을 이용해 작업할 수 있다
    // Routing 상대경로 위주로 생각...?

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
