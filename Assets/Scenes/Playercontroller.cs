using UnityEngine;
using UnityEngine.InputSystem;
public class Playercontroller : MonoBehaviour
{


    private Rigidbody rb;

    private float MovementX;
    private float MovementY;

    public float speed = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
   private void FixedUpdate()
    {
        Vector3 Movement = new Vector3 (MovementX, 0.0f, MovementY);

        rb.AddForce(Movement*speed);
    }

    void OnMove(InputValue MovementValue)
    {
        Vector2 MovementVector= MovementValue.Get<Vector2>();
        MovementX = MovementVector.x;
        MovementY = MovementVector.y;
    }
}
