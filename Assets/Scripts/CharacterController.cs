using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Rigidbody2D rb;

    [SerializeField] bool move;

    [SerializeField] Collider2D charCol;

    [SerializeField] AudioSource squish;


    // Start is called before the first frame update
    void Start()
    {
        move = true;
        rb = this.GetComponent<Rigidbody2D>();
        charCol = this.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            move = false;
        }
        else
        {
            move = true;
        }

        if (charCol.gameObject.CompareTag("Ground")) //puts slime right side when touching the ground
        {
            transform.rotation = new Quaternion(0, 0, 0,0);
        }
        
    }

    private void FixedUpdate()
    {
        if (move)
        {
            Vector3 v = rb.velocity;
            v.x = 1.0f * moveSpeed * Time.fixedDeltaTime;
            rb.velocity = v;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Hazard") || col.gameObject.CompareTag("Projectile"))
        {
            Destroy(gameObject);
        }
        if (col.gameObject.CompareTag("Ground"))
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }

        squish.Play(); //play sound on collision with ground

    }
}
