using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planet : MonoBehaviour {

    [SerializeField] Image planetImage;
    [SerializeField] Text planetNameText;
    [SerializeField] Text planetTypeText;
    [SerializeField] Text planetSizeText;
    [SerializeField] Text planetQualityText;

    private string planetName;
    private string planetType;
    private string planetSize;
    private string planetQuality;

    public virtual void Start()
    {
        planetName = NewPlanet.GetPlanetName();
        gameObject.name = planetName;
        planetNameText.text = planetName;
    }
}
