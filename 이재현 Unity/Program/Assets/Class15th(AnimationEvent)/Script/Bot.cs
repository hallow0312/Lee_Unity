using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class Bot : MonoBehaviour  
{
   public Capsule capsule;
      public void Attack(float attack)
    {
        if (capsule != null)
        {
            capsule.Damage(attack);
        }
    }


  
}

