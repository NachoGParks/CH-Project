using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform posPlayer;
    private float dist;
    private float lookingSpeed = 2f;
    private float MovingSpeed;
    public float AttackRange = 1f;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        CheckDistance();
        LookAtPlayer();
        FollowPlayer();
        
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
        }

        if(dist <= AttackRange)
        {
        MovingSpeed = 0;
        }
        
    }    
}
