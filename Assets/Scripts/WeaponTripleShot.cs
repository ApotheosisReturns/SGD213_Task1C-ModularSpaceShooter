using UnityEngine;

public class WeaponTripleShot : WeaponBase
{
    [Header("Triple Shot Settings")]
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float spreadAngle = 15f;

    public override void Fire()
    {
        if (firePoint == null)
        {
            Debug.LogError("TripleShot has no firePoint assigned!");
            return;
        }

        // Center shot
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Left angled shot
        Quaternion leftRot = firePoint.rotation * Quaternion.Euler(0, 0, -spreadAngle);
        Instantiate(bulletPrefab, firePoint.position, leftRot);

        // Right angled shot
        Quaternion rightRot = firePoint.rotation * Quaternion.Euler(0, 0, spreadAngle);
        Instantiate(bulletPrefab, firePoint.position, rightRot);
    }
}
