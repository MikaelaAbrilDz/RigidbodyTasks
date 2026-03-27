using UnityEngine;
using UnityEngine.InputSystem;

public class Task_01_ObjectMover : MonoBehaviour
{
    Rigidbody rb;
    bool isMoving;
    float strenght = 10;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (isMoving) rb.AddForce(transform.forward * strenght, ForceMode.Force);
    }
    public void onMoveFwd(InputAction.CallbackContext context)
    {
        if (context.performed) isMoving = true;
        if (context.canceled) isMoving = false;
    }
}
