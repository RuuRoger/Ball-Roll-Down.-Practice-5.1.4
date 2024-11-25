using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Public properties
    public float speed;

    //Private attributes
    private byte _hits;
    private byte _playerPoints;

    //Methods
    private void Start()
    {
        _hits = 0;
        _playerPoints = 0;
    }

    private void Update()
    {
        //Player movement
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);

        //Game over
        if (_hits == 3) 
        {
            Time.timeScale = 0;
            print("Has perdido.");
        }
        

        //"UI" Points
        print("Puntos :" + _playerPoints);
    }

    private void OnCollisionEnter(Collision collision)
    {
        _hits++;

        if (_hits == 2) gameObject.GetComponent<Renderer>().material.color = Color.red;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Yellow") _playerPoints++;
        if (other.tag == "Green") _playerPoints += 2;
        if (other.tag == "Blue") _playerPoints += 3;
        
        if (other.tag == "Finish")
        {
            print("¡Victoria!");
            Time.timeScale = 0;
        }
    }
}

