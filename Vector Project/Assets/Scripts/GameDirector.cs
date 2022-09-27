using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI ���

public class GameDirector : MonoBehaviour
{
    GameObject scoreint;
    GameObject HOLE;
    GameObject Arrow;
    public int socre = 0;

    GameObject VectorA;
    GameObject VectorB;
    public int ingredient_a_x=1, ingredient_a_y=1, ingredient_b_x=-1, ingredient_b_y=1;

    // Start is called before the first frame update
    void Start()
    {
        // GameObject ã��
        this.scoreint = GameObject.Find("scoreint");
        this.HOLE = GameObject.Find("HOLE");
        this.Arrow = GameObject.Find("Arrow");

        this.VectorA = GameObject.Find("VectorA");
        this.VectorB = GameObject.Find("VectorB");

    }

    // Update is called once per frame
    void Update()
    {
        this.scoreint.GetComponent<Text>().text = socre.ToString("F0") + "��"; // score�� ��Ÿ��
        this.VectorA.GetComponent<Text>().text = "(" + ingredient_a_x.ToString("F0") + "," + ingredient_a_y.ToString("F0") + ")"; // VectorA ������ ��Ÿ��
        this.VectorB.GetComponent<Text>().text = "(" + ingredient_a_x.ToString("F0") + "," + ingredient_a_y.ToString("F0") + ")"; // VectorB ������ ��Ÿ��
    }

}
