using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 配列課題 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { -10, 20, 79, 120, -48 };
        int min = -2147483647;
        int max = 2147483647;

        // 順番に表示
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > min && array[i] < max)
            {
                Debug.Log(array[i]);
            }
        }


        // 逆順に表示
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > min && array[i] < max)
            {
                Debug.Log(array[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
