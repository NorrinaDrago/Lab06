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
    public float SGDUSD = 0.74f;
    public float SGDJPY = 82.78f;
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
        }
        catch
        {
            DebuggingText.text = "Please enter a valid amount";
        }
        
        if(ToggleUSdollars.isOn)
        {
            InputConvertAmt.text = "$" + (amount * SGDUSD);
        }
        else if(ToggleJapaneseYen.isOn)
        {
            InputConvertAmt.text = "$" + (amount * SGDJPY);
        }

    }

    public void ClearBtn()
    {
        ToggleUSdollars.isOn = false;
        ToggleJapaneseYen.isOn = false;
        InputAmount.text = "";
        InputConvertAmt.text = "";
    }
}
