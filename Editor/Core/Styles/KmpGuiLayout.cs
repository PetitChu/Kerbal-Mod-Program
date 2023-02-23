using System;
using UnityEditor;
using UnityEngine;

namespace KMP.Editor.Core.Styles
{
    static class KmpGuiLayout
    {
        #region SCOPES
        
        public class BaseModuleLayoutScope : GUI.Scope
        {
            public Rect rect { get; protected set; }

            public BaseModuleLayoutScope(params GUILayoutOption[] options)
            {
                this.rect = EditorGUILayout.BeginVertical(options);
                this.rect = EditorGUILayout.BeginHorizontal(options);
                GUILayout.Space(5f);
                
                this.rect = EditorGUILayout.BeginVertical(options);
            }

            public BaseModuleLayoutScope(GUIStyle style, params GUILayoutOption[] options)
            {
                this.rect = EditorGUILayout.BeginVertical(style, options);
                this.rect = EditorGUILayout.BeginHorizontal(style, options);
                GUILayout.Space(5f);
                
                this.rect = EditorGUILayout.BeginVertical(style, options);
            }

            protected override void CloseScope()
            {
                EditorGUILayout.EndVertical();
                
                GUILayout.Space(5f);
                EditorGUILayout.EndHorizontal();

                GUILayout.Space(10f);
                EditorGUILayout.EndVertical();
            }
        }

        public class ChangeGuiColorScope : GUI.Scope
        {
            Color m_BaseColor;
            
            public ChangeGuiColorScope(Color color)
            {
                m_BaseColor = GUI.color;
                GUI.color = color;
            }

            protected override void CloseScope()
            {
                GUI.color = m_BaseColor;
            }
        }

        public class HelpBoxScope : GUI.Scope
        {
            public Rect rect { get; protected set; }
            
            Color m_BaseColor;
            
            public HelpBoxScope(params GUILayoutOption[] options)
            {
                m_BaseColor = GUI.color;
                GUI.color = KmpStylesUtilities.HelpBoxColor;
                
                this.rect = EditorGUILayout.BeginHorizontal(options);
                GUILayout.Space(4f);
            }
            
            public HelpBoxScope(GUIStyle style, params GUILayoutOption[] options)
            {
                m_BaseColor = GUI.color;
                GUI.color = KmpStylesUtilities.HelpBoxColor;
                
                this.rect = EditorGUILayout.BeginHorizontal(style, options);
                GUILayout.Space(4f);
            }

            protected override void CloseScope()
            {
                GUILayout.Space(4f);
                EditorGUILayout.EndHorizontal();
                
                GUI.color = m_BaseColor;
            }
        }

        public class HorizontalCenteredContentScope : GUI.Scope
        {
            public Rect rect { get; protected set; }
            
            public HorizontalCenteredContentScope(params GUILayoutOption[] options)
            {
                this.rect = EditorGUILayout.BeginVertical(options);
                GUILayout.FlexibleSpace();
            }
            
            public HorizontalCenteredContentScope(GUIStyle style, params GUILayoutOption[] options)
            {
                this.rect = EditorGUILayout.BeginVertical(style, options);
                GUILayout.FlexibleSpace();
            }

            protected override void CloseScope()
            {
                GUILayout.FlexibleSpace();
                EditorGUILayout.EndVertical();
            }
        }
        
        #endregion
        
        
        #region PROPERTIES DRAWERS

        public static string TextField(string label, string tooltip, string value, float fieldWidth = 80f)
        {
            using (new EditorGUILayout.HorizontalScope())
            {
                var labelGuiContent = new GUIContent(label, tooltip);
                GUILayout.Label(labelGuiContent, KmpStyles.ContentNormalLabelStyle);
                GUILayout.FlexibleSpace();

                value = EditorGUILayout.TextField(value, KmpStyles.BoxField, GUILayout.Width(80f));
                return value;
            }
        }

