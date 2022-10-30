using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class RocketControl : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float speed = 5f;
    public float rotateSpeed = 100f;
    float rotation;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
    }
    //meerdere malen oproepen per frame
    private void FixedUpdate()
    {
        moveCharacter();
    }
    void moveCharacter()
    {
        if (Input.GetKey(KeyCode.Space))
            rb.AddForce(Vector3.up * speed);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * speed);
            Rotation('R');
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * speed);
            Rotation('L');
        }


    }
    void Rotation(char Rotation)
    {
        switch (Rotation)
        {
            case 'L':
                GetComponent<Rigidbody>().freezeRotation = true;
                transform.Rotate(Vector3.forward * Time.deltaTime * rotateSpeed);
                GetComponent<Rigidbody>().freezeRotation = false;
                break;

            case 'R':
                GetComponent<Rigidbody>().freezeRotation = true;
                transform.Rotate(-Vector3.forward * Time.deltaTime * rotateSpeed);
                GetComponent<Rigidbody>().freezeRotation = false;
                break;
        }
    }
}
