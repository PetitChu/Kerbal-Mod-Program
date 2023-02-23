using UnityEditor;
using UnityEngine;

namespace KMP.Editor.Core.Styles
{
    static class KmpStylesUtilities
    {
        const string k_EditorStylesResourcesPath = "Packages/com.brainlesslabs.kmp/Editor/Internal/KMPStylesResources.asset";
        
        static KmpStylesResources s_KmpStylesResources = GetEditorStylesResources();

        internal static Texture2D Logo => s_KmpStylesResources != null ? s_KmpStylesResources.logo : null;
        
        internal static Font HeaderFont => s_KmpStylesResources != null ? s_KmpStylesResources.headerFont : UnityEditor.EditorStyles.boldFont;

        internal static Font ContentFont => s_KmpStylesResources != null ? s_KmpStylesResources.contentFont : UnityEditor.EditorStyles.standardFont;

        internal static Font NoteFont => s_KmpStylesResources != null ? s_KmpStylesResources.noteFont : UnityEditor.EditorStyles.miniFont;
        
        internal static Font ButtonFont => s_KmpStylesResources != null ? s_KmpStylesResources.buttonFont : UnityEditor.EditorStyles.miniBoldFont;

        internal static Texture2D CheckIcon => s_KmpStylesResources != null ? s_KmpStylesResources.checkIcon : null;

        internal static Texture2D XIcon => s_KmpStylesResources != null ? s_KmpStylesResources.xIcon : null;

        internal static Texture2D PlusIcon => s_KmpStylesResources != null ? s_KmpStylesResources.plusIcon : null;

        internal static Texture2D MinusIcon => s_KmpStylesResources != null ? s_KmpStylesResources.minusIcon : null;

        internal static Texture2D EditIcon => s_KmpStylesResources != null ? s_KmpStylesResources.editIcon : null;

        internal static Texture2D InfoIcon => s_KmpStylesResources != null ? s_KmpStylesResources.infoIcon : null;

        internal static Texture2D LeftIcon => s_KmpStylesResources != null ? s_KmpStylesResources.leftIcon : null;

        internal static Texture2D RightIcon => s_KmpStylesResources != null ? s_KmpStylesResources.rightIcon : null;

        internal static Texture2D UpIcon => s_KmpStylesResources != null ? s_KmpStylesResources.upIcon : null;

        internal static Texture2D DownIcon => s_KmpStylesResources != null ? s_KmpStylesResources.downIcon : null;
        
        internal static Texture2D HeaderTexture => s_KmpStylesResources != null ? s_KmpStylesResources.headerTexture : null;
        
        internal static Texture2D BodyTexture => s_KmpStylesResources != null ? s_KmpStylesResources.bodyTexture : null;
        
        internal static Texture2D FooterTexture => s_KmpStylesResources != null ? s_KmpStylesResources.footerTexture : null;

        internal static Texture2D TabHeaderTexture => s_KmpStylesResources != null ? s_KmpStylesResources.tabHeaderTexture : null;
        
        internal static Texture2D TabBodyTexture => s_KmpStylesResources != null ? s_KmpStylesResources.tabBodyTexture : null;
        
        internal static Texture2D TabFooterTexture => s_KmpStylesResources != null ? s_KmpStylesResources.tabFooterTexture : null;

        internal static Texture2D TabButtonNormalTexture => s_KmpStylesResources != null ? s_KmpStylesResources.tabButtonNormalTexture : null;
        
        internal static Texture2D TabButtonActiveTexture => s_KmpStylesResources != null ? s_KmpStylesResources.tabButtonActiveTexture : null;
        
        internal static Texture2D TabButtonClickTexture => s_KmpStylesResources != null ? s_KmpStylesResources.tabButtonClickTexture : null;

        internal static Texture2D FrameTexture => s_KmpStylesResources != null ? s_KmpStylesResources.frameTexture : null;
        
        internal static Texture2D BoxTexture => s_KmpStylesResources != null ? s_KmpStylesResources.boxTexture : null;
        
        internal static Texture2D HelpBoxTexture => s_KmpStylesResources != null ? s_KmpStylesResources.helpBoxTexture : null;
        
        internal static Texture2D ScrollViewTexture => s_KmpStylesResources != null ? s_KmpStylesResources.scrollViewTexture : null;
        
        internal static Texture2D ScrollThumbTexture => s_KmpStylesResources != null ? s_KmpStylesResources.scrollThumbTexture : null;
        
