using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckOnPrefab : MonoBehaviour
{
    public GameObject backGroundmusic;
    private bool musicFind;

    void Start()
    {
        musicFind = GameObject.Find(backGroundmusic.name);
    }

    void Update()
    {

    }

    void Awake()
    {
        if (musicFind == false)
        {
            backGroundmusic = Instantiate(backGroundmusic);
        }
        print("musicFind");
        //DontDestroyOnLoad(transform.gameObject);
    }
}