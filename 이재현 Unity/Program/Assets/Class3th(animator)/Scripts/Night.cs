using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Night : MonoBehaviour
{
    // �� Ÿ�� // ���� Ÿ��  
    //�� Ÿ�� : char , byte ,bool ,short ,int ,long , double ,decimal, struct
    // ���� Ÿ�� : class , array , collection , delegate, interface, abstractclass ,event;
    // int [] array = new int [5];
    // class Doozy = new Doozy();

    // �ֻ��� Ÿ�� : object : �� Ÿ�� ���� Ÿ�� �ٴ��� �� �ִ� Ÿ��  - ����Ÿ������ �Ǿ��ִ� .
    public int [] data;
    private void Start()
    {
        foreach(int element in data)  
        {
            Debug.Log(element);
        }
       
    }

}
