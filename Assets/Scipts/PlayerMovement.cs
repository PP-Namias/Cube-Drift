using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float fowardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()    
    {
        // Debug.Log("Hello World");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
