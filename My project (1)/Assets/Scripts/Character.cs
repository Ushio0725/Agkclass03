using UnityEngine;

public class Character
{
    public string name;
    public int hp;
    public int attack;

    public Character(string name, int hp, int attack)
    {
        this.name = name;
        this.hp = hp;
        this.attack = attack;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        Debug.Log($"{name}이 {damage} 데미지를 받았다");

        if (hp <= 0)
        {
            Die();
        }
    }

    public void Attack(Character target)
    {
        Debug.Log($"{name}가 {target.name}을 공격했다");
        target.TakeDamage(attack);
    }

    public void Die()
    {
        Debug.Log($"{name}이 죽었다");
    }
}