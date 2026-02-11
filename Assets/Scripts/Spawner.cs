using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]private GameObject[] pipes;
    [SerializeField]private int selectedPipe= 0;

    [SerializeField]private float delay = 0;
    [SerializeField]private float time = 0;

    [SerializeField] private float heightRange = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.RegisterSpawner(this);
        InvokeRepeating("spawn", delay, time);
    }

    public int selectPipe(int pipeNumber) {
        if (pipeNumber<0 || pipeNumber> pipes.Length)
            return -1;
        selectedPipe = pipeNumber;  
        return selectedPipe;
    }

    private void spawn() {
        if (!GameManager.isGameOver())
        {
            Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange), 0);
            Instantiate(pipes[selectedPipe], spawnPos, transform.rotation);
        }
    }
}
