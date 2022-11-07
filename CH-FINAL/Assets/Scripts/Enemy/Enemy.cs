using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform posPlayer;
    private float dist;
    private float lookingSpeed = 2f;
    private float MovingSpeed;
    public float AttackRange = 1f;
    public int zombieHP = 90;
    public bool dead;
    public int damageTaken = 30;
    public GameObject Zombie;
    private Animator animator;

    /* Attacking */
    public float radius = 1f;
    public int damageAmount = 15;
    
    void Start()
    {
        dead = false;

    }
    
    void Update()
    {
        CheckDistance();
        LookAtPlayer();
        FollowPlayer();

        if(dead)
        {
            Debug.Log("Enemigo Abatido");
            Destroy(Zombie);
        }
        
    }

    void CheckDistance()
    {
        dist = Vector3.Distance(posPlayer.position, transform.position);
        
    }

    void LookAtPlayer()
    {   
        if(dist <= 10)
        {                 
            Quaternion newRotation = Quaternion.LookRotation((posPlayer.position - transform.position));
            transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, lookingSpeed * Time.deltaTime);             
        }        
    }

    void FollowPlayer()
    {   
        if(dist >= AttackRange)
        {
        transform.position = Vector3.MoveTowards(transform.position, posPlayer.position, MovingSpeed * Time.deltaTime);
        MovingSpeed = 2f;
        animator.SetBool("ZIsMoving", true);
        animator.SetBool("ZIsAttacking", false);
        }

        if(dist <= AttackRange)
        {
        MovingSpeed = 0;
        animator.SetBool("ZIsMoving", false);
        animator.SetBool("ZIsAttacking", true);
        }
        
    }


    /* Attacking */
    private void OnCollisionEnter(Collision collision)
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach(Collider nearbyObject in colliders)
        {
            if(nearbyObject.tag == "Player")
            {
                PlayerManager.TakeDamage(damageAmount);
                Debug.Log("Damage taken: " + damageAmount);
            }

            if (nearbyObject.tag == "Impact")
            {
                zombieHP -= damageTaken;
                Debug.Log("Enemy HP: " + zombieHP);

                if (zombieHP <= 0)
                {
                    dead = true;
                }
            }

        }
        }
    }
}
