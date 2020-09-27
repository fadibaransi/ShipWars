using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class GameHandler : MonoBehaviour {
    [SerializeField] private HealthBar healthBar;
	// Use this for initialization
	void Start () {
        
        float health = 1f;
        FunctionPeriodic.Create(() =>
        {
            if (health > .01f)
            {
                health -= .01f;
                healthBar.SetSize(health);

                if(health < .3f){
                    if ((health * 100f) % 3 == 0)
                    {
                        healthBar.setColor(Color.white);
                    }
                    else
                    {
                        healthBar.setColor(Color.red);
                    }
              
            }
            }
        }, .03f);

        
	}
	
	
}
