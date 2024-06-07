using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Button : MonoBehaviour
{
    
    public DataManager dataManager;
       
    
   public void OnClick()
    {
        dataManager.SetData();
    }
    
}
