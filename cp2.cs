using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cp2 : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update

    public GameObject RightXbase;
    public GameObject LeftXbase;

    public GameObject ZPylonL;
    public GameObject ZPylonR;

    public GameObject cpL;
    public GameObject cpR;

    void Start()
    {


    }


    // Update is called once per frame
    void Update()
    {
        var speed = 30;

        // Move the Y-Base
        if (Input.GetKey(KeyCode.Q))
            transform.Translate(Vector3.up * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.down * Time.deltaTime);

        // Move the X-beam
        if (Input.GetKey(KeyCode.E))
        {
            LeftXbase.transform.Translate(Vector3.up * Time.deltaTime);
            RightXbase.transform.Translate(Vector3.up * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.R))
        {
            RightXbase.transform.Translate(Vector3.down * Time.deltaTime);
            LeftXbase.transform.Translate(Vector3.down * Time.deltaTime);
        }

        // Move the ZPylon
        if (Input.GetKey(KeyCode.T))
        {
            ZPylonL.transform.Translate(Vector3.left * Time.deltaTime);
            ZPylonR.transform.Translate(Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Y))
        {
            ZPylonL.transform.Translate(Vector3.right * Time.deltaTime);
            ZPylonR.transform.Translate(Vector3.left * Time.deltaTime);
        }
        // Rotate the chopstick
        if (Input.GetKey(KeyCode.U))
            cpL.transform.Rotate(Vector3.up * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.I))
            cpR.transform.Rotate(Vector3.left * speed * Time.deltaTime);


    }

    void pre_planned_traj()
    {
        // Move x-beam

        // Move z-pylon

        // Move x-beam
    }
}
