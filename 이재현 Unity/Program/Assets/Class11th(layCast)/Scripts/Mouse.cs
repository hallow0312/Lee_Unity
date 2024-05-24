using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    // Start is called before the first frame update
    private Ray ray;
    public LayerMask layermask;
    private RaycastHit rayCastHit;

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);   

        if(Input.GetButtonDown("Fire1"))
        {
            //Physics. Raycast
            // ray: ������ ���� ���� 
            // rayCastHit : �浹�� ������Ʈ�� ���� ���� 
            // Mathf. Infinity :������ ���� 
            // layermask  : �浹 ������ layer
            if(Physics.Raycast(ray, out rayCastHit, Mathf.Infinity,layermask))
            {
                rayCastHit.collider.GetComponent<Health>().HP -= 10;
                Debug.Log(rayCastHit.collider.GetComponent<Health>().HP);
            }
        }
    }
}
