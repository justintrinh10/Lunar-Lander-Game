using UnityEngine;
using UnityEngine.InputSystem;

public class Lander : MonoBehaviour
{
    private Rigidbody2D landerRigidbody2D;
    private float thrust = 700f;
    private float rotationSpeed = 100f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        landerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Keyboard.current.upArrowKey.isPressed)
        {
            landerRigidbody2D.AddForce(thrust * transform.up * Time.deltaTime);
            Debug.Log("Thrusting");
        }

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            landerRigidbody2D.AddTorque(rotationSpeed * Time.deltaTime);
            Debug.Log("Rotating Left");
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            landerRigidbody2D.AddTorque(-rotationSpeed * Time.deltaTime);
            Debug.Log("Rotating Right");
        }
    }
}
