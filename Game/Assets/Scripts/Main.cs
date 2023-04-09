using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public void Game()
    {
        SceneManager.LoadScene("Game");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
