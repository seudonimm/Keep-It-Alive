﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//used to destroy contructs
public class ObjectsController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col) 
    {

        if (col.gameObject.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
        }
    }

}
