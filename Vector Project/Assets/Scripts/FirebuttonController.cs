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
        if(isFireButton==true) // 버튼 눌렸을 때
        {
            FireTimer += Time.deltaTime;
            if (FireTimer >= 1.0f) // 0.1초 지났을 때
            {
                isFireButton = false; // 안눌린 판정으로 바꿈
                FireTimer = 0; // 타이머 리셋
            }
        }
    }
    public void OnClickFireButton()
    {
        isFireButton = true;
    }

}
