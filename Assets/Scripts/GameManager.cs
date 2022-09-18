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
        GameObject runner1 = Instantiate(runner1Prefab, track1.TrackStartPosition, runner1Prefab.transform.rotation);
        runner1.GetComponent<Animal>().SetDestination(track1.TrackEndPosition);

        GameObject runner2 = Instantiate(runner2Prefab, track2.TrackStartPosition, runner1Prefab.transform.rotation);
        runner2.GetComponent<Animal>().SetDestination(track2.TrackEndPosition);

        var pc = GetComponent<PlayerControl>();
        pc.runner1 = runner1.GetComponent<Rigidbody>();
        pc.runner2 = runner2.GetComponent<Rigidbody>();
    }
}

