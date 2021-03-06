﻿using UnityEngine;
using System.Collections;

public class ProceduralGeneration : MonoBehaviour {
    public int xSize = 200;
    public int ySize = 200;
    public GameObject cube;
    // Use this for initialization
    void Start () {
	    for(int x = 0;x< xSize; x++)
        {
            for (int y = 0; y < ySize; y++)
            {
               GameObject tmp =Instantiate(cube, new Vector3(x, y, 0), Quaternion.identity) as GameObject;
               if (x % 2 == 0) { tmp.GetComponent<Renderer>().material.SetColor("_Color", new Color(255, 0, 0, 1));}
               tmp.AddComponent<UnitBehavior>();
                tmp.GetComponent<UnitBehavior>().posSetter(x, y);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
