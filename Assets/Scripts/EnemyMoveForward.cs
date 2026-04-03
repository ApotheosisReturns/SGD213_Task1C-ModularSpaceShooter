using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMoveForward : MonoBehaviour
{
    [SerializeField] private float acceleration = 75f;
    [SerializeField] private float initialVelocity = 2f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        // Set initial downward velocity
        rb.velocity = Vector2.down * initialVelocity;
    }

    private void FixedUpdate()
    {
        // Apply continuous downward force
        Vector2 force = Vector2.down * acceleration * Time.fixedDeltaTime;
        rb.AddForce(force);
    }
}