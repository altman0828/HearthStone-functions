using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Card : MonoBehaviour {

    public int cost;
    public int damage;
    public void DealDamage(short p, short targetEnemy, List<Minion> mList)
    {
        mList[targetEnemy].health -= damage;
    }
}

//주문
public class Spell : Card
{
    
}

//하수인
public class Minion : Card
{
    public GameObject body;
    public int health;
    public string tags;

    public void Played (int targetEnemy)
    {

    }
}