using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    //スコア
    public int score = 10;
    private BlockGenelator blockGenelator;

    //何かとぶつかったときに呼ばれる
    private void Start()
    {
        blockGenelator=FindObjectOfType<BlockGenelator>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(ScoreScript.instance!=null)
        {
            ScoreScript.instance.ScoreManager(score);
        }
        else
        {
            Debug.LogError("ScoreScriptのインスタンスがありません。");
        }
        //ブロックがぶつかったときに生成したカウントを減らしていく
        blockGenelator.BlockDestroyed();
        //ゲームオブジェクトを削除する
        Destroy(gameObject);
    }
}
