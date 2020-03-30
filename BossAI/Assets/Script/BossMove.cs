using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
public class BossMove : Action
{
    public SharedGameObject[] wayPoints;
    public int NowPoint=0;
    public float speed = 10f;
    private void Now()
    {
        NowPoint++;
    }
    public override TaskStatus OnUpdate()
    {
        if(NowPoint>=wayPoints.Length)
        {
            NowPoint %= wayPoints.Length;
        }
        Transform Target = wayPoints[NowPoint].Value.transform;
        transform.LookAt(Target);//朝向目标位置
        transform.position = Vector3.MoveTowards(transform.position, Target.position, speed * Time.deltaTime);//移动至目标位置
        if (transform.position == Target.position)
            Now();
        return TaskStatus.Running;
    }
}
