using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrackInfoPanel : MonoBehaviour {
    [SerializeField]
    TMP_Text racerNameText;
    [SerializeField]
    TMP_Text racerStateText;
    [SerializeField]
    GameObject winnerBanner;
    
    public void DisplayRacerName(string racerName) {
        racerNameText.text = racerName;
    }

    public void DisplayRacerState(string state) {
        racerStateText.text = state;
    }

    public void DisplayWinner() {
        winnerBanner.SetActive(true);
    }
}
