using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject FireButton;
    GameObject HOLE;
    Rigidbody2D arrow_rigidbody2d;

    public float angle = 0.0f;
    public float force = 0.0f;
    float angleTimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.FireButton = GameObject.Find("FireButton");
        this.HOLE = GameObject.Find("HOLE");

        this.arrow_rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("GameDirector").GetComponent<FirebuttonController>().isFireButton)
        {
            anglechange();
            Debug.Log(angle);
            Debug.Log(force);

            angleTimer += Time.deltaTime;
            if (angleTimer >= 0.1f) // 0.1초 지났을 때
            {
                angle = 0.0f;
                force = 0.0f;
                angleTimer = 0; // 타이머 리셋
            }
        }
    }

    public void anglechange()
    {
        // 방향 전환
        angle = Mathf.Atan2(GameObject.Find("GameDirector").GetComponent<GameDirector>().ingredient_a_y, GameObject.Find("GameDirector").GetComponent<GameDirector>().ingredient_a_x) * Mathf.Rad2Deg; // 각도 구하기
        transform.rotation = Quaternion.Euler(0, 0, angle); // angle만큼 객체 회전

        // 성분에 비례하여 화살표 발사
        force = Mathf.Sqrt((GameObject.Find("GameDirector").GetComponent<GameDirector>().ingredient_a_y) ^ 2 + (GameObject.Find("GameDirector").GetComponent<GameDirector>().ingredient_a_x) ^ 2);
        this.arrow_rigidbody2d.AddForce(transform.forward * force);
    }
}