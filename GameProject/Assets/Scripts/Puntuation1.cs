using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuation1 : MonoBehaviour {

    public static int puntuation1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        puntuation1 = puntuation1 + (int)Time.timeSinceLevelLoad * 2;
    }
}
