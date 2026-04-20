using UnityEngine;

/// <summary>
/// Base class for all weapons.
/// </summary>
public abstract class WeaponBase : MonoBehaviour
{
    /// <summary>
    /// Fires the weapon. Implemented by subclasses.
    /// </summary>
    public abstract void Fire();
}
