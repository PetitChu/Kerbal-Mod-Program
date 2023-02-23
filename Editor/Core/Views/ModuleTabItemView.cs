using UnityEngine;

namespace KMP.Editor.Core.Views
{
    class ModuleTabItemView : EditorView
    {
        public bool IsSelected => m_IsSelected;
        
        string m_ModuleName;
        string m_ModuleDescription;
        bool m_IsSelected;
        
        public void Initialize(string moduleName, string moduleDescription)
        {
            base.Initialize();

            m_ModuleName = moduleName;
            m_ModuleDescription = moduleDescription;
        }

        protected override void OnGUI()
        {
            // TODO m_IsSelected ? active : normal
            
            // TODO Draw name label
            // TODO Draw description label
        }

        public void SetSelected(bool selected)
        {
            m_IsSelected = selected;
        }
    }
}