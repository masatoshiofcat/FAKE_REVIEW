///カードを動的に生成するためのクラス
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject cardFrame;//CardBaseをアタッチしてある、カードの枠、テキスト入力をまとめたオブジェクト

    [SerializeField]
    CardDataBase cardDataList; //カードのデータをまとめたデータベース

    [SerializeField]
    Sprite[] cardIcons;//カードのアイコンリスト


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
