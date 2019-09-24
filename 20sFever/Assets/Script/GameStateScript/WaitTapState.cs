using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// writer name is Sato Momoya
///タップ待ちステート

public class WaitTapState : GameState.GameState
{
    /// <summary>
    /// ステート実行関数
    /// </summary>
    public override void ExecuteState()
    {

    }
    /// <summary>
    /// このクラスのステートをstring型で返す関数
    /// </summary>
    /// <returns>ステートの名前</returns>
    public override string GetStateName()
    {
        return "state is WaitTapState";
    }
}
