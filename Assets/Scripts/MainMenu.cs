using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject _ShopMenu, _Menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Levels()
    {
        SceneManager.LoadScene(1);
    }
    public void Shop()
    {
        _ShopMenu.SetActive(true);
        _Menu.SetActive(false);
    }

    public void Cancel()
    {
        Application.Quit();
    }


}
