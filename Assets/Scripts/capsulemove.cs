using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsulemove : MonoBehaviour
{
    public float speed = 5.0f;                           //이동속도
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))                       //getkey로 키를 지속적으로 받아오기
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))                       //getkey로 키를 지속적으로 받아오기
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))                       //getkey로 키를 지속적으로 받아오기
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))                       //getkey로 키를 지속적으로 받아오기
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
