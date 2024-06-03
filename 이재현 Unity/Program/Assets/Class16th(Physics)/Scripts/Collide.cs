using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Collide : MonoBehaviour
{
    public GameObject PlayerObject1;
    
    private int count = 0;
    public UIManager manager;
    public GameManager gameManager;
    private int LastEnem =2;
    private int endCount = 2;
    private void OnTriggerEnter(Collider other)
    {   
        //Ball ball = other.GetComponent<Ball>();
        if (other.gameObject == PlayerObject1)
        {
            manager.Result("Defeat");
            gameManager.State = false;
        }
        else 
        {
            count++;
            LastEnem--;
           
            if(count>=endCount)
            {
                manager.Result("Victory");
                gameManager.State = false;
            }
            else
            {
                string enem = LastEnem.ToString(); 
                manager.Result(enem);
            }
        }
    }
}
   
