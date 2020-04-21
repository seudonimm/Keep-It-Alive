using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSpike : MonoBehaviour
{
    //[SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject spike;

    void Start()
    {
        //rb = this.GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        //if (col.gameObject.CompareTag("Object"))
        //{
        //    Destroy(gameObject);
        //}
        //if (activateBox.gameObject.CompareTag("Player"))
        //{
        //    Debug.Log("fallsad");
        //    rb.gravityScale = 1;
        //}

    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("fall");
            spike.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
}
