using UnityEngine;

namespace BrainlessLabs.KMP.Editor.Internal
{
    public class EditorStyles
    {
        #region LABELS
        
        static GUIStyle s_HeaderLabelStyle;
        static GUIStyle s_SignatureLabelStyle;
        static GUIStyle s_SubtitleLabelStyle;
        static GUIStyle s_TitleLabelStyle;
        static GUIStyle s_ContentLargeLabelStyle;
        static GUIStyle s_ContentNormalLabelStyle;
        static GUIStyle s_ContentSmallLabelStyle;
        static GUIStyle s_NoteLabelStyle;
        static GUIStyle s_ButtonNormalLabelStyle;
        static GUIStyle s_ButtonSmallLabelStyle;

        public static GUIStyle HeaderLabelStyle => s_HeaderLabelStyle ?? (s_HeaderLabelStyle = EditorStylesUtilities.CreateHeaderLabelStyle());
        
        public static GUIStyle SignatureLabelStyle => s_SignatureLabelStyle ?? (s_SignatureLabelStyle = EditorStylesUtilities.CreateSignatureLabelStyle());

        public static GUIStyle TitleLabelStyle => s_TitleLabelStyle ?? (s_TitleLabelStyle = EditorStylesUtilities.CreateTitleLabelStyle());
        
        public static GUIStyle SubtitleLabelStyle => s_SubtitleLabelStyle ?? (s_SubtitleLabelStyle = EditorStylesUtilities.CreateSubtitleLabelStyle());

        public static GUIStyle ContentLargeLabelStyle => s_ContentLargeLabelStyle ?? (s_ContentLargeLabelStyle = EditorStylesUtilities.CreateContentLargeLabelStyle());
        
        public static GUIStyle ContentNormalLabelStyle => s_ContentNormalLabelStyle ?? (s_ContentNormalLabelStyle = EditorStylesUtilities.CreateContentNormalLabelStyle());

        public static GUIStyle ContentSmallLabelStyle => s_ContentSmallLabelStyle ?? (s_ContentSmallLabelStyle = EditorStylesUtilities.CreateContentSmallLabelStyle());

        public static GUIStyle NoteLabelStyle => s_NoteLabelStyle ?? (s_NoteLabelStyle = EditorStylesUtilities.CreateNoteLabelStyle());

        public static GUIStyle ButtonNormalLabelStyle => s_ButtonNormalLabelStyle ?? (s_ButtonNormalLabelStyle = EditorStylesUtilities.CreateButtonNormalLabelStyle());

        public static GUIStyle ButtonSmallLabelStyle => s_ButtonSmallLabelStyle ?? (s_ButtonSmallLabelStyle = EditorStylesUtilities.CreateButtonSmallLabelStyle());
            
        #endregion
        
        
        #region WINDOWS
        
        static GUIStyle s_FrameStyle;
        static GUIStyle s_BoxStyle;
        static GUIStyle s_HelpBoxStyle;
        static GUIStyle s_ButtonStyle;
        static GUIStyle s_SmallButtonStyle;
        static GUIStyle s_RoundButtonStyle;
        static GUIStyle s_ToolbarStyle;
        static GUIStyle s_ScrollViewStyle;
        static GUIStyle s_ScrollViewFrameStyle;
        static GUIStyle s_DropMenuStyle;
        static GUIStyle s_IconStyle;
        static GUIStyle s_IconRightSideStyle;
        static GUIStyle s_HeaderStyle;
        static GUIStyle s_BodyStyle;
        static GUIStyle s_FooterStyle;
        static GUIStyle s_TabHeaderStyle;
        static GUIStyle s_TabBodyStyle;
        static GUIStyle s_TabFooterStyle;
        static GUIStyle s_TabButtonStyle;
        static GUIStyle s_TabActiveButtonStyle;
        static GUIStyle s_NumberField;

        public static GUIStyle FrameStyle => s_FrameStyle ?? (s_FrameStyle = EditorStylesUtilities.CreateFrameStyle());

        public static GUIStyle BoxStyle => s_BoxStyle ?? (s_BoxStyle = EditorStylesUtilities.CreateBoxStyle());

        public static GUIStyle HelpBoxStyle => s_HelpBoxStyle ?? (s_HelpBoxStyle = EditorStylesUtilities.CreateHelpBoxStyle());

        public static GUIStyle ButtonStyle => s_ButtonStyle ?? (s_ButtonStyle = EditorStylesUtilities.CreateButtonStyle());

