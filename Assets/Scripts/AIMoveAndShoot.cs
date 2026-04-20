using UnityEngine;

/// <summary>
/// Simple AI that moves using EnemyMovement and fires a weapon.
/// </summary>
public class AIMoveAndShoot : MonoBehaviour
{
    [SerializeField] private EnemyMovement movement;
    [SerializeField] private WeaponBase weapon;
    [SerializeField] private float fireInterval = 2f;

    private float timer;

    private void Update()
    {
        // Movement is now handled INSIDE EnemyMovement.Update()
        // so we do NOT call MoveEnemy() anymore.

        timer += Time.deltaTime;

        if (timer >= fireInterval)
        {
            weapon.Fire();
            timer = 0f;
        }
    }
}
