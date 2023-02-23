using UnityEngine;

namespace KMP.Editor.Core.Views
{
    abstract class EditorView
    {
        public virtual void Initialize() { }
        
        public virtual void DrawGUI()
        {
            BeginGUI();
            OnGUI();
            EndGUI();
        }

        public virtual void OnFocus() {}

        protected virtual void BeginGUI() { }
        
        protected abstract void OnGUI();

        protected virtual void EndGUI() { }
    }
}