        internal static Texture2D FieldTexture => s_KmpStylesResources != null ? s_KmpStylesResources.fieldTexture : null;

        internal static Texture2D ButtonTexture => s_KmpStylesResources != null ? s_KmpStylesResources.buttonTexture : null;
        
        internal static Texture2D ButtonDarkTexture => s_KmpStylesResources != null ? s_KmpStylesResources.buttonDarkTexture : null;
        
        internal static Texture2D ButtonRoundTexture => s_KmpStylesResources != null ? s_KmpStylesResources.buttonRoundTexture : null;
        
        internal static Texture2D ButtonRoundDarkTexture => s_KmpStylesResources != null ? s_KmpStylesResources.buttonRoundDarkTexture : null;

        internal static Texture2D SignOctagonal => s_KmpStylesResources != null ? s_KmpStylesResources.signOctagonal : null;
        
        internal static Texture2D SignTriangle => s_KmpStylesResources != null ? s_KmpStylesResources.signTriangle : null;

        internal static Color HeaderFontColor => s_KmpStylesResources != null ? s_KmpStylesResources.headerFontColor : Color.white;
        
        internal static Color ContentFontColor => s_KmpStylesResources != null ? s_KmpStylesResources.contentFontColor : Color.white;
        
        internal static Color NoteFontColor => s_KmpStylesResources != null ? s_KmpStylesResources.noteFontColor : Color.white;
        
        internal static Color ButtonFontColor => s_KmpStylesResources != null ? s_KmpStylesResources.buttonFontColor : Color.white;
        
        internal static Color AlwaysBlackFontColor => s_KmpStylesResources != null ? s_KmpStylesResources.alwaysBlackFontColor : Color.black;
        
        internal static Color SeparatorColor => s_KmpStylesResources != null ? s_KmpStylesResources.separatorColor : Color.white;
        
        internal static Color ToggleOnActiveColor => s_KmpStylesResources != null ? s_KmpStylesResources.toggleOnActiveColor : Color.green;
        
        internal static Color ToggleOffActiveColor => s_KmpStylesResources != null ? s_KmpStylesResources.toggleOffActiveColor : Color.red;
        
        internal static Color ToggleInactiveColor => s_KmpStylesResources != null ? s_KmpStylesResources.toggleInactiveColor : Color.grey;
        
        internal static Color HelpBoxColor => s_KmpStylesResources != null ? s_KmpStylesResources.helpBoxColor : Color.red;
        
        internal static Color WarningColor => s_KmpStylesResources != null ? s_KmpStylesResources.warningColor : Color.yellow;
        
        internal static Color WarningButtonColor => s_KmpStylesResources != null ? s_KmpStylesResources.warningButtonColor : Color.grey;
        
        internal static KmpStylesResources GetEditorStylesResources()
        {
            var editorStylesResources = (KmpStylesResources) AssetDatabase.LoadAssetAtPath(k_EditorStylesResourcesPath, typeof(KmpStylesResources));
            if (editorStylesResources == null)
            {
                Debug.LogWarning($"{nameof(KmpStylesResources)} was not found at path: {k_EditorStylesResourcesPath}");
            }

            return editorStylesResources;
        }

        internal static GUIStyle CreateHeaderLabelStyle()
        {
            var headerLabelStyle = new GUIStyle("IN Title");
            headerLabelStyle.richText = true;
            headerLabelStyle.fixedHeight = 42;
            headerLabelStyle.font = HeaderFont;
            headerLabelStyle.fontSize = 34;
            headerLabelStyle.alignment = TextAnchor.LowerLeft;
            headerLabelStyle.fontStyle = FontStyle.Normal;
            headerLabelStyle.padding = new RectOffset(4, 4, 4, 4);
            headerLabelStyle.normal.textColor = HeaderFontColor;

            return headerLabelStyle;
        }

        internal static GUIStyle CreateSignatureLabelStyle()
        {
            var signatureLabelStyle = new GUIStyle("IN TitleText");
            signatureLabelStyle.richText = true;
            signatureLabelStyle.fixedHeight = 20;
            signatureLabelStyle.font = HeaderFont;
            signatureLabelStyle.fontSize = 11;
            signatureLabelStyle.alignment = TextAnchor.LowerLeft;
            signatureLabelStyle.fontStyle = FontStyle.Normal;
            signatureLabelStyle.padding = new RectOffset(8, 4, 4, 4);
            signatureLabelStyle.normal.textColor = HeaderFontColor;

            return signatureLabelStyle;
        }

