using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineTrigger : MonoBehaviour {

    public delegate void FinishLine(Collider collider);
    public event FinishLine OnFinishLine;

    void OnTriggerExit(Collider other) {
        if (OnFinishLine != null) {
            OnFinishLine(other);
        }
    }
}
