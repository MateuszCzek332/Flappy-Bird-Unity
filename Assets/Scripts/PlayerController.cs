using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController:MonoBehaviour
{
    [SerializeField] private float jumpForce = 0;
    [SerializeField]private AudioManager audioManager;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {

    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed && !GameManager.isGameOver()) { 
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            audioManager.playJumpSound();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //audioManager.playDeathSound();
        GameManager.GameOver();
    }

    private void OnTriggerEnter(Collider other)
    {
        audioManager.playScoreSound();
        GameManager.UpdateScore();
    }

}