        public static int IntField(string label, string tooltip, int value, float fieldWidth = 80f)
        {
            using (new EditorGUILayout.HorizontalScope())
            {
                var labelGuiContent = new GUIContent(label, tooltip);
                GUILayout.Label(labelGuiContent, KmpStyles.ContentNormalLabelStyle);
                GUILayout.FlexibleSpace();
                
                value = EditorGUILayout.IntField(value, KmpStyles.BoxField, GUILayout.Width(fieldWidth));
                return value;
            }
        }

        public static float FloatField(string label, string tooltip, float value, float fieldWidth = 80f)
        {
            using (new EditorGUILayout.HorizontalScope())
            {
                var labelGuiContent = new GUIContent(label, tooltip);
                GUILayout.Label(labelGuiContent, KmpStyles.ContentNormalLabelStyle);
                GUILayout.FlexibleSpace();
                
                value = EditorGUILayout.FloatField(value, KmpStyles.BoxField, GUILayout.Width(fieldWidth));
                return value;
            }
        }

        public static GameObject GameObjectField(string label, string tooltip, GameObject value, float fieldWidth = 80f)
        {
            using (new EditorGUILayout.HorizontalScope())
            {
                var labelGuiContent = new GUIContent(label, tooltip);
                GUILayout.Label(labelGuiContent, KmpStyles.ContentNormalLabelStyle);
                GUILayout.FlexibleSpace();
                
                value = (GameObject) EditorGUILayout.ObjectField(value, typeof(GameObject), false, GUILayout.Width(fieldWidth));
                return value;
            }
        }

        #endregion
        
        
        #region BUTTONS

        public static bool Button(string label, string tooltip, Color color, float width = 80f, float height = 28f)
        {
            using (new ChangeGuiColorScope(color))
            {
                var rect = GUILayoutUtility.GetRect(new GUIContent(), KmpStyles.ButtonStyle, GUILayout.Width(width), GUILayout.Height(height));
                var isPressed = GUI.Button(rect, "", KmpStyles.ButtonStyle);

                using (new ChangeGuiColorScope(KmpStylesUtilities.ButtonFontColor))
                {
                    var labelGuiContent = new GUIContent(label, tooltip);
                    GUI.Label(rect, labelGuiContent, KmpStyles.ButtonNormalLabelStyle);
                }
                
                return isPressed;
            }
        }

        public static bool SmallButton(string label, string tooltip, Color color, float width = 50f, float height = 24f)
        {
            using (new ChangeGuiColorScope(color))
            {
                var rect = GUILayoutUtility.GetRect(new GUIContent(), KmpStyles.SmallButtonStyle, GUILayout.Width(width), GUILayout.Height(height));
                var isPressed = GUI.Button(rect, "", KmpStyles.SmallButtonStyle);

                using (new ChangeGuiColorScope(KmpStylesUtilities.ButtonFontColor))
                {
                    var labelGuiContent = new GUIContent(label, tooltip);
                    GUI.Label(rect, labelGuiContent, KmpStyles.ButtonSmallLabelStyle);
                }

                return isPressed;
            }
        }

        public static bool FullWidthButton(string label, string tooltip, Color color, float height = 28f)
        {
            using (new ChangeGuiColorScope(color))
            {
                var rect = GUILayoutUtility.GetRect(new GUIContent(), KmpStyles.ButtonStyle, GUILayout.Height(height));
                var isPressed = GUI.Button(rect, "", KmpStyles.ButtonStyle);

                using (new ChangeGuiColorScope(KmpStylesUtilities.ButtonFontColor))
                {
                    var labelGuiContent = new GUIContent(label, tooltip);
                    GUI.Label(rect, labelGuiContent, KmpStyles.ButtonNormalLabelStyle);
                }

                return isPressed;
            }
        }

