using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flappy_controller : MonoBehaviour
{
    public flappy_bird flappy_script;

    public List<string> options= new List<string>();
    public List<List<string>> test2 = new List<List<string>>();

    // Start is called before the first frame update
    void Start()
    {
        test2.Add(new List<string> { "w", "q" });
        int rand = Random.Range(0, 5);
        spam_buttons(test2[rand][0], test2[rand][1]);
    }

    public void Reset_player()
    {
        
        GetComponent<Animator>().SetBool("flap", false);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "flappy pipe")
        {
            print("you lose");
            flappy_script.initiate_flappy();
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


    //qw 
    public void spam_buttons(string btn1,string btn2)
    {
        if (Input.GetKeyDown(btn1))
        {
            
        }
    }

}
