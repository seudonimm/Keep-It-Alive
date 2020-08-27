using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSpike : MonoBehaviour
{
    //[SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject spike;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D col)
    {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("Player")) //drops spike when player enters it trigger
        {
            Debug.Log("fall");
            spike.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
}
