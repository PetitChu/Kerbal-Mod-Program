using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace BrainlessLabs.KMP.Editor.Core
{
    static class EditorListener
    {
        internal static event Action OnReset;

        internal static event Action OnUpdate;

        static Queue<Action> RunOnceActions;

        static EditorListener()
        {
            Reset();
        }

        static void Reset()
        {
            RunOnceActions = new Queue<Action>();

            EditorApplication.update -= Update;
            EditorApplication.update += Update;
            EditorApplication.playModeStateChanged -= ModeChanged;
            EditorApplication.playModeStateChanged += ModeChanged;

            OnReset?.Invoke();
        }

        static void Update()
        {
            OnUpdate?.Invoke();

            while (RunOnceActions.Count != 0)
            {
                var action = RunOnceActions.Dequeue();
                action.Invoke();
            }
        }

        static void ModeChanged(PlayModeStateChange state)
        {
            if (state == PlayModeStateChange.EnteredEditMode)
            {
                Reset();
            }
        }

        [PostProcessBuild]
        static void OnPostprocessBuild(BuildTarget target, string path)
        {
            Reset();
        }

        [DidReloadScripts]
        static void OnScriptsReload()
        {
            Reset();
        }

        internal static void QueueAction(Action action)
        {
            RunOnceActions.Enqueue(action);
        }
    }
}