using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RacerSelection : MonoBehaviour {

    [SerializeField]
    AnimalScriptableObject animalData;

    [SerializeField]
    TMP_Text racerName;
    [SerializeField]
    Image racerThumbnail;
    [SerializeField]
    Toggle racer1Toggle;
    [SerializeField]
    Toggle racer2Toggle;

    void Awake() {
        if (animalData != null) {
            racerName.text = animalData.animalName;
            racerThumbnail.sprite = animalData.thumbnail;

            racer1Toggle.onValueChanged.AddListener((value) => {
                if (!value) TitleManager.Instance.ClearRacer1();
                if (value) TitleManager.Instance.Racer1Changed(animalData);
            });

            racer2Toggle.onValueChanged.AddListener((value) => {
                if (!value) TitleManager.Instance.ClearRacer2(); 
                if (value) TitleManager.Instance.Racer2Changed(animalData);
            });
           
        } else {
            racerName.text = "Assign ScriptableObject Data";
        }
    }
}
