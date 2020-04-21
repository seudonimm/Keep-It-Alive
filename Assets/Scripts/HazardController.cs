using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    //[SerializeField] Collider2D activateBox;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionEnter2D(Collision2D col)
    //{
    //    if (col.gameObject.CompareTag("Object"))
    //    {
    //        Destroy(gameObject);
    //    }
        //if (activateBox.gameObject.CompareTag("Player"))
        //{
        //    Debug.Log("fallsad");
        //    rb.gravityScale = 1;
        //}

    //}

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
        
    //    if (activateBox.gameObject.CompareTag("Player"))
    //    {
    //        Debug.Log("fall");
    //        rb.gravityScale = 1;
    //    }
    //}
}
