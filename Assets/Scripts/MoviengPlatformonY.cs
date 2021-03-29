using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviengPlatformonY : MonoBehaviour
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
        if(transform.position.y > pos.y + 4f)
        {
            moviengUp = false;
        }
        else if(transform.position.y < pos.y - 8f)
        {
            moviengUp = true;
        }

        if(moviengUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
        }    
    }
}
