using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    // override = 덮어쓰다
    public override void Eat()
    {
        Debug.Log("냠냠");
    }
    public override void Move()
    {
        Debug.Log("움직이지 않았습니다!");
    }
    void Start()
    {
        // 부모 클래스의 함수를 실행시키는 것
        base.Move();
        Move();
    }
}

