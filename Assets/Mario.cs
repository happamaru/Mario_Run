using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    public float JumpPower;//ジャンプ力
    public Animator animator;
    public Sprite GameOverImage;//マリオのゲームオーバー画像
    public GameObject GameOver;//GameOverパネル
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rigid2D;
    int JumpNum = 0;
    public int JumpLimit;//ジャンプ回数上限

    void Update()
    {

       
 if (Input.GetKeyDown(KeyCode.Space))
        {//もしスペースボタンを押したら

            if (JumpNum < JumpLimit)
            {
                JumpNum++;
                rigid2D.AddForce(Vector2.up * JumpPower);
            }
        }

    }

   
    void OnCollisionStay2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Ground")
        {
            JumpNum = 0;//ジャンプのリセット
        }
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "Enemy")
        {
            GameOver.SetActive(true);//GameOveの表示
            animator.enabled = false;//Animationの停止
            spriteRenderer.sprite = GameOverImage;//ゲームオーバー画像に差し替え
            Destroy(collider2D.gameObject);//敵の破壊
            Time.timeScale = 0;//時間停止
        }
    }

}
