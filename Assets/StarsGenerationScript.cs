using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsGenerationScript : MonoBehaviour
{
    public GameObject red;
    public GameObject blue;
    public GameObject green;

    void Start()
    {
        InvokeRepeating("AddStar", 1f, 1f);
    }

    void AddStar()
    {
        Quaternion self_quatertion = Quaternion.AngleAxis(0, new Vector3(0, 0, 0));
        
        int b_x = Random.Range(0, 8);
        int b_y = Random.Range(-1, 2);

        Vector3 crystal_pos = new Vector3(11 + b_x, 0 + b_y, 0);

        int rand = Random.Range(0, 6);

        if (rand == 0)
        {
            Instantiate(red, crystal_pos, self_quatertion);
        }
        if (rand == 1)
        {
            Instantiate(green, crystal_pos, self_quatertion);
        }
        if (rand == 2)
        {
            Instantiate(blue, crystal_pos, self_quatertion);
        }

        /*Quaternion rotation_b = Quaternion.AngleAxis(0, new Vector3(0, 0, 0));

        Vector3 tr = new Vector3(11, 0, 0);

        int rand = Random.Range(0, 3);
        if (rand == 0)
        {
            Instantiate(red, tr, rotation_b);
        }
        if (rand == 1)
        {
            Instantiate(green, tr, rotation_b);
        }
        if (rand == 2)
        {
            Instantiate(blue, tr, rotation_b);
        }*/
    }

    void Update()
    {

    }
}
