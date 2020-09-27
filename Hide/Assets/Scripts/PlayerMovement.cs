using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    Vector3 targetPosition;
    Vector3 lookAtTarget;
    Quaternion playerRot;
    float rotSpeed = 5;
    public float MoveSpeed = 1000;
    public float RotSpeed = 1000;
   public int points = 0;
    public float PlayerLife = 3f;
    public bool PlayerIsAlive = true;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
       
        /*
        if(Input.GetKey("w")){
            rb.AddForce(-Speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s")){
            rb.AddForce(Speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")){
            rb.AddForce(0, 0, -Speed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d")){
            rb.AddForce(0, 0, Speed * Time.deltaTime, ForceMode.VelocityChange);
        }
        transform.Rotate(0,Input.GetAxis("Horizontal"),0);
	*/
        if (Input.GetKey(KeyCode.W))
        {
            rb.position += transform.forward * (float)Time.deltaTime * MoveSpeed;
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(Vector3.left * (float)Time.deltaTime * MoveSpeed);
            //transform.rotation += transform.rotation.SetLookRotation(transform.rotation.x, transform.rotation.y * MoveSpeed * (float)Time.deltaTime,transform.rotation.z,);
            transform.Rotate(0, (float)RotSpeed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.position -= transform.forward * (float)Time.deltaTime * MoveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //  transform.Translate(Vector3.right * (float)Time.deltaTime * MoveSpeed);
            // rb.rotation += transform.right * (float)Time.deltaTime * MoveSpeed;
            transform.Rotate(0, (float)RotSpeed * -1, 0);
        }
    }


   
   
}
