using Application.Interface.Context;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    public class DpContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            service.AddScoped<INiazRoozDBContext, NiazRoozDBContext>();
        }
    }
}
