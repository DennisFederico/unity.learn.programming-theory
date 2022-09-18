using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackInfo : MonoBehaviour {

    public Vector3 TrackStartPosition { get; private set; }
    public Vector3 TrackEndPosition { get; private set; }

    void Awake() {
        TrackStartPosition = transform.Find("StartPosition").position;
        TrackEndPosition = transform.Find("FinishPosition").position;
    }
}
