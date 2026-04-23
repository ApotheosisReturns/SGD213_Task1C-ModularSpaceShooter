using UnityEngine;

public class EngineBase : MonoBehaviour
{
    [SerializeField] protected float moveSpeed = 5f;
    protected Vector2 movementDirection;

    protected void Move()
    {
        transform.position += (Vector3)movementDirection * moveSpeed * Time.deltaTime;
    }
}
