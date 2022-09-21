using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{


    public GameManager gameManager;

    void OnTriggerEnter ()
    {
        Debug.Log("End Trigger");

        gameManager.Completelevel();
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
