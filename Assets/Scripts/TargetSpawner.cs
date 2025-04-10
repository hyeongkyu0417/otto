using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject panelPretab;             //���� ������(������Ʈ)

    public float generateTime = 3f;            //����� �ð� 

    private float timer = 0;                   //����� �ð� ����� ����
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;                //timer �������� deltaTimde�� ���� ���� �ð� ����

        if(timer <= 0)                          //timer�� 0���� �۰ų� ���� ��
        {
            timer = generateTime;               //timer�� ����� �ð��� �Է���

            float xPostiton = Random.Range(-101, 101);   //-10-10 ������ ������ �Ǽ����� zPsition�� ����
            Vector3 newPos = new Vector3(xPostiton, 0, 0);   // ������ ���Ӱ� ���� Position ��
            Instantiate(panelPretab, newPos, Quaternion. identity);  //���� �������� newPos ��ġ�� ������
        }

    }
}
