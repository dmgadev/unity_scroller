using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrollingScript : MonoBehaviour
{
    public MeshRenderer firstBG;
    public float scrollSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        float x = Mathf.Repeat(Time.time * scrollSpeed, 1);
        Vector2 offset = new Vector2(x, 0);
        firstBG.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}