using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class VasicVariables : MonoBehaviour
{
    public int gold = 0;                     //������
    public float Hp = 100.0f;                //�Ǽ��� (�Ҽ����� �ִ� ����, ���� 'f'�ʼ�)
    public string playerName = "ȫ�浿";     //���ڿ� (������ ����)
    private bool isAlive = true;             //���� ( ��/������ ��Ÿ��) true/false


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("���� ����");         //����Ƽ ����׿� �޼����� ���

        if(gold > 50)                                      //���� gold�� 50���� ũ�ٸ�
        {
            Debug.Log("�������� ������ �� �ֽ��ϴ�.");     //�޼��� ���
        }
        else if(gold > 25)                                //gold�� 50���� ������ 25���� Ŭ��
        {
            Debug.Log("�Ϻ� �������� ������ �� �ֽ��ϴ�.");   //�޼��� ���
        }
        else                                               //�� ������ ���� �ƴ� ���
        {
            Debug.Log("���� �����մϴ�.");         //�޼��� ���
        }
    }


    // Update is called once per frame
    void Update()
    {
        //Debug.Log("���� ������");

        if (Input.GetKeyDown(KeyCode.Space))         //Ű������ �����̽��� ������ �� true ��ȯ
        {
            gold = gold + 10;                        //��带 10 ������Ų��.
            Debug.Log("���� ��� : " + gold);        //���� ��带 ���
        }
    }
}