        internal static GUIStyle CreateTitleLabelStyle()
        {
            var titleLabelStyle = new GUIStyle("IN TitleText");
            titleLabelStyle.richText = true;
            titleLabelStyle.fixedHeight = 30;
            titleLabelStyle.font = HeaderFont;
            titleLabelStyle.fontSize = 18;
            titleLabelStyle.alignment = TextAnchor.LowerLeft;
            titleLabelStyle.fontStyle = FontStyle.Italic;
            titleLabelStyle.padding = new RectOffset(6, 4, 4, 4);
            titleLabelStyle.normal.textColor = ContentFontColor;

            return titleLabelStyle;
        }

        public static GUIStyle CreateSubtitleLabelStyle()
        {
            var subtitleLabelStyle = new GUIStyle("IN TitleText");
            subtitleLabelStyle.richText = true;
            subtitleLabelStyle.fixedHeight = 28;
            subtitleLabelStyle.font = HeaderFont;
            subtitleLabelStyle.fontSize = 15;
            subtitleLabelStyle.alignment = TextAnchor.LowerLeft;
            subtitleLabelStyle.fontStyle = FontStyle.Italic;
            subtitleLabelStyle.padding = new RectOffset(6, 4, 4, 4);
            subtitleLabelStyle.normal.textColor = ContentFontColor;

            return subtitleLabelStyle;
        }

        public static GUIStyle CreateContentLargeLabelStyle()
        {
            var contentLargeLabelStyle = new GUIStyle("Label");
            contentLargeLabelStyle.wordWrap = true;
            contentLargeLabelStyle.richText = true;
            contentLargeLabelStyle.fontSize = 18;
            contentLargeLabelStyle.font = ContentFont;
            contentLargeLabelStyle.alignment = TextAnchor.MiddleLeft;
            contentLargeLabelStyle.fontStyle = FontStyle.BoldAndItalic;
            contentLargeLabelStyle.padding = new RectOffset(10, 10, 4, 4);
            contentLargeLabelStyle.normal.textColor = ContentFontColor;

            return contentLargeLabelStyle;
        }

        public static GUIStyle CreateContentNormalLabelStyle()
        {
            var contentNormalLabelStyle = new GUIStyle("Label");
            contentNormalLabelStyle.wordWrap = true;
            contentNormalLabelStyle.richText = true;
            contentNormalLabelStyle.fontSize = 15;
            contentNormalLabelStyle.fixedHeight = 28;
            contentNormalLabelStyle.font = ContentFont;
            contentNormalLabelStyle.alignment = TextAnchor.MiddleLeft;
            contentNormalLabelStyle.fontStyle = FontStyle.Normal;
            contentNormalLabelStyle.padding = new RectOffset(10, 10, 4, 4);
            contentNormalLabelStyle.normal.textColor = ContentFontColor;

            return contentNormalLabelStyle;
        }

        public static GUIStyle CreateContentSmallLabelStyle()
        {
            var contentSmallLabelStyle = new GUIStyle("Label");
            contentSmallLabelStyle.wordWrap = true;
            contentSmallLabelStyle.richText = true;
            contentSmallLabelStyle.fontSize = 12;
            contentSmallLabelStyle.font = ContentFont;
            contentSmallLabelStyle.alignment = TextAnchor.MiddleLeft;
            contentSmallLabelStyle.fontStyle = FontStyle.Bold;
            contentSmallLabelStyle.padding = new RectOffset(10, 10, 4, 4);
            contentSmallLabelStyle.normal.textColor = ContentFontColor;

            return contentSmallLabelStyle;
        }


        public static GUIStyle CreateNoteLabelStyle()
        {
            var noteLabelStyle = new GUIStyle("Label");
            noteLabelStyle.wordWrap = true;
            noteLabelStyle.richText = true;
            noteLabelStyle.fontSize = 14;
            noteLabelStyle.font = NoteFont;
            noteLabelStyle.alignment = TextAnchor.LowerLeft;
            noteLabelStyle.fontStyle = FontStyle.Normal;
            noteLabelStyle.normal.textColor = NoteFontColor;

            return noteLabelStyle;
        }

