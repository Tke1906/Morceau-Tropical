using UnityEngine;using UnityEngine.UI;using TMPro;

public class MenuConfiguration : MonoBehaviour
{
    public TMP_Text PortugueseText;
    public TMP_Text JapaneseText;
    public TMP_Text EnglishText;

    public TMP_FontAsset FontDefault;
    public TMP_FontAsset JapaneseFontDefault;
    public TMP_FontAsset FontBold;
    public TMP_FontAsset JapaneseFontBold;
    

    public int Size = 48;
    public int BigSize = 64;

    private string Language;
    void Start()
    {

    }
    public void openPopUp(GameObject canvas)
    {
        canvas.SetActive(true);
    }

    public void closePopUp(GameObject canvas)
    {
        canvas.SetActive(false);
    }

    public void SelectedPortuguese()
    {
        resetText();
        Language = "Portuguese";
        Debug.Log(Language);
        PortugueseText.fontSize = BigSize;
        PortugueseText.fontStyle = FontStyles.Underline;
        PortugueseText.font = FontBold;
    }
    public void SelectedJapanese()
    {
        resetText();
        Language = "Japanese";
        Debug.Log(Language);
        JapaneseText.fontSize = BigSize;
        JapaneseText.fontStyle = FontStyles.Underline;
        JapaneseText.font = JapaneseFontBold;
    }
    public void SelectedEnglish()
    {
        resetText();
        Language = "English";
        Debug.Log(Language);
        EnglishText.fontSize = BigSize;
        EnglishText.fontStyle = FontStyles.Underline;
        EnglishText.font = FontBold;
    }

    void resetText()
    {
        EnglishText.fontSize = Size;
        EnglishText.fontStyle = FontStyles.Normal;
        EnglishText.font = FontDefault;

        JapaneseText.fontSize = Size;
        JapaneseText.fontStyle = FontStyles.Normal;
        JapaneseText.font = JapaneseFontDefault;


        PortugueseText.fontSize = Size;
        PortugueseText.fontStyle = FontStyles.Normal;
        PortugueseText.font = FontDefault;
    }
}
