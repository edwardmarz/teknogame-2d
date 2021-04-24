using System.Collections;
using UnityEngine;

public class timeDestroyer : MonoBehaviour
{
    public float aliveTimer;

    //the function will be executed once at beginn
    void Start()
    {
        //Destroy funktion will delete gameObject (current GameObject) from the scene after aliveTimer seconds
        Destroy(gameObject, aliveTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
