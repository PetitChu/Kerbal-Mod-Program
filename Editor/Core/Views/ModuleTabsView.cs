using System.Collections.Generic;
using UnityEngine;

namespace KMP.Editor.Core.Views
{
    class ModuleTabsView : EditorView, IModuleTabsView
    {
        public int CurrentSelectionIndex => m_CurrentSelectionIndex;

        List<BaseModuleView> m_Modules;
        int m_CurrentSelectionIndex;
        
        protected override void OnGUI()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateModuleTabs(List<BaseModuleView> modules)
        {
            
        }

        public void ChangeSelection(int index)
        {
        }

        void ClearModuleTabs()
        {
            
        }
    }
}