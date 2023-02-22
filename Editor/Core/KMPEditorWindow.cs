using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace BrainlessLabs.KMP.Editor.Core
{
    abstract class KMPEditorWindow : EditorWindow
    {
        protected const int k_ConfigureMenuPriority = 100;
        
        protected abstract string WindowTitle { get; }

        protected abstract float WindowMinimumWidth { get; }

        protected abstract float WindowMinimumHeight { get; }
        
        protected KMPEditorWindow()
        {
            EditorListener.OnReset -= Reset;
            EditorListener.OnReset += Reset;
        }
        
        protected virtual void OnInspectorUpdate()
        {
            Repaint();
        }
        
        // ReSharper disable Unity.PerformanceAnalysis
        internal static T FindOrCreateWindow<T>(Type[] desiredDockNextTo = null) where T : KMPEditorWindow
        {
            var kmpEditorWindow = Resources.FindObjectsOfTypeAll<T>().FirstOrDefault();
            if (kmpEditorWindow == null)
            {
                if (desiredDockNextTo == null)
                {
                    desiredDockNextTo = new Type[] {};
                }
                kmpEditorWindow = GetWindow<T>(desiredDockNextTo);
                kmpEditorWindow.minSize = new Vector2(kmpEditorWindow.WindowMinimumWidth, kmpEditorWindow.WindowMinimumHeight);
                kmpEditorWindow.name = kmpEditorWindow.WindowTitle;
                kmpEditorWindow.titleContent.text = kmpEditorWindow.WindowTitle;
            }

            kmpEditorWindow.Show(true);

            return kmpEditorWindow;
        }
        
        // ReSharper disable Unity.PerformanceAnalysis
        internal static void RefreshWindow<T>() where T : KMPEditorWindow
        {
            var kmpEditorWindow = FindOrCreateWindow<T>();
            if (kmpEditorWindow == null)
                return;

            kmpEditorWindow.Reset();
        }

        protected abstract void Reset();
    }
}