using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuControls : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Play pressed");
    }
    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Play pressed");
    }
}
