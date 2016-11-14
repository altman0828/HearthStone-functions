﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubeSpawner : MonoBehaviour {

    public GameObject cubePrefabVar;
    public List<GameObject> gameObjectList;
    public float scalingFactor = 0.95f;
    public int numCubes = 0;

	void Start () {
        gameObjectList = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
        numCubes++;

        GameObject gObj = Instantiate(cubePrefabVar) as GameObject;

        gObj.name = "Cube" + numCubes;
        Color c = new Color(Random.value, Random.value, Random.value);
        gObj.GetComponent<Renderer>().material.color = c;
        
        gObj.transform.position = Random.insideUnitSphere;

        gameObjectList.Add(gObj);

        List<GameObject> removeList = new List<GameObject>();

        foreach(GameObject goTemp in gameObjectList)
        {
            float scale = goTemp.transform.localScale.x;
            scale *= scalingFactor;
            goTemp.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1f)
                removeList.Add(goTemp);
        }

        foreach (GameObject goTemp in removeList)
        {
            gameObjectList.Remove(goTemp);
            Destroy(goTemp);
        }
	}
}
