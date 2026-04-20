using UnityEngine;

/// <summary>
/// Spawns Pickup prefabs at timed intervals.
/// Multiple copies of this component can be placed in the scene
/// to create multiple spawn points.
/// </summary>
public class PickupSpawner : MonoBehaviour
{
    [Header("Pickup Settings")]
    [SerializeField] private GameObject pickupPrefab;

    [Header("Spawn Timing")]
    [SerializeField] private float spawnInterval = 10f;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnPickup();
            timer = 0f;
        }
    }

    /// <summary>
    /// Instantiates the pickup prefab at the spawner's position.
    /// </summary>
    private void SpawnPickup()
    {
        Instantiate(pickupPrefab, transform.position, Quaternion.identity);
    }
}
