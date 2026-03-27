using UnityEngine;
using UnityEngine.InputSystem;

public class Task_07_Rotator : MonoBehaviour
{
    Rigidbody rb;
    float inputRotation;
    float torqueForce = 10;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.AddTorque(new Vector3(0, inputRotation, 0) * torqueForce, ForceMode.Force);
    }
    public void onRotate(InputAction.CallbackContext context)
    {
        inputRotation = context.ReadValue<float>();
    }
}
