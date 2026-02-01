using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController:MonoBehaviour
{
    [SerializeField] private float jumpForce = 0;
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
        if (context.performed)
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

}
