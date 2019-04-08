///カードの効果を書くための基底クラス
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardEffectBase : ScriptableObject
{
    /// <summary>
    /// カードの効果を記述する
    /// </summary>
    public abstract void Effect();
}
