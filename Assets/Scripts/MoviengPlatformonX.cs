using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviengPlatformonX : MonoBehaviour
{
    float speed = 6f;
    bool moviengUp = true;
    Vector3 pos;
    private void Start()
    {
        pos = transform.position;
    }
    void Update()
    {
        if(transform.position.x > pos.x + 4f)
        {
            moviengUp = false;
        }
        else if(transform.position.x < pos.x - 4f)
        {
            moviengUp = true;
        }

        if(moviengUp)
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
        }    
    }
}
