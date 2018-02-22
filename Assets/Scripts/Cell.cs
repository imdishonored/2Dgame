using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{

    public GameObject Contains { get; private set; }

    public int X { get; private set; }
        
    public int Y { get; private set; }
   

    public void Init(GameObject enteredObj, int x, int y)
    {
        Contains = enteredObj;
        X = x;
        Y = y;
        if (Contains != null)
        {
            Contains.transform.SetParent(transform,false);
        }
        
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
