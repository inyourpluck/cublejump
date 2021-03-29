using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnCollisionStar : MonoBehaviour
{
    public Text score;
    Collider col;
    public string keyName1; //номер уровня
    public string keyName2; //номер звезды
    public GameObject starVFX;

    void Start()
    {
        //PlayerPrefs.DeleteKey("countStar" + keyName1);
        //PlayerPrefs.DeleteKey("CountAllStar");
        col = GetComponent<Collider>();
        if(PlayerPrefs.GetString(keyName1 + keyName2) == "True")
        {
            score.text = PlayerPrefs.GetInt("countStar" + keyName1).ToString();
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.gameObject.name.Equals("Sphere"))
            {
                //score.text = cc.count.ToString();
                PlayerPrefs.SetString(keyName1 + keyName2, "True");
                PlayerPrefs.SetInt("countStar" + keyName1, PlayerPrefs.GetInt("countStar" + keyName1) + 1);
                PlayerPrefs.SetInt("CountAllStar", PlayerPrefs.GetInt("CountAllStar") +1);
                score.text = PlayerPrefs.GetInt("countStar" + keyName1).ToString();
                Destroy(this.gameObject);
                Instantiate(starVFX, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z), Quaternion.identity);  
            }
        }
    }
}
