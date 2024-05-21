using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 1.0f;
    
    void Start()
    {
        /* transform.position = new Vector3(-2, 0, 2);*/ //�������� �̵�

        // Boxing 
        // �� ������ �����͸� ������������ ��ȯ�ϴ� ���� .
        object data = speed;
        Debug.Log("data�� �� : " + data);

        //UnBoxing 
        // ���������� �����͸� �� �������� ��ȯ�ϴ� ���� .
        float result =(float)data;
        Debug.Log("result ������ �� : " + result);
    }

  
    private void Update()
    {
        #region InputŬ����
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
        #region GetAxis�Լ�

        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
        //������ ����ȭ : ������ ũ�⸦ 1�� �����Ͽ� �밢�� �̵��� �յ��ϰ� ó���ϵ��� ������.
        direction.Normalize();

        // Time.deltaTime : �� ������ ��  �����ϴ� �ð� ;

        transform.position += direction * speed * Time.deltaTime;
        #endregion

    }


}
