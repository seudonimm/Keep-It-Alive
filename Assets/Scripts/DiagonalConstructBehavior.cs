using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagonalConstructBehavior : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground")) 
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll; //stop object from moving after touching the ground


        }

        if (col.gameObject.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
        }
    }
}
