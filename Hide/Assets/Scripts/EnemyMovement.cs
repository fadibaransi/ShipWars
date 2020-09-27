using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    Vector3 targetPosition;
    Vector3 lookAtTarget;
    Quaternion playerRot;
    float rotSpeed = 5;
    public float Speed = 1000;
    Vector3 playerPos;
    public Rigidbody rb;
    int gameover = 0;
    public int Lifetime= 1;
    public GameObject EnemyPrefab;
    public Transform enemyRespawn;
    int DeadTimes = 0;

	// Use this for initialization
	void Start () {
        Vector3 startpos = transform.position;
        playerPos = GameObject.Find("Player").transform.position;
        rb.AddForce(playerPos.x * Time.deltaTime, playerPos.y * Time.deltaTime, playerPos.z * Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Player") != null)
        {
        playerPos = GameObject.Find("Player").transform.position;
        lookAtTarget = new Vector3(transform.position.x - targetPosition.x, targetPosition.y, transform.position.z- targetPosition.z );
        playerRot = Quaternion.LookRotation(lookAtTarget);
        transform.rotation = Quaternion.Slerp(transform.rotation, playerRot, rotSpeed * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position,playerPos,Speed * Time.deltaTime);
        transform.LookAt(playerPos);
        }
        
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            other.gameObject.GetComponent<PlayerMovement>().PlayerIsAlive = false;
            //Destroy(other.gameObject);
            Debug.Log("GAME OVER");
            
        }
        if (other.name == "Bullet(Clone)")
        {
            if (Lifetime == 0)
            {
                /*
                Instantiate(EnemyPrefab, enemyRespawn);
                Destroy(gameObject);
                */
                //i tried at first to rebuild a new enemy, but WHY ?  i can just replace its place 
                //and give it a new LifeTime :)

                DeadTimes++;
                Lifetime = DeadTimes + 1;
              
                transform.position = new Vector3(Random.Range(-20, 25), 2, Random.Range(-28, 23));
               
            }
            else
            {
                Lifetime--;
            }         
        }
    }
}
