using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// writer name is Sato Momoya
///カラーボールマネージャー
public class ColorBallManager : MonoBehaviour
{
    //カラーボールを横に生成する数
    public const int MaxColorBallWidth = 10;
    //カラーボールを縦に生成する数
    public const int MaxColorBallHeight = 10;
    //カラーボール
    [SerializeField]
    GameObject colorBall;
    //カラーボールを生成する分のリスト
    List<GameObject> colorBallsList;
    //タップ判定がtrueのカラーボールだけ格納するリスト
    List<GameObject> tapedColorBallsList;
    // Start is called before the first frame update
    void Start()
    {
        
        colorBallsList = new List<GameObject>();
        tapedColorBallsList = new List<GameObject>();
        //カラーボールを生成する
        CreateColorBalls();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// カラーボールを生成する関数
    /// </summary>
    public void CreateColorBalls()
    {
        //カラーボールを生成する
        for(int j = 0; j < MaxColorBallHeight; j++)
        {
            for(int i = 0; i <MaxColorBallWidth; i++)
            {
                //カラーボールをマネージャーの位置に生成する
                GameObject go = Instantiate(colorBall, new Vector3((float)transform.position.x + i, (float)transform.position.y + j, 0.0f), Quaternion.identity);
                //このオブジェクトの子供にする
                go.transform.SetParent(this.transform, true);
                //生成したカラーボールをリストに追加する
                colorBallsList.Add(go);
            }
        }
    }

}
