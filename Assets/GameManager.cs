using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameOver { get; private set; }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void RestartScene()
    {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void GameOver()
    {
        isGameOver =true;
    }
}
