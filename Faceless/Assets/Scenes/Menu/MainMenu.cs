using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(int SceneID)
    {
         SceneManager.LoadScene(SceneID);
    }
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
    public void GoToInstructions(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }
}