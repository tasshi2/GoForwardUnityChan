using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeController : MonoBehaviour
{

    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    // private GameObject syoutotuText;
    // int syoutotuKaisuu = 0;

    // Start is called before the first frame update
    void Start()
    {

        // //シーン中の衝突テキスト取得
        // this.syoutotuText = GameObject.Find("SyoutotuText");
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        // タグがキューブタグ,グランドタグのときには効果音をプレイする
        if (other.gameObject.tag == "CubeTag" || other.gameObject.tag == "GroundTag")
            GetComponent<AudioSource>().Play();
    }
}