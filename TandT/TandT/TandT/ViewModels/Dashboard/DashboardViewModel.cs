﻿using Models.Base;
using Prism.Modularity;
using Prism.Navigation;

namespace TandT.ViewModels
{
	public class DashboardViewModel : BaseVM
	{
        public DashboardViewModel(INavigationService nav, IModuleManager mod) : base(nav, mod)
        {
            Title = "Dashboard";
        }

        public override void Init()
        {
            
        }
    }
}
