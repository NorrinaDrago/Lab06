using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    public InputField InputAmount;
    public InputField InputConvertAmt;
    public Toggle ToggleUSdollars;
    public Toggle ToggleJapaneseYen;
    public Toggle ToggleRMdollars;
    public Toggle ToggleEURdollars;
    public Toggle ToggleKRWdollars;
    public Toggle ToggleTWDdollars;
    public float SGDUSD = 0.74f;
    public float SGDJPY = 97.25f;
    public float SGDRM = 3.27f;
    public float SGEUR = 0.70f;
    public float SGKRW = 936.37f;
    public float SGTWD = 22.93f;
    private float amount;
    public Text DebuggingText;
    // Start is called before the first frame update
    void Start()
    {
        ClearBtn();
    }

    public void ConvertBtn()
    {
        try
        {
             amount = float.Parse(InputAmount.text);

            if (ToggleUSdollars.isOn)
            {
                InputConvertAmt.text = "$" + (amount * SGDUSD);
                DebuggingText.text = "";
            }
            else if (ToggleJapaneseYen.isOn)
            {
                InputConvertAmt.text = "$" + (amount * SGDJPY);
                DebuggingText.text = "";
            }
            else if (ToggleRMdollars.isOn)
            {
                InputConvertAmt.text = "$" + (amount * SGDRM);
                DebuggingText.text = "";
            }
            else if (ToggleEURdollars.isOn)
            {
                InputConvertAmt.text = "$" + (amount * SGEUR);
                DebuggingText.text = "";
            }
            else if (ToggleKRWdollars.isOn)
            {
                InputConvertAmt.text = "$" + (amount * SGKRW);
                DebuggingText.text = "";
            }
            else if (ToggleTWDdollars.isOn)
            {
                InputConvertAmt.text = "$" + (amount * SGTWD);
                DebuggingText.text = "";
            }
        }
        catch
        {
            DebuggingText.text = "Please enter a valid amount";
        }

    }

    public void ClearBtn()
    {
        ToggleUSdollars.isOn = false;
        ToggleJapaneseYen.isOn = false;
        ToggleRMdollars.isOn = false;
        ToggleEURdollars.isOn = false;
        ToggleKRWdollars.isOn = false;
        ToggleTWDdollars.isOn = false;
        InputAmount.text = "";
        InputConvertAmt.text = "";
        DebuggingText.text = "";
    }
}
