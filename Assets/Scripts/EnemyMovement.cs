using UnityEngine;

public class EnemyMovement : EngineBase
{
    [SerializeField] private Transform target;

    private void Update()
    {
        if (target == null) return;

        // Move ONLY horizontally toward the player's X position
        float horizontal = Mathf.Sign(target.position.x - transform.position.x);

        // No vertical movement
        float vertical = 0f;

        movementDirection = new Vector2(horizontal, vertical);

        Move();
    }
}
