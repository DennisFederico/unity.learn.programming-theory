using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnimalRacers {

    [RequireComponent(typeof(Rigidbody))]
    public abstract class AnimalRacer : MonoBehaviour {
        //ABSTRACTION
        protected Rigidbody RacerRigidBody {get; private set; } //ENCAPSULATION
        public string RacerName {get; set; }
        public float Impulse {get; set; }
        
        void Awake() {
            RacerRigidBody = GetComponent<Rigidbody>();
        }

        public abstract void Move(); //POLIMORPHISM

        public virtual void Stop() { //ABSTRACTION
            StopAllCoroutines();
            RacerRigidBody.velocity = Vector3.right * 0.1f;
        }
    }

}
