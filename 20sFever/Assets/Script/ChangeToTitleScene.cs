using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///タイトルシーンへ切り替えるクラス
public class ChangeToTitleScene : MonoBehaviour
{
    //シーンを切り替える時間
    public const float maxTime = 1.0f;
    //現在のカウントしている時間
    private float nowCountTime = 0.0f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //経過時間を足し続ける
        nowCountTime += Time.deltaTime;
        //もしnowCountTimeがmaxTimeを超えたら
        //シーンをタイトルシーンに切り替える
        if (nowCountTime > maxTime)
        {
            ChangeSceneClass.ChangeScene(ChangeSceneClass.SceneName.TITLE_SCENE);
        }
    }
}
