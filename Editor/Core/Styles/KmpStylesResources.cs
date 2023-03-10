using UnityEngine;
using UnityEngine.Serialization;

namespace KMP.Editor.Core.Styles
{
    #if KMP_INTERNAL
    [CreateAssetMenu(menuName = "KMP Internal/Kmp Styles Resources Asset")]
    #endif
    public class KmpStylesResources : ScriptableObject
    {
        public Texture2D logo => m_Logo;

        public Font headerFont => m_HeaderFont;

        public Font contentFont => m_ContentFont;

        public Font noteFont => m_NoteFont;

        public Font buttonFont => m_ButtonFont;

        public Texture2D checkIcon => m_CheckIcon;

        public Texture2D xIcon => m_XIcon;

        public Texture2D plusIcon => m_PlusIcon;

        public Texture2D minusIcon => m_MinusIcon;

        public Texture2D editIcon => m_EditIcon;

        public Texture2D infoIcon => m_InfoIcon;

        public Texture2D leftIcon => m_LeftIcon;

        public Texture2D rightIcon => m_RightIcon;

        public Texture2D upIcon => m_UpIcon;

        public Texture2D downIcon => m_DownIcon;

        public Texture2D headerTexture => m_HeaderTexture;

        public Texture2D bodyTexture => m_BodyTexture;

        public Texture2D footerTexture => m_FooterTexture;

        public Texture2D tabHeaderTexture => m_TabHeaderTexture;

        public Texture2D tabBodyTexture => m_TabBodyTexture;

        public Texture2D tabFooterTexture => m_TabFooterTexture;

        public Texture2D tabButtonNormalTexture => m_TabButtonNormalTexture;

        public Texture2D tabButtonActiveTexture => m_TabButtonActiveTexture;

        public Texture2D tabButtonClickTexture => m_TabButtonClickTexture;

        public Texture2D frameTexture => m_FrameTexture;

        public Texture2D boxTexture => m_BoxTexture;

        public Texture2D helpBoxTexture => m_HelpBoxTexture;

        public Texture2D scrollViewTexture => m_ScrollViewTexture;

        public Texture2D scrollThumbTexture => m_ScrollThumbTexture;

        public Texture2D fieldTexture => m_FieldTexture;

        public Texture2D buttonTexture => m_ButtonTexture;

        public Texture2D buttonDarkTexture => m_ButtonDarkTexture;

        public Texture2D buttonRoundTexture => m_ButtonRoundTexture;

        public Texture2D buttonRoundDarkTexture => m_ButtonRoundDarkTexture;

        public Texture2D signOctagonal => m_SignOctagonal;

        public Texture2D signTriangle => m_SignTriangle;

        public Color headerFontColor => m_HeaderFontColor;

        public Color contentFontColor => m_ContentFontColor;

        public Color noteFontColor => m_NoteFontColor;

        public Color buttonFontColor => m_ButtonFontColor;

        public Color alwaysBlackFontColor => m_AlwaysBlackFontColor;

        public Color separatorColor => m_SeparatorColor;

        public Color toggleOnActiveColor => m_ToggleOnActiveColor;

        public Color toggleOffActiveColor => m_ToggleOffActiveColor;

        public Color toggleInactiveColor => m_ToggleInactiveColor;

        public Color helpBoxColor => m_HelpBoxColor;

        public Color warningColor => m_WarningColor;

        public Color warningButtonColor => m_WarningButtonColor;

        [Header("Logo")]
        [SerializeField]
        Texture2D m_Logo;
        
        [Header("Fonts")]
        [SerializeField]
        Font m_HeaderFont;

        [SerializeField]
        Font m_ContentFont;

        [SerializeField]
        Font m_NoteFont;

        [SerializeField]
        Font m_ButtonFont;

        [Header("Icons")]
        [SerializeField]
        Texture2D m_CheckIcon;

        [SerializeField]
        Texture2D m_XIcon;

        [SerializeField]
        Texture2D m_PlusIcon;

        [SerializeField]
        Texture2D m_MinusIcon;

        [SerializeField]
        Texture2D m_EditIcon;

        [SerializeField]
        Texture2D m_InfoIcon;

        [SerializeField]
        Texture2D m_LeftIcon;

        [SerializeField]
        Texture2D m_RightIcon;

        [SerializeField]
        Texture2D m_UpIcon;

        [SerializeField]
        Texture2D m_DownIcon;
        
        [Header("Textures")]
        [SerializeField]
        Texture2D m_HeaderTexture;
        
        [SerializeField]
        Texture2D m_BodyTexture;
        
        [SerializeField]
        Texture2D m_FooterTexture;

        [SerializeField]
        Texture2D m_TabHeaderTexture;
        
        [SerializeField]
        Texture2D m_TabBodyTexture;
        
        [SerializeField]
        Texture2D m_TabFooterTexture;

        [SerializeField]
        Texture2D m_TabButtonNormalTexture;
        
        [SerializeField]
        Texture2D m_TabButtonActiveTexture;
        
        [SerializeField]
        Texture2D m_TabButtonClickTexture;

        [SerializeField]
        Texture2D m_FrameTexture;
        
        [SerializeField]
        Texture2D m_BoxTexture;
        
        [SerializeField]
        Texture2D m_HelpBoxTexture;
        
        [SerializeField]
        Texture2D m_ScrollViewTexture;
        
        [SerializeField]
        Texture2D m_ScrollThumbTexture;
        
        [SerializeField]
        Texture2D m_FieldTexture;

        [SerializeField]
        Texture2D m_ButtonTexture;
        
        [SerializeField]
        Texture2D m_ButtonDarkTexture;
        
        [SerializeField]
        Texture2D m_ButtonRoundTexture;
        
        [SerializeField]
        Texture2D m_ButtonRoundDarkTexture;

        [SerializeField]
        Texture2D m_SignOctagonal;
        
        [SerializeField]
        Texture2D m_SignTriangle;

        [Header("Colors Palette")]
        [SerializeField]
        Color m_HeaderFontColor;

        [SerializeField]
        Color m_ContentFontColor;

        [SerializeField]
        Color m_NoteFontColor;

        [SerializeField]
        Color m_ButtonFontColor;

        [SerializeField]
        Color m_AlwaysBlackFontColor;

        [SerializeField]
        Color m_SeparatorColor;

        [SerializeField]
        Color m_ToggleOnActiveColor;

        [SerializeField]
        Color m_ToggleOffActiveColor;

        [SerializeField]
        Color m_ToggleInactiveColor;

        [SerializeField]
        Color m_HelpBoxColor;

        [SerializeField]
        Color m_WarningColor;

        [SerializeField]
        Color m_WarningButtonColor;
    }
}