using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public GameObject audioSource;
    public GameObject image;
    public Sprite sprite1;
    public Sprite sprite2;
    private bool playMusic;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("MusicOnOff"))
        {
            PlayerPrefs.GetString("MusicOnOff");
            if (PlayerPrefs.GetString("MusicOnOff") == "Yes")
            {
                audioSource.GetComponent<AudioSource>().Play();
                playMusic = true;
            }
            else
            {
                playMusic = false;
            }
        }
        else playMusic = true;
        //print(playMusic);
        if (playMusic)
        {
            image.GetComponent<Image>().sprite = sprite1;
        }
        else
        {
            image.GetComponent<Image>().sprite = sprite2;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    //включение и выключение музыки и смена спрайта
    public void SoundOnOff()
    {
        if (playMusic)
        {
            GameObject.FindGameObjectWithTag("Sound").GetComponent<DontDestroyMusic>().SoundOffOn(playMusic);
            image.GetComponent<Image>().sprite = sprite2;
            playMusic = false;
        }
        else
        {
            GameObject.FindGameObjectWithTag("Sound").GetComponent<DontDestroyMusic>().SoundOffOn(playMusic);
            image.GetComponent<Image>().sprite = sprite1;
            playMusic = true;
        }
    }
}
