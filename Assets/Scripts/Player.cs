using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Public properties
    public float speed;

    //Private attributes
    private byte _hits;

    //Methods
    private void Start()
    {
        _hits = 0;
    }

    private void Update()
    {
        //Player movement
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);

        //Game over
        if (_hits == 3) Time.timeScale = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        _hits++;

        if (_hits == 2) gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
}

