using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Public properties
    public float speed;

    private void Update()
    {
        //Player movement
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);

        print("Velocidad :" + speed);

    }

    public void MoreSpeed() => speed *= 3; 

}
