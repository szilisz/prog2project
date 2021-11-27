using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    [SerializeField] private AudioClip HurtSound;
    [SerializeField] private AudioClip death;
    [SerializeField] public GameObject mask1;
    [SerializeField] public GameObject mask2;

    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            SoundManager.instance.PlaySound(HurtSound);
            anim.SetTrigger("hurt");
        }
        else
        {
            if (!dead)
            {
                SoundManager.instance.PlaySound(death);
                mask1.gameObject.SetActive(false);
                mask2.gameObject.SetActive(false);
                anim.SetTrigger("die");
                GetComponent<PlayerMovement>().enabled = false;
                dead = true;
            }
        }
    }
    public void LoadGameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        dead = false;
    }
    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }
}