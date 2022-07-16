using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Image : MonoBehaviour
{
    public GameObject[] image; 
    void Start()
    {
        PickRandom_Image();
        
        InvokeRepeating("PickRandom_Image", timer, timer); 
    }

    public float timer; 
    void Update()
    {
        
 
    }

    void PickRandom_Image(){
        int x = Random.Range(0, image.Length);

        for(int i =0; i < image.Length; i++) {
            if (x != i) {
                image[i].SetActive(false); 
            }
            else {

                image[i].SetActive(true); 
            }

            }


        }
    }
