using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flappy_controller : MonoBehaviour
{
    public flappy_bird flappy_script;

    public List<string> options= new List<string>();

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Reset_player()
    {
        GetComponent<Animator>().SetBool("flap", false);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "flappy pipe")
        {
            flappy_script.initiate_flappy();
            flappy_script.score= 0;
            flappy_script.set_score();
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "score")
        {
            flappy_script.score++;
            flappy_script.set_score();
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GetComponent<Animator>().SetBool("flap",true);
            transform.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 10,ForceMode2D.Impulse);
        }
    }
}
