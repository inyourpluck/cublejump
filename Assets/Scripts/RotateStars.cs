using UnityEngine;

public class RotateStars : MonoBehaviour
{
    public float speed = 5f;

    private Transform _rotator;

    private void Start()
    {
        _rotator = GetComponent<Transform>();
    }

    private void Update()
    {

        _rotator.Rotate(0 , 0, speed * Time.deltaTime);
    }

}
