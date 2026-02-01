using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]private GameObject pipe;
    [SerializeField]private float delay = 0;
    [SerializeField]private float time = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("spawn", delay, time);
    }

    private void spawn() { 
        Instantiate(pipe,transform.position, transform.rotation);
    }
}
