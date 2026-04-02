using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BulletMoveForward : MonoBehaviour
{
    [SerializeField] private float acceleration = 50f;
    [SerializeField] private float initialVelocity = 5f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        // Set initial upward velocity
        rb.velocity = Vector2.up * initialVelocity;
    }

    private void FixedUpdate()
    {
        // Apply continuous upward force
        Vector2 force = Vector2.up * acceleration * Time.fixedDeltaTime;
        rb.AddForce(force);
    }
}