using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Button : MonoBehaviour
{
    
    public DataManager dataManager;
    
    private void OnButtonClick()
    {
        dataManager.SetData();
        
    }
    
}
