using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class flappy_bird : MonoBehaviour
{
    public float speed;
    public List<GameObject> backgrounds;
    public GameObject moving_object;
    public GameObject background_obj;
    public GameObject base_obj;
    public GameObject pipe_obj;

    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(background_obj, new Vector2(i * 2.88f * 2 - 10f, 0), quaternion.identity, moving_object.transform);
            Instantiate(base_obj, new Vector2(i * 3.36f * 2 - 10f, -5f), quaternion.identity, moving_object.transform);
            float y_pos = UnityEngine.Random.Range(3f, -2.7f);
            Instantiate(pipe_obj, new Vector2(i * 3.36f * 2 - 10f, y_pos + 5), quaternion.identity, moving_object.transform);




            //backgrounds.Add(background_object);
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        //foreach (var item in backgrounds)
        //{
        //    item.transform.Translate(Vector2.left * Time.deltaTime * speed);
        //}
        moving_object.transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}
