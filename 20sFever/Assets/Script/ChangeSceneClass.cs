using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
/// writer name is Sato Momoya
///シーン変更用クラス
public class ChangeSceneClass : MonoBehaviour
{
    //登録しているシーン
    public  enum SceneName
    {
        LOGO_SCENE  = 0,//ロゴシーン
        TITLE_SCENE = 1,//タイトルシーン
        SELECT_SCENE= 2,//セレクトシーン
        PLAY_SCENE =  3,//プレイシーン
   
        NUM
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// シーンを切り替える関数
    /// </summary>
    /// <param name="changeSceneName">切り替えるシーンの名前</param>
public static void ChangeScene(SceneName changeSceneName)
       {
          SceneManager.LoadSceneAsync((int)changeSceneName);
       }
}
