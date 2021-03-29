using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarTakeMusic : MonoBehaviour
{
    //private GameObject star;
    public AudioClip clip;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.tag == "Star")
                GetComponent<AudioSource>().PlayOneShot(clip, 0.5f);
        }
    }
}
