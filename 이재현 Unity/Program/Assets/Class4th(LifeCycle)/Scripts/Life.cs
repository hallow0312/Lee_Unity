using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{   
    
  // Awake �Լ�
   // ���� ������Ʈ�� �ν��Ͻ� �� �� �� �� �� ���� ȣ��Ǵ� 
   // �̺�Ʈ �Լ��̸� , ��ũ��Ʈ�� ��Ȱ��ȭ �Ǿ��� ���� ȣ��Ǵ� �̺�Ʈ�Լ� .
  /*
   private void Awake()
   {
       Debug.Log("Awake");
   }
   // OnEnable
   // ���� ������Ʈ�� Ȱ��ȭ �Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�.
   private void OnEnable()
   {
       Debug.Log("OnEnable");
   }
   // Start
   // ���� ������Ʈ�� �ν��Ͻ� �� �Ŀ� �� �ѹ��� ȣ��Ǹ� ,
   // ��ũ��Ʈ�� Ȱ��ȭ �Ǿ������� , ȣ��Ǵ� �̺�Ʈ �Լ� .
   private void Start()
   {
       Debug.Log("Start");

   }
  */
     //FixedUpdate
     // TimeStep �� ������ ���� ���� ������ �������� ȣ��Ǵ� 
     // �̺�Ʈ�Լ� .
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    // Updata
    // �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ�Լ�.
    private void Update()
    {
        Debug.Log("Update");

    }
    //Late Update
    // Update �Լ��� ���� �Ŀ� ȣ��Ǵ� �̺�Ʈ�Լ�.

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");

    }
    //OnDisable 
    //  ���� ������Ʈ�� ��Ȱ��ȭ �Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�.
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    //OnDestroy
    // ���� ������Ʈ�� �ı��Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�.
    private void OnDestroy() 
    {
        Debug.Log("OnDestroy"); 
    }
}
