using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IDamageable
{
    private int health = 100;
    // OnCollisionEnter
    //�������� �浹�� ���� ��
  void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }
    // OnCollisionExit
    // �������� �浹�� �ϰ� �ִ� �� 
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");

    }
    // OnCollisionExit
    // �������� �浹�� ������ ��
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");

    }

    public void Active()
    {
        health -= 50;
        Debug.Log("Damage �޾ҽ��ϴ�");
    }
}
