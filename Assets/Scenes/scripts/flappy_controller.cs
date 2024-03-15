using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flappy_controller : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Reset_player()
    {
        print("has been reset");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().enabled = true;
            print("presssed");
        }
    }
}
