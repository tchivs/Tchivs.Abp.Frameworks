﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tchivs.Abp.AspNetCore.Components.WebAssembly;
using Tchivs.Abp.UI.Toolbars;
using Volo.Abp.Modularity;

namespace Tchivs.Abp.UI.Radzen.WebAssembly
{
    [DependsOn(typeof(AbpUIRadzenModule))]
    public class AbpUIRadzenWebAssemblyModule : AbpAspNetCoreComponentsWebAssemblyBasicModule<RadzenBundleContributor>
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpToolbarOptions>(options =>
            {
               // options.Contributors.Add(new ToolbarContributor());
            });
        }
    }
}