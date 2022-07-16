using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTexture : MonoBehaviour
{
    public Vector2 offset = new Vector2(0.2f, 0); 
    Renderer rend; 
    void Start()
    {
        rend = GetComponent<Renderer>(); 
    }

    public float speed = 0.25f; 
    Vector2 VisualMovement = new Vector2(0,0); 
    void Update()
    {
        VisualMovement =new Vector2(VisualMovement.x + offset.x * speed* Time.deltaTime,VisualMovement.y + offset.y * speed* Time.deltaTime); 
        rend.material.SetTextureOffset("_MainTex",  VisualMovement); 

    }
}
