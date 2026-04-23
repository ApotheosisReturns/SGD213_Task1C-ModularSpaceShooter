using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        playerMovement.SetHorizontalInput(x);
    }
}
