using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public Player p1 = new Player(); //플레이하는 플레이어
    public Player p2 = new Player(); //상대방

    void Start () {
	    if(isFirst())
        {
            p1.goFirst("p1");
            p2.goSnd("p2");
        }
        else
        {
            p2.goFirst("p2");
            p1.goSnd("p1");
        }
	}
	
	// Update is called once per frame
	void Update () {
        TurnCount();
	}

    //선공 후공을 정하는 메소드
    bool isFirst ()
    {
        float rand = Random.Range(0f, 1.0f);
        if (rand > 0.5)
            return true;
        else
            return false;
    }

    //턴의 시간제한
    void TurnCount ()
    {
        float left_time = 1.0f - Time.deltaTime;
        if (left_time <= 0)
            changeTurn();
        
    }

    public static void changeTurn()
    {
        Debug.Log("Turn Changed");
    }
}
