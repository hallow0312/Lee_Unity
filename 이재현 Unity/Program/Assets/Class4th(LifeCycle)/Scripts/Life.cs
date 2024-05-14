using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{   
    
  // Awake 함수
   // 게임 오브젝트가 인스턴스 된 후 에 단 한 번만 호출되는 
   // 이벤트 함수이며 , 스크립트가 비활성화 되었을 때도 호출되는 이벤트함수 .
  /*
   private void Awake()
   {
       Debug.Log("Awake");
   }
   // OnEnable
   // 게임 오브젝트가 활성화 되었을 때 호출되는 이벤트 함수.
   private void OnEnable()
   {
       Debug.Log("OnEnable");
   }
   // Start
   // 게임 오브젝트가 인스턴스 된 후에 단 한번만 호출되며 ,
   // 스크립트가 활성화 되었을때만 , 호출되는 이벤트 함수 .
   private void Start()
   {
       Debug.Log("Start");

   }
  */
     //FixedUpdate
     // TimeStep 에 설정된 값에 따라 일정한 간격으로 호출되는 
     // 이벤트함수 .
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    // Updata
    // 매 프레임마다 호출되는 이벤트함수.
    private void Update()
    {
        Debug.Log("Update");

    }
    //Late Update
    // Update 함수가 끝난 후에 호출되는 이벤트함수.

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");

    }
    //OnDisable 
    //  게임 오브젝트가 비활성화 되었을 때 호출되는 이벤트 함수.
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    //OnDestroy
    // 게임 오브젝트가 파괴되었을 때 호출되는 이벤트 함수.
    private void OnDestroy() 
    {
        Debug.Log("OnDestroy"); 
    }
}
