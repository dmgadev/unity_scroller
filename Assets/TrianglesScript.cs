using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrianglesScript : MonoBehaviour
{
    Vector2 triangles_speed = new Vector2(-10f, 0);

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = triangles_speed;
    }

    void Update()
    {
        if (GetComponent<Rigidbody2D>().position.x < -20)
        {
            Destroy(GetComponent<Rigidbody2D>().gameObject);
        }
    }
}
