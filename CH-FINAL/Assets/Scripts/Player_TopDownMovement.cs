using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_TopDownMovement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;

    void Start()
    {
        
    }


    void Update()
    {
        MovementInput();

    }

    void MovementInput()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");

        Vector3 _movement = new Vector3(_horizontal, 0, _vertical);
        transform.Translate(_movement * movementSpeed * Time.deltaTime, Space.World);

    }

}
