using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRay : MonoBehaviour
{
    void Update()
    {
        {
            Ray ray = new Ray(transform.position, -transform.up);
            Debug.DrawRay(transform.position, -transform.up*100, Color.yellow);
        }
    }
}
