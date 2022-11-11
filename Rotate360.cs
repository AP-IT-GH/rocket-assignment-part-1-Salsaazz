using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate360 : MonoBehaviour
{
    public int speed;
    void Start()
    {
        speed = 180;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
