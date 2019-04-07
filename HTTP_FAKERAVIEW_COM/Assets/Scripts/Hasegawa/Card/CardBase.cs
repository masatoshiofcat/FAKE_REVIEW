
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 商品カードの基底クラス。
/// 商品カードを作成するにはこれを継承したオブジェクトを生成する必要がある。
/// </summary>
abstract public class CardBase : MonoBehaviour
{
    [SerializeField]
    private string productName;//商品名
    [SerializeField]
    private string[] tagNames;//タグ名s

    [SerializeField]
    private string mouseOverString;//アイコンに？マウスがのせられた際に表示するヒント
    
    [SerializeField]
    private Texture2D iconTexture;//商品のイメージアイコン画像
    [SerializeField]
    private Vector3 iconOffst;//アイコンの描画位置

    [SerializeField]
    private int maxStock; //在庫


    private int currentStock;//現在までに売れた個数
    
    // Start is called before the first frame update
    private void Start()
    {
        //アイコンをイメージ位置に移動
    }

    /// <summary>
    /// カードの効果を発揮する純粋仮想関数
    /// </summary>
    public abstract void Effect();
}
