using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviengPlatformonZ : MonoBehaviour
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
        if(transform.position.z > pos.z + 4f)
        {
            moviengUp = false;
        }
        else if(transform.position.z < pos.z - 4f)
        {
            moviengUp = true;
        }

        if(moviengUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed * Time.deltaTime);
        }    
    }
}
