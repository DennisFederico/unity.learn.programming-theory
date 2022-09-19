using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AnimalRacers;
using AnimalRacerExtensions;

public class Track : MonoBehaviour {

    public Vector3 TrackStartPosition { get; private set; }
    public Vector3 TrackEndPosition { get; private set; }

    ParticleSystem fireworks;

    [SerializeField]
    AnimalRacer racer;

    [SerializeField]
    private TrackInfoPanel trackInfoPanel;

    void Awake() {
        TrackStartPosition = transform.Find("StartPosition").position;
        TrackEndPosition = transform.Find("FinishPosition").position;
        fireworks = GetComponentInChildren<ParticleSystem>();
        var trigger = GetComponentInChildren<FinishLineTrigger>();
        if (trigger != null) {
            trigger.OnFinishLine += OnTriggerExit;
        }
    }

    public void TrackRacer(AnimalRacer racer) {
        this.racer = racer;
        this.trackInfoPanel.DisplayRacerName(racer.RacerName);
        this.trackInfoPanel.DisplayRacerState(racer.RacerState());
    }

    void LateUpdate() {
        if (RaceManager.Instance.IsRaceOn && racer != null) {
            this.trackInfoPanel.DisplayRacerState(racer.RacerState());
        }
    }

    void OnTriggerExit(Collider other) {
        if (RaceManager.Instance.IsRaceOn) {            
            RaceManager.Instance.RacerFinish(this);
        }
    }

    public void DisplayWinner() {
        trackInfoPanel.DisplayWinner();
        fireworks.Play();
    }
}
