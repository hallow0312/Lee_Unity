using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyManager : MonoBehaviour
{
   public GameObject data = null;

    private void Start()
    {
        InvokeRepeating(nameof(Search), 0, 10);
    }

    public void Search()
    {
        data = GameObject.Find("CreateManager");
        data = GameObject.Find("Wraith(Clone)");
        if (data != null)
        {
            Destroy(data);
        }
    }
}
