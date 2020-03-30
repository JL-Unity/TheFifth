using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
//其实行为树自己就有seek了这个只是试着写写
public class MySeek : Action
{
    public float speed=0.5f;
    public SharedTransform target;
    public float Dist;
    public SharedInt health;
    public override void OnStart()
    {
        Dist = Vector3.Distance(target.Value.position, transform.position);
    }
    public override TaskStatus OnUpdate()
    {
        Dist = Vector3.Distance(target.Value.position, transform.position);
        if (target == null||target.Value==null)
            return TaskStatus.Failure;
        else
        { 
            transform.LookAt(target.Value.position);
            transform.position = Vector3.MoveTowards(transform.position, target.Value.position, Time.deltaTime * speed);
            if (Dist <= 3)
                { 
                health.Value -= 10;
                return TaskStatus.Success;
               
                }
               
            else
                return TaskStatus.Running;
        }
        
    }
}
