using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Start is called before the first frame update
    private Rigidbody m1;
    private Transform m2;
    public float speed = 0.1f;
    void Start()
    {
        m1 = gameObject.GetComponent<Rigidbody>();
        m2 = gameObject.GetComponent<Transform>();//括号不要忘了
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            m1.MovePosition(m2.position + Vector3.forward * speed);
        if (Input.GetKey(KeyCode.A))
            m1.MovePosition(m2.position + Vector3.left * speed);
        if (Input.GetKey(KeyCode.S))
            m1.MovePosition(m2.position + Vector3.back * speed);
        if (Input.GetKey(KeyCode.D))
            m1.MovePosition(m2.position + Vector3.right * speed);
       
    }
}
