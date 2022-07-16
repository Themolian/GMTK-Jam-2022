using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSpin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Vector3 rotation; 
    public float speed = 5f; 
    void Update()
    {
        transform.Rotate(rotation * speed * Time.deltaTime); 
    }
}
