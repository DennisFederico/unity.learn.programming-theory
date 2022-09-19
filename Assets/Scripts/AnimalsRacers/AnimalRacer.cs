using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnimalRacers {

    [RequireComponent(typeof(Rigidbody))]
    public abstract class AnimalRacer : MonoBehaviour {

        [field: SerializeField]
        public string RacerName {get; set; }

        [field: SerializeField]
        public float Impulse {get; set; }

        [field: SerializeField]
        protected Vector3 StartPosition { get; private set; }

        [field: SerializeField]
        protected Vector3 TargetPosition { get; private set; }

        protected Rigidbody racerRigidBody;
        
        void Awake() {
            racerRigidBody = GetComponent<Rigidbody>();
            StartPosition = transform.position;
        }

        public virtual void SetDestination(Vector3 destination) {
            TargetPosition = destination;
        }

        public abstract void Move();

        public abstract void Stop();
    }

}
