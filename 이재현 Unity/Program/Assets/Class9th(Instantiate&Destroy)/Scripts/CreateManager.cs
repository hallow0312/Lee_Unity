using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    //public GameObject unit1;
    //public GameObject unit2;
    ////public GameObject unit3;
    //public GameObject unit;
    //public float x = -2.5f;
    //void Start()
    //{
    //    // Instantiate() : ���� ������Ʈ ���� �Լ� 
    //    //unit1 = Instantiate(unit1); 
    //    //unit2= Instantiate(unit2); 
    //    //unit3= Instantiate(unit3); 

    //    //unit1.transform.position = new Vector3(-2.5f, 0, 0);
    //    //unit2.transform.position = new Vector3(0, 0, 0);
    //    //unit3.transform.position = new Vector3(2.5f, 0, 0);

    //    //unit1.transform.Rotate(0, -180, 0);
    //    //unit2.transform.Rotate(0, -180, 0);
    //    //unit3.transform.Rotate(0, -180, 0);
    //    for(int i =0; i<3; i++)
    //    {
    //        unit = Instantiate(unit);
    //        unit.transform.position = new Vector3(x, 0, 0);
    //        unit.transform.Rotate(0, -180, 0);
    //        x += 2.5f;
    //    }

    //}

    public Factory factory;

    private void Awake()
    {
        factory = GetComponent<Factory>();  
    }
    
}
