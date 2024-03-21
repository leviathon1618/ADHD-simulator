using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class teacher : MonoBehaviour
{
    public int path_option;
    public List<List<GameObject>> option = new List<List<GameObject>>();
    public List<GameObject> path1 = new List<GameObject>();
    public List<GameObject> path2 = new List<GameObject>();
    public List<GameObject> path3 = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        option.Add(path1);
        option.Add(path2);
        option.Add(path3);
        List<Vector3> path1_list = new List<Vector3>();
        foreach (var item in option[path_option -1 ])
        {
            path1_list.Add(item.transform.position);
        }
        var path1_array = path1_list.ToArray();
        transform.DOPath(path1_array, 15,PathType.Linear);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
