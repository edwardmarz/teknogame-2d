using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemChecker : MonoBehaviour
{
    public int score;
    public GameObject ScoreObject;
    //variable for reference to Text componente on Score GameObject
    Text scoreText;

    //will be executed once
    void Start()
    {
        //reference scoreText to Text component
        scoreText = ScoreObject.GetComponent<Text>();
    }

    //will be started, if one GameObject with Collider2D has touched the Trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        //check if GameObjects Tag is Good
        if (other.gameObject.tag == "Good")
        {
            //if Tag is Good increase score
            score = score + 10;
            scoreText.text = score.ToString();
            //delete GameObject, which went into Trigger, from the Scene
            Destroy(other.gameObject);
        }
        //check if GameObjects Tag is Bad
        if (other.gameObject.tag == "Bad")
        {
            //if Tag is Bad decrease score
            score = score - 10;
            scoreText.text = score.ToString();
            //delete GameObject, which went into Trigger, from the Scene
            Destroy(other.gameObject);
        }
    }
}
