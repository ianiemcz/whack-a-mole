using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;

    GameObject hole1;
    GameObject hole2;
    GameObject hole3;
    GameObject hole4;
    GameObject hole5;
    GameObject hole6;
    GameObject hole7;
    GameObject hole8;
    GameObject hole9;

    // Start is called before the first frame update
    void Start()
    {
        // Not needed
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            MoveToHole1();
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            MoveToHole2();
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            MoveToHole3();
        }

        if (Input.GetKey(KeyCode.Alpha4))
        {
            MoveToHole4();
        }

        if (Input.GetKey(KeyCode.Alpha5))
        {
            MoveToHole5();
        }

        if (Input.GetKey(KeyCode.Alpha6))
        {
            MoveToHole6();
        }

        if (Input.GetKey(KeyCode.Alpha7))
        {
            MoveToHole7();
        }

        if (Input.GetKey(KeyCode.Alpha8))
        {
            MoveToHole8();
        }

        if (Input.GetKey(KeyCode.Alpha9))
        {
            MoveToHole9();
        }
    }
    
    private void MoveToHole1()
    {
        //transform.position(new Vector3(gameObject.transform.position));
    }

    private void MoveToHole2()
    {

    }

    private void MoveToHole3()
    {

    }

    private void MoveToHole4()
    {

    }

    private void MoveToHole5()
    {

    }

    private void MoveToHole6()
    {

    }

    private void MoveToHole7()
    {

    }

    private void MoveToHole8()
    {

    }

    private void MoveToHole9()
    {

    }
}