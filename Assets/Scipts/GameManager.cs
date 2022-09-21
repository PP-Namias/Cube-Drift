using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject CompleteLevelUI;


    public void Completelevel()
    {
        Debug.Log("Level Won");
        CompleteLevelUI.SetActive(true);

    }



    public void EndGame()
    {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game over");
            Invoke("Restart", restartDelay);
            // Restart();
        }
       
    } 


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
