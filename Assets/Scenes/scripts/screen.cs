using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screen : MonoBehaviour
{
    public List<GameObject> tabs;
    public flappy_controller flappy_bird;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void switch_tab(string tab_name)
    {
        foreach (var item in tabs)
        {
            if (item.name != tab_name)
            {
                item.transform.GetChild(0).gameObject.SetActive(false);
            }
        }
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.transform.name == "2d_screen")
                {
                    RaycastHit2D hit2 = Physics2D.Raycast(hit.point, Vector2.zero);

                    if (hit2.collider != null)
                    {
                        if (hit2.transform.tag == "tab")
                        {
                            switch_tab(hit2.collider.name);
                            hit2.transform.GetChild(0).gameObject.SetActive(true);
                        }
                    }
                }
            }
        }
    }
}