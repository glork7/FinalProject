using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DController : MonoBehaviour {

    public GameObject Diamond5, Diamond4, Diamond3, Diamond2, Diamond1;
    public static int diamond;

    // Start is called before the first frame update
    void Start()
    {
        diamond = 0;
        Diamond5.gameObject.SetActive(true);
        Diamond4.gameObject.SetActive(true);
        Diamond3.gameObject.SetActive(true);
        Diamond2.gameObject.SetActive(true);
        Diamond1.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (diamond > 5)
        {
            diamond = 5;
        }
        switch (diamond)
        {
            case 5:
                Diamond5.gameObject.SetActive(true);
                Diamond4.gameObject.SetActive(true);
                Diamond3.gameObject.SetActive(true);
                Diamond2.gameObject.SetActive(true);
                Diamond1.gameObject.SetActive(true);
                break;
            case 4:
                Diamond5.gameObject.SetActive(false);
                Diamond4.gameObject.SetActive(true);
                Diamond3.gameObject.SetActive(true);
                Diamond2.gameObject.SetActive(true);
                Diamond1.gameObject.SetActive(true);
                break;
            case 3:
                Diamond5.gameObject.SetActive(false);
                Diamond4.gameObject.SetActive(false);
                Diamond3.gameObject.SetActive(true);
                Diamond2.gameObject.SetActive(true);
                Diamond1.gameObject.SetActive(true);
                break;
            case 2:
                Diamond5.gameObject.SetActive(false);
                Diamond4.gameObject.SetActive(false);
                Diamond3.gameObject.SetActive(false);
                Diamond2.gameObject.SetActive(true);
                Diamond1.gameObject.SetActive(true);
                break;
            case 1:
                Diamond5.gameObject.SetActive(false);
                Diamond4.gameObject.SetActive(false);
                Diamond3.gameObject.SetActive(false);
                Diamond2.gameObject.SetActive(false);
                Diamond1.gameObject.SetActive(true);
                break;
            case 0:
                Diamond5.gameObject.SetActive(false);
                Diamond4.gameObject.SetActive(false);
                Diamond3.gameObject.SetActive(false);
                Diamond2.gameObject.SetActive(false);
                Diamond1.gameObject.SetActive(false);
                break;
        }
    }
}
