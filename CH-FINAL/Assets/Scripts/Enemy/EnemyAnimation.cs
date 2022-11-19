using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    private Animator animator;
    private Vector3 movementDirection;
    private GameObject target;
    private float dist;
    public int damageAmount = 15;
	private float timeToShoot = 3f;
	private float timeToShootLeft;
    public EnemyMovementTAG varGral;

    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
        animator = GetComponent<Animator>();
        target = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        CheckDistance();
        Temporizador();      

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

    void CheckDistance()
    {
        dist = Vector3.Distance(target.transform.position, transform.position);
    }

    private void ResetTimer()
	{
		timeToShootLeft = timeToShoot;
	}

    private void Shoot()
    {
        PlayerManager.TakeDamage(damageAmount);
        Debug.Log("Damage taken: " + damageAmount);
    }

    private void Temporizador()
	{
		if(varGral.dead != true)
        {
            timeToShootLeft -= Time.deltaTime;
            if(timeToShootLeft <= 0 && dist <= 1.5) {
                Shoot();
                ResetTimer();					
            }
        }
	}
}
