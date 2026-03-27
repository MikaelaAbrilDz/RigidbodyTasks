using UnityEngine;
using UnityEngine.InputSystem;

public class Task_03_Car : MonoBehaviour
{
    Rigidbody rb;
    float inputMovement;
    float gas = 1000;
    float brake = 500;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (inputMovement > 0) rb.AddForce(transform.forward * gas, ForceMode.Force);
        else if (inputMovement < 0) rb.AddForce(-transform.forward * brake, ForceMode.Force);
    }
    public void onMove(InputAction.CallbackContext context)
    {
        inputMovement = context.ReadValue<float>();
    }
}
