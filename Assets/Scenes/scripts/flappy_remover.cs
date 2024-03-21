using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flappy_remover : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "flappy background")
        {
            collision.transform.Translate(5 * 2.88f * 2, 0, 0);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "flappy pipe")
        {
            
            collision.transform.Translate(4 * 3.36f * 2 - 10f, 0, 0);
        }
        if (collision.transform.tag == "flappy base")
        {
            collision.transform.Translate(5 * 3.36f * 2, 0, 0);
        }
    }

}
