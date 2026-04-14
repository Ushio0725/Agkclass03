using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class Print : MonoBehaviour
{
    public void Printlnfo(string name, string desctiption)
    {
        Debug.Log($"당신의 이름은 {name} 입니다!");
        Debug.Log($"{desctiption} {name} 정말 멋진 이름입니다!");
     }

    public int Print_Number(int a, int b)    
    {
        a = 3;
        b = 2;
        int result = a + b;
        return result;
    }
    void Start()
    {
        
    
        // --------------------------------
        int[] numbers = { 10, 50, 100, 2, 80 };

        int max = numbers.Max();

        Debug.Log("가장 큰 값: " + max);

        // --------------------------------------
        int[] Icandoit = { 10, 5, 8, 3, 12 };

  
        int min = Icandoit[0];

       
        for (int i = 1; i < Icandoit.Length; i++)
        {
            if (Icandoit[i] < min)
            {
                min = Icandoit[i];
            }
            Debug.Log($"가장 작은 값 :{i}");
        }
    }
}
