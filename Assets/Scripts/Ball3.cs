using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball3 : MonoBehaviour
{
    [SerializeField] KeyCode KeyFive;
    [SerializeField] Vector3 moveDirection;
    bool is_ground = false;
    Rigidbody Ball;

    void Start()
    {
        Ball = GetComponent<Rigidbody>(); //при старте сцены, получаем компонент и сохран€ем в переменную
    }

    void OnTriggerStay(Collider col)
    {                                                    //если в тригере что то есть и у обьекта тег "ground"
        if (col.tag == "ground") is_ground = true;      //то включаем переменную "на земле"
    }

    void OnTriggerExit(Collider col)
    {                                                   //если из триггера что то вышло и у обьекта тег "ground"
        if (col.tag == "ground") is_ground = false;     //то вџключаем переменную "на земле"
    }


    private void FixedUpdate()

    {
        if ((Input.GetKey(KeyFive)) && (is_ground))
        {
            Ball.AddForce(moveDirection * Ball.mass, ForceMode.Impulse);
        }
    }
}