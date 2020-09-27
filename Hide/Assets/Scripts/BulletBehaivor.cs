using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaivor : MonoBehaviour {
    [SerializeField] public GameObject healthBar;
    private GameObject Player;
    float hitDamage = 0.33f;
    float fullHealth = 1f;
    void Start()
    {
        Player = GameObject.Find("Player");
        healthBar = GameObject.Find("HealthBar");
    }
    private void OnTriggerEnter(Collider other)
    {
       Debug.Log("Hit " + other.name + "!");
       if (other.name == "Player")
       {
         /*  healthBar.GetComponent<HealthBar>().fullHealth = gameObject.GetComponent<HealthBar>().fullHealth - hitDamage;
           fullHealth = fullHealth - hitDamage;
           Debug.Log(fullHealth);
           healthBar.GetComponent<HealthBar>().SetSize(fullHealth);*/
       
           if (--Player.GetComponent<PlayerMovement>().PlayerLife == 0)
           {
               
               other.gameObject.GetComponent<PlayerMovement>().PlayerIsAlive = false;
               Debug.Log("Game Over");
           }
       }
    }
}
