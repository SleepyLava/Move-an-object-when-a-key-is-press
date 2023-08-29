using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rigBody;
    [SerializeField] float speed;

    float speedZ, speedX;
    // Start is called before the first frame update
    void Start()
    {
        rigBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            speedZ = speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            speedZ = -speed;
        }
        else
        {
            speedZ = 0;
        }

        if (Input.GetKey(KeyCode.A))
        {
            speedX = -speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            speedX = speed;
        }
        else
        {
            speedX = 0;
        }
    }

    private void FixedUpdate()
    {
        rigBody.velocity = new Vector3(speedX, 0, speedZ);
    }
}
