using UnityEngine;

public class TripleShotPickup : MonoBehaviour
{
    [SerializeField] private float duration = 5f;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            col.GetComponent<ShootingScript>().ActivateTripleShot(duration);

            Destroy(gameObject);
        }
    }

}
