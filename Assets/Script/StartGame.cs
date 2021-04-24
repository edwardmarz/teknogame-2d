using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public float timeLeft = 3.0f;
    public Text startText; //used for showing countdown from 3,2,1 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            GameOver();
            timeLeft = 0;
            //Do something useful or Load a new game scene
        }
    }

    public void GameOver()
    {
        Application.Quit();
    }
}
