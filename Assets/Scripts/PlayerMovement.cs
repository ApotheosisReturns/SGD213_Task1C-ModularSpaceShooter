using UnityEngine;

public class PlayerMovement : EngineBase
{
    private float horizontalInput;

    public void SetHorizontalInput(float x)
    {
        horizontalInput = x;
    }

    private void Update()
    {
        // Only move left/right
        movementDirection = new Vector2(horizontalInput, 0f);
        Move();
    }
}
