using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;   // เปลี่ยนเป็น array
    public Vector3 spawnPos = new(25, 0, 0);

    public float startDelay = 2;
    public float repeatRate = 2;

    private PlayerController playerController;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), startDelay, repeatRate);

        playerController = GameObject.Find("Player").GetComponent<PlayerController>(); 
    }

    void SpawnObstacle()
    {
        int index = Random.Range(0, obstaclePrefab.Length);  

        Instantiate(obstaclePrefab[index], spawnPos, obstaclePrefab[index].transform.rotation);
    }
}