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
        nameText.text = rarity.ToString() + " ящик";

        switch(rarity){
            case CrateRarity.Common:
                nameText.text = "Обычный ящик";
                image.sprite = commonSprite; break;
            case CrateRarity.Rare:
                nameText.text = "Редкий ящик";
                image.sprite = rareSprite; break;
            case CrateRarity.Legendary:
                nameText.text = "Легендарный ящик";
                image.sprite = epicSprite; break;
        }
    }
}
