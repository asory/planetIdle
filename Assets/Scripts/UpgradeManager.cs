using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class UpgradeManager : MonoBehaviour
{

    public Click click;
    public Intantiate generator;
    public UnityEngine.UI.Text itemInfo;
    public GameObject prefab;
    public GameObject spaceObjectContainer;
    public Button buttonHide, buttonDisable;
    public string itemName;
    public float cost;
    private float baseCost;
    public int level = 0;  // times buy
    public int clickPower; // amount stardust per click gained
    public int range; // area to spawn 
    public int goal; //  

    private void Start()
    {
        baseCost = cost;
       buttonHide.gameObject.SetActive(false);
 
    }
    void Update()
    {
        itemInfo.text = itemName + "    lv: " + level + "\n +" + clickPower + " Cost: " + cost;

    }

    public void PurchaseUpgrade()
    {
        if (click.stardust >= cost)
        {
            click.stardust -= cost;
            level += 1;
            click.starPerClick += clickPower;
            cost = Mathf.Round(cost * 1.15f);
            baseCost = Mathf.Pow(cost, baseCost);
            generator.CreateObject(itemName);
        }
        if (level > 10)
            NextLevel();
    }

    public void NextLevel()
    {
        buttonDisable.interactable = true;

        if (level > goal / 2)
        {
            buttonHide.gameObject.SetActive(true);
        }
        if (level >= goal)
            buttonHide.interactable = true;

    }
}