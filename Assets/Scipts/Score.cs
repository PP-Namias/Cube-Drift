using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(player.position.z); 
       scoreText.text = player.position.z.ToString("0");

    }
}
