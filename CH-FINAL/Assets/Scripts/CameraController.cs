using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform targetPlayer;
    [SerializeField]
    private Vector3 targetDistance;
    [SerializeField]
    private float cameraSpeed;


    void Start()
    {
        
    }

    void Update()
    {
        MoveCamera();
    }

    void MoveCamera()
    {
        transform.position = Vector3.Lerp(transform.position, targetPlayer.position + targetDistance, cameraSpeed * Time.deltaTime);

    }

}
