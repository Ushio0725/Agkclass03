using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    void Start()
    {
        // 플레이어 
        Player player = new Player("용사", 100, 15);

        // 적 리스트 생성
        List<Enemy> enemies = new List<Enemy>();
        enemies.Add(new Slime());
        enemies.Add(new Goblin());

        Debug.Log("전투 시작");

        // 첫 번째 적 공격
        Enemy firstEnemy = enemies[0];
        player.Attack(firstEnemy);

        Debug.Log($"{firstEnemy.name}의 남은 체력 {firstEnemy.hp}");

        // 포션 사용
        player.UsePotion();
    }
}