using UnityEngine;

/// <summary>
/// Enemy movement logic.
/// Moves toward a target (e.g., the player).
/// </summary>
public class EnemyMovement : EngineBase
{
    [SerializeField] private Transform target;

    private void Update()
    {
        if (target == null) return;

        movementDirection = (target.position - transform.position).normalized;

        Move();
    }
}
