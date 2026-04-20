using UnityEngine;

/// <summary>
/// Player-specific movement logic.
/// Reads input and passes direction to EngineBase.
/// </summary>
public class PlayerMovement : EngineBase
{
    private void Update()
    {
        Move();
    }

    /// <summary>
    /// Receives input direction from PlayerInput and updates movementDirection.
    /// </summary>
    public void SetInputDirection(Vector2 input)
    {
        movementDirection = new Vector3(input.x, input.y, 0).normalized;
    }
}
