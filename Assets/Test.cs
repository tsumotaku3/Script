using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour
{
    //int型の配列「array」を初期化
    int[] array = {1,2,3,4,5};

    void Start()
    {
        //配列の要素をすべて表示する
        for (int i=0;i<array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        //配列の要素をすべて表示する
        for (int i=0;i<array.Length;i++)
        {
            Debug.Log(array[array.Length-i-1]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}