using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{   
    Animator anim;

    private float movementSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MovementInput()
    {
        float _horizontal = transform.position.x;
        float _vertical = transform.position.z;
     
        Vector3 _movement = new Vector3(_horizontal, 0, _vertical);        

        Vector3 localMove=transform.InverseTransformDirection(_movement);

        anim.SetFloat("Forward", _movement.z);
        anim.SetFloat("Sideways", _movement.x);

    }

    void RotationInput()
    {
        RaycastHit _hit;
        Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(_ray, out _hit))
        {
            transform.LookAt(new Vector3(_hit.point.x, transform.position.y, _hit.point.z));

        }
    }
}
