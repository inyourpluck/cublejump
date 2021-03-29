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
        Ball = GetComponent<Rigidbody>(); //��� ������ �����, �������� ��������� � ��������� � ����������
    }

    void OnTriggerStay(Collider col)
    {                                                    //���� � ������� ��� �� ���� � � ������� ��� "ground"
        if (col.tag == "ground") is_ground = true;      //�� �������� ���������� "�� �����"
    }

    void OnTriggerExit(Collider col)
    {                                                   //���� �� �������� ��� �� ����� � � ������� ��� "ground"
        if (col.tag == "ground") is_ground = false;     //�� ��������� ���������� "�� �����"
    }


    private void FixedUpdate()

    {
        if ((Input.GetKey(KeyFive)) && (is_ground))
        {
            Ball.AddForce(moveDirection * Ball.mass, ForceMode.Impulse);
        }
    }
}