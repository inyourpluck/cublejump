using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DontDestroyMusic : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
       
    }
    //музыка продолжает играть при переходе в другие сцены
    void Awake()
    {
        if (GameObject.FindGameObjectsWithTag("Sound").Length > 1)
        {
            Destroy(this.gameObject);
        }
            DontDestroyOnLoad(transform.gameObject);     
    }
    //включение и выключение музыки
    public void SoundOffOn(bool playMusic)
    {
        audioSource.GetComponent<AudioSource>().Play();
        if (playMusic)
        {
            audioSource.GetComponent<AudioSource>().mute = true;
            if (PlayerPrefs.HasKey("MusicOnOff"))
            {
                PlayerPrefs.DeleteKey("MusicOnOff");
            }
            PlayerPrefs.SetString("MusicOnOff", "No");
        }
        else
        {
            audioSource.GetComponent<AudioSource>().mute = false;
            if (PlayerPrefs.HasKey("MusicOnOff"))
            {
                PlayerPrefs.DeleteKey("MusicOnOff");
            }
            PlayerPrefs.SetString("MusicOnOff", "Yes");
        }
    }
}
