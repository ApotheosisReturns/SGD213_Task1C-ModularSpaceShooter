using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    [Header("Fire Point")]
    public Transform firePoint;

    // Every weapon must implement its own firing logic
    public abstract void Fire();
}
