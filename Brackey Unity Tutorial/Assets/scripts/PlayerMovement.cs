using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float fowardForce = 2000f;

    public float sidewaysForce = 500f;

	// Use this for initialization
	void Start () {

        rb.AddForce(0,200,500);

	}
	
    //F REs H a vOc a dO
	// Update is called once per frame
	void FixedUpdate ()
    {
        //add a foward force
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            //only execute if condition is met
            rb.AddForce(sidewaysForce* Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            //only execute if condition is met
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
