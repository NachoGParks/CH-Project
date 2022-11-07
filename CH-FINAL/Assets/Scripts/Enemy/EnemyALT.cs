using UnityEngine;

public class EnemyALT : MonoBehaviour
{    
    /* Attacking */
    public int zombieHP = 90;
    public bool dead;
    public int damageTaken = 30;
    public GameObject Zombie;    
    public float radius = 1f;
    public int damageAmount = 15;
    
    void Start()
    {        
        dead = false;        
    }
    
    void Update()
    {        
        if(dead)
        {
            Debug.Log("Enemigo Abatido");
            Destroy(Zombie);
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

            if(nearbyObject.tag == "Impact")
            {                
                zombieHP -= damageTaken;
                Debug.Log("Enemy HP: " + zombieHP);
        
                if(zombieHP <= 0)
                {
                    dead = true;
                }                
            }
        }
    }
}
