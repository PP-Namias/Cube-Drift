using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColiision : MonoBehaviour
{

    public PlayerMovement movement;


     void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            


        }

    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
