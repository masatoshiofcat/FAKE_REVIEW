﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "Card",menuName ="CreateCard")]
public class CardData : ScriptableObject
{
    //カードの種類。主にこれによってイラストが変わる
    public enum KindOfCard
    {
        BOOK,         // 本
        DISC,         // CDやDVDがこれにあたる
        HOBBY,        // 主に玩具
        Game,         // ゲーム
        STATIONERY,   // 文房具
        OTHER,        // その他
    }

    //カードのタグ。
    public enum TagOfCard
    {
        NARD,          // オタク
        YOUNG,         // 若者
        GIRL,          // 女児
        BOY,           // 男児
        READER,        // 読書家
        STUDENT,       // 受験生

    }

    [SerializeField]
    private KindOfCard kind;//カードの種類

    [SerializeField]
    private string cardName;//商品名

    [SerializeField]
    private TagOfCard[] cardTag;//商品についているタグ

    [SerializeField]
    private CardEffectBase cardEffect;//カードの効果

    [SerializeField]
    private string cardEffectText;//カードに書かれる、効果の説明

    [SerializeField]
    private int stock; //在庫数

    [SerializeField]
    private string mouseOverText;//マウスが上に乗った時表示されるヒント



    /// <summary>
    /// 商品の種類の取得
    /// </summary>
    /// <returns></returns>
    public KindOfCard GetKind()
    {
        return this.kind;
    }

    /// <summary>
    /// 商品名の取得
    /// </summary>
    /// <returns></returns>
    public String GetCardName()
    {
        return this.cardName;
    }

    /// <summary>
    /// 商品についているタグの取得
    /// </summary>
    /// <returns></returns>
    public TagOfCard[] GetCardTag()
    {
        return this.cardTag;
    }

    /// <summary>
    /// カードの効果スクリプトの取得
    /// </summary>
    /// <returns></returns>
    public CardEffectBase GetCardEffect()
    {
        return this.cardEffect;
    }

    /// <summary>
    /// カードの効果説明文の取得
    /// </summary>
    /// <returns></returns>
    public string GetCardEffectText()
    {
        return this.cardEffectText;
    }
    /// <summary>
    /// 商品の在庫数の取得
    /// </summary>
    /// <returns></returns>
    public int GetStock()
    {
        return this.stock;
    }

    /// <summary>
    /// マウスが上に乗った時表示される文字列の取得
    /// </summary>
    public string GetMouseOverString()
    {
        return this.mouseOverText;
    }
}
