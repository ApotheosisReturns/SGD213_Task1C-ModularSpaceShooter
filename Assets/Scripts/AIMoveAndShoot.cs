using UnityEngine;

public class AIMoveAndShoot : MonoBehaviour
{
    [SerializeField] private EnemyMovement movement;

    [Header("Weapon Settings")]
    [SerializeField] private GameObject enemyProjectilePrefab;   // <-- You can now assign your bullet here
    [SerializeField] private Transform firePoint;                // <-- Optional: assign enemy fire point
    [SerializeField] private float fireInterval = 2f;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= fireInterval)
        {
            FireEnemyBullet();
            timer = 0f;
        }
    }

    private void FireEnemyBullet()
    {
        if (enemyProjectilePrefab == null)
        {
            Debug.LogError("Enemy projectile prefab is NOT assigned!");
            return;
        }

        if (firePoint == null)
        {
            Debug.LogError("Enemy firePoint is NOT assigned!");
            return;
        }

        Instantiate(enemyProjectilePrefab, firePoint.position, firePoint.rotation);
    }
}
