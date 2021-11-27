using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] icebolts;
    [SerializeField] private GameObject[] fireballs;
    [SerializeField] public GameObject mask1;
    [SerializeField] public GameObject mask2;
    [SerializeField] private AudioClip fire;
    [SerializeField] private AudioClip freeze;



    private Animator anim;
    private PlayerMovement playerMovement;
    private float cooldownTimer = Mathf.Infinity;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (mask1.gameObject.activeInHierarchy && Input.GetKey(KeyCode.Q) && cooldownTimer > attackCooldown)
        {
            SoundManager.instance.PlaySound(freeze);
            Attack();
        }

        if (mask2.gameObject.activeInHierarchy && Input.GetKey(KeyCode.Q) && cooldownTimer > attackCooldown)
        {
            SoundManager.instance.PlaySound(fire);
            Attack2();
        }

        cooldownTimer += Time.deltaTime;
    }

    private void Attack()
    {
        anim.SetTrigger("attack");
        cooldownTimer = 0;

        icebolts[FindIce()].transform.position = firePoint.position;
        icebolts[FindIce()].GetComponent<Projectile>().SetDirection(Mathf.Sign(transform.localScale.x));
    }
    private int FindIce()
    {
        for (int i = 0; i < icebolts.Length; i++)
        {
            if (!icebolts[i].activeInHierarchy)
                return i;
        }
        return 0;
    }

    private void Attack2()
    {
        anim.SetTrigger("attack");
        cooldownTimer = 0;

        fireballs[FindFire()].transform.position = firePoint.position;
        fireballs[FindFire()].GetComponent<Projectile>().SetDirection(Mathf.Sign(transform.localScale.x));
    }
    private int FindFire()
    {
        for (int i = 0; i < fireballs.Length; i++)
        {
            if (!fireballs[i].activeInHierarchy)
                return i;
        }
        return 0;
    }
    private void maskoff()
    {
        gameObject.SetActive(false);
    }


}