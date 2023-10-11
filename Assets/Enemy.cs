using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    void Update()
    {

        this.transform.position += Vector3.left * speed * Time.deltaTime;
        if (this.transform.position.x < -10)
        {
            Destroy(this.gameObject);
        }
    }
}
