using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class flappy_bird : MonoBehaviour
{
    public int score;


    public float speed;

    public List<GameObject> numbers;
    public List<GameObject> backgrounds;
    public GameObject moving_object;
    public GameObject background_obj;
    public GameObject base_obj;
    public GameObject pipe_obj;

    public float distance;

    public GameObject number1;
    public GameObject number2;
    // Start is called before the first frame update
    void Start()
    {
        initiate_flappy();
        set_score();
    }

    public void set_score()
    {
        string score_string = score.ToString();
        var num1 = Convert.ToInt32(score_string[0].ToString());
        number1.GetComponent<SpriteRenderer>().sprite = numbers[num1].GetComponent<SpriteRenderer>().sprite;

        if (score > 9)
        {
            var num2 = Convert.ToInt32(score_string[1].ToString());
            number2.SetActive(true);
            number2.GetComponent<SpriteRenderer>().sprite = numbers[num2].GetComponent<SpriteRenderer>().sprite;
        }
        else
        {
            number2.SetActive(false);
        }
    }


    public void initiate_flappy()
    {
        if (backgrounds != null)
        {
            if (backgrounds.Count > 0)
            {
                for (int i = 0; i < backgrounds.Count; i++)
                {
                    Destroy(backgrounds[i].gameObject);
                }
                backgrounds.Clear();
            }
        }
        
        for (int i = 0; i < 5; i++)
        {
            GameObject bg = Instantiate(background_obj, new Vector2(i * 2.88f * 2 - 10f, -1), quaternion.identity, moving_object.transform);
            GameObject floor = Instantiate(base_obj, new Vector2(i * 3.36f * 2 - 10f, -5f), quaternion.identity, moving_object.transform);
            float y_pos = UnityEngine.Random.Range(3f, -2.7f);
            GameObject pipe = Instantiate(pipe_obj, new Vector2(i * 3.36f * 2, y_pos + 5), quaternion.identity, moving_object.transform);
            backgrounds.Add(bg);//,floor,pipe
            backgrounds.Add(floor);
            backgrounds.Add(pipe);
        }
    }

    // Update is called once per frame
    void Update()
    {
        moving_object.transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}
