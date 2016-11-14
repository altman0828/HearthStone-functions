using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    public Player p1 = new Player(); //플레이하는 플레이어
    public Player p2 = new Player(); //상대방
    public List<List<Vector3>> posList;//하수인들의 위치

    private short[] minionNum = { 0, 0 };

    List<List<Minion>> mList = new List<List<Minion>>(); // 하수인들의 정보를 담는 가변리스트

    void Start() {

        if (isFirst())
        {
            p1.GoFirst("p1");
            p2.GoSnd("p2");
            StartCoroutine("P1_Turn");
        }
        else
        {
            p2.GoFirst("p2");
            p1.GoSnd("p1");
            StartCoroutine("P2_Turn");
        }
        mList.Add(null);
        mList.Add(null);
    }
	
	// Update is called once per frame
	void Update () {
        
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


    IEnumerator P1_Turn()
    {
        StopCoroutine("P2_Turn");
        p2.SetTurn(false);
        p1.SetTurn(true);
        yield return new WaitForSeconds(20);
        Debug.Log("Turn changed (p1 -> p2)");
        StartCoroutine("P2_Turn");
    }

    IEnumerator P2_Turn()
    {
        StopCoroutine("P1_Turn");
        p1.SetTurn(false);
        p2.SetTurn(true);
        yield return new WaitForSeconds(20);
        Debug.Log("Turn changed (p2 -> p1)");
        StartCoroutine("P1_Turn");
    }

    public void ChangeTurn()
    {
        if(p1.GetTurn())
        {
            StartCoroutine("P2_Turn");
        }
        else
        {
            StartCoroutine("P1_Turn");
        }
    }
    public void HeroDamaged(Player damagedOne,int damage)
    {
        damagedOne.health -= damage;
    }
    void PlayMinion(short p, Minion minion)
    {
        minionNum[p - 1]++;
        mList[p - 1].Add(minion);
    }
    void MinionDestroy(short p, Minion minion)
    {
        minionNum[p - 1]--;
        mList[p - 1].Remove(minion);
        Destroy(minion);
    }
}
