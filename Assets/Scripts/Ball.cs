using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] KeyCode KeyOne;
    [SerializeField] KeyCode KeyTwo;
    [SerializeField] Vector3 moveDirection;

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyOne))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }
        if (Input.GetKey(KeyTwo))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
    }


}
