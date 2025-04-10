using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 5f;    // ȸ�� �ӵ�

    private float yaw = 0f;             // ���� ȸ��
    private float pitch = 0f;           // ���� ȸ��

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");                        //���콺�� ���� ���� �Է� �޾ƿ�
        float mouseY = Input.GetAxis("Mouse Y");                        //���콺�� ���� ���� �Է� �޾ƿ�

        yaw += mouseX * rotationSpeed * Time.deltaTime;                 // ���� ȸ��

        pitch -= mouseY * rotationSpeed * Time.deltaTime;               // ���� ȸ��, -�� ���� ����

        pitch = Mathf.Clamp(pitch, -90f, 90f);                          // pitch�� 90�� �̻�, -90�� ���Ϸ� ȸ������ �ʵ��� ����

        transform.rotation = Quaternion.Euler(pitch, yaw, 0f);
    }
}
