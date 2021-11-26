using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void PlayGame(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }
    public void GoToMenu(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }

}