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
            // ray: 광선에 대한 정보 
            // rayCastHit : 충돌한 오브젝트에 대한 정보 
            // Mathf. Infinity :광선의 길이 
            // layermask  : 충돌 가능한 layer
            if(Physics.Raycast(ray, out rayCastHit, Mathf.Infinity,layermask))
            {
                rayCastHit.collider.GetComponent<Health>().HP -= 10;
                Debug.Log(rayCastHit.collider.GetComponent<Health>().HP);
            }
        }
    }
}
