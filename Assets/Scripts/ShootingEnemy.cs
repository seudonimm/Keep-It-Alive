using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject projectile;

    [SerializeField] Transform projSpawn;

    [SerializeField] float shootTimer, shootTimerMax;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        shootTimer = shootTimerMax;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //shooting interval
        shootTimer--;
        if (shootTimer <= 0)
        {
            Instantiate(projectile, projSpawn.position, projectile.transform.rotation);
            shootTimer = shootTimerMax;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Projectile")) //destroy enemy on contact with projectile
        {
            Destroy(gameObject);
        }
    }
}
