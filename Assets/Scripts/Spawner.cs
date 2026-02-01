using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]private GameObject pipe;
    [SerializeField]private float delay = 0;
    [SerializeField]private float time = 0;

    [SerializeField] private float heightRange = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("spawn", delay, time);
    }

    private void spawn() { 
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange), 0);
        Instantiate(pipe, spawnPos, transform.rotation);
    }
}
