///カードのデータをまとめておくデータベースを作るためのクラス
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardDataBase",menuName ="CreateCardDataBase")]
public class CardDataBase : ScriptableObject
{
    [SerializeField]
    private List<CardData> cardDataList = new List<CardData>();

    /// <summary>
    /// カードのデータリストの取得
    /// </summary>
    /// <returns></returns>
    public List<CardData> GetCardDataList()
    {
        return this.cardDataList;
    }
}
