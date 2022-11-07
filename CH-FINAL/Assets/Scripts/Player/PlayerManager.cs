using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static int playerHP = 100;
    public static bool dead;
    public GameObject Player;
    private Animator animator;

    void Start()
    {
        dead = false;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        //Buscar la forma de no usar Destroy, sino que anule el movimiento del Player al morir para ver la animacion de muerte
        if(dead)
        {
            Debug.Log("La Quedutti!");
            Destroy(Player);

            animator.SetBool("IsDead", true);
        }
        else
        {
            animator.SetBool("IsDead", false);
        }
    }

    public static void TakeDamage(int damageAmount)
    {
        playerHP -= damageAmount;
        Debug.Log("Player HP= " + playerHP);

        if(playerHP <= 0)
        {
            dead = true;

        }
    }
}
