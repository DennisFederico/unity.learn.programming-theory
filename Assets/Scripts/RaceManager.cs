using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using AnimalRacers;

public class RaceManager : MonoBehaviour {

    public static RaceManager Instance { get; private set; }

    [SerializeField]
    GameObject startButton;

    [SerializeField]
    GameObject backButton;

    [SerializeField]
    GameObject restartButton;

    [SerializeField]
    Track track1;
    [SerializeField]
    Track track2;

    [SerializeField]
    AnimalRacer racer1;
    [SerializeField]
    AnimalRacer racer2;

    public bool IsRaceOn { get; private set; }

    void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(this);
            return;
        }
        Instance = this;
        IsRaceOn = false;
    }

    void Start() {
        SpawnRacers();
    }

    void SpawnRacers() {
        var runner1 = AnimalScriptableObject.CreateAnimalRacer(RaceData.Instance.racer1, track1.TrackStartPosition);
        racer1 = runner1.GetComponent<AnimalRacer>();
        racer1.SetDestination(track1.TrackEndPosition);
        track1.TrackRacer(racer1);

        var runner2 = AnimalScriptableObject.CreateAnimalRacer(RaceData.Instance.racer2, track2.TrackStartPosition);
        racer2 = runner2.GetComponent<AnimalRacer>();
        racer2.SetDestination(track1.TrackEndPosition);
        track2.TrackRacer(racer2);

        var pc = GetComponent<MoveTester>();
        pc.runner1 = racer1;
        pc.runner2 = racer2;
    }

    public void StartRace() {
        startButton.SetActive(false);
        backButton.SetActive(true);
        restartButton.SetActive(true);

        racer1.Move();
        racer2.Move();
        IsRaceOn = true;
    }

    public void RacerFinish(Track track) {
        if (IsRaceOn) {
            IsRaceOn = false;
            track.DisplayWinner();
        }
        StopRace();
    }

    void StopRace() {
        racer1.Stop();
        racer2.Stop();
    }

    public void BackToMenu() {
        SceneManager.LoadScene("Scenes/Title");
    }

    public void Restart() {
        SceneManager.LoadScene("Scenes/RaceScene");
    }
}