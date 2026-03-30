using UnityEngine;
using UnityEngine.InputSystem;

public class Task_02_ObjectMover : MonoBehaviour
{
    Rigidbody rb;
    Vector2 inputMovement;
    float strenght = 10;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.AddForce(new Vector3(inputMovement.x, 0, inputMovement.y).normalized * strenght, ForceMode.Force);
    }
    public void onMove(InputAction.CallbackContext context)
    {
        inputMovement = context.ReadValue<Vector2>();
    }
}
