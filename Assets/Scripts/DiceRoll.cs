using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    float randomNumberD4;
    int difficultyLevel;
    // Start is called before the first frame update
    void Start()
    {
        difficultyLevel = 1;
        InvokeRepeating("RollDice", 2, 2);
        InvokeRepeating("ApplyEffect", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    void RollDice() {
        switch (difficultyLevel)
        {
            case 1:
            randomNumberD4 = Random.Range(1, 4);
            break;
        }
        Debug.Log(randomNumberD4);
    }

    void ApplyEffect() {
        switch (randomNumberD4) {
            case 1:
            Debug.Log("Tyres -1");
            break;
            
            case 2:
            Debug.Log("Helmet - 1");
            break;

            case 3:
            Debug.Log("Plastic bag goes WHAM");
            break;

            case 4:
            Debug.Log("Nothing happened");
            break;
        }
    }
}
