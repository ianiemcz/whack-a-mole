using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveForward();
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            MoveBackwards();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft();
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            MoveUp();
        }
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void MoveBackwards()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
    private void MoveLeft()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    private void MoveRight()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    private void MoveUp()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

}
