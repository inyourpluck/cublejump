using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController1 : MonoBehaviour
{

    [SerializeField] private Transform playerTransform;
    [SerializeField] private string playerTag;
    [SerializeField] private float movingSpeed;

    private void Awake()
    {
        if(this.playerTransform == null)
        {
            if(this.playerTag == "")
            {
                this.playerTag = "Player";
            }
            this.playerTransform = GameObject.FindGameObjectWithTag(this.playerTag).transform;

        }

        this.playerTransform.position = new Vector3()
        {
            x = this.playerTransform.position.x,
            y = this.playerTransform.position.y,
            z = this.playerTransform.position.z,
        };
    }


    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {

        if (this.playerTransform)
        {
            Vector3 target = new Vector3()
            {
                x = this.playerTransform.position.x + 18,
                y = this.playerTransform.position.y + 27,
                z = this.playerTransform.position.z - 27,
            };

            Vector3 pos = Vector3.Lerp(this.transform.position, target, this.movingSpeed * Time.deltaTime);

            this.transform.position = pos;
        }
    }

}
