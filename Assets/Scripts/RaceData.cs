using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceData : MonoBehaviour {

    public static RaceData Instance { get; private set; }

    [SerializeReference]
    public Racer racer1;
    [SerializeReference]
    public Racer racer2;

    void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public class Racer {
        [field: SerializeField]
        public string RacerName { get; set; }
        [field: SerializeField]
        public float RacerImpulse { get; set; }
        [field: SerializeField]
        public AnimalScriptableObject RacerInfo { get; set; }
    }
}
