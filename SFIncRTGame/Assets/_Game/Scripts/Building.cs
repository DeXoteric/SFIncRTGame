using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour {

    [SerializeField] BuildingSO buildingData;

    [SerializeField] private Image image;
    [SerializeField] private Text nameText;
    [SerializeField] private Text amountText;
    [SerializeField] private Text buildCostText1;
    [SerializeField] private Text buildCostText2;
    [SerializeField] private Text buildCostText3;
    [SerializeField] private Text productionText;
    [SerializeField] private int initialAmount;

    
    private string buildingName;
    private int buildingAmount;
    private float buildingCost1;
    private float buildingCost2;
    private float buildingCost3;
    private float buildingProduction;

   

    private void Start()
    {
        image.sprite = buildingData.buildingImage;
        nameText.text = buildingData.buildingName;
        amountText.text = initialAmount.ToString();
        buildCostText1.text = buildingData.baseCostRes1.ToString();
        productionText.text = buildingData.baseProduction.ToString();

    }
}
