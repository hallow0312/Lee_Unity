using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Collide : MonoBehaviour
{
    public GameObject PlayerObject1;
    public GameObject EnemyObject1;
    public GameObject EnemyObject2;
    private int count = 0;
    public UIManager manager;
    private int LastEnem =2;
       
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == PlayerObject1)
        {
            manager.Result("Defeat");
        }
        else 
        {
            count++;
            LastEnem--;
           
            if(count>=2)
            {
                manager.Result("You Win");
            }
            else
            {
                string enem = LastEnem.ToString();
                manager.Result(enem);
            }
        }
    }
}
   
