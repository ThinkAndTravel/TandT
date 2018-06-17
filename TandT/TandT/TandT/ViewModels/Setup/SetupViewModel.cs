using Models.Base;
using Prism.Commands;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TandT.ViewModels
{
	public class SetupViewModel : BaseVM
	{
        public SetupViewModel(INavigationService nav, IModuleManager mod) : base(nav, mod)
        {
            Title = "Setup";
        }

        public override void Init()
        {
            
        }
    }
}
