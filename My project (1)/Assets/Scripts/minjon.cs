using UnityEngine;
using System; // Array.Sort를 사용하기 위해 필요

public class minjon : MonoBehaviour
{
    void Start()
    {
        // 1. 정수 배열 선언 및 초기화
        int[] numbers = { 10, 5, 8, 1, 7, 3, 9, 2, 6, 4 };

        // 2. 함수 호출
        SortAndPrint(numbers);
    }

    // 배열을 정렬하고 출력하는 함수
    void SortAndPrint(int[] array)
    {
        // 원본 배열이 비어있는지 확인
        if (array == null || array.Length == 0)
        {
            Debug.Log("배열이 비어있습니다.");
            return;
        }

        // 3. 배열 정렬 (오름차순)
        Array.Sort(array);

        // 4. 차례대로 출력
        string result = "정렬된 배열: ";
        for (int i = 0; i < array.Length; i++)
        {
            result += array[i] + (i == array.Length - 1 ? "" : ", ");
        }

        Debug.Log(result);
    }
}

