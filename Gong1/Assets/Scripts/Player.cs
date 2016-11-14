using UnityEngine;
using System.Collections;

public class Player {

    public int health;
    

    private bool turn;
    private bool isWeapon;
    
	public Player ()
    {
        health = 30;
	}
    
    public void GoFirst(string name)
    {
        Debug.Log(name + "선공");
    }
    public void GoSnd(string name)
    {
        Debug.Log(name + "후공");
    }
    public void SetTurn(bool yTurn)
    {
        turn = yTurn;
    }
    public bool GetTurn()
    {
        return turn;
    }
    public void HeroAttack(int damage)
    {
        
    }
    
}
