using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerationScript : MonoBehaviour
{
    public GameObject triangle;
    
    void Start()
    {
        InvokeRepeating("AddGameObject", 1f, 2f);
    }

    void AddGameObject()
    {
        Quaternion rotation_b = Quaternion.AngleAxis(0, new Vector3(0, 0, 0));
        transform.rotation *= rotation_b;

        Vector3 tr = new Vector3(11, -2.88f, 0);
        if (Random.Range(0, 3) != 0) {
            Instantiate(triangle, tr, rotation_b);
        }
    }

    void Update()
    {

    }

}
