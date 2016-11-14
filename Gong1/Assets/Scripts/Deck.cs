using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck : MonoBehaviour {

    List<Card> deckList;
	
	void Start () {
        deckList = new List<Card>(30);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
