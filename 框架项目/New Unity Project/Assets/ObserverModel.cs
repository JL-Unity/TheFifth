using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverMode : MonoBehaviour
{
    private void Start()
    {

        ConcreteSubjectA subjectA = new ConcreteSubjectA();

        IObserver observerA = new ConcreteObserverA(subjectA);
        IObserver observerB = new ConcreteObserverB(subjectA);
        subjectA.AddObserber(observerA);
        subjectA.AddObserber(observerB);

        //改变subjectA的状态
        subjectA.State = "状态A";
    }
}
#region 被观察者
/// <summary>
/// 被观察者抽象类
/// </summary>
public abstract class ISubject //被观察者抽象类
{
    /// <summary>
    /// 所有观察这个被观察者的   观察者集合
    /// </summary>
    protected List<IObserver> mObserverList;

    public ISubject()
    {
        mObserverList = new List<IObserver>();
    }

    /// <summary>
    /// 添加观察者
    /// </summary>
    public void AddObserber(IObserver observer)
    {
        if (mObserverList.Contains(observer) == false && observer != null)
        {
            mObserverList.Add(observer);
            return;
        }
        Debug.Log("报错");
    }
    /// <summary>
    /// 移除观察者
    /// </summary>
    public void RemoveObserber(IObserver observer)
    {
        if (mObserverList.Contains(observer))
        {
            mObserverList.Remove(observer);
            return;
        }
        Debug.Log("报错");
    }
    /// <summary>
    /// 通知所有观察者更新
    /// </summary>
    public void NotifyObserver()
    {
        foreach (IObserver item in mObserverList)//这个foreach可以遍历所有存储在list中的观察者
        {
            item.Update();
        }
    }
}
public class ConcreteSubjectA : ISubject//继承抽象类ISubject
{
    private string mState;
    public string State
    {
        get { return mState; }
        set
        {
            mState = value;
            NotifyObserver();
        }
    }
}
#endregion
#region 观察者
/// <summary>
/// 观察者抽象类
/// </summary>
public abstract class IObserver//观察者抽象类
{
    public abstract void Update();
}
public class ConcreteObserverA : IObserver //观察者类型A
{
    private ConcreteSubjectA mSubject;//创建自身的实例

    public ConcreteObserverA(ConcreteSubjectA subject)
    {
        mSubject = subject;//用来添加观察者
    }

    public override void Update()
    {
        Debug.Log("ConcreteObserverA显示更新：" + mSubject.State);
    }
}
public class ConcreteObserverB : IObserver//观察者类型B
{
    private ConcreteSubjectA mSubject;//创建自身的实例

    public ConcreteObserverB(ConcreteSubjectA subject)
    {
        mSubject = subject;//用来添加观察者
    }

    public override void Update()
    {
        Debug.Log("ConcreteObserverB显示更新：" + mSubject.State);
    }
}
#endregion