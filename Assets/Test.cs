using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // �������Ƒ������̒l�𑫂����l��Ԃ��֐�
    int Add(int a, int b)
    {
        // �������Ƒ������̒l�𑫂��āA�ϐ�c�ɑ������
        int c = a + b;
        // �ϐ�c���Ăяo�����̊֐��ɕԂ�
        return c;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Add�֐��Ɂu3�v�Ɓu6�v�̈�����n���A�Ԃ�l��num�ϐ��ɑ������
        int num = Add(3, 6);
        // num��\������
        Debug.Log(num);
    }

    // Update is called once per frame
    void Update()
    {

    }
}