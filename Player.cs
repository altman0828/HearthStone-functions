using UnityEngine;
using System.Collections;

public class Player {

    public int health;
    
	public Player ()
    {
        health = 30;
	}
    
    void damaged (int damage)
    {
        health -= damage;
            
    }
    public void goFirst(string name)
    {
        Debug.Log(name + "선공");
    }
    public void goSnd(string name)
    {
        Debug.Log(name + "후공");
    }
}