        public static GUIStyle CreateButtonNormalLabelStyle()
        {
            var buttonNormalLabelStyle = new GUIStyle("Label");
            buttonNormalLabelStyle.wordWrap = true;
            buttonNormalLabelStyle.richText = true;
            buttonNormalLabelStyle.fontSize = 16;
            buttonNormalLabelStyle.font = ButtonFont;
            buttonNormalLabelStyle.alignment = TextAnchor.MiddleCenter;
            buttonNormalLabelStyle.fontStyle = FontStyle.Normal;
            buttonNormalLabelStyle.padding = new RectOffset(0, 0, 3, 0);
            buttonNormalLabelStyle.normal.textColor = ButtonFontColor;

            return buttonNormalLabelStyle;
        }

        public static GUIStyle CreateButtonSmallLabelStyle()
        {
            var buttonSmallLabelStyle = new GUIStyle("Label");
            buttonSmallLabelStyle.wordWrap = true;
            buttonSmallLabelStyle.richText = true;
            buttonSmallLabelStyle.fontSize = 13;
            buttonSmallLabelStyle.font = ButtonFont;
            buttonSmallLabelStyle.alignment = TextAnchor.MiddleCenter;
            buttonSmallLabelStyle.fontStyle = FontStyle.Normal;
            buttonSmallLabelStyle.padding = new RectOffset(0, 0, 2, 0);
            buttonSmallLabelStyle.normal.textColor = ButtonFontColor;

            return buttonSmallLabelStyle;
        }

        public static GUIStyle CreateFrameStyle()
        {
            var editorFrameStyle = new GUIStyle("Box");
            editorFrameStyle.normal.background = FrameTexture;
            editorFrameStyle.border = new RectOffset(8, 8, 8, 8);
            editorFrameStyle.margin = new RectOffset(2, 2, 4, 4);
            editorFrameStyle.padding = new RectOffset(8, 8, 6, 6);

            return editorFrameStyle;
        }

        public static GUIStyle CreateBoxStyle()
        {
            var editorBoxStyle = new GUIStyle("Box");
            editorBoxStyle.normal.background = BoxTexture;

            return editorBoxStyle;
        }

        public static GUIStyle CreateHelpBoxStyle()
        {
            var editorHelpBoxStyle = new GUIStyle("Helpbox");
            editorHelpBoxStyle.normal.background = HelpBoxTexture;
            editorHelpBoxStyle.border = new RectOffset(8, 8, 8, 8);
            editorHelpBoxStyle.margin = new RectOffset(2, 2, 4, 4);
            editorHelpBoxStyle.padding = new RectOffset(4, 8, 6, 6);

            return editorHelpBoxStyle;
        }

        public static GUIStyle CreateButtonStyle()
        {
            var editorButtonStyle = new GUIStyle("Button");
            editorButtonStyle.normal.background = ButtonTexture;
            editorButtonStyle.active.background = ButtonDarkTexture;
            editorButtonStyle.border = new RectOffset(8, 8, 8, 8);
            editorButtonStyle.margin = new RectOffset(0, 0, 0, 0);
            editorButtonStyle.padding = new RectOffset(0, 0, 0, 4);
            editorButtonStyle.alignment = TextAnchor.LowerCenter;
            editorButtonStyle.fontSize = 15;
            editorButtonStyle.font = ContentFont;
            editorButtonStyle.fontStyle = FontStyle.Bold;
            editorButtonStyle.normal.textColor = ButtonFontColor;

            return editorButtonStyle;
        }

        public static GUIStyle CreateSmallButtonStyle()
        {
            var editorSmallButtonStyle = new GUIStyle("Button");
            editorSmallButtonStyle.normal.background = ButtonTexture;
            editorSmallButtonStyle.active.background = ButtonDarkTexture;
            editorSmallButtonStyle.border = new RectOffset(8, 8, 8, 8);
            editorSmallButtonStyle.margin = new RectOffset(0, 0, 2, 0);
            editorSmallButtonStyle.padding = new RectOffset(0, 0, 0, 6);
            editorSmallButtonStyle.alignment = TextAnchor.LowerCenter;
            editorSmallButtonStyle.fontSize = 12;
            editorSmallButtonStyle.font = ContentFont;
            editorSmallButtonStyle.fontStyle = FontStyle.Bold;
            editorSmallButtonStyle.normal.textColor = ButtonFontColor;

            return editorSmallButtonStyle;
        }

