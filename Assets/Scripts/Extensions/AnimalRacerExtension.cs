using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AnimalRacers;

namespace AnimalRacerExtensions {
    public static class AnimalRacerExtension {

        //POLYMORPHISM
        public static string RacerState(this AnimalRacer racer) {
            var rb = racer.GetComponent<Rigidbody>();
            return $"Impulse: {racer.Impulse}<br>"
                        + $"Mass: {rb.mass}<br>"
                        + $"Avg. Speed: {rb.velocity.x}<br>";
        }
    }
}