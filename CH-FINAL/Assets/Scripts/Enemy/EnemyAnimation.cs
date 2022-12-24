using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    private Animator animator;
    private Vector3 movementDirection;
    public EnemyManager enemyManager;    

    // Start is called before the first frame update
    void Start()
    {        
        animator = GetComponent<Animator>();        
    }

    // Update is called once per frame
    void Update()
    {        
        if (transform.hasChanged)
        {            
            animator.SetBool("isRunning", true);
            transform.hasChanged = false;            
        }
        else
        {
            animator.SetBool("isRunning", false); 
        }
    }
}
