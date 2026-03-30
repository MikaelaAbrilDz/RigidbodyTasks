using UnityEngine;
using UnityEngine.InputSystem;

public class Task_08_Explosion : MonoBehaviour
{
    float explosionStrenght = 500;
    float radius = 5;
    float updwardsModifier = 2;
    public void AddExplosionForce(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Collider[] affectedBodies = Physics.OverlapSphere(transform.position, radius);
            foreach (Collider affectedBody in affectedBodies)
            {
                if (affectedBody.GetComponent<Rigidbody>() != null) affectedBody.GetComponent<Rigidbody>()?.AddExplosionForce(explosionStrenght, transform.position, radius, updwardsModifier);
            }
        }
    }
}
