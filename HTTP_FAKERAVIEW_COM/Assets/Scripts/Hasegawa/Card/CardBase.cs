
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 商品カードの基底クラス。
/// 商品カードを作成するにはこれを継承したオブジェクトを生成する必要がある。
/// </summary>
public class CardBase : MonoBehaviour
{
    [SerializeField]
    private Text nameText; //商品名を書くためのTextオブジェクト

    [SerializeField]
    private Text effectText;//商品効果を書くためのTextオブジェクト

    [SerializeField]
    private Text maxStockText;//在庫数を書くためのTextオブジェクト

    [SerializeField]
    private Text currentStockText;//現在の在庫数を書くためのTextオブジェクト

    [SerializeField]
    private SpriteRenderer cardIcon;//アイコン画像を変更するためのオブジェクト

    private CardEffectBase cardEffect;//商品が買われたときの効果を記述したクラス

    private int currentStock;//現在までに売れた個数
    
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    /// <summary>
    /// カード情報を初期化設定するための関数
    /// </summary>
    /// <param name="nameText"></param>商品名
    /// <param name="effectText"></param>カードの効果説明
    /// <param name="maxStock"></param>カードの在庫数
    /// <param name="effect"></param>カードの効果を記述したクラス
    /// <param name="tex"></param>アイコン画像
    public void CardInitialize(string nameText,string effectText,int maxStock,CardEffectBase effect,Sprite tex)
    {
        this.SetNameText(nameText);
        this.SetCardEffectText(effectText);
        this.SetMaxStock(maxStock);
        this.SetCardEffect(effect);
        this.SetCardIconImage(tex);
    }
    /// <summary>
    /// カードの表示名を設定するための関数
    /// </summary>
    /// <param name="nameText"></param>
    public void SetNameText(string nameText)
    {
        this.nameText.text = nameText;
    }

    /// <summary>
    /// カード効果の表記を設定するための関数
    /// </summary>
    /// <param name="effectText"></param>
    public void SetCardEffectText(string effectText)
    {
        this.effectText.text = effectText;
    }

    /// <summary>
    /// 現在在庫数の表記を設定するための関数
    /// </summary>
    /// <param name="value"></param>
    public void SetCurrentStock(int value)
    {
        this.currentStockText.text = value.ToString();
    }

    /// <summary>
    /// 売るべき在庫数の表記を設定するための関数
    /// </summary>
    /// <param name="value"></param>
    public void SetMaxStock(int value)
    {
        this.maxStockText.text = "/" + value.ToString();
    }

    /// <summary>
    /// カードが売れたときの効果を記述したソースの設定
    /// </summary>
    public void SetCardEffect(CardEffectBase effect)
    {
        this.cardEffect = effect;
    }

    /// <summary>
    /// カードアイコンの設定
    /// </summary>
    /// <param name="tex"></param>
    public void SetCardIconImage(Sprite tex)
    {
        this.cardIcon.sprite =tex;
    }
}
