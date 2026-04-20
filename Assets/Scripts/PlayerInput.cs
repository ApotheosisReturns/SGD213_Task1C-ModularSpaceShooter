using UnityEngine;

/// <summary>
/// PlayerInput handles all player-specific input behaviour and passes
/// input information to the appropriate components.
/// </summary>
public class PlayerInput : MonoBehaviour
{
    // Local references
    private PlayerMovement playerMovement;
    private WeaponBase weapon;

    public WeaponBase Weapon
    {
        get => weapon;
        set => weapon = value;
    }

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        weapon = GetComponent<WeaponBase>();
    }

    private void Update()
    {
        HandleMovementInput();
        HandleFireInput();
    }

    /// <summary>
    /// Reads movement input and passes it to PlayerMovement.
    /// PlayerMovement handles the actual movement logic.
    /// </summary>
    private void HandleMovementInput()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        if (playerMovement != null)
        {
            playerMovement.SetInputDirection(new Vector2(x, y));
        }
    }

    /// <summary>
    /// Reads fire input and triggers the weapon.
    /// </summary>
    private void HandleFireInput()
    {
        if (Input.GetButton("Fire1") && weapon != null)
        {
            weapon.Fire();
        }
    }

    /// <summary>
    /// Swaps the player's weapon by adding a new WeaponBase component
    /// and removing the old one.
    /// </summary>
    public void SwapWeapon(WeaponType weaponType)
    {
        WeaponBase newWeapon = null;

        switch (weaponType)
        {
            case WeaponType.machineGun:
                newWeapon = gameObject.AddComponent<WeaponMachineGun>();
                break;

            case WeaponType.tripleShot:
                newWeapon = gameObject.AddComponent<WeaponTripleShot>();
                break;
        }

        // Remove the old weapon
        Destroy(weapon);

        // Assign the new weapon
        weapon = newWeapon;
    }
}
