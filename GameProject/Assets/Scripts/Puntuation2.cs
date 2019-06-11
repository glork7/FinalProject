using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuation2 : MonoBehaviour {

    public static int puntuation2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        puntuation2 = puntuation2 + (int)Time.timeSinceLevelLoad * 2;
    }
}
