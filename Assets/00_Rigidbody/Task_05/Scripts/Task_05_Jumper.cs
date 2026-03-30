using UnityEngine;
using UnityEngine.InputSystem;

public class Task_05_Jumper : MonoBehaviour
{
    Rigidbody rb;
    float strenght = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void onJump(InputAction.CallbackContext context)
    {
        if (context.performed) rb.AddForce(transform.up * strenght, ForceMode.Impulse);
    }
}
