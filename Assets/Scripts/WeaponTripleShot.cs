using UnityEngine;

public class WeaponTripleShot : WeaponBase
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float spreadAngle = 15f;

    public override void Fire()
    {
        FireProjectile(0);
        FireProjectile(-spreadAngle);
        FireProjectile(spreadAngle);
    }

    private void FireProjectile(float angleOffset)
    {
        Quaternion rotation = Quaternion.Euler(0, 0, angleOffset);
        Instantiate(projectilePrefab, transform.position, transform.rotation * rotation);
    }
}
