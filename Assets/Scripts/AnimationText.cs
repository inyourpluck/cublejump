using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationText : MonoBehaviour
{
    public GameObject Lvltext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("VisibleText", 2.5f);
    }

    private void VisibleText()
    {
        Lvltext.SetActive(false);
    }
}
