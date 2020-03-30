using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
//设置一个角度小于45°以内距离小于10的查找视角
public class MySearch : Conditional
{
    public Transform[] Targets;
    public float agl;
    public float dis;
    public float MaxDis;
    public SharedTransform target;

    public override TaskStatus OnUpdate()
    {
        if (target == null)
        {
            return TaskStatus.Failure;
        }
            
        foreach (var TheTarget in Targets)
        {
            float distance = Vector3.Distance(transform.position, TheTarget.position);
            float angle = Vector3.Angle(transform.forward, TheTarget.position - transform.position);
            if (distance < dis && angle < 0.5f * agl&&distance<MaxDis)
            {
                this.target.Value = TheTarget;
                return TaskStatus.Success;
            }
        }
        return TaskStatus.Failure;
    }
}

