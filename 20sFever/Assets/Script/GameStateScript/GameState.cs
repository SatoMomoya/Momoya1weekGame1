using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// writer name is Sato Momoya
//ゲームステート
namespace GameState
{
    //ステートの実行を管理するクラス
    public class StateProcessor
    {
        //ステート本体
        private GameState _state;
        // ステートを取得、セットをするプロパティ
        public GameState State
        {
            set { _state = value; }
            get { return _state; }
        }

        // 実行関数
        public void Execute()
        {
            State.Execute();
        }

    }
    //ゲームステートの親クラス
    public abstract class GameState
    {
        //ステート実行関数
        public abstract void ExecuteState();
     

        //実行関数
        public virtual void Execute()
        {
            //ステートを実行する
            ExecuteState();
        }

        //現在のステートをストリング型で返す関数
        public abstract string GetStateName();
    }
}