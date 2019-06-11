using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tpuntuation : MonoBehaviour {

    public static int tPuntuation;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        tPuntuation = tPuntuation + (int)Time.timeSinceLevelLoad * 2;
    }
}
