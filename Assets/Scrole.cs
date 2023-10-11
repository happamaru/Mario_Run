using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//これはステージのスクロールをするクラスです
public class Scrole : MonoBehaviour
{
    public GameObject stage1;//マリオのステージ1
    public GameObject stage2;//マリオのステージ2
    public GameObject stage3;//マリオのステージ3

    public float speed;//スクロールするスピード

    //毎回呼ばれる関数
    void Update()
    {
        stage1.transform.position += Vector3.left * speed * Time.deltaTime;
        stage2.transform.position += Vector3.left * speed * Time.deltaTime;
        stage3.transform.position += Vector3.left * speed * Time.deltaTime;

        if (stage1.transform.position.x < -18)
        {
            stage1.transform.position = new Vector3(25, 0, 0);
        }

        if (stage2.transform.position.x < -18)
        {
            stage2.transform.position = new Vector3(25, 0, 0);
        }

        if (stage3.transform.position.x < -18)
        {
            stage3.transform.position = new Vector3(25, 0, 0);
        }
    }
}
