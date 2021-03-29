using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMusic : MonoBehaviour
{
    public AudioClip gameoverMusic;
    public GameObject textFlag;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (textFlag.activeSelf)
        {
            if (!gameObject.GetComponent<AudioSource>().isPlaying && count == 0)
            {
                gameObject.GetComponent<AudioSource>().PlayOneShot(gameoverMusic);
                count++;
            }
        }
    }

}
