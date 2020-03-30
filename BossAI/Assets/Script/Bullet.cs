using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int flag = 0;
    public float speed = 10f;
    public Rigidbody rb;
    void Awake()
    {
            rb = gameObject.GetComponent<Rigidbody>();
            rb.velocity = transform.TransformDirection(Vector3.forward * speed);
    }
}
