using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private void Update()
    {
        // transform은 오브젝트의 상태 정보
        // transform.position은 그 오브젝트의 현재 위치

        // Vector3
        // 숫자 3개를 묶어둔 자료형이에요. 유니티에서는 주로 위치나 방향을 표현할 때 사용하고

        // Vector3.up : 유니티가 미리 만들어둔 위쪽 방향 벡터이다
        // 실제로는 new Vector(0, 1, 0);

        // 왜 백터를 쓰느냐 위치가 숫자 하나가 아니라 x, y, z 3개로 이루어져 있다
        // 세 방향의 값이 한번에 필요하여 벡터라는 친구는 숫자 3개의 묶음형이라 안쓸 이유가 없다.
       
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.up;

            transform.position = new Vector3(0, 0, 0);
        }
         
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.down;

            transform.position = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.right;

            transform.position = new Vector3(0, 0, 0);
        }
       
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.left;

            transform.position = new Vector3(0, 0, 0);
        }
    }
}
