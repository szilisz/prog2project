using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class finishline : MonoBehaviour
{

    private void OnTriggerEnter2D( Collider2D collision)
        {
            if (collision.tag == "Player")
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
}