using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intantiate : MonoBehaviour
{

    public Click click;

    // the Equip prefab - required for instantiation
    public GameObject spaceObjectContainer;

    // list that holds all created objects - deleate all instances if desired
    public List<GameObject> createdObjects = new List<GameObject>();


    // list that holds all prefab objects - 
    public List<GameObject> Prefabs = new List<GameObject>();

    public Spersecond ro;


    public void DeleteAll()
    {
        ro.Stop();

        foreach (GameObject item in createdObjects)
        {
            if (Application.isEditor)
                GameObject.DestroyImmediate(item);
            else
                GameObject.Destroy(item);

        }


    }


    public void CreateObject(string type)
    {
        GameObject newSpaceObject;
        Vector3 position;
        int i;
        switch (type)
        {
            case "Stardust":
            case "Auto":
                break;

            case "Core":
            case "AutoCore":
                {
                    i = 0;
                    position = Random.onUnitSphere * (5 + Random.Range(0, 0.5f));
                    newSpaceObject = Instantiate(Prefabs[i], position, Quaternion.identity) as GameObject;
                    newSpaceObject.transform.parent = spaceObjectContainer.transform;
                    createdObjects.Add(newSpaceObject);
                    break;
                }
            case "AutoMantle":
            case "Mantle":
                {
                    i = 1;

                    position = Random.onUnitSphere * (20 + Random.Range(0, 0.5f));
                    newSpaceObject = Instantiate(Prefabs[i], position, Quaternion.identity) as GameObject;
                    newSpaceObject.transform.parent = spaceObjectContainer.transform;
                    createdObjects.Add(newSpaceObject);
                    break;
                }
            case "Crust":
            case "AutoCrust":
                {

                    i = 2;
                    position = Random.onUnitSphere * (30 + Random.Range(0, 0.5f));
                    newSpaceObject = Instantiate(Prefabs[i], position, Quaternion.identity) as GameObject;
                    newSpaceObject.transform.parent = spaceObjectContainer.transform;
                    createdObjects.Add(newSpaceObject);
                    break;
                }
        }


    }

}