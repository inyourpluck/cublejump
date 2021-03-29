using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class FallingPlatform : MonoBehaviour
{
    Rigidbody rb;
    Collider col;

    void Start()
       {
           rb = GetComponent<Rigidbody>();
           col = GetComponent<Collider>();
    }

       void OnCollisionEnter(Collision collision)
       {
            if (collision.gameObject.name.Equals("Sphere"))
               {
                   gameObject.GetComponent<Renderer>().material.color = Color.red; 
                   Invoke("FallPlatform", 1f);
                   Destroy(gameObject, 2f);
               }
       }

       void FallPlatform()
       {
           rb.isKinematic = false;
       }

   }