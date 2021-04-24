using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int kecepatan;
    public int pindah;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {

            transform.Translate(Vector2.right * kecepatan * Time.deltaTime); // untuk memberikan gerak ke kanan dan ke kiri pada player
            pindah = 1;

        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right * -kecepatan * Time.deltaTime);
            pindah = -1;
        }
    }
}
