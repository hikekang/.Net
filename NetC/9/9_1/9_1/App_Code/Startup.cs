﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_9_1.Startup))]
namespace _9_1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
