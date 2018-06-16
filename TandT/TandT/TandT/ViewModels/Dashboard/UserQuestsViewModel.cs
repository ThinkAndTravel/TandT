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
	public class UserQuestsViewModel : BaseTabVM
	{
        public UserQuestsViewModel(INavigationService nav, IModuleManager mod) : base(nav, mod, false)
        {
        }

        public override void Init()
        {
            
        }

    }
}
