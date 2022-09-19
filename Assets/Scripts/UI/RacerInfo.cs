using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class RacerInfo : MonoBehaviour {

    [SerializeField]
    TMP_Text titleText;

    [SerializeField]
    TMP_InputField impulseInput;

    [SerializeField]
    TMP_Text bioText;

    AnimalScriptableObject animalData;

    public void RePaint(AnimalScriptableObject animalData, int racerNumber) {
        this.animalData = animalData;
        titleText.text = animalData.racerNames[racerNumber];
        impulseInput.text = $"{animalData.impulse}";
        bioText.text = animalData.bio;
    }

    public RaceData.Racer GetRacerData() {
        RaceData.Racer racer = new RaceData.Racer();
        racer.RacerInfo = animalData;
        racer.RacerName = titleText.text;
        try {
            racer.RacerImpulse = float.Parse(impulseInput.text);
        } catch (FormatException) {
            racer.RacerImpulse = animalData.impulse;
        }
        return racer;    
    }
}
