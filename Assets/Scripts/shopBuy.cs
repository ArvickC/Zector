using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopBuy : MonoBehaviour
{

    private bool bought;
    public int price;
    public Button button;
    public string itemName;
    public string sold;
    public int plusLevels;

    private void Start()
    {
        if (backgroundAudio.itemsBoughtList !=null && backgroundAudio.itemsBoughtList.Contains(itemName))
        {
            button.interactable = false;
            GameObject.Find(sold).GetComponent<Text>().text = "SOLD!";
        }
        else
        {
            GameObject.Find(sold).GetComponent<Text>().text = "";
        }
    }

    public void ItemBought()
    {
        if(backgroundAudio.coinsNumber >= price)
        {
            bought = true;
            button.interactable = false;
            backgroundAudio.coinsNumber = backgroundAudio.coinsNumber - price;
            backgroundAudio.itemsBoughtList.Add(itemName);
            GameObject.Find(sold).GetComponent<Text>().text = "SOLD!";
        }
    }

    public void BoughtItem()
    {
        if(bought == true)
        {
            GameObject.Find(sold).GetComponent<Text>().text = "SOLD!";
        }
    }

    public void PlusLevels()
    {
        if (backgroundAudio.coinsNumber >= price)
        {
            backgroundAudio.coinsNumber -= price;
            backgroundAudio.levelNumber += plusLevels;
        }
    }

}
