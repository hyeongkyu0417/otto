using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsulemove : MonoBehaviour
{
    public float speed = 5.0f;                           //�̵��ӵ�
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))                       //getkey�� Ű�� ���������� �޾ƿ���
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))                       //getkey�� Ű�� ���������� �޾ƿ���
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))                       //getkey�� Ű�� ���������� �޾ƿ���
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))                       //getkey�� Ű�� ���������� �޾ƿ���
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
