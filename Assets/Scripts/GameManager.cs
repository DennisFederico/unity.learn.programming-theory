using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Animals;

public class GameManager : MonoBehaviour {

    public static GameManager Instance { get; private set; }

    [SerializeField]
    private TrackInfo track1;
    [SerializeField]
    private TrackInfo track2;

    [SerializeField]
    private GameObject runner1Prefab;
    [SerializeField]
    private GameObject runner2Prefab;

    void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(this);
            return;
        }
        Instance = this;        
    }

    void Start() {
        SpawnRunners(runner1Prefab, runner2Prefab);
    }

    void SpawnRunners(GameObject runner1Prefab, GameObject runner2Prefab) {

        var pc = GetComponent<MoveTester>();

        GameObject runnerObject1 = Instantiate(runner1Prefab, track1.TrackStartPosition, runner1Prefab.transform.rotation);
        var runner1 = runnerObject1.GetComponent<Animal>();
        runner1.SetDestination(track1.TrackEndPosition);
        pc.runner1 = runner1;

        GameObject runnerObject2 = Instantiate(runner2Prefab, track2.TrackStartPosition, runner1Prefab.transform.rotation);
        var runner2 = runnerObject2.GetComponent<Animal>();
        runner2.SetDestination(track2.TrackEndPosition);
        pc.runner2 = runner2;
    }
}

