using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject FireButton;
    GameObject HOLE;
    Rigidbody2D arrow_rigidbody2d;
    public Vector2 move;

    public float angle = 0.0f;
    public float force = 0.0f;
    public float angleTimer = 0.0f;

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
            if (angleTimer >= 0.1f) // 0.1�� ������ ��
            {
                angle = 0.0f;
                force = 0.0f;
                angleTimer = 0; // Ÿ�̸� ����
            }
        }
    }

    public void anglechange()
    {
        // ���� ��ȯ
        angle = Mathf.Atan2(GameObject.Find("GameDirector").GetComponent<GameDirector>().ingredient_a_y, GameObject.Find("GameDirector").GetComponent<GameDirector>().ingredient_a_x) * Mathf.Rad2Deg; // ���� ���ϱ�
        transform.rotation = Quaternion.Euler(0, 0, angle); // angle��ŭ ��ü ȸ��

        // ���п� ����Ͽ� ȭ��ǥ �߻�
        Vector2 forforce = new Vector2(GameObject.Find("GameDirector").GetComponent<GameDirector>().ingredient_a_x, GameObject.Find("GameDirector").GetComponent<GameDirector>().ingredient_a_y); // ���ͷ� ����
        force = forforce.magnitude; // ���� ���� ��Ʈ�� ��� �̰��� ���̴�.
        Vector2 move = new Vector2(GameObject.Find("GameDirector").GetComponent<GameDirector>().ingredient_a_x, GameObject.Find("GameDirector").GetComponent<GameDirector>().ingredient_a_y) * force * 10.0f; // ���⺤�Ϳ� ���� ���ϰ�
        arrow_rigidbody2d.velocity = move; // rigidbody�� �ӷ¸� �ٿ��� �̵�(Ÿ ���� ����X)
    }

}