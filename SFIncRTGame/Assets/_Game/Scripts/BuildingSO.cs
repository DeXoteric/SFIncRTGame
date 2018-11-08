using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="New Building Template")]
public class BuildingSO : ScriptableObject {

    public string buildingName;
    public Sprite buildingImage;

    public float baseTimeToBuild;
    public float baseCostRes1;
    public float baseCostRes2;
    public float baseCostRes3;
    public float baseProduction;
}
