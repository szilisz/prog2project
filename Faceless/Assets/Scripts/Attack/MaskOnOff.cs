using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskOnOff : MonoBehaviour
{
    [SerializeField] public GameObject mask1;
    [SerializeField] public GameObject mask2;
    [SerializeField] public GameObject maskice;
    [SerializeField] public GameObject maskfire;
    [SerializeField] private AudioClip pickup;


    public bool maskI = false;
    public bool maskF = false;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && maskI)
        {
            mask1.gameObject.SetActive(true);
            mask2.gameObject.SetActive(false);

        }
        if (Input.GetKeyDown(KeyCode.E) && maskF)
        {
            mask1.gameObject.SetActive(false);
            mask2.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "MaskIce")
        {
            SoundManager.instance.PlaySound(pickup);
            maskice.gameObject.SetActive(false);
            maskI = true;
        }

        if (collision.tag == "MaskFire")
        {
            SoundManager.instance.PlaySound(pickup);
            maskfire.gameObject.SetActive(false);
            maskF = true;
        }
    }
}
