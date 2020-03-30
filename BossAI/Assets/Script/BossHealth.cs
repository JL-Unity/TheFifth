using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
//health变量在行为树中判断boss是否死亡
public class BossHealth : Conditional
{
    public SharedInt  health = 5000;
    public GameObject deathEffect;
    // Start is called before the first frame update
    public override TaskStatus OnUpdate()
    {
        
        if (health.Value <= 0)
            return TaskStatus.Success;//死亡
        if (health.Value >= 0)
            return TaskStatus.Failure;
        else return TaskStatus.Running;
    }
    
}
