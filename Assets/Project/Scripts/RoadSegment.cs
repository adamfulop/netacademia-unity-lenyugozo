using Lean.Pool;
using UnityEngine;

public class RoadSegment : MonoBehaviour {
    private GameObject _car;

    private const float DestroyThreshold = -10;
    
    private void Awake() {
        _car = GameObject.FindGameObjectWithTag("Car");
    }

    private void Update() {
        if (transform.position.x - _car.transform.position.x < DestroyThreshold) {
            LeanPool.Despawn(gameObject);
        }
    }
}
