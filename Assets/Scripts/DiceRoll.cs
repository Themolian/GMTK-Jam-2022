using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoll : MonoBehaviour
{
    float randomNumberD4;
    int difficultyLevel;
    float covidExposure;
    float infectionRate;
    float recoveryRate;

    public Image Exposure;

    public bool maskOn;

    public GameObject cyclist;

    private Animator cyclistAnimator;

    private Animation maskOnAnim;

    public GameObject diceTransform;

    // Start is called before the first frame update
    void Start()
    {
        cyclistAnimator = cyclist.GetComponent<Animator>();
        difficultyLevel = 1;
        covidExposure = 100;
        maskOn = true;
        infectionRate = .1f;
        recoveryRate = .1f;
        
        InvokeRepeating("RollDice", 2, 2);
        InvokeRepeating("ApplyEffect", 2, 2);
        InvokeRepeating("GetSick", 2, .3f);
        InvokeRepeating("GetBetter", 0, .3f);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)) {
            cyclistAnimator.Play("Mask", -1, 0f);
        }

        // if(Input.GetKeyDown(KeyCode.D)) {
        //     float randomNumberD6;
        //     randomNumberD6 = Random.Range(1, 7);
        //     Quaternion rotation1 = Quaternion.Euler(diceTransform.transform.rotation);
        //     Quaternion rotation2;
        //     float speed = 0.1f;

        //     switch(randomNumberD6) {
        //         case 1:
        //         rotation2 = new Vector3(-0.994f, -90f, 90f);
        //         StartCoroutine(RotateOverTime(rotation1, rotation2, 1f / speed));
        //         break;
        //         case 2:
        //         rotation2 = new Vector3(1.573f, 90.574f, 269.975f);
        //         StartCoroutine(RotateOverTime(rotation1, rotation2, 1f / speed));
        //         break;
        //         case 3:
        //         rotation2 = new Vector3(-89.98f, 0f, 0f);
        //         StartCoroutine(RotateOverTime(rotation1, rotation2, 1f / speed));
        //         break;
        //         case 4:
        //         rotation2 = new Vector3(0.06f, 179.301f, 271.572f);
        //         StartCoroutine(RotateOverTime(rotation1, rotation2, 1f / speed));
        //         break;
        //         case 5:
        //         rotation2 = new Vector3(-0.004f, 1.349f, 268.427f);
        //         StartCoroutine(RotateOverTime(rotation1, rotation2, 1f / speed));
        //         break;
        //         case 6:
        //         rotation2 = new Vector3(-0.004f, 1.349f, 176.974f);
        //         StartCoroutine(RotateOverTime(rotation1, rotation2, 1f / speed));
        //         break;
        //     }
        // }
    }
    
    void RollDice() {
        switch (difficultyLevel)
        {
            case 1:
            randomNumberD4 = Random.Range(1, 5);
            break;
        }
        Debug.Log(randomNumberD4);
    }

    void ApplyEffect() {
        switch (randomNumberD4) {
            case 1:
            // Debug.Log("Tyres -1");
            break;
            
            case 2:
            // Debug.Log("Helmet - 1");
            break;

            case 3:
            // Debug.Log("Plastic bag goes WHAM");
            break;

            case 4:
            maskOn = false;
            break;
        }
    }
    
    void GetSick() {
        if(!maskOn) {
            covidExposure -= infectionRate;
            Debug.Log(covidExposure);
        }
    }

    void GetBetter() {
        if(maskOn) {
            if(covidExposure != 100) {
                covidExposure += recoveryRate;
                Debug.Log(covidExposure);
            } else {
                covidExposure = 100;
            }
        }
    }

    IEnumerator RotateOverTime (Quaternion originalRotation, Quaternion finalRotation, float duration) {
        if (duration > 0f) {
            float startTime = Time.time;
            float endTime = startTime + duration;
            diceTransform.transform.rotation = originalRotation;
            yield return null;
            while (Time.time < endTime) {
                float progress = (Time.time - startTime) / duration;
                // progress will equal 0 at startTime, 1 at endTime.
                diceTransform.transform.rotation = Quaternion.Slerp (originalRotation, finalRotation, progress);
                yield return null;
            }
        }
        diceTransform.transform.rotation = finalRotation;
    }
}