using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class TitleManager : MonoBehaviour {

    public static TitleManager Instance { get; private set; }

    void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(this);
            return;
        }
        Instance = this;
    }

    [SerializeField]
    ToggleGroup toggleGroup1;
    [SerializeField]
    ToggleGroup toggleGroup2;

    [SerializeField]
    GameObject noRacerSelectedMessage;

    [SerializeField]
    RacerInfo racer1Info;

    [SerializeField]
    RacerInfo racer2Info;

    [SerializeField]
    Button startGameButton;

    void Start() {
        ValidateState();
    }

    public void Racer1Changed(AnimalScriptableObject racerData) {
        noRacerSelectedMessage.SetActive(false);
        racer1Info.RePaint(racerData, 0);
        racer1Info.gameObject.SetActive(true);
        ValidateState();
    }

    public void ClearRacer1() {
        racer1Info.gameObject.SetActive(false);
        ValidateState();
    }

    public void Racer2Changed(AnimalScriptableObject racerData) {
        noRacerSelectedMessage.SetActive(false);
        racer2Info.RePaint(racerData, 1);
        racer2Info.gameObject.SetActive(true);
        ValidateState();
    }

    public void ClearRacer2() {
        racer2Info.gameObject.SetActive(false);
        ValidateState();
    }

    void ValidateState() {    
        noRacerSelectedMessage.SetActive(toggleGroup1.GetFirstActiveToggle() == null && toggleGroup2.GetFirstActiveToggle() == null);
        startGameButton.interactable = toggleGroup1.GetFirstActiveToggle() != null && toggleGroup2.GetFirstActiveToggle() != null;
    }

    public void StartRace() {
        RaceData.Instance.racer1 = racer1Info.GetRacerData();
        RaceData.Instance.racer2 = racer2Info.GetRacerData();
        SceneManager.LoadScene("Scenes/RaceScene");
    }

    public void QuitGame() {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}
