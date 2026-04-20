using UnityEngine;

public class WeaponMachineGun : WeaponBase
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float fireRate = 0.1f;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= fireRate)
        {
            Fire();
            timer = 0f;
        }
    }

    public override void Fire()
    {
        Instantiate(projectilePrefab, transform.position, transform.rotation);
    }
}
