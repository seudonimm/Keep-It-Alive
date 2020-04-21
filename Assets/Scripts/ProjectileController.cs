using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] bool goingRight;
    [SerializeField] float speed;
    
    // Start is called before the first frame update
    void Start()
    {

        rb = this.GetComponent<Rigidbody2D>();

        rb.velocity = Vector2.left * speed;
        goingRight = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("ObjectStationary"))
        {
            if (goingRight)
            {
                goingRight = false;
                rb.velocity = Vector2.left * speed;
            }
            else if (!goingRight)
            {
                goingRight = true;
                rb.velocity = Vector2.right * speed;
            }
        }

        if (col.gameObject.CompareTag("Ground") || col.gameObject.CompareTag("Door"))
        {
            Destroy(gameObject);
        }

    }
}
