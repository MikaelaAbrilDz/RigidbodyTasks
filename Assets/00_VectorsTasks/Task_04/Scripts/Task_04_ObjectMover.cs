using UnityEngine;
using UnityEngine.InputSystem;

public class Task_04_ObjectMover : MonoBehaviour
{
    Rigidbody rb;
    Vector2 inputMovement;
    float strenght = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.linearVelocity =new Vector3(inputMovement.x, 0, inputMovement.y).normalized * strenght;
    }
    public void onMove(InputAction.CallbackContext context)
    {
        inputMovement = context.ReadValue<Vector2>();
    }
}
