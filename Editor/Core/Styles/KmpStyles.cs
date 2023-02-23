using UnityEngine;

namespace KMP.Editor.Core.Styles
{
    static class KmpStyles
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

        public static GUIStyle HeaderLabelStyle => s_HeaderLabelStyle ?? (s_HeaderLabelStyle = KmpStylesUtilities.CreateHeaderLabelStyle());
        
        public static GUIStyle SignatureLabelStyle => s_SignatureLabelStyle ?? (s_SignatureLabelStyle = KmpStylesUtilities.CreateSignatureLabelStyle());

        public static GUIStyle TitleLabelStyle => s_TitleLabelStyle ?? (s_TitleLabelStyle = KmpStylesUtilities.CreateTitleLabelStyle());
        
        public static GUIStyle SubtitleLabelStyle => s_SubtitleLabelStyle ?? (s_SubtitleLabelStyle = KmpStylesUtilities.CreateSubtitleLabelStyle());

        public static GUIStyle ContentLargeLabelStyle => s_ContentLargeLabelStyle ?? (s_ContentLargeLabelStyle = KmpStylesUtilities.CreateContentLargeLabelStyle());
        
        public static GUIStyle ContentNormalLabelStyle => s_ContentNormalLabelStyle ?? (s_ContentNormalLabelStyle = KmpStylesUtilities.CreateContentNormalLabelStyle());

        public static GUIStyle ContentSmallLabelStyle => s_ContentSmallLabelStyle ?? (s_ContentSmallLabelStyle = KmpStylesUtilities.CreateContentSmallLabelStyle());

        public static GUIStyle NoteLabelStyle => s_NoteLabelStyle ?? (s_NoteLabelStyle = KmpStylesUtilities.CreateNoteLabelStyle());

        public static GUIStyle ButtonNormalLabelStyle => s_ButtonNormalLabelStyle ?? (s_ButtonNormalLabelStyle = KmpStylesUtilities.CreateButtonNormalLabelStyle());

        public static GUIStyle ButtonSmallLabelStyle => s_ButtonSmallLabelStyle ?? (s_ButtonSmallLabelStyle = KmpStylesUtilities.CreateButtonSmallLabelStyle());
            
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
        static GUIStyle s_BoxField;

        public static GUIStyle FrameStyle => s_FrameStyle ?? (s_FrameStyle = KmpStylesUtilities.CreateFrameStyle());

        public static GUIStyle BoxStyle => s_BoxStyle ?? (s_BoxStyle = KmpStylesUtilities.CreateBoxStyle());

        public static GUIStyle HelpBoxStyle => s_HelpBoxStyle ?? (s_HelpBoxStyle = KmpStylesUtilities.CreateHelpBoxStyle());

        public static GUIStyle ButtonStyle => s_ButtonStyle ?? (s_ButtonStyle = KmpStylesUtilities.CreateButtonStyle());

        public static GUIStyle SmallButtonStyle => s_SmallButtonStyle ?? (s_SmallButtonStyle = KmpStylesUtilities.CreateSmallButtonStyle());

        public static GUIStyle RoundButtonStyle => s_RoundButtonStyle ?? (s_RoundButtonStyle = KmpStylesUtilities.CreateRoundButtonStyle());

        public static GUIStyle ToolbarStyle => s_ToolbarStyle ?? (s_ToolbarStyle = KmpStylesUtilities.CreateToolbarStyle());

        public static GUIStyle ScrollViewStyle => s_ScrollViewStyle ?? (s_ScrollViewStyle = KmpStylesUtilities.CreateScrollViewStyle());

        public static GUIStyle ScrollViewFrameStyle => s_ScrollViewFrameStyle ?? (s_ScrollViewFrameStyle = KmpStylesUtilities.CreateScrollViewFrameStyle());

        public static GUIStyle DropMenuStyle => s_DropMenuStyle ?? (s_DropMenuStyle = KmpStylesUtilities.CreateDropMenuStyle());

        public static GUIStyle IconStyle => s_IconStyle ?? (s_IconStyle = KmpStylesUtilities.CreateIconStyle());

        public static GUIStyle RightSideIconStyle => s_IconRightSideStyle ?? (s_IconRightSideStyle = KmpStylesUtilities.CreateRightSideIconStyle());

        public static GUIStyle HeaderStyle => s_HeaderStyle ?? (s_HeaderStyle = KmpStylesUtilities.CreateHeaderStyle());

        public static GUIStyle BodyStyle => s_BodyStyle ?? (s_BodyStyle = KmpStylesUtilities.CreateBodyStyle());

        public static GUIStyle FooterStyle => s_FooterStyle ?? (s_FooterStyle = KmpStylesUtilities.CreateFooterStyle());

        public static GUIStyle TabHeaderStyle => s_TabHeaderStyle ?? (s_TabHeaderStyle = KmpStylesUtilities.CreateTabHeaderStyle());

        public static GUIStyle TabBodyStyle => s_TabBodyStyle ?? (s_TabBodyStyle = KmpStylesUtilities.CreateTabBodyStyle());

        public static GUIStyle TabFooterStyle => s_TabFooterStyle ?? (s_TabFooterStyle = KmpStylesUtilities.CreateTabFooterStyle());

        public static GUIStyle TabButtonStyle => s_TabButtonStyle ?? (s_TabButtonStyle = KmpStylesUtilities.CreateTabButtonStyle());

        public static GUIStyle ActiveTabButtonStyle => s_TabActiveButtonStyle ?? (s_TabActiveButtonStyle = KmpStylesUtilities.CreateActiveTabButtonStyle());

        public static GUIStyle BoxField => s_BoxField ?? (s_BoxField = KmpStylesUtilities.CreateBoxFieldStyle());

        #endregion
        
        
        #region SCROLLBARS
        
        static GUIStyle s_HorizontalScrollBarStyle;
        static GUIStyle s_VerticalScrollBarStyle;
        static GUIStyle s_HorizontalScrollBarThumbStyle;
        static GUIStyle s_VerticalScrollBarThumbStyle;
        static GUIStyle s_ScrollBarButtonStyle;


        public static GUIStyle HorizontalScrollBarStyle => s_HorizontalScrollBarStyle ?? (s_HorizontalScrollBarStyle = KmpStylesUtilities.CreateHorizontalScrollBarStyle());
        
        public static GUIStyle VerticalScrollBarStyle => s_VerticalScrollBarStyle ?? (s_VerticalScrollBarStyle = KmpStylesUtilities.CreateVerticalScrollBarStyle());

        public static GUIStyle HorizontalScrollBarThumbStyle => s_HorizontalScrollBarThumbStyle ?? (s_HorizontalScrollBarThumbStyle = KmpStylesUtilities.CreateHorizontalScrollBarThumbStyle());

        public static GUIStyle VerticalScrollBarThumbStyle => s_VerticalScrollBarThumbStyle ?? (s_VerticalScrollBarThumbStyle = KmpStylesUtilities.CreateVerticalScrollBarThumbStyle());

        public static GUIStyle ScrollBarButtonStyle => s_ScrollBarButtonStyle ?? (s_ScrollBarButtonStyle = KmpStylesUtilities.CreateScrollBarButtonStyle());


        #endregion
    }
}