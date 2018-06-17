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
    public class QPersonalViewModel : BaseTabVM
    {
        public QPersonalViewModel(INavigationService nav, IModuleManager mod, bool isFirst) : base(nav, mod, isFirst)
        {
        }

        public override void Init()
        {
           
        }
    }
}
