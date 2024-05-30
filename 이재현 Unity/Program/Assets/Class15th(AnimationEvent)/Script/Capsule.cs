using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Capsule : MonoBehaviour
{
    private float health;
    private float Maxhealth;
    public Slider slider;
   

    private void Start()
    {
        health = 100;
        Maxhealth = health;
    }

    public void Damage(float damage)
    {
        if (health > 0)
        {
            health -= damage;
            slider.value = health / Maxhealth;
        }
        else
        {
            
            Destroy(gameObject);
            
        }
    }

}
