using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayCrateInfo : MonoBehaviour
{
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private Image image;
    [SerializeField] private Sprite commonSprite;
    [SerializeField] private Sprite rareSprite;
    [SerializeField] private Sprite epicSprite;
    
    public void SetUp(CrateRarity rarity) {
        nameText.text = rarity.ToString() + " ����";

        switch(rarity){
            case CrateRarity.Common:
                nameText.text = "������� ����";
                image.sprite = commonSprite; break;
            case CrateRarity.Rare:
                nameText.text = "������ ����";
                image.sprite = rareSprite; break;
            case CrateRarity.Legendary:
                nameText.text = "����������� ����";
                image.sprite = epicSprite; break;
        }
    }
}
