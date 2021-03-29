using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StarsLevelMenu : MonoBehaviour
{
    //public Button lvl;
    private Image[] star; //������ ���������
    public string keyName1; //����� ������
    public string keyName2; //����� ������
    public int count; //���������� �����
    // Start is called before the first frame update

    private void Awake()
    {
        star = GetComponentsInChildren<Image>();
    }

    void Start()
    {
        count = 0;
        for(int i = 1; i<4; i++)
        {
            //PlayerPrefs.DeleteKey(keyName1 + keyName2 + i.ToString()); //������� ��������� ������, ��� �����
            if (PlayerPrefs.GetString(keyName1 + keyName2 + i.ToString()) == "True")//��������� ���������� ������������ �� ��������
                count++;
        }
        PlayerPrefs.SetInt("countStar" + keyName1, count);
        if (count == 1)
        {
            star[1].color = new Color(238, 255, 0, 256);
        }
        else if (count == 2)
        {
            star[1].color = new Color(238, 255, 0, 256);
            star[2].color = new Color(238, 255, 0, 256);
        }
        else if (count == 3)
        {
            star[1].color = new Color(238, 255, 0, 256);
            star[2].color = new Color(238, 255, 0, 256);
            star[3].color = new Color(238, 255, 0, 256);
        }
    }

    void Update()
    {
       
    }

}
