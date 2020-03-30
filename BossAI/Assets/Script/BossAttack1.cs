using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
//其实行为树自己就有seek了这个只是试着写写
public class BossAttack1 : Action
{
    public float speed = 0.5f;
    public SharedTransform target;
    public SharedGameObject bullet;
    public SharedInt health;
    public float Dist;
    public override void OnStart()
    {
        gameObject.GetComponent<CreatBullet>().enabled = true;
    }

}
