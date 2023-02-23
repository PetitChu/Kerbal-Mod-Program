using UnityEngine;

namespace KMP.Editor.Core.Views
{
    abstract class BaseModuleView : EditorView
    {
        protected abstract bool DrawHeader { get; }

        protected abstract string HeaderLabel { get; }
        
        protected abstract string DescriptionLabel { get; }

        protected abstract Texture2D HeaderIcon { get; }
        
        protected override void BeginGUI()
        {
            if (DrawHeader)
            {
                // TODO Draw Header
                // UgcBridgeGuiLayout.Separator();
            }
        }
        
        protected override void EndGUI()
        {
            if (DrawHeader)
            {
                // UgcBridgeGuiLayout.Separator();
            }
        }
    }
}