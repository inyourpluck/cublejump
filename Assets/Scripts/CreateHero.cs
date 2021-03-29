using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateHero : MonoBehaviour
{
    public GameObject Pyramid;
    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("Skin") == "Pyramid")
        {
            DestroyImmediate(Cube, true);
            Pyramid.name = "Sphere";
        }
        else if (PlayerPrefs.GetString("Skin") == "Cube")
        {
            DestroyImmediate(Pyramid, true);
            Cube.name = "Sphere";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
