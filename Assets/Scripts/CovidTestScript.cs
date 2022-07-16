using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CovidTestScript : MonoBehaviour
{

    public Image testLine;
    [Range(0,255)]
    public byte alpha;

    // Update is called once per frame
    void Update()
    {
        testLine.color = new Color32(255,255,255,alpha);
    }
}