        public static GUIStyle SmallButtonStyle => s_SmallButtonStyle ?? (s_SmallButtonStyle = EditorStylesUtilities.CreateSmallButtonStyle());

        public static GUIStyle RoundButtonStyle => s_RoundButtonStyle ?? (s_RoundButtonStyle = EditorStylesUtilities.CreateRoundButtonStyle());

        public static GUIStyle ToolbarStyle => s_ToolbarStyle ?? (s_ToolbarStyle = EditorStylesUtilities.CreateToolbarStyle());

        public static GUIStyle ScrollViewStyle => s_ScrollViewStyle ?? (s_ScrollViewStyle = EditorStylesUtilities.CreateScrollViewStyle());

        public static GUIStyle ScrollViewFrameStyle => s_ScrollViewFrameStyle ?? (s_ScrollViewFrameStyle = EditorStylesUtilities.CreateScrollViewFrameStyle());

        public static GUIStyle DropMenuStyle => s_DropMenuStyle ?? (s_DropMenuStyle = EditorStylesUtilities.CreateDropMenuStyle());

        public static GUIStyle IconStyle => s_IconStyle ?? (s_IconStyle = EditorStylesUtilities.CreateIconStyle());

        public static GUIStyle RightSideIconStyle => s_IconRightSideStyle ?? (s_IconRightSideStyle = EditorStylesUtilities.CreateRightSideIconStyle());

        public static GUIStyle HeaderStyle => s_HeaderStyle ?? (s_HeaderStyle = EditorStylesUtilities.CreateHeaderStyle());

        public static GUIStyle BodyStyle => s_BodyStyle ?? (s_BodyStyle = EditorStylesUtilities.CreateBodyStyle());

        public static GUIStyle FooterStyle => s_FooterStyle ?? (s_FooterStyle = EditorStylesUtilities.CreateFooterStyle());

        public static GUIStyle TabHeaderStyle => s_TabHeaderStyle ?? (s_TabHeaderStyle = EditorStylesUtilities.CreateTabHeaderStyle());

        public static GUIStyle TabBodyStyle => s_TabBodyStyle ?? (s_TabBodyStyle = EditorStylesUtilities.CreateTabBodyStyle());

        public static GUIStyle TabFooterStyle => s_TabFooterStyle ?? (s_TabFooterStyle = EditorStylesUtilities.CreateTabFooterStyle());

        public static GUIStyle TabButtonStyle => s_TabButtonStyle ?? (s_TabButtonStyle = EditorStylesUtilities.CreateTabButtonStyle());

        public static GUIStyle ActiveTabButtonStyle => s_TabActiveButtonStyle ?? (s_TabActiveButtonStyle = EditorStylesUtilities.CreateActiveTabButtonStyle());

        public static GUIStyle NumberField => s_NumberField ?? (s_NumberField = EditorStylesUtilities.CreateNumberField());

        #endregion
        
        
        #region SCROLLBARS
        
        static GUIStyle s_HorizontalScrollBarStyle;
        static GUIStyle s_VerticalScrollBarStyle;
        static GUIStyle s_HorizontalScrollBarThumbStyle;
        static GUIStyle s_VerticalScrollBarThumbStyle;
        static GUIStyle s_ScrollBarButtonStyle;


        public static GUIStyle HorizontalScrollBarStyle => s_HorizontalScrollBarStyle ?? (s_HorizontalScrollBarStyle = EditorStylesUtilities.CreateHorizontalScrollBarStyle());
        
        public static GUIStyle VerticalScrollBarStyle => s_VerticalScrollBarStyle ?? (s_VerticalScrollBarStyle = EditorStylesUtilities.CreateVerticalScrollBarStyle());

        public static GUIStyle HorizontalScrollBarThumbStyle => s_HorizontalScrollBarThumbStyle ?? (s_HorizontalScrollBarThumbStyle = EditorStylesUtilities.CreateHorizontalScrollBarThumbStyle());

        public static GUIStyle VerticalScrollBarThumbStyle => s_VerticalScrollBarThumbStyle ?? (s_VerticalScrollBarThumbStyle = EditorStylesUtilities.CreateVerticalScrollBarThumbStyle());

        public static GUIStyle ScrollBarButtonStyle => s_ScrollBarButtonStyle ?? (s_ScrollBarButtonStyle = EditorStylesUtilities.CreateScrollBarButtonStyle());


        #endregion
    }
}