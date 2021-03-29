using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ShopLogic : MonoBehaviour
{
    public GameObject OnOff;
    public GameObject _ShopMenu, _Menu;
    public Text countstar;
    public Text pricePyramid;
    public Text priceCube;
    public GameObject NotEnoughMoney, starPyramid, textPyramid, starCube, textCube;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetString("Skin") == "Pyramid")
        {
            OnOff.GetComponent<RectTransform>().localPosition = new Vector3(-70, 170, 0);
        }
        else if(PlayerPrefs.GetString("Skin") == "Cube")
        {
            OnOff.GetComponent<RectTransform>().localPosition = new Vector3(-310, 170, 0);
        }
        if(PlayerPrefs.GetInt("BuyingPyramid") == 1)
        {
            starPyramid.SetActive(false);
            textPyramid.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BuyingCube") == 1)
        {
            starCube.SetActive(false);
            textCube.SetActive(false);
        }
    }

    public void Pyramid()
    {
        if(starPyramid.activeSelf)
        {
            if (Convert.ToInt32(countstar.text) - Convert.ToInt32(pricePyramid.text) < 0)
            {
                NotEnoughMoney.SetActive(true);
                NotEnoughMoney.GetComponent<Animation>().Play("Close");
            }
            else
            {
                PlayerPrefs.SetInt("CountAllStar", PlayerPrefs.GetInt("CountAllStar") - Convert.ToInt32(pricePyramid.text));
                countstar.text = PlayerPrefs.GetInt("CountAllStar").ToString();
                starPyramid.SetActive(false);
                textPyramid.SetActive(false);
                PlayerPrefs.SetString("Skin", "Pyramid");
                OnOff.GetComponent<RectTransform>().localPosition = new Vector3(-70, 170, 0);
                PlayerPrefs.SetInt("BuyingPyramid", 1);
            }
        }
        else
        {
            OnOff.GetComponent<RectTransform>().localPosition = new Vector3(-70, 170, 0);
            PlayerPrefs.SetString("Skin", "Pyramid");
        }
    }

    public void Cube()
    {
        if (starCube.activeSelf)
        {
            if (Convert.ToInt32(countstar.text) - Convert.ToInt32(priceCube.text) < 0)
            {
                NotEnoughMoney.SetActive(true);
                NotEnoughMoney.GetComponent<Animation>().Play("Close");
            }
            else
            {
                PlayerPrefs.SetInt("CountAllStar", PlayerPrefs.GetInt("CountAllStar") - Convert.ToInt32(priceCube.text));
                countstar.text = PlayerPrefs.GetInt("CountAllStar").ToString();
                starCube.SetActive(false);
                textCube.SetActive(false);
                PlayerPrefs.SetString("Skin", "Cube");
                OnOff.GetComponent<RectTransform>().localPosition = new Vector3(-310, 170, 0);
                PlayerPrefs.SetInt("BuyingCube", 1);
            }
        }
        else
        {
            OnOff.GetComponent<RectTransform>().localPosition = new Vector3(-310, 170, 0);
            PlayerPrefs.SetString("Skin", "Cube");
        }
    }

    public void Back()
    {
        _ShopMenu.SetActive(false);
        _Menu.SetActive(true);
    }

}
