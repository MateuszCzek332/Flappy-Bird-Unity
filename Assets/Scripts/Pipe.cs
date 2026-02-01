using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField]private float speed = 0;
    void Start()
    {
        
    }

    void Update()
    {
        moveLeft();
    }

    private void moveLeft() {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if(transform.position.x < -20)
            Destroy(gameObject);
        
    }
    
}
