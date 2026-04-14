using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public string Name;
    
    public int Health;
    
    public float Speed;

    public void Shout(string message)
    {

    }

    /// <summary>
    /// virtsual : 기본 동작을 정의 할수가 있다.
    /// </summary>

    public virtual void Move()
    {
        Debug.Log("움직입니다");
    }

    /// <summary>
    /// abstract : 동작을 구현 할 수가 없다.
    /// </summary>

    public abstract void Eat();

    // virtual : 기본 동작은 있지만 자식이 바꿔서 사용할 수 있게 하고 싶다.

    // abstract : 이 기는은 무조건 구현해야하는 것. 자식에서
}
