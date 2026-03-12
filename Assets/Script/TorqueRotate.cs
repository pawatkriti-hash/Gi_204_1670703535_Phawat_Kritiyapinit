using UnityEngine;
using UnityEngine.InputSystem;

public class TorqueRotate : MonoBehaviour
{
    public float angularSpeed;

    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            rb.angularVelocity = new Vector3(0, 0, angularSpeed);
        }
        else

        {

            rb.angularVelocity = Vector3.zero;

        }

    }

}
