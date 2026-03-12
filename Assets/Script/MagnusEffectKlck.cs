using UnityEngine;
using UnityEngine.InputSystem;
public class MagnusEffectKlck : MonoBehaviour
{
    public float KickForce;
    public float SpinAmount;
    public float MagnusStrength = 0.5f;

    Rigidbody rb;
    bool isShot = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && !isShot)
        {
            rb.AddForce(Vector3.forward * KickForce, ForceMode.Impulse);
            
            rb.AddTorque(Vector3.up * SpinAmount);
            
            isShot = true;
        }

    }

    private void FixedUpdate()
    {
        if (isShot) return;

        Vector3 velocity = rb.linearVelocity;
        Vector3 spin = rb.angularVelocity;

        Vector3 magnusForce = MagnusStrength * Vector3.Cross(spin, velocity);

        rb.AddForce(magnusForce);
    }
}