        public static GUIStyle CreateRoundButtonStyle()
        {
            var editorRoundButtonStyle = new GUIStyle("Button");
            editorRoundButtonStyle.normal.background = ButtonRoundTexture;
            editorRoundButtonStyle.active.background = ButtonRoundDarkTexture;
            editorRoundButtonStyle.border = new RectOffset(0, 0, 0, 0);
            editorRoundButtonStyle.margin = new RectOffset(0, 0, 0, 0);
            editorRoundButtonStyle.padding = new RectOffset(0, 0, 0, 0);
            editorRoundButtonStyle.imagePosition = ImagePosition.ImageOnly;
            editorRoundButtonStyle.alignment = TextAnchor.MiddleCenter;
            editorRoundButtonStyle.stretchWidth = false;
            editorRoundButtonStyle.stretchHeight = false;
            editorRoundButtonStyle.fontSize = 8;
            editorRoundButtonStyle.font = ContentFont;
            editorRoundButtonStyle.fontStyle = FontStyle.Bold;
            editorRoundButtonStyle.normal.textColor = ButtonFontColor;

            return editorRoundButtonStyle;
        }

        public static GUIStyle CreateToolbarStyle()
        {
            var editorToolbarStyle = new GUIStyle("Toolbar");
            return editorToolbarStyle;
        }

        public static GUIStyle CreateScrollViewStyle()
        {
            var editorScrollViewStyle = new GUIStyle("Box");
            editorScrollViewStyle.normal.background = ScrollViewTexture;
            editorScrollViewStyle.border = new RectOffset(8, 8, 8, 8);
            editorScrollViewStyle.margin = new RectOffset(2, 2, 4, 4);
            editorScrollViewStyle.padding = new RectOffset(4, 4, 6, 6);

            return editorScrollViewStyle;
        }

        public static GUIStyle CreateScrollViewFrameStyle()
        {
            var editorScrollViewFrameStyle = new GUIStyle("Box");
            editorScrollViewFrameStyle.normal.background = FrameTexture;
            editorScrollViewFrameStyle.border = new RectOffset(8, 8, 8, 8);
            editorScrollViewFrameStyle.margin = new RectOffset(2, 2, 4, 4);
            editorScrollViewFrameStyle.padding = new RectOffset(4, 4, 4, 4);
            
            return editorScrollViewFrameStyle;
        }

        public static GUIStyle CreateDropMenuStyle()
        {
            var editorDropMenuStyle = new GUIStyle(UnityEditor.EditorStyles.popup);
            editorDropMenuStyle.normal.background = BoxTexture;
            editorDropMenuStyle.focused.background = BoxTexture;
            editorDropMenuStyle.active.background = BoxTexture;
            editorDropMenuStyle.normal.textColor = ContentFontColor;
            editorDropMenuStyle.focused.textColor = ContentFontColor;
            editorDropMenuStyle.active.textColor = ContentFontColor;
            editorDropMenuStyle.fixedHeight = 24f;
            editorDropMenuStyle.border = new RectOffset(4, 4, 4, 4);
            editorDropMenuStyle.margin = new RectOffset(0, 0, 0, 0);
            editorDropMenuStyle.padding = new RectOffset(8, 4, 4, 4);
            editorDropMenuStyle.alignment = TextAnchor.LowerLeft;
            editorDropMenuStyle.font = ContentFont;
            editorDropMenuStyle.fontSize = 13;

            return editorDropMenuStyle;
        }

        public static GUIStyle CreateIconStyle()
        {
            var editorIconStyle = new GUIStyle("Label");
            editorIconStyle.imagePosition = ImagePosition.ImageOnly;
            editorIconStyle.alignment = TextAnchor.MiddleCenter;
            editorIconStyle.stretchWidth = false;
            editorIconStyle.stretchHeight = false;
            editorIconStyle.border = new RectOffset(0, 0, 0, 0);
            editorIconStyle.margin = new RectOffset(0, 0, 0, 0);
            editorIconStyle.padding = new RectOffset(0, 0, 3, 0);

            return editorIconStyle;
        }

