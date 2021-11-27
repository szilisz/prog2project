using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creds : MonoBehaviour
{
    public void quit(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }
}