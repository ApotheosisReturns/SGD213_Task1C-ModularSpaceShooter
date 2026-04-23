using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject bulletPrefab;

    private bool tripleShotActive = false;

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (tripleShotActive)
                FireTripleShot();
            else
                FireSingleShot();
        }
    }

    private void FireSingleShot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    private void FireTripleShot()
    {
        StartCoroutine(TripleVolley());
    }

    private IEnumerator TripleVolley()
    {
        // Bullet 1
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Small delay
        yield return new WaitForSeconds(0.05f);

        // Bullet 2
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Small delay
        yield return new WaitForSeconds(0.05f);

        // Bullet 3
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }


    public void ActivateTripleShot(float duration)
    {
        StartCoroutine(TripleShotRoutine(duration));
    }

    private IEnumerator TripleShotRoutine(float duration)
    {
        tripleShotActive = true;
        yield return new WaitForSeconds(duration);
        tripleShotActive = false;
    }
}
