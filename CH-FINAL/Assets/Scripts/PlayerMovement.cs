using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        CheckMovement();
        CheckRotation();

    }

    void CheckMovement()
    {
        var xMove = transform.right * (Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime);
        var zMove = transform.forward * (Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime);
        var move = xMove + zMove;

        transform.position += move;
    }

    void CheckRotation()
    {
        var rotation = Input.GetAxisRaw("Mouse X") * rotateSpeed * Time.deltaTime * 500;

        transform.Rotate(0f, rotation, 0f);
    }
 
}
