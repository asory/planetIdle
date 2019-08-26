using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public Click click;
    public UnityEngine.UI.Text itemInfo;
    public GameObject prefab;
    public float cost;
    public int level = 0;
    public int tickValue;
    public string itemName;
    private float baseCost;

    private void Start()
    {
        baseCost = cost;
    }

    private void Update()
    {
        itemInfo.text = itemName + " lv: " + level + "\nCost:" + cost ;
    }

    public void PurchaseItem()
    {
        if (click.stardust >= cost)
        {

            click.stardust -= cost;
            level += 1;
            cost = Mathf.Round(baseCost * Mathf.Round(level * 1.15f));

        }
    }
}