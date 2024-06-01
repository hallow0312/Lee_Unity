using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text resultText;
    
  
    private void Start()
    {
        resultText.GetComponent<RectTransform>().anchorMin = new Vector2(1, 1);
        resultText.GetComponent<RectTransform>().anchorMax = new Vector2(1, 1);
        resultText.text = "2";
    }
        
  
    public void Result(string text)
    {
        if (text == "You Win" || text == "Defeat")
        {
            resultText.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
            resultText.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
            resultText.text = text;
        }
        else
        {
            resultText.text = text;
        }
    }
}