        public static bool RoundButton(string label, string tooltip, Color color, float size = 28f)
        {
            using (new ChangeGuiColorScope(color))
            {
                var rect = GUILayoutUtility.GetRect(new GUIContent(), KmpStyles.RoundButtonStyle, GUILayout.Width(size), GUILayout.Height(size));
                var isPressed = GUI.Button(rect, "", KmpStyles.RoundButtonStyle);

                using (new ChangeGuiColorScope(KmpStylesUtilities.ButtonFontColor)) // white so the icon isn't colored
                {
                    var labelGuiContent = new GUIContent(label, tooltip);
                    GUI.Label(rect, labelGuiContent, KmpStyles.IconStyle);
                }

                return isPressed;
            }
        }
        
        public static bool RoundButton(Texture2D icon, string tooltip, Color color, float size = 28f)
        {
            using (new ChangeGuiColorScope(color))
            {
                var rect = GUILayoutUtility.GetRect(new GUIContent(), KmpStyles.RoundButtonStyle, GUILayout.Width(size), GUILayout.Height(size));
                var isPressed = GUI.Button(rect, "", KmpStyles.RoundButtonStyle);

                using (new ChangeGuiColorScope(Color.white)) // white so the icon isn't colored
                {
                    var iconGuiContent = new GUIContent(icon, tooltip);
                    GUI.Label(rect, iconGuiContent, KmpStyles.IconStyle);
                }

                return isPressed;
            }
        }

        public static bool ButtonToggle(string label, string tooltip, bool value)
        {
            using (new EditorGUILayout.HorizontalScope())
            {
                if (!string.IsNullOrEmpty(label))
                {
                    GUIContent labelContent = new GUIContent(label, tooltip);
                    GUILayout.Label(labelContent, KmpStyles.ContentNormalLabelStyle);
                }
                
                GUILayout.FlexibleSpace();

                var toggleOnColor = value ? KmpStylesUtilities.ToggleOnActiveColor : KmpStylesUtilities.ToggleInactiveColor;
                using (new ChangeGuiColorScope(toggleOnColor))
                {
                    var toggleOnRect = GUILayoutUtility.GetRect(new GUIContent(""), KmpStyles.SmallButtonStyle, GUILayout.Width(40f), GUILayout.Height(24f));
                    if(GUI.Button(toggleOnRect, "", KmpStyles.SmallButtonStyle))
                    {
                        value = true;
                    }

                    using (new ChangeGuiColorScope(KmpStylesUtilities.ButtonFontColor))
                    {
                        GUI.Label(toggleOnRect, "ON", KmpStyles.ButtonSmallLabelStyle);
                    }
                }

                var toggleOffColor = value ? KmpStylesUtilities.ToggleInactiveColor : KmpStylesUtilities.ToggleOffActiveColor;
                using (new ChangeGuiColorScope(toggleOffColor))
                {
                    var toggleOffRect = GUILayoutUtility.GetRect(new GUIContent(""), KmpStyles.SmallButtonStyle, GUILayout.Width(40f), GUILayout.Height(24f));
                    if (GUI.Button(toggleOffRect, "", KmpStyles.SmallButtonStyle))
                    {
                        value = false;
                    }
                    
                    using (new ChangeGuiColorScope(KmpStylesUtilities.ButtonFontColor))
                    {
                        GUI.Label(toggleOffRect, "OFF", KmpStyles.ButtonSmallLabelStyle);
                    }
                }
            }
            
            return value;
        }
        
        #endregion
        
        
        #region POPUPS

        public static int PopupMenu(string label, string tooltip, int selected, string[] labels, float width = 80f)
        {
            using (new EditorGUILayout.HorizontalScope())
            {
                var labelGuiContent = new GUIContent(label, tooltip);
                GUILayout.Label(labelGuiContent, KmpStyles.ContentNormalLabelStyle);
                GUILayout.FlexibleSpace();
                
                var rect = GUILayoutUtility.GetRect(new GUIContent(), KmpStyles.DropMenuStyle, GUILayout.Width(width), GUILayout.Height(28f));
                selected = EditorGUI.Popup(rect, selected, labels, KmpStyles.DropMenuStyle);
                
                GUI.Label(rect, KmpStylesUtilities.DownIcon, KmpStyles.RightSideIconStyle);
            }

            return selected;
        }

