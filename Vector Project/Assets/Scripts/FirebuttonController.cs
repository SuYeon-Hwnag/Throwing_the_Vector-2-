using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirebuttonController : MonoBehaviour
{
    GameObject FireButton;
    public bool isFireButton = false;
    float FireTimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.FireButton = GameObject.Find("FireButton");
    }

    // Update is called once per frame
    void Update()
    {
        if(isFireButton==true) // ��ư ������ ��
        {
            FireTimer += Time.deltaTime;
            if (FireTimer >= 1.0f) // 0.1�� ������ ��
            {
                isFireButton = false; // �ȴ��� �������� �ٲ�
                FireTimer = 0; // Ÿ�̸� ����
            }
        }
    }
    public void OnClickFireButton()
    {
        isFireButton = true;
    }

}
