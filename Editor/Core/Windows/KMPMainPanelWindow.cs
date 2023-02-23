using KMP.Editor.Core.Views;
using UnityEditor;
using UnityEngine;

namespace KMP.Editor.Core.Windows
{
    class KMPMainPanelWindow : KMPEditorWindow
    {

        const string k_WindowTitle = "Kerbal Mod Program";

        const float k_MinimumWidth = 700f;
        
        const float k_MinimumHeight = 400f;
        
        const string k_KMPMenuItemPath = "KMP/Main Panel";

        protected override string WindowTitle => k_WindowTitle;

        protected override float WindowMinimumWidth => k_MinimumWidth;

        protected override float WindowMinimumHeight => k_MinimumHeight;

        internal override bool IsLocked { get; set; }

        MainPanelView m_MainPanelView;

        [MenuItem(k_KMPMenuItemPath, priority = k_ConfigureMenuPriority)]
        static void ShowKMPMainPanel()
        {
            FindOrCreateWindow<KMPMainPanelWindow>();
        }

        KMPMainPanelWindow()
        {
            IsLocked = false;
        }
        
        void OnEnable()
        {
            if (m_MainPanelView == null)
                Reset();
        }

        void OnGUI()
        {
            // using (new UgcBridgeGuiLayout.PublishingPanelViewScope())
            {
                EditorGUI.BeginDisabledGroup(IsLocked);
                m_MainPanelView.DrawGUI();
                EditorGUI.EndDisabledGroup();
            }
        }
        
        void OnFocus()
        {
            if (m_MainPanelView != null)
                m_MainPanelView.OnFocus();
        }

        protected override void Reset()
        {
            m_MainPanelView = new MainPanelView();
            m_MainPanelView.Initialize();
        }
    }
}