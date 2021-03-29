using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelFinish : MonoBehaviour
{
    private OnCollisionStar count;
    public GameObject fp;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject pauseButton;

    public string keyName1;

    void Start()
    {
        count = GetComponent<OnCollisionStar>();
    }

    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.gameObject.name.Equals("Sphere"))
            {
                Time.timeScale = 0;
                fp.SetActive(true);
                pauseButton.SetActive(false);
                GetComponent<AudioSource>().Play();
                //countStars.text = PlayerPrefs.GetInt("countStar" + keyName1).ToString();
                if (PlayerPrefs.GetInt("countStar" + keyName1) == 1)
                {
                    star1.SetActive(true);
                }
                else if (PlayerPrefs.GetInt("countStar" + keyName1) == 2)
                {
                    star1.SetActive(true);
                    star2.SetActive(true);
                }
                else if (PlayerPrefs.GetInt("countStar" + keyName1) == 3)
                {
                    star1.SetActive(true);
                    star2.SetActive(true);
                    star3.SetActive(true);
                }
            }
        }
    }
}
