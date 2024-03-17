using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pinata_manager : MonoBehaviour
{
    public GameObject pinata_button;


    public int click_score;
    public float time_left = 3.0f;
    public float despawn_time_baseline = 5.0f;
    public float time_to_despawn = 0.0f;

    private string last_clicked = "";
    public List<List<string>> key_lists = new List<List<string>>();
    private int button_set = 0;
    
    public TMP_Text left_key;
    public TMP_Text right_key;
    

    // Start is called before the first frame update
    void Start()
    {
        click_score = 0;
        pinata_button.SetActive(false);

        key_lists.Add(new List<string> { "q", "w" });
        key_lists.Add(new List<string> { "w", "e" });
        key_lists.Add(new List<string> { "a", "s" });
        key_lists.Add(new List<string> { "s", "d" });
        int rand = Random.Range(0, 5);
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
            spam_buttons(key_lists[button_set][0], key_lists[button_set][1]);
        }
        else
        {
            pinata_button.SetActive(false);
            button_set = 0;
        }
    }

    private void SpawnPinata()
    {
        time_to_despawn = despawn_time_baseline;
        pinata_button.SetActive(true);
        click_score = 0;
        button_set = Random.Range(1,5);
        last_clicked = "";
        left_key.SetText(key_lists[button_set][0].ToUpper());
        right_key.SetText(key_lists[button_set][1].ToUpper());
    }


    private void spam_buttons(string left_button, string right_button)
    {
        if (Input.GetKeyDown(left_button) && last_clicked != left_button)
        {
            last_clicked = left_button;
            click_score++;
        }
        else if (Input.GetKeyDown(right_button) && last_clicked != right_button)
        {
            last_clicked = right_button;
            click_score++;
        }
    }
}
