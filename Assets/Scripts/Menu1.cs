using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu1 : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pp;
    public GameObject pse;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !GameIsPaused)
        {
            pse.SetActive(false);
            pp.SetActive(true);
            Time.timeScale = 0;
            GameIsPaused = true;
        } else if(Input.GetKeyDown(KeyCode.Escape) && GameIsPaused)
        {
                pse.SetActive(true);
                pp.SetActive(false); 
                Time.timeScale = 1;
                GameIsPaused = false;
            }
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Home()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void pauseOn()
    {
        pse.SetActive(false);
        pp.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
    }

    public void Resume()
    {
        pse.SetActive(true);
        pp.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
    }

    public void Levels()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void NextLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
