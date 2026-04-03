using UnityEngine;

public class SpawnOverTimeScript : MonoBehaviour
{
    [SerializeField] private GameObject spawnObject;
    [SerializeField] private float spawnDelay = 2f;

    private Renderer ourRenderer;

    private void Awake()
    {
        ourRenderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        // Hide the spawner visually (if it has a renderer)
        if (ourRenderer != null)
        {
            ourRenderer.enabled = false;
        }

        InvokeRepeating(nameof(Spawn), spawnDelay, spawnDelay);
    }

    private void Spawn()
    {
        if (spawnObject == null || ourRenderer == null) return;

        float halfWidth = ourRenderer.bounds.size.x * 0.5f;

        float x1 = transform.position.x - halfWidth;
        float x2 = transform.position.x + halfWidth;

        Vector2 spawnPoint = new Vector2(
            Random.Range(x1, x2),
            transform.position.y
        );

        Instantiate(spawnObject, spawnPoint, Quaternion.identity);
    }
}