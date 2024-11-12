using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerS : MonoBehaviour
{
    public GameObject gameUI;


    private void Start()
    {
        gameUI.SetActive(false);
    }

    public void GameOver()
    {
        if (gameUI != null)
        {
            gameUI.SetActive(true); 
        }
        else
        {
            Debug.LogError("Game Over UI is missing.");
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        gameUI.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
