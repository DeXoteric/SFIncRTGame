using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateNewPlanet : MonoBehaviour {

    [SerializeField] GameObject planetTemplate;

    public void CreatePlanet()
    {
        var parentObject = FindObjectOfType<PlanetsPanel>().transform;
        GameObject newPlanet =  Instantiate(planetTemplate , parentObject);

        //newPlanet.name = NewPlanet.GetPlanetName();

        //var texts = newPlanet.GetComponentsInChildren<Text>();
        //texts[0].text = newPlanet.name;


    }
}
