using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDown : MonoBehaviour
{
    public GameObject redButton;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Equals("Sphere"))
        {
            GetComponent<Animation>().Play("ButtonDown");
            GetComponent<BoxCollider>().enabled = false;
        }
    }


}
