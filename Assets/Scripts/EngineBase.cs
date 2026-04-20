using UnityEngine;

/// <summary>
/// Base movement engine used by both Player and Enemy.
/// Handles acceleration, deceleration and directional movement.
/// </summary>
public class EngineBase : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] protected float moveSpeed = 5f;

    protected Vector3 movementDirection;

    /// <summary>
    /// Moves the object based on the movementDirection vector.
    /// </summary>
    protected void Move()
    {
        transform.Translate(movementDirection * moveSpeed * Time.deltaTime);
    }
}
