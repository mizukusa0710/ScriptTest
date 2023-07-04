using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int mp = 53;

    public void Magic()
    {
        if (mp >= 5)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            mp -= 5;
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}

public class 発展課題 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();

        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }

        lastboss.Magic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
