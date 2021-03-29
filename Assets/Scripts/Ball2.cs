using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2 : MonoBehaviour
{
    [SerializeField] KeyCode KeyThree;
    [SerializeField] KeyCode KeyFour;
    [SerializeField] Vector3 moveDirection;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyThree))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }
        if (Input.GetKey(KeyFour))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
    }
}
