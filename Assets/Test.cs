using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Boss
{
    private int hp = 100; //HP
    private int power = 25; //攻撃力
    private int mp = 53; //MP

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power+"のダメージを与えた");
    }
    //防御用の関数
    public void Defence(int damage) 
    {
        Debug.Log(damage+"のダメージを受けた");
        //HPを減らす
        this.hp -= damage;
    }
    //魔法用の関数
    public void Magic(int consumptionMP)
    {
        //MPがある時は魔法攻撃をして、足りない場合は魔法を使えないというメッセージを表示する
        if (this.mp >= consumptionMP)
        {
            mp -= consumptionMP;
            Debug.Log("魔法攻撃をした。のこりMPは"+this.mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法を使えない");
        }
    }
}
public class Test : MonoBehaviour
{
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();
        Boss midboss = new Boss();
        //攻撃用の関数を呼び出す
        lastboss.Attack();
        midboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);
        midboss.Defence(10);
        //魔法用の関数を繰り返し呼び出す
        for (int i = 0; i <= 10; i++)
        {
            lastboss.Magic(5);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}