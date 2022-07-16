using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void GoToNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void MainMenu() {
        SceneManager.LoadScene("MainMenu");
    }

    public int getCurrentLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        return currentLevel;
    }
}
