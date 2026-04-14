using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // 플레이어 체력
    public int health = 100;
    // Start : 스크립트가 처음 실행될때 한번만 작동하는 함수

    void Start()
    {
        Debug.Log("현재 체력: " + health);
    }

    // Update : 매 프레임 마다 호출되는 함수
    void Update()
    {
        // GetKeyDown -> 키보드를 한번 눌렀을 때
        // KeyCode -> 감지할 키보드의 코드
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(10);
        }
    }
    void Die()
    {
        Debug.Log("플레이어 사망");
        gameObject.SetActive(false); // 오브젝트 비활성화
    }
    void TakeDamage (int damage)
    {
        health -= damage;
        Debug.Log("데미지를 받았습니다! 남은 체력 : " + health);

        if(health <= 0)
        {
            Die();
        }
    }
        /// <summary>
        ///  프린트 함수
        /// </summary>
        /// <param name="message"></param>
        void Print(string message)
        {
            Debug.Log(message);
        }
        int Calculate(int a, int b)
        {
            int result = 0;

            result = a + b;

            result *= a;

            result -= b;

            return result;
        }

    
}