using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 1.0f;
    
    void Start()
    {
        /* transform.position = new Vector3(-2, 0, 2);*/ //순간적인 이동

        // Boxing 
        // 값 형식의 데이터를 참조형식으로 변환하는 과정 .
        object data = speed;
        Debug.Log("data의 값 : " + data);

        //UnBoxing 
        // 참조형식의 데이터를 값 형식으로 변환하는 과정 .
        float result =(float)data;
        Debug.Log("result 변수의 값 : " + result);
    }

  
    private void Update()
    {
        #region Input클래스
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //transform.position += new Vector3(0, 0, 1);
        //}
        //else if (Input.GetKeyDown(KeyCode.A))
        //{
        //transform.position += new Vector3(-1, 0, 0);
        //}
        //else if (Input.GetKeyDown(KeyCode.S))
        //{
        //transform.position += new Vector3(0, 0, -1);
        //}
        //else if(Input.GetKeyDown(KeyCode.D))
        //{
        //transform.position += new Vector3(1, 0, 0);
        //}
        #endregion
        #region GetAxis함수

        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
        //벡터의 정규화 : 벡터의 크기를 1로 설정하여 대각선 이동을 균등하게 처리하도록 설정함.
        direction.Normalize();

        // Time.deltaTime : 한 프레임 당  실행하는 시간 ;

        transform.position += direction * speed * Time.deltaTime;
        #endregion

    }


}
