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
        // Use the bullet's own forward direction
        rb.velocity = transform.up * initialVelocity;
    }

    private void FixedUpdate()
    {
        // Apply force in the bullet's forward direction
        Vector2 force = transform.up * acceleration * Time.fixedDeltaTime;
        rb.AddForce(force);
    }
}
