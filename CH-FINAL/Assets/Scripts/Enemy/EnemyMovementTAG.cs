using UnityEngine;
using UnityEngine.AI;

public class EnemyMovementTAG : MonoBehaviour
{
    private GameObject target;
    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {        
        /* transform.LookAt(target.transform); */
        if(agent != null)
        {
        agent.SetDestination(target.transform.position);
        }

        if(dead)
        {            
            Destroy(agent);
        }
    }

    /* Attacking */
    public float radius = 1f;    
    public int zombieHP = 90;    
    public int damageTaken = 30;
    public bool dead;

    private void OnCollisionEnter(Collision collision)
    {
        
        if(dead != true)
        {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach(Collider nearbyObject in colliders)
        {            
            if(nearbyObject.tag == "Impact")
            {                
                zombieHP -= damageTaken;
                Debug.Log("Enemy HP: " + zombieHP);
        
                if(zombieHP <= 0)
                {
                    Debug.Log("Enemigo Abatido");
                    dead = true;
                }                
            }
        }
        }
    }    
}