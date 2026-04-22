using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        Move();
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, v, 0);

        transform.position += dir * moveSpeed * Time.deltaTime;

        // 이번 프레임의 시간 길이 
        // 이번에는 시간이 얼마나 흘렀지? 이걸 알려주는 값
        // 유니티에서는 이 시간이 deltaTime 
    }
}
