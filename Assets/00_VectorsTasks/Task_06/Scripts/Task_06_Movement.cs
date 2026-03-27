using UnityEngine;

public class Task_06_Movement : MonoBehaviour
{
    Rigidbody rb;
    float strenght = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.AddForce(transform.forward * strenght, ForceMode.Acceleration);
    }
}
