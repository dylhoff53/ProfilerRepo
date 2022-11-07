using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SlowCode : MonoBehaviour
{
    private int x;
    private int y;
    private int z;
    public GameObject cube;
    void Update()
    {
        cube.transform.localScale = SizeForTime();
        DoLoopStuff();
        DoSomethingElse();
    }
    private void DoLoopStuff()
    {
        for (int i = 0; i < 2500; i++)
        {
            cube.transform.localScale = SizeForTime();
        }
    }
    private Vector3 SizeForTime()
    {
        x = Random.Range(-5, 5);
        y = Random.Range(-5, 5);
        z = Random.Range(-5, 5);
        return new Vector3(x, y, z);
    }
    private void DoSomethingElse()
    {
        Debug.Log("look how slow logging is!");
    }
}
