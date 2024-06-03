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
        resultText.text = "Last Enemy : 2";
    }
        
  
    public void Result(string text)
    {
        if (text == "Victory" || text == "Defeat")
        {
            resultText.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
            resultText.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
            resultText.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
            resultText.fontSize = 80;
            resultText.text = text;
        }
        else
        {
            string str = "Last Enemy : " + text;
            resultText.text = str;
        }
    }
}
