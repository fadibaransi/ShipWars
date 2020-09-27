using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

    private Transform bar;
    public float fullHealth = 1f;
	// Use this for initialization
	private void Start () {

        bar = transform.Find("Bar");
        SetSize(fullHealth);
	}
	
	

    public void SetSize(float sizeNormalized)
    {
        bar.localScale = new Vector3(sizeNormalized,1f);
    }

    public void setColor(Color color)
    {
        bar.Find("BarSprite").GetComponent<SpriteRenderer>().color = color;
    }
}
