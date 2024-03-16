using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinata_manager : MonoBehaviour
{
    public GameObject pinata_button;


    public int click_score;
    public float time_left = 3.0f;
    public float despawn_time_baseline = 5.0f;
    public float time_to_despawn = 0.0f;
    private enum Clickability
    {
        Left,
        Right,
        Both
    }

    public List<List<string>> test2 = new List<List<string>>();

    private Clickability click_direction = Clickability.Both;
    public int button_set = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        click_score = 0;
        pinata_button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time_left -= Time.deltaTime;
        
        if (time_left <= 0.0f)
        {
            SpawnPinata();
            time_left = 10.0f;
        }

        if (time_to_despawn > 0)
        {
            time_to_despawn -= Time.deltaTime;
            pinata_button.SetActive(true);
            Debug.Log(click_score.ToString());
        }
        else
        {
            pinata_button.SetActive(false);
            button_set = 0;
        }

        switch (button_set)
        {
            case 1:
                if (click_direction == Clickability.Both && Input.GetKeyDown("Q"))
                {
                    click_direction = Clickability.Right;
                    click_score++;
                }
                else if (click_direction == Clickability.Both && Input.GetKeyDown(KeyCode.W))
                {
                    click_direction = Clickability.Left;
                    click_score++;
                }
                else if (click_direction == Clickability.Left && Input.GetKeyDown(KeyCode.Q))
                {
                    click_direction = Clickability.Right;
                    click_score++;
                }
                else if (click_direction == Clickability.Right && Input.GetKeyDown(KeyCode.W))
                {
                    click_direction = Clickability.Left;
                    click_score++;
                } 
                break;
            case 2:
                if (click_direction == Clickability.Both && Input.GetKeyDown(KeyCode.W))
                {
                    click_direction = Clickability.Right;
                    click_score++;
                }
                else if (click_direction == Clickability.Both && Input.GetKeyDown(KeyCode.E))
                {
                    click_direction = Clickability.Left;
                    click_score++;
                }
                else if (click_direction == Clickability.Left && Input.GetKeyDown(KeyCode.W))
                {
                    click_direction = Clickability.Right;
                    click_score++;
                }
                else if (click_direction == Clickability.Right && Input.GetKeyDown(KeyCode.E))
                {
                    click_direction = Clickability.Left;
                    click_score++;
                }
                break;
            case 3:
                if (click_direction == Clickability.Both && Input.GetKeyDown(KeyCode.A))
                {
                    click_direction = Clickability.Right;
                    click_score++;
                }
                else if (click_direction == Clickability.Both && Input.GetKeyDown(KeyCode.S))
                {
                    click_direction = Clickability.Left;
                    click_score++;
                }
                else if (click_direction == Clickability.Left && Input.GetKeyDown(KeyCode.A))
                {
                    click_direction = Clickability.Right;
                    click_score++;
                }
                else if (click_direction == Clickability.Right && Input.GetKeyDown(KeyCode.S))
                {
                    click_direction = Clickability.Left;
                    click_score++;
                }
                break;
            case 4:
                if (click_direction == Clickability.Both && Input.GetKeyDown(KeyCode.S))
                {
                    click_direction = Clickability.Right;
                    click_score++;
                }
                else if (click_direction == Clickability.Both && Input.GetKeyDown(KeyCode.D))
                {
                    click_direction = Clickability.Left;
                    click_score++;
                }
                else if (click_direction == Clickability.Left && Input.GetKeyDown(KeyCode.S))
                {
                    click_direction = Clickability.Right;
                    click_score++;
                }
                else if (click_direction == Clickability.Right && Input.GetKeyDown(KeyCode.D))
                {
                    click_direction = Clickability.Left;
                    click_score++;
                }
                break;
            default:
                break;
        }



    }

    void SpawnPinata()
    {
        time_to_despawn = despawn_time_baseline;
        pinata_button.SetActive(true);
        click_score = 0;
        button_set = Random.Range(1,5);
        click_direction = Clickability.Both;
    }
}
