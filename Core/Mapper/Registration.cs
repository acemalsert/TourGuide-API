﻿using Microsoft.Extensions.DependencyInjection;
using TourGuide.Application.Interfaces.AutoMapper;

namespace TourGuide.Mapper
{
    public static class Registration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {
            services.AddSingleton<IMapper, AutoMapper.Mapper>();
        }
    }
}