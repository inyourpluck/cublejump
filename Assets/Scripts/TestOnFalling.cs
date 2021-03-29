using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOnFalling : MonoBehaviour
{
    public GameObject b,c;
    public Transform coordFall;
    public CharacterMechanics script2;
    public GameObject pp2, pse2,jstk;//панели паузы и джостик

    void Start()
    {
        script2 = c.GetComponent<CharacterMechanics>();
        coordFall = b.GetComponent<Transform>();
    }
 
    void Update()
    {
        //if(script2.coordin.y - coordFall.position.y > 5)
        if(coordFall.position.y < 0)
        {
            //Time.timeScale = 0;
            pp2.SetActive(true);
            pse2.SetActive(false);
            jstk.SetActive(false);
            script2.coordin.y = 0;
            GetComponent<AudioSource>().Stop();
        }
    }
}