using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Animals {
    public class Bird : Animal {
        [SerializeField]
        private float impulse = 10;

        public override void Move() {
            StartCoroutine(WingMove(animalRigidBody));
        }

        IEnumerator WingMove(Rigidbody rb) {
            while (true) {
                rb.AddForce(Vector3.right * impulse, ForceMode.Impulse);
                yield return new WaitForSeconds(1);
            }
        }
    }
}