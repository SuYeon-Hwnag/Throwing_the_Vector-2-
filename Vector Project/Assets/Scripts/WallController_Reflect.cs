using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController_Reflect : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // Vector3.Reflect
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector2 Reflect(Vector2 a, Vector2 n)
    {
        Vector2 p = Mathf.Abs(Vector2.Dot(a, n)) / n.magnitude * n / n.magnitude; // abs 절댓값, dot 내적, magnitude 벡터 길이
        Vector2 b = a + 2 * p;
        return b;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Arrow"))
        {
            //Debug.Log("collision");
            //Rigidbody2D ArrowRB_Wall = collision.gameObject.GetComponent<Rigidbody2D>();
            //Vector2 move = collision.gameObject.GetComponent<ArrowController>().move;
            //ArrowRB_Wall.velocity = Reflect(move, -collision.GetContact(0).normal); // GetContact 충돌 접점의 정보, normal 법선

            //var speed = collision.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude;
            //var dir = Vector2.Reflect(collision.gameObject.GetComponent<Rigidbody2D>().velocity.normalized, collision.contacts[0].normal);

            //collision.gameObject.GetComponent<Rigidbody2D>().velocity = dir * Mathf.Max(speed, 0f);
            //Debug.Log("collision");

            collision.gameObject.GetComponent<ArrowController>().move = Quaternion.AngleAxis(180, collision.contacts[0].normal) * collision.gameObject.GetComponent<Transform>().forward * -1;
            Debug.Log("collision");
        }
    }

}