        public static GUIStyle CreateRightSideIconStyle()
        {
            var editorIconRightSideStyle = new GUIStyle("Label");
            editorIconRightSideStyle.imagePosition = ImagePosition.ImageOnly;
            editorIconRightSideStyle.alignment = TextAnchor.MiddleRight;
            editorIconRightSideStyle.stretchWidth = false;
            editorIconRightSideStyle.stretchHeight = false;
            editorIconRightSideStyle.border = new RectOffset(0, 0, 0, 0);
            editorIconRightSideStyle.margin = new RectOffset(0, 0, 0, 0);
            editorIconRightSideStyle.padding = new RectOffset(0, 4, 4, 4);

            return editorIconRightSideStyle;
        }

        public static GUIStyle CreateHeaderStyle()
        {
            var editorHeaderStyle = new GUIStyle("Box");
            editorHeaderStyle.normal.background = HeaderTexture;
            editorHeaderStyle.border = new RectOffset(0, 0, 0, 32);
            editorHeaderStyle.margin = new RectOffset(0, 0, 0, 0);
            editorHeaderStyle.alignment = TextAnchor.LowerLeft;

            return editorHeaderStyle;
        }

        public static GUIStyle CreateBodyStyle()
        {
            var editorBodyStyle = new GUIStyle("Box");
            editorBodyStyle.normal.background = BodyTexture;
            editorBodyStyle.border = new RectOffset(4, 4, 4, 4);
            editorBodyStyle.margin = new RectOffset(0, 0, 0, 0);
            editorBodyStyle.padding = new RectOffset(0, 0, 0, 0);
            editorBodyStyle.alignment = TextAnchor.LowerLeft;

            return editorBodyStyle;
        }

        public static GUIStyle CreateFooterStyle()
        {
            var editorFooterStyle = new GUIStyle("Box");
            editorFooterStyle.normal.background = FooterTexture;
            editorFooterStyle.border = new RectOffset(0, 128, 32, 0);
            editorFooterStyle.margin = new RectOffset(0, 0, 0, 0);
            editorFooterStyle.padding = new RectOffset(0, 0, 0, 0);
            editorFooterStyle.alignment = TextAnchor.LowerLeft;

            return editorFooterStyle;
        }

        public static GUIStyle CreateTabHeaderStyle()
        {
            var editorTabHeaderStyle = new GUIStyle("Box");
            editorTabHeaderStyle.normal.background = TabHeaderTexture;
            editorTabHeaderStyle.border = new RectOffset(64, 16, 16, 32);
            editorTabHeaderStyle.margin = new RectOffset(0, 0, 0, 0);
            editorTabHeaderStyle.alignment = TextAnchor.LowerLeft;

            return editorTabHeaderStyle;
        }

        public static GUIStyle CreateTabBodyStyle()
        {
            var editorTabBodyStyle = new GUIStyle("Box");
            editorTabBodyStyle.normal.background = TabBodyTexture;
            editorTabBodyStyle.border = new RectOffset(64, 16, 8, 8);
            editorTabBodyStyle.margin = new RectOffset(0, 0, 0, 0);
            editorTabBodyStyle.padding = new RectOffset(4, 0, 0, 0);
            editorTabBodyStyle.alignment = TextAnchor.LowerLeft;

            return editorTabBodyStyle;
        }

        public static GUIStyle CreateTabFooterStyle()
        {
            var editorTabFooterStyle = new GUIStyle("Box");
            editorTabFooterStyle.normal.background = TabFooterTexture;
            editorTabFooterStyle.border = new RectOffset(64, 128, 16, 8);
            editorTabFooterStyle.margin = new RectOffset(0, 0, 0, 0);
            editorTabFooterStyle.alignment = TextAnchor.LowerLeft;

            return editorTabFooterStyle;
        }

        public static GUIStyle CreateTabButtonStyle()
        {
            var editorTabButtonStyle = new GUIStyle("Box");
            editorTabButtonStyle.normal.background = TabButtonNormalTexture;
            editorTabButtonStyle.active.background = TabButtonClickTexture;
            editorTabButtonStyle.border = new RectOffset(32, 32, 0, 0);
            editorTabButtonStyle.padding = new RectOffset(0, 26, 0, 0);
            editorTabButtonStyle.margin = new RectOffset(0, 0, 0, 0);
            editorTabButtonStyle.alignment = TextAnchor.MiddleRight;
            editorTabButtonStyle.font = ContentFont;
            editorTabButtonStyle.fontSize = 14;
            editorTabButtonStyle.normal.textColor = ContentFontColor;
            editorTabButtonStyle.active.textColor = ContentFontColor;
            editorTabButtonStyle.fontStyle = FontStyle.Normal;

            return editorTabButtonStyle;
        }

