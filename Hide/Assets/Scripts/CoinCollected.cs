using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollected : MonoBehaviour {

    public Text Score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, 50 * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            other.GetComponent<PlayerMovement>().points++;
            Score.text = other.GetComponent<PlayerMovement>().points.ToString();
             transform.position = new Vector3(Random.Range(-20, 25), 2, Random.Range(-28, 23));
            Debug.Log(transform.position);
           // Destroy(gameObject);
        }
    }
}
