using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject zombie;

    public GameObject Spawnpoint01;
    public GameObject Spawnpoint02;
    public GameObject Spawnpoint03;
    public GameObject Spawnpoint04;
    private Vector3 SP01pos;
    private Vector3 SP02pos;
    private Vector3 SP03pos;
    private Vector3 SP04pos;


    private float Interval01 = 5.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(Interval01, zombie));
        StartCoroutine(spawnEnemy2(Interval01, zombie));
        StartCoroutine(spawnEnemy3(Interval01, zombie));
        StartCoroutine(spawnEnemy4(Interval01, zombie));
        SP01pos = Spawnpoint01.transform.position;
        SP02pos = Spawnpoint02.transform.position;
        SP03pos = Spawnpoint03.transform.position;
        SP04pos = Spawnpoint04.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, SP01pos, Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }

    private IEnumerator spawnEnemy2(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, SP02pos, Quaternion.identity);
        StartCoroutine(spawnEnemy2(interval, enemy));
    }
    private IEnumerator spawnEnemy3(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, SP03pos, Quaternion.identity);
        StartCoroutine(spawnEnemy3(interval, enemy));
    }
    private IEnumerator spawnEnemy4(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, SP04pos, Quaternion.identity);
        StartCoroutine(spawnEnemy4(interval, enemy));
    }
}
