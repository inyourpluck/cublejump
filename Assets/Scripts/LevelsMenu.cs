using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelsMenu : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void level1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
    public void level2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }
    public void level3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
    }

    public void Back()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
