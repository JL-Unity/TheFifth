using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class MyBoosDie : Action
{
    public override void OnStart()
    {
        gameObject.GetComponent<CreatBullet>().enabled = false;
    }
}

