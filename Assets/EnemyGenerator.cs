using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject togezo;
    float time;
    float span = 1;//生成頻度
    void Update()
    {
        time += Time.deltaTime;
        if (time > span)
        {
            time = 0;
            span = Random.Range(0.3f, 0.8f);//ランダムな生成頻度にする
            GameObject go = Instantiate(togezo) as GameObject;
        }
    }
}
