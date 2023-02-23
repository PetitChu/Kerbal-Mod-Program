using System.Collections.Generic;
using UnityEngine;

namespace KMP.Editor.Core.Views
{
    interface IModuleTabsView
    {
        int CurrentSelectionIndex { get; }
        
        void UpdateModuleTabs(List<BaseModuleView> modules);
    }
}