        public static GUIStyle CreateActiveTabButtonStyle()
        {
            var editorTabActiveButtonStyle = new GUIStyle("Box");
            editorTabActiveButtonStyle.normal.background = TabButtonActiveTexture;
            editorTabActiveButtonStyle.active.background = TabButtonClickTexture;
            editorTabActiveButtonStyle.border = new RectOffset(32, 32, 0, 0);
            editorTabActiveButtonStyle.margin = new RectOffset(0, 0, 0, 0);
            editorTabActiveButtonStyle.padding = new RectOffset(0, 26, 0, 0);
            editorTabActiveButtonStyle.alignment = TextAnchor.MiddleRight;
            editorTabActiveButtonStyle.font = ContentFont;
            editorTabActiveButtonStyle.fontSize = 14;
            editorTabActiveButtonStyle.normal.textColor = ContentFontColor;
            editorTabActiveButtonStyle.active.textColor = ContentFontColor;
            editorTabActiveButtonStyle.fontStyle = FontStyle.Bold;

            return editorTabActiveButtonStyle;
        }

        public static GUIStyle CreateBoxFieldStyle()
        {
            var boxFieldStyle = new GUIStyle(UnityEditor.EditorStyles.numberField);
            boxFieldStyle.normal.background = FieldTexture;
            boxFieldStyle.active.background = FieldTexture;
            boxFieldStyle.focused.background = FieldTexture;
            boxFieldStyle.hover.background = FieldTexture;
            boxFieldStyle.fixedHeight = 28f;
            boxFieldStyle.margin = new RectOffset(0, 0, 0, 0);
            boxFieldStyle.padding = new RectOffset(6, 6, 2, 2);
            boxFieldStyle.border = new RectOffset(4, 4, 4, 4);
            boxFieldStyle.font = ContentFont;
            boxFieldStyle.fontSize = 14;
            boxFieldStyle.alignment = TextAnchor.MiddleLeft;

            return boxFieldStyle;
        }

        public static GUIStyle CreateHorizontalScrollBarStyle()
        {
            var horizontalScrollBarStyle = new GUIStyle(GUI.skin.horizontalScrollbar);
            horizontalScrollBarStyle.normal.background = null;
            horizontalScrollBarStyle.overflow = new RectOffset(0, 0, 0, 0);
            horizontalScrollBarStyle.padding = new RectOffset(2, 2, 0, 0);

            return horizontalScrollBarStyle;
        }

        public static GUIStyle CreateVerticalScrollBarStyle()
        {
            var verticalScrollBarStyle = new GUIStyle(GUI.skin.verticalScrollbar);
            verticalScrollBarStyle.normal.background = null;
            verticalScrollBarStyle.overflow = new RectOffset(0, 0, 0, 0);
            verticalScrollBarStyle.padding = new RectOffset(0, 0, 2, 2);

            return verticalScrollBarStyle;
        }

        public static GUIStyle CreateHorizontalScrollBarThumbStyle()
        {
            var horizontalScrollBarThumbStyle = new GUIStyle(GUI.skin.horizontalScrollbarThumb);
            horizontalScrollBarThumbStyle.normal.background = ScrollThumbTexture;
            horizontalScrollBarThumbStyle.overflow = new RectOffset(0, 0, 0, 0);
            horizontalScrollBarThumbStyle.margin = new RectOffset(2, 2, 2, 2);
            horizontalScrollBarThumbStyle.border = new RectOffset(6, 6, 8, 8);

            return horizontalScrollBarThumbStyle;
        }
        
        public static GUIStyle CreateVerticalScrollBarThumbStyle()
        {
            var verticalScrollBarThumbStyle = new GUIStyle(GUI.skin.verticalScrollbarThumb);
            verticalScrollBarThumbStyle.normal.background = ScrollThumbTexture;
            verticalScrollBarThumbStyle.overflow = new RectOffset(0, 0, 0, 0);
            verticalScrollBarThumbStyle.margin = new RectOffset(2, 2, 2, 2);
            verticalScrollBarThumbStyle.border = new RectOffset(6, 6, 8, 8);

            return verticalScrollBarThumbStyle;
        }

        public static GUIStyle CreateScrollBarButtonStyle()
        {
            var scrollBarButtonStyle = new GUIStyle(GUIStyle.none);

            return scrollBarButtonStyle;
        }
    }
}