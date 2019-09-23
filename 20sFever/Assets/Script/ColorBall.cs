using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// writer name is Sato Momoya
/// カラーボールクラス
public class ColorBall : MonoBehaviour
{
    //色の種類
    public enum ColorBallTypes
    {
        NONE,//無し(空白)
        COLOR_TYPE_A,//Aタイプ
        COLOR_TYPE_B,//Bタイプ
        COLOR_TYPE_C,//Cタイプ
        COLOR_TYPE_D,//Dタイプ
        COLOR_TYPE_E,//Eタイプ

        NUM
    }
    //自身が調べるボールの範囲
    public enum TheTypeOfBowlToExamine
    {
        UP,             //上
        UPPER_RIGHT,    //右上
        UPPER_LEFT,     //左上
        RIGHT,          //右
        LEFT,           //左
        BOTTOM,         //下
        BOTTOM_RIGHT,   //右下
        BOTTOM_LEFT,    //左下

        NUM
    }

    //押されているかの確認フラグ
    //デフォルトは押されていない状態
    bool pushedFlag = false;
    //自身のカラータイプ
    //デフォルトは空白に設定
    [SerializeField]
    ColorBallTypes colorBallType = ColorBallTypes.NONE;
    //1フレーム前のカラーボールタイプ
    ColorBallTypes currentColorBallType;
    //カラーボールに登録されているマテリアル
    [SerializeField]
    Material[] registeredColorBallMaterial = new Material[(int)ColorBallTypes.NUM];
    //現在のカラーボールマテリアル
    Material nowColorBallMaterial;
    //スプライトレンダラー
    SpriteRenderer spriteRender;
    //自身が隣接している分のカラーボール情報
    ColorBall[] adjoiningBalls = new ColorBall[(int)TheTypeOfBowlToExamine.NUM];
    // Start is called before the first frame update
    void Start()
    {
        //色のタイプによって色を変える
        nowColorBallMaterial = registeredColorBallMaterial[(int)colorBallType];
        //スプライトレンダラーを取得
        spriteRender = this.GetComponent<SpriteRenderer>();
        //現在のカラーボールマテリアルをオブジェクトのマテリアルにする
        spriteRender.material.color = nowColorBallMaterial.color;


    }

    // Update is called once per frame
    void Update()
    {
        //オブジェクトの色を現在のマテリアルに変更する
        spriteRender.material.color = nowColorBallMaterial.color;
        //テスト
        //スペースキーを押されたら
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //新しいカラータイプに変更する
            ChangeRandomNewColor();
        }
        //1フレーム前と違うカラータイプだったら
        if (currentColorBallType != colorBallType)
        {
            //現在のマテリアルを登録されているマテリアルに変更
            nowColorBallMaterial = registeredColorBallMaterial[(int)colorBallType];
            //現在のカラーボールマテリアルをオブジェクトのマテリアルにする
           spriteRender.material.color = nowColorBallMaterial.color;
        }

        //1フレーム前のカラータイプとして登録する
        currentColorBallType = colorBallType;
    }
    /// <summary>
    /// 押されたか確認するフラグのプロパティ
    /// </summary>
    public bool PushedFlag
    {
        get { return pushedFlag; }
        set { pushedFlag = value; }
    } 
    /// <summary>
    /// カラーボールのプロパティ
    /// </summary>
    public ColorBallTypes ColorBallType
    {
        get { return colorBallType; }
        set { colorBallType = value; }
    }
    /// <summary>
    /// 自身の隣接しているボール情報を返す関数
    /// </summary>
    /// <param name="type">どの場所か</param>
    /// <returns></returns>
    public ColorBall GetAdjoiningBalls(TheTypeOfBowlToExamine getType)
    {
        return adjoiningBalls[(int)getType];
    }
    /// <summary>
    /// 自身の隣接しているボールをセットする関数
    /// </summary>
    /// <param name="setColorBall">セットするボール</param>
    /// <param name="setType">セットするタイプ</param>
    public void SetAdjoiningBalls(ColorBall setColorBall, TheTypeOfBowlToExamine setType)
    {
        adjoiningBalls[(int)setType] = setColorBall;
    }
    /// <summary>
    /// 現在のカラータイプから別のカラータイプに変更する関数
    /// </summary>
    public void ChangeRandomNewColor()
    {
        ColorBallTypes tmp;
        //ランダムで取得したカラータイプが
        //同じ色以外かNONE以外になるまで回す
        while (true)
        {
            tmp = (ColorBallTypes)Random.Range((int)ColorBallTypes.NONE, (int)ColorBallTypes.NUM);
            if(tmp != colorBallType && tmp != ColorBallTypes.NONE)
            {
                break;
            }
        }
        //新しいカラータイプに変更する
        colorBallType = tmp;
    }
}
