using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountAllStars : MonoBehaviour
{
    public Text countStar;
    // Start is called before the first frame update
    void Start()
    {
        countStar.text = PlayerPrefs.GetInt("CountAllStar").ToString();
    }

}
