using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class teacher : MonoBehaviour
{
    public List<GameObject> points = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        List<Vector3> path1_list = new List<Vector3>();
        foreach (var item in points)
        {
            path1_list.Add(item.transform.position);
        }
        var path1_array = path1_list.ToArray();
        transform.DOPath(path1_array, 15);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
