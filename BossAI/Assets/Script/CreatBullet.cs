using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime;
using UnityEngine;
//单例模式创造子弹
public class CreatBullet : MonoBehaviour
{
    public static CreatBullet instance;
    public GameObject player;
    public GameObject Boss;
    public static CreatBullet  Instance()
    {
        if(instance==null )
        {
            instance = new CreatBullet();
        }
        return instance;
    }
    public Transform firePoint;
    public GameObject bulletPrefab;
    public void CreateBullet()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
            CreateBullet();
        if (Input.GetKey(KeyCode.A))
            CreateBullet();
        if (Input.GetKey(KeyCode.S))
            CreateBullet();
        if (Input.GetKey(KeyCode.D))
            CreateBullet();
        if (Vector3.Distance(player.transform.position,Boss.transform.position)<=5)
            CreateBullet();
    }
}