        public static Enum EnumPopupMenu(string label, string tooltip, Enum selected, float width = 80f)
        {
            using (new EditorGUILayout.HorizontalScope())
            {
                var labelGuiContent = new GUIContent(label, tooltip);
                GUILayout.Label(labelGuiContent, KmpStyles.ContentNormalLabelStyle);
                GUILayout.FlexibleSpace();
                
                var rect = GUILayoutUtility.GetRect(new GUIContent(), KmpStyles.DropMenuStyle, GUILayout.Width(width), GUILayout.Height(28f));
                selected = EditorGUI.EnumPopup(rect, selected, KmpStyles.DropMenuStyle);
                
                GUI.Label(rect, KmpStylesUtilities.DownIcon, KmpStyles.RightSideIconStyle);
            }

            return selected;
        }
        
        #endregion
        
        
        #region HELPBOXES

        public static void HelpBox(string message)
        {
            using (new HelpBoxScope())
            {
                using (new HorizontalCenteredContentScope())
                {
                    var rect = GUILayoutUtility.GetRect(new GUIContent(""), KmpStyles.IconStyle, GUILayout.Width(35f), GUILayout.Height(35f));
                    using (new ChangeGuiColorScope(KmpStylesUtilities.WarningColor))
                    {
                        GUI.Label(rect, KmpStylesUtilities.SignOctagonal, KmpStyles.IconStyle);
                    }

                    using (new ChangeGuiColorScope(KmpStylesUtilities.AlwaysBlackFontColor))
                    {
                        GUI.Label(rect, KmpStylesUtilities.InfoIcon, KmpStyles.IconStyle);
                    }
                }

                using (new HorizontalCenteredContentScope())
                {
                    var labelGuiContent = new GUIContent(message);
                    using (new ChangeGuiColorScope(KmpStylesUtilities.AlwaysBlackFontColor))
                    {
                        GUILayout.Label(labelGuiContent, KmpStyles.ContentSmallLabelStyle);
                    }
                }
            }
        }
        
        public static void HelpBoxWithAction(string message, string actionLabel, Action actionCallback)
        {
            using (new HelpBoxScope())
            {
                using (new HorizontalCenteredContentScope())
                {
                    var rect = GUILayoutUtility.GetRect(new GUIContent(""), KmpStyles.IconStyle, GUILayout.Width(35f), GUILayout.Height(35f));
                    using (new ChangeGuiColorScope(KmpStylesUtilities.WarningColor))
                    {
                        GUI.Label(rect, KmpStylesUtilities.SignOctagonal, KmpStyles.IconStyle);
                    }

                    using (new ChangeGuiColorScope(KmpStylesUtilities.AlwaysBlackFontColor))
                    {
                        GUI.Label(rect, KmpStylesUtilities.InfoIcon, KmpStyles.IconStyle);
                    }
                }

                using (new HorizontalCenteredContentScope())
                {
                    var labelGuiContent = new GUIContent(message);
                    using (new ChangeGuiColorScope(KmpStylesUtilities.AlwaysBlackFontColor))
                    {
                        GUILayout.Label(labelGuiContent, KmpStyles.ContentSmallLabelStyle);
                    }
                }

                using (new EditorGUILayout.HorizontalScope())
                {
                    GUILayout.Space(4f);

                    if (Button(actionLabel, "", KmpStylesUtilities.WarningButtonColor, 95f, 50f))
                    {
                        actionCallback?.Invoke();
                    }
                    GUILayout.Space(4f);
                }
            }
        }
        
        #endregion
    }
}