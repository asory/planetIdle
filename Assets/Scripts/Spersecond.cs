using System.Collections;
using UnityEngine;

public class Spersecond : MonoBehaviour
{

    public Click click;

    // Start is called before the first frame update
    public ItemManager[] items;
    public Intantiate generator;
    public GameObject spaceObjectContainer;

    private void Start()
    {
        StartCoroutine(AutoTick());
    }

    private void Update()
    {
        click.starPerSeg = GetstardustPerSec();
    }
    public int GetstardustPerSec()
    {
        int tick = 0;
        foreach (ItemManager items in items)
        {
            tick += items.level + items.tickValue;
            if (items.level >= 1)
                generator.CreateObject(items.itemName);

        }
        return tick;

    }


    public void AutostardustPerSec()
    {
        click.stardust += GetstardustPerSec();
    }

    IEnumerator AutoTick()
    {
        while (true)
        {
            AutostardustPerSec();
            yield return new WaitForSeconds(1);
        }
    }

    public void Stop()
    {
        StopCoroutine(AutoTick());
    }
}