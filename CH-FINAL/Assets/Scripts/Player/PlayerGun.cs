using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public float range = 30f;
    public GameObject rayCastStart;
    public GameObject impacto;
    public int ShotDamage;
    public ParticleSystem muzzleFlash;
    public AudioSource shootingSound;

    // Start is called before the first frame update
    void Start()
    {
      shootingSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Disparar();
        }
    }

    void Disparar()
    {
        muzzleFlash.Play();
        shootingSound.Play();
        RaycastHit hit;
        if(Physics.Raycast(rayCastStart.transform.position, rayCastStart.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if(hit.transform.CompareTag("Zombie"))
            {
                GameObject go = Instantiate(impacto, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy (go, 0.2f);
            }
        }
    }   
